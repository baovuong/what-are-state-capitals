using WhatAreStateCapitals.Models;

namespace WhatAreStateCapitals.StateCapitalStorage
{
    public class ArrayListStateCapitalStorage : IStateCapitalStorage
    {
        private const int INTIAL_ = 50;
        private StateCapital[] _stateCapitals;
        public ArrayListStateCapitalStorage(List<StateCapital> stateCapitals)
        {
            _stateCapitals = new StateCapital[INTIAL_];

            // add to array 
            for (int i = 0; i < stateCapitals.Count; i++)
            {
                _stateCapitals[i] = stateCapitals[i];
            }
        }

        public string? GetCapitalByState(string state)
        {
            // if it's sorted by state, we can use binary search O(logn)

            int current;
            int low = 0;
            int high = _stateCapitals.Length - 1;
            
            while  (low <= high)
            {
                current = (low + high) / 2;
                if (_stateCapitals[current].State.Equals(state)) 
                {
                    return _stateCapitals[current].Capital;
                }

                if  (_stateCapitals[current].State.CompareTo(state) > 0)
                {
                    low = current;
                }
                else 
                {
                    high = current;
                }
            }            
            return null; 
        }

        public string? GetStateByCapital(string capital)
        {
            // sequential search, since we're not sorted by state O(n)
            foreach (StateCapital stateCapital in _stateCapitals)
            {
                if (stateCapital.Capital.Equals(capital))
                {
                    return stateCapital.State;
                }
            }
            return null;
        }

        public List<string> GetStates()
        {
            // just iterate and add to List
            List<string> result = [];
            foreach (StateCapital stateCapital in _stateCapitals)
            {
                result.Add(stateCapital.State);
            }
            return result;
        }

        public List<string> GetCapitals()
        {
            // just iterate and add to List
            List<string> result = new List<string>();
            foreach (StateCapital stateCapital in _stateCapitals)
            {
                result.Add(stateCapital.Capital);
            }
            return result;
        }

        public Dictionary<string, string> GetCapitalsDictionary()
        {
            throw new NotImplementedException();
        }
    }
}