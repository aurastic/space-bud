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
using SpaceBudData;
using SpaceBudCore;
using System.Collections;

namespace SpaceBudPatient
{
    public class PatientMovement : MonoBehaviour
    {
        private NavMeshAgent patientAgent;
        private WanderAI wanderWalk;
        private Vector3 shopExit;
        private PatientStateData stateManager;
        private int waitToDisappear;

        private void OnEnable()
        {
            waitToDisappear = 5;
            shopExit = new Vector3(-5.8f, 0.5f, 9.5f);
            patientAgent = gameObject.GetComponent<NavMeshAgent>();
            wanderWalk = gameObject.GetComponent<WanderAI>();
            stateManager = gameObject.GetComponent<PatientStateData>();

            PatientSaleEventManager.OnSaleStateChange += UpdateMovementType;
        }

        private void OnDisable()
        {
            PatientSaleEventManager.OnSaleStateChange -= UpdateMovementType;
        }

        public void UpdateMovementType()
        {
            if (stateManager.currentState == SaleState.PendingCheckInState)
            {
                wanderWalk.isWandering = false;
                
            }

            else if (stateManager.currentState == SaleState.NewPatientState)
            {
                wanderWalk.isWandering = true;
                wanderWalk.StartCoroutine(wanderWalk.WanderCoroutine());
            }

            else if (stateManager.currentState == SaleState.CheckedInState)
            {
                wanderWalk.isWandering = false;
                patientAgent.destination = new Vector3(0, 1, Random.Range(5, 7));

            }

            else if (stateManager.currentState == SaleState.LeavingState)
            {
                wanderWalk.isWandering = false;
                patientAgent.destination = shopExit;
                StartCoroutine(PatientLeavingCoroutine());
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
            stateManager.SwitchState(SaleState.HiddenInPoolState);
            Debug.Log("Patient reached exit. Leaving.");
            gameObject.SetActive(false);
        }
    }
}


