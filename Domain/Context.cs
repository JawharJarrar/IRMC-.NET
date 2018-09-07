namespace hack
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using hack.Conventions;

    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public  class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<evenement> events { get; set; }
        public virtual DbSet<t_todo> t_todo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<category>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<category>()
                .HasMany(e => e.events)
                .WithOptional(e => e.category)
                .HasForeignKey(e => e.category_idCategory);

            modelBuilder.Entity<evenement>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<evenement>()
                .Property(e => e.file)
                .IsUnicode(false);

            modelBuilder.Entity<evenement>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<evenement>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<evenement>()
                .Property(e => e.resume)
                .IsUnicode(false);

            modelBuilder.Entity<evenement>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<t_todo>()
                .Property(e => e.text)
                .IsUnicode(false);
        }
    }
}
