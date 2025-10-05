using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace HotelDreamSTS
{
    public class DataAccess
    {
        private SqlConnection sqlCon;
           public SqlConnection SqlCon
        {
            get{return this.sqlCon;}
            set { this.sqlCon= value; }
        }
           private SqlCommand sqlCom;
           public SqlCommand SqlCom
        {
            get { return this.sqlCom; }
            set { this.sqlCom = value; }
        }
            private SqlDataAdapter sda;
           public SqlDataAdapter Sda
         {
             get { return this.sda; }
             set { this.sda= value; }
        }
         private DataSet ds;
           public DataSet Ds
                {
                  get{return this.ds;}
                  set{this.ds=value;}
                }
           public DataAccess()
           {
               this.SqlCon = new SqlConnection(@"Data Source=DESKTOP-9LQADLV;Initial Catalog=ProjectC#;User ID=sa;Password=9095");
            //this.SqlCon = new SqlConnection(@"Data Source=DESKTOP-KA2838Q;Initial Catalog=ProjectC#;Persist Security Info=True;User ID=sa;Password=QETUOwryip1999*");
            
               this.SqlCon.Open();
           }
         private void QueryText(string query)
         {
             this.SqlCom = new SqlCommand(query, SqlCon);
         }
         public DataSet ExecuteQuery(string sql)
         {
             this.QueryText(sql);
             this.Sda = new SqlDataAdapter(SqlCom);
             this.Ds = new DataSet();
             this.Sda.Fill(Ds);
             return this.Ds;
         }

         public DataTable ExecuteQueryTable(string sql)
         {
             this.QueryText(sql);
             this.Sda = new SqlDataAdapter(SqlCom);
             this.Ds = new DataSet();
             this.Sda.Fill(Ds);
             return this.Ds.Tables[0];
         }

         public int ExecuteDML(string sql)
         {
             this.QueryText(sql);
             int u = this.SqlCom.ExecuteNonQuery();
                 return u;
         }
    }
}
