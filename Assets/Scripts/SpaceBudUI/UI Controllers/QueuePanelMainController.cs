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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using SpaceBudCore;

namespace SpaceBudUI
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
