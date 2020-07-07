using ApplicationCore.EF;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<Cartdetail> Cartdetail { get; set; }
        public virtual DbSet<Classify> Classify { get; set; }
        public virtual DbSet<Complain> Complain { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<Laptop> Product { get; set; }
        public virtual DbSet<Promotion> Promotion { get; set; }
        public virtual DbSet<Trademark> Trademark { get; set; }
        public virtual DbSet<Userinformation> UserInformation {get;set;}

        //         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //         {
        //             if (!optionsBuilder.IsConfigured)
        //             {
        //                 optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=laptop;Trusted_Connection=True;");
        //             }
        //         }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Userinformation>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK__userinfo__B7C926384607B758");

                entity.ToTable("userinformation");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(255);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(50);

                entity.Property(e => e.NameUser).HasMaxLength(255);

                entity.Property(e => e.Numberphone).HasColumnName("numberphone");
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.HasKey(e => e.Idcart)
                    .HasName("PK__cart__4581138DCE425A7E");

                entity.ToTable("cart");

                entity.Property(e => e.Idcart).HasColumnName("IDcart");

                entity.Property(e => e.Createday)
                    .HasColumnName("createday")
                    .HasColumnType("date");

                entity.Property(e => e.Idaccount)
                    .HasColumnName("IDaccount")
                    .HasMaxLength(450);

                entity.Property(e => e.Totalprice)
                    .HasColumnName("totalprice")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<Cartdetail>(entity =>
            {
                entity.HasKey(e => e.Idcartdetail)
                    .HasName("PK__cartdeta__6431700507C70DC7");

                entity.ToTable("cartdetail");

                entity.Property(e => e.Idcartdetail).HasColumnName("IDcartdetail");

                entity.Property(e => e.Idcart)
                    .HasColumnName("IDcart")
                    .HasMaxLength(450);

                entity.Property(e => e.Idproduct)
                    .HasColumnName("IDproduct")
                    .HasMaxLength(450);

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(255);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("money");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.IdcartNavigation)
                    .WithMany(p => p.Cartdetail)
                    .HasForeignKey(d => d.Idcart)
                    .HasConstraintName("FK__cartdetai__IDcar__7F2BE32F");
            });

            modelBuilder.Entity<Classify>(entity =>
            {
                entity.HasKey(e => e.Idclassify)
                    .HasName("PK__classify__1FB14F2BD4F85462");

                entity.ToTable("classify");

                entity.Property(e => e.Idclassify).HasColumnName("IDclassify");

                entity.Property(e => e.Nameclassify)
                    .HasColumnName("nameclassify")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Complain>(entity =>
            {
                entity.HasKey(e => e.Idcomplain)
                    .HasName("PK__complain__9289DDF5FBC9B005");

                entity.ToTable("complain");

                entity.Property(e => e.Idcomplain).HasColumnName("IDcomplain");

                entity.Property(e => e.Createday)
                    .HasColumnName("createday")
                    .HasColumnType("date");

                entity.Property(e => e.Idaccount)
                    .HasColumnName("IDaccount")
                    .HasMaxLength(450);

                entity.Property(e => e.Idcartdetail)
                    .HasColumnName("IDcartdetail")
                    .HasMaxLength(450);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Laptop>(entity =>
            {
                entity.HasKey(e => e.Idlaptop)
                    .HasName("PK__laptop__F8074072FBDEE2CC");

                entity.ToTable("laptop");

                entity.Property(e => e.Idlaptop).HasColumnName("IDlaptop");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.Idclassify)
                    .HasColumnName("IDclassify")
                    .HasMaxLength(450);

                entity.Property(e => e.Idtrademark)
                    .HasColumnName("IDtrademark")
                    .HasMaxLength(450);

                entity.Property(e => e.LinkImg)
                    .HasColumnName("linkIMG")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Namelaptop)
                    .HasColumnName("namelaptop")
                    .HasMaxLength(255);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("money");

                entity.Property(e => e.Priceselling)
                    .HasColumnName("priceselling")
                    .HasColumnType("money");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdclassifyNavigation)
                    .WithMany(p => p.Laptop)
                    .HasForeignKey(d => d.Idclassify)
                    .HasConstraintName("FK__laptop__IDclassi__7D439ABD");

                entity.HasOne(d => d.IdtrademarkNavigation)
                    .WithMany(p => p.Laptop)
                    .HasForeignKey(d => d.Idtrademark)
                    .HasConstraintName("FK__laptop__IDtradem__7E37BEF6");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.HasKey(e => e.Idnotification)
                    .HasName("PK__notifica__36098EECB40032C1");

                entity.ToTable("notification");

                entity.Property(e => e.Idnotification).HasColumnName("IDnotification");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasMaxLength(255);

                entity.Property(e => e.Idaccount).HasColumnName("IDaccount");
            });

            modelBuilder.Entity<Promotion>(entity =>
            {
                entity.HasKey(e => e.Idpromotion)
                    .HasName("PK__promotio__53DC425E87CDD7D3");

                entity.ToTable("promotion");

                entity.Property(e => e.Idpromotion).HasColumnName("IDpromotion");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasMaxLength(255);

                entity.Property(e => e.Createday)
                    .HasColumnName("createday")
                    .HasColumnType("date");

                entity.Property(e => e.Idlaptop)
                    .HasColumnName("IDlaptop")
                    .HasMaxLength(450);

                entity.Property(e => e.LinkImg)
                    .HasColumnName("linkIMG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Linkimgpromotion)
                    .HasColumnName("linkimgpromotion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Trademark>(entity =>
            {
                entity.HasKey(e => e.Idtrademark)
                    .HasName("PK__trademar__9120D53811A52407");

                entity.ToTable("trademark");

                entity.Property(e => e.Idtrademark).HasColumnName("IDtrademark");

                entity.Property(e => e.Trademark1)
                    .HasColumnName("trademark")
                    .HasMaxLength(255);
            });

            //OnModelCreatingPartial(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
