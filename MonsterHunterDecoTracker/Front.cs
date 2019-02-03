using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace MonsterHunterDecoTracker {
    public partial class Form1 : Form {
        DecoList decoList = new DecoList();

        public Form1 () {
            InitializeComponent();
            int i = 0;
            foreach(ListItem l in decoList.DecorationList) {
                Decoration d = new Decoration {
                    index = i,
                    SetDecoName = l.DecoName,
                    SetSkillName = l.SkillName,
                    SetMaxLevel1 = l.SkillMaxLevel.ToString(),
                    InventoryAmount = l.InventoryAmount,
                };
                d.ValueChanged += new EventHandler(ValueChanged);
                DecolistFlowPanel.Controls.Add(d);
                i++;
            }
            decoList.SaveBackUp();
        }

        private void ValueChanged ( object sender, EventArgs e ) {
            Decoration d = sender as Decoration;
            decoList.DecorationList[d.index].InventoryAmount = d.InventoryAmount;
            SaveChanges();
        }

        void SaveChanges () {
            decoList.SaveFile();
        }

        protected override void OnFormClosing ( FormClosingEventArgs e ) {
            base.OnFormClosing(e);
            SaveChanges();
        }
    }
}
