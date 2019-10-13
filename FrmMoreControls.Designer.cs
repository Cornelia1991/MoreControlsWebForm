namespace MoreControls
{
    partial class FrmMoreControls
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.HsbNumber = new System.Windows.Forms.HScrollBar();
            this.MnuColors = new System.Windows.Forms.MenuStrip();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSecondForm = new System.Windows.Forms.Button();
            this.MnuColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtNumber
            // 
            this.TxtNumber.Location = new System.Drawing.Point(524, 370);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(226, 22);
            this.TxtNumber.TabIndex = 0;
            // 
            // HsbNumber
            // 
            this.HsbNumber.LargeChange = 1;
            this.HsbNumber.Location = new System.Drawing.Point(44, 361);
            this.HsbNumber.Maximum = 50;
            this.HsbNumber.Name = "HsbNumber";
            this.HsbNumber.Size = new System.Drawing.Size(311, 43);
            this.HsbNumber.TabIndex = 1;
            this.HsbNumber.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HsbNumber_Scroll);
            // 
            // MnuColors
            // 
            this.MnuColors.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MnuColors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorsToolStripMenuItem});
            this.MnuColors.Location = new System.Drawing.Point(0, 0);
            this.MnuColors.Name = "MnuColors";
            this.MnuColors.Size = new System.Drawing.Size(800, 28);
            this.MnuColors.TabIndex = 2;
            this.MnuColors.Text = "menuStrip1";
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.colorsToolStripMenuItem.Text = "Colors";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.RedToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.GreenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.BlueToolStripMenuItem_Click);
            // 
            // BtnSecondForm
            // 
            this.BtnSecondForm.Location = new System.Drawing.Point(327, 228);
            this.BtnSecondForm.Name = "BtnSecondForm";
            this.BtnSecondForm.Size = new System.Drawing.Size(200, 45);
            this.BtnSecondForm.TabIndex = 3;
            this.BtnSecondForm.Text = "Go To 2nd Form";
            this.BtnSecondForm.UseVisualStyleBackColor = true;
            this.BtnSecondForm.Click += new System.EventHandler(this.BtnSecondForm_Click);
            // 
            // FrmMoreControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSecondForm);
            this.Controls.Add(this.HsbNumber);
            this.Controls.Add(this.TxtNumber);
            this.Controls.Add(this.MnuColors);
            this.MainMenuStrip = this.MnuColors;
            this.Name = "FrmMoreControls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "More Controls";
            this.MnuColors.ResumeLayout(false);
            this.MnuColors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNumber;
        private System.Windows.Forms.HScrollBar HsbNumber;
        private System.Windows.Forms.MenuStrip MnuColors;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.Button BtnSecondForm;
    }
}

