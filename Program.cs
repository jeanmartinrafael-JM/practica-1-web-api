var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Endpoint  principal
app.MapGet("/", () => "¡Bienvenido a Jean web api!");

// Endpoint con mi nombre y apellido
app.MapGet("/jean-pangol", () =>
{
    var info = new Dictionary<string, string>
    {
        { "Nombre",   "Jean" },
        { "Apellido", "Pangol" }
    };
    return string.Join("\n", info.Select(x => $"{x.Key}: {x.Value}"));
});

app.Run();