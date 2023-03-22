namespace Chapter2.ScopeHierarchy;

public record class SmtpConfiguration
{
    public string Domain { get; init; }
    public int Port { get; init; }
}