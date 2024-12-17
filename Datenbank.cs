using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace DatenBankZoo
{
    public class Datenbank
    {
        private MySqlConnection con;
        private string connectionString;

        public Datenbank()
        {
            connectionString = string.Format("SERVER=localhost;DATABASE=zoo;UID=root;PASSWORD='';");
            con = new MySqlConnection(connectionString);
            
        }

        public void newThemenbereich(Themenbereiche theme)
        {
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            if(theme.TNr1 == -1)
            {
                com.CommandText = string.Format("INSERT INTO Themenbereich VALUES(NULL,'{0}');", theme.TName1);
            }
            else
            {
                com.CommandText = string.Format("UPDATE Themenbereich SET Name = '{0}' " + "WHERE ThemenbereichID = {1};", theme.TName1, theme.TNr1);
            }
            com.ExecuteNonQuery();
            schliessen();
        }

        public void newTierart(Tierart tier)
        {
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            if(tier.TierartId == -1)
            {
                com.CommandText = string.Format("INSERT INTO Tierart VALUES(NULL,'{0}');", tier.Name);
            }
            else
            {
                com.CommandText = string.Format("UPDATE Tierart SET Name = '{0}' " + "WHERE TierartID = {1};", tier.Name, tier.TierartId);
            }
            com.ExecuteNonQuery();
            schliessen();
        }

        public void newGehege(Gehege gehege)
        {
            oeffnen();
            MySqlCommand com = con.CreateCommand();

            if(gehege.GehegeID == -1)
            {
                com.CommandText = string.Format("INSERT INTO Gehege VALUES(NULL, '{0}', {1});", gehege.Name, gehege.ThemenbereichID);
            }
            else
            {
                com.CommandText = string.Format("UPDATE Gehege SET Name = '{0}' " + "WHERE GehegeID = {1};", gehege.Name, gehege.GehegeID);
            }
            com.ExecuteNonQuery();
            schliessen();
        }

        public void newTier(Tier tier)
        {
            oeffnen();
            MySqlCommand com = con.CreateCommand();

            if(tier.TierID == -1)
            {
                com.CommandText = string.Format("INSERT INTO Tier VALUES(NULL, '{0}', {1}, {2});", tier.Name, tier.GehegeID, tier.TierartID);
            }
            else
            {
                com.CommandText = string.Format("UPDATE Tier SET Name = '{0}', GehegeID = {1}, TierartID = {2} " + "WHERE TierID = {3};", tier.Name, tier.GehegeID, tier.TierartID, tier.TierID);
            }
            com.ExecuteNonQuery();
            schliessen();
        }

        public void delThemenbereich(int id)
        {
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = string.Format("DELETE FROM Themenbereich WHERE ThemenbereichID = {0};", id);
            com.ExecuteNonQuery();
            schliessen();
        }

        public void delTierart(int id)
        {
            oeffnen();
            MySqlCommand com = con.CreateCommand();

            // First, delete dependent rows in the 'tier' table
            //com.CommandText = string.Format("DELETE FROM tier WHERE TierartID = {0};", id);
            //com.ExecuteNonQuery();

            // Then, delete the row in the 'Tierart' table
            com.CommandText = string.Format("DELETE FROM Tierart WHERE TierartID = {0};", id);
            com.ExecuteNonQuery();

            schliessen();
        }

        public void delTier(int id)
        {
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = string.Format("DELETE FROM tier WHERE TierID = {0};", id);
            com.ExecuteNonQuery();

            schliessen();
        }

        public void delGehege(int id)
        {
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = string.Format("DELETE FROM gehege WHERE GehegeID = {0};", id);
            com.ExecuteNonQuery();
            schliessen();
        }

        public List<Themenbereiche> getThemenbereiche()
        {
            List<Themenbereiche> liko = new List<Themenbereiche>();
            oeffnen();
            try
            {
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM themenbereich ORDER BY Name";
                // Sendet die oben geschriebene query ab
                MySqlDataReader reader = com.ExecuteReader();
                while(reader.Read())
                {
                    liko.Add(
                        new Themenbereiche(
                            // Nummern ist die Reihenfolge der Daten, wie Sie ankommen
                            reader.GetInt32("ThemenbereichID"),
                            reader.GetString("Name")
                            )
                        );
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            schliessen();
            return liko;
        }

        public List<Tierart> getTierart()
        {
            List<Tierart> liTierart = new List<Tierart>();
            oeffnen();
            try
            {
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM tierart ORDER BY Name";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    liTierart.Add(
                        new Tierart(
                            reader.GetInt32("TierartID"),
                            reader.GetString("Name")
                        )
                    );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            schliessen();
            return liTierart;
        }

        public List<Gehege> getGehege()
        {
            List<Gehege> liGehege = new List<Gehege>();
            oeffnen();
            try
            {
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM gehege ORDER BY Name";
                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    liGehege.Add(
                        new Gehege(
                            reader.GetInt32("GehegeID"),
                            reader.GetString("Name"),
                            reader.GetInt32("ThemenbereichID")
                        )
                    );
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("In der getGehege ist was schief gelaufen: " + ex.Message);
            }
            schliessen();
            return liGehege;
        }

        public List<Tier> getTier()
        {
            List<Tier> liTier = new List<Tier>();
            oeffnen();
            try
            {
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM Tier ORDER BY Name";
                MySqlDataReader reader = com.ExecuteReader();

                while(reader.Read())
                {
                    liTier.Add(
                            new Tier(
                                    reader.GetInt32("TierID"),
                                    reader.GetString("Name"),
                                    reader.GetInt32("GehegeID"),
                                    reader.GetInt32("TierartID")
                                )
                        );
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("In der getTier ist was schief gelaufen: " + ex.Message);
            }
            schliessen();
            return liTier;
        }

        private void oeffnen()
        {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int anzahlTiere()
        {
            int anzahl = 0;

            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT COUNT(TierID) from tier;";
            MySqlDataReader reader = com.ExecuteReader();

            if(reader.Read())
            {
                anzahl = reader.GetInt32(0);
            }
            reader.Close();
            schliessen();
            return anzahl;
        }

        public List<Tier> gehegeTiere()
        {
            List<Tier> temp = new List<Tier>();
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT Gehege.Name AS GehegeName, Tier.Name AS TierName FROM Tier JOIN Gehege ON Tier.GehegeID = Gehege.GehegeID ORDER BY GehegeName, TierName;";
            MySqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                temp.Add(
                    new Tier(
                        reader.GetString("GehegeName"),
                        reader.GetString("TierName")
                        )
                    );
            }

            reader.Close();
            schliessen();

            return temp;
        }

        public int anzahlVerschTierarten()
        {
            int anzahl = 0;
            
            oeffnen();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT COUNT(DISTINCT TierartID) FROM Tier;";
            MySqlDataReader reader = com.ExecuteReader();

            if (reader.Read())
            {
                anzahl = reader.GetInt32(0);
            }
            reader.Close();
            schliessen();

            return anzahl;
        }

        public List<List<string>> wievieleTiereTierart()
        {
            List<List<string>> list = new List<List<string>>(); 
            
            oeffnen();
            
            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT t.Name AS Tierart, COUNT(*) AS AnzahlTiere FROM Tier ti JOIN Tierart t ON ti.TierartID = t.TierartID GROUP BY ti.TierartID;";
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                List<string> temp = new List<string>();

                temp.Add(
                    reader.GetString("Tierart")
                );
                temp.Add(
                    reader.GetInt32("AnzahlTiere").ToString()
                    );

                list.Add(temp);
            }

            reader.Close();
            schliessen();

            return list;
        }

        public List<List<string>> welcheTierartThemenbereich()
        {
            List<List<string>> list = new List<List<string>>();

            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT t.Name AS Tierart, th.Name AS Themenbereich FROM Tier ti JOIN Gehege g ON ti.GehegeID = g.GehegeID JOIN Themenbereich th ON g.ThemenbereichID = th.ThemenbereichID JOIN Tierart t ON ti.TierartID = t.TierartID ORDER BY th.Name, t.Name;";
            MySqlDataReader reader = com.ExecuteReader();

            while(reader.Read())
            {
                List<string> temp = new List<string>();

                temp.Add(reader.GetString("Themenbereich"));
                temp.Add(reader.GetString("Tierart"));

                list.Add(temp);

            }

            reader.Close();
            schliessen();
            return list;
        }

        public List<string> leereGehege()
        {
            List<string> list = new List<string>();
            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT g.Name AS Gehege FROM Gehege g LEFT JOIN Tier t ON g.GehegeID = t.GehegeID WHERE t.TierID IS NULL;";
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                list.Add(reader.GetString("Gehege"));
            }
            
            reader.Close();
            schliessen();
            return list;
        }

        public List<string> leereThemenbereiche()
        {
            List<string> list = new List<string>();
            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT th.Name AS Themenbereich FROM Themenbereich th LEFT JOIN Gehege g ON th.ThemenbereichID = g.ThemenbereichID WHERE g.GehegeID IS NULL;";
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                list.Add(reader.GetString("Themenbereich"));
            }

            reader.Close();
            schliessen();
            return list;
        }

        private void schliessen()
        {
            try
            {
                if(con != null)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}