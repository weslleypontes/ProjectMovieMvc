using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; }

    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    public string? Genre { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    public Movie()
    {
    }

    public Movie(int id, string? title, DateTime releaseDate, string? genre, decimal price)
    {
        Id = id;
        Title = title;
        ReleaseDate = releaseDate;
        Genre = genre;
        Price = price;
    }
}