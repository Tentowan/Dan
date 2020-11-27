using System;
using System.Collections.Generic;
using System.Text;

namespace Dan
{
    class Exercise
    {

        #region fields
        private int id;
        private int muscleGroup;
        private string exerciseName;
        private string tip;

        #endregion


        #region constructor
        public Exercise(int pid, int pmuscleGroup, string pexerciseName, string ptip)
        {
            this.id = pid;
            this.muscleGroup = pmuscleGroup;
            this.exerciseName = pexerciseName;
            this.tip = ptip;
        }
        #endregion



        #region properties
        public string TipP
        {
            get { return tip; }
            set { tip = value; }
        }


        public string ExerciseNameP
        {
            get { return exerciseName; }
            set { exerciseName = value; }
        }

        public int MuscleGroupP
        {
            get { return muscleGroup; }
            set { muscleGroup = value; }
        }

        public int IDp
        {
            get { return id; }
            set { id = value; }
        }
        #endregion


        #region methods
        DBHandeler dh = new DBHandeler();
        public void AddExercise()
        {
            if (this.tip == "")
            {
                this.tip = "n/a";
            }
            string qry = "INSERT INTO exercises (`id`, `muscleid`, `exerciseName`,`tip`) VALUES (null, '"+this.muscleGroup+"','"+this.exerciseName+"' , '"+this.tip+"')";
            dh.ExecuteQuery(qry);
        }

        public List<Exercise> GetExercises()
        {
            List < Exercise > data = new List<Exercise>();
            return data;
        }
        #endregion
    }
}
