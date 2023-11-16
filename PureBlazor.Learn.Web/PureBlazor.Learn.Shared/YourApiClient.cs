namespace PureBlazor.Learn.Shared;

public class YourApiClient(HttpClient client)
{
    public async Task<string> GetTodos()
    {
        return await client.GetStringAsync("/todos");
    }
}

