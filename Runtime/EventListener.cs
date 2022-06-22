using UnityEngine;
using UnityEngine.Events;

namespace Events
{
    /// <summary>
    /// Listener for events.
    /// </summary>
    public class EventListener : MonoBehaviour
    {
        [SerializeField]
        private Event listeningOn;
        
        /// <summary>
        /// Event to listen to.
        /// </summary>
        public Event ListeningOn
        {
            get => listeningOn;
            set
            {
                Unregister();
                listeningOn = value;
                Register();
            }
        }

        [SerializeField]
        private UnityEvent onInvocation = new UnityEvent();
        public UnityEvent OnInvocation => onInvocation;
        
        /// <summary>
        /// Invokes this event.
        /// </summary>
        [ContextMenu(nameof(Invoke))]
        public void Invoke()
        {
            OnInvocation.Invoke();
        }
        
        private void OnEnable() => Register();
        private void OnDisable() => Unregister();

        private void Register()
        {
            if (listeningOn != null)
                listeningOn.OnInvocation.AddListener(Invoke);
        }

        private void Unregister()
        {
            if (listeningOn != null)
                listeningOn.OnInvocation.RemoveListener(Invoke);
        }
    }
}