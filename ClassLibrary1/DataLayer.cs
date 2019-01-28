using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using ClassLibrary3;

namespace ClassLibrary1
{
   
    public interface IDataAccessLayer
    {
        void InsertData(UserPL objPl);
        object SelectData();
    }

    public class DataLayer : IDataAccessLayer
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ThreetierArc.Properties.Settings.Threetier"].ToString());

        public void InsertData(UserPL obPl)
        {
            SqlDataAdapter ada = new SqlDataAdapter("Insert into UserInfo values('"+obPl.Name+"', '"+obPl.City+"','"+obPl.Email+"')",con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
        }

        public object SelectData()
        {
            SqlDataAdapter ada = new SqlDataAdapter("Select * from UserInfo", con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            return dt;
        }
    }
}
