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


        [SerializeField] private NewPatientListObject newPatientList;
        [SerializeField] private NewPatientListObject queueList;
        [SerializeField] private IntegerObject maxQueueListCountObject;

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
            if (newPatientList.patientObjectsList != null && queueList.patientObjectsList.Count <= maxQueueListCountObject.value)
            {
                Debug.Log("test");

                _panelSwitcher.SwitchPanels(_gameObject, true);

                var activePatient = newPatientList.activePatient;
                currentStateManager = activePatient.GetComponent<PatientStateData>();
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
            canceledCheckIn.RaiseEvent();
            currentStateManager.SwitchState(SaleState.NewPatientState);
            _panelSwitcher.DeactivatePanel(_gameObject, true);
        }

        public void CompleteCheckIn()
        {
            checkInComplete.RaiseEvent();
            updateUI.RaiseEvent();
            currentStateManager.SwitchState(SaleState.CheckedInState);
            _panelSwitcher.DeactivatePanel(_gameObject, true);
        }
    }
}

