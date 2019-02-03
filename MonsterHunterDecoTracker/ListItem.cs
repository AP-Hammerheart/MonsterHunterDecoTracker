using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonsterHunterDecoTracker {
    class ListItem {
        string decoName;
        string skillName;
        int skillMaxLevel;
        int inventoryAmount;

        public string DecoName {
            get {
                return decoName;
            }
        }

        public string SkillName {
            get {
                return skillName;
            }
        }

        public int SkillMaxLevel {
            get {
                return skillMaxLevel;
            }
        }

        public int InventoryAmount {
            get {
                return inventoryAmount;
            } set {
                if(value < 0) {
                    inventoryAmount = 0;
                } else if(inventoryAmount > 9999) {
                    inventoryAmount = 9999;
                } else {
                    inventoryAmount = value;
                }
            }
        }

        public ListItem () {
            decoName = "Jewel";
            skillName = "None";
            skillMaxLevel = 1;
            inventoryAmount = 0;
        }

        public ListItem ( string decoName, string skillName, int skillMaxLevel, int inventoryAmount ) {
            this.decoName = decoName;
            this.skillName = skillName;
            this.skillMaxLevel = skillMaxLevel;
            this.inventoryAmount = inventoryAmount;
        }

        public void IncreaseInventoryAmmount () {
            inventoryAmount++;
            if(inventoryAmount < 0) {
                inventoryAmount = 0;
            }
        }

        public void DecreaseInventoryAmmount () {
            inventoryAmount--;
            if(inventoryAmount < 0) {
                inventoryAmount = 0;
            }
        }
    }
}
