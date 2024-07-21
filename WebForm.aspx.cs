using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment4
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Rainbow rainbow = new Rainbow();
                IEnumerator<string> enumerator = rainbow.GetEnumerator();

                while (enumerator.MoveNext())
                {
                    string color = enumerator.Current;
                    lstColorsUppercase.Items.Add(color.ToUpper());
                    lstColorsLowercase.Items.Add(color.ToLower());
                }
            }
        }

        protected void lstColorsUppercase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}