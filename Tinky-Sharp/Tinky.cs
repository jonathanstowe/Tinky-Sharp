
using System;
using System.Collections.Generic;

namespace Tinky {

	public class State :IEquatable<State> {


		private string _name;

		public string name {
			get {
				return _name;
			}
		}
		
		public State () {

		}

		public State (string name) {
			_name = name;
		}

		public bool Equals(State n) {
			
			if (n == null)
				return false;
			else if (n.name == this.name)
				return true;
			else
				return false;
		}

		public override bool Equals(Object n) {
			if (n == null)
				return false;
			else {
				State stateObj = n as State;
				if (stateObj == null)
					return false;
				else
					return Equals(stateObj);
			}
		}

	}

	public class Transition :IEquatable<Transition> {

        public string   name;
        public State    from;
        public State    to;

		public Transition () {
		}

        public Transition (string n, State f, State t) {
            name    = n;
            from    = f;
            to      = t;
        }

		public bool Equals(Transition n ) {
			if ( n == null )
				return false;
			else if (n.name == this.name)
				return true;
			else
				return false;
				
		}

	}

	public class Workflow {

		public string name;

		public Workflow () {
		}

		public Workflow(string n ) {
			name = n;
		}
	}
}

