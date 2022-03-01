using UnityEngine;
using UnityEngine.Events;

namespace Events
{
    public class EventListener : MonoBehaviour
    {
        [SerializeField]
        private Event listeningOn;
        public Event ListeningOn
        {
            get => listeningOn;
            set => listeningOn = value;
        }
        
        [SerializeField]
        private UnityEvent onInvocation = new UnityEvent();
        public UnityEvent OnInvocation => onInvocation;
        
        [ContextMenu(nameof(Invoke))]
        private void Invoke()
        {
            OnInvocation.Invoke();
        }
        
        private void OnEnable()
        {
            if (ListeningOn != null)
                ListeningOn.OnInvocation += Invoke;
        }
        private void OnDisable()
        {
            if (ListeningOn != null)
                ListeningOn.OnInvocation -= Invoke;
        }
    }
}