using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public class FileHadeler    
{
    class FileHandler
    {
        #region Fields
        StreamReader reader;
        StreamWriter writer;
        FileStream stream;
        string filePathPrime;
        #endregion

        #region Constructors
        public FileHandler(string filePath = "default.txt")
        {
            this.filePathPrime = filePath;
        }

        public FileHandler()
        {

        }
        #endregion

        #region methods

        public List<string> ReadData(string filePath)
        {
            List<string> data = new List<string>();
            try
            {
                stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(stream);

                while (!reader.EndOfStream)
                {
                    data.Add(reader.ReadLine());
                }
            }
            catch (FileNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("Directory Not Found");
            }
            catch (IOException)
            {
                System.Windows.Forms.MessageBox.Show("Error");
            }
            finally
            {
                reader.Close();
                stream.Close();
            }

            return data;
        }



        public void WriteData(List<ItemClass> data, string fileName, bool isAppend)
        {
            try
            {
                if (isAppend)
                    stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                else
                    stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(stream);
                foreach (var s in data)
                {

                    writer.WriteLine("\n");
                    writer.Write(s + ",");
                }
            }
            catch (FileNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("Directory Not Found");
            }
            catch (IOException)
            {
                System.Windows.Forms.MessageBox.Show("Error");
            }

            finally
            {
                writer.Close();
                stream.Close();
            }
        }


        #endregion
    }
}
