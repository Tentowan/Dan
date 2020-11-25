using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

                //spath = @"C:\CrayManBuilder\" + sname + "_" + ssurname + @"\sheet1.txt";
                //sexercisepath = @"C:\CrayManBuilder\Exercise\back.txt";

                //Directory.CreateDirectory(Path.GetDirectoryName(spath));

                //for (int i = 1; i <= iparts; i++)
                //{
                //    var myfile =  File.Create(@"C:\CrayManBuilder\" + sname + "_" + ssurname + @"\sheet"+i.ToString()+".txt");
                //    myfile.Close();
                //}

                this.Hide();
                frmCreate newinstance = new frmCreate();
                newinstance.Show();
            }
        }
    }
}
