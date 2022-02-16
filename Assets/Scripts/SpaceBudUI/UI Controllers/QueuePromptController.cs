//Copyright © 2022 Alex Reid (R.M.P.)

//This file is part of Space Bud.

//Space Bud is free software: you can redistribute it and/or modify it
//under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License,
//or (at your option) any later version.

//Space Bud is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty
//of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
//See the GNU General Public License for more details.

//You should have received a copy of the GNU General Public
//License along with Space Bud. If not, see <https://www.gnu.org/licenses/>.

using UnityEngine;
using UnityEngine.UIElements;
using SpaceBudCore;
using SpaceBudData;


namespace SpaceBudUI
{
    public class QueuePromptController : MonoBehaviour
    {
        private Label patientNameText;

        private Button checkInButton;
        private Button cancelButton;

        private PatientStateData currentStateManager;
        private NewPatientTimer currentPatienceTimer;

        [SerializeField] private NewPatientListObject newPatientList;
        [SerializeField] private IntegerObject maxQueueListCountObject;
        [SerializeField] private IntegerObject queueListCountObj;

        private PanelSwitcher _panelSwitcher;
        private GameObject _gameObject;
        private VisualElement _rootVisualElement;

        private void Awake()
        {
            _panelSwitcher = GetComponent<PanelSwitcher>();
            _gameObject = gameObject;
            PatientSaleEventManager.OnPatientClick += OpenCheckInPrompt;
        }
       
        private void OnEnable()
        {
            _rootVisualElement = GetComponent<UIDocument>().rootVisualElement;
            checkInButton = _rootVisualElement.Q<Button>("add-to-queue-button");
            cancelButton = _rootVisualElement.Q<Button>("back-button");
            patientNameText = _rootVisualElement.Q<Label>("label");

            checkInButton.RegisterCallback<ClickEvent>(ev => CompleteCheckIn());
            cancelButton.RegisterCallback<ClickEvent>(ev => ExitCheckInPrompt());

        }
        private void OnApplicationQuit()
        {
            PatientSaleEventManager.OnPatientClick -= OpenCheckInPrompt;
        }

        private void Start()
        {
            gameObject.SetActive(false);
        }

        public void OpenCheckInPrompt()
        {
            if (newPatientList.patientObjectsList != null && queueListCountObj.value < maxQueueListCountObject.value)
            {
                PatientSaleEventManager.OpenedCheckInPrompt();
                _panelSwitcher.SwitchPanels(_gameObject, true);

                var activePatient = newPatientList.activePatient;
                currentStateManager = activePatient.GetComponent<PatientStateData>();
                currentPatienceTimer = activePatient.GetComponent<NewPatientTimer>();
                
                currentPatienceTimer.isTimerOn = false;

                var patientName = activePatient.GetComponent<PatientInformationBase>().patientName;
                
                patientNameText.text = "Add " + patientName + " to queue?";

            }
            else
            {
                Debug.Log("The queue is packed!");
            }
        }

        public void ExitCheckInPrompt()
        {
            currentPatienceTimer.isTimerOn = true;
            currentPatienceTimer.StartTimer();
            PatientSaleEventManager.CanceledCheckIn();
            currentStateManager.SwitchState(SaleState.NewPatientState);
            _panelSwitcher.DeactivatePanel(_gameObject, true);
        }

        public void CompleteCheckIn()
        {
            queueListCountObj.value++;
            PatientSaleEventManager.CheckInComplete();
            UIEventsManager.GameOverlayNeedsUpdate();
            currentStateManager.SwitchState(SaleState.CheckedInState);
            _panelSwitcher.DeactivatePanel(_gameObject, true);
        }
    }
}

