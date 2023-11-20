using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4NEXT.Admin
{
    public partial class addMember : System.Web.UI.Page
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Graci\\OneDrive\\Desktop\\CSCI 213\\Modual 4\\Assignment4\\NEW\\Assignment4NEXT\\App_Data\\KarateSchool.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=False";

        protected void Page_Load(object sender, EventArgs e)
        {

            KarateDataContext dataConnection = new KarateDataContext(connectionString);

            var result2 = from item in dataConnection.Instructors
                          orderby item.InstructorID
                          select new
                          {
                              InstructorID = item.InstructorID,
                              InstructorFirstName = item.InstructorFirstName,
                              InstructorLastName = item.InstructorLastName
                          };

            // Set AutoTypesLIST's DataSource propery to result of query and bind
            GridView1.DataSource = result2;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            KarateDataContext dataConnection = new KarateDataContext(connectionString);

            string member = "Member";

            NetUser user = new NetUser
            {
                UserName = TextBox6.Text,
                UserPassword = TextBox7.Text,
                UserType = member.ToString()
            };

            dataConnection.NetUsers.InsertOnSubmit(user);

            // Submit changes to the database
            dataConnection.SubmitChanges();

            var result2 = (from item in dataConnection.NetUsers
                           where item.UserName == TextBox6.Text
                           select item.UserID).Single();

            Member member1 = new Member
            {
                Member_UserID = Convert.ToInt32(result2),
                MemberFirstName = TextBox1.Text,
                MemberLastName = TextBox2.Text,
                MemberDateJoined = Convert.ToDateTime(TextBox3.Text),
                MemberPhoneNumber = TextBox4.Text, 
                MemberEmail = TextBox5.Text
            };

            dataConnection.Members.InsertOnSubmit(member1);

            // Submit changes to the database
            dataConnection.SubmitChanges();
        }
    }
}