using System;
using System.Data;
using System.Data.SqlClient;

namespace FINALSSS
{
    class AllItems
    {
        public DataTable GetAllItems()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(DBconnection.ConnectionString))
            {
                conn.Open();
                string query = "SELECT ItemID, ItemName, Price, Unit, Status, StockQuantity FROM Items";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }

            return dt;
        }
    }
}
