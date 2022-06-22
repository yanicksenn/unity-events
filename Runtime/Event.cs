using UnityEngine;
using UnityEngine.Events;

namespace Events
{
    /// <summary>
    /// Event wrapped in ScriptableObject.
    /// </summary>
    [CreateAssetMenu(
        menuName = EventConstants.RootMenu + "/Create event", 
        fileName = "Event")]
    public class Event : ScriptableObject
    {
        [SerializeField, TextArea] 
        private string description;

        /// <summary>
        /// Description.
        /// </summary>
        public string Description
        {
            get => description;
            set => description = value;
        }

        [SerializeField, Space]
        private UnityEvent onInvoke = new UnityEvent();
        public UnityEvent OnInvocation => onInvoke;

        /// <summary>
        /// Invokes this event.
        /// </summary>
        [ContextMenu(nameof(Invoke))]
        public void Invoke()
        {
            OnInvocation.Invoke();
        }
    }
}