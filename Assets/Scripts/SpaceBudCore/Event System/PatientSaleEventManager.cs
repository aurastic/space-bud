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

using System;
using UnityEngine;

namespace SpaceBudCore
{
    public static class PatientSaleEventManager
    {
        public static event Action OnNewPatient;
        public static event Action OnCheckIn;
        public static event Action OnCancelCheckIn;
        public static event Action OnOpenCheckInPrompt;
        public static event Action OnPatientClick;

        public static event PatientLeftEarlyEventHandler PatientLeftEarly;
        public delegate void PatientLeftEarlyEventHandler(object sender, IntegerEventArgs args);

        public static event Action OnSaleStateChange;
        
        public class IntegerEventArgs : EventArgs
        {
            public int Index { get; set; }

            public IntegerEventArgs(int index)
            {
                Index = index;
            }
        }

        public static void CheckInComplete() => OnCheckIn?.Invoke();
       
        public static void CanceledCheckIn() => OnCancelCheckIn?.Invoke();
        
        public static void OpenedCheckInPrompt() => OnOpenCheckInPrompt?.Invoke();

        public static void ClickedOnPatient() => OnPatientClick?.Invoke();
       
        public static void NewPatient() => OnNewPatient?.Invoke();
      
        public static void OnPatientLeftEarly(UnityEngine.Object sender, IntegerEventArgs args) => PatientLeftEarly?.Invoke(sender, args);
        
        public static void SaleStateChanged() => OnSaleStateChange?.Invoke();
      
 
    }
}

