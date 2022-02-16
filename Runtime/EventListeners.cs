using System.Collections.Generic;
using UnityEngine;

namespace CraipaiGames.Events
{
    public class EventListeners : MonoBehaviour
    {
        [SerializeField] 
        private List<EventListenerEntry> entries = new List<EventListenerEntry>();
        public List<EventListenerEntry> Entries
        {
            get => entries;
            set => entries = value;
        }
        
        private void OnEnable() => Entries.ForEach(e => e.AddListener());
        private void OnDisable() => Entries.ForEach(e => e.RemoveListener());
    }
}