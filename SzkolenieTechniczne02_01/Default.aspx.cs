using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SzkolenieTechniczne02_01
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitAge();
            }
        }

        #region Methods

        void InitAge()
        {
            ddlAge.Items.Add(new ListItem());
            for (int i = 1; i <= 100; i++)
            {
                ddlAge.Items.Add(
                    new ListItem
                    {
                        Text = i.ToString(),
                        Value = i.ToString()
                    }
                );
            }
        }

        bool ControlIsNummOrEmpty()
        {
            return string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(ddlAge.SelectedValue);
        }

        #endregion

        #region Events

        protected void btnSend_Click(object sender, EventArgs e)
        {
            if (ControlIsNummOrEmpty())
                return;
            panelInfo.Visible = true;
            txtInfo.Text += $"Imię: {txtName.Text} Wiek: {ddlAge.SelectedValue}\n";
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}