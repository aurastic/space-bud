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

using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BudShopData;

namespace BudShopCamera
{
    public class CameraSwitcher : MonoBehaviour
    {
        private Animator animator;

        //[SerializeField] private GameObject patientCam;


        private CinemachineTargetGroup targetGroup;
        [SerializeField] private GameObject targetGroupObject;
        [SerializeField] private NewPatientListObject newPatientList;

        private void Awake()
        {
            animator = this.GetComponent<Animator>();
        }

        public void PatientInteractionCamera()
        {
            targetGroup = targetGroupObject.GetComponent<CinemachineTargetGroup>();
            targetGroup.AddMember(newPatientList.activePatient.transform, 1, 0.5f);
            // var vcam = patientCam.GetComponent<CinemachineVirtualCamera>();
            // vcam.LookAt = targetGroup.transform;
            //vcam.Follow = targetGroup.transform;
            animator.Play("patient interaction");


        }

        public void IdleCamera()
        {
            ClearTarget(newPatientList.activePatient.transform);
            animator.Play("idle");

        }

        public void ClearTarget(Transform target)
        {
            targetGroup.RemoveMember(target);
        }

    }
}

