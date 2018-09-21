using System.Linq;
using Myproject.EntityFramework;
using Myproject.MultiTenancy;

namespace Myproject.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly MyprojectDbContext _context;

        public DefaultTenantCreator(MyprojectDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
