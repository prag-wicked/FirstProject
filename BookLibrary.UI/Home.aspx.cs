using BookLibrary.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookLibrary.UI
{
    public partial class Home : System.Web.UI.Page
    {
        MockDB mockDB = new MockDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var allBooks = mockDB.GetBooks();
                foreach (var item in allBooks)
                {
                    DropDownList1.Items.Add(new ListItem(item.Name));
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {             
                if (!DropDownList1.SelectedValue.Equals(null))
                {
                    var text = DropDownList1.SelectedValue;
                    List<BookDetail> bookDetail = mockDB.GetByName(text);

                    foreach (var value in bookDetail)
                    {
                        if (text.Equals(value.Name))
                        {
                            Label lbl1 = new Label();
                            lbl1.Text = value.Author + "<br/>";
                            this.Controls.Add(lbl1);
                            Label lb2 = new Label();
                            lb2.Text = value.Genre;
                            this.Controls.Add(lb2);
                        }                    
                    }
                }              
            }
            catch(Exception ex)
            {
                Literal1.Text = "unknown error occured" + ex.Message;
            }
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = DropDownList1.SelectedValue;
            
           // Label 
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var text = TextBox1.Text;
            List<BookDetail> bookByName = mockDB.GetByName(text);
            try
            {
                foreach (var t in bookByName)
                {
                    Label lbl1 = new Label();
                    lbl1.Text = t.Name;
                    this.Controls.Add(lbl1);
                    Label lbl2 = new Label();
                    lbl2.Text = t.Author;
                    this.Controls.Add(lbl2);
                }
            }
            catch(Exception ex)
            {
                Literal1.Text = "no matching records" + ex.Message;
            }
        }
    }
}