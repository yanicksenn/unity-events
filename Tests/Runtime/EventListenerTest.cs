using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace CraipaiGames.Events.Tests
{
    public class EventListenerTest
    {
        [UnityTest]
        public IEnumerator AssertEventIsInvoked()
        {
            var @event = ScriptableObject.CreateInstance<Event>();
            var gameObject = new GameObject();
            var trigger = new TestTrigger();
            
            var eventListener = gameObject.AddComponent<EventListener>();
            eventListener.ListeningOn = @event;
            eventListener.OnInvocation.AddListener(() => trigger.Trigger());
            
            gameObject.SetActive(false);
            gameObject.SetActive(true);
            yield return null;
            
            @event.Invoke();
            trigger.Assert();
            yield return null;
        }
    }
}