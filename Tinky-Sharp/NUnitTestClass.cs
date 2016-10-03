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

		[Test, Description("Basic Transition Tests")]
		public void TestTransition () {
			State s_from = new State ("from");
			Assert.That (s_from.name, Is.EqualTo ("from"));
			State s_to = new State ("to");
			Assert.That (s_to.name, Is.EqualTo ("to"));
			Transition t = new Transition ("transition", s_from, s_to);
			Assert.That (t.name, Is.EqualTo ("transition"));
		}
	}
}

