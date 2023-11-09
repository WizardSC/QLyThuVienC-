using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuThuTienDAL : MSSConnect
    {
        public DataTable GetListPhieuThuTien()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM PHIEUTHUTIEN";
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

        public bool InsertPhieuThuTien(PhieuThuTienDTO phieuThuTien)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO PHIEUTHUTIEN (SoTienNo, SoTienThu, MaDocGia, MaNhanVien) " +
                                  "VALUES (@SoTienNo, @SoTienThu, @MaDocGia, @MaNhanVien)";
                cmd.Connection = conn;
                cmd.Parameters.Add("@SoTienNo", SqlDbType.Float).Value = phieuThuTien.SoTienNo;
                cmd.Parameters.Add("@SoTienThu", SqlDbType.Float).Value = phieuThuTien.SoTienThu;
                cmd.Parameters.Add("@MaDocGia", SqlDbType.Int).Value = phieuThuTien.MaDocGia;
                cmd.Parameters.Add("@MaNhanVien", SqlDbType.Int).Value = phieuThuTien.MaNhanVien;
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
