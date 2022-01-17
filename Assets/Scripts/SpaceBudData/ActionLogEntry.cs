//Copyright � 2022 Alex Reid (R.M.P.)

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

namespace SpaceBudData
{
    public class ActionLogEntry
    {
        public int time;
        public LogEntryType type;
        public string desc;
        public string sender;

        public ActionLogEntry(int time, LogEntryType type, string desc, string sender)
        {
            this.time = time;
            this.type = type;
            this.desc = desc;
            this.sender = sender;

        }
    }
}

