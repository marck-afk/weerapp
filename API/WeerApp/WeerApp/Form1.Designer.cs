
namespace WeerApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.CbxPlaats = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLoadResults = new System.Windows.Forms.Button();
            this.RtbResults = new System.Windows.Forms.RichTextBox();
            this.CbxTemperatuur = new System.Windows.Forms.CheckBox();
            this.CbxNeerslag = new System.Windows.Forms.CheckBox();
            this.CbxWind = new System.Windows.Forms.CheckBox();
            this.CbxLucht = new System.Windows.Forms.CheckBox();
            this.CbxZon = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(8, 186);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(83, 37);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.SaveJson);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(96, 186);
            this.BtnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(82, 37);
            this.BtnLoad.TabIndex = 2;
            this.BtnLoad.Text = "Load";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.LoadJson);
            // 
            // CbxPlaats
            // 
            this.CbxPlaats.FormattingEnabled = true;
            this.CbxPlaats.Location = new System.Drawing.Point(52, 10);
            this.CbxPlaats.Margin = new System.Windows.Forms.Padding(2);
            this.CbxPlaats.Name = "CbxPlaats";
            this.CbxPlaats.Size = new System.Drawing.Size(128, 21);
            this.CbxPlaats.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plaats:";
            // 
            // BtnLoadResults
            // 
            this.BtnLoadResults.Location = new System.Drawing.Point(8, 144);
            this.BtnLoadResults.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLoadResults.Name = "BtnLoadResults";
            this.BtnLoadResults.Size = new System.Drawing.Size(170, 37);
            this.BtnLoadResults.TabIndex = 6;
            this.BtnLoadResults.Text = "Load results";
            this.BtnLoadResults.UseVisualStyleBackColor = true;
            this.BtnLoadResults.Click += new System.EventHandler(this.LoadResults);
            // 
            // RtbResults
            // 
            this.RtbResults.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RtbResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RtbResults.Location = new System.Drawing.Point(184, 10);
            this.RtbResults.Margin = new System.Windows.Forms.Padding(2);
            this.RtbResults.Name = "RtbResults";
            this.RtbResults.ReadOnly = true;
            this.RtbResults.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RtbResults.Size = new System.Drawing.Size(449, 214);
            this.RtbResults.TabIndex = 7;
            this.RtbResults.Text = "";
            // 
            // CbxTemperatuur
            // 
            this.CbxTemperatuur.AutoSize = true;
            this.CbxTemperatuur.Location = new System.Drawing.Point(8, 34);
            this.CbxTemperatuur.Margin = new System.Windows.Forms.Padding(2);
            this.CbxTemperatuur.Name = "CbxTemperatuur";
            this.CbxTemperatuur.Size = new System.Drawing.Size(86, 17);
            this.CbxTemperatuur.TabIndex = 8;
            this.CbxTemperatuur.Text = "Temperatuur";
            this.CbxTemperatuur.UseVisualStyleBackColor = true;
            // 
            // CbxNeerslag
            // 
            this.CbxNeerslag.AutoSize = true;
            this.CbxNeerslag.Location = new System.Drawing.Point(8, 56);
            this.CbxNeerslag.Margin = new System.Windows.Forms.Padding(2);
            this.CbxNeerslag.Name = "CbxNeerslag";
            this.CbxNeerslag.Size = new System.Drawing.Size(68, 17);
            this.CbxNeerslag.TabIndex = 9;
            this.CbxNeerslag.Text = "Neerslag";
            this.CbxNeerslag.UseVisualStyleBackColor = true;
            // 
            // CbxWind
            // 
            this.CbxWind.AutoSize = true;
            this.CbxWind.Location = new System.Drawing.Point(8, 78);
            this.CbxWind.Margin = new System.Windows.Forms.Padding(2);
            this.CbxWind.Name = "CbxWind";
            this.CbxWind.Size = new System.Drawing.Size(51, 17);
            this.CbxWind.TabIndex = 10;
            this.CbxWind.Text = "Wind";
            this.CbxWind.UseVisualStyleBackColor = true;
            // 
            // CbxLucht
            // 
            this.CbxLucht.AutoSize = true;
            this.CbxLucht.Location = new System.Drawing.Point(8, 100);
            this.CbxLucht.Margin = new System.Windows.Forms.Padding(2);
            this.CbxLucht.Name = "CbxLucht";
            this.CbxLucht.Size = new System.Drawing.Size(53, 17);
            this.CbxLucht.TabIndex = 11;
            this.CbxLucht.Text = "Lucht";
            this.CbxLucht.UseVisualStyleBackColor = true;
            // 
            // CbxZon
            // 
            this.CbxZon.AutoSize = true;
            this.CbxZon.Location = new System.Drawing.Point(8, 122);
            this.CbxZon.Margin = new System.Windows.Forms.Padding(2);
            this.CbxZon.Name = "CbxZon";
            this.CbxZon.Size = new System.Drawing.Size(45, 17);
            this.CbxZon.TabIndex = 12;
            this.CbxZon.Text = "Zon";
            this.CbxZon.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(644, 233);
            this.Controls.Add(this.CbxZon);
            this.Controls.Add(this.CbxLucht);
            this.Controls.Add(this.CbxWind);
            this.Controls.Add(this.CbxNeerslag);
            this.Controls.Add(this.CbxTemperatuur);
            this.Controls.Add(this.RtbResults);
            this.Controls.Add(this.BtnLoadResults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbxPlaats);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.BtnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Weer App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.ComboBox CbxPlaats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLoadResults;
        private System.Windows.Forms.RichTextBox RtbResults;
        private System.Windows.Forms.CheckBox CbxTemperatuur;
        private System.Windows.Forms.CheckBox CbxNeerslag;
        private System.Windows.Forms.CheckBox CbxWind;
        private System.Windows.Forms.CheckBox CbxLucht;
        private System.Windows.Forms.CheckBox CbxZon;
    }
}

