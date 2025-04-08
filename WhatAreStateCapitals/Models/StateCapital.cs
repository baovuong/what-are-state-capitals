namespace WhatAreStateCapitals.Models
{
    public class StateCapital
    {
        public string State { get; set; }
        public string Capital { get; set; }

        public StateCapital(string state, string capital)
        {
            State = state;
            Capital = capital;
        }
    }
}