using UnityEngine;

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
        public event EventDelegate OnInvocation;

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

        /// <summary>
        /// Invokes this event.
        /// </summary>
        [ContextMenu(nameof(Invoke))]
        public void Invoke()
        {
            OnInvocation?.Invoke();
        }
    }
}