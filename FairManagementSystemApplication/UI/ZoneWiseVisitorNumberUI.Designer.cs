namespace FairManagementSystemApplication.UI
{
    partial class ZoneWiseVisitorNumberUI
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
            this.textBoxTotalAll = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewCustonerByZone = new System.Windows.Forms.ListView();
            this.zoneName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numberVisitor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textBoxTotalAll
            // 
            this.textBoxTotalAll.Location = new System.Drawing.Point(325, 237);
            this.textBoxTotalAll.Name = "textBoxTotalAll";
            this.textBoxTotalAll.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalAll.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total";
            // 
            // listViewCustonerByZone
            // 
            this.listViewCustonerByZone.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.zoneName,
            this.numberVisitor});
            this.listViewCustonerByZone.Location = new System.Drawing.Point(12, 35);
            this.listViewCustonerByZone.Name = "listViewCustonerByZone";
            this.listViewCustonerByZone.Size = new System.Drawing.Size(423, 184);
            this.listViewCustonerByZone.TabIndex = 3;
            this.listViewCustonerByZone.UseCompatibleStateImageBehavior = false;
            this.listViewCustonerByZone.View = System.Windows.Forms.View.Details;
            // 
            // zoneName
            // 
            this.zoneName.Text = "Zone";
            this.zoneName.Width = 201;
            // 
            // numberVisitor
            // 
            this.numberVisitor.Text = "Number of Visitor";
            this.numberVisitor.Width = 221;
            // 
            // ZoneWiseVisitorNumberUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 278);
            this.Controls.Add(this.listViewCustonerByZone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTotalAll);
            this.Name = "ZoneWiseVisitorNumberUI";
            this.Text = "Zone Wise Visitor Number UI";
            this.Load += new System.EventHandler(this.ZoneWiseVisitorNumberUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTotalAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewCustonerByZone;
        private System.Windows.Forms.ColumnHeader zoneName;
        private System.Windows.Forms.ColumnHeader numberVisitor;
    }
}