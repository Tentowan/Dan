using System;
using System.Collections.Generic;
using System.Text;

namespace Dan
{
    class Segment
    {
        #region fields
        private int programID;
        private string segmentName;
        private List<ExerciseField> segments;
        #endregion

        #region constructor
        public Segment(int programIDp, string segmentNamep, List<ExerciseField> segmentsp)
        {
            this.programID = programIDp;
            this.segmentName = segmentNamep;
            this.segments = segmentsp;
        }
        public Segment(string segmentNamep, List<ExerciseField> segmentsp)
        {
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
        #endregion

        #region methods
        DBHandeler dh = new DBHandeler();
        public void AddSegmentToDB(int programid)
        {

            string segqry = "insert into program_segment(id,programID,segment) VALUES(null," + programid + ", '" + this.SegmentName + "')";
            int segid = dh.GetSegmentIDFromDB();

            dh.ExecuteQuery(segqry);
            foreach (var item in Segments)
            {
                item.AddFieldToDB(segid);
            }
        }
        #endregion
    }
}
