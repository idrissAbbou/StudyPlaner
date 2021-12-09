using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StudyPlan
{
    public class StudyContext : DbContext
    {
        public DbSet<Subject> subjects { get; set; }
    }
}
