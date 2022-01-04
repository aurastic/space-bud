using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using BudShopCore;

namespace BudShopUI
{
    public class QueuePanelMainController : MonoBehaviour
    {
        private Button closePanelButton;
        [SerializeField] private GameObject player;
        private GameplayInputController controls;
        // Start is called before the first frame update
        void Start()
        {
            this.gameObject.SetActive(false);
        }

        private void OnEnable()
        {
            controls = InputSystemController.controls;
            closePanelButton = this.gameObject.GetComponent<UIDocument>().rootVisualElement.Q<Button>("back-button");
            closePanelButton.RegisterCallback<ClickEvent>(ev => ClosePanel());
        }

        private void ClosePanel()
        {
            SwitchActionMapToGameplay();
            this.gameObject.SetActive(false);

        }
        public void SwitchActionMapToGameplay()
        {

            controls.UI.Disable();
            controls.Gameplay.Enable();
            //Debug.Log("switched to gameplay controls");


        }
    }

}
