using System;
using System.Collections.Generic;
using System.Text;

namespace Dan
{
    class ExerciseField
    {
        #region fields
        private Exercise exercise;
        private int sets;
        private int superSets;
        private int reps;
        private int max;
        private int weight;

        #endregion

        #region contructor
        public ExerciseField(Exercise exerciseP, int setsP = 0, int superSetsP = 0, int repsP = 0, int maxP = 0, int weightP = 0)
        {
            this.exercise = exerciseP;
            this.sets = setsP;
            this.superSets = superSetsP;
            this.reps = repsP;
            this.max = maxP;
            this.weight = weightP;

        }
        #endregion

        #region getters
        public Exercise Exercise
        {
            get { return exercise; }
            set { exercise = value; }
        }


        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Max
        {
            get { return max; }
            set { max = value; }
        }

        public int Reps
        {
            get { return reps; }
            set { reps = value; }
        }


        public int SuperSets
        {
            get { return superSets; }
            set { superSets = value; }
        }

        public int Sets
        {
            get { return sets; }
            set { sets = value; }
        }

        #endregion
        #region methods
        public void AddSegmentToDB()
        {

        }
        #endregion
    }
}
