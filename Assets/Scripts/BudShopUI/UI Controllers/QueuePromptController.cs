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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using BudShopCore;
using BudShopData;


namespace BudShopUI
{
    public class QueuePromptController : MonoBehaviour
    {
        private Label patientNameText;


        private Button checkInButton;
        private Button cancelButton;

        [SerializeField] private GameEvent checkInComplete;
        [SerializeField] private GameEvent canceledCheckIn;
        [SerializeField] private GameEvent updateUI;

       
        private PatientStateData currentStateManager;
        private NewPatientTimer currentPatienceTimer;


        [SerializeField] private NewPatientListObject newPatientList;
    
        [SerializeField] private IntegerObject maxQueueListCountObject;
        [SerializeField] private IntegerObject queueListCountObj;

        private SwitchPanelsStatic _panelSwitcher;
        private GameObject _gameObject;
        private VisualElement _rootVisualElement;

        private void Awake()
        {
            _panelSwitcher = GetComponent<SwitchPanelsStatic>();
            _gameObject = gameObject;
            
        }
        private void Start()
        {
            this.gameObject.SetActive(false);
        }
        public void OnEnable()
        {
            _rootVisualElement = GetComponent<UIDocument>().rootVisualElement;
            checkInButton = _rootVisualElement.Q<Button>("add-to-queue-button");
            cancelButton = _rootVisualElement.Q<Button>("back-button");
            patientNameText = _rootVisualElement.Q<Label>("label");

            checkInButton.RegisterCallback<ClickEvent>(ev => CompleteCheckIn());
            cancelButton.RegisterCallback<ClickEvent>(ev => ExitCheckInPrompt());

        }

        public void OpenCheckInPrompt()
        {
            if (newPatientList.patientObjectsList != null && queueListCountObj.value < maxQueueListCountObject.value)
            {
                Debug.Log("test");
                
                
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
            canceledCheckIn.RaiseEvent();
            currentStateManager.SwitchState(SaleState.NewPatientState);
            _panelSwitcher.DeactivatePanel(_gameObject, true);
        }

        public void CompleteCheckIn()
        {
            queueListCountObj.value++;
            checkInComplete.RaiseEvent();
            updateUI.RaiseEvent();
            currentStateManager.SwitchState(SaleState.CheckedInState);
            _panelSwitcher.DeactivatePanel(_gameObject, true);
        }
    }
}

