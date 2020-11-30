using System;
using System.Collections.Generic;
using System.Text;

namespace Dan
{
    class ExProgram
    {
        #region fields
        private int id;
        private int personID;
        private string programName;
        private List<Segment> segments;
        #endregion

        #region constructor
        public ExProgram(int idp, int personIDp, string programNamep)
        {
            this.id = idp;
            this.personID = personIDp;
            this.programName = programNamep;
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


        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        #endregion

        #region methods

        #endregion
    }
}
