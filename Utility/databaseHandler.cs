using System.ComponentModel;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;

namespace tagify
{
    internal class databaseHandler : mainWindow
    {
        internal static void connectDatabase()
        {
            sqlConnection = new SQLiteConnection("Data Source=" + connectionURL + "\\database.db");
            string folderLocation = connectionURL;
            connectionURL += "\\database.db";

            if (!File.Exists(connectionURL))
            {
                if (!Directory.Exists(folderLocation))
                    Directory.CreateDirectory(folderLocation);

                File.Create(connectionURL);
            }
            
            Interactor.databaseConnector.RunWorkerAsync();
        }

        internal static void tryConnection(object sender, DoWorkEventArgs e)
        {
            int retries = 0;
            BackgroundWorker worker = sender as BackgroundWorker;

            while (true)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                Debug.WriteLine("Connecting to database....");

                try
                {
                    sqlConnection.Open();
                }
                catch (Exception ex)
                {
                    ++retries;
                    if (retries == 5)
                    {
                        worker.CancelAsync();
                        continue;
                    }

                    Thread.Sleep(1000);
                    continue;
                }

                break;
            }
        }

        internal static void connectionSuccess(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                Debug.WriteLine("connection failed");
                Interactor.notification.ShowBalloonTip(15000, "Database Error", "Couldn't connect to Database. Some features might not work as expected. Please try restarting the application.", ToolTipIcon.Error);
                // handle situation here
            }
            else
            {
                try
                {
                    string command = "CREATE TABLE IF NOT EXISTS TAGLIST (name TEXT NOT NULL UNIQUE, PRIMARY KEY(name));";
                    sql = new SQLiteCommand(command, sqlConnection);
                    sql.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                catch(Exception ex)
                {
                    Debug.WriteLine("connection failed");
                    Interactor.notification.ShowBalloonTip(15000, "Database Error", "Couldn't connect to Database. Some features might not work as expected. Please try restarting the application.", ToolTipIcon.Error);
                    return;
                }

                Debug.WriteLine("database connected");
            }
        }
    }
}