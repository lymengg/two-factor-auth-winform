using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleSystem.DataAccess
{
    public class DataAccessObject
    {
        private readonly SqlConnection connection = new("data source=.; database=y2_s2_final;Integrated Security=SSPI;");

        public bool VerifyCredential(string username, string password)
        {
            string query = "select * from tblUser where username=@username and password=@password;";
            SqlCommand cmd = new(query, connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue ("@password", password);
            SqlDataAdapter adapter = new()
            {
                SelectCommand = cmd
            };
            DataTable dt = new();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0 )
            {
                Random random = new();
                dt.Rows[0]["otp_code"] = random.Next(0, 1000000).ToString("D6");
                SqlCommand updateQuery = new("update tblUser set otp_code = @optCode", connection);
                updateQuery.Parameters.AddWithValue("@optCode", random.Next(0, 1000000).ToString("D6"));
                adapter.UpdateCommand = updateQuery;
                adapter.Update(dt);
                return true;
            }

            return false;
        }

        public bool VerifyOTP(string username, string otpCode)
        {
            string query = "select * from tblUser where username=@username;";
            SqlCommand cmd = new(query, connection);
            cmd.Parameters.AddWithValue("@username", username);
            SqlDataAdapter adapter = new()
            {
                SelectCommand = cmd
            };
            DataTable dt = new();
            adapter.Fill(dt);
            MessageBox.Show(dt.Rows[0]["otp_code"].ToString());
            if (dt.Rows.Count > 0 && dt.Rows[0]["otp_code"].ToString() == otpCode)
            {
                return true;
            }

            return false;
        }
    }
}
