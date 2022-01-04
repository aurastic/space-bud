using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BudShopData;
using BudShopCore;


namespace BudShopInteraction
{
    public class PatientInteractiveBase : MonoBehaviour, IInteractive
    {

        private PatientStateData stateManager;
        public GameEvent clickedOnPatient;

        [SerializeField] private NewPatientListObject newPatientList;

        public void OnEnable()
        {
            stateManager = this.GetComponent<PatientStateData>();
        }

        public void OnInteract()
        {
            if (newPatientList.patientObjectsList.Count > 0)
            {
                if (stateManager.currentState == SaleState.NewPatientState && this.gameObject == newPatientList.activePatient)
                {


                    clickedOnPatient.RaiseEvent();
                    stateManager.SwitchState(SaleState.PendingCheckInState);


                }
                else if(stateManager.currentState == SaleState.NewPatientState && this.gameObject != newPatientList.activePatient)
                {
                    Debug.Log("This is not the first patient to arrive.");
                }


            }
            else
            {
                Debug.Log("Patient already checked in.");
            }

        }
    }
}

