using System;
using System.Collections.Generic;
using System.Text;

namespace Dan
{
    class ExProgram
    {
        #region fields
        private int personID;
        private string programName;
        private List<Segment> segments;
        #endregion

        #region constructor
        public ExProgram( int personIDp, string programNamep, List<Segment> segmentsp)
        {
            this.personID = personIDp;
            this.programName = programNamep;
            this.segments = segmentsp;
        }

        #endregion

        #region properties
        public List<Segment> Segments
        {
            get { return segments; }
            set { segments = value; }
        }
        public string ProgramName
        {
            get { return programName; }
            set { programName = value; }
        }

        public int PersonID
        {
            get { return personID; }
            set { personID = value; }
        }

        #endregion
        DBHandeler dh = new DBHandeler();

        #region methods
        public void AddProgramToDB()
        {
            
            string qry = "insert into program(id,personID,programName) values(NULL,"+PersonID+",'"+ProgramName+"')";
            dh.ExecuteQuery(qry);

            int programid = dh.GetProgramIDFromDB();
            foreach (var item in Segments)
            {
                item.AddSegmentToDB(programid);
            }
               
            
        }
        #endregion
    }
}
