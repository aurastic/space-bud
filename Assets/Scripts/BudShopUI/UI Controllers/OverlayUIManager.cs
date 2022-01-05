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
using BudShopCore;


namespace BudShopUI
{
    public class OverlayUIManager: MonoBehaviour
    {
        [SerializeField] IntegerObject patientCount;
        [SerializeField] IntegerObject fundsCount;

        [SerializeField] private GameObject gameMenu;

        
       

        //ui elements
        private Label patientCountLabel;
        private Label shopFundsLabel;
        private Label shopStateLabel;
        private Button gameMenuButton;

        private SwitchPanelsStatic _panelSwitcher;
        private VisualElement _rootVisualElement;

        private void Awake()
        {
            _panelSwitcher = GetComponent<SwitchPanelsStatic>();
            _rootVisualElement = GetComponent<UIDocument>().rootVisualElement;

        }
        private void OnEnable()
        {
            _panelSwitcher.SwitchPanels(gameObject, false);

            patientCountLabel = _rootVisualElement.Q<Label>("new-pt-count");
            shopFundsLabel = _rootVisualElement.Q<Label>("shop-funds-count");
            shopStateLabel = _rootVisualElement.Q<Label>("shop-state-label");


            gameMenuButton = _rootVisualElement.Q<Button>("game-menu-button");


            gameMenuButton.RegisterCallback<ClickEvent>(ev => _panelSwitcher.SwitchPanels(gameMenu, false)); //no unity event needed since click event sends message
            

            UpdateValues();

           
        }

        private void UpdateValues()
        {
            shopFundsLabel.text = "$ " + fundsCount.value.ToString();
            shopStateLabel.text = "TBD";
            patientCountLabel.text = patientCount.value.ToString();
        }
    }
}

