using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BudShopCore;

namespace BudShopData
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
        public GameEvent stateUpdate;
        

        public void SwitchState(SaleState state)
        {
            currentState = state;
            stateUpdate.RaiseEvent();

        }

     
    }


}

