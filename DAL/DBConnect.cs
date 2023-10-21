using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
       protected SqlConnection _con = new SqlConnection(@"Data Source=LAPTOP-ANTLCG4B\SQLEXPRESS;Initial Catalog=doann;Integrated Security=True");
    }
}
