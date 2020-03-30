using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SQLiteAgenda.Datos
{
   // class ISQLiteDB
    //{
    //}

    public interface ISQLiteDB
    {
        SQLiteAsyncConnection GetConnection();
    }//interface
}//namespace
