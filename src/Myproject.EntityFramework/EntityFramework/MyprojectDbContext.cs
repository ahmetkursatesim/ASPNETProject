using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using Myproject.Authorization.Roles;
using Myproject.Authorization.Users;
using Myproject.MultiTenancy;
using Myproject.Book;
using Myproject.Authors;
using Myproject.UserPhotos;

namespace Myproject.EntityFramework
{
    public class MyprojectDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...


       
        public DbSet<Author> Author { get; set; }
        public DbSet<UserImage> UserImage { get; set; }
        public DbSet<BookDb> BookModel { get; set; }
        public MyprojectDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in MyprojectDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of MyprojectDbContext since ABP automatically handles it.
         */
        public MyprojectDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public MyprojectDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public MyprojectDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
