using Sirenix.OdinInspector;
using UnityEngine;

namespace CraipaiGames.Events
{
    [CreateAssetMenu(menuName = "Events/Create event", fileName = "Event")]
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

        [Button("Invoke")]
        public void Invoke()
        {
            OnInvocation?.Invoke();
        }
    }
}