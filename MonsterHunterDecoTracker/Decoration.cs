using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MonsterHunterDecoTracker {
    public partial class Decoration : UserControl {

        public int index = 0;

        public event EventHandler ValueChanged;

        public string SetDecoName {
            set {
                DecoName.Text = value;
            }
        }

        public string SetSkillName {
            set {
                SkillName.Text = value;
            }
        }

        public string SetMaxLevel1 {
            set {
                MaxLevel1.Text = value;
            }
        }

        public int InventoryAmount {
            get {
                return (int)InventoryAmountNUP.Value;
            }
            set {
                InventoryAmountNUP.Value = value;
            }
        }

        public Decoration () {
            InitializeComponent();
            this.InventoryAmountNUP.Controls[0].Visible = false;
        }

        private void IncreaseButton_Click ( object sender, EventArgs e ) {
            decimal d = this.InventoryAmountNUP.Value;
            d++;
            if(d > this.InventoryAmountNUP.Maximum) {
                d = this.InventoryAmountNUP.Maximum;
            }
            this.InventoryAmountNUP.Value = d;
        }

        private void DecreaseButton_Click ( object sender, EventArgs e ) {
            decimal d = this.InventoryAmountNUP.Value;
            d--;
            if(d < this.InventoryAmountNUP.Minimum) {
                d = this.InventoryAmountNUP.Minimum;
            }
            this.InventoryAmountNUP.Value = d;
        }

        private void InventoryAmount_ValueChanged ( object sender, EventArgs e ) {
            if(this.ValueChanged != null) {
                this.ValueChanged(this, e);
            }
        }
    }
}
