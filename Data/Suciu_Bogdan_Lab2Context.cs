using Microsoft.EntityFrameworkCore;

public class Suciu_Bogdan_Lab2Context(DbContextOptions<Suciu_Bogdan_Lab2Context> options) : DbContext(options)
{
    public DbSet<Suciu_Bogdan_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Suciu_Bogdan_Lab2.Models.Publisher> Publisher { get; set; } = default!;

    public DbSet<Suciu_Bogdan_Lab2.Models.Author> Author { get; set; } = default!;
}
