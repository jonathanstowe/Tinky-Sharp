
using System;

namespace Tinky {

	public class State {

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
	}

	public class Transition {

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

