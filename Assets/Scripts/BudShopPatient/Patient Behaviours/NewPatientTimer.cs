using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BudShopData;
using BudShopCore;


namespace BudShopPatient
{
    public class NewPatientTimer : MonoBehaviour
    {
        private string patientName;
        private int patience;
        private PatientStateData stateManager;

        [SerializeField] private IntegerObject newPatients;
        [SerializeField] private NewPatientListObject spawnedPatients;

        [SerializeField] private GameEvent updateUI;
        [SerializeField] private GameEvent patientLeftEarly;


        void OnEnable()
        {
            patientName = this.gameObject.GetComponent<PatientInformationBase>().patientName;
            stateManager = this.gameObject.GetComponent<PatientStateData>();
            patience = Random.Range(10, 60);
        }
        public IEnumerator PatientPatience()
        {
            var state = stateManager.currentState;

            while (state == SaleState.NewPatientState && patience > 0)
            {

                patience--;
                Debug.Log(patience);
                state = stateManager.currentState;
                yield return new WaitForSeconds(1f);
            }

            if (state != SaleState.PendingCheckInState)
            {
                PatienceRanOut(patientName);
                yield break;
            }
            else
            {
                yield break;
            }

        }

        void PatienceRanOut(string ptName)
        {

            Debug.Log("I've been waiting too long!!!! BYE ");
            Debug.Log(ptName + " left.");
            newPatients.value--;
            spawnedPatients.patientObjectsList.Remove(this.gameObject);
            patientLeftEarly.RaiseEvent();
            updateUI.RaiseEvent();
            this.gameObject.SetActive(false);

        }
    }
}

