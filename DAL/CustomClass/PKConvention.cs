using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CustomClass
{
   public class PKConvention: Convention
    {
        public PKConvention() => Properties()
                .Where(p => p.Name == p.DeclaringType.Name + "_Id")
                .Configure(p => p.IsKey());

    }
}
