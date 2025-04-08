namespace WhatAreStateCapitals.StateCapitalProcessors
{
    public interface IStateCapitalProcessor
    {
        List<string> GetCapitals();
        Dictionary<string, string> GetCapitalsDictionary();
        string GetCapitalByState(string state);
        string GetStateByCapital(string capital);
        List<string> GetStates();
    }
}