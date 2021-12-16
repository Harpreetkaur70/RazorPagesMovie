using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie1
{
    public class RazorPagesMovieContext1:DbContext
    {
        public RazorPagesMovieContext1(
            DbContextOptions<RazorPagesMovieContext1> options)
            : base(options)
        {

        }
        public DbSet<RazorPagesMovie1.Models.Movie> Movie { get; set; }

    }
}
