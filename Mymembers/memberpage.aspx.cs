using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4NEXT.Mymembers
{
    public partial class memberpage : System.Web.UI.Page
    {
        
        KarateDataContext dbcon;
        string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\16123\\Source\\Repos\\gracie82003\\Assignment4NEXT_NOV17\\App_Data\\KarateSchool.mdf;Integrated Security=True;Connect Timeout=30";

        protected void Page_Load(object sender, EventArgs e)
        {
            //Initialize connection string 
            dbcon = new KarateDataContext(conn);

          
            Label1.Text = LoginName1.ToString();
        }
        
        
    }
}