using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CRUD
{
    public class ADODOTNET
    {
        private SqlConnection conn;

        public ADODOTNET(string connString)
        {
            conn = new SqlConnection();
            conn.ConnectionString = connString;
        }

        public void ExecuteCreateRequest(int requests)
        {
            conn.Open();
            for (int i = 0; i < requests; i++)
            {
                SqlCommand commandInsert = new SqlCommand("insert into gebruikers (emailadres, wachtwoord, actief, geblokkeerd, geblokkeerd_tot, foutieve_inlogpogingen, reset_token) values ('test@test.test" + i + "', 'x4ugaIby', 0, 0, '9/28/2020', 49, '1f06e5bc-127c-4050-b338-0f753155ac25');", conn);
                commandInsert.ExecuteNonQuery();
            }
            conn.Close();
        }

        public void ExecuteReadRequest(int requests)
        {
            conn.Open();
            for (int i = 0; i < requests; i++)
            {
                SqlCommand commandRead = new SqlCommand("SELECT * FROM gebruikers", conn);
                using (SqlDataReader reader = commandRead.ExecuteReader())
                {
                    reader.Read();
                }
            }
            conn.Close();
        }

        public void ExecuteUpdateRequest(int requests)
        {
            conn.Open();
            for (int i = 0; i < requests; i++)
            {
                SqlCommand commandUpdate = new SqlCommand("UPDATE gebruikers SET emailadres = 'test@test" + (i + 1) + ".com' where emailadres = 'test@test.test" + i + "'", conn);
                commandUpdate.ExecuteNonQuery();
            }
            conn.Close();
        }

        public void ExecuteDeleteRequest(int requests)
        {
            conn.Open();
            for (int i = 0; i < requests; i++)
            {
                SqlCommand commandDelete = new SqlCommand("DELETE FROM gebruikers WHERE emailadres = 'test@test.com'", conn);
                commandDelete.ExecuteNonQuery();
            }
            conn.Close();
        }
    }
}
