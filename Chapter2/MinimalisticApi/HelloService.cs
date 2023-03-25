namespace MinimalisticAPI;

public class HelloService : IHelloService
{
    public string Hello (string name)
    {
        return $"Hello {name}";
    }
}