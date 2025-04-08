
using WhatAreStateCapitals.Models;

namespace WhatAreStateCapitals.StateCapitalProcessors
{
    public class ArrayListProcessor : IStateCapitalProcessor
    {
        private StateCapital[] _stateCapitals;
        public ArrayListProcessor(StateCapital[] stateCapitals)
        {
            _stateCapitals = stateCapitals;
        }
        public string GetCapitalByState(string state)
        {
            throw new NotImplementedException();
        }

        public List<string> GetCapitals()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> GetCapitalsDictionary()
        {
            throw new NotImplementedException();
        }

        public string GetStateByCapital(string capital)
        {
            throw new NotImplementedException();
        }

        public List<string> GetStates()
        {
            throw new NotImplementedException();
        }
    }
}