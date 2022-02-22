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

using UnityEngine;
using SpaceBudCore;

namespace SpaceBudData
{
    public enum SaleState
    {
        NewPatientState = 0,
        PendingCheckInState = 1,
        CheckedInState = 2,
        SaleInProgressState = 3,
        LeavingState = 4,
        HiddenInPoolState = 5
    }
    public enum MoodState
    {
        Happy = 0,
    }
   
    public class PatientStateData : MonoBehaviour
    {
        public SaleState currentState = SaleState.HiddenInPoolState;
        public MoodState currentMood = MoodState.Happy;
        public int currentPlaceInLine;
        private PatientMovement movementManager;

        private void OnEnable()
        {
            movementManager = GetComponent<PatientMovement>();
            
        }
        
        public void SwitchState(SaleState state)
        {
            currentState = state;
            PatientSaleEventManager.SaleStateChanged();
            movementManager.UpdateMovement();

        }
        
    }
}

