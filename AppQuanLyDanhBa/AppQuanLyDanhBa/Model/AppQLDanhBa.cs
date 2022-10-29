using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AppQuanLyDanhBa.Model
{
    public partial class AppQLDanhBa : DbContext
    {
        public AppQLDanhBa()
            : base("name=AppQLDanhBa")
        {
        }

        public virtual DbSet<Nguoi> Nguoi { get; set; }
        public virtual DbSet<Nhom> Nhom { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nhom>()
                .HasMany(e => e.Nguoi)
                .WithOptional(e => e.Nhom)
                .HasForeignKey(e => e.IDNhom);
        }
    }
}
