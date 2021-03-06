using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;

namespace Events.Tests
{
    public class EventTest
    {
        [UnityTest]
        public IEnumerator AssertEventIsInvoked()
        {
            var @event = ScriptableObject.CreateInstance<Event>();
            var trigger = new TestTrigger();
            @event.OnInvocation.AddListener(trigger.Trigger);
            @event.Invoke();
            trigger.Assert();
            yield return null;
        }
    }
}