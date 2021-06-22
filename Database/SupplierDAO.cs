using Harvest_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Management_System.Database
{
    class SupplierDAO : DAO
    {
        public const string TABLE_SUPPLIER = "Supplier";
        public const string COLUMN_SUPPLIER_ID = "SupplierId";
        public const string COLUMN_SUPPLIER_STATUS = "SupplierStatus";
        public const string COLUMN_SUPPLIER_NAME = "SupplierName";
        public const string COLUMN_SUPPLIER_FIRSTNAME = "SupplierFirstName";
        public const string COLUMN_SUPPLIER_LASTNAME = "SupplierLastName";

        private static SupplierDAO instance = null;

        private SupplierDAO() : base() { }

        public static SupplierDAO getInstance()
        {
            if (instance == null)
                instance = new SupplierDAO();
            return instance;
        }

        internal Dictionary<string, Supplier> SupplierDictionary()
        {
            Dictionary<string, Supplier> dictionary = new Dictionary<string, Supplier>();

            string selectStmt = "SELECT * FROM " + TABLE_SUPPLIER + " ORDER BY " + COLUMN_SUPPLIER_NAME + " ASC;";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        Supplier supplier = new Supplier()
                        {
                            SupplierId = result.GetInt32(result.GetOrdinal(COLUMN_SUPPLIER_ID)),
                            SupplierStatus = result.GetBoolean(result.GetOrdinal(COLUMN_SUPPLIER_STATUS)),
                            SupplierName = result.GetString(result.GetOrdinal(COLUMN_SUPPLIER_NAME)),
                            SupplierFirstName = result.GetString(result.GetOrdinal(COLUMN_SUPPLIER_FIRSTNAME)),
                            SupplierLastName = result.GetString(result.GetOrdinal(COLUMN_SUPPLIER_LASTNAME))
                        };
                        dictionary.Add(supplier.SupplierName, supplier);
                    }
                }
                return dictionary;
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

        public void AddSupplier(Supplier supplier)
        {
            string insertStmt = getInsertCommand();
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(insertStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.AddWithValue(COLUMN_SUPPLIER_STATUS, supplier.SupplierStatus);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_SUPPLIER_NAME, supplier.SupplierName.Trim().ToString());
                sQLiteCommand.Parameters.AddWithValue(COLUMN_SUPPLIER_FIRSTNAME, supplier.SupplierFirstName.Trim().ToString());
                sQLiteCommand.Parameters.AddWithValue(COLUMN_SUPPLIER_LASTNAME, supplier.SupplierLastName.Trim().ToString());
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

        private static string getInsertCommand()
        {
            return "INSERT INTO " + TABLE_SUPPLIER + " ("
                    + COLUMN_SUPPLIER_STATUS + ", "
                    + COLUMN_SUPPLIER_NAME + ", "
                    + COLUMN_SUPPLIER_FIRSTNAME + ", "
                    + COLUMN_SUPPLIER_LASTNAME + " "
                    + ") VALUES ( "
                    + "@" + COLUMN_SUPPLIER_STATUS + ", "
                    + "@" + COLUMN_SUPPLIER_NAME + ", "
                    + "@" + COLUMN_SUPPLIER_FIRSTNAME + ", "
                    + "@" + COLUMN_SUPPLIER_LASTNAME + " )";
        }

        public List<Supplier> ListSupplier()
        {
            var selectStmt = "SELECT * FROM " + TABLE_SUPPLIER + " ORDER BY " + COLUMN_SUPPLIER_ID + " ASC;";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                return getSupplierListFromResult(result);
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

        private static List<Supplier> getSupplierListFromResult(SQLiteDataReader result)
        {
            List<Supplier> list = new List<Supplier>();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    Supplier supplier = new Supplier()
                    {
                        SupplierId = result.GetInt32(result.GetOrdinal(COLUMN_SUPPLIER_ID)),
                        SupplierStatus = result.GetBoolean(result.GetOrdinal(COLUMN_SUPPLIER_STATUS)),
                        SupplierName = result.GetString(result.GetOrdinal(COLUMN_SUPPLIER_NAME)),
                        SupplierFirstName = result.GetString(result.GetOrdinal(COLUMN_SUPPLIER_FIRSTNAME)),
                        SupplierLastName = result.GetString(result.GetOrdinal(COLUMN_SUPPLIER_LASTNAME))
                    };
                    list.Add(supplier);
                }
            }
            return list;
        }

        internal void UpdateSupplier(Supplier supplier)
        {
            string updateStmt = getUpdateCommand(supplier);

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(updateStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_SUPPLIER_STATUS, supplier.SupplierStatus));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_SUPPLIER_NAME, supplier.SupplierName.Trim().ToUpper()));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_SUPPLIER_FIRSTNAME, supplier.SupplierFirstName.Trim().ToUpper()));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_SUPPLIER_LASTNAME, supplier.SupplierLastName.Trim().ToUpper()));
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

        private static string getUpdateCommand(Supplier supplier)
        {
            return "UPDATE " + TABLE_SUPPLIER + " SET "
                 + COLUMN_SUPPLIER_STATUS + " =@" + COLUMN_SUPPLIER_STATUS + ", "
                 + COLUMN_SUPPLIER_NAME + " =@" + COLUMN_SUPPLIER_NAME + ", "
                 + COLUMN_SUPPLIER_FIRSTNAME + " =@" + COLUMN_SUPPLIER_FIRSTNAME + ", "
                 + COLUMN_SUPPLIER_LASTNAME + " =@" + COLUMN_SUPPLIER_LASTNAME + " "
                + " WHERE " + COLUMN_SUPPLIER_ID + " = " + supplier.SupplierId + " ";
        }

        public void DeleteSupplier(Supplier supplier)
        {
            string deleteSupplierStmt = "DELETE FROM " + TABLE_SUPPLIER + " WHERE " + COLUMN_SUPPLIER_ID + " = " + supplier.SupplierId + " ";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(deleteSupplierStmt, mSQLiteConnection);
                OpenConnection();
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
        public void CreateTable()
        {
            string createStmt = "CREATE TABLE IF NOT EXISTS " + TABLE_SUPPLIER + "("
                    + COLUMN_SUPPLIER_ID + " INTEGER PRIMARY KEY, "
                    + COLUMN_SUPPLIER_STATUS + " BOOLEAN NOT NULL, "
                    + COLUMN_SUPPLIER_NAME + " TEXT NOT NULL, "
                    + COLUMN_SUPPLIER_FIRSTNAME + " TEXT NOT NULL, "
                    + COLUMN_SUPPLIER_LASTNAME + " TEXT NOT NULL "
                    + ")";

            SQLiteCommand sQLiteCommand = new SQLiteCommand(createStmt, mSQLiteConnection);
            OpenConnection();
            sQLiteCommand.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
