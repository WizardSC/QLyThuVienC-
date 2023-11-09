using System;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class PhieuMuonSachDAL : MSSConnect
    {
        public DataTable GetListPhieuMuonSach()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM PHIEUMUONSACH";
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

        public bool InsertPhieuMuonSach(PhieuMuonSachDTO phieuMuonSach)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO PHIEUMUONSACH (NgayMuon, MaDocGia) VALUES (@NgayMuon, @MaDocGia)";
                cmd.Connection = conn;
                cmd.Parameters.Add("@NgayMuon", SqlDbType.DateTime).Value = phieuMuonSach.NgayMuon;
                cmd.Parameters.Add("@MaDocGia", SqlDbType.Int).Value = phieuMuonSach.MaDocGia;
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

        // Các hàm Update và Delete tương tự như BangCapDAL
    }
}