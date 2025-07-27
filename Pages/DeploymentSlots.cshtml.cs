using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace az_webapp_kaycee.Pages;

public class DeploymentSlotsModel : PageModel
{
private readonly ILogger<ErrorModel> _logger;

    public DeploymentSlotsModel(ILogger<ErrorModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

