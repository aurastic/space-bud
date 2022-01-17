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
using SpaceBudData;

namespace SpaceBudPatient
{
    public class PatientPool : MonoBehaviour
    {
        public static PatientPool patientPool;
        public List<GameObject> pooledPatients;
        public GameObject patientPrefab;
        private int amountToPool;
        [SerializeField] private IntegerObject queueListMaxCount;
        [SerializeField] private IntegerObject newPatientListMaxCount;
        private void Awake()
        {
            patientPool = this;
        }

        private void Start()
        {

            amountToPool = queueListMaxCount.value + newPatientListMaxCount.value;
            pooledPatients = new List<GameObject>();
            GameObject pt;
            for (int i = 0; i < amountToPool; i++)
            {
                pt = Instantiate(patientPrefab);
                pt.SetActive(false);
                pooledPatients.Add(pt);

            }
        }

        public GameObject GetPooledPatient()
        {
            for (int i = 0; i < amountToPool; i++)
            {
                if (!pooledPatients[i].activeInHierarchy)
                {
                    return pooledPatients[i];
                }
            }
            return null;
        }
    }
}

