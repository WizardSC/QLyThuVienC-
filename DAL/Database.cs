using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAL
{
    public class Database : MSSConnect
    {
        public DataTable LayDSNhanvien()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select Manhanvien, HoTenNhanVien, Ngaysinh,Diachi,Dienthoai, TenBangcap From Nhanvien N, BANGCAP B Where N.MaBangCap=B.MaBangCap";
                cmd.Connection = conn;
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                Disconnect();
            }
            return dt;
        }

        public DataTable LayBangcap()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from bangcap";
                cmd.Connection = conn;
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                Disconnect();
            }
            return dt;
        }
        public bool XoaNhanVien(int index_nv)
        {

            try
            {
                Connect();
                string query = "Delete from NhanVien where MaNhanVien = " + index_nv;
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.ExecuteNonQuery();
                return true;


            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi: " + e.Message);

                return false;
            }
            finally
            {
                Disconnect();
            }
        }

        public bool ThemNhanVien(string ten, string ngaysinh, string diachi, string dienthoai, string index_bc)
        {

            try
            {
                Connect();
                string query =  string.Format("Insert Into NHANVIEN Values(N'{0}', '{1}', N'{2}', '{3}',{4})",ten, ngaysinh, diachi, dienthoai, index_bc);
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.ExecuteNonQuery();
                return true;


            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi: " + e.Message);

                return false;
            }
            finally
            {
                Disconnect();
            }
        }

        public bool CapNhatNhanVien(int index_nv, string hoten,string ngaysinh, string diachi, string dienthoai, string index_bc)
        {

            try
            {
                Connect();
                string query = string.Format("Update NHANVIEN set HoTenNhanVien = N'{0}', NgaySinh = '{1}', diachi = N'{2}', dienthoai = '{3}', MaBangCap = {4}  where MaNhanVien = {5}", hoten, ngaysinh, diachi, dienthoai, index_bc, index_nv);

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.ExecuteNonQuery();
                return true;


            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi: " + e.Message);

                return false;
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
