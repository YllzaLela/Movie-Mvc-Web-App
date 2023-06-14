using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
	public class MovieGenreViewModel
	{
		public List<Movie>? Movies { get; set; } //list of movies
		public SelectList? Genres { get; set; }//List of genres
		public string? MovieGenre { get; set; } //Contains the selected Genre

		public string? SearchString { get; set; } //Contains the text users enter in the search text box

	}
}
