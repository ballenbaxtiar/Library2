using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library2
{

    internal class Language
    {
      public static SqlConnection con = Connection.con;

        
        public static string backup = "";
        public static string type_book = "";
        public static string user = "";
        public static string take_book = "";
        public static string ended = "";
        public static string koga = "";
        public static string expired = "";
        public static string get_back = "";
        public static string back = "";
        public static string home = "";


        public static void translate()
        {
            string lang = "";
           con.Close();
           con.Open();
            SqlCommand cmd = new SqlCommand("select * from language",con);
            SqlDataReader dd = cmd .ExecuteReader();
            if (dd.Read())
            {
                lang = dd["language"].ToString();
            }


            if (lang== "کوردی")
            {
                backup = "پاراستنی داتا";
                type_book = "جۆرەکانی کتێب";
                user = "هەژمارەکان";
                take_book = "بردنی کتێب";
                ended = "تەواوبوەکان";
                koga = "کۆگای کتێب";
                expired = "بەسەرچووەکان";
                back = "هێنانەوە";
                get_back = "هێنان و بردنەکان";
                home= "سەرەکی";
                
            }
            else
            {
                backup = "Backup";
                type_book = "Type of books";
                user = "Users";
                take_book = "Get book";
                ended = "Run out of books";
                koga = "store of books";
                expired = "Expired";
                back = "Back";
                get_back = "Back and get";
                home = "‌Main";

            }

    con.Close();
        }

    }
}
