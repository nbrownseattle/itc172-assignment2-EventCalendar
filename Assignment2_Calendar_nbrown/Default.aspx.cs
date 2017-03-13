using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string[,] ClubEvent = new string[7, 2];//six events

    protected void Page_Load(object sender, EventArgs e)
    {
        /*ClubEvent[0, 0] = "Monthly Meeting";
        ClubEvent[0, 1] = "03/28/2017";
        ClubEvent[1, 0] = "Apiary Work Party";
        ClubEvent[1, 1] = "04/22/2017";
        ClubEvent[2, 0] = "Lecture WSU Bee Lab";
        ClubEvent[2, 1] = "06/03/2017";
        ClubEvent[3, 0] = "Class: Hive Splitting";
        ClubEvent[3, 1] = "07/15/2017";
        ClubEvent[4, 0] = "Lecture Swarms with Ken Reid";
        ClubEvent[4, 1] = "07/22/2017";
        ClubEvent[5, 0] = "Bee Club Potluck";
        ClubEvent[5, 1] = "07/22/2017";
        ClubEvent[6, 0] = "Class: Honey Extraction 101";
        ClubEvent[6, 1] = "08/08/2017";
        */
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Event.Text = Calendar1.SelectedDate.ToShortDateString();
       
        GetEvent();
    }

    protected void GetEvent()
    {
        ClubEvent[0, 0] = "Monthly Meeting";
        ClubEvent[0, 1] = "3/28/2017";
        ClubEvent[1, 0] = "Apiary Work Party";
        ClubEvent[1, 1] = "4/22/2017";
        ClubEvent[2, 0] = "Lecture WSU Bee Lab";
        ClubEvent[2, 1] = "6/03/2017";
        ClubEvent[3, 0] = "Class: Hive Splitting";
        ClubEvent[3, 1] = "7/15/2017";
        ClubEvent[4, 0] = "Lecture Swarms with Ken Reid";
        ClubEvent[4, 1] = "7/22/2017";
        ClubEvent[5, 0] = "Bee Club Potluck";
        ClubEvent[5, 1] = "7/22/2017";
        ClubEvent[6, 0] = "Class: Honey Extraction 101";
        ClubEvent[6, 1] = "8/08/2017";
        for (int i = 0; i < 7; i++)
        {
            if (Calendar1.SelectedDate.ToShortDateString() == ClubEvent[i, 1])
            {
                Event.Text += " " + ClubEvent[i, 0];
            }
        }
    }
}