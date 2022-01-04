using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace BudShopCore
{
    [CreateAssetMenu(menuName = "Game Event", fileName = "New Game Event")]
    public class GameEvent : ScriptableObject
    {
        private List<GameEventListener> listeners = new List<GameEventListener>();


        public void RaiseEvent()
        {
            Debug.Log(this.name + " raised");
            for (int i = listeners.Count - 1; i >= 0; i--)
                listeners[i].OnEventRaised();
        }

        public void Register(GameEventListener gameEventListener)
        {
            listeners.Add(gameEventListener);


        }
        public void Deregister(GameEventListener gameEventListener)
        {
            listeners.Remove(gameEventListener);
        }

    }
}

