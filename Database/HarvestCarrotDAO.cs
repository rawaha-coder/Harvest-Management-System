using Harvest_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest_Management_System.Database
{
    class HarvestCarrotDAO:DAO
    {
        public const string TABLE_HARVEST_CARROT = "HarvestCarrot";
        public const string COLUMN_HARVEST_CARROT_ID = "HarvestCarrotId";
        public const string COLUMN_HARVEST_ID = "HarvestId";
        public const string COLUMN_EMPLOYEE_ID = "EmployeeId";
        public const string COLUMN_HARVEST_CARROT_C0TQ = "C0TQ"; //Carrot type n total quantity
        public const string COLUMN_HARVEST_CARROT_C0DQ = "C0DQ"; //Carrot type n damage quantity
        public const string COLUMN_HARVEST_CARROT_C0EP = "C0EP"; //Carrot type n price employee
        public const string COLUMN_HARVEST_CARROT_C0CP = "C0CP"; //Carrot type n price company
        public const string COLUMN_HARVEST_CARROT_C1TQ = "C1TQ";
        public const string COLUMN_HARVEST_CARROT_C1DQ = "C1DQ";
        public const string COLUMN_HARVEST_CARROT_C1EP = "C1EP";
        public const string COLUMN_HARVEST_CARROT_C1CP = "C1CP";
        public const string COLUMN_HARVEST_CARROT_C2TQ = "C2TQ";
        public const string COLUMN_HARVEST_CARROT_C2DQ = "C2DQ";
        public const string COLUMN_HARVEST_CARROT_C2EP = "C2EP"; 
        public const string COLUMN_HARVEST_CARROT_C2CP = "C2CP";
        public const string COLUMN_HARVEST_CARROT_C3TQ = "C3TQ";
        public const string COLUMN_HARVEST_CARROT_C3DQ = "C3DQ";
        public const string COLUMN_HARVEST_CARROT_C3EP = "C3EP"; 
        public const string COLUMN_HARVEST_CARROT_C3CP = "C3CP"; 
        public const string COLUMN_HARVEST_CARROT_C4TQ = "C4TQ";
        public const string COLUMN_HARVEST_CARROT_C4DQ = "C4DQ";
        public const string COLUMN_HARVEST_CARROT_C4EP = "C4EP"; 
        public const string COLUMN_HARVEST_CARROT_C4CP = "C4CP"; 

        private static HarvestCarrotDAO instance = null;

        private HarvestCarrotDAO() : base() { }

        public static HarvestCarrotDAO getInstance()
        {
            if (instance == null)
                instance = new HarvestCarrotDAO();
            return instance;
        }

        public void CreateTable()
        {
            string createStmt = "CREATE TABLE " + TABLE_HARVEST_CARROT
                    + "(" + COLUMN_HARVEST_CARROT_ID + " INTEGER PRIMARY KEY, "
                    + COLUMN_HARVEST_ID + " INTEGER NOT NULL, "
                    + COLUMN_EMPLOYEE_ID + " INTEGER NOT NULL, "
                    + COLUMN_HARVEST_CARROT_C0TQ + " REAL DEFAULT 0, "
                    + COLUMN_HARVEST_CARROT_C0DQ + " REAL DEFAULT 0, "
                    + COLUMN_HARVEST_CARROT_C0EP + " REAL DEFAULT 0, "
                    + COLUMN_HARVEST_CARROT_C0CP + " REAL DEFAULT 0, "
                    + COLUMN_HARVEST_CARROT_C1TQ + " REAL DEFAULT 0, "
                    + COLUMN_HARVEST_CARROT_C1DQ + " REAL DEFAULT 0, "
                    + COLUMN_HARVEST_CARROT_C1EP + " REAL DEFAULT 0, "
                    + COLUMN_HARVEST_CARROT_C1CP + " REAL DEFAULT 0, "
                    + COLUMN_HARVEST_CARROT_C2TQ + " REAL DEFAULT 0, "
                    + COLUMN_HARVEST_CARROT_C2DQ + " REAL DEFAULT 0, "
                    + COLUMN_HARVEST_CARROT_C2EP + " REAL DEFAULT 0, "
                    + COLUMN_HARVEST_CARROT_C2CP + " REAL DEFAULT 0, "
                    + COLUMN_HARVEST_CARROT_C3TQ + " REAL DEFAULT 0, "
                    + COLUMN_HARVEST_CARROT_C3DQ + " REAL DEFAULT 0, "
                    + COLUMN_HARVEST_CARROT_C3EP + " REAL DEFAULT 0, "
                    + COLUMN_HARVEST_CARROT_C3CP + " REAL DEFAULT 0, "
                    + COLUMN_HARVEST_CARROT_C4TQ + " REAL DEFAULT 0, "
                    + COLUMN_HARVEST_CARROT_C4DQ + " REAL DEFAULT 0, "
                    + COLUMN_HARVEST_CARROT_C4EP + " REAL DEFAULT 0, "
                    + COLUMN_HARVEST_CARROT_C4CP + " REAL DEFAULT 0, "
                    + " FOREIGN KEY (" + COLUMN_HARVEST_ID + ") REFERENCES " + HarvestDAO.TABLE_HARVEST + " (" + HarvestDAO.COLUMN_HARVEST_ID + ")"
                    + " FOREIGN KEY (" + COLUMN_EMPLOYEE_ID + ") REFERENCES " + EmployeeDAO.TABLE_EMPLOYEE + " (" + EmployeeDAO.COLUMN_EMPLOYEE_ID + ")"
                    + ")";

            SQLiteCommand sQLiteCommand = new SQLiteCommand(createStmt, mSQLiteConnection);
            OpenConnection();
            sQLiteCommand.ExecuteNonQuery();
            CloseConnection();
        }

        public void addCarrotProduction(CarrotProduction item)
        {
            string insertStmt = "INSERT INTO " + TABLE_HARVEST_CARROT + " ("
                    + COLUMN_HARVEST_ID + ", "
                    + COLUMN_EMPLOYEE_ID + ", "
                    + COLUMN_HARVEST_CARROT_C0TQ + ", "
                    + COLUMN_HARVEST_CARROT_C0DQ + ", "
                    + COLUMN_HARVEST_CARROT_C0EP + ", "
                    + COLUMN_HARVEST_CARROT_C0CP + ", "
                    + COLUMN_HARVEST_CARROT_C1TQ + ", "
                    + COLUMN_HARVEST_CARROT_C1DQ + ", "
                    + COLUMN_HARVEST_CARROT_C1EP + ", "
                    + COLUMN_HARVEST_CARROT_C1CP + ", "
                    + COLUMN_HARVEST_CARROT_C2TQ + ", "
                    + COLUMN_HARVEST_CARROT_C2DQ + ", "
                    + COLUMN_HARVEST_CARROT_C2EP + ", "
                    + COLUMN_HARVEST_CARROT_C2CP + ", "
                    + COLUMN_HARVEST_CARROT_C3TQ + ", "
                    + COLUMN_HARVEST_CARROT_C3DQ + ", "
                    + COLUMN_HARVEST_CARROT_C3EP + ", "
                    + COLUMN_HARVEST_CARROT_C3CP + ", "
                    + COLUMN_HARVEST_CARROT_C4TQ + ", "
                    + COLUMN_HARVEST_CARROT_C4DQ + ", "
                    + COLUMN_HARVEST_CARROT_C4EP + ", "
                    + COLUMN_HARVEST_CARROT_C4CP + " "
                    + ") VALUES ( "
                    + "@" + COLUMN_HARVEST_ID + ", "
                    + "@" + COLUMN_EMPLOYEE_ID + ", "
                    + "@" + COLUMN_HARVEST_CARROT_C0TQ + ", "
                    + "@" + COLUMN_HARVEST_CARROT_C0DQ + ", "
                    + "@" + COLUMN_HARVEST_CARROT_C0EP + ", "
                    + "@" + COLUMN_HARVEST_CARROT_C0CP + ", "
                    + "@" + COLUMN_HARVEST_CARROT_C1TQ + ", "
                    + "@" + COLUMN_HARVEST_CARROT_C1DQ + ", "
                    + "@" + COLUMN_HARVEST_CARROT_C1EP + ", "
                    + "@" + COLUMN_HARVEST_CARROT_C1CP + ", "
                    + "@" + COLUMN_HARVEST_CARROT_C2TQ + ", "
                    + "@" + COLUMN_HARVEST_CARROT_C2DQ + ", "
                    + "@" + COLUMN_HARVEST_CARROT_C2EP + ", "
                    + "@" + COLUMN_HARVEST_CARROT_C2CP + ", "
                    + "@" + COLUMN_HARVEST_CARROT_C3TQ + ", "
                    + "@" + COLUMN_HARVEST_CARROT_C3DQ + ", "
                    + "@" + COLUMN_HARVEST_CARROT_C3EP + ", "
                    + "@" + COLUMN_HARVEST_CARROT_C3CP + ", "
                    + "@" + COLUMN_HARVEST_CARROT_C4TQ + ", "
                    + "@" + COLUMN_HARVEST_CARROT_C4DQ + ", "
                    + "@" + COLUMN_HARVEST_CARROT_C4EP + ", "
                    + "@" + COLUMN_HARVEST_CARROT_C4CP
                    + " )";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(insertStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.AddWithValue(COLUMN_HARVEST_ID, item.Harvest.Id);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_EMPLOYEE_ID, item.EmployeeId);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_HARVEST_CARROT_C0TQ, item.C0TQ);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_HARVEST_CARROT_C0DQ, item.C0DQ);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_HARVEST_CARROT_C0EP, item.HarvestCarrots[0].Carrot.EmployeePrice);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_HARVEST_CARROT_C0CP, item.HarvestCarrots[0].Carrot.CompanyPrice);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_HARVEST_CARROT_C1TQ, item.C1TQ);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_HARVEST_CARROT_C1DQ, item.C1DQ);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_HARVEST_CARROT_C1EP, item.HarvestCarrots[1].Carrot.EmployeePrice);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_HARVEST_CARROT_C1CP, item.HarvestCarrots[1].Carrot.CompanyPrice);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_HARVEST_CARROT_C2TQ, item.C2TQ);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_HARVEST_CARROT_C2DQ, item.C2DQ);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_HARVEST_CARROT_C2EP, item.HarvestCarrots[2].Carrot.EmployeePrice);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_HARVEST_CARROT_C2CP, item.HarvestCarrots[2].Carrot.CompanyPrice);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_HARVEST_CARROT_C3TQ, item.C3TQ);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_HARVEST_CARROT_C3DQ, item.C3DQ);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_HARVEST_CARROT_C3EP, item.HarvestCarrots[3].Carrot.EmployeePrice);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_HARVEST_CARROT_C3CP, item.HarvestCarrots[3].Carrot.CompanyPrice);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_HARVEST_CARROT_C4TQ, item.C4TQ);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_HARVEST_CARROT_C4DQ, item.C4DQ);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_HARVEST_CARROT_C4EP, item.HarvestCarrots[4].Carrot.EmployeePrice);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_HARVEST_CARROT_C4CP, item.HarvestCarrots[4].Carrot.CompanyPrice);
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

        public List<CarrotProduction> CarrotProductionList()
        {
            string selectStmt = "SELECT * FROM " + TABLE_HARVEST_CARROT + " ORDER BY " + COLUMN_HARVEST_CARROT_ID + " ASC;";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                return GetCarrotProductionListFromResult(result);
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

        private static List<CarrotProduction> GetCarrotProductionListFromResult(SQLiteDataReader result)
        {
            List<CarrotProduction> list = new List<CarrotProduction>();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    CarrotProduction item = new CarrotProduction();
                    item.Id = result.GetInt32(result.GetOrdinal(COLUMN_HARVEST_CARROT_ID));
                    item.Harvest.Id = result.GetInt32(result.GetOrdinal(COLUMN_HARVEST_ID));
                    item.EmployeeId = result.GetInt32(result.GetOrdinal(COLUMN_EMPLOYEE_ID));
                    item.C0TQ = result.GetDouble(result.GetOrdinal(COLUMN_HARVEST_CARROT_C0TQ));
                    item.C0DQ = result.GetDouble(result.GetOrdinal(COLUMN_HARVEST_CARROT_C0DQ));
                    item.HarvestCarrots[0].Carrot.EmployeePrice = result.GetDouble(result.GetOrdinal(COLUMN_HARVEST_CARROT_C0EP));
                    item.HarvestCarrots[0].Carrot.CompanyPrice= result.GetDouble(result.GetOrdinal(COLUMN_HARVEST_CARROT_C0CP));
                    item.C1TQ = result.GetDouble(result.GetOrdinal(COLUMN_HARVEST_CARROT_C1TQ));
                    item.C1DQ = result.GetDouble(result.GetOrdinal(COLUMN_HARVEST_CARROT_C1DQ));
                    item.HarvestCarrots[1].Carrot.EmployeePrice = result.GetDouble(result.GetOrdinal(COLUMN_HARVEST_CARROT_C1EP));
                    item.HarvestCarrots[1].Carrot.CompanyPrice = result.GetDouble(result.GetOrdinal(COLUMN_HARVEST_CARROT_C1CP));
                    item.C2TQ = result.GetDouble(result.GetOrdinal(COLUMN_HARVEST_CARROT_C2TQ));
                    item.C2DQ = result.GetDouble(result.GetOrdinal(COLUMN_HARVEST_CARROT_C2DQ));
                    item.HarvestCarrots[2].Carrot.EmployeePrice = result.GetDouble(result.GetOrdinal(COLUMN_HARVEST_CARROT_C2EP));
                    item.HarvestCarrots[2].Carrot.CompanyPrice = result.GetDouble(result.GetOrdinal(COLUMN_HARVEST_CARROT_C2CP));
                    item.C3TQ = result.GetDouble(result.GetOrdinal(COLUMN_HARVEST_CARROT_C3TQ));
                    item.C3DQ = result.GetDouble(result.GetOrdinal(COLUMN_HARVEST_CARROT_C3DQ));
                    item.HarvestCarrots[3].Carrot.EmployeePrice = result.GetDouble(result.GetOrdinal(COLUMN_HARVEST_CARROT_C3EP));
                    item.HarvestCarrots[3].Carrot.CompanyPrice = result.GetDouble(result.GetOrdinal(COLUMN_HARVEST_CARROT_C3CP));
                    item.C4TQ = result.GetDouble(result.GetOrdinal(COLUMN_HARVEST_CARROT_C4TQ));
                    item.C4DQ = result.GetDouble(result.GetOrdinal(COLUMN_HARVEST_CARROT_C4DQ));
                    item.HarvestCarrots[4].Carrot.EmployeePrice = result.GetDouble(result.GetOrdinal(COLUMN_HARVEST_CARROT_C4EP));
                    item.HarvestCarrots[4].Carrot.CompanyPrice = result.GetDouble(result.GetOrdinal(COLUMN_HARVEST_CARROT_C4CP));
                    list.Add(item);
                }
            }
            return list;
        }

        public void UpdateCarrotProduction(CarrotProduction item)
        {
            string updateStmt = "UPDATE " + TABLE_HARVEST_CARROT + " SET "
                 + COLUMN_HARVEST_ID + " =@" + COLUMN_HARVEST_ID + ", "
                 + COLUMN_EMPLOYEE_ID + " =@" + COLUMN_EMPLOYEE_ID + ", "
                 + COLUMN_HARVEST_CARROT_C0TQ + " =@" + COLUMN_HARVEST_CARROT_C0TQ + ", "
                 + COLUMN_HARVEST_CARROT_C0DQ + " =@" + COLUMN_HARVEST_CARROT_C0DQ + ", "
                 + COLUMN_HARVEST_CARROT_C0EP + " =@" + COLUMN_HARVEST_CARROT_C0EP + ", "
                 + COLUMN_HARVEST_CARROT_C0CP + " =@" + COLUMN_HARVEST_CARROT_C0CP + ", "

                 + COLUMN_HARVEST_CARROT_C1TQ + " =@" + COLUMN_HARVEST_CARROT_C1TQ + ", "
                 + COLUMN_HARVEST_CARROT_C1DQ + " =@" + COLUMN_HARVEST_CARROT_C1DQ + ", "
                 + COLUMN_HARVEST_CARROT_C1EP + " =@" + COLUMN_HARVEST_CARROT_C1EP + ", "
                 + COLUMN_HARVEST_CARROT_C1CP + " =@" + COLUMN_HARVEST_CARROT_C1CP + ", "

                 + COLUMN_HARVEST_CARROT_C2TQ + " =@" + COLUMN_HARVEST_CARROT_C2TQ + ", "
                 + COLUMN_HARVEST_CARROT_C2DQ + " =@" + COLUMN_HARVEST_CARROT_C2DQ + ", "
                 + COLUMN_HARVEST_CARROT_C2EP + " =@" + COLUMN_HARVEST_CARROT_C2EP + ", "
                 + COLUMN_HARVEST_CARROT_C2CP + " =@" + COLUMN_HARVEST_CARROT_C2CP + ", "

                 + COLUMN_HARVEST_CARROT_C3TQ + " =@" + COLUMN_HARVEST_CARROT_C3TQ + ", "
                 + COLUMN_HARVEST_CARROT_C3DQ + " =@" + COLUMN_HARVEST_CARROT_C3DQ + ", "
                 + COLUMN_HARVEST_CARROT_C3EP + " =@" + COLUMN_HARVEST_CARROT_C3EP + ", "
                 + COLUMN_HARVEST_CARROT_C3CP + " =@" + COLUMN_HARVEST_CARROT_C3CP + ", "

                 + COLUMN_HARVEST_CARROT_C4TQ + " =@" + COLUMN_HARVEST_CARROT_C4TQ + ", "
                 + COLUMN_HARVEST_CARROT_C4DQ + " =@" + COLUMN_HARVEST_CARROT_C4DQ + ", "
                 + COLUMN_HARVEST_CARROT_C4EP + " =@" + COLUMN_HARVEST_CARROT_C4EP + ", "
                 + COLUMN_HARVEST_CARROT_C4CP + " =@" + COLUMN_HARVEST_CARROT_C4CP + " "

                 + " WHERE " + COLUMN_HARVEST_CARROT_ID + " = " + item.Id + " ";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(updateStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_HARVEST_ID, item.Harvest.Id));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_EMPLOYEE_ID, item.EmployeeId));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_HARVEST_CARROT_C0TQ, item.C0TQ));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_HARVEST_CARROT_C0DQ, item.C0DQ));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_HARVEST_CARROT_C0EP, item.HarvestCarrots[0].Carrot.EmployeePrice));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_HARVEST_CARROT_C0CP, item.HarvestCarrots[0].Carrot.CompanyPrice));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_HARVEST_CARROT_C1TQ, item.C1TQ));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_HARVEST_CARROT_C1DQ, item.C1DQ));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_HARVEST_CARROT_C1EP, item.HarvestCarrots[1].Carrot.EmployeePrice));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_HARVEST_CARROT_C1CP, item.HarvestCarrots[1].Carrot.CompanyPrice));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_HARVEST_CARROT_C2TQ, item.C2TQ));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_HARVEST_CARROT_C2DQ, item.C2DQ));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_HARVEST_CARROT_C2EP, item.HarvestCarrots[2].Carrot.EmployeePrice));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_HARVEST_CARROT_C2CP, item.HarvestCarrots[2].Carrot.CompanyPrice));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_HARVEST_CARROT_C3TQ, item.C3TQ));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_HARVEST_CARROT_C3DQ, item.C3DQ));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_HARVEST_CARROT_C3EP, item.HarvestCarrots[3].Carrot.EmployeePrice));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_HARVEST_CARROT_C3CP, item.HarvestCarrots[3].Carrot.CompanyPrice));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_HARVEST_CARROT_C4TQ, item.C4TQ));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_HARVEST_CARROT_C4DQ, item.C4DQ));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_HARVEST_CARROT_C4EP, item.HarvestCarrots[4].Carrot.EmployeePrice));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_HARVEST_CARROT_C4CP, item.HarvestCarrots[4].Carrot.CompanyPrice));
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

        public void DeleteCarrotProduction(int id)
        {
            string deleteStmt = "DELETE FROM " + TABLE_HARVEST_CARROT + " WHERE " + COLUMN_HARVEST_CARROT_ID + " = " + id + " ";
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
