using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using BudShopCore;

namespace BudShopUI
{
    public class AppearancePanelController : MonoBehaviour
    {
        private Button closePanelButton;
        [SerializeField] private GameObject player;
        private GameplayInputController controls;


        private void OnEnable()
        {
            controls = InputSystemController.controls;
            closePanelButton = this.gameObject.GetComponent<UIDocument>().rootVisualElement.Q<Button>("back-button");
            closePanelButton.RegisterCallback<ClickEvent>(ev => ClosePanel());

        }
        void Start()
        {
            this.gameObject.SetActive(false);
        }

        private void ClosePanel()
        {
            SwitchActionMapToGameplay();
            this.gameObject.SetActive(false);

        }
        public void SwitchActionMapToUI()
        {
            if (!controls.UI.enabled)
            {
                controls.Gameplay.Disable();
                controls.UI.Enable();
                //Debug.Log("switched to UI controls");
            }
        }
        public void SwitchActionMapToGameplay()
        {

            controls.UI.Disable();
            controls.Gameplay.Enable();
            //Debug.Log("switched to gameplay controls");


        }
    }

}
