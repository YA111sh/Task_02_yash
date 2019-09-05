using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ImageTask02
{
    public partial class Upload2 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Click(object sender, EventArgs e)
        {
            if(!Directory.Exists(Server.MapPath("Images")))
            {
                Directory.CreateDirectory(Server.MapPath("Images"));
            }
            string imageurl = (Server.MapPath("Images") + "\\" + UploadImage.FileName);
            string dppathimg = "~/Images/" + UploadImage.FileName;
            UploadImage.SaveAs(imageurl);
            SqlCommand command = new SqlCommand("insert ImageMaster (UserImage) values (@UserImage)", conn);
            command.Parameters.AddWithValue("@UserImage", dppathimg);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}