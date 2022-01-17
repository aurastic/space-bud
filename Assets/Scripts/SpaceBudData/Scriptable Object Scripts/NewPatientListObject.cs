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

using System.Collections.Generic;
using UnityEngine;

namespace SpaceBudData
{
    [CreateAssetMenu(fileName = "New Patient List", menuName = "Basic Scriptable Object Data/List/Patient List")]
    public class NewPatientListObject : ScriptableObject
    {
        public List<PatientInformationBase> patientInformationList;
        public List<GameObject> patientObjectsList;
        public List<string> patientNameList;
        public GameObject activePatient;
        public string activePatientName;

        public void UpdateListData(NewPatientListObject list)
        {

            patientInformationList.Clear();
            patientNameList.Clear();

            if (patientObjectsList.Count > 0)
            {
                Debug.Log(list + "count: " + patientObjectsList.Count);

                for (int i = 0; i < patientObjectsList.Count; i++)
                {
                    var informationBase = patientObjectsList[i].GetComponent<PatientInformationBase>();
                    var patientName = informationBase.patientName;

                    patientNameList.Add(patientName);
                    patientInformationList.Add(informationBase);
                }
                activePatient = patientObjectsList[0];
                activePatientName = patientNameList[0];
            }

            else
            {
                Debug.Log("No new patient data for list.");
            }


        }
        public void ClearList()
        {
            patientObjectsList.Clear();
            patientInformationList.Clear();
            patientNameList.Clear();


        }

    }
}

