using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Transition
    {
        public String startState;
        public String input;
        public String newState;

        public Transition(String startState, String input, String newState)
        {
            this.startState = startState;
            this.input = input;
            this.newState = newState;
        }
    }
}