using System.Diagnostics;
using System.Data.SQLite;
using System.ComponentModel;

namespace tagify
{
    public partial class mainWindow : Form
    {
        protected static mainWindow Interactor;
        protected static Stack<DirectoryInfo> locationHistory;

        protected static SQLiteConnection sqlConnection;
        protected static SQLiteCommand sql;
        protected static SQLiteDataReader sqlReader;
        protected static string connectionURL;

        protected static DateTime startTime;
        protected static long filesScanned;
        protected static long resultsFound;

        public mainWindow()
        {
            Interactor = this;
            locationHistory = new Stack<DirectoryInfo>();
            InitializeComponent();
            treeBuilder.buildTree();
            viewBuilder.loadView();

            connectionURL = "C:\\ProgramData\\Tagify";
            databaseHandler.connectDatabase();
        }
        
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Interactor.tagSearcher.CancelAsync();

            TreeNode selectedNode = e.Node;
            viewBuilder.updateFromTree(selectedNode);
        }

        private void mainView_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewBuilder.setFileInformation();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewBuilder.processItem(Interactor.mainView.SelectedItems[0]);
        }

        private void openInExplorer_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedItems = Interactor.mainView.SelectedItems;

            if (selectedItems.Count == 1)
                viewBuilder.openItemLocation(selectedItems[0].Tag);
            else
                viewBuilder.openLocation();
        }

        private void mainView_DoubleClick(object sender, EventArgs e)
        {
            viewBuilder.processItem(Interactor.mainView.SelectedItems[0]);
        }

        private void mainView_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13 && Interactor.mainView.SelectedItems.Count == 1)
                viewBuilder.processItem(Interactor.mainView.SelectedItems[0]);

            if(e.KeyValue == 8)
            {
                Interactor.tagSearcher.CancelAsync();

                viewBuilder.goBack();
            }
                
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Interactor.tagSearcher.CancelAsync();

            viewBuilder.goBack();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Interactor.tagSearcher.CancelAsync();

            viewBuilder.clearHistory();
        }
        private void addressBar_Enter(object sender, EventArgs e)
        {
            addressBar.ForeColor = SystemColors.WindowText;
            addressBar.BorderStyle = BorderStyle.Fixed3D;
        }

        private void addressBar_Leave(object sender, EventArgs e)
        {
            Interactor.tagSearcher.CancelAsync();
            
            viewBuilder.loadView();
        }

        private void addressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Interactor.tagSearcher.CancelAsync();

                viewBuilder.goToAddress();
            }
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            Interactor.tagSearcher.CancelAsync();

            viewBuilder.loadView();
        }

        private void sortMainViewItems_Click(object sender, EventArgs e)
        {
            viewBuilder.sortMainView();
        }

        private void searchBar_Enter(object sender, EventArgs e)
        {
            Interactor.searchBar.Text = "";
            Interactor.searchBar.ForeColor = SystemColors.WindowText;
            Interactor.searchBar.BorderStyle = BorderStyle.Fixed3D;

            viewBuilder.loadSuggestions();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Interactor.tagSearcher.CancelAsync();

            viewBuilder.searchTag();
        }

        private void searchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Interactor.tagSearcher.CancelAsync();

                viewBuilder.searchTag();
            }
        }

        private void editTagsButton_Click(object sender, EventArgs e)
        {
            viewBuilder.editTags();
        }

        private void deleteTagsButton_Click(object sender, EventArgs e)
        {
            viewBuilder.deleteAllTags();
        }

        private void databaseConnector_DoWork(object sender, DoWorkEventArgs e)
        {
            databaseHandler.tryConnection(sender, e);
        }

        private void databaseConnector_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            databaseHandler.connectionSuccess(sender, e);
        }

        private void notification_MouseClick(object sender, MouseEventArgs e)
        {
            Interactor.TopMost = true;
            Interactor.TopMost = false;
            Interactor.WindowState = FormWindowState.Normal;
        }

        private void tagSearcher_DoWork(object sender, DoWorkEventArgs e)
        {
            string searchKeyword = e.Argument as string;
            BackgroundWorker worker = sender as BackgroundWorker;
            
            if(locationHistory.Count == 0)
            {
                DriveInfo[] drives = DriveInfo.GetDrives();

                foreach(DriveInfo drive in drives)
                    viewBuilder.recursiveSearch(drive.RootDirectory, worker, searchKeyword, e);
            }
            else
            {
                DirectoryInfo currentDirectory = locationHistory.Peek();
                viewBuilder.recursiveSearch(currentDirectory, worker, searchKeyword, e);
            }
        }

        private void tagSearcher_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            viewBuilder.searchCompleted();
        }

        private void tagSearcher_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            viewBuilder.updateSearchProgress();
        }

        private void resultsTimer_Tick(object sender, EventArgs e)
        {
            resultsTimer.Enabled = false;
            Interactor.searchResults.Visible = false;
        }
    }
}