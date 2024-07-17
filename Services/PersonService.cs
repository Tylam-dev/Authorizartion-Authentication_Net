
using System.Text.Json;

public class PersonService: IPersonService
{
    string path = "./MOCK_DATA.json";
    public async Task<List<Person>> Get()
    {
        string content = await File.ReadAllTextAsync(path);
        List<Person> people = JsonSerializer.Deserialize<List<Person>>(content);
        return people;
    }

}
