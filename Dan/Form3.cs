using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.SQLite;

namespace Dan
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private SQLiteDataAdapter DB;
        private SQLiteConnection sql_conn = new SQLiteConnection();
        private SQLiteCommand sql_cmd;

        DBHandeler dh = new DBHandeler();

        public void LoadExerciseData()
        {
            DT = dh.LoadExercises();
            dataGridView1.DataSource = DT;
            sql_conn.Close();
        }
        public void LoadMuscleData()
        {
            DT = dh.LoadMuscleGData();

            foreach (DataRow item in DT.Rows)
            {
                MuscleGroupCbb.Items.Add(item["id"]+"."+item["name"]);
            }
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            LoadExerciseData();
            LoadMuscleData();
        }

        private void BtnAddExercise_Click(object sender, EventArgs e)
        {
            int m = new int();
            string[] muscleGroup = MuscleGroupCbb.SelectedItem.ToString().Split('.');
            Exercise exer = new Exercise(0,Convert.ToInt32(muscleGroup[0]), ExersiceNameTxt.Text,TipTxt.Text);
            exer.AddExercise();
            LoadExerciseData();
        }

        private void MuscleGroupCbb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }  
        private void lblename_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
