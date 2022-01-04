using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BudShopData
{
    [CreateAssetMenu(fileName = "New Patient List", menuName = "Basic Scriptable Object Data/List/Patient List")]
    public class NewPatientListObject : ScriptableObject
    {
        public List<PatientInformationBase> patientInformationList;
        public List<GameObject> patientObjectsList;
        public List<string> patientNameList;
        public GameObject activePatient;
        public string activePatientName;

        public void UpdateListData(string listID)
        {

            patientInformationList.Clear();
            patientNameList.Clear();

            if (patientObjectsList.Count > 0)
            {
                Debug.Log(listID + "count: " + patientObjectsList.Count);

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

