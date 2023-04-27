#pragma warning disable CS8618

using Microsoft.EntityFrameworkCore;
namespace C_Sharp_Project.Models;

public class MyContext : DbContext 
{   

    public MyContext(DbContextOptions options) : base(options) { }    

    public DbSet<Review> Reviews {get;set;}

}