using System;
using System.Windows.Forms;

namespace Dan
{
    public partial class frmMain : Form
    {
        public static string sname;
        public static string ssurname;
        public static int iparts;
        public static string spath;
        public static string sexercisepath;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            sname = edtName.Text;
            ssurname = edtSurname.Text;

            iparts = Convert.ToInt32(Math.Round(numParts.Value, 0));

            if (sname == "" || ssurname == "")
            {
                MessageBox.Show("Client's name is blank"); 
            }
            else
            {

                Person p = new Person(sname,ssurname);
                p.MakePeronFile(iparts);

                this.Hide();
                frmCreate newinstance = new frmCreate();
                newinstance.Show();
            }
        }
    }
}
