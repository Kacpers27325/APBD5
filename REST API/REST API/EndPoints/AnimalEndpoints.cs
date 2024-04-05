using REST_API.Models;

namespace REST_API.EndPoints;

public static class AnimalEndpoints
{
    public static void MapAnimalsEndPoints(this WebApplication app)
    {
        app.MapPost("/animals", (Animal animal, int id) =>
        {
            return "";
        });
    }
}