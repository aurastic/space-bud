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
using UnityEngine.AI;
using SpaceBudCore;
using System.Collections;

namespace SpaceBudData
{
    public class PatientMovement : MonoBehaviour
    {
        private NavMeshAgent patientAgent;
        private Vector3 shopExit;
        private PatientInformationBase patientInfo;
        private PatientStateData stateManager;
        private int waitToDisappear;
        [SerializeField] private PlaceHolderListObject listObject;
        [SerializeField] private NewPatientListObject newPatientListObject;

        private void OnEnable()
        {
            waitToDisappear = 5;
            shopExit = new Vector3(-5.8f, 0.5f, 9.5f);
            patientAgent = gameObject.GetComponent<NavMeshAgent>();
            patientInfo = gameObject.GetComponent<PatientInformationBase>();
            stateManager = gameObject.GetComponent<PatientStateData>();
            
            PatientSaleEventManager.OnCheckIn += MoveForwardInLine;
            PatientSaleEventManager.PatientLeftEarly += MoveForwardMidLine;
            
        }

        private void OnDisable()
        {
           
            PatientSaleEventManager.OnCheckIn -= MoveForwardInLine;
            PatientSaleEventManager.PatientLeftEarly -= MoveForwardMidLine;
        }

        private void MoveToWaitingRoom()
        {
            patientAgent.destination = new Vector3(0, 1, Random.Range(5, 7));

        }

        private void Leave()
        {
            patientAgent.destination = shopExit;

            StartCoroutine(PatientLeavingCoroutine());
        }

        private void Freeze()
        {
            patientAgent.isStopped = true;
        }

        public void UpdateMovement()
        {
            var currentState = stateManager.currentState;

            if(currentState == SaleState.PendingCheckInState)
            {
               Freeze();
            }
            else if(currentState == SaleState.LeavingState)
            {
                Leave();
            }
            else if(currentState == SaleState.CheckedInState)
            {
                MoveToWaitingRoom();
            }
            
        }
        
        private IEnumerator PatientLeavingCoroutine()
        {

            while(waitToDisappear > 0)
            {
                waitToDisappear--;
                Debug.Log(waitToDisappear);
                yield return new WaitForSeconds(1);
            }

            HidePatient();
            yield break;
        }

        private void HidePatient()
        {
            StopAllCoroutines();
            Debug.Log("Patient reached exit. Leaving.");
            gameObject.SetActive(false);
        }

        private void MoveForwardInLine()
        {
            var currentPlace = patientInfo.currentPlaceInLine;

            if (currentPlace > 0)
            {
                var newPlace = currentPlace --;

                if (newPlace <= listObject.list.Count - 1)
                {

                    Debug.Log("Moving forward in line.");
                    patientAgent.destination = listObject.list[newPlace].placeholderObject.transform.position;
                }
                
            }
            
        }

        private void MoveForwardMidLine(object sender, PatientSaleEventManager.IntegerEventArgs args)
        {
            if (stateManager.currentState == SaleState.NewPatientState)
            {
                var newPlace = newPatientListObject.patientObjectsList.LastIndexOf(gameObject);
                stateManager.currentPlaceInLine = newPlace;
                Debug.Log("new place: " + newPlace);

                if (newPlace <= listObject.list.Count - 1 && newPlace <= 0)
                    {
                        Debug.Log("Moving forward in line.");
                        patientAgent.SetDestination(listObject.list[newPlace].placeholderObject.transform.position);
                    }

            }
        }
    }
}


