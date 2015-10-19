namespace Football.Client
{
    partial class FootballManagerClient
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.CreateSqlServerDb = new System.Windows.Forms.Button();
            this.GetMongoData = new System.Windows.Forms.Button();
            this.FillDatFromZip = new System.Windows.Forms.Button();
            this.FillFromXml_btn = new System.Windows.Forms.Button();
            this.CreateMySqlDb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateSqlServerDb
            // 
            this.CreateSqlServerDb.Location = new System.Drawing.Point(79, 45);
            this.CreateSqlServerDb.Name = "CreateSqlServerDb";
            this.CreateSqlServerDb.Size = new System.Drawing.Size(132, 23);
            this.CreateSqlServerDb.TabIndex = 0;
            this.CreateSqlServerDb.Text = "Create SQL Server DB";
            this.CreateSqlServerDb.UseVisualStyleBackColor = true;
            this.CreateSqlServerDb.Click += new System.EventHandler(this.CreateSqlServerDb_Click);
            // 
            // GetMongoData
            // 
            this.GetMongoData.Location = new System.Drawing.Point(79, 89);
            this.GetMongoData.Name = "GetMongoData";
            this.GetMongoData.Size = new System.Drawing.Size(132, 23);
            this.GetMongoData.TabIndex = 1;
            this.GetMongoData.Text = "Fill Data From MongoDB";
            this.GetMongoData.UseVisualStyleBackColor = true;
            this.GetMongoData.Click += new System.EventHandler(this.GetMongoData_Click);
            // 
            // FillDatFromZip
            // 
            this.FillDatFromZip.Location = new System.Drawing.Point(79, 132);
            this.FillDatFromZip.Name = "FillDatFromZip";
            this.FillDatFromZip.Size = new System.Drawing.Size(132, 23);
            this.FillDatFromZip.TabIndex = 2;
            this.FillDatFromZip.Text = "Fill Data from Zip";
            this.FillDatFromZip.UseVisualStyleBackColor = true;
            this.FillDatFromZip.Click += new System.EventHandler(this.FillDatFromZip_Click);
            // 
            // FillFromXml_btn
            // 
            this.FillFromXml_btn.Location = new System.Drawing.Point(79, 180);
            this.FillFromXml_btn.Name = "FillFromXml_btn";
            this.FillFromXml_btn.Size = new System.Drawing.Size(132, 23);
            this.FillFromXml_btn.TabIndex = 3;
            this.FillFromXml_btn.Text = "Fill Data from Xml ";
            this.FillFromXml_btn.UseVisualStyleBackColor = true;
            this.FillFromXml_btn.Click += new System.EventHandler(this.FillFromXml_btn_Click);
            // 
            // CreateMySqlDb
            // 
            this.CreateMySqlDb.Location = new System.Drawing.Point(79, 242);
            this.CreateMySqlDb.Name = "CreateMySqlDb";
            this.CreateMySqlDb.Size = new System.Drawing.Size(132, 23);
            this.CreateMySqlDb.TabIndex = 4;
            this.CreateMySqlDb.Text = "Create MySql Db";
            this.CreateMySqlDb.UseVisualStyleBackColor = true;
            this.CreateMySqlDb.Click += new System.EventHandler(this.CreateMySqlDb_Click);
            // 
            // FootballManagerClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 312);
            this.Controls.Add(this.CreateMySqlDb);
            this.Controls.Add(this.FillFromXml_btn);
            this.Controls.Add(this.FillDatFromZip);
            this.Controls.Add(this.GetMongoData);
            this.Controls.Add(this.CreateSqlServerDb);
            this.Name = "FootballManagerClient";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateSqlServerDb;
        private System.Windows.Forms.Button GetMongoData;
        private System.Windows.Forms.Button FillDatFromZip;
        private System.Windows.Forms.Button FillFromXml_btn;
        private System.Windows.Forms.Button CreateMySqlDb;
    }
}