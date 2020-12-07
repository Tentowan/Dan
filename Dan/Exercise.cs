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


        #region constructors
        public Exercise(int pid, int pmuscleGroup, string pexerciseName, string ptip)
        {
            this.id = pid;
            this.muscleGroup = pmuscleGroup;
            this.exerciseName = pexerciseName;
            this.tip = ptip;
        }
        public Exercise(int idp)
        {
            this.id = idp;
        }
        public Exercise()
        {

        }
        #endregion



        #region properties
        public string Tip
        {
            get { return tip; }
            set { tip = value; }
        }


        public string ExerciseName
        {
            get { return exerciseName; }
            set { exerciseName = value; }
        }

        public int MuscleGroup
        {
            get { return muscleGroup; }
            set { muscleGroup = value; }
        }

        public int ID
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
        public Exercise GetExercise()
        { 
           return dh.GetExDataFromDB(ID);   
        }
        #endregion
    }
}
