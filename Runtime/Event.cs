using UnityEngine;

namespace CraipaiGames.Events
{
    [CreateAssetMenu(menuName = Events.RootMenu + "/Create event", fileName = "Event")]
    public class Event : ScriptableObject
    {
        public event EventDelegate OnInvocation;

        [SerializeField, TextArea] 
        private string description;
        public string Description
        {
            get => description;
            set => description = value;
        }

        [ContextMenu(nameof(Invoke))]
        public void Invoke()
        {
            OnInvocation?.Invoke();
        }
    }
}