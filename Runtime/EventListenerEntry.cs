using System;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

namespace CraipaiGames.Events
{
    [Serializable]
    public class EventListenerEntry
    {
        [SerializeField, Required]
        private Event @event;
        public Event Event
        {
            get => @event;
            set => @event = value;
        }
        
        [SerializeField]
        private UnityEvent unityEvent = new UnityEvent();
        public UnityEvent UnityEvent => unityEvent;
        
        
        public void AddListener()
        {
            if (Event != null)
                Event.OnInvocation += Invoke;
        }

        public void RemoveListener()
        {
            if (Event != null)
                Event.OnInvocation -= Invoke;
        }

        private void Invoke()
        {
            UnityEvent.Invoke();
        }
    }
}