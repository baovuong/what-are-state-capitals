namespace WhatAreStateCapitals.StateCapitalStorage
{
    public interface IStateCapitalStorage
    {
        List<string> GetCapitals();
        List<string> GetStates();
        Dictionary<string, string> GetCapitalsDictionary();
        string? GetCapitalByState(string state);
        string? GetStateByCapital(string capital);
    }
}