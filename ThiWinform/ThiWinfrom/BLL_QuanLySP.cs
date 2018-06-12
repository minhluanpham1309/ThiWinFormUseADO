using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiWinfrom;

namespace ThiWinfrom
{
    public class BLL_QuanLySP
    {
        Cl_Database db = null;
        public BLL_QuanLySP()
        {
            db = new Cl_Database();
        }
        public DataTable GetListCat(ref string err)
        {
            return db.GetDataTable(ref err, "sp_list_cat", CommandType.StoredProcedure, null);
        }
        public DataTable GetListPro(ref string err)
        {
            return db.GetDataTable(ref err, "sp_list_pro", CommandType.StoredProcedure, null);
        }
        public int GetCatIDWithCatName(ref string err, string catname)
        {
            DataTable dt = GetListCat(ref err);
            int catid = 0;
            foreach (DataRow item in dt.Rows)
            {
                if (item[1].ToString().Equals(catname))
                {
                    catid = (int)item[0];
                    break;
                }  
            }
            return catid;
        }
       
        public DataTable GetListProWithCatID(ref string err, int catid)
        {
            return db.GetDataTable(ref err, "sp_list_pro_catid", CommandType.StoredProcedure, new SqlParameter("@catid", catid));
        }
        public bool AddProduct(ref string err, string proname, string prodes, int catid)
        {
            return db.ExcuteNoQuery(ref err, "sp_Add_pro", CommandType.StoredProcedure, new SqlParameter("@catid", catid), new SqlParameter("@proname", proname),new SqlParameter("@prodes", prodes));
        }
        public bool EditProduct(ref string err,int proid, string proname, string prodes, int catid)
        {
            return db.ExcuteNoQuery(ref err, "sp_update_pro", CommandType.StoredProcedure, new SqlParameter("@proid", proid), new SqlParameter("@catid", catid), new SqlParameter("@proname", proname), new SqlParameter("@prodes", prodes));
        }
        public bool DeletePro(ref string err, int proid)
        {
            return db.ExcuteNoQuery(ref err, "sp_Delete_pro", CommandType.StoredProcedure, new SqlParameter("@proid", proid));
        }
    }
}
