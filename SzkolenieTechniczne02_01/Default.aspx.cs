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
            if (IsPostBack) return;
            InitAge();
            InitResources();
            InitGender();
        }

        #region Methods

        void InitResources()
        {
            lblName.Text = GlobalResource.Name;
            lblAge.Text = GlobalResource.Age;
            lblInfo.Text = GlobalResource.Information;
            btnSend.Text = GlobalResource.Send;
            btnClear.Text = GlobalResource.Clear;
            lblGender.Text = GlobalResource.Gender;
        }

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

        void InitGender()
        {
            cblGender.Items.Add(GlobalResource.Men);
            cblGender.Items.Add(GlobalResource.Women);
        }

        bool ControlIsNummOrEmpty()
        {
            return string.IsNullOrEmpty(txtName.Text)
                   || string.IsNullOrEmpty(ddlAge.SelectedValue) 
                   || string.IsNullOrEmpty(cblGender.SelectedValue);
        }

        #endregion

        #region Events

        protected void btnSend_Click(object sender, EventArgs e)
        {
            if (ControlIsNummOrEmpty())
                return;
            panelInfo.Visible = true;
            txtInfo.Text += $"Imię: {txtName.Text} " +
                            $"Wiek: {ddlAge.SelectedValue}" +
                            $"Płeć: {cblGender.SelectedValue}\n";
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            ddlAge.SelectedIndex = 0;
            txtInfo.Text = "";
            panelInfo.Visible = false;
        }

        #endregion
    }
}