using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections;

namespace renameExtension
{
    public class Controler
    {
        public string[] FilesInDirectory(string path) {
            return Directory.GetFiles(path);
        }

        public string InsertDotInExtension(string extension) {
            if (!extension.StartsWith("."))
                extension = "." + extension;
            
            return extension;
        }

        public string ChangeExtension(string fileName ,string oldExtension, string newExtension) {
            fileName = fileName.Replace(oldExtension, newExtension);
            return fileName;
        }

        public void CreateFile(string path) {
            File.Create(path).Dispose();
            File.Create(path+".txt").Dispose();
        }

        public void InsertFilesSelectedInList(string[] files, ListBox list, Label label)
        {
            list.Items.Clear();

            foreach (string file in files)
            {
                string fileName = file.Substring(file.LastIndexOf("\\"));
                list.Items.Add(fileName);
            }
            label.Text = "Count: " + list.Items.Count;
        }

        public void ChangeContent(string path, string oldExtension, string newExtension, bool restriction) {
            ArrayList allText = ReadFile(path);

            for (int i = 0; i < allText.Count; i++)
                if(restriction)
                    while (allText[i].ToString().Contains(oldExtension))
                        allText[i] = allText[i].ToString().Replace(oldExtension, newExtension);
                else
                    while(allText[i].ToString().Contains("<a") && allText[i].ToString().Contains(oldExtension))
                        allText[i] = allText[i].ToString().Replace(oldExtension, newExtension);


            RedraftFile(path, allText);
        }

        private void RedraftFile(string path, ArrayList allText) {
            StreamWriter writer = new StreamWriter(path, false, Encoding.Default);

            for (int i = 0; i < allText.Count; i++)
                writer.WriteLine(allText[i].ToString());

            writer.Close();
        }
        
        private ArrayList ReadFile(string path) {
            ArrayList allText = new ArrayList();
            StreamReader reader = new StreamReader(path, Encoding.Default);
            
            while (!reader.EndOfStream)
                allText.Add(reader.ReadLine());
            
            reader.Close();
            return allText;
        }
    }
}
