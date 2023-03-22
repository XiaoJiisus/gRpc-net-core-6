namespace Chapter2.ScopeHierarchy;

public class DemoController : Controller
{
    private readonly SmtpConfiguration _smtpConfiguration;

    public DemoController(SmtpConfiguration smtpConfiguration)
    {
        _smtpConfiguration = smtpConfiguration;
    }
}