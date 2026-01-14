using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Library2
{
    internal class Connection
    {
        public static SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Library2;Integrated Security=True");
    }
}
