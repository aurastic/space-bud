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
using UnityEngine.AI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using SpaceBudCore;


namespace SpaceBudInteraction
{
    public class InteractionController : MonoBehaviour
    {
        private NavMeshAgent playerAgent;
        private GameplayInputController controls;
        [SerializeField] private GameObject player;

        public void OnEnable()
        {
            playerAgent = GetComponent<NavMeshAgent>();
            InputSystem.onDeviceChange += (device, change) =>
            {
                switch (change)
                {
                    case InputDeviceChange.Added:
                        Debug.Log("New device added: " + device);
                        break;

                    case InputDeviceChange.Removed:
                        Debug.Log("Device removed: " + device);
                        break;
                }
            };

        }

        public void Start()
        {
            controls = InputSystemController.controls;
            controls.Gameplay.Enable();
            controls.Gameplay.Click.performed += _ => Click();
            controls.Gameplay.RightClick.performed += _ => RightClick();
            
        }

        public void OnDisable()
        {
            controls.Disable();
        }

        public void Click()
        {
            Ray interactionRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Physics.Raycast(interactionRay, out interactionData, Mathf.Infinity);

            if (Physics.Raycast(interactionRay, out RaycastHit interactionData, Mathf.Infinity))
            {
                PatientInteractiveBase interactiveItemInstance = interactionData.transform.GetComponent<PatientInteractiveBase>();
                Vector3 interactiveItemPos = interactionData.collider.transform.position;

                if (interactiveItemInstance == null)
                {

                    playerAgent.destination = interactionData.point;

                }
                else
                {
                    playerAgent.destination = interactiveItemPos + new Vector3(-0.5f, 0, 3);
                    interactiveItemInstance.OnInteract();

                }
            }
        }
        public void RightClick()
        {
            SceneManager.LoadScene("Start Menu Scene");
        }

    }
}


