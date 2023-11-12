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
        public bool updateTrangThai(int maPhieuMuon)
        {
            try
            {
                Connect();
                string query = "UPDATE PhieumuonSach SET TinhTrang = @TrangThai WHERE MaPhieuMuon = @MaPhieuMuon";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.Add("@TrangThai", SqlDbType.Int).Value = 1;
                cmd.Parameters.Add("@MaPhieuMuon", SqlDbType.Int).Value = maPhieuMuon;


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
        public bool InsertPhieuMuonSach(PhieuMuonSachDTO phieuMuonSach)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO PHIEUMUONSACH (MaPhieuMuon, NgayMuon, MaDocGia, TinhTrang) VALUES (@MaPhieuMuon, @NgayMuon, @MaDocGia, @TinhTrang)";
                cmd.Connection = conn;
                cmd.Parameters.Add("@MaPhieuMuon", SqlDbType.Int).Value = phieuMuonSach.MaPhieuMuon;
         
                cmd.Parameters.Add("@NgayMuon", SqlDbType.DateTime).Value = phieuMuonSach.NgayMuon;
                cmd.Parameters.Add("@MaDocGia", SqlDbType.Int).Value = phieuMuonSach.MaDocGia;
                cmd.Parameters.Add("@TinhTrang", SqlDbType.Int).Value = 0;

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