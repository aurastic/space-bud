using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using BudShopCore;




namespace BudShopInteraction
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


