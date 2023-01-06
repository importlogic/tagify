using System.Data.SQLite;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.VisualBasic;

namespace tagify
{
    public partial class tagSelectorDialog : Form
    {
        private static SQLiteConnection sqlConnection;
        private static SQLiteCommand sql;
        private static SQLiteDataReader sqlReader;
        private static string connectionURL = "C:\\ProgramData\\Tagify\\database.db";
        private static tagSelectorDialog Interactor;

        public tagSelectorDialog(SortedSet<string> commonTags)
        {
            InitializeComponent();
            Interactor = this;

            sqlConnection = new SQLiteConnection("Data Source=" + connectionURL);

            try
            {
                sqlConnection.Open();
            }
            catch(Exception ex)
            {
                // cannot connect to server
            }

            loadSelectedTags(commonTags);
            loadTagHistory();
        }

        private static void loadSelectedTags(SortedSet<string> commonTags)
        {
            foreach(string item in commonTags)
            {
                Interactor.tagSelected.Rows.Insert(Interactor.tagSelected.Rows.Count, item);
            }
        }

        private static void loadTagHistory()
        {
            Interactor.tagHistory.Rows.Clear();
            string searchBoxText = Interactor.searchBox.Text;

            if(Interactor.searchBox.Text == "Search Old Tags or Add New Tags")
                searchBoxText = "";

            string command = "SELECT * FROM TAGLIST WHERE name LIKE ($searchText) ORDER BY name;";

            sql = new SQLiteCommand(command, sqlConnection);
            sql.Parameters.AddWithValue("$searchText", "%" + searchBoxText + "%");

            try
            {
                sqlReader = sql.ExecuteReader();
                while(sqlReader.Read())
                {
                    Interactor.tagHistory.Rows.Insert(Interactor.tagHistory.Rows.Count, sqlReader.GetString(0));
                }
            }
            catch
            {
                // cannot connect to database
            }
        }

        private static bool validateNewRow(string newRow)
        {
            foreach(DataGridViewRow row in Interactor.tagSelected.Rows)
            {
                if (row.Cells[0].Value.ToString() == newRow)
                    return false;
            }

            return true;
        }

        private static void addRows()
        {
            foreach (DataGridViewCell item in Interactor.tagHistory.SelectedCells)
            {
                if(validateNewRow(item.Value.ToString()))
                    Interactor.tagSelected.Rows.Insert(0, item.Value.ToString());
            }
        }

        private static void removeRows()
        {
            foreach (DataGridViewCell item in Interactor.tagSelected.SelectedCells)
            {
                Interactor.tagSelected.Rows.RemoveAt(item.RowIndex);
            }
        }

        private static void clearTagHistory()
        {
            DialogResult confirmResult = MessageBox.Show("Are you sure to delete your Tag History?\n\nAll your files will still remain tagged.", "Clear Tag History", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                string command = "DELETE FROM TAGLIST;";

                sql = new SQLiteCommand(command, sqlConnection);

                try
                {
                    sql.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    // cannot connect to data base
                }

                loadTagHistory();
            }
        }

        private static void clearSelectedTags()
        {
            Interactor.tagSelected.Rows.Clear();
        }

        private static void addNewTag()
        {
            string newTag = Interactor.searchBox.Text.Trim();

            if(newTag.Length > 0)
            {
                if (newTag[0] == '.')
                {
                    MessageBox.Show("Tag Name cannot start with a '.' symbol.", "Invalid Tag", MessageBoxButtons.OK);
                }
                else if (newTag != "Search Old Tags or Add New Tags")
                {
                    newTag = newTag.ToLower();

                    if (validateNewRow(newTag))
                    {
                        string command = "INSERT INTO TAGLIST VALUES ($newTag)";
                        sql = new SQLiteCommand(command, sqlConnection);
                        sql.Parameters.AddWithValue("$newTag", newTag);

                        try
                        {
                            sql.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            // cannot connect to database
                        }

                        Interactor.tagSelected.Rows.Insert(0, newTag);
                    }
                }
            }

            Interactor.searchBox.Text = "Search Old Tags or Add New Tags";
            Interactor.searchBox.ForeColor = SystemColors.GrayText;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            loadTagHistory();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addRows();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            removeRows();
        }

        private void tagSelected_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridView table = sender as DataGridView;

            table.Sort(table.Columns[0], ListSortDirection.Ascending);
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            addNewTag();
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                addNewTag();
                Interactor.tagHistory.Focus();
            }
        }

        private void clearSelectedButton_Click(object sender, EventArgs e)
        {
            clearSelectedTags();
        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            Interactor.searchBox.Text = "";
            Interactor.searchBox.ForeColor = SystemColors.WindowText;
        }

        private void clearHistoryButton_Click(object sender, EventArgs e)
        {
            clearTagHistory();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void rejectButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tagSelectorDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            sqlConnection.Close();
        }
    }
}
