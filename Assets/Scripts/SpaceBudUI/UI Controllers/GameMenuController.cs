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
    public class GameMenuController : MonoBehaviour
    {
        private Button appearance;
        private Button queue;
        private Button exit;

        [SerializeField] private GameObject appearancePanelObj;
        [SerializeField] private GameObject queuePanelObj;

        private GameObject _gameObject;
        private VisualElement _rootVisualElement;
        private PanelSwitcher _panelSwitcher;

        private void Awake()
        {
            _panelSwitcher = GetComponent<PanelSwitcher>();
            _gameObject = gameObject;
        }
        public void OnEnable()
        {
            _rootVisualElement = GetComponent<UIDocument>().rootVisualElement;
            
            appearance = _rootVisualElement.Q<Button>("appearance-button");
            queue = _rootVisualElement.Q<Button>("queue-button");
            exit = _rootVisualElement.Q<Button>("close-game-menu-button");
            
            appearance.RegisterCallback<ClickEvent>(ev => _panelSwitcher.SwitchPanels(appearancePanelObj, true));
            appearance.RegisterCallback<ClickEvent>(ev => _panelSwitcher.DeactivatePanel(_gameObject, false));
            
            queue.RegisterCallback<ClickEvent>(ev => _panelSwitcher.SwitchPanels(queuePanelObj, false));
            queue.RegisterCallback<ClickEvent>(ev => _panelSwitcher.DeactivatePanel(_gameObject, true));
            
            exit.RegisterCallback<ClickEvent>(ev => _panelSwitcher.DeactivatePanel(_gameObject, true));
        }

        private void Start()
        {
            gameObject.SetActive(false);
        }
       
    }

}
