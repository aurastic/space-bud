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
using UnityEngine.AI;

namespace SpaceBudPatient
{
    public class WanderAI : MonoBehaviour
    {
        private Vector3 currentDestination;
        private NavMeshAgent agent;
        private int waitTime = 20;
        
        public bool isWandering = false;
        private int wB = 0;
        private int eB = -7;
        private int nB = 4;
        private int sB = 7;

        private void OnEnable()
        {
            agent = GetComponent<NavMeshAgent>();
            
        }


        private void PickNewDestination()
        {
            int lon = Random.Range(wB, eB);
            int lat = Random.Range(sB, nB);
            currentDestination = new Vector3(lon, 1, lat);
            agent.destination = currentDestination;

        }

        public IEnumerator WanderCoroutine()
        {
            while(isWandering)
            {
                PickNewDestination();
                yield return new WaitForSeconds(waitTime);
            }

            Debug.Log("Stopped wandering.");
            yield break;
        }

        private void OnApplicationQuit()
        {
            StopAllCoroutines();
        }
    }
}

