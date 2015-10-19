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
            this.GeneratePdfReport_btn = new System.Windows.Forms.Button();
            this.GenerateXmlReport_btn = new System.Windows.Forms.Button();
            this.GenerateJsonReport_btn = new System.Windows.Forms.Button();
            this.ExcelReportForTeams = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // CreateSqlServerDb
            // 
            this.CreateSqlServerDb.BackColor = System.Drawing.Color.Azure;
            this.CreateSqlServerDb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateSqlServerDb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateSqlServerDb.Location = new System.Drawing.Point(74, 76);
            this.CreateSqlServerDb.Name = "CreateSqlServerDb";
            this.CreateSqlServerDb.Size = new System.Drawing.Size(163, 29);
            this.CreateSqlServerDb.TabIndex = 0;
            this.CreateSqlServerDb.Text = "Create SQL Server DB";
            this.CreateSqlServerDb.UseVisualStyleBackColor = false;
            this.CreateSqlServerDb.Click += new System.EventHandler(this.CreateSqlServerDb_Click);
            // 
            // GetMongoData
            // 
            this.GetMongoData.BackColor = System.Drawing.Color.Azure;
            this.GetMongoData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetMongoData.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetMongoData.Location = new System.Drawing.Point(74, 120);
            this.GetMongoData.Name = "GetMongoData";
            this.GetMongoData.Size = new System.Drawing.Size(163, 29);
            this.GetMongoData.TabIndex = 1;
            this.GetMongoData.Text = "Fill Data From MongoDB";
            this.GetMongoData.UseVisualStyleBackColor = false;
            this.GetMongoData.Click += new System.EventHandler(this.GetMongoData_Click);
            // 
            // FillDatFromZip
            // 
            this.FillDatFromZip.BackColor = System.Drawing.Color.Azure;
            this.FillDatFromZip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FillDatFromZip.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FillDatFromZip.Location = new System.Drawing.Point(74, 164);
            this.FillDatFromZip.Name = "FillDatFromZip";
            this.FillDatFromZip.Size = new System.Drawing.Size(163, 29);
            this.FillDatFromZip.TabIndex = 2;
            this.FillDatFromZip.Text = "Fill Data from Zip";
            this.FillDatFromZip.UseVisualStyleBackColor = false;
            this.FillDatFromZip.Click += new System.EventHandler(this.FillDatFromZip_Click);
            // 
            // FillFromXml_btn
            // 
            this.FillFromXml_btn.BackColor = System.Drawing.Color.Azure;
            this.FillFromXml_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FillFromXml_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FillFromXml_btn.Location = new System.Drawing.Point(74, 208);
            this.FillFromXml_btn.Name = "FillFromXml_btn";
            this.FillFromXml_btn.Size = new System.Drawing.Size(163, 29);
            this.FillFromXml_btn.TabIndex = 3;
            this.FillFromXml_btn.Text = "Fill Data from Xml ";
            this.FillFromXml_btn.UseVisualStyleBackColor = false;
            this.FillFromXml_btn.Click += new System.EventHandler(this.FillFromXml_btn_Click);
            // 
            // CreateMySqlDb
            // 
            this.CreateMySqlDb.BackColor = System.Drawing.Color.Azure;
            this.CreateMySqlDb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateMySqlDb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateMySqlDb.Location = new System.Drawing.Point(74, 383);
            this.CreateMySqlDb.Name = "CreateMySqlDb";
            this.CreateMySqlDb.Size = new System.Drawing.Size(163, 29);
            this.CreateMySqlDb.TabIndex = 7;
            this.CreateMySqlDb.Text = "Create MySql Db";
            this.CreateMySqlDb.UseVisualStyleBackColor = false;
            this.CreateMySqlDb.Click += new System.EventHandler(this.CreateMySqlDb_Click);
            // 
            // GeneratePdfReport_btn
            // 
            this.GeneratePdfReport_btn.BackColor = System.Drawing.Color.Azure;
            this.GeneratePdfReport_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GeneratePdfReport_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GeneratePdfReport_btn.Location = new System.Drawing.Point(74, 252);
            this.GeneratePdfReport_btn.Name = "GeneratePdfReport_btn";
            this.GeneratePdfReport_btn.Size = new System.Drawing.Size(163, 29);
            this.GeneratePdfReport_btn.TabIndex = 4;
            this.GeneratePdfReport_btn.Text = "Generate Pdf report";
            this.GeneratePdfReport_btn.UseVisualStyleBackColor = false;
            this.GeneratePdfReport_btn.Click += new System.EventHandler(this.GeneratePdfReport_btn_Click);
            // 
            // GenerateXmlReport_btn
            // 
            this.GenerateXmlReport_btn.BackColor = System.Drawing.Color.Azure;
            this.GenerateXmlReport_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerateXmlReport_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateXmlReport_btn.Location = new System.Drawing.Point(74, 340);
            this.GenerateXmlReport_btn.Name = "GenerateXmlReport_btn";
            this.GenerateXmlReport_btn.Size = new System.Drawing.Size(163, 29);
            this.GenerateXmlReport_btn.TabIndex = 6;
            this.GenerateXmlReport_btn.Text = "Generate Xml report";
            this.GenerateXmlReport_btn.UseVisualStyleBackColor = false;
            this.GenerateXmlReport_btn.Click += new System.EventHandler(this.GenerateXmlReport_btn_Click);
            // 
            // GenerateJsonReport_btn
            // 
            this.GenerateJsonReport_btn.BackColor = System.Drawing.Color.Azure;
            this.GenerateJsonReport_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerateJsonReport_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerateJsonReport_btn.Location = new System.Drawing.Point(74, 296);
            this.GenerateJsonReport_btn.Name = "GenerateJsonReport_btn";
            this.GenerateJsonReport_btn.Size = new System.Drawing.Size(163, 29);
            this.GenerateJsonReport_btn.TabIndex = 5;
            this.GenerateJsonReport_btn.Text = "Generate Json report";
            this.GenerateJsonReport_btn.UseVisualStyleBackColor = false;
            this.GenerateJsonReport_btn.Click += new System.EventHandler(this.GenerateJsonReport_btn_Click);
            // 
            // ExcelReportForTeams
            // 
            this.ExcelReportForTeams.BackColor = System.Drawing.Color.Azure;
            this.ExcelReportForTeams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExcelReportForTeams.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExcelReportForTeams.Location = new System.Drawing.Point(74, 427);
            this.ExcelReportForTeams.Name = "ExcelReportForTeams";
            this.ExcelReportForTeams.Size = new System.Drawing.Size(163, 29);
            this.ExcelReportForTeams.TabIndex = 8;
            this.ExcelReportForTeams.Text = "Excel Report for Teams";
            this.ExcelReportForTeams.UseVisualStyleBackColor = false;
            this.ExcelReportForTeams.Click += new System.EventHandler(this.ExcelReportForTeams_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(14, 30);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(303, 23);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Football Manager -Team \"Selenium\"";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FootballManagerClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(318, 509);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ExcelReportForTeams);
            this.Controls.Add(this.CreateMySqlDb);
            this.Controls.Add(this.GenerateJsonReport_btn);
            this.Controls.Add(this.GenerateXmlReport_btn);
            this.Controls.Add(this.GeneratePdfReport_btn);
            this.Controls.Add(this.FillFromXml_btn);
            this.Controls.Add(this.FillDatFromZip);
            this.Controls.Add(this.GetMongoData);
            this.Controls.Add(this.CreateSqlServerDb);
            this.Name = "FootballManagerClient";
            this.Text = "Football Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateSqlServerDb;
        private System.Windows.Forms.Button GetMongoData;
        private System.Windows.Forms.Button FillDatFromZip;
        private System.Windows.Forms.Button FillFromXml_btn;

        private System.Windows.Forms.Button CreateMySqlDb;

        private System.Windows.Forms.Button GeneratePdfReport_btn;
        private System.Windows.Forms.Button GenerateXmlReport_btn;
        private System.Windows.Forms.Button GenerateJsonReport_btn;
        private System.Windows.Forms.Button ExcelReportForTeams;
        private System.Windows.Forms.LinkLabel linkLabel1;

    }
}