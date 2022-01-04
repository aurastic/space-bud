using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using BudShopCore;


namespace BudShopUI
{
    public class SwitchPanelsStatic : MonoBehaviour
    {
        private static GameplayInputController controls;

        private void Awake()
        {
            controls = InputSystemController.controls;

        }
        public void SwitchPanels(GameObject panelObj, bool overridesGameControls)
        {

            panelObj.SetActive(true);
           

            if (overridesGameControls)
            {
                SwitchActionMapToUI();

            }

            else
            {
                var doc = panelObj.GetComponent<UIDocument>();
                var elements = doc.rootVisualElement.Children();

                foreach (VisualElement element in elements)
                {
                    element.RegisterCallback<MouseEnterEvent>(ev => SwitchActionMapToUI());

                    element.RegisterCallback<MouseLeaveEvent>(ev => SwitchActionMapToGameplay());
                }

              
            }
        }
        public void DeactivatePanel(GameObject panelObj, bool returnControls)
        {
            panelObj.SetActive(false);
            
            if(returnControls)
            {
                SwitchActionMapToGameplay();
            }
            
        }


        public void SwitchActionMapToUI()
        {
           
                controls.Gameplay.Disable();
                controls.UI.Enable();
                //Debug.Log("switched to UI controls");
            
        }
        public void SwitchActionMapToGameplay()
        {
            controls.UI.Disable();
            controls.Gameplay.Enable();
            //Debug.Log("switched to gameplay controls");

        }


        public void DeactivateSubPanel(GameObject panelObj, string panelName)
        {
            var element = panelObj.GetComponent<UIDocument>().rootVisualElement.Q<VisualElement>(panelName);
            var doc = panelObj.GetComponent<UIDocument>().rootVisualElement;
            doc.Remove(element);
        }
        public void ActivateSubPanel(GameObject panelObj, string panelName)
        {
            var element = panelObj.GetComponent<UIDocument>().rootVisualElement.Q<VisualElement>(panelName);
            var doc = panelObj.GetComponent<UIDocument>().rootVisualElement;
            doc.Add(element);
        }



   


    }

}

