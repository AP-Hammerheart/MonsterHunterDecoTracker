using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MonsterHunterDecoTracker {
    class DecoList {

        List<ListItem> list = new List<ListItem>();
        string filePath = @"MHWDecoList\DecoList.csv";
        string backup = @"MHWDecoList\DecoList " + DateTime.Now.ToString("yyyy.MM.dd_HH.mm.ss") + ".csv";

        public List<ListItem> DecorationList {
            get {
                return list;
            }
        }

        public DecoList () {
            if(File.Exists(filePath)) {
                ReadFile(filePath);
            } else {
                FileInfo f = new FileInfo(filePath);
                f.Directory.Create();
                using(StreamWriter writer = new StreamWriter(filePath, false)) {
                    writer.Write(FileFormat.fileContent);
                    writer.Close();
                }
                ReadFile(filePath);
            }
        }

        void ReadFile ( string filePath ) {
            using(StreamReader reader = new StreamReader(filePath)) {
                string f = reader.ReadToEnd();
                string[] rowSplit = f.Split('\n');
                for(int i = 0; i < rowSplit.Length - 1; i++) {
                    string[] semiColonSplit = rowSplit[i].Split(';');
                    int i0 = int.Parse(semiColonSplit[2]);
                    int i1 = int.Parse(semiColonSplit[3]);
                    ListItem l = new ListItem(semiColonSplit[0], semiColonSplit[1], i0, i1);
                    list.Add(l);
                }
                reader.Close();
            }
        }

        string CreateSaveFileString () {
            string save = string.Empty;
            foreach(ListItem l in list) {
                save += l.DecoName + ";" + l.SkillName + ";" + l.SkillMaxLevel.ToString() + ";" + l.InventoryAmount.ToString() + "\n";
            }
            return save;
        }

        public void SaveFile () {
            string save = CreateSaveFileString();
            using(StreamWriter writer = new StreamWriter(filePath, false)) {
                writer.Write(save);
                writer.Close();
            }
        }

        public void SaveBackUp () {
            string save = CreateSaveFileString();
            using(StreamWriter writer = new StreamWriter(backup, false)) {
                writer.Write(save);
                writer.Close();
            }
        }


    }
}
