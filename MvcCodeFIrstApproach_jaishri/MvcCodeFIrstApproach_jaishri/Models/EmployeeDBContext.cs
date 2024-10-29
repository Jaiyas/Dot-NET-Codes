using Microsoft.EntityFrameworkCore;

namespace MvcCodeFIrstApproach_jaishri.Models
{
    public class EmployeeDBContext:DbContext
    {
public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options)
        {

        }
public DbSet<EmployeeModel> employees { get; set; }
    }
}
