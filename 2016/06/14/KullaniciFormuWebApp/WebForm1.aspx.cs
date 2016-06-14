using System;

namespace KullaniciFormuWebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string t1 = TextBox1.Text,
                   t2 = TextBox2.Text,
                   madalya = "";
            if (t2 == "1")
                madalya = "Altın";
            else if (t2 == "2")
                madalya = "Gümüş";
            else if (t2 == "3")
                madalya = "Bronz";
            Label4.Text = "Sayın " + t1 + " " + madalya + " madalya kazandınız";
        }
    }
}
