
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
            this.BtnSave.Location = new System.Drawing.Point(11, 229);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(111, 46);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.SaveJson);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(128, 229);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(110, 46);
            this.BtnLoad.TabIndex = 2;
            this.BtnLoad.Text = "Load";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.LoadJson);
            // 
            // CbxPlaats
            // 
            this.CbxPlaats.FormattingEnabled = true;
            this.CbxPlaats.Location = new System.Drawing.Point(69, 12);
            this.CbxPlaats.Name = "CbxPlaats";
            this.CbxPlaats.Size = new System.Drawing.Size(169, 24);
            this.CbxPlaats.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plaats:";
            // 
            // BtnLoadResults
            // 
            this.BtnLoadResults.Location = new System.Drawing.Point(11, 177);
            this.BtnLoadResults.Name = "BtnLoadResults";
            this.BtnLoadResults.Size = new System.Drawing.Size(227, 46);
            this.BtnLoadResults.TabIndex = 6;
            this.BtnLoadResults.Text = "Load results";
            this.BtnLoadResults.UseVisualStyleBackColor = true;
            this.BtnLoadResults.Click += new System.EventHandler(this.LoadResults);
            // 
            // RtbResults
            // 
            this.RtbResults.Location = new System.Drawing.Point(245, 12);
            this.RtbResults.Name = "RtbResults";
            this.RtbResults.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.RtbResults.Size = new System.Drawing.Size(420, 263);
            this.RtbResults.TabIndex = 7;
            this.RtbResults.Text = "";
            // 
            // CbxTemperatuur
            // 
            this.CbxTemperatuur.AutoSize = true;
            this.CbxTemperatuur.Location = new System.Drawing.Point(11, 42);
            this.CbxTemperatuur.Name = "CbxTemperatuur";
            this.CbxTemperatuur.Size = new System.Drawing.Size(112, 21);
            this.CbxTemperatuur.TabIndex = 8;
            this.CbxTemperatuur.Text = "Temperatuur";
            this.CbxTemperatuur.UseVisualStyleBackColor = true;
            // 
            // CbxNeerslag
            // 
            this.CbxNeerslag.AutoSize = true;
            this.CbxNeerslag.Location = new System.Drawing.Point(11, 69);
            this.CbxNeerslag.Name = "CbxNeerslag";
            this.CbxNeerslag.Size = new System.Drawing.Size(87, 21);
            this.CbxNeerslag.TabIndex = 9;
            this.CbxNeerslag.Text = "Neerslag";
            this.CbxNeerslag.UseVisualStyleBackColor = true;
            // 
            // CbxWind
            // 
            this.CbxWind.AutoSize = true;
            this.CbxWind.Location = new System.Drawing.Point(11, 96);
            this.CbxWind.Name = "CbxWind";
            this.CbxWind.Size = new System.Drawing.Size(62, 21);
            this.CbxWind.TabIndex = 10;
            this.CbxWind.Text = "Wind";
            this.CbxWind.UseVisualStyleBackColor = true;
            // 
            // CbxLucht
            // 
            this.CbxLucht.AutoSize = true;
            this.CbxLucht.Location = new System.Drawing.Point(11, 123);
            this.CbxLucht.Name = "CbxLucht";
            this.CbxLucht.Size = new System.Drawing.Size(65, 21);
            this.CbxLucht.TabIndex = 11;
            this.CbxLucht.Text = "Lucht";
            this.CbxLucht.UseVisualStyleBackColor = true;
            // 
            // CbxZon
            // 
            this.CbxZon.AutoSize = true;
            this.CbxZon.Location = new System.Drawing.Point(11, 150);
            this.CbxZon.Name = "CbxZon";
            this.CbxZon.Size = new System.Drawing.Size(55, 21);
            this.CbxZon.TabIndex = 12;
            this.CbxZon.Text = "Zon";
            this.CbxZon.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 287);
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

