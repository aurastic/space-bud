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
    public class ActionLogEntryController
    {
        private Label timeLabel;
        private Label senderLabel;
        private Label descLabel;
        private Label typeLabel;

        public void SetVisualElements(VisualElement listEntryAsset)
        {
            timeLabel = listEntryAsset.Q<Label>("time");
            descLabel = listEntryAsset.Q<Label>("description");
            senderLabel = listEntryAsset.Q<Label>("sender");
            typeLabel = listEntryAsset.Q<Label>("type");
        }

        public void SetActionLogData(ActionLogEntry entryData)
        {
            timeLabel.text = entryData.time.ToString();
            descLabel.text = entryData.desc;
            senderLabel.text = entryData.sender;
            typeLabel.text = entryData.type.ToString();
        }
    }
}


