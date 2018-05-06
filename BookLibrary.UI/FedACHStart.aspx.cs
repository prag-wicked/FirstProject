using BookLibrary.UI.FedAchServiceReference;
using BookLibrary.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookLibrary.UI
{
    public partial class FedACHStart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            Label1.Text = "FedACHList";
            string searchValue = TextBox1.Text;
            FedAchStart fedAchStart = new FedAchStart();
            fedAchStart.StartService(searchValue);

        }
    }
}