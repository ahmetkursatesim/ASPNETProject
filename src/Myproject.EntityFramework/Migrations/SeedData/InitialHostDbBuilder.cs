using Myproject.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Myproject.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly MyprojectDbContext _context;

        public InitialHostDbBuilder(MyprojectDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
