using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class DFA
    {
        private List<String> alphabet;
        private List<String> states;
        private List<String> acceptingStates;
        private Dictionary<String, String> transitions = new Dictionary<String, String>();
        private string startState;
        private string currentState;

        public void set(string definition)
        {
            definition = definition
                .Replace("{", String.Empty)
                .Replace("}", String.Empty)
                .Replace(" ", String.Empty);

            string[] lines = definition.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(lines[2]);
            foreach (string s in lines)
            {
                Console.WriteLine(s);
            }

            alphabet = lines[0].Split(',').ToList();
            states = lines[1].Split(',').ToList();
            startState = lines[2][0].ToString();
            currentState = lines[2][0].ToString();
            acceptingStates = lines[3].Split(',').ToList();

            //acceptingStates.Add("a");

            for (int i = 4; i < lines.Length; i++)
            {
                string startState = lines[i][1].ToString();
                string input = lines[i][3].ToString();
                string newState = lines[i][7].ToString();

                String key = getKeyForTransition(input, startState);
                transitions.Add(key, newState);
            }

            /*
            foreach(KeyValuePair<String, Transition> t in transitions)
            {
                Console.WriteLine(t.Key + " " + t.Value.toString());
            }
            */
        }

        public void input(String input)
        {
            if (currentState != null)
            {
                // Check that this input is contained within the input alphabet
                if (!alphabet.Contains(input))
                {
                    currentState = null;
                }

                string key = getKeyForTransition(input, currentState);

                string newState;
                if (!transitions.TryGetValue(key, out newState))
                {
                    currentState = null;
                }

                if (currentState != null)
                    currentState = newState;
            }
        }

        public Boolean isAccepting()
        {
            return acceptingStates.Contains(currentState);
            //return true;
        }

        private String getKeyForTransition(String input, String state)
        {
            return input + "," + state;
        }

        public string getStates()
        {
            return String.Join(", ", acceptingStates.ToArray()); ;
        }

        public void reset()
        {
            alphabet = new List<string>();
            states = new List<string>();
            acceptingStates = new List<string>();
            transitions = new Dictionary<String, String>();
            startState = null;
            currentState = null;
        }

    }
}