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
using SpaceBudPlayerData;

namespace SpaceBudUI
{
    public class AppearancePanelController : MonoBehaviour
    {
        private Button closePanelButton;
        [SerializeField] private VisualTreeAsset appearanceListEntryTemplate;
        private PanelSwitcher _panelSwitcher;
        private VisualElement _rootVisualElement;
        private AppearanceListController _listController;

        private Button hatsButton;
        private Button skinButton;
        private Button faceButton;

        private List<AppearanceProfile> hatProfiles;
        private List<AppearanceProfile> skinProfiles;
        private List<AppearanceProfile> faceProfiles;

        private List<AppearanceProfile> currentList;

        private void Awake()
        {
            currentList = hatProfiles;
            
            _panelSwitcher = GetComponent<PanelSwitcher>();
            
            EnumerateAllProfiles();
        }
        public void OnEnable()
        {
            _rootVisualElement = GetComponent<UIDocument>().rootVisualElement;

            _listController = new AppearanceListController();
            _listController.InitializeAppearanceList(_rootVisualElement, appearanceListEntryTemplate, currentList);
            
            closePanelButton = _rootVisualElement.Q<Button>("back-button");
            closePanelButton.RegisterCallback<ClickEvent>(ev => _panelSwitcher.DeactivatePanel(gameObject, true));

            hatsButton = _rootVisualElement.Q<Button>("hats");
            hatsButton.RegisterCallback<ClickEvent>(ev => SwitchAppearanceTab(hatProfiles));

            skinButton = _rootVisualElement.Q<Button>("skin");
            skinButton.RegisterCallback<ClickEvent>(ev => SwitchAppearanceTab(skinProfiles));

            faceButton = _rootVisualElement.Q<Button>("face");
            faceButton.RegisterCallback<ClickEvent>(ev => SwitchAppearanceTab(faceProfiles));

        }
        private void Start()
        {
           gameObject.SetActive(false);
        }

        private void EnumerateAllProfiles()
        {
            hatProfiles = new List<AppearanceProfile>();
            hatProfiles.AddRange(Resources.LoadAll<AppearanceProfile>("Hats"));

            skinProfiles = new List<AppearanceProfile>();
            skinProfiles.AddRange(Resources.LoadAll<AppearanceProfile>("Skin"));

            faceProfiles = new List<AppearanceProfile>();
            faceProfiles.AddRange(Resources.LoadAll<AppearanceProfile>("Face"));

        }

        private void SwitchAppearanceTab(List<AppearanceProfile> currentList)
        {
            this.currentList = currentList;
            _listController.InitializeAppearanceList(_rootVisualElement, appearanceListEntryTemplate, currentList);
        }
    }

}
