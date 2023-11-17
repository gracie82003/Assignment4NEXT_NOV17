using Assignment4NEXT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4NEXT.Mymembers
{
    public partial class memberspage : System.Web.UI.Page
    {

        KarateDataContext dbcon;
        string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Graci\\OneDrive\\Desktop\\CSCI 213\\Modual 4\\Assignment4\\NEW\\Assignment4NEXT\\App_Data\\KarateSchool.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            dbcon = new KarateDataContext(conn);

            //string myUserName=User.Identity.Name;

            string myUserName = "user1";

           
            var res=from x in dbcon.NetUsers
                    select x.UserName;


            
            GridView1.DataSource = res;
            GridView1.DataBind();
        }
    }
}

