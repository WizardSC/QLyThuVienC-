using System;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class SachDAL : MSSConnect
    {
        public DataTable GetListSach()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM SACH";
                cmd.Connection = conn;
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }
            return dt;
        }

        public bool InsertSach(SachDTO sach)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO SACH (TenSach, TacGia, NamXuatBan, NhaXuatBan, TriGia, NgayNhap) VALUES (@TenSach, @TacGia, @NamXuatBan, @NhaXuatBan, @TriGia, @NgayNhap)";
                cmd.Connection = conn;
                cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = sach.TenSach;
                cmd.Parameters.Add("@TacGia", SqlDbType.NVarChar).Value = sach.TacGia;
                cmd.Parameters.Add("@NamXuatBan", SqlDbType.Int).Value = sach.NamXuatBan;
                cmd.Parameters.Add("@NhaXuatBan", SqlDbType.NVarChar).Value = sach.NhaXuatBan;
                cmd.Parameters.Add("@TriGia", SqlDbType.Float).Value = sach.TriGia;
                cmd.Parameters.Add("@NgayNhap", SqlDbType.DateTime).Value = sach.NgayNhap;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
        }

        public bool UpdateSach(SachDTO sach)
        {
            try
            {
                Connect();
                string query = "UPDATE SACH SET TenSach = @TenSach, TacGia = @TacGia, NamXuatBan = @NamXuatBan, NhaXuatBan = @NhaXuatBan, TriGia = @TriGia, NgayNhap = @NgayNhap WHERE MaSach = @MaSach";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = sach.TenSach;
                cmd.Parameters.Add("@TacGia", SqlDbType.NVarChar).Value = sach.TacGia;
                cmd.Parameters.Add("@NamXuatBan", SqlDbType.Int).Value = sach.NamXuatBan;
                cmd.Parameters.Add("@NhaXuatBan", SqlDbType.NVarChar).Value = sach.NhaXuatBan;
                cmd.Parameters.Add("@TriGia", SqlDbType.Float).Value = sach.TriGia;
                cmd.Parameters.Add("@NgayNhap", SqlDbType.DateTime).Value = sach.NgayNhap;
                cmd.Parameters.Add("@MaSach", SqlDbType.Int).Value = sach.MaSach;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
        }

        public bool DeleteSach(int maSach)
        {
            try
            {
                Connect();
                string query = "DELETE FROM SACH WHERE MaSach = @MaSach";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@MaSach", SqlDbType.Int).Value = maSach;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
