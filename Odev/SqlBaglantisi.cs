using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Odev
{
    public class SqlBaglantisi
    {
        public OleDbConnection baglanti()
        {
            //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\bin\Debug\Database1.accdb
            //Provider = Microsoft.Jet.OLEDB.4.0; Data Source = DataDirectory|\bin\Debug\Database1.mdb; User Id = admin; Password =;
            OleDbConnection baglan = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\musta\OneDrive\Masaüstü\C# Projects\Odev\Odev\bin\Debug\bilgiler.mdb");
            baglan.Open();
            return baglan;

        }
    }
}
