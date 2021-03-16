
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
            this.ClbData = new System.Windows.Forms.CheckedListBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.CbxPlaats = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLoadResults = new System.Windows.Forms.Button();
            this.RtbResults = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ClbData
            // 
            this.ClbData.FormattingEnabled = true;
            this.ClbData.Items.AddRange(new object[] {
            "Temparatuur",
            "Neerslag",
            "Wind",
            "Lucht",
            "Zon"});
            this.ClbData.Location = new System.Drawing.Point(13, 42);
            this.ClbData.Name = "ClbData";
            this.ClbData.Size = new System.Drawing.Size(226, 106);
            this.ClbData.TabIndex = 0;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(12, 206);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(110, 46);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.SaveJson);
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(128, 206);
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
            this.BtnLoadResults.Location = new System.Drawing.Point(11, 154);
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
            this.RtbResults.Size = new System.Drawing.Size(303, 240);
            this.RtbResults.TabIndex = 7;
            this.RtbResults.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 264);
            this.Controls.Add(this.RtbResults);
            this.Controls.Add(this.BtnLoadResults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbxPlaats);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.ClbData);
            this.Name = "Form1";
            this.Text = "Weer App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ClbData;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.ComboBox CbxPlaats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLoadResults;
        private System.Windows.Forms.RichTextBox RtbResults;
    }
}

