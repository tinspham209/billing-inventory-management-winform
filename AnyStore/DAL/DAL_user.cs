using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using AnyStore.BLL;

namespace AnyStore.DAL
{
    class DAL_User
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region Select Data from Database
        public DataTable Select()
        {
            // Static Method to connect db
            SqlConnection conn = new SqlConnection(myconnstrng);

            // ToolBar hold the data from db

            DataTable dt = new DataTable();
            try
            {
                // SQL Query to Get data from db
                String sql = "SELECT * FROM tbl_users";
                //For executing Command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Getting data from db
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //db connection open
                conn.Open();
                //fill data in dataTable
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
        #region Insert Data in DB
        public bool Insert(BLL_User u)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                String sql = "INSERT INTO tbl_users (first_name, last_name, email, username, password, contact, address, gender, user_type, added_date, added_by) VALUES (@first_name, @last_name, @email, @username, @password, @contact, @address, @gender, @user_type, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@first_name", u.first_name);
                cmd.Parameters.AddWithValue("@last_name", u.last_name);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                cmd.Parameters.AddWithValue("@user_type", u.user_type);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query is excute successfully then the value to rows will be greater than 0 else it will be less than 0
                if(rows > 0)
                {
                    //Query Successfull
                    isSuccess = true;
                }
                else
                {
                    //query failed
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
        #region update data in db
        public bool Update(BLL_User u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "UPDATE tbl_users SET first_name=@first_name, last_name=@last_name, email=@email, username=@username, password=@password, contact=@contact, address=@address, gender=@gender, user_type=@user_type, added_date=@added_date, added_by=@added_by WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@first_name", u.first_name);
                cmd.Parameters.AddWithValue("@last_name", u.last_name);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                cmd.Parameters.AddWithValue("@user_type", u.user_type);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);
                cmd.Parameters.AddWithValue("@id", u.id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    //Query Successfull
                    isSuccess = true;
                }
                else
                {
                    //query failed
                    isSuccess = false;
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                return isSuccess;
        }
        #endregion
        #region delete data from db
        public bool Delete(BLL_User u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM tbl_users WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", u.id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    //Query Successfull
                    isSuccess = true;
                }
                else
                {
                    //query failed
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
        #region Search user on db usingKeywords
        public DataTable Search(string keywords)
        {
            // Static Method to connect db
            SqlConnection conn = new SqlConnection(myconnstrng);

            // ToolBar hold the data from db

            DataTable dt = new DataTable();
            try
            {
                // SQL Query to Get data from db
                String sql = "SELECT * FROM tbl_users WHERE id LIKE '%"+ keywords + "%' OR first_name LIKE '%" + keywords + "%' OR last_name LIKE '%" + keywords + "%' OR username LIKE '%" + keywords + "%' ";
                //For executing Command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Getting data from db
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //db connection open
                conn.Open();
                //fill data in dataTable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
        #region getting user id from username
        public BLL_User GetIdFromUsername(string username)
        {
            BLL_User u = new BLL_User();
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT id from tbl_users WHERE username='" + username + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql,conn);
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    u.id = int.Parse(dt.Rows[0]["id"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return u;
        }
        #endregion
    }
}
