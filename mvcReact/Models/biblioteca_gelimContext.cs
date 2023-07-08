using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace mvcReact.Models
{
    public partial class biblioteca_gelimContext : DbContext
    {
        public biblioteca_gelimContext()
        {
        }

        public biblioteca_gelimContext(DbContextOptions<biblioteca_gelimContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Autore> Autores { get; set; }
        public virtual DbSet<AutoresLibro> AutoresLibros { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<CategoriasLibro> CategoriasLibros { get; set; }
        public virtual DbSet<Editoriale> Editoriales { get; set; }
        public virtual DbSet<EditorialesLibro> EditorialesLibros { get; set; }
        public virtual DbSet<Libro> Libros { get; set; }
        public virtual DbSet<Multa> Multas { get; set; }
        public virtual DbSet<Prestamo> Prestamos { get; set; }
        public virtual DbSet<Reserva> Reservas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local); Database=biblioteca_gelim; Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Autore>(entity =>
            {
                entity.HasKey(e => e.IdAutor)
                    .HasName("PK__Autores__9626AD26B582B606");

                entity.Property(e => e.IdAutor)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Autor");

                entity.Property(e => e.Biografia)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Nacimiento");

                entity.Property(e => e.Nacionalidad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AutoresLibro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Autores_Libros");

                entity.Property(e => e.IdAutor).HasColumnName("ID_Autor");

                entity.Property(e => e.IdLibro).HasColumnName("ID_Libro");

                entity.HasOne(d => d.IdAutorNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdAutor)
                    .HasConstraintName("FK__Autores_L__ID_Au__4BAC3F29");

                entity.HasOne(d => d.IdLibroNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdLibro)
                    .HasConstraintName("FK__Autores_L__ID_Li__4CA06362");
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__Categori__02AA078543816525");

                entity.Property(e => e.IdCategoria)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Categoria");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CategoriasLibro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Categorias_Libros");

                entity.Property(e => e.IdCategoria).HasColumnName("ID_Categoria");

                entity.Property(e => e.IdLibro).HasColumnName("ID_Libro");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK__Categoria__ID_Ca__5165187F");

                entity.HasOne(d => d.IdLibroNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdLibro)
                    .HasConstraintName("FK__Categoria__ID_Li__52593CB8");
            });

            modelBuilder.Entity<Editoriale>(entity =>
            {
                entity.HasKey(e => e.IdEditorial)
                    .HasName("PK__Editoria__BCB52C7839E6FC21");

                entity.Property(e => e.IdEditorial)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Editorial");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SitioWeb)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Sitio_Web");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EditorialesLibro>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Editoriales_Libros");

                entity.Property(e => e.IdEditorial).HasColumnName("ID_Editorial");

                entity.Property(e => e.IdLibro).HasColumnName("ID_Libro");

                entity.HasOne(d => d.IdEditorialNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdEditorial)
                    .HasConstraintName("FK__Editorial__ID_Ed__4E88ABD4");

                entity.HasOne(d => d.IdLibroNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdLibro)
                    .HasConstraintName("FK__Editorial__ID_Li__4F7CD00D");
            });

            modelBuilder.Entity<Libro>(entity =>
            {
                entity.HasKey(e => e.IdLibro)
                    .HasName("PK__Libros__B1E7FA10414B2857");

                entity.Property(e => e.IdLibro)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Libro");

                entity.Property(e => e.AnioPublicacion).HasColumnName("Anio_Publicacion");

                entity.Property(e => e.Autor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Categoria)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CopiasDisponibles).HasColumnName("Copias_Disponibles");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Editorial)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Isbn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ISBN");

                entity.Property(e => e.Titulo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Multa>(entity =>
            {
                entity.HasKey(e => e.IdMulta)
                    .HasName("PK__Multas__8512E565DF22E9AE");

                entity.Property(e => e.IdMulta)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Multa");

                entity.Property(e => e.EstadoMulta)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Estado_Multa");

                entity.Property(e => e.FechaGeneracion)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Generacion");

                entity.Property(e => e.IdPrestamo).HasColumnName("ID_Prestamo");

                entity.Property(e => e.MontoMulta)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Monto_Multa");

                entity.HasOne(d => d.IdPrestamoNavigation)
                    .WithMany(p => p.Multa)
                    .HasForeignKey(d => d.IdPrestamo)
                    .HasConstraintName("FK__Multas__ID_Prest__4316F928");
            });

            modelBuilder.Entity<Prestamo>(entity =>
            {
                entity.HasKey(e => e.IdPrestamo)
                    .HasName("PK__Prestamo__FE17DB1700CAB302");

                entity.Property(e => e.IdPrestamo)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Prestamo");

                entity.Property(e => e.FechaDevolucionPrevista)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Devolucion_Prevista");

                entity.Property(e => e.FechaDevolucionReal)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Devolucion_Real");

                entity.Property(e => e.FechaPrestamo)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Prestamo");

                entity.Property(e => e.IdLibro).HasColumnName("ID_Libro");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_Usuario");

                entity.HasOne(d => d.IdLibroNavigation)
                    .WithMany(p => p.Prestamos)
                    .HasForeignKey(d => d.IdLibro)
                    .HasConstraintName("FK__Prestamos__ID_Li__3B75D760");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Prestamos)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Prestamos__ID_Us__3C69FB99");
            });

            modelBuilder.Entity<Reserva>(entity =>
            {
                entity.HasKey(e => e.IdReserva)
                    .HasName("PK__Reservas__12CAD9F49168F0C2");

                entity.Property(e => e.IdReserva)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Reserva");

                entity.Property(e => e.EstadoReserva)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Estado_Reserva");

                entity.Property(e => e.FechaReserva)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Reserva");

                entity.Property(e => e.IdLibro).HasColumnName("ID_Libro");

                entity.Property(e => e.IdUsuario).HasColumnName("ID_Usuario");

                entity.HasOne(d => d.IdLibroNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.IdLibro)
                    .HasConstraintName("FK__Reservas__ID_Lib__3F466844");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Reservas__ID_Usu__403A8C7D");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuarios__DE4431C589C10ED7");

                entity.Property(e => e.IdUsuario)
                    .ValueGeneratedNever()
                    .HasColumnName("ID_Usuario");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contrasena)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_Registro");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
