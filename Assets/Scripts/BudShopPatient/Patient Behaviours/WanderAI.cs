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

namespace BudShopPatient
{
    public class WanderAI : MonoBehaviour
    {
        public float moveSpeed = 2f;
        public float rotSpeed = 200f;
        private bool isWandering = false;
        private bool isRotatingLeft = false;
        private bool isRotatingRight = false;
        private bool isWalking = false;


        private float sB = -5f;
        private float nB = 1f;
        private float eB = -2f;
        private float wB = -5f;


        //private Collider personalSpaceCollider;

        private void OnEnable()
        {
            //personalSpaceCollider = this.GetComponentInChildren<Collider>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            this.gameObject.transform.Rotate(0, 0, 180);
        }
        void Update()
        {
            if (transform.position.x < wB)
            {
                transform.position = new Vector3(wB, transform.position.y, transform.position.z);
            }
            if (transform.position.x > eB)
            {
                transform.position = new Vector3(eB, transform.position.y, transform.position.z);
            }
            if (transform.position.z > nB)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, nB);
            }
            if (transform.position.z < sB)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, sB);
            }

            if (!isWandering)
            {
                StartCoroutine(Wander());
            }

            if (isRotatingRight == true)
            {
                transform.Rotate(transform.up * Time.deltaTime * rotSpeed);
            }

            if (isRotatingLeft == true)
            {
                transform.Rotate(transform.up * Time.deltaTime * -rotSpeed);
            }
            if (isWalking == true)
            {
                transform.Translate(transform.forward * moveSpeed * Time.deltaTime);
            }

            IEnumerator Wander()
            {
                int rotDuration = Random.Range(1, 3);
                int rotWait = Random.Range(1, 3);
                int rotateLorR = Random.Range(1, 2);
                int walkWait = Random.Range(1, 5);
                int walkTime = Random.Range(1, 2);

                isWandering = true;

                yield return new WaitForSeconds(walkWait);
                isWalking = true;
                yield return new WaitForSeconds(walkTime);
                isWalking = false;
                yield return new WaitForSeconds(rotWait);

                if (rotateLorR == 1)
                {
                    isRotatingRight = true;
                    yield return new WaitForSeconds(rotDuration);
                    isRotatingRight = false;
                }
                if (rotateLorR == 2)
                {
                    isRotatingLeft = true;
                    yield return new WaitForSeconds(rotDuration);
                    isRotatingLeft = false;
                }
                isWandering = false;
            }
        }

    }
}

