using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;

namespace CraipaiGames.Events.Tests
{
    public class EventTest
    {
        [UnityTest]
        public IEnumerator AssertEventIsInvoked()
        {
            var @event = ScriptableObject.CreateInstance<Event>();
            var trigger = new TestTrigger();
            @event.OnInvocation += () => trigger.Trigger();
            @event.Invoke();
            trigger.Assert();
            yield return null;
        }
    }
}