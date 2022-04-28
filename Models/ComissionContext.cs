using Comission.Models;
using Microsoft.EntityFrameworkCore;

namespace Comission.Models
{
    public class ComissionContext : DbContext
    {
        public ComissionContext(DbContextOptions options) : base(options) { }

        // for every model / entity that is going to be part of the db
        // the names of these properties will be the names of the tables in the db
        public DbSet<User> Users { get; set; }
        public DbSet<Piece> Pieces { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<UserArtConnection> UserArtConnection { get; set; }
        public DbSet<Message> Messages { get; set; }

        // public DbSet<Widget> Widgets { get; set; }
        // public DbSet<Item> Items { get; set; }
    }
}
