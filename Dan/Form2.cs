using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Dan
{
    public partial class frmCreate : Form
    {
        public static string sgroup, sselectedpart;
        private SQLiteConnection sql_conn;

        public frmCreate()
        {
            InitializeComponent();
        }

        public void LoadMuscleData()
        {
            DBHandeler dh = new DBHandeler();
            DataTable dt = dh.LoadMuscleGData();

            foreach (DataRow item in dt.Rows)
            {
                cbMuscle.Items.Add(item["id"] + "." + item["name"]);
            }
        }

        private void FormCreateLoad(object sender, EventArgs e)
        {
            DirectoryInfo dirpart = new DirectoryInfo(@"C:\CrayManBuilder\" + FormMain.sname + "_" + FormMain.ssurname);

            FileInfo[] filespart = dirpart.GetFiles("*.txt");
            foreach (FileInfo filepart in filespart)
            {
                string filepartfull = filepart.Name;
                int fileextpos = filepartfull.LastIndexOf(".");
                if (fileextpos >= 0)
                    filepartfull = filepartfull.Substring(0, fileextpos);
                cbPart.Items.Add(filepartfull);
            }
            cbPart.SelectedIndex = 0;


            LoadMuscleData();
            cbMuscle.Text = "1.arms";
        }

        private void CBMuscle_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void ButtonClick1(object sender, EventArgs e)
        {

        }

        private void CbMuscle_SelectedValueChanged_1(object sender, EventArgs e)
        {
            //sgroup = cbMuscle.SelectedItem.ToString();

            //cbExercise.Items.Clear();

           // DirectoryInfo direxe = new DirectoryInfo(@"C:\CrayManBuilder\Exercises\" + sgroup + @".txt");

           // string[] s = File.ReadAllLines(@"C:\CrayManBuilder\Exercises\" + sgroup + @".txt");
           // foreach (string line in s)
           // {
           //     string[] str = line.Split(',');
           //     cbExercise.Items.Add(str[0]);
          //  }

           // cbExercise.SelectedIndex = 0;
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (cbPart.SelectedIndex > 0)
            {
                cbPart.SelectedIndex--;
                cbPart.Update();
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (cbPart.SelectedIndex < FormMain.iparts-1)
            {
                cbPart.SelectedIndex ++;
                cbPart.Update();
            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CbPart_SelectedValueChanged(object sender, EventArgs e)
        {
            sselectedpart = cbPart.SelectedItem.ToString();
            lvPartDisp.Items.Clear();
            DirectoryInfo dirpart = new DirectoryInfo(@"C:\CrayManBuilder\" + FormMain.sname + "_" + FormMain.ssurname + @"\" + sselectedpart + @".txt");

            int counter = 0;
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(dirpart.FullName);
            while ((line = file.ReadLine()) != null)
            {

                string whole = line;
                string[] parts = whole.Split(",");
                lvPartDisp.Items.Add(parts[0]);
                lvPartDisp.Items[counter].SubItems.Add(parts[1]);
                lvPartDisp.Items[counter].SubItems.Add(parts[2]);
                lvPartDisp.Items[counter].SubItems.Add(parts[3]);
                lvPartDisp.Items[counter].SubItems.Add(parts[4]);
                lvPartDisp.Items[counter].SubItems.Add(parts[5]);
                lvPartDisp.Items[counter].SubItems.Add(parts[6]);
                lvPartDisp.Items[counter].SubItems.Add(parts[7]);
                counter++;
            }
            file.Close();
        }

        private void LvPartDisp_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void cbExercise_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            lvPartDisp.Update();
            sselectedpart = cbPart.SelectedItem.ToString();
            DirectoryInfo dirpart = new DirectoryInfo(@"C:\CrayManBuilder\" + FormMain.sname + "_" + FormMain.ssurname+@"\"+sselectedpart+@".txt");
            //MessageBox.Show(dirpart.FullName);

            string stext =  cbExercise.SelectedItem.ToString() + "," + Convert.ToInt32(Math.Round(numSets.Value, 0)) + "," +
                            Convert.ToInt32(Math.Round(numSupSets.Value, 0)) + "," + edtReps.Text + "," + edtRest.Text + "," +
                            edtMax.Text + "," + edtWeight.Text + "," + edtTip.Text + "\n";
            File.AppendAllText(dirpart.FullName, stext);
            

            MessageBox.Show(stext);
        }
    }
}
