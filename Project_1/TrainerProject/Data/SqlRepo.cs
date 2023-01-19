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
            int userId = 123;

            using SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            string query = @"insert into  TrainerDetails(user_id,Name,EmailID,Location,Gender,Age,PhoneNumber,Password)values(@userID,@Name,@EmailID,@Location,@Gender,@Age,@PhoneNumber,@Password)";

           
            SqlCommand sqlCommand = new SqlCommand(query, con);

            sqlCommand.Parameters.AddWithValue("@userID",userId);

            sqlCommand.Parameters.AddWithValue("@EmailId", trainerdata.EmailID);

            sqlCommand.Parameters.AddWithValue("@Name", trainerdata.Name);

            sqlCommand.Parameters.AddWithValue("@PhoneNumber", trainerdata.PhoneNumber);

            sqlCommand.Parameters.AddWithValue("@Location", trainerdata.Location);

            sqlCommand.Parameters.AddWithValue("@Gender", trainerdata.Gender);

            sqlCommand.Parameters.AddWithValue("@Age", trainerdata.Age);

            sqlCommand.Parameters.AddWithValue("@Password", trainerdata.Password);

            int rows = sqlCommand.ExecuteNonQuery();



            string query2 = @"insert into Education_Details(user_id ,InstitutionName,Degree,Specialization,PassingYear) values(@userID,@InstitutionName,@Degree,@Specialization,@PassingYear)";

            SqlCommand sqlCommand2 = new SqlCommand(query2, con);

            sqlCommand2.Parameters.AddWithValue("@userID", userId);

            //sqlCommand.Parameters.AddWithValue("@userID", 102);

            sqlCommand2.Parameters.AddWithValue("@InstitutionName", trainerdata.InstitutionName);

            sqlCommand2.Parameters.AddWithValue("@Degree", trainerdata.Degree);

            sqlCommand2.Parameters.AddWithValue("@Specialization", trainerdata.Specialization);

            sqlCommand2.Parameters.AddWithValue("PassingYear", trainerdata.PassingYear);

            sqlCommand2.ExecuteNonQuery();



            string query3 = @"insert into Skills_Details( user_id,Skill1, Skill2, Skill3)values(@userID, @Skill1, @Skill2, @Skill3)";

            SqlCommand sqlCommand1 = new SqlCommand(query3, con);

            sqlCommand1.Parameters.AddWithValue("@userID", userId);

            sqlCommand1.Parameters.AddWithValue("@Skill1", trainerdata.Skill1);

            sqlCommand1.Parameters.AddWithValue("@Skill2", trainerdata.Skill2);

            sqlCommand1.Parameters.AddWithValue("@Skill3", trainerdata.Skill3);

            sqlCommand1.ExecuteNonQuery();



            string query4 = @"insert into Company_Detail(user_id,CompanyName,Experience,Position)values(@userID,@CompanyName,@Experience,@Position)";

            SqlCommand sqlCommand3 = new SqlCommand(query4, con);

            sqlCommand3.Parameters.AddWithValue("@userID", userId);

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
                string query = "select Name,PhoneNumber,EmailID,Age,Gender,Location from TrainerDetails";
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


        public bool Login(string email)
        {
            string query9 = $"select EmailID from TrainerDetails where EmailID='{email}'";

            using SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            SqlCommand command9 = new SqlCommand(query9, con);

            SqlDataReader reader= command9.ExecuteReader();

            if(reader.Read())
            {
                reader.Close();
                Console.WriteLine("Enter Password");

                string? password = Console.ReadLine();

                string query10 = $"select Password from TrainerDetails where Password='{password}'";

                SqlCommand command11 = new SqlCommand(query10, con);
                using SqlDataReader reader3= command11.ExecuteReader();
                if(reader3.Read())
                {
                    Console.WriteLine("successfull login");

                    
                    return true;
                }
                else
                {
                    Console.WriteLine("wrong Password");

                    reader3.Close();
                    return false;
                }

                
            }
            else
            {
                Console.WriteLine("wrong EmailID");
                reader.Close();
                return false;
            }



        }






    }
    
 }


