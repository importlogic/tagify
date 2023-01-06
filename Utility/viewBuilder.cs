using System.Diagnostics;
using System.Data.SQLite;
using System.ComponentModel;

namespace tagify
{
    internal class viewBuilder : mainWindow
    {
        internal static void loadView()
        {
            Interactor.mainView.Items.Clear();
            Interactor.mainView.Tag = 1;
            resetFileInformation();

            if(locationHistory.Count == 0)
                Interactor.backButton.Enabled = false;
            else
                Interactor.backButton.Enabled = true;

            Interactor.addressBar.ForeColor = SystemColors.GrayText;
            Interactor.addressBar.BorderStyle = BorderStyle.FixedSingle;

            Interactor.searchBar.Text = " Search your Tag";
            Interactor.searchBar.ForeColor = SystemColors.GrayText;
            Interactor.searchBar.BorderStyle = BorderStyle.FixedSingle;

            if (locationHistory.Count == 0)
            {
                DriveInfo[] drives = null;
                Interactor.addressBar.Text = " home";

                try
                {
                    drives = DriveInfo.GetDrives();

                    foreach(DriveInfo drive in drives)
                    {
                        try
                        {
                            ListViewItem newDrive = new ListViewItem(drive.Name);
                            newDrive.Tag = drive;
                            newDrive.ImageIndex = 42;
                            Interactor.mainView.Items.Add(newDrive);
                        }
                        catch(Exception e)
                        {
                            // excpetion in accesing drives
                        }
                    }
                }
                catch(Exception ex)
                {
                    // exception in getting drives
                }
            }
            else
            {
                Interactor.addressBar.Text = " " + locationHistory.Peek().FullName;

                bool permissionError = false;

                DirectoryInfo currentDirectory = null;

                try
                {
                    currentDirectory = locationHistory.Peek();

                    FileInfo[] files = currentDirectory.GetFiles();
                    DirectoryInfo[] directories = currentDirectory.GetDirectories();

                    foreach(FileInfo file in files)
                    {
                        addNewFile(file);
                    }

                    foreach(DirectoryInfo directory in directories)
                    {
                        addNewDirectory(directory);
                    }
                }
                catch
                {
                    // location invalid or inaccesible
                    permissionError = true;
                }

                if (permissionError)
                {
                    MessageBox.Show("One or more files could not be accessed due to Permission Error!", "ERROR", MessageBoxButtons.OK);
                }
            }

            Interactor.mainView.Focus();
        }

        internal static void addNewFile(FileInfo file)
        {
            ListViewItem newFile = new ListViewItem(file.Name);
            newFile.ImageIndex = getImageIndex(file.Extension);
            newFile.Tag = file;
            Interactor.mainView.Invoke(new Action(() => Interactor.mainView.Items.Add(newFile)));
        }

        internal static void addNewDirectory(DirectoryInfo directory)
        {
            ListViewItem newDirectory = new ListViewItem(directory.Name);
            newDirectory.ImageIndex = 41;
            newDirectory.Tag = directory;
            Interactor.mainView.Items.Add(newDirectory);
        }

        internal static void updateFromTree(TreeNode selectedNode)
        {
            bool isDirectory = selectedNode.Tag is DirectoryInfo;

            if (isDirectory)
            {
                DirectoryInfo currentDirectory = selectedNode.Tag as DirectoryInfo;
                treeBuilder.buildDirectories(currentDirectory, selectedNode);
                locationHistory.Push(currentDirectory);
            }
            else
            {
                DriveInfo currentDrive = selectedNode.Tag as DriveInfo;
                treeBuilder.buildDirectories(currentDrive.RootDirectory, selectedNode);
                locationHistory.Push(currentDrive.RootDirectory);
            }

            loadView();
        }

        internal static void openItemLocation(dynamic item)
        {
            string itemPath = "";

            bool isFile = item is FileInfo;
            bool isDirectory = item is DirectoryInfo;

            if(isFile || isDirectory)
                itemPath = item.FullName;
            else 
                itemPath = item.RootDirectory.FullName;

            Process.Start("explorer.exe", "/select," + itemPath);
        }

        internal static void openLocation()
        {

            if (locationHistory.Count == 0)
                Process.Start("explorer.exe");
            else
            {
                string currentLocation = locationHistory.Peek().FullName;
                Process.Start("explorer.exe", currentLocation);
            }  
        }

        internal static void processItem(dynamic item)
        {
            bool isFile = item.Tag is FileInfo;

            if(isFile)
            {
                FileInfo currentFile = item.Tag as FileInfo;
                Process.Start("explorer.exe", currentFile.FullName);
            }
            else
            {
                bool isDrive = item.Tag is DriveInfo;

                if(isDrive)
                {
                    DriveInfo currentDrive = item.Tag as DriveInfo;
                    locationHistory.Push(currentDrive.RootDirectory);
                }
                else
                {
                    DirectoryInfo currentDirectory = item.Tag as DirectoryInfo;
                    locationHistory.Push(currentDirectory);
                }

                loadView();
            }
        }

        internal static void setFileInformation()
        {
            ListView.SelectedListViewItemCollection selectedItems = Interactor.mainView.SelectedItems;

            if (selectedItems.Count == 1)
            {
                bool isFile = selectedItems[0].Tag is FileInfo;

                if (isFile)
                {
                    FileInfo currentFile = selectedItems[0].Tag as FileInfo;

                    if (currentFile.Name.Length < 32) Interactor.fileNameText.Text = currentFile.Name;
                    else Interactor.fileNameText.Text = currentFile.Name.Substring(0, 32) + " ...";

                    Interactor.fileTypeText.Text = currentFile.Extension;

                    string tags = tagInterface.getTags(currentFile.FullName);
                    if (tags != "") 
                        Interactor.tagsBar.Text = tags;
                    else
                        Interactor.tagsBar.Text = "--";

                    Interactor.filePathText.Text = currentFile.FullName;

                    return;
                }
            }

            resetFileInformation();
        }

        internal static void resetFileInformation()
        {
            Interactor.fileNameText.Text = "--";
            Interactor.fileTypeText.Text = "--";
            Interactor.tagsBar.Text = "--";
            Interactor.filePathText.Text = "--";
        }

        internal static void goBack()
        {
            if(locationHistory.Count > 0)
            {
                locationHistory.Pop();
                loadView();
            }
        }

        internal static void goToAddress()
        {
            string path = Interactor.addressBar.Text.Trim();

            if(path == "home") clearHistory();
            else if(path.Length > 2 && Directory.Exists(path))
            {
                DirectoryInfo currentDirectory = new DirectoryInfo(path);

                if(locationHistory.Count == 0 || (locationHistory.Peek().FullName != currentDirectory.FullName))
                    locationHistory.Push(currentDirectory);
                    
            }

            loadView();
        }

        internal static void clearHistory()
        {
            locationHistory.Clear();
            loadView();
        }

        internal static void loadSuggestions()
        {
            AutoCompleteStringCollection suggestionItems = new AutoCompleteStringCollection();
            sqlConnection = new SQLiteConnection("DataSource=" + connectionURL);
            
            try
            {
                sqlConnection.Open();

                string command = "SELECT * FROM TAGLIST;";
                sql = new SQLiteCommand(command, sqlConnection);

                sqlReader = sql.ExecuteReader();
                while(sqlReader.Read())
                {
                    suggestionItems.Add(sqlReader.GetString(0));
                }

                sqlConnection.Close();
            }
            catch
            {
                // cannot connect to database
            }

            Interactor.searchBar.AutoCompleteCustomSource = suggestionItems;
        }

        internal static void searchTag()
        {
            if(Interactor.tagSearcher.IsBusy)
            {
                return;
            }

            string searchKeyword = Interactor.searchBar.Text.Trim().ToLower();
            if(searchKeyword == "")
            {
                loadView();
                return;
            }
             
            Interactor.searchingAnimation.Visible = true;
            Interactor.searchButton.ImageIndex = 5;

            Interactor.searchBar.ForeColor = SystemColors.GrayText;
            Interactor.searchBar.Text = " " + searchKeyword;
            Interactor.searchBar.BorderStyle = BorderStyle.FixedSingle;

            Interactor.mainView.Items.Clear();
            Interactor.mainView.Focus();
            resetFileInformation();

            Interactor.searchProgressBar.Value = 0;
            Interactor.searchProgressBar.Visible = true;
            Interactor.searchResults.Visible = false;

            startTime = DateTime.Now;
            filesScanned = 0;
            resultsFound = 0;

            Interactor.tagSearcher.RunWorkerAsync(searchKeyword);
        }

        internal static void recursiveSearch(DirectoryInfo root, BackgroundWorker worker, string searchKeyword, DoWorkEventArgs e)
        {
            if(worker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            worker.ReportProgress(0);
                
            FileInfo[] files = null;
            DirectoryInfo[] directories = null;

            try
            {
                files = root.GetFiles();
            }
            catch(Exception ex)
            {
                // exception in reading files
            }

            if(files != null)
            {
                foreach (FileInfo file in files)
                {
                    if(worker.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }

                    ++filesScanned;
                    string filePath = file.FullName;

                    if(searchKeyword[0] == '.'){
                        if(file.Extension == searchKeyword)
                        {
                            ++resultsFound;
                            addNewFile(file);
                        }
                    }
                    else if(tagInterface.containsTag(filePath, searchKeyword))
                    {
                        ++resultsFound;
                        addNewFile(file);
                    }
                }
            }

            try
            {
                directories = root.GetDirectories();
            }
            catch(Exception ex)
            {
                // exception in reading directories
            }

            if (directories != null)
            {
                foreach (DirectoryInfo directory in directories)
                {
                    recursiveSearch(directory, worker, searchKeyword, e);
                }
            }
        }

        internal static void updateSearchProgress()
        {
            DateTime currentTime = DateTime.Now;

            double timeTaken = (currentTime - startTime).TotalMilliseconds;
            timeTaken = Math.Log10(timeTaken);
            timeTaken *= 16.6667;

            int progressPercent = (int)Math.Floor(timeTaken);
            progressPercent = Math.Max(progressPercent, 0);
            progressPercent = Math.Min(progressPercent, 99);

            Interactor.searchProgressBar.Value = progressPercent;
        }

        internal static void searchCompleted()
        {
            Interactor.searchProgressBar.Value = 100;
            Interactor.searchButton.ImageIndex = 4;

            DateTime currentTime = DateTime.Now;
            double timeTaken = Math.Round((currentTime - startTime).TotalMilliseconds / 1000, 4);

            Interactor.searchProgressBar.Visible = false;
            Interactor.searchingAnimation.Visible = false;

            Interactor.timeTakenLabel.Text = timeTaken.ToString() + " s";
            Interactor.filesScannedLabel.Text = filesScanned.ToString();
            Interactor.resultsFoundLabel.Text = resultsFound.ToString();

            Interactor.searchResults.Visible = true;

            Interactor.resultsTimer.Enabled = false;
            Interactor.resultsTimer.Enabled = true;
        }

        internal static void editTags()
        {
            ListView.SelectedListViewItemCollection selectedItems = Interactor.mainView.SelectedItems;

            if(selectedItems.Count > 0)
            {
                SortedSet<string> commonTags = tagInterface.getCommonTags(selectedItems);
                
                tagSelectorDialog newDialog = new tagSelectorDialog(commonTags);

                if(newDialog.ShowDialog() == DialogResult.OK)
                {
                    SortedSet<string> finalTags = new SortedSet<string>();

                    foreach (DataGridViewRow row in newDialog.tagSelected.Rows)
                        finalTags.Add(row.Cells[0].Value.ToString());

                    List<string> tagsToDelete = commonTags.Except(finalTags).ToList();
                    List<string> tagsToAdd = finalTags.Except(commonTags).ToList();

                    if(tagsToDelete.Count > 0)
                        tagInterface.deleteBatchTags(selectedItems, tagsToDelete);

                    if(tagsToAdd.Count > 0)
                        tagInterface.addBatchTags(selectedItems, tagsToAdd);
                }

                setFileInformation();
            }
        }

        internal static void deleteAllTags()
        {
            ListView.SelectedListViewItemCollection selectedItems = Interactor.mainView.SelectedItems;

            if(selectedItems.Count > 0)
            {
                DialogResult confirmResult = MessageBox.Show("Do you want to remove all the Tags from the selected files?", "Delete All Tags", MessageBoxButtons.YesNo);

                if(confirmResult == DialogResult.Yes)
                {
                    tagInterface.deleteAllTags(selectedItems);
                }

                setFileInformation();
            }
        }

        internal static void sortMainView()
        {
            List<dynamic> mainViewItems = new List<dynamic>();

            foreach (ListViewItem item in Interactor.mainView.Items)
            {
                bool isFile = item.Tag is FileInfo;
                bool isDirectory = item.Tag is DirectoryInfo;

                if(isFile || isDirectory)
                    mainViewItems.Add(item.Tag);
            }

            if(mainViewItems.Count > 0)
            {
                int state = (int)Interactor.mainView.Tag;

                if (state == 1)
                    mainViewItems.Sort((x, y) => (x.Name).CompareTo(y.Name));
                else
                    mainViewItems.Sort((x, y) => (y.Name).CompareTo(x.Name));

                state ^= 1;

                Interactor.mainView.Tag = state;
                Interactor.mainView.Items.Clear();

                foreach(dynamic item in mainViewItems)
                {
                    bool isFile = item is FileInfo;

                    if (isFile)
                        addNewFile(item);
                    else
                        addNewDirectory(item);
                }  
            }
        }

        internal static int getImageIndex(string extension)
        {
            switch(extension)
            {
                case ".3ds":
                    return 0;
                case ".aac":
                    return 1;
                case ".avi":
                    return 2;
                case ".bmp":
                    return 3;
                case ".cad":
                    return 4;
                case ".cdr":
                    return 5;
                case ".css":
                    return 6;
                case ".dat":
                    return 7;
                case ".dll":
                    return 8;
                case ".dmg":
                    return 9;
                case ".doc":
                    return 10;
                case ".eps":
                    return 11;
                case ".fla":
                    return 13;
                case ".flv":
                    return 14;
                case ".gif":
                    return 15;
                case ".html":
                    return 16;
                case ".indd":
                    return 17;
                case ".iso":
                    return 18;
                case ".jpg":
                    return 19;
                case ".js":
                    return 20;
                case ".midi":
                    return 21;
                case ".mov":
                    return 22;
                case ".mp3":
                    return 23;
                case ".mp4":
                    return 24;
                case ".mpg":
                    return 25;
                case ".pdf":
                    return 26;
                case ".php":
                    return 27;
                case ".png":
                    return 28;
                case ".ppt":
                    return 29;
                case ".ps":
                    return 30;
                case ".psd":
                    return 31;
                case ".raw":
                    return 32;
                case ".sql":
                    return 33;
                case ".svg":
                    return 34;
                case ".tif":
                    return 35;
                case ".txt":
                    return 36;
                case ".wmv":
                    return 37;
                case ".xls":
                    return 38;
                case ".xml":
                    return 39;
                case ".zip":
                    return 40;
                default:
                    return 12;
            }
        }
    }
}