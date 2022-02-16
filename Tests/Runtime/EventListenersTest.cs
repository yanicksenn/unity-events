using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace CraipaiGames.Events.Tests
{
    public class EventListenersTest
    {
        [UnityTest]
        public IEnumerator AssertEventIsInvoked()
        {
            var event1 = ScriptableObject.CreateInstance<Event>();
            var trigger1 = new TestTrigger();
            var entry1 = new EventListenerEntry {Event = event1};
            entry1.UnityEvent.AddListener(() => trigger1.Trigger());

            var event2 = ScriptableObject.CreateInstance<Event>();
            var trigger2 = new TestTrigger();
            var entry2 = new EventListenerEntry {Event = event2};
            entry2.UnityEvent.AddListener(() => trigger2.Trigger());
            
            var gameObject = new GameObject();
            var eventListeners = gameObject.AddComponent<EventListeners>();
            eventListeners.Entries = new List<EventListenerEntry> {entry1, entry2};
            
            gameObject.SetActive(false);
            gameObject.SetActive(true);
            yield return null;
            
            event1.Invoke();
            trigger1.Assert();
            
            event2.Invoke();
            trigger2.Assert();
            yield return null;
        }
    }
}