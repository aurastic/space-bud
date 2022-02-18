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
using SpaceBudData;
using SpaceBudCore;
using UnityEngine.AI;

namespace SpaceBudPatient
{
    public class PatientSpawner : MonoBehaviour
    {
        [SerializeField] private IntegerObject newPatients;

        [SerializeField] private NewPatientListObject spawnedPatients;

        [SerializeField] private IntegerObject newPatientListMaxCount;

        [SerializeField] private PlaceHolderListObject listObject;

        private int waitToSpawn = 3;
        private int checkIndex;
        private readonly int minDownTime = 5;
        private readonly int maxDownTime = 10;
        private readonly float sB = -5f;
        private readonly float nB = 1f;
        private readonly float eB = -2f;
        private readonly float wB = -5f;

        private void Start()
        {
            Invoke("SpawnNewPatient", 5);
        }

        private void StartSpawning()
        {
            if (newPatients.value < newPatientListMaxCount.value)
            {
                //Debug.Log("spawn possible. will spawn after random time.");
                var time = Random.Range(minDownTime, maxDownTime);
                Invoke("SpawnNewPatient", time);
            }

            else
            {
                StartCoroutine(WaitToSpawn());
            }
        }

        private void SpawnNewPatient()
        {
            var spawnLocation = new Vector3(Random.Range(wB, eB), 1, Random.Range(sB, nB));
            
            GameObject patient = PatientPool.patientPool.GetPooledPatient();

            if (patient != null)
            {
                patient.transform.SetPositionAndRotation(spawnLocation, Quaternion.identity);
                patient.SetActive(true);

                var patientStateManager = patient.GetComponent<PatientStateData>();
                patientStateManager.SwitchState(SaleState.NewPatientState);

                var patientCard = patient.GetComponent<PatientInformationBase>();
                Debug.Log(patientCard.patientName + ", " + patientCard.gender + ", " + patientCard.age + ", " + patientCard.patientType + ", " + patientCard.favoriteStrain);

                
                var timer = patient.GetComponent<NewPatientTimer>();
                timer.StartCoroutine(timer.PatientPatience());

                var patientAgent = patient.GetComponent<NavMeshAgent>();
                
                spawnedPatients.patientObjectsList.Add(patient);
                var place = spawnedPatients.patientObjectsList.LastIndexOf(patient);
                patientStateManager.currentPlaceInLine = place;
                Debug.Log(place.ToString() + " in line.");

                if (place <= listObject.list.Count - 1)
                {
                    patientAgent.destination = listObject.list[place].placeholderObject.transform.position;
                    
                }
                spawnedPatients.UpdateListData(spawnedPatients);

                AddNewPatientValue();

                PatientSaleEventManager.NewPatient();
                UIEventsManager.GameOverlayNeedsUpdate();

                StartCoroutine(WaitToSpawn());
            }

            else
            {
                Debug.Log("No more in pool");
            }
        }

      

        private IEnumerator WaitToSpawn()
        {
            while (waitToSpawn >= 0)
            {
                //Debug.Log("spawn wait" + waitToSpawn);
                waitToSpawn--;
                yield return new WaitForSeconds(1);
            }

            waitToSpawn = 3;
            //Debug.Log("sent request to start spawning if possible");
            StartSpawning();
            yield break;
        }

        private void AddNewPatientValue()
        {
            newPatients.value += 1;
        }

        private void OnApplicationQuit()
        {
            StopAllCoroutines();
        }

    }
}

