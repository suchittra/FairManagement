namespace FairManagementSystemApplication.UI
{
    partial class ZoneSpecificVisitorInformation
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
            this.comboBoxZoneName = new System.Windows.Forms.ComboBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.buttonExportExcel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewZoneSpecificCustomer = new System.Windows.Forms.ListView();
            this.customerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contactNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // comboBoxZoneName
            // 
            this.comboBoxZoneName.FormattingEnabled = true;
            this.comboBoxZoneName.Location = new System.Drawing.Point(107, 39);
            this.comboBoxZoneName.Name = "comboBoxZoneName";
            this.comboBoxZoneName.Size = new System.Drawing.Size(190, 21);
            this.comboBoxZoneName.TabIndex = 0;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(329, 39);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 1;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Zone";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(303, 367);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotal.TabIndex = 4;
            // 
            // buttonExportExcel
            // 
            this.buttonExportExcel.Location = new System.Drawing.Point(209, 407);
            this.buttonExportExcel.Name = "buttonExportExcel";
            this.buttonExportExcel.Size = new System.Drawing.Size(194, 23);
            this.buttonExportExcel.TabIndex = 5;
            this.buttonExportExcel.Text = "Export To Excel";
            this.buttonExportExcel.UseVisualStyleBackColor = true;
            this.buttonExportExcel.Click += new System.EventHandler(this.buttonExportExcel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total";
            // 
            // listViewZoneSpecificCustomer
            // 
            this.listViewZoneSpecificCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.customerName,
            this.email,
            this.contactNumber});
            this.listViewZoneSpecificCustomer.Location = new System.Drawing.Point(12, 84);
            this.listViewZoneSpecificCustomer.Name = "listViewZoneSpecificCustomer";
            this.listViewZoneSpecificCustomer.Size = new System.Drawing.Size(392, 252);
            this.listViewZoneSpecificCustomer.TabIndex = 7;
            this.listViewZoneSpecificCustomer.UseCompatibleStateImageBehavior = false;
            this.listViewZoneSpecificCustomer.View = System.Windows.Forms.View.Details;
            // 
            // customerName
            // 
            this.customerName.Text = "Visitor Name";
            this.customerName.Width = 131;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 133;
            // 
            // contactNumber
            // 
            this.contactNumber.Text = "Contact Number";
            this.contactNumber.Width = 121;
            // 
            // ZoneSpecificVisitorInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 442);
            this.Controls.Add(this.listViewZoneSpecificCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonExportExcel);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.comboBoxZoneName);
            this.Name = "ZoneSpecificVisitorInformation";
            this.Text = "ZoneSpecificVisitorInformation";
            this.Load += new System.EventHandler(this.ZoneSpecificVisitorInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxZoneName;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button buttonExportExcel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewZoneSpecificCustomer;
        private System.Windows.Forms.ColumnHeader customerName;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader contactNumber;
    }
}