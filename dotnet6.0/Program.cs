
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World dotnet 6!");

app.MapGet("/readfile", () =>
{
    var fileContent = File.ReadAllText("data.txt");
    return fileContent;
});

app.MapGet("/fibonacci", () =>
{
    ulong a = 0, b = 1, c = 0;
    for (ulong i = 2; i < 2000000; i++)
    {
        c = a + b;
        a = b;
        b = c;
    }

    return "done";
});

app.Run();