
using System.ComponentModel.DataAnnotations;
namespace homework_3_jacalva.Models;


// Enum classes store all possible options and you can add Display rules and reference them directly.
public enum Country
{
[Display(Name = "United States")]    
UnitedStates,

[Display(Name = "South Korea")]
SouthKorea,

[Display(Name = "Canada")]
Canada,

}

public enum State
{
[Display(Name = "Texas")]    
Texas,

[Display(Name = "Gyeonggi")]
Gyeonggi,

[Display(Name = "Nova Scotia")]
NovaScotia,

}

//Entity Classes Below
public class Order
{
    [Display(Name = "First Name")]
    [Required]
    public string FirstName {get; set;} = string.Empty;
    
    [Display(Name = "Last Name")]
    [Required]
    public string LastName {get; set;} = string.Empty;
    
    [Display(Name = "Email Address")]
    [EmailAddress]
    public string Email {get; set;} = string.Empty;

    [Display(Name = "Address")]
    [Required]
    public string Address {get; set;} = string.Empty;

    [Required]
    public Country? Country {get; set;}

    [Required]
    public State? State {get; set;}

    [Display(Name = "Zip Code")]
    [RegularExpression(@"\d{5}$", ErrorMessage = "Invalid Zip Code")]
    public string Zip {get; set;} = string.Empty;


    [Display(Name = "Shipping address is the same as my billing address.")]
    public bool SameShippingInfo {get; set;}

    [Display(Name = "Save this information for next time.")]
    public bool SaveInformation {get; set;}

    [Display(Name = "Payment Type")]
    [Required]
    public int PaymentType {get; set;}

    public string PaymentName {get; set;} = string.Empty;

    [Display(Name = "Name On Card")]
    [Required]
    public string NameOnCard {get; set;} = string.Empty;

    [Display(Name = "Credit Card Number")]
    [CreditCard]
    public string CardNumber {get; set;} = string.Empty;


}