using System.Text.Json;
using WhatAreStateCapitals.Models;
using WhatAreStateCapitals.StateCapitalStorage;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<List<StateCapital>>(serviceProvider =>
{
    string jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "data", "state-capitals.json");
    string jsonString = File.ReadAllText(jsonPath);
    var stateCapitals = JsonSerializer.Deserialize<List<StateCapital>>(jsonString);
    return stateCapitals;
});

builder.Services.AddSingleton<IStateCapitalStorage, ArrayListStateCapitalStorage>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("api/statecapitals/states", (IStateCapitalStorage stateCapitalStorage) => stateCapitalStorage.GetStates());
app.MapGet("api/statecapitals/capitals", (IStateCapitalStorage stateCapitalStorage) => stateCapitalStorage.GetCapitals());

app.Run();
