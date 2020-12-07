using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace Dan
{
    class DBHandeler
    {
        private SQLiteConnection sql_conn;
        private SQLiteCommand sql_cmd;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private SQLiteDataAdapter DB;


        public void SetConnection()
        {
            sql_conn = new SQLiteConnection("Data Source=./db.db;Version=3;");
        }

        public SQLiteConnection ReturnConnection()
        {
            return sql_conn = new SQLiteConnection("Data Source=./db.db;Version=3;");
        }

        public DataTable LoadExercises()
        {
            SetConnection();
            sql_conn.Open();
            sql_cmd = sql_conn.CreateCommand();
            string CommandText = "select * from exercises";
            DB = new SQLiteDataAdapter(CommandText, sql_conn);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            return DT;
        }
        public DataTable LoadMuscleGData()
        {


            SetConnection();
            sql_conn.Open();
            string query = "Select * from musclegroup";
            DataSet ds = new DataSet();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, sql_conn);
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }

        public void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_conn.Open();
            sql_cmd = sql_conn.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_conn.Close();
        }

        public int GetProgramIDFromDB()
        {
            SetConnection();
            sql_conn.Open();
            int id = 0;
            string qry = "SELECT `id` FROM `program` ORDER BY `id` DESC limit 1";
            DataSet ds = new DataSet();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(qry, sql_conn);
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];

            foreach (DataRow item in dt.Rows)
            {
                id =  Convert.ToInt32(item["id"]);
            }
            return id;
        }

        public int GetSegmentIDFromDB()
        {
            SetConnection();
            sql_conn.Open();
            int id = 0;
            string qry = "SELECT `id` FROM `program_segment` ORDER BY id DESC limit 1";
            DataSet ds = new DataSet();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(qry, sql_conn);
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];

            foreach (DataRow item in dt.Rows)
            {
                id = Convert.ToInt32(item["id"]);
            }
            return id;
        }
        public int GetPersonIDFromDB()
        {
            SetConnection();
            sql_conn.Open();
            int id = 0;
            string qry = "SELECT `id` FROM `person` ORDER BY id DESC limit 1";
            DataSet ds = new DataSet();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(qry, sql_conn);
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];

            foreach (DataRow item in dt.Rows)
            {
                id = Convert.ToInt32(item["id"]);
            }
            return id;
        }
        public Exercise GetExDataFromDB(int id)
        {
            string qry = "SELECT * FROM `exercises` Where `id` =" + id;
            SetConnection();
            sql_conn.Open();


            Exercise ex = new Exercise();
            DataSet ds = new DataSet();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(qry, connection: sql_conn);
            adapter.Fill(ds);
            
            DataTable dt = ds.Tables[0];

            foreach (DataRow item in dt.Rows)
            {
                ex = new Exercise(Convert.ToInt32(item["id"]), Convert.ToInt32(item["muscleid"]), item["exerciseName"].ToString(), item["tip"].ToString());
            }
            return ex;
        }
    }
}
