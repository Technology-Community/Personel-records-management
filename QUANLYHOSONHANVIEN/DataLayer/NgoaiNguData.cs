﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace QUANLYHOSONHANVIEN.DataLayer
{
   public  class NgoaiNguData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachNGOAINGU()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM NGOAINGU");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataRow NewRow()
        {
            return m_Ds.NewRow();
        }
        public void Add(DataRow row)
        {
            m_Ds.Rows.Add(row);
        }
        public bool Save()
        {
            return m_Ds.ExecuteNoneQuery() > 0;
        }
        public DataTable ThemNGOAINGU(string ma, string tennghe)
        {
            //long ma = ThamSo.TaoMaNgheNghiep;
            //ThamSo.TaoMaNgheNghiep = ma + 1;
            //string maso = "NN" + ma.ToString();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO NGOAINGU(MANN,TENNN) values(N'" + ma + "',N'" + tennghe + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
        public DataTable UpdateNGOAINGU(string tennghe, string mann)
        {
            OleDbCommand cmd = new OleDbCommand("UPDATE NGOAINGU SET tennn=N'" + tennghe + "' WHERe mann = '" + mann + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteNGOAINGU(string maNN)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM NGOAINGU WHERE MANN ='" + maNN + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
