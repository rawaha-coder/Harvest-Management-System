using Harvest_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Management_System.Database
{
    class HarvestDAO:DAO
    {
        public const string TABLE_HARVEST = "Harvest";
        public const string COLUMN_HARVEST_ID = "HarvestId";
        public const string COLUMN_HARVEST_DATE = "HarvestDate";
        public const string COLUMN_HARVEST_SUPPLIER = "HarvestSuplier";
        public const string COLUMN_HARVEST_FARM = "HarvestFarm";

        private static HarvestDAO instance = null;

        private HarvestDAO() : base() { }

        public static HarvestDAO getInstance()
        {
            if (instance == null)
                instance = new HarvestDAO();
            return instance;
        }

        public void CreateTable()
        {
            string createStmt = "CREATE TABLE " + TABLE_HARVEST
                    + "(" + COLUMN_HARVEST_ID + " INTEGER PRIMARY KEY, "
                    + COLUMN_HARVEST_DATE + " DATE NOT NULL, "
                    + COLUMN_HARVEST_SUPPLIER + " INTEGER NOT NULL, "
                    + COLUMN_HARVEST_FARM + " TINTEGER NOT NULL, "
                    + " FOREIGN KEY (" + COLUMN_HARVEST_SUPPLIER + ") REFERENCES " + SupplierDAO.TABLE_SUPPLIER + " (" + SupplierDAO.COLUMN_SUPPLIER_ID + ")"
                    + " FOREIGN KEY (" + COLUMN_HARVEST_FARM + ") REFERENCES " + FarmDAO.TABLE_FARM + " (" + FarmDAO.COLUMN_FARM_ID + ")"
                    + ")";

            SQLiteCommand sQLiteCommand = new SQLiteCommand(createStmt, mSQLiteConnection);
            OpenConnection();
            sQLiteCommand.ExecuteNonQuery();
            CloseConnection();
        }

        public void addHarvest(Harvest item)
        {
            string insertStmt = "INSERT INTO " + TABLE_HARVEST + " ("
                    + COLUMN_HARVEST_DATE + ", "
                    + COLUMN_HARVEST_SUPPLIER + ", "
                    + COLUMN_HARVEST_FARM + " "
                    + ") VALUES ( "
                    + "@" + COLUMN_HARVEST_DATE + ", "
                    + "@" + COLUMN_HARVEST_SUPPLIER + ", "
                    + "@" + COLUMN_HARVEST_FARM + " )";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(insertStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.AddWithValue(COLUMN_HARVEST_DATE, item.Date);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_HARVEST_SUPPLIER, item.Supplier);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_HARVEST_FARM, item.Farm);
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

        public List<Harvest> HarvestList()
        {
            string selectStmt = "SELECT * FROM " + TABLE_HARVEST + " ORDER BY " + COLUMN_HARVEST_DATE + " ASC;";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                return GetHarvestListFromResult(result);
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

        private static List<Harvest> GetHarvestListFromResult(SQLiteDataReader result)
        {
            List<Harvest> list = new List<Harvest>();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    Harvest item = new Harvest();
                    item.Id = result.GetInt32(result.GetOrdinal(COLUMN_HARVEST_ID));
                    item.Date = result.GetDateTime(result.GetOrdinal(COLUMN_HARVEST_DATE));
                    item.Supplier.SupplierId = result.GetInt32(result.GetOrdinal(COLUMN_HARVEST_SUPPLIER));
                    item.Farm.Id = result.GetInt32(result.GetOrdinal(COLUMN_HARVEST_FARM));
                    list.Add(item);
                }
            }
            return list;
        }

        public void UpdateHarvest(Harvest item)
        {
            string updateStmt = "UPDATE " + TABLE_HARVEST + " SET "
                 + COLUMN_HARVEST_DATE + " =@" + COLUMN_HARVEST_DATE + ", "
                 + COLUMN_HARVEST_SUPPLIER + " =@" + COLUMN_HARVEST_SUPPLIER + ", "
                 + COLUMN_HARVEST_FARM + " =@" + COLUMN_HARVEST_FARM + " "
                 + " WHERE " + COLUMN_HARVEST_ID + " = " + item.Id + " ";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(updateStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_HARVEST_DATE, item.Date));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_HARVEST_SUPPLIER, item.Supplier));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_HARVEST_SUPPLIER, item.Farm));
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

        public void DeleteHarvest(int HarvestId)
        {
            string deleteStmt = "DELETE FROM " + TABLE_HARVEST + " WHERE " + COLUMN_HARVEST_ID + " = " + HarvestId + " ";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(deleteStmt, mSQLiteConnection);
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
    }
}
