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
using SpaceBudCore;

namespace SpaceBudArt
{
    public class ShopAnimationMechanics : MonoBehaviour
    {

        [SerializeField] private GameObject door;
        private Animator doorAnimator;


        private void OnEnable()
        {
            doorAnimator = door.GetComponent<Animator>();
            PatientSaleEventManager.OnNewPatient += OpenDoors;
        }

        private void OnDisable()
        {
            PatientSaleEventManager.OnNewPatient -= OpenDoors;
        }

        public void OpenDoors()
        {
            doorAnimator.Play("opening");

            doorAnimator.Play("closed");
            //otherdoorAnimator.Play("closed");
            // otherdoorAnimator.Play()

            //StartCoroutine(DoorTimer());
        }

        //IEnumerator DoorTimer()
        //{
        // int doorTime = 3;
        // while(doorTime > 0)
        //{
        // doorTime--;
        // Debug.Log(doorTime);
        // yield return new WaitForSecondsRealtime(1);
        // }

        //   leftAnimator.Play("closed");
        //  StopCoroutine(DoorTimer());

        // }

    }
}

