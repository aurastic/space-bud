using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace BudShopCore
{
    public class GameEventListener : MonoBehaviour
    {
        [SerializeField] GameEvent gameEvent;
        [SerializeField] UnityEvent response;

        void OnEnable()
        {
            gameEvent.Register(gameEventListener: this);

        }



        void OnDisable()
        {
            gameEvent.Deregister(gameEventListener: this);
        }

        public virtual void OnEventRaised()
        {
            response.Invoke();
        }


    }
}

