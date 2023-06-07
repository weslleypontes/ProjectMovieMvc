using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }

    [StringLength(60, MinimumLength = 3, ErrorMessage = "Tamanho do {0} deve ser entre {2} e {1}.")]
    [Required(ErrorMessage = "{0} é obrigatório.")]
    public string? Title { get; set; }

    [Required(ErrorMessage = "{0} é obrigatório.")]
    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [Required(ErrorMessage = "{0} é obrigatório")]
    [RegularExpression(@"^[0-9]*$", ErrorMessage = "O campo {0} deve ser um número.")]
    [Range(1, 100, ErrorMessage = "O {0} deve ser de {1} até {2}")]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }


    [Required(ErrorMessage = "{0} é obrigatório.")]
    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Use apenas letras.\r\nA primeira letra deve ser maiúscula.")]
    [StringLength(30)]
    public string? Genre { get; set; }


    [Required(ErrorMessage = "{0} é obrigatório.")]
    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$", ErrorMessage = "O campo {0} deve corresponder à expressão regular {1}")]
    [StringLength(5)]
    public string? Rating { get; set; }

public Movie()
    {
    }

    public Movie(int id, string? title, DateTime releaseDate, string? genre, decimal price, string rating)
    {
        Id = id;
        Title = title;
        ReleaseDate = releaseDate;
        Genre = genre;
        Price = price;
        Rating = rating;
    }
}