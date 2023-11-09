using System;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class CTPhieuMuonSachDAL : MSSConnect
    {
        public bool InsertCTPhieuMuonSach(CTPhieuMuonSachDTO ctPhieuMuonSach)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CHITIETPHIEUMUON (MaSach, MaPhieuMuon) VALUES (@MaSach, @MaPhieuMuon)";
                cmd.Connection = conn;
                cmd.Parameters.Add("@MaSach", SqlDbType.Int).Value = ctPhieuMuonSach.MaSach;
                cmd.Parameters.Add("@MaPhieuMuon", SqlDbType.Int).Value = ctPhieuMuonSach.MaPhieuMuon;
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

        // Các hàm Update và Delete tương tự như các lớp khác
    }
}
