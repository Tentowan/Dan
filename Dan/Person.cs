using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
            this.Name = pSurname;
            this.Surname = pSurname;
        }

        #endregion

        #region methods

        public void MakePeronFile(int numOfFiles)
        {
            string name = this.Name;
            string sname = this.Surname;
            List<string> empt = new List<string>();
            string filename = "sheet"; 
            FileHandeler fa = new FileHandeler();
            string path = @"C:\ruantest\" + name + "_" + sname + @"\";
            Directory.CreateDirectory(Path.GetDirectoryName(path));

            for (int i = 1; i <= numOfFiles; i++)
            {
                fa.WriteData(empt, path + filename + i+".txt", false);
            }
            
        }

        #endregion

    }
}
