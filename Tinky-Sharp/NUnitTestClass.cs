using NUnit.Framework;
using System;
using Tinky;

namespace TinkySharp
{
	[TestFixture ()]
	public class NUnitTestClass 
	{
		[Test ()]
		public void TestCase ()
		{
			State s = new State ("state1");
			Assert.That (s.name, Is.EqualTo ("state1"));
		}
	}
}

