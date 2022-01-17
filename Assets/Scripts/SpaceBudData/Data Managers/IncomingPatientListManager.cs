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

namespace SpaceBudData
{
    public class IncomingPatientListManager : MonoBehaviour
    {
        [SerializeField] private NewPatientListObject newPatientList;
        [SerializeField] private NewPatientListObject queueList;
        [SerializeField] private IntegerObject newPatientCount;
        [SerializeField] private IntegerObject queueCount;

        private void Start()
        {
            newPatientList.ClearList();
            queueList.ClearList();

        }

        public void MovePatientToQueue()
        {
            var patient = newPatientList.patientObjectsList[0];


            queueList.patientObjectsList.Add(patient);
            queueList.UpdateListData(queueList);

            newPatientList.patientObjectsList.Remove(patient);
            newPatientList.UpdateListData(newPatientList);


            newPatientCount.value -= 1;

        }

        public void RemoveFromQueue()
        {
            queueList.patientObjectsList.Remove(queueList.patientObjectsList[0]);

        }

        private void OnApplicationQuit()
        {
            newPatientCount.value = 0;
            queueCount.value = 0;
        }
    }

}
