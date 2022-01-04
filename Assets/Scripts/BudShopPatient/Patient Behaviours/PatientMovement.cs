using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using BudShopData;

namespace BudShopPatient
{
    public class PatientMovement : MonoBehaviour
    {


        private NavMeshAgent patientAgent;
        private WanderAI wanderWalk;

        private PatientStateData stateManager;




        private void OnEnable()
        {
            patientAgent = this.gameObject.GetComponent<NavMeshAgent>();

            wanderWalk = this.gameObject.GetComponent<WanderAI>();
            stateManager = this.gameObject.GetComponent<PatientStateData>();
        }

        public void UpdateMovementType()
        {
            if (stateManager.currentState == SaleState.PendingCheckInState)
            {
                StopWandering();
            }

            if (stateManager.currentState == SaleState.NewPatientState)
            {
                ResumeWandering();
            }

            if (stateManager.currentState == SaleState.CheckedInState)
            {
                StopWandering();
                patientAgent.enabled = true;
                patientAgent.destination = new Vector3(0, 1, Random.Range(5, 7));

            }
        }


        public void StopWandering()
        {
            wanderWalk.enabled = false;
        }

        public void ResumeWandering()
        {
            wanderWalk.enabled = true;
        }




    }
}


