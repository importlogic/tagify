using System.Diagnostics;
using System.IO;
using System.Numerics;

namespace tagify
{
    internal class tagInterface : mainWindow
    {
        internal static string getTags(string filePath)
        {
            return tagsParse(getAds(filePath));
        }

        internal static void deleteBatchTags(ListView.SelectedListViewItemCollection items, List<string> inputTags)
        {
            foreach (ListViewItem item in items)
            {
                bool isFile = item.Tag is FileInfo;

                if (isFile)
                {
                    FileInfo currentFile = item.Tag as FileInfo;
                    string filePath = currentFile.FullName;

                    SortedSet<string> oldTags = stringToSet(getAds(filePath));
                    List<string> newTags = oldTags.Except(inputTags).ToList();

                    string finalTags = setToString(newTags);
                    setAds(filePath, finalTags);
                }
            }
        }

        internal static void addBatchTags(ListView.SelectedListViewItemCollection items, List<string> inputTags)
        {
            foreach (ListViewItem item in items)
            {
                bool isFile = item.Tag is FileInfo;

                if(isFile)
                {
                    FileInfo currentFile = item.Tag as FileInfo;
                    string filePath = currentFile.FullName;

                    List<string> newTags = inputTags.ToList();
                    SortedSet<string> oldTags = stringToSet(getAds(filePath));

                    foreach(string tag in newTags)
                        oldTags.Add(tag);

                    string finalTags = setToString(oldTags);

                    setAds(filePath, finalTags);
                }
            }
        }

        internal static void deleteAllTags(ListView.SelectedListViewItemCollection items)
        {
            foreach (ListViewItem item in items)
            {
                bool isFile = item.Tag is FileInfo;

                if (isFile)
                {
                    FileInfo currentFile = item.Tag as FileInfo;
                    string filePath = currentFile.FullName;

                    setAds(filePath, "");
                }
            }
        }

        internal static SortedSet<string> getCommonTags(ListView.SelectedListViewItemCollection items)
        {
            SortedSet<string> commonTags = new SortedSet<string>();

            int index = 0;
            for(; index < items.Count; index++)
            {
                bool isFile = items[index].Tag is FileInfo;

                if(isFile)
                {
                    FileInfo currentFile = items[index].Tag as FileInfo;
                    string filePath = currentFile.FullName;

                    commonTags = stringToSet(getAds(filePath));
                    ++index;
                    break;
                }
            }

            for(; index < items.Count; index++)
            {
                bool isFile = items[index].Tag is FileInfo;

                if (isFile)
                {
                    FileInfo currentFile = items[index].Tag as FileInfo;
                    string filePath = currentFile.FullName;

                    SortedSet<string> currentFileTags = stringToSet(getAds(filePath));
                    commonTags.IntersectWith(currentFileTags);
                }
            }

            return commonTags;
        }

        internal static bool containsTag(string filePath, string inputTag)
        {
            string tagString = getAds(filePath);
            tagString = inputTag + '|' + tagString;

            int[] z = z_function(tagString);
            
            for(int i = inputTag.Length + 1; i < z.Length; i++)
            {
                if (z[i] == inputTag.Length)
                    return true;
            }

            return false;
        }

        internal static int[] z_function(string tagString)
        {
            int n = tagString.Length;
            int[] z = new int[n];
            for(int i = 1; i < n; ++i)
                while (i + z[i] < n && tagString[z[i]] == tagString[i + z[i]])
                    ++z[i];
            return z;
        }

        internal static string getAds(string filePath)
        {
            filePath += ":tagifyTags";
            string adsTags = "";

            try
            {
                adsTags = File.ReadAllText(filePath);
            }
            catch(Exception e)
            {
                // exception when stream is not present or no read permission
            }

            return adsTags; 
        }

        internal static void setAds(string filePath, string inputAds)
        {
            if(File.Exists(filePath))
            {
                filePath += ":tagifyTags";

                try
                {
                    File.WriteAllText(filePath, inputAds);
                }
                catch(Exception ex)
                {
                    // exception for no write permission
                }
            }
        }

        internal static string tagsParse(string inputTags)
        {
            string parsedTags = "";
            for (int i = 0; i < inputTags.Length; i++)
            {
                parsedTags += inputTags[i];
                if(inputTags[i] == ',') parsedTags += " ";
            }

            return parsedTags;
        }

        internal static SortedSet<string> stringToSet(string inputTags)
        {
            SortedSet<string> uniqueTags = new SortedSet<string>();

            string[] tags = inputTags.Split(",");
            for (int i = 0; i < tags.Length; i++)
            {
                tags[i] = tags[i].Trim(' ').ToLower();
                if (tags[i] != "")
                    uniqueTags.Add(tags[i]);
            }

            return uniqueTags;
        }

        internal static string setToString(dynamic uniqueTags)
        {
            string stringifiedTags = "";

            foreach (string tag in uniqueTags)
            {
                if (tag != "")
                {
                    stringifiedTags += tag + ",";
                }
            }

            if(stringifiedTags.Length > 0)
                stringifiedTags = stringifiedTags.Substring(0, stringifiedTags.Length - 1);

            return stringifiedTags;
        }
    }
}
