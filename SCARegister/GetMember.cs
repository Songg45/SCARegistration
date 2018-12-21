using Gecko;
using Gecko.DOM;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class GetMember : Form

    {
        private DataSet MainData;
        public GetMember(DataSet RegistrationData)
        {
            this.MainData = RegistrationData;
            InitializeComponent();
        }

        public string RealName, SCAName, Kingdom, Expires, Status, MemberNumber = "";

        private void GetMember_Load(object sender, EventArgs e)
        {

            MemberWeb.Navigate("https://members.sca.org/apps/#SignIn");

        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (MemberWeb.Url.ToString() != "https://members.sca.org/apps/#MbrManage")
            {
                MemberHelp.Text = "Please log in first";
                return;
            }
            else
            {
                try
                {

                    GeckoElementCollection WebCollection = MemberWeb.Document.GetElementsByTagName("div");
                    int Count = 0;
                 
                    foreach (GeckoHtmlElement currentTag in WebCollection)
                    {
                        Count += 1;
                        switch (Count)
                        {
                            case 17:
                                MemberNumber = currentTag.InnerHtml;
                                break;

                            case 18:
                                RealName = currentTag.InnerHtml;
                                break;

                            case 22:
                                SCAName = currentTag.InnerHtml;
                                break;

                            case 20:
                                Kingdom = currentTag.InnerHtml;
                                break;

                            case 23:
                                Expires = currentTag.InnerHtml;
                                break;

                            case 24:
                                Status = currentTag.InnerHtml;
                                break;
                        }

                    }

                }
                catch (Exception)
                {

                    MemberHelp.Text = "Something went wrong while fetching information";

                }

                TestOutputAndMove();
                DeleteCookie();
                this.Close();

            }
            
        }
        private void TestOutputAndMove ()
        {
            
            if (RealName != "" && Kingdom != "" && Expires != "" && Status != "" &&
                MemberNumber != "")
            {
                DataTable MainTable = MainData.Tables[0];

                MainTable.Rows.Add();

                int RowLocation = MainTable.Rows.Count;
                RowLocation = RowLocation - 1;

                MainTable.Rows[RowLocation][0] = MemberNumber;
                MainTable.Rows[RowLocation][1] = RealName;
                MainTable.Rows[RowLocation][2] = SCAName;
                MainTable.Rows[RowLocation][3] = Kingdom;
                MainTable.Rows[RowLocation][4] = Expires;
                MainTable.Rows[RowLocation][5] = Status;

            }
            else
            {

                MemberHelp.Text = "Error inputting data from website to database";

            }



        }

        private void DeleteCookie()
        {

            var cookies = Gecko.CookieManager.GetEnumerator();

            while (cookies.MoveNext())
            {
                if (cookies.Current.RawHost == "members.sca.org")
                {
                    Gecko.CookieManager.Remove(cookies.Current.Host, cookies.Current.Name, cookies.Current.Path, false);
                }
            }

        }
    }
}
