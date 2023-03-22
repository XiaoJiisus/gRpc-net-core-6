namespace Chapter2.DependencyInjection;

public class DemoController : Controller
{
    private readonly ISingletonService _singletonService;
    private readonly IScopedService _scopedService;
    private readonly ITransientService _transientService;

    public DemoController(ISingletonService singletonService,IScopedService scopedService, ITransientService transientService)
    {
        _singletonService = singletonService;
        _scopedService = scopedService;
        _transientService = transientService;
    }
}