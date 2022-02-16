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

namespace SpaceBudUI
{
    public class QueuePanelMainController : MonoBehaviour
    {
        private Button closePanelButton;
        private PanelSwitcher _panelSwitcher;

        private void Awake()
        {
            _panelSwitcher = GetComponent<PanelSwitcher>();
        }
        private void Start()
        {
            gameObject.SetActive(false);
        }

        private void OnEnable()
        {
            closePanelButton = GetComponent<UIDocument>().rootVisualElement.Q<Button>("back-button");
            closePanelButton.RegisterCallback<ClickEvent>(ev => _panelSwitcher.DeactivatePanel(this.gameObject, true));
        }

    }

}
