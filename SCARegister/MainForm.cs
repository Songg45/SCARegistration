using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Gecko.Xpcom.Initialize("Firefox");
            Gecko.GeckoPreferences.User["Network.cookie.cookieBehavior"] = 2;

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            int Pass = 0;

            foreach (Control x in this.Controls)
            {
                if (x is TextBox || x is ComboBox)
                {
                    if (x.Text != "")
                        Pass += 1;
                }

            }

            if (Pass == 6)
            {
                DataTable MainTable = RegistrationData.Tables[0];

                int PriorRow = MainTable.Rows.Count - 1;

                if (PriorRow == -1)
                {

                    AddToTable();
                    return;

                }

                string PriorInput = MainTable.Rows[PriorRow][1].ToString();

                if (PriorInput == RealNameBox.Text)
                {

                    MessageBox.Show("Same input entered!", "Error Detected!");
                    return;

                }

                else
                {

                    AddToTable();

                }

            }

        }

        private void AddToTable()
        {
            DataTable MainTable = RegistrationData.Tables[0];
            MainTable.Rows.Add();
            int RowLocation = MainTable.Rows.Count - 1;

            MainTable.Rows[RowLocation][0] = MemberBox.Text;
            MainTable.Rows[RowLocation][1] = RealNameBox.Text;
            MainTable.Rows[RowLocation][2] = SCANameBox.Text;
            MainTable.Rows[RowLocation][3] = KingdomBox.Text;
            MainTable.Rows[RowLocation][4] = ExpiresBox.Text;
            MainTable.Rows[RowLocation][5] = MembershipActiveBox.Text;

        }

        private void GetMemberButton_Click(object sender, EventArgs e)
        {

            new GetMember(RegistrationData).ShowDialog();
            RegistrationDataView.Update();

        }

    }
}
