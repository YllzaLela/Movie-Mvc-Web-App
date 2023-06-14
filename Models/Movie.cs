using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
	public class Movie
	{
		public int Id { get; set; }

		[StringLength(60, MinimumLength = 3)]
		[Required]
		public string? Title { get; set; } //string? means This property is nullable

		[Display(Name ="Release Date")] //Display specifies what to display for the name of a field
		[DataType(DataType.Date)]
		public DateTime ReleaseDate { get; set; }


		[RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
		[Required]
		[StringLength(30)]
		public string? Genre { get; set; }//Thi is also nullable

		[Range(1, 100)]
		[DataType(DataType.Currency)] 
		
		[Column(TypeName ="decimal(18,2)")] //This data annotation is required so EF Core can correctly map Price to currency in the DB
		public decimal Price { get; set; }

		[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
		[StringLength(5)]
		[Required]
		public string? Rating { get; set; }

	}
}
