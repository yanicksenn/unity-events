namespace Events.Tests
{
    public class TestTrigger
    {
        private bool triggered;
        public bool Triggered => triggered;

        public void Trigger()
        {
            triggered = true;
        }

        public void Assert()
        {
            NUnit.Framework.Assert.IsTrue(Triggered);
        }
    }
}