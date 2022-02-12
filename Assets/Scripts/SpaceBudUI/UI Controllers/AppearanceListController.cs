using UnityEngine.UIElements;
using SpaceBudPlayerData;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceBudUI
{
    public class AppearanceListController
    {
        private VisualTreeAsset _appearanceEntryTemplate;

        private ListView _appearanceList;

        public void InitializeAppearanceList(VisualElement rootElement, VisualTreeAsset listElementTemplate, List<AppearanceProfile> currentList)
        {
            
            _appearanceEntryTemplate = listElementTemplate;
            _appearanceList = rootElement.Q<ListView>("appearance-list");
           
            FillActionLog(currentList);
        }

        private void FillActionLog(List<AppearanceProfile> currentList)
        {
            // Set up a make item function for a list entry
            _appearanceList.makeItem = () =>
            {
                // Instantiate the UXML template for the entry
                var newListEntry = _appearanceEntryTemplate.Instantiate();

                // Instantiate a controller for the data
                var newListEntryLogic = new AppearanceEntryController();

                // Assign the controller script to the visual element
                newListEntry.userData = newListEntryLogic;

                // Initialize the controller script
                newListEntryLogic.SetVisualElements(newListEntry);

                // Return the root of the instantiated visual tree
                return newListEntry;
            };

            _appearanceList.bindItem = (item, index) =>
            {
                (item.userData as AppearanceEntryController).SetAppearanceData(currentList[index]);

            };

            _appearanceList.itemHeight = 60;
            _appearanceList.horizontalScrollingEnabled = true;
            _appearanceList.itemsSource = currentList;
        }
    }
}

