using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLY_QUANAN
{
    internal class SQL
    {
        private string chuoi = "Data Source=DESKTOP-NOVMU8K\\ZUYHAIDAO;Initial Catalog=QUANLYQUANAN;Integrated Security=True";
        public string getChuoi()
        {
            return chuoi;
        }
    }
}
