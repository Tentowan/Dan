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
    public partial class editExercises : Form
    {
        public editExercises()
        {
            InitializeComponent();
        }

        private DataTable DT = new DataTable();
        private SQLiteConnection sql_conn = new SQLiteConnection();
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
            Person person = new Person("test", "user");
            person.AddPersonToDB();
            Exercise exersise1 = new Exercise(2).GetExercise();
            
            ExerciseField ex1 = new ExerciseField(exersise1);
            ExerciseField ex2 = new ExerciseField(exersise1);
            ExerciseField ex3 = new ExerciseField(exersise1);
            List<ExerciseField> exlist = new List<ExerciseField>
            {
                ex1,
                ex2,
                ex3
            };


            Segment s1 = new Segment("chest",exlist);
            List<Segment> segmentlist = new List<Segment>
            {
                s1
            };
            ExProgram program = new ExProgram(person.GetPersonID(),person.Name1+"_"+person.Surname1,segmentlist);
            program.AddProgramToDB();
        }

        private void BtnAddExercise_Click(object sender, EventArgs e)
        {
            
           
            string[] muscleGroup = MuscleGroupCbb.SelectedItem.ToString().Split('.');
            Exercise exer = new Exercise(0,Convert.ToInt32(muscleGroup[0]), ExersiceNameTxt.Text,TipTxt.Text);
            exer.AddExercise();
            LoadExerciseData();
        }

        private void MuscleGroupCbb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }  
        private void Lblename_Click(object sender, EventArgs e)
        {

        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
