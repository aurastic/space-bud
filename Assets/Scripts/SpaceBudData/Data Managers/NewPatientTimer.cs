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
using UnityEngine;
using SpaceBudCore;


namespace SpaceBudData
{
    public class NewPatientTimer : MonoBehaviour
    {
        private string patientName;

        public bool isTimerOn = true;

        private int patience;
        [SerializeField] private IntegerObject newPatients;
        [SerializeField] private NewPatientListObject spawnedPatients;
        [SerializeField] private ActionLogObject logObject;
        
        private PatientStateData stateManager;


        private void OnEnable()
        {
            patientName = gameObject.GetComponent<PatientInformationBase>().patientName;
            stateManager = gameObject.GetComponent<PatientStateData>();
            patience = Random.Range(10, 60);
            
        }


        public IEnumerator PatientPatience()
        {

            while (isTimerOn && patience > 0)
            {
                patience--;
                //Debug.Log(patience);
                
                yield return new WaitForSeconds(1);
            }

            if(patience == 0)
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
            StopCoroutine(PatientPatience());
            var actionLogEntry = new ActionLogEntry(5, LogEntryType.Review, "I've been waiting too long!!!! BYE ", ptName);
            logObject.actionLog.Add(actionLogEntry);
            newPatients.value--;

            spawnedPatients.patientObjectsList.Remove(gameObject);
            spawnedPatients.UpdateListData(spawnedPatients);
            stateManager.SwitchState(SaleState.LeavingState);
            var indexArg = new PatientSaleEventManager.IntegerEventArgs(stateManager.currentPlaceInLine);
            PatientSaleEventManager.OnPatientLeftEarly(this, indexArg);
            UIEventsManager.GameOverlayNeedsUpdate();
            UIEventsManager.AddedToActionLog();
            
           
           
        }

        public void StartTimer()
        {
            StartCoroutine(PatientPatience());
        }
    }
}

