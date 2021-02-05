using System;
using System.Windows.Forms;

namespace Dan
{
    public partial class FormMain : Form
    {
        //public static string sname;
        //public static string ssurname;
        //public static int iparts;
        //public static string spath;
        //public static string sexercisepath;

        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnCont_Click(object sender, EventArgs e)
        {
            //sname = edtName.Text;
            //ssurname = edtSurname.Text;

            //iparts = Convert.ToInt32(Math.Round(numParts.Value, 0));

            //if (sname == "" || ssurname == "")
            //{
            //    MessageBox.Show("Client's name is blank"); 
            //}
            //else
            //{

            //    Person p = new Person(sname,ssurname);
            //    p.MakePeronFile(iparts);
            //    p.AddPersonToDB();
            //    this.Hide();
            //    frmCreate newinstance = new frmCreate();
            //    newinstance.Show();
            //}
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            editExercises d = new editExercises();
            d.Show();
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage d = new MainPage();
            d.Show();

        }
    }
}
