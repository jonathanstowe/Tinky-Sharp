using NUnit.Framework;
using System;
using Tinky;

namespace TinkySharp
{
	[TestFixture, Description("Basic Tests") ]
	public class NUnitTestClass 
	{
		[Test, Description("Basic State Tests") ]
		public void TestState ()
		{
			State s = new State ("state1");
			Assert.That (s.name, Is.EqualTo ("state1"));
		}

		[Test, Description("State Equals tests") ]
		public void TestStateEquals() {
			State s1 = new State ("state1");
			State s2 = new State ("state2");
			State s3 = new State ("state1"); // same name different objects
			Assert.That(s1.Equals(s1), Is.True);
			Assert.That (s1.Equals (s3), Is.True);
			Assert.That (s1.Equals (s2), Is.False);
			Assert.That (s1.Equals(null), Is.False);
		}

		[Test, Description("Basic Transition Tests")]
		public void TestTransition () {
			State s_from = new State ("from");
			Assert.That (s_from.name, Is.EqualTo ("from"));
			State s_to = new State ("to");
			Assert.That (s_to.name, Is.EqualTo ("to"));
			Transition t = new Transition() { name="transition", from=s_from,to=s_to };
			Assert.That (t.name, Is.EqualTo ("transition"));
		}

		[Test, Description("Transition Equals tests") ]
		public void TestTransitionEquals() {
			State s1 = new State ("state1");
			State s2 = new State ("state2");
			State s3 = new State ("state3");
			Transition t1 = new Transition () { name = "t1", from = s1, to = s2 };
			Transition t2 = new Transition () { name = "t2", from = s2, to = s3 };
			Assert.That(t1.Equals(t1), Is.True);
			Assert.That (t2.Equals (t2), Is.True);
			Assert.That (t1.Equals (t2), Is.False);
			Assert.That (t1.Equals(null), Is.False);

		}
	}
}

