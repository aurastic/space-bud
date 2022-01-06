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


