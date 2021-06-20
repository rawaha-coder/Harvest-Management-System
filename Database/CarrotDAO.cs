using Harvest_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Management_System.Database
{
    class CarrotDAO : DAO
    {
        public const string TABLE_CARROT = "Carrots";
        public const string COLUMN_CARROT_ID = "Id";
        public const string COLUMN_CARROT_TYPE = "Type";
        public const string COLUMN_CARROT_NAME = "Name";
        public const string COLUMN_CARROT_CODE = "Code";
        public const string COLUMN_CARROT_EMPLOYEE_PRICE = "EmployeePrice";
        public const string COLUMN_CARROT_COMPANY_PRICE = "CompanyPrice";

        private static CarrotDAO instance = null;

        private CarrotDAO() : base() { }

        public static CarrotDAO getInstance()
        {
            if (instance == null)
                instance = new CarrotDAO();
            return instance;
        }

        public void addNewProduct(Carrot item)
        {
            string insertStmt = "INSERT INTO " + TABLE_CARROT + " ("
                    + COLUMN_CARROT_TYPE + ", "
                    + COLUMN_CARROT_NAME + ", "
                    + COLUMN_CARROT_CODE + ", "
                    + COLUMN_CARROT_EMPLOYEE_PRICE + ", "
                    + COLUMN_CARROT_COMPANY_PRICE + " "
                    + ") VALUES ( "
                    + "@" + COLUMN_CARROT_TYPE + ", "
                    + "@" + COLUMN_CARROT_NAME + ", "
                    + "@" + COLUMN_CARROT_CODE + ", "
                    + "@" + COLUMN_CARROT_EMPLOYEE_PRICE + ", "
                    + "@" + COLUMN_CARROT_COMPANY_PRICE + " )";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(insertStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.AddWithValue(COLUMN_CARROT_TYPE, item.Type);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_CARROT_NAME, item.Name);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_CARROT_CODE, item.Code);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_CARROT_EMPLOYEE_PRICE, item.EmployeePrice);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_CARROT_COMPANY_PRICE, item.CompanyPrice);
                sQLiteCommand.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void UpdatePrice(Carrot carrot)
        {
            string updateStmt = "UPDATE " + TABLE_CARROT + " SET "
                 + COLUMN_CARROT_EMPLOYEE_PRICE + " =@" + COLUMN_CARROT_EMPLOYEE_PRICE + ", "
                 + COLUMN_CARROT_COMPANY_PRICE + " =@" + COLUMN_CARROT_COMPANY_PRICE + " "
                 + " WHERE " + COLUMN_CARROT_ID + " = " + carrot.Id + " ";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(updateStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_CARROT_EMPLOYEE_PRICE, carrot.EmployeePrice));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_CARROT_COMPANY_PRICE, carrot.CompanyPrice));
                sQLiteCommand.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public List<Carrot> CarrotList()
        {
            string selectStmt = "SELECT * FROM " + TABLE_CARROT + " ORDER BY " + COLUMN_CARROT_ID + " ASC;";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                return GetCarrotListFromResult(result);
            }
            catch (SQLiteException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        private static List<Carrot> GetCarrotListFromResult(SQLiteDataReader result)
        {
            List<Carrot> list = new List<Carrot>();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    Carrot carrot = new Carrot();
                    carrot.Id = result.GetInt32(result.GetOrdinal(COLUMN_CARROT_ID));
                    carrot.Type = result.GetInt32(result.GetOrdinal(COLUMN_CARROT_TYPE));
                    carrot.Code = result.GetString(result.GetOrdinal(COLUMN_CARROT_NAME));
                    carrot.EmployeePrice = result.GetDouble(result.GetOrdinal(COLUMN_CARROT_EMPLOYEE_PRICE));
                    carrot.CompanyPrice = result.GetDouble(result.GetOrdinal(COLUMN_CARROT_COMPANY_PRICE));
                    list.Add(carrot);
                }
            }
            return list;
        }

        public void CreateTable()
        {
            string createStmt = "CREATE TABLE IF NOT EXISTS " + TABLE_CARROT + "("
                    + COLUMN_CARROT_ID + " INTEGER PRIMARY KEY, "
                    + COLUMN_CARROT_TYPE + " INTEGER NOT NULL, "
                    + COLUMN_CARROT_NAME + " TEXT NOT NULL, "
                    + COLUMN_CARROT_CODE + " TEXT NOT NULL, "
                    + COLUMN_CARROT_EMPLOYEE_PRICE + " REAL NOT NULL, "
                    + COLUMN_CARROT_COMPANY_PRICE + " REAL NOT NULL "
                    + ")";

            SQLiteCommand sQLiteCommand = new SQLiteCommand(createStmt, mSQLiteConnection);
            OpenConnection();
            sQLiteCommand.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
