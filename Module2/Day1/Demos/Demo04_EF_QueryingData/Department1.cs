using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04_EF_QueryingData
{
    public partial class Department
    {
        public override string ToString()
        {
            return this.ID + "\t" + this.Name + "\t" + this.EmployeeCount;
        }
    }
}
