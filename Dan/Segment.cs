using System;
using System.Collections.Generic;
using System.Text;

namespace Dan
{
    class Segment
    {
        #region fields
        private int id;
        private int programID;
        private string segmentName;
        private List<ExerciseField> segments;
        #endregion

        #region constructor
        public Segment(int idp, int programIDp, string segmentNamep, List<ExerciseField> segmentsp)
        {
            this.id = idp;
            this.programID = programIDp;
            this.segmentName = segmentNamep;
            this.segments = segmentsp;
        }
        #endregion

        #region properties
        public List<ExerciseField> Segments
        {
            get { return segments; }
            set { segments = value; }
        }

        public string SegmentName
        {
            get { return segmentName; }
            set { segmentName = value; }
        }


        public int ProgramID
        {
            get { return programID; }
            set { programID = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        #endregion
    }
}
