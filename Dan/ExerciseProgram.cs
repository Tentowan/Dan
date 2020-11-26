using System;
using System.Collections.Generic;
using System.Text;

namespace Dan
{
    class ExerciseProgram
    {
        #region fields
        private string muscleGroup;
        private string exercise;
        private int sets;
        private int superSets;
        private int reps;
        private int max;
        private int weight;
        private string tip;
        #endregion

        #region contructor
        public ExerciseProgram(string PmuscleGroup = "", string Pexercise ="", int Psets=0, int PsuperSets=0, int Preps=0, int Pmax=0, int Pweight=0, string Ptip="")
        {
            this.muscleGroup = PmuscleGroup;
            this.exercise = Pexercise;
            this.sets = Psets;
            this.superSets = PsuperSets;
            this.reps = Preps;
            this.max = Pmax;
            this.weight = Pweight;
            this.tip = Ptip;
    }
        #endregion

        #region getters
        public string TipP
        {
            get { return tip; }
            set { tip = value; }
        }

        public int WeightP
        {
            get { return weight; }
            set { weight = value; }
        }

        public int MaxP
        {
            get { return max; }
            set { max = value; }
        }

        public int RepsP
        {
            get { return reps; }
            set { reps = value; }
        }


        public int SuperSetsP
        {
            get { return superSets; }
            set { superSets = value; }
        }

        public int SetsP
        {
            get { return sets; }
            set { sets = value; }
        }

        public string ExerciseP
        {
            get { return exercise; }
            set { exercise = value; }
        }

        public string MuscleGroupP
        {
            get { return muscleGroup; }
            set { muscleGroup = value; }
        }
        #endregion

        #region methods
        public List<ExerciseProgram> GetExercisePrograms(string dir)
        {
            List<ExerciseProgram> data = new List<ExerciseProgram>();
            FileHandeler fa = new FileHandeler();
            
            foreach (var item in fa.ReadData(dir))
            {
                string[] splitter = item.Split(',');
                data.Add(new ExerciseProgram(splitter[0], splitter[1], Convert.ToInt32(splitter[2]), Convert.ToInt32(splitter[3]), Convert.ToInt32(splitter[4]), Convert.ToInt32(splitter[5]), Convert.ToInt32(splitter[6]), splitter[7]));
            }

            return data;
        }
        #endregion
    }
}
