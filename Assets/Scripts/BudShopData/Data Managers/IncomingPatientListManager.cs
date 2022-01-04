using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace BudShopData
{
    public class IncomingPatientListManager : MonoBehaviour
    {
        [SerializeField] private NewPatientListObject newPatientList;
        [SerializeField] private NewPatientListObject queueList;
        [SerializeField] private IntegerObject newPatientCount;

        private void Start()
        {
            newPatientList.ClearList();
            queueList.ClearList();

        }

        public void MovePatientToQueue()
        {
            var patient = newPatientList.patientObjectsList[0];


            queueList.patientObjectsList.Add(newPatientList.patientObjectsList[0]);
            queueList.UpdateListData("Queue List");

            newPatientList.patientObjectsList.Remove(newPatientList.patientObjectsList[0]);
            newPatientList.UpdateListData("New Patient List");


            newPatientCount.value -= 1;



        }


        public void RemoveFromQueue()
        {
            queueList.patientObjectsList.Remove(queueList.patientObjectsList[0]);

        }

    }

}
