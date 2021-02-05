using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Dan
{
    public partial class NewSegement : Form
    {
        public NewSegement()
        {
            InitializeComponent();
        }

        private DataTable DT = new DataTable();
        private SQLiteConnection sql_conn = new SQLiteConnection();
        DBHandeler dh = new DBHandeler();


        private void NewSegement_Load(object sender, EventArgs e)
        {
            // loads the muscle group combo box 
            DT = dh.LoadMuscleGData();
            cbbMuscGroup.DataSource = DT;
            cbbMuscGroup.DisplayMember = "name";
            cbbMuscGroup.ValueMember = "id";

            
        }

        private void btnAddExToSegment_Click(object sender, EventArgs e)
        {
            // create a field in program meta 
            int exerciseID = Convert.ToInt32(cbbExercise.SelectedValue);
            //MessageBox.Show(cbbExercise.Text + " " + cbbExercise.SelectedValue);
        }

        private void cbbMuscGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            // when the combo box of the muscle group changes the exercise combo box
            // so it searches the db by muscle group and only shows exercises in that group
            var i = cbbMuscGroup.SelectedValue;
            DT = dh.LoadSpesificExercises(1);
            cbbExercise.DataSource = DT;
            cbbExercise.ValueMember = "id";
            cbbExercise.DisplayMember = "exerciseName";


        }
    }
}
