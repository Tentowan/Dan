using System;
using System.Collections.Generic;
using System.IO;
using System.Data.SQLite;


namespace Dan
{
    class Person
    {
        #region fields

        private string Name;
        private string Surname;

       

        #endregion

        #region contructor
        public Person(string pName ="basic",string pSurname = "person")
        {
            this.Name1 = pName;
            this.Surname1 = pSurname;
        }

        public string Name1 { get => Name; set => Name = value; }
        public string Surname1 { get => Surname; set => Surname = value; }

        #endregion

        #region methods

        public void MakePeronFile(int numOfFiles)
        {
            string name = this.Name1;
            string sname = this.Surname1;
            List<string> empt = new List<string>();
            string filename = "sheet"; 
            FileHandeler fa = new FileHandeler();
            string path = @"C:\CrayManBuilder\" + name + "_" + sname + @"\";
            Directory.CreateDirectory(Path.GetDirectoryName(path));

            for (int i = 1; i <= numOfFiles; i++)
            {
                fa.WriteData(empt, path + filename + i+".txt", false);
            }
            
        }
        public void AddPersonToDB()
        {
            DBHandeler dh = new DBHandeler();
            //INSERT INTO person (`id`, `name`, `surname`) VALUES(null, 'doos' , 'poes')
            string qry = @"INSERT INTO person (`id`, `name`, `surname`) VALUES(null,'"+ this.Name1 +"' , '"+this.Surname1+"')";
            dh.ExecuteQuery(qry);
        }
        private int ExecuteWrite(string query, Dictionary<string, object> args)
        {
            int numberOfRowsAffected;

            //setup the connection to the database
            using var con = new SQLiteConnection("Data Source=test.db");
            con.Open();

            //open a new command
            using (var cmd = new SQLiteCommand(query, con))
            {
                //set the arguments given in the query
                foreach (var pair in args)
                {
                    cmd.Parameters.AddWithValue(pair.Key, pair.Value);
                }

                //execute the query and get the number of row affected
                numberOfRowsAffected = cmd.ExecuteNonQuery();
            }

            return numberOfRowsAffected;
        }
        #endregion

    }
}
