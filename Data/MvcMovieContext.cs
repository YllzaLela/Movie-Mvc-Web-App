using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;



namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext //This 'context' handles the task of connecting to the DB 
                                             //And mapping Movie obj -> Database Records
                                             //This context is registered with DI contaoner in Program.cs
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
