using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AD2_WEB_APP.Pages.Admin;

public class SeriesModel : PageModel
{
    private readonly ILogger<SeriesModel> _logger;

    public SeriesModel(ILogger<SeriesModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
