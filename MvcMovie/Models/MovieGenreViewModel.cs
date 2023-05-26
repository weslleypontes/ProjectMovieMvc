using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {

        public List<Movie>? Movies { get; set; }
        //Uma SelectList que contém a lista de gêneros. Isso permite que o usuário selecione um gênero na lista
        public SelectList? Genres { get; set; }
        public string? MovieGenre { get; set; }
        public string? SearchString { get; set; }
    }
}
