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
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using SpaceBudCore;
using SpaceBudData;

namespace SpaceBudInteraction
{
    public class InteractionController : MonoBehaviour
    {
   
        private GameplayInputController controls;
        private CharacterController characterController;
        private Vector2 leftJoyValue;
        [SerializeField] private Camera myCamera;
        private Transform cameraTransform;
        private int selectedIndex;
        private bool isInteractionInFocus;

        [SerializeField] private NearbyInteractionsListObject nearbyCollidersObject;

        private void OnEnable()
        {
            characterController = GetComponent<CharacterController>();
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

        private void Start()
        {
            controls = InputSystemController.controls;
            controls.Gameplay.Enable();
            cameraTransform = myCamera.transform;
            controls.Gameplay.RightClick.performed += _ => RightClick();
            controls.Gameplay.Click.performed += _ => SelectInteraction();
            controls.Gameplay.Move.performed += ctx => leftJoyValue = ctx.ReadValue<Vector2>();
            controls.Gameplay.Move.canceled += ctx => leftJoyValue = Vector2.zero;
            controls.Gameplay.LeftShoulder.performed += _ => SwapFocusLeft();
            controls.Gameplay.RightShoulder.performed += _ => SwapFocusRight();
            
        }

        private void OnDisable()
        {
            controls.Disable();
        }


        public void RightClick()
        {
            SceneManager.LoadScene("Start Menu Scene");
        }

        private void Update()
        {
            var moveVector = cameraTransform.right * leftJoyValue.x + cameraTransform.forward * leftJoyValue.y;
            var moveVectorFlat = new Vector3(moveVector.x, 0, moveVector.z);
            characterController.Move(moveVectorFlat * Time.deltaTime * 5);
            if (moveVector != Vector3.zero)
            {
                transform.forward = moveVectorFlat;
            }


        }

        private void SelectInteraction()
        {
            if(isInteractionInFocus)
            {
                var interactiveBase = nearbyCollidersObject.list[selectedIndex].gameObject.GetComponent<PatientInteractiveBase>();

                if (interactiveBase != null)
                {
                    interactiveBase.OnInteract();
                }
            }

            else
            {
                Debug.Log("Nothing to interact with.");
            }
          
        }

        public void OnTriggerEnter(Collider other)
        {
            var t = other.gameObject.GetComponent<Transform>();
            nearbyCollidersObject.list.Add(t);
            InteractionEventManager.CollidedWithInteraction(t);

            if(!isInteractionInFocus)
            {
                FocusOnFirstCollider(t);
                Debug.Log("Starting focus.");
            }
        }

        private void OnTriggerExit(Collider other)
        {
            var t = other.gameObject.GetComponent<Transform>();
            nearbyCollidersObject.list.Remove(t);
            InteractionEventManager.ColliderMovedAway(t);

            if(nearbyCollidersObject.list.Count == 0)
            {
                isInteractionInFocus = false;
                Debug.Log("Focus list is empty.");
            }
        }

        private void FocusOnFirstCollider(Transform t)
        {
            if (nearbyCollidersObject.list.Count > 0)
            {
                selectedIndex = 0;
                isInteractionInFocus = true;
                t.gameObject.GetComponent<InteractionVisualCueManager>().ToggleImage();
                InteractionEventManager.SelectionChanged(nearbyCollidersObject.list[selectedIndex]);
            }
        }

        private void SwapFocusRight()
        {
            

            var listCount = nearbyCollidersObject.list.Count;

            if (isInteractionInFocus && listCount > 1)
            {
                Debug.Log("Swapping current target.");

                if (selectedIndex < listCount - 1)
                {
                    selectedIndex++;
                    InteractionEventManager.SelectionChanged(nearbyCollidersObject.list[selectedIndex]);

                }

                else if (selectedIndex == listCount - 1)
                {
                    selectedIndex = 0;
                    InteractionEventManager.SelectionChanged(nearbyCollidersObject.list[selectedIndex]);
                }

                
            }

            else
            {
                Debug.Log("Nothing to swap focus with.");
            }
        }

        private void SwapFocusLeft()
        {
            var listCount = nearbyCollidersObject.list.Count;

            if (isInteractionInFocus && listCount > 1)
            {
                Debug.Log("Swapping current target.");

                if (selectedIndex > 0)
                {
                    selectedIndex--;
                    InteractionEventManager.SelectionChanged(nearbyCollidersObject.list[selectedIndex]);
                }

                else if (selectedIndex == 0)
                {
                    selectedIndex = listCount - 1;
                    InteractionEventManager.SelectionChanged(nearbyCollidersObject.list[selectedIndex]);
                }

                
            }

            else
            {
                Debug.Log("Nothing to swap focus with.");
            }
        }

        private void OnApplicationQuit()
        {
            nearbyCollidersObject.list.Clear();
        }
    }
}


