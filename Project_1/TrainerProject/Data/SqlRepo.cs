using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Net.Cache;
using System.Security.Cryptography.X509Certificates;

namespace Data
{
    public class SqlRepo : IRepo
    {
        private readonly string? connectionString;
        public SqlRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Trainerdata Add(Trainerdata trainerdata)
        {


            using SqlConnection con = new SqlConnection(connectionString);

            string query = @"insert into trainerdata (Name,EmailID,Location,Gender,Age,PhoneNumber)values(@Name,@EmailID,@Location,@Gender,@Age,@PhoneNumber)";
            con.Open();
            SqlCommand sqlCommand = new SqlCommand(query, con);

            sqlCommand.Parameters.AddWithValue("@EmailId", trainerdata.EmailID);

            sqlCommand.Parameters.AddWithValue("@Name", trainerdata.Name);

            sqlCommand.Parameters.AddWithValue("@PhoneNumber", trainerdata.PhoneNumber);

            sqlCommand.Parameters.AddWithValue("@Location", trainerdata.Location);

            sqlCommand.Parameters.AddWithValue("@Gender", trainerdata.Gender);

            sqlCommand.Parameters.AddWithValue("@Age", trainerdata.Age);

            int rows = sqlCommand.ExecuteNonQuery();



            string query2 = @"insert into trainerdata(InstitutionName,Degree,Specialization,CGPA,PassingYear) values(@InstitutionName,@Degree,@Specialization,@CGPA,@PassingYear)";

            SqlCommand sqlCommand2 = new SqlCommand(query2, con);

            sqlCommand2.Parameters.AddWithValue("@InstitutionName", trainerdata.InstitutionName);

            sqlCommand2.Parameters.AddWithValue("@Degree", trainerdata.Degree);

            sqlCommand2.Parameters.AddWithValue("@Specialization", trainerdata.Specialization);

            sqlCommand2.Parameters.AddWithValue("@CGPA", trainerdata.CGPA);

            sqlCommand2.Parameters.AddWithValue("PassingYear", trainerdata.PassingYear);

            sqlCommand2.ExecuteNonQuery();



            string query3 = @"insert into trainerdata( Skill1, Skill2, Skill3)values( @Skill1, @Skill2, @Skill3)";

            SqlCommand sqlCommand1 = new SqlCommand(query3, con);

            sqlCommand1.Parameters.AddWithValue("@Skill1", trainerdata.Skill1);

            sqlCommand1.Parameters.AddWithValue("@Skill2", trainerdata.Skill2);

            sqlCommand1.Parameters.AddWithValue("@Skill3", trainerdata.Skill3);

            sqlCommand1.ExecuteNonQuery();


            string query4 = @"insert into trainerdata(trainerID,CompanyName,Experience,Position)values(@trainerID,@CompanyName,@Experience,@Position)";

            SqlCommand sqlCommand3 = new SqlCommand(query4, con);

            sqlCommand3.Parameters.AddWithValue("@CompanyName", trainerdata.CompanyName);

            sqlCommand3.Parameters.AddWithValue("@Experience", trainerdata.Experience);

            sqlCommand3.Parameters.AddWithValue("@Position", trainerdata.Position);

            sqlCommand3.ExecuteNonQuery();

            Console.WriteLine("Signup Completed Successfully!");


            Console.WriteLine(rows + "row(s) added");

            return trainerdata;

        }

        public List<Trainerdata> GetTrainerdatas()
        {
            List<Trainerdata> trainerdata = new List<Trainerdata>();

            try
            {
                using SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = "select Name,PhoneNumber,EmailID,Age,Gender,Location from trainerdata";
                using SqlCommand command = new SqlCommand(query, con);
                using SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    trainerdata.Add(new Trainerdata()
                    {
                        Name = reader.GetString(0),
                        PhoneNumber = reader.GetString(1),
                        EmailID = reader.GetString(2),
                        Location = reader.GetString(3),
                        Gender = reader.GetString(4),
                        Age = reader.GetString(5),
                        InstitutionName = reader.GetString(6),
                        Degree = reader.GetString(7),
                        Specialization = reader.GetString(8),
                        CGPA = reader.GetString(9),
                        PassingYear = reader.GetString(10),
                        CompanyName = reader.GetString(11),
                        Experience = reader.GetString(12),
                        Position = reader.GetString(13),
                        Skill1 = reader.GetString(14),
                        Skill2 = reader.GetString(15),
                        Skill3 = reader.GetString(16),

                    }); ;

                }


            }
            catch (SqlException)
            {
                throw;
            }
            return trainerdata;
        }
        public List<Trainerdata> GetTrainerDisconnected()
         {
                List<Trainerdata> trainerdata = new List<Trainerdata>();
                SqlConnection con = new SqlConnection(connectionString);
                string query5 = "select Name,EmailID,PhoneNumber,Gender,Age,Location,InstitutionName,Degree,Specialization,CGPA,PassingYear,CompanyName,Experience,Position,Skill1,Skill2,Skill3";
                using SqlDataAdapter adapter = new SqlDataAdapter(query5, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dtTrainer = ds.Tables[0];
                foreach(DataRow row in dtTrainer.Rows)
                {
                    trainerdata.Add(new Trainerdata()
                    {
                        Name = (string)row["Name"],
                        EmailID = (string)row["EmailID"],
                        PhoneNumber = (string)row["PhoneNumber"],
                        Location = (string)row["Location"],
                        Gender = (string)row["Gender"],
                        Age = (string)row["Age"],
                        InstitutionName = (string)row["InstitutionName"],
                        Degree = (string)row["Degree"],
                        Specialization = (string)row["Specialization"],
                        CGPA = (string)row["CGPA"],
                        PassingYear = (string)row["PAssingYear"],
                        Skill1 = (string)row["Skill1"],
                        Skill2 = (String)row["SKill2"],
                        Skill3 = (string)row["SKill3"],
                        CompanyName = (string)row["CompanyName"],
                        Experience = (string)row["Experience"],
                        Position = (string)row["Position"]

                    });
                }

                return trainerdata;

        }




    }
    
 }


