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
using UnityEngine;
using SpaceBudCore;
using SpaceBudData;

namespace SpaceBudCamera
{
    public class CameraSwitcher : MonoBehaviour
    {
        private Animator animator;

        private CinemachineTargetGroup checkInTargetGroup;
        private CinemachineTargetGroup interactionTargetGroup;

        [SerializeField] private GameObject checkInTargetGroupObject;
        [SerializeField] private GameObject interactionTargetGroupObject;

        [SerializeField] private NewPatientListObject newPatientList;
        

        private void Awake()
        {
            checkInTargetGroup = checkInTargetGroupObject.GetComponent<CinemachineTargetGroup>();
            interactionTargetGroup = interactionTargetGroupObject.GetComponent<CinemachineTargetGroup>();

            animator = GetComponent<Animator>();
        }

        private void OnEnable()
        {
            PatientSaleEventManager.OnCheckIn += IdleCamera;
            PatientSaleEventManager.OnCancelCheckIn += IdleCamera;
            PatientSaleEventManager.OnOpenCheckInPrompt += PatientInteractionCamera;
            InteractionEventManager.onCollidedWithInteraction += t => AddColliderToTargetGroup(t);
            InteractionEventManager.onUndoCollision += t => RemoveColliderFromTargetGroup(t);
            InteractionEventManager.onSelectionChange += t => FocusOnSelection(t);
        }

        private void OnDisable()
        {
            PatientSaleEventManager.OnCheckIn -= IdleCamera;
            PatientSaleEventManager.OnCancelCheckIn -= IdleCamera;
            PatientSaleEventManager.OnOpenCheckInPrompt -= PatientInteractionCamera;
            InteractionEventManager.onCollidedWithInteraction -= t => AddColliderToTargetGroup(t);
            InteractionEventManager.onUndoCollision -= t => RemoveColliderFromTargetGroup(t);
        }

        public void PatientInteractionCamera()
        {
            
            checkInTargetGroup.AddMember(newPatientList.activePatient.transform, 1, 0.5f);
            animator.Play("patient interaction");
        }

        public void IdleCamera()
        {
            ClearTarget(newPatientList.activePatient.transform);
            animator.Play("idle");

        }

        public void ClearTarget(Transform target)
        {
            checkInTargetGroup.RemoveMember(target);
        }

        public void AddColliderToTargetGroup(Transform t)
        {
            interactionTargetGroup.AddMember(t, 1f, 1f);
        }

        public void RemoveColliderFromTargetGroup(Transform t)
        {
            interactionTargetGroup.RemoveMember(t);
        }

        private void FocusOnSelection(Transform t)
        {
            //interactionTargetGroup.AddMember(t, 2f, 0.5f);

        }



    }
}

