using CodeAlong_240215.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeAlong_240215.Data;

public class MovieContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }
    public MovieContext (){}
    public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

}

