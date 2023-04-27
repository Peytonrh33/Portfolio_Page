#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace C_Sharp_Project.Models;

public class MyViewModel
{
    public Review? Review {get;set;}
    public List<Review> AllRevews {get;set;}
}