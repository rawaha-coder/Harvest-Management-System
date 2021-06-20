using Harvest_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Management_System.Database
{
    class FarmDAO : DAO
    {
        public const string TABLE_FARM = "Farm";
        public const string COLUMN_FARM_ID = "Id";
        public const string COLUMN_FARM_NAME = "Name";
        public const string COLUMN_FARM_ADDRESS = "Address";
        public const string COLUMN_FARM_AREA = "Area";
        public const string COLUMN_FARM_PLANTING_DATE = "PlantingDate";
        public const string COLUMN_FARM_HARVEST_DATE = "HarvestDate";


        private static FarmDAO instance = new FarmDAO();

        private FarmDAO() : base() { }

        public static FarmDAO getInstance()
        {
            if (instance == null)
                instance = new FarmDAO();
            return instance;
        }

        public void CreateTable()
        {
            string createStmt = "CREATE TABLE IF NOT EXISTS " + TABLE_FARM + "("
                    + COLUMN_FARM_ID + " INTEGER PRIMARY KEY, "
                    + COLUMN_FARM_NAME + " TEXT NOT NULL, "
                    + COLUMN_FARM_ADDRESS + " TEXT, "
                    + COLUMN_FARM_AREA + " REAL, "
                    + COLUMN_FARM_PLANTING_DATE + " DATE, "
                    + COLUMN_FARM_HARVEST_DATE + " DATE "
                    + ")";

            SQLiteCommand sQLiteCommand = new SQLiteCommand(createStmt, mSQLiteConnection);
            OpenConnection();
            sQLiteCommand.ExecuteNonQuery();
            CloseConnection();
        }

        public void AddFarm(Farm farm)
        {
            string insertStmt = "INSERT INTO " + TABLE_FARM + " ("
                    + COLUMN_FARM_NAME + ", "
                    + COLUMN_FARM_ADDRESS + ", "
                    + COLUMN_FARM_AREA + ", "
                    + COLUMN_FARM_PLANTING_DATE + ", "
                    + COLUMN_FARM_HARVEST_DATE + " "
                    + ") VALUES ( "
                    + "@" + COLUMN_FARM_NAME + ", "
                    + "@" + COLUMN_FARM_ADDRESS + ", "
                    + "@" + COLUMN_FARM_AREA + ", "
                    + "@" + COLUMN_FARM_PLANTING_DATE + ", "
                    + "@" + COLUMN_FARM_HARVEST_DATE + " )";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(insertStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.AddWithValue(COLUMN_FARM_NAME, farm.Name.ToUpper());
                sQLiteCommand.Parameters.AddWithValue(COLUMN_FARM_ADDRESS, farm.Address.ToUpper());
                sQLiteCommand.Parameters.AddWithValue(COLUMN_FARM_AREA, farm.Area);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_FARM_PLANTING_DATE, farm.PlantingDate);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_FARM_HARVEST_DATE, farm.HarvestDate);
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

        public List<Farm> FarmList()
        {
            
            var selectStmt = "SELECT * FROM " + TABLE_FARM + " ORDER BY " + COLUMN_FARM_ID + " ASC;";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                return getFarmListFromResult(result);
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

        private static List<Farm> getFarmListFromResult(SQLiteDataReader result)
        {
            List<Farm> list = new List<Farm>();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    Farm farm = new Farm();
                    farm.Id = result.GetInt32(result.GetOrdinal(COLUMN_FARM_ID));
                    farm.Name = result.GetString(result.GetOrdinal(COLUMN_FARM_NAME));
                    farm.Address = result.GetString(result.GetOrdinal(COLUMN_FARM_ADDRESS));
                    farm.Area = result.GetDouble(result.GetOrdinal(COLUMN_FARM_AREA));
                    farm.PlantingDate = result.GetDateTime(result.GetOrdinal(COLUMN_FARM_PLANTING_DATE));
                    farm.HarvestDate = result.GetDateTime(result.GetOrdinal(COLUMN_FARM_HARVEST_DATE));
                    list.Add(farm);
                }
            }
            return list;
        }

        public void UpdateFarm(Farm farm)
        {
            string updateStmt = "UPDATE " + TABLE_FARM + " SET "
                 + COLUMN_FARM_NAME + " =@" + COLUMN_FARM_NAME + ", "
                 + COLUMN_FARM_ADDRESS + " =@" + COLUMN_FARM_ADDRESS + ", "
                 + COLUMN_FARM_AREA + " =@" + COLUMN_FARM_AREA + ", "
                 + COLUMN_FARM_PLANTING_DATE + " =@" + COLUMN_FARM_PLANTING_DATE + ", "
                 + COLUMN_FARM_HARVEST_DATE + " =@" + COLUMN_FARM_HARVEST_DATE + " "
                + " WHERE " + COLUMN_FARM_ID + " = " + farm.Id + " ";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(updateStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_FARM_NAME, farm.Name.ToUpper()));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_FARM_ADDRESS, farm.Address.ToUpper()));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_FARM_AREA, farm.Area));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_FARM_PLANTING_DATE, farm.PlantingDate));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_FARM_HARVEST_DATE, farm.HarvestDate));
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

        public void DeleteFarm(Farm farm)
        {
            string updateStmt = "DELETE FROM " + TABLE_FARM + " WHERE " + COLUMN_FARM_ID + " = " + farm.Id + " ";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(updateStmt, mSQLiteConnection);
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
