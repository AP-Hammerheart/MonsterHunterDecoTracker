namespace MonsterHunterDecoTracker {
    partial class Decoration {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing ) {
            if(disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.DecoName = new System.Windows.Forms.Label();
            this.SkillName = new System.Windows.Forms.Label();
            this.MaxLevel0 = new System.Windows.Forms.Label();
            this.MaxLevel1 = new System.Windows.Forms.Label();
            this.DecreaseButton = new System.Windows.Forms.Button();
            this.IncreaseButton = new System.Windows.Forms.Button();
            this.InventoryAmountNUP = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryAmountNUP)).BeginInit();
            this.SuspendLayout();
            // 
            // DecoName
            // 
            this.DecoName.AutoSize = true;
            this.DecoName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecoName.Location = new System.Drawing.Point(3, 3);
            this.DecoName.Name = "DecoName";
            this.DecoName.Size = new System.Drawing.Size(137, 16);
            this.DecoName.TabIndex = 0;
            this.DecoName.Text = "Heavy Artillery Jewel 1";
            // 
            // SkillName
            // 
            this.SkillName.AutoSize = true;
            this.SkillName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkillName.Location = new System.Drawing.Point(155, 3);
            this.SkillName.Name = "SkillName";
            this.SkillName.Size = new System.Drawing.Size(140, 16);
            this.SkillName.TabIndex = 1;
            this.SkillName.Text = "Paralysis Functionality";
            // 
            // MaxLevel0
            // 
            this.MaxLevel0.AutoSize = true;
            this.MaxLevel0.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxLevel0.Location = new System.Drawing.Point(313, 3);
            this.MaxLevel0.Name = "MaxLevel0";
            this.MaxLevel0.Size = new System.Drawing.Size(66, 16);
            this.MaxLevel0.TabIndex = 2;
            this.MaxLevel0.Text = "Max Level";
            // 
            // MaxLevel1
            // 
            this.MaxLevel1.AutoSize = true;
            this.MaxLevel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxLevel1.Location = new System.Drawing.Point(376, 3);
            this.MaxLevel1.Name = "MaxLevel1";
            this.MaxLevel1.Size = new System.Drawing.Size(15, 16);
            this.MaxLevel1.TabIndex = 3;
            this.MaxLevel1.Text = "1";
            // 
            // DecreaseButton
            // 
            this.DecreaseButton.Location = new System.Drawing.Point(398, 1);
            this.DecreaseButton.Name = "DecreaseButton";
            this.DecreaseButton.Size = new System.Drawing.Size(20, 20);
            this.DecreaseButton.TabIndex = 4;
            this.DecreaseButton.Text = "-";
            this.DecreaseButton.UseVisualStyleBackColor = true;
            this.DecreaseButton.Click += new System.EventHandler(this.DecreaseButton_Click);
            // 
            // IncreaseButton
            // 
            this.IncreaseButton.Location = new System.Drawing.Point(466, 1);
            this.IncreaseButton.Name = "IncreaseButton";
            this.IncreaseButton.Size = new System.Drawing.Size(20, 20);
            this.IncreaseButton.TabIndex = 5;
            this.IncreaseButton.Text = "+";
            this.IncreaseButton.UseVisualStyleBackColor = true;
            this.IncreaseButton.Click += new System.EventHandler(this.IncreaseButton_Click);
            // 
            // InventoryAmountNUP
            // 
            this.InventoryAmountNUP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryAmountNUP.InterceptArrowKeys = false;
            this.InventoryAmountNUP.Location = new System.Drawing.Point(418, 1);
            this.InventoryAmountNUP.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.InventoryAmountNUP.Name = "InventoryAmountNUP";
            this.InventoryAmountNUP.Size = new System.Drawing.Size(48, 20);
            this.InventoryAmountNUP.TabIndex = 8;
            this.InventoryAmountNUP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.InventoryAmountNUP.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.InventoryAmountNUP.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.InventoryAmountNUP.ValueChanged += new System.EventHandler(this.InventoryAmount_ValueChanged);
            // 
            // Decoration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.IncreaseButton);
            this.Controls.Add(this.InventoryAmountNUP);
            this.Controls.Add(this.DecreaseButton);
            this.Controls.Add(this.MaxLevel1);
            this.Controls.Add(this.MaxLevel0);
            this.Controls.Add(this.SkillName);
            this.Controls.Add(this.DecoName);
            this.Name = "Decoration";
            this.Size = new System.Drawing.Size(493, 22);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryAmountNUP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DecoName;
        private System.Windows.Forms.Label SkillName;
        private System.Windows.Forms.Label MaxLevel0;
        private System.Windows.Forms.Label MaxLevel1;
        private System.Windows.Forms.Button DecreaseButton;
        private System.Windows.Forms.Button IncreaseButton;
        private System.Windows.Forms.NumericUpDown InventoryAmountNUP;
    }
}
