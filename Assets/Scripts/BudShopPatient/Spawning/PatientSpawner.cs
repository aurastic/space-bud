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
using BudShopData;
using BudShopCore;

namespace BudShopPatient
{
    public class PatientSpawner : MonoBehaviour
    {
       

        [SerializeField] private IntegerObject newPatients;


        [SerializeField] private GameEvent newpatientEvent;
        [SerializeField] private GameEvent updateUI;
        [SerializeField] private NewPatientListObject spawnedPatients;

        [SerializeField] private IntegerObject newPatientListMaxCount;

        // [SerializeField] private ObjectScriptableObject activePatient;

        private int spawnDelay;

        private readonly int minDownTime = 5;
        private readonly int maxDownTime = 10;
        private readonly float sB = -5f;
        private readonly float nB = 1f;
        private readonly float eB = -2f;
        private readonly float wB = -5f;


        // Start is called before the first frame update
        private void Start()
        {

            Invoke("SpawnNewPatient", 5);

        }

        public void StartSpawning()
        {
            if (newPatients.value < newPatientListMaxCount.value)
            {
                var time = Random.Range(minDownTime, maxDownTime);
                Invoke("SpawnNewPatient", time);
            }

        }

        private void SpawnNewPatient()
        {
            var spawnLocation = new Vector3(Random.Range(wB, eB), 1, Random.Range(sB, nB));
            //int patientTypeIndex = Random.Range(0, patientPrefabs.Length);


            // var newPatient = Instantiate(patientPrefabs[patientTypeIndex], spawnLocation, Quaternion.identity);
            GameObject patient = PatientPool.patientPool.GetPooledPatient();

            if (patient != null)
            {
                patient.transform.position = spawnLocation;
                patient.transform.rotation = Quaternion.identity;
                patient.SetActive(true);
                var patientCard = patient.GetComponent<PatientInformationBase>();
                var patientStateManager = patient.GetComponent<PatientStateData>();
                var timer = patient.GetComponent<NewPatientTimer>();
                spawnedPatients.patientObjectsList.Add(patient);
                Debug.Log(patientCard.patientName + ", " + patientCard.gender + ", " + patientCard.age + ", " + patientCard.patientType + ", " + patientCard.favoriteStrain);
                spawnedPatients.UpdateListData("New Patient List");
                patientStateManager.SwitchState(SaleState.NewPatientState);
                timer.StartCoroutine(timer.PatientPatience());
                spawnDelay = Random.Range(minDownTime, maxDownTime);

                AddNewPatientValue();

                newpatientEvent.RaiseEvent();
                updateUI.RaiseEvent();

                if (newPatients.value < newPatientListMaxCount.value)
                {
                    Invoke("SpawnNewPatient", spawnDelay);
                }
            }
            else
            {
                Debug.Log("no more in pool");
            }



        }

        private void AddNewPatientValue()
        {
            newPatients.value += 1;

        }

        private void OnApplicationQuit()
        {
            newPatients.value = 0;
        }
    }
}

