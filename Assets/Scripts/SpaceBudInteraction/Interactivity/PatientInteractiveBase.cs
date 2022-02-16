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
using SpaceBudData;
using SpaceBudCore;


namespace SpaceBudInteraction
{
    public class PatientInteractiveBase : MonoBehaviour, IInteractive
    {
        private PatientStateData stateManager;
       
        [SerializeField] private NewPatientListObject newPatientList;

        public void OnEnable()
        {
            stateManager = GetComponent<PatientStateData>();
        }

        public void OnInteract()
        {
            if (newPatientList.patientObjectsList.Count > 0)
            {
                if (stateManager.currentState == SaleState.NewPatientState && this.gameObject == newPatientList.activePatient)
                {
                    PatientSaleEventManager.ClickedOnPatient();
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

