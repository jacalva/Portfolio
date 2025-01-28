using System.ComponentModel.DataAnnotations; //Code in order to use various validation rules 
using System.Diagnostics.Eventing.Reader;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace homework_2_jacalva.Pages;

public class ComplaintModel : PageModel
{
    private readonly ILogger<ComplaintModel> _logger;

        [BindProperty]
        [Required (ErrorMessage = "Please Select a Product.")]
        
        public int SelectedProduct {get; set;} 
        
        //public int Results {get; set;} 
        
        //Bindproperty takes values from HTTP requests and maps them to properties in the Page Model.
        //must be used when the user is entering data in an HTML form and you want to view, store, or process that data.
        [BindProperty]
        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string Name {get; set;} = string.Empty;

              
        [BindProperty]
        [Required]
        public string Email {get; set;} = string.Empty;


        [BindProperty]
        [Required]
        [StringLength(500)]
        public string Message { get; set; } = null!;



    public ComplaintModel(ILogger<ComplaintModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
       
    }

/*    
Was Unable to figure out the line of code in order to return the name value for Selected Product.
Used this thread on stack overflow as a guide, after reading comments in slack.
https://stackoverflow.com/questions/68628424/how-to-determine-which-radio-button-was-selected-in-c-sharp-asp-net-core-mvc-5-0

public IActionResult ValidateSelectedProduct(string SelectedProduct)
        {
       
            switch (SelectedProduct)

            {
                case "1":
                    Results = "MindSync";
                    break;

                case "2":
                    Results = "Seraphine";
                    break;

                case "3":
                    Results = "SoulSear";
                    break;

                case "4":
                    Results = "PhantomClaw";
                    break;                        
            }

            return RedirectToAction("Complaint Model");
        }

        */

     public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            _logger.LogWarning("OnPost Called. INVALID DATA. Returning to page.");
            return Page();
        }

        _logger.LogWarning($"OnPost Called. Data Validated. Name = {Name} Email = {Email} Message = {Message} Selected Product = {SelectedProduct}");
        return Page();


    }
}

     