#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace C_Sharp_Project.Models;

public class Review
{
    [Key]
    public int ReviewId {get;set;}

    [Required(ErrorMessage = "First Name is required!")]
    [MinLength(3, ErrorMessage = "First Name must be at least 3 Characters!")]
    public string FirstName {get;set;}

    [Required(ErrorMessage = "Last Name is required!")]
    [MinLength(3, ErrorMessage = "Last Name must be at least 3 Characters!")]
    public string LastName {get;set;}

    
    public string Comment {get;set;}

    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;
}