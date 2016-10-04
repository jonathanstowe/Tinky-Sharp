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
	}
}

