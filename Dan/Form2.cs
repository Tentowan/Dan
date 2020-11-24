using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Dan
{
    public partial class frmCreate : Form
    {
        public static string sgroup, sselectedpart;
        public frmCreate()
        {
            InitializeComponent();
        }

        private void frmCreate_Load(object sender, EventArgs e)
        {
            DirectoryInfo dirpart = new DirectoryInfo(@"C:\CrayManBuilder\" + frmMain.sname + "_" + frmMain.ssurname);

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

            DirectoryInfo dirgroup = new DirectoryInfo(@"C:\CrayManBuilder\Exercises");

            FileInfo[] filesgroup = dirgroup.GetFiles("*.txt");
            foreach (FileInfo filegroup in filesgroup)
            {
                string filegroupfull = filegroup.Name;
                int fileextpos2 = filegroupfull.LastIndexOf(".");
                if (fileextpos2 >= 0)
                    filegroupfull = filegroupfull.Substring(0, fileextpos2);           
                cbMuscle.Items.Add(filegroupfull);
            }
            cbMuscle.SelectedIndex = 0;

            
        }

        private void cbMuscle_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cbMuscle_SelectedValueChanged_1(object sender, EventArgs e)
        {
            sgroup = cbMuscle.SelectedItem.ToString();

            cbExercise.Items.Clear();

            DirectoryInfo direxe = new DirectoryInfo(@"C:\CrayManBuilder\Exercises\" + sgroup + @".txt");

            string[] s = File.ReadAllLines(@"C:\CrayManBuilder\Exercises\" + sgroup + @".txt");
            foreach (string line in s)
            {
                string[] str = line.Split(',');
                cbExercise.Items.Add(str[0]);
            }

            cbExercise.SelectedIndex = 0;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (cbPart.SelectedIndex > 0)
            {
                cbPart.SelectedIndex = cbPart.SelectedIndex - 1;
                cbPart.Update();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cbPart.SelectedIndex < frmMain.iparts-1)
            {
                cbPart.SelectedIndex = cbPart.SelectedIndex + 1;
                cbPart.Update();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbPart_SelectedValueChanged(object sender, EventArgs e)
        {
            sselectedpart = cbPart.SelectedItem.ToString();
            lvPartDisp.Items.Clear();
            DirectoryInfo dirpart = new DirectoryInfo(@"C:\CrayManBuilder\" + frmMain.sname + "_" + frmMain.ssurname + @"\" + sselectedpart + @".txt");

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

        private void lvPartDisp_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lvPartDisp.Update();
            sselectedpart = cbPart.SelectedItem.ToString();
            DirectoryInfo dirpart = new DirectoryInfo(@"C:\CrayManBuilder\" + frmMain.sname + "_" + frmMain.ssurname+@"\"+sselectedpart+@".txt");
            //MessageBox.Show(dirpart.FullName);

            string stext =  cbExercise.SelectedItem.ToString() + "," + Convert.ToInt32(Math.Round(numSets.Value, 0)) + "," +
                            Convert.ToInt32(Math.Round(numSupSets.Value, 0)) + "," + edtReps.Text + "," + edtRest.Text + "," +
                            edtMax.Text + "," + edtWeight.Text + "," + edtTip.Text + "\n";
            File.AppendAllText(dirpart.FullName, stext);
            

            MessageBox.Show(stext);
        }
    }
}
