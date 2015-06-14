using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication2
{
    public class BazaDanych
    {
        OleDbConnection uchwyt;
        OleDbDataAdapter daBaza;
        OleDbCommand com;
        DataSet dsAccess = new DataSet("Access");
        public OpenFileDialog okienko = new OpenFileDialog();

        public BazaDanych()
        {
            okienko.Filter = "Baza Danych (mdb)|*.mdb";
            okienko.ShowDialog();
            string conStr;
            conStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + okienko.FileName;
            uchwyt = new OleDbConnection(conStr);
            uchwyt.Open();
        }

        public void Zapisz(string temp, string prad )
        {
            com = new OleDbCommand("INSERT INTO Tabela1(Temperatura,Prond) VALUES (@Temperatura,@Prond)", uchwyt);
            com.Parameters.Add(new OleDbParameter("@Temperatura", temp));
            com.Parameters.Add(new OleDbParameter("@Prond", prad));
            com.ExecuteNonQuery();
        }

        public void Wczytaj()
        {
            daBaza = new OleDbDataAdapter("SELECT * FROM Tabela1", uchwyt);
            daBaza.Fill(dsAccess);
        }
        ~BazaDanych()
        {
            throw new System.NotImplementedException();
        }
    }
}
