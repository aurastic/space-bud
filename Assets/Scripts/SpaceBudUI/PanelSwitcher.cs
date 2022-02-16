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
using UnityEngine.UIElements;
using SpaceBudCore;

namespace SpaceBudUI
{
    public class PanelSwitcher : MonoBehaviour
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
        }

        public void SwitchActionMapToGameplay()
        {
            controls.UI.Disable();
            controls.Gameplay.Enable();
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

