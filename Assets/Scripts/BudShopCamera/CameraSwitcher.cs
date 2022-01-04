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

