using System.Text.Json.Serialization;

namespace WhatAreStateCapitals.Models
{
    public class StateCapital
    {
        [JsonPropertyName("state")]
        public string State { get; set; }
        [JsonPropertyName("capital")]
        public string Capital { get; set; }

        public StateCapital(string state, string capital)
        {
            State = state;
            Capital = capital;
        }
    }
}