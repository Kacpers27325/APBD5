using REST_API.Models;

namespace REST_API.Database;

public class MockDb
{
    public List<Animal> Animals { get; set; } = new List<Animal>();

    public MockDb()
    {
        Animals.Add();
    }
}

