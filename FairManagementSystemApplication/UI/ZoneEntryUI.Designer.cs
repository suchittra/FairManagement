namespace FairManagementSystemApplication.UI
{
    partial class ZoneEntryUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxZoneName = new System.Windows.Forms.TextBox();
            this.buttonSaveZone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewZone = new System.Windows.Forms.ListView();
            this.zoneType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxZoneName);
            this.groupBox1.Controls.Add(this.buttonSaveZone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zone Type";
            // 
            // textBoxZoneName
            // 
            this.textBoxZoneName.Location = new System.Drawing.Point(109, 39);
            this.textBoxZoneName.Name = "textBoxZoneName";
            this.textBoxZoneName.Size = new System.Drawing.Size(182, 20);
            this.textBoxZoneName.TabIndex = 3;
            // 
            // buttonSaveZone
            // 
            this.buttonSaveZone.Location = new System.Drawing.Point(153, 77);
            this.buttonSaveZone.Name = "buttonSaveZone";
            this.buttonSaveZone.Size = new System.Drawing.Size(138, 22);
            this.buttonSaveZone.TabIndex = 2;
            this.buttonSaveZone.Text = "Save";
            this.buttonSaveZone.UseVisualStyleBackColor = true;
            this.buttonSaveZone.Click += new System.EventHandler(this.buttonSaveZone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type Name";
            // 
            // listViewZone
            // 
            this.listViewZone.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.zoneType});
            this.listViewZone.Location = new System.Drawing.Point(12, 161);
            this.listViewZone.Name = "listViewZone";
            this.listViewZone.Size = new System.Drawing.Size(322, 155);
            this.listViewZone.TabIndex = 1;
            this.listViewZone.UseCompatibleStateImageBehavior = false;
            this.listViewZone.View = System.Windows.Forms.View.Details;
            // 
            // zoneType
            // 
            this.zoneType.Text = "Zone Type";
            this.zoneType.Width = 300;
            // 
            // ZoneEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 328);
            this.Controls.Add(this.listViewZone);
            this.Controls.Add(this.groupBox1);
            this.Name = "ZoneEntryUI";
            this.Text = "Zone Type Entry";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSaveZone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxZoneName;
        private System.Windows.Forms.ListView listViewZone;
        private System.Windows.Forms.ColumnHeader zoneType;
    }
}