using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using homework_3_jacalva.Models;

namespace homework_3_jacalva.Pages;

public class OrderModel : PageModel
{
    private readonly ILogger<OrderModel> _logger;

    [BindProperty]
    public Order OrderObject {get; set;} = default!;
   

    public OrderModel(ILogger<OrderModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }



}