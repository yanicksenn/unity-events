using Sirenix.OdinInspector;
using UnityEngine;

namespace CraipaiGames.Events
{
    public class EventListener : MonoBehaviour
    {
        [SerializeField, InlineProperty, HideLabel] 
        private EventListenerEntry entry = new EventListenerEntry();
        public EventListenerEntry Entry => entry;
        
        private void OnEnable() => Entry.AddListener();
        private void OnDisable() => Entry.RemoveListener();
    }
}