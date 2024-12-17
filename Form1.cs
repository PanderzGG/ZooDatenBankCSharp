using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.BC;
using System.Drawing;

namespace DatenBankZoo
{
    public partial class Form1 : Form
    {
        private Datenbank db;
        private List<Themenbereiche> liTheme;
        private List<Tierart> litiera;
        private List<Gehege> ligehege;
        private List<Tier> litier;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new Datenbank();
            dispThemenbereiche();
            dispGehege();
            dispTierart();
            dispTier();
        }
        private void dispThemenbereiche()
        {
            liTheme = db.getThemenbereiche();
            listBoxThemenbereiche.Items.Clear();
            comboBoxThemenBereiche.Items.Clear();
            comboBoxTierThemenbereich.Items.Clear();
            try
            {
                foreach (Themenbereiche theme in liTheme)
                {
                    listBoxThemenbereiche.Items.Add(theme.TName1);
                    comboBoxThemenBereiche.Items.Add(theme.TName1);
                    comboBoxTierThemenbereich.Items.Add(theme.TName1);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Themenbereiche k�nnen nicht angezeigt werden, Fehler: " + ex.Message);
            }
            
        }

        private void dispTier()
        {
            litier = db.getTier();
            dataGridViewTiere.Rows.Clear();

            try
            {
                foreach (Tier tier in litier)
                {


                    string taName =
                        litiera.Find(x => x.TierartId == tier.TierartID).Name;


                    string gName =
                        ligehege.Find(x => x.GehegeID == tier.GehegeID).Name;


                    int thnr = ligehege.Find(x => x.GehegeID == tier.GehegeID).ThemenbereichID;
                    string tbName = liTheme.Find(x => x.TNr1 == thnr).TName1;


                    // Daten zur DataGridView hinzuf�gen
                    dataGridViewTiere.Rows.Add(tier.Name, taName, gName, tbName);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Tiere k�nnen nicht angezeigt werden, Fehler: " + ex.Message);
            }

            
        }

        private void dispTierart()
        {
            litiera = db.getTierart();
            listBoxTierart.Items.Clear();

            try
            {
                foreach (Tierart tiera in litiera)
                {
                    listBoxTierart.Items.Add(tiera.Name);
                    comboBoxTierTierart.Items.Add(tiera.Name);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Tierarten k�nnen nicht angezeigt werden, Fehler: " + ex.Message);
            }
            
        }

        private void dispGehege()
        {
            ligehege = db.getGehege();

            try
            {
                foreach (Gehege gehege in ligehege)
                {

                    comboBoxTierGehege.Items.Add(gehege.Name);

                    string s = liTheme.Find(x => x.TNr1 == gehege.ThemenbereichID).TName1;
                    dataGridGehege.Rows.Add(gehege.Name, s);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Gehege k�nnen nicht angezeigt werden, Fehler: " + ex.Message);
            }
            
        }

        private void buttonThemenbereichSpeichern_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbTheme.Text != "")
                {
                    // Immer �berpr�fen ob ein Element ausgew�hlt wurde
                    int nr = listBoxThemenbereiche.SelectedIndex == -1 ? -1 : liTheme[listBoxThemenbereiche.SelectedIndex].TNr1;
                    // -1 , da die ID automatisch generiert wird
                    Themenbereiche theme = new Themenbereiche(-1, tbTheme.Text);

                    db.newThemenbereich(theme);

                    listBoxThemenbereiche.Items.Clear();
                    dispThemenbereiche();
                    MessageBox.Show(string.Format("{0} erfolgreich gespeichert", theme.TName1));
                }
                else
                {
                    MessageBox.Show("Bitte geben Sie einen Themenbereich ein");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Themenbereich kann nicht gespeichert werden, Fehler: " + ex.Message);
            }

        }

        private void buttonSpeichernTierart_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbTierart.Text != "")
                {
                    int nr = listBoxTierart.SelectedIndex == -1 ? -1 : litiera[listBoxTierart.SelectedIndex].TierartId;

                    Tierart tiera = new Tierart(-1, tbTierart.Text);

                    db.newTierart(tiera);
                    listBoxTierart.Items.Clear();
                    dispTierart();

                    tbTierart.Text = "";
                    MessageBox.Show(string.Format("{0} erfolgreich gespeichert", tiera.Name));
                }
                else
                {
                    MessageBox.Show("Bitte geben Sie eine Tierart ein");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tierart kann nicht gespeichert werden, Fehler: " + ex.Message);
            }
        }

        private void buttonTierSpeichern_Click(object sender, EventArgs e)
        {
            try
            {// Pr�fen, ob alle erforderlichen Felder ausgef�llt sind
            
                if (string.IsNullOrWhiteSpace(tbTierName.Text) ||
                comboBoxTierGehege.SelectedIndex == -1 ||
                comboBoxTierTierart.SelectedIndex == -1)
                {
                    MessageBox.Show("Bitte alle Felder ausf�llen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Neues Tier erstellen (TierID auf -1, weil es neu ist)
                Tier tier = new Tier(
                                -1, // Platzhalter f�r neue IDs
                                tbTierName.Text,
                                ligehege[comboBoxTierGehege.SelectedIndex].GehegeID,
                                litiera[comboBoxTierTierart.SelectedIndex].TierartId
                );

                // In die Datenbank speichern
                db.newTier(tier);

                dataGridViewTiere.Rows.Clear();

                // DataGridView aktualisieren
                dispTier();
                MessageBox.Show(string.Format("{0} erfolgreich gespeichert", tier.Name));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Tier kann nicht gespeichert werden, Fehler: " + ex.Message);
            }
        }

        private void buttonGehegeUnk_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbGehegeName.Text != "")
                {

                    Gehege gh = new Gehege(-1, tbGehegeName.Text, liTheme[comboBoxThemenBereiche.SelectedIndex].TNr1);
                    db.newGehege(gh);

                    MessageBox.Show(string.Format("{0} erfolgreich gespeichert", gh.Name));

                    tbGehegeName.Text = "";
                    comboBoxThemenBereiche.SelectedIndex = -1;
                    dataGridGehege.Rows.Clear();
                    dispGehege();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Gehege kann nicht gespeichert werden, Fehler: " + ex.Message);
            }
        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {
            try
            {   // -1 Pr�fung ob ein Element ausgew�hlt wurde
                if (listBoxThemenbereiche.SelectedIndex != -1)
                {
                    int which = liTheme[listBoxThemenbereiche.SelectedIndex].TNr1;
                    string name = liTheme[listBoxThemenbereiche.SelectedIndex].TName1;
                    db.delThemenbereich(which);
                    dispThemenbereiche();
                    MessageBox.Show(string.Format("{0} erfolgreich gel�scht", name));
                }
                else
                {
                    MessageBox.Show("Bitte w�hlen Sie einen Themenbereich aus");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Themenbereich kann nicht gel�scht werden, Fehler: " + ex.Message);
            }
        }

        private void buttonL�schenTierart_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxTierart.SelectedIndex != -1)
                {
                    int which = litiera[listBoxTierart.SelectedIndex].TierartId;
                    string name = litiera[listBoxTierart.SelectedIndex].Name;

                    db.delTierart(which);

                    listBoxTierart.Items.Clear();
                    dispTierart();

                    tbTierart.Text = "";
                    MessageBox.Show(string.Format("{0} erfolgreich gel�scht", name));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Tierart kann nicht gel�scht werden, Fehler: " + ex.Message);
            }
        }

        private void buttonTierLoeschen_Click(object sender, EventArgs e)
        {
            try
            {// Pr�fen, ob eine Zeile selektiert ist
                if (dataGridViewTiere.SelectedRows.Count > 0)
                {
                    // TierID der selektierten Zeile auslesen
                    int selectedRowIndex = dataGridViewTiere.SelectedRows[0].Index;
                    string tierName = litier[selectedRowIndex].Name;

                    //// Datenbank l�schen


                    db.delTier(litier[selectedRowIndex].TierID);

                    dataGridViewTiere.Rows.Clear();
                    // Anzeige aktualisieren
                    dispTier();
                    MessageBox.Show(string.Format("{0} wurde erfolgreich gel�scht", tierName));
                }
                else
                {
                    MessageBox.Show("Bitte eine Zeile ausw�hlen, die gel�scht werden soll.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Tier kann nicht gel�scht werden, Fehler: " + ex.Message);
            }
        }

        private void buttonGehegeLoeschen_Click(object sender, EventArgs e)
        {
            if(dataGridGehege.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridGehege.SelectedRows[0].Index;
                string gehegeName = tbGehegeName.Text;
                
                db.delGehege(ligehege[selectedRowIndex].GehegeID);
                dataGridGehege.Rows.Clear();
                
                dispGehege();
                MessageBox.Show(string.Format("{0} erfolgreich hinzufgef�gt", gehegeName));
            }
            else
            {
                MessageBox.Show("Bitte eine Zeile ausw�hlen, die gel�scht werden soll.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxThemenbereiche.SelectedIndex != -1)
            {
                tbTheme.Text = liTheme[listBoxThemenbereiche.SelectedIndex].TName1;
            }

        }

        private void buttonThemenbereichNeu_Click(object sender, EventArgs e)
        {
            listBoxThemenbereiche.SelectedIndex = -1;
            tbTheme.Text = "";
        }

        private void listBoxTierart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTierart.SelectedIndex != -1)
            {
                tbTierart.Text = litiera[listBoxTierart.SelectedIndex].Name;
            }
        }

        private void buttonNeuTierart_Click(object sender, EventArgs e)
        {
            listBoxTierart.SelectedIndex = -1;
            tbTierart.Text = "";
        }

        private void buttonTierNeu_Click(object sender, EventArgs e)
        {
            dataGridViewTiere.ClearSelection();

            tbTierName.Text = "";
            lbTierIDWert.Text = "";
            comboBoxTierGehege.SelectedIndex = -1;
            comboBoxTierTierart.SelectedIndex = -1;
            comboBoxTierThemenbereich.SelectedIndex = -1;
        }

        private void buttonGehegeNeu_Click(object sender, EventArgs e)
        {
            dataGridGehege.ClearSelection();
            tbGehegeName.Text = "";
            comboBoxThemenBereiche.SelectedIndex = -1;
        }

        private void dataGridGehege_SelectionChanged(object sender, EventArgs e)
        {
            int index = dataGridGehege.CurrentRow.Index;
            tbGehegeName.Text = ligehege[index].Name;

            index = liTheme.FindIndex(x => x.TNr1 == ligehege[index].ThemenbereichID);
            comboBoxThemenBereiche.SelectedIndex = index;
        }

        private void dataGridViewTiere_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTiere.CurrentRow.Index >= 0)
            {

                int tierIndex = dataGridViewTiere.CurrentRow.Index;

                lbTierIDWert.Text = litier[tierIndex].TierID.ToString();
                tbTierName.Text = litier[tierIndex].Name;


                int gehegeIndex = ligehege.FindIndex(x => x.GehegeID == litier[tierIndex].GehegeID);
                if (gehegeIndex >= 0)
                {
                    comboBoxTierGehege.SelectedIndex = gehegeIndex;
                }


                int tierartIndex = litiera.FindIndex(x => x.TierartId == litier[tierIndex].TierartID);
                if (tierartIndex >= 0)
                {
                    comboBoxTierTierart.SelectedIndex = tierartIndex;
                }


                if (gehegeIndex >= 0)
                {

                    int themenbereichIndex = liTheme.FindIndex(x => x.TNr1 == ligehege[gehegeIndex].ThemenbereichID);
                    if (themenbereichIndex >= 0)
                    {
                        comboBoxTierThemenbereich.SelectedIndex = themenbereichIndex;
                    }
                }
            }
        }

        private void radioButtonThemenbereichTierarten_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewStatistik.Columns.Clear();
            dataGridViewStatistik.Rows.Clear();
            string rbTag = tabPageStatistik.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Tag.ToString();

            switch (rbTag)
            {
                case "1":

                    int AnzahlTiere = db.anzahlTiere();

                    dataGridViewStatistik.Columns.Add("AnzahlTiere", "Anzahl der Tiere im Zoo");
                    dataGridViewStatistik.Rows.Add(AnzahlTiere.ToString());

                    break;

                case "2":

                    List<Tier> temp = new List<Tier>();
                    temp = db.gehegeTiere();

                    dataGridViewStatistik.Columns.Add("StatistikGehege", "Gehege");
                    dataGridViewStatistik.Columns.Add("StatistikTierName", "Tier");

                    foreach (Tier t in temp)
                    {
                        dataGridViewStatistik.Rows.Add(t.Gehegename, t.Name);
                    }

                    break;
                case "3":

                    List<string> tempo = db.leereGehege();

                    dataGridViewStatistik.Columns.Add("StatistikGehegeOhneTier", "Gehege");

                    foreach (string s in tempo)
                    {
                        dataGridViewStatistik.Rows.Add(s);
                    }

                    if (tempo.Count == 0)
                    {
                        dataGridViewStatistik.Rows.Add("Volle Bude");

                    }

                    break;
                case "4":
                    int anzahl = db.anzahlVerschTierarten();

                    dataGridViewStatistik.Columns.Add("AnzahlVerschTierarten", "Anzahl der verschiedenene Tierarten in unserem Zoo.");
                    dataGridViewStatistik.Rows.Add(anzahl.ToString());

                    break;
                case "5":
                    List<List<string>> list = new List<List<string>>();

                    list = db.wievieleTiereTierart();
                    dataGridViewStatistik.Columns.Add("Tierarten", "Tierarten");
                    dataGridViewStatistik.Columns.Add("AnzahlTierarten", "Anzahl der Tierarten");

                    foreach (List<string> t in list)
                    {
                        dataGridViewStatistik.Rows.Add(t[0], t[1]);
                    }

                    break;
                case "6":
                    List<string> tempa = db.leereThemenbereiche();

                    dataGridViewStatistik.Columns.Add("StatistikThemenbereicheOhneGehege", "Themenbereiche");

                    foreach (string t in tempa)
                    {
                        dataGridViewStatistik.Rows.Add(t);
                    }

                    if (tempa.Count == 0)
                    {
                        dataGridViewStatistik.Rows.Add("Alle Themenbereiche besitzen Gehege");
                    }
                    break;
                case "7":
                    List<List<string>> listdeux = new List<List<string>>();

                    listdeux = db.welcheTierartThemenbereich();
                    dataGridViewStatistik.Columns.Add("Themenbereiche", "Themenbereich");
                    dataGridViewStatistik.Columns.Add("Tierarten", "Tierart");

                    foreach (List<string> t in listdeux)
                    {
                        dataGridViewStatistik.Rows.Add(t[0], t[1]);
                    }

                    break;

            }
        }

    }
}