
using System;

namespace Tinky {
	public class State {

		private string _name;

		public string name {
			get {
				return _name;
			}
			set {
				_name = value;
			}
		}
		
		public State () {

		}
		public State (string name) {
			_name = name;
		}
	}

	public class Transition {
		public Transition () {
		}
	}
}

