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
            string[]arr = trainerdata.EmailID.Split("@");
            string userId = arr[0];

            using SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            string query = @"insert into  TrainerDetails(user_id,Name,EmailID,Location,Gender,Age,PhoneNumber,Password)values(@userID,@Name,@EmailID,@Location,@Gender,@Age,@PhoneNumber,@Password)";


            SqlCommand sqlCommand = new SqlCommand(query, con);

            sqlCommand.Parameters.AddWithValue("@userID", userId);

            sqlCommand.Parameters.AddWithValue("@EmailId", trainerdata.EmailID);

            sqlCommand.Parameters.AddWithValue("@Name", trainerdata.Name);

            sqlCommand.Parameters.AddWithValue("@PhoneNumber", trainerdata.PhoneNumber);

            sqlCommand.Parameters.AddWithValue("@Location", trainerdata.Location);

            sqlCommand.Parameters.AddWithValue("@Gender", trainerdata.Gender);

            sqlCommand.Parameters.AddWithValue("@Age", trainerdata.Age);

            sqlCommand.Parameters.AddWithValue("@Password", trainerdata.Password);

            int rows = sqlCommand.ExecuteNonQuery();



            string query2 = @"insert into Education_Details(user_id ,institutionName,Degree,Specialization,PassingYear) values(@userID,@InstitutionName,@Degree,@Specialization,@PassingYear)";

            SqlCommand sqlCommand2 = new SqlCommand(query2, con);

            sqlCommand2.Parameters.AddWithValue("@userID", userId);

            //sqlCommand.Parameters.AddWithValue("@userID", 102);

            sqlCommand2.Parameters.AddWithValue("@InstitutionName", trainerdata.institutionName);

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

       /* public List<Trainerdata> GetTrainerdatas()
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
                        institutionName = reader.GetString(6),
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
        }*/
        /*public List<Trainerdata> GetTrainerDisconnected()
        {
            List<Trainerdata> trainerdata = new List<Trainerdata>();
            SqlConnection con = new SqlConnection(connectionString);
            string query5 = "select Name,EmailID,PhoneNumber,Gender,Age,Location,institutionName,Degree,Specialization,CGPA,PassingYear,CompanyName,Experience,Position,Skill1,Skill2,Skill3";
            using SqlDataAdapter adapter = new SqlDataAdapter(query5, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable dtTrainer = ds.Tables[0];
            foreach (DataRow row in dtTrainer.Rows)
            {
                trainerdata.Add(new Trainerdata()
                {
                    Name = (string)row["Name"],
                    EmailID = (string)row["EmailID"],
                    PhoneNumber = (string)row["PhoneNumber"],
                    Location = (string)row["Location"],
                    Gender = (string)row["Gender"],
                    Age = (string)row["Age"],
                    institutionName = (string)row["institutionName"],
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

*/
        public bool Login(string email)
        {
            string query9 = $"select EmailID from TrainerDetails where EmailID='{email}'";

            using SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            SqlCommand command9 = new SqlCommand(query9, con);

            SqlDataReader reader = command9.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();
                Console.WriteLine("Enter Password");

                string? password = Console.ReadLine();

                string query10 = $"select Password from TrainerDetails where Password='{password}'";

                SqlCommand command11 = new SqlCommand(query10, con);
                using SqlDataReader reader3 = command11.ExecuteReader();
                if (reader3.Read())
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




        public Trainerdata GetATrainer(string Email)
        {

            Trainerdata tdata = new Trainerdata();
            String[] arr = Email.Split("@");
            string userID = arr[0];

            string query1 = $@"select Name,PhoneNumber,Location,Gender from TrainerDetails where user_id='{userID}'";


            using SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand command1 = new SqlCommand(query1, con);
            SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {


                tdata.Name = reader1.GetString(0);
                tdata.PhoneNumber = reader1.GetString(1);
                tdata.Location = reader1.GetString(2);
                tdata.Gender = reader1.GetString(3);
                tdata.EmailID = Email;


            }
            reader1.Close();

            string query2 = $@"select Skill1,Skill2,Skill3 from Skills_Details where user_id='{userID}'";

            SqlCommand command2 = new SqlCommand(query2, con);
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                tdata.Skill1 = reader2.GetString(0);
                tdata.Skill2 = reader2.GetString(1);
                tdata.Skill3 = reader2.GetString(2);


            }
            reader2.Close();

            string query3 = $@"select institutionName,Degree,Specialization,PassingYear from Education_Details where user_id='{userID}'";

            SqlCommand command3 = new SqlCommand(query3, con);
            SqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {

                tdata.institutionName = reader3.GetString(0);
                tdata.Degree = reader3.GetString(1);
                tdata.Specialization = reader3.GetString(2);
                tdata.PassingYear = reader3.GetString(3);
            }
            reader3.Close();

            string query4 = $@"select CompanyName,Experienec Position from Company_Detail where user_id ='{userID}'";
            SqlCommand command4 = new SqlCommand(query3, con);
            SqlDataReader reader4 = command3.ExecuteReader();
            while (reader4.Read())
            {
                tdata.CompanyName = reader4.GetString(0);
                tdata.Experience = reader4.GetString(1);
                tdata.Position = reader4.GetString(2);

            }
            reader4.Close();
            return tdata;
        }


    }

}