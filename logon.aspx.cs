﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4NEXT
{
    public partial class logon : System.Web.UI.Page
    {
        /*
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string userName = Login1.UserName;
            string pass = Login1.Password;

            //read data from Database. Validate input


            if (userName == "cat" && pass == "cat")
            {

                FormsAuthentication.RedirectFromLoginPage(userName, true);


            }
            else
                Response.Redirect("logon.aspx", true);

        }
        */
        //Connect to the database
        KarateDataContext dbcon;
        string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\16123\\Source\\Repos\\gracie82003\\Assignment4NEXT_NOV17\\App_Data\\KarateSchool.mdf;Integrated Security=True;Connect Timeout=30";

        protected void Page_Load(object sender, EventArgs e)
        {
            //Initialize connection string 
            dbcon = new KarateDataContext(conn);
          
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

            string nUserName = Login1.UserName;
            string nPassword = Login1.Password;


            HttpContext.Current.Session["nUserName"] = nUserName;
            HttpContext.Current.Session["uPass"] = nPassword;



            // Search for the current User, validate UserName and Password
            NetUser myUser = (from x in dbcon.NetUsers
                              where x.UserName == HttpContext.Current.Session["nUserName"].ToString()
                                    && x.UserPassword == HttpContext.Current.Session["uPass"].ToString()
                                    select x).First();

            if (myUser != null)
            {
                //Add UserID and User type to the Session
                HttpContext.Current.Session["userID"] = myUser.UserID;
                HttpContext.Current.Session["userType"] = myUser.UserType;

            }
            if (myUser != null && HttpContext.Current.Session["userType"].ToString().Trim() == "Instructor")
            {

                FormsAuthentication.RedirectFromLoginPage(HttpContext.Current.Session["nUserName"].ToString(), true);

                Response.Redirect("~/Instructors/instructorpage.aspx");
            }
            else if (myUser != null && HttpContext.Current.Session["userType"].ToString().Trim() == "Member")
            {

                FormsAuthentication.RedirectFromLoginPage(HttpContext.Current.Session["nUserName"].ToString(), true);

                Response.Redirect("~/Mymembers/memberpage.aspx");
            }
            else
                Response.Redirect("Logon.aspx", true);


        }
    }


}
