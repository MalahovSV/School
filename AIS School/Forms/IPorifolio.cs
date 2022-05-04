using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_School
{
    internal interface IPorifolio
    {
        DataSet LoadData(string PkUser);
    }
}
