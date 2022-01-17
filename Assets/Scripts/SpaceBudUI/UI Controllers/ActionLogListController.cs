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

using UnityEngine.UIElements;
using SpaceBudData;

namespace SpaceBudUI
{
    public class ActionLogListController
    {
        private VisualTreeAsset _actionLogTemplate;

        private ListView _actionLogList;
       

        public void InitializeActionLog(VisualElement rootElement, VisualTreeAsset listElementTemplate, ActionLogObject logData)
        {
            _actionLogTemplate = listElementTemplate;
            _actionLogList = rootElement.Q<ListView>("action-log");
            FillActionLog(logData);

        }
        private void FillActionLog(ActionLogObject logData)
        {
            // Set up a make item function for a list entry
            _actionLogList.makeItem = () =>
            {
                // Instantiate the UXML template for the entry
                var newListEntry = _actionLogTemplate.Instantiate();

                // Instantiate a controller for the data
                var newListEntryLogic = new ActionLogEntryController();

                // Assign the controller script to the visual element
                newListEntry.userData = newListEntryLogic;

                // Initialize the controller script
                newListEntryLogic.SetVisualElements(newListEntry);

                // Return the root of the instantiated visual tree
                return newListEntry;
            };

            _actionLogList.bindItem = (item, index) =>
            {
                (item.userData as ActionLogEntryController).SetActionLogData(logData.actionLog[index]);
                
            };

            _actionLogList.itemHeight = 20;
            _actionLogList.itemsSource = logData.actionLog;
        }
    }
}

