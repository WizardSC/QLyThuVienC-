using System;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class BangCapDAL : MSSConnect
    {
        public DataTable GetListBangCap()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM BANGCAP";
                cmd.Connection = conn;
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi:" + ex.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }
            return dt;
        }

        public bool InsertBangCap(BangCapDTO bangCap)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO BANGCAP (TenBangCap) VALUES (@TenBangCap)";
                cmd.Connection = conn;
                cmd.Parameters.Add("@TenBangCap", SqlDbType.NVarChar).Value = bangCap.TenBangCap;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi:" + ex.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
        }

        public bool UpdateBangCap(BangCapDTO bangCap)
        {
            try
            {
                Connect();
                string query = "UPDATE BANGCAP SET TenBangCap = @TenBangCap WHERE MaBangCap = @MaBangCap";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@TenBangCap", SqlDbType.NVarChar).Value = bangCap.TenBangCap;
                cmd.Parameters.Add("@MaBangCap", SqlDbType.Int).Value = bangCap.MaBangCap;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi:" + ex.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
        }

        public bool DeleteBangCap(int maBangCap)
        {
            try
            {
                Connect();
                string query = "DELETE FROM BANGCAP WHERE MaBangCap = @MaBangCap";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@MaBangCap", SqlDbType.Int).Value = maBangCap;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi:" + ex.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
