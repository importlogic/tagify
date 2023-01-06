using System.Diagnostics;
using System.IO;

namespace tagify
{
    internal class treeBuilder : mainWindow
    {
        internal static void buildTree()
        {
            DriveInfo[] drives = null;

            try
            {
                drives = DriveInfo.GetDrives();
            }
            catch (Exception e)
            {
                // exception in getting drives
            }

            foreach (DriveInfo drive in drives)
            {
                try
                {
                    TreeNode newDrive = new TreeNode(drive.Name);
                    newDrive.ImageIndex = 1;
                    newDrive.SelectedImageIndex = 1;
                    newDrive.Tag = drive;

                    Interactor.treeView.Nodes.Add(newDrive);
                }
                catch (Exception e)
                {
                    // error in accessing drives
                }
            }

        }

        internal static void buildDirectories(DirectoryInfo directory, TreeNode directoryNode)
        {
            DirectoryInfo[] directories = null;

            try
            {
                directories = directory.GetDirectories();
                directoryNode.Nodes.Clear();

                foreach (DirectoryInfo currentDirectory in directories)
                {
                    try
                    {
                        TreeNode newNode = new TreeNode(currentDirectory.Name);
                        newNode.ImageIndex = 0;
                        newNode.SelectedImageIndex = 0;
                        newNode.Tag = currentDirectory;

                        directoryNode.Nodes.Add(newNode);
                    }
                    catch (Exception e)
                    {
                        // exception while trying to access folders
                    }
                }
            }
            catch (Exception e)
            {
                // error in getting directories
            }
        }
    }
}