
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World dotnet 6!");

app.MapGet("/readfile", () =>
{
    var fileContent = File.ReadAllText("data.txt");
    return fileContent;
});

app.MapGet("/bubblesort", () =>
{
    var maxNumber = 1500;
    var array = new int[maxNumber];

    for (int i = 0; i < maxNumber; i++)
    {
        array[i] = maxNumber - i;
    }

    int tempBox;
    var lastIndex = array.Length - 1;

    for (int outerIndex = 0; outerIndex < lastIndex; outerIndex++)
    {
        for (int currentIndex = 0; currentIndex < lastIndex; currentIndex++)
        {
            var nextIndex = currentIndex + 1;

            if (array[currentIndex] > array[nextIndex])
            {
                tempBox = array[nextIndex];
                array[nextIndex] = array[currentIndex];
                array[currentIndex] = tempBox;
            }
        }
    }

    return array;
});

app.Run();