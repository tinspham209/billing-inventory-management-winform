using AnyStore.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyStore.DAL
{
    class DAL_categories
    {
        //static string method for db connection string 
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region Select Method
        public DataTable Select()
        {
            //creating db connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                // SQL Query to Get data from db
                String sql = "SELECT* FROM tbl_categories";       
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
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
        #region Insert new category
        public bool Insert(BLL_categories c)
        {
            bool isSuccess = false;
            //creating db connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                // SQL Query to Get data from db
                String sql = "INSERT INTO tbl_categories (title, description, added_date, added_by) VALUES (@title, @description, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query is excute successfully then the value to rows will be greater than 0 else it will be less than 0
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
        #region update category
        public bool Update(BLL_categories c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "UPDATE tbl_categories SET title=@title, description=@description,  added_date=@added_date, added_by=@added_by WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
                cmd.Parameters.AddWithValue("@id", c.id);

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
        public bool Delete(BLL_categories c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM tbl_categories WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", c.id);

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
        #region Search category on db usingKeywords
        public DataTable Search(string keywords)
        {
            // Static Method to connect db
            SqlConnection conn = new SqlConnection(myconnstrng);

            // ToolBar hold the data from db

            DataTable dt = new DataTable();
            try
            {
                // SQL Query to Get data from db
                String sql = "SELECT * FROM tbl_categories WHERE id LIKE '%" + keywords + "%' OR title LIKE '%" + keywords + "%' OR description LIKE '%" + keywords + "%' ";
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
    }
}
