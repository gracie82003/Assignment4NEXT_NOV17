using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4NEXT.Admin
{
    public partial class addInstructor : System.Web.UI.Page
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Graci\\OneDrive\\Desktop\\CSCI 213\\Modual 4\\Assignment4\\NEW\\Assignment4NEXT\\App_Data\\KarateSchool.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=False";

            protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            KarateDataContext dataConnection = new KarateDataContext(connectionString);

            string instructor = "Instructor";

            NetUser user = new NetUser
            {
                UserName = TextBox4.Text,
                UserPassword = TextBox5.Text,
                UserType = instructor.ToString()
            };

            dataConnection.NetUsers.InsertOnSubmit(user);

            // Submit changes to the database
            dataConnection.SubmitChanges();

            var result2 = (from item in dataConnection.NetUsers
                           where item.UserName == TextBox4.Text
                           select item.UserID).Single();

            Instructor instructor1 = new Instructor
            {
                InstructorID = Convert.ToInt32(result2),
                InstructorFirstName = TextBox1.Text,
                InstructorLastName = TextBox3.Text,
                InstructorPhoneNumber = TextBox2.Text
            };

            dataConnection.Instructors.InsertOnSubmit(instructor1);

            // Submit changes to the database
            dataConnection.SubmitChanges();

        }
    }
}