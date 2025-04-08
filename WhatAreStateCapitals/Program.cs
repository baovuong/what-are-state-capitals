var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("api/statecapitals", () => 
{
    return new List<string>
    {
        "Montgomery, Alabama",
        "Juneau, Alaska",
        "Phoenix, Arizona",
        "Little Rock, Arkansas",
        "Sacramento, California",
        "Denver, Colorado",
        "Hartford, Connecticut",
        "Dover, Delaware",
        "Tallahassee, Florida",
        "Atlanta, Georgia"
    };
});

app.Run();
