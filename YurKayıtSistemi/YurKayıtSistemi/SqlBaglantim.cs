using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace YurKayıtSistemi
{
    internal class SqlBaglantim
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-KDH31I7F;Initial Catalog=YurtOtomasyon;Integrated Security=True");
         baglan.Open();
            return baglan;

        }
    }
}
