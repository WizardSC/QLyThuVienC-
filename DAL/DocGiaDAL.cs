using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DocGiaDAL : MSSConnect
    {
        public DataTable getListDocGia()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from DocGia";
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

        public bool insertDocGia(DocGiaDTO docGia)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO DocGia (HoTenDocGia, NgaySinh, Email, DiaChi, NgayLapThe, NgayHetHan, TienNo) VALUES (@HoTenDocGia, @NgaySinh, @Email, @DiaChi, @NgayLapThe, @NgayHetHan, @TienNo)";
                cmd.Connection = conn;
                cmd.Parameters.Add("@HoTenDocGia", SqlDbType.NChar).Value = docGia.HoTenDocGia;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = docGia.NgaySinh;
                cmd.Parameters.Add("@Email", SqlDbType.NChar).Value = docGia.Email;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NChar).Value = docGia.DiaChi;
                cmd.Parameters.Add("@NgayLapThe", SqlDbType.DateTime).Value = docGia.NgayLapThe;
                cmd.Parameters.Add("@NgayHetHan", SqlDbType.DateTime).Value = docGia.NgayHetHan;
                cmd.Parameters.Add("@TienNo", SqlDbType.Float).Value = docGia.TienNo;
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    Console.WriteLine("Lỗi: Vi phạm ràng buộc PRIMARY KEY.");

                }
                else
                {
                    Console.WriteLine("Lỗi:" + ex.Message);
                }


                return false;
            }
            finally
            {
                Disconnect();
            }
        }
        public bool updateDocGia(DocGiaDTO docGia)
        {
            try
            {
                Connect();
                string query = "UPDATE DocGia SET HoTenDocGia = @HoTen, NgaySinh = @NgaySinh, DiaChi = @DiaChi, Email = @Email, NgayLapThe = @NgayLapThe, NgayHetHan = @NgayHetHan, TienNo = @TienNo WHERE MaDocGia = @MaDocGia";
                SqlCommand cmd = new SqlCommand(query, conn);
                //cmd.Connection = conn;
                cmd.Parameters.Add("@MaDocGia", SqlDbType.Int).Value = docGia.MaDocGia;
                cmd.Parameters.Add("@HoTen", SqlDbType.NChar).Value = docGia.HoTenDocGia;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = docGia.NgaySinh;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NChar).Value = docGia.DiaChi;
                cmd.Parameters.Add("@Email", SqlDbType.NChar).Value = docGia.Email;
                cmd.Parameters.Add("@NgayLapThe", SqlDbType.DateTime).Value = docGia.NgayLapThe;
                cmd.Parameters.Add("@NgayHetHan", SqlDbType.DateTime).Value = docGia.NgayHetHan;
                cmd.Parameters.Add("@TienNo", SqlDbType.Float).Value = docGia.TienNo;
                
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

        public bool DeleteDocGia(int maDocGia, out bool isForeignKey)
        {
            try
            {
                Connect();
                string query = "DELETE FROM DocGia WHERE MaDocGia = @MaDocGia";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@MaDocGia", SqlDbType.Int).Value = maDocGia;
                cmd.ExecuteNonQuery();
                isForeignKey = true;
                return true;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    Console.WriteLine("Lỗi: Không thể xóa độc giả vì có khóa ngoại tham chiếu.");
                    isForeignKey = true;
                }
                else
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    isForeignKey = false;
                }
                return false;
            }
            finally
            {
                Disconnect();
            }
        }

        public bool DeleteDocGia(int maDocGia)
        {
            try
            {
                Connect();
                string query = "DELETE FROM DocGia WHERE MaDocGia = @MaDocGia";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@MaDocGia", SqlDbType.Int).Value = maDocGia;
                cmd.ExecuteNonQuery();
               /// isForeignKey = true;
                return true;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    Console.WriteLine("Lỗi: Không thể xóa độc giả vì có khóa ngoại tham chiếu.");
                   // isForeignKey = true;
                }
                else
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                 //   isForeignKey = false;
                }
                return false;
            }
            finally
            {
                Disconnect();
            }
        }
        /*  public DataTable getListDocGia1(int MaDocGia)
          {
              DataTable dt = new DataTable();
              try
              {
                  Connect();
                  SqlCommand cmd = new SqlCommand();
                  cmd.CommandType = CommandType.Text;
                  cmd.CommandText = "select * from DocGia DG, PhieuMuonSach MS where DG.MaDocGia = @MaDocGia AND MS.MaDocGia = @MaDocGia";
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
          }*/
      }

    }
