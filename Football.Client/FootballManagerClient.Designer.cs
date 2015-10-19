namespace Football.Client
{
    public partial class FootballManagerClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button createSqlServerDb;
        private System.Windows.Forms.Button getMongoData;
        private System.Windows.Forms.Button fillDatFromZip;
        private System.Windows.Forms.Button fillFromXmlBtn;

        private System.Windows.Forms.Button createMySqlDb;

        private System.Windows.Forms.Button generatePdfReportBtn;
        private System.Windows.Forms.Button generateXmlReportBtn;
        private System.Windows.Forms.Button generateJsonReportBtn;
        private System.Windows.Forms.Button excelReportForTeams;
        private System.Windows.Forms.LinkLabel linkLabel1;

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
            this.createSqlServerDb = new System.Windows.Forms.Button();
            this.getMongoData = new System.Windows.Forms.Button();
            this.fillDatFromZip = new System.Windows.Forms.Button();
            this.fillFromXmlBtn = new System.Windows.Forms.Button();
            this.createMySqlDb = new System.Windows.Forms.Button();
            this.generatePdfReportBtn = new System.Windows.Forms.Button();
            this.generateXmlReportBtn = new System.Windows.Forms.Button();
            this.generateJsonReportBtn = new System.Windows.Forms.Button();
            this.excelReportForTeams = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // CreateSqlServerDb
            // 
            this.createSqlServerDb.BackColor = System.Drawing.Color.Azure;
            this.createSqlServerDb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createSqlServerDb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createSqlServerDb.Location = new System.Drawing.Point(74, 76);
            this.createSqlServerDb.Name = "CreateSqlServerDb";
            this.createSqlServerDb.Size = new System.Drawing.Size(163, 29);
            this.createSqlServerDb.TabIndex = 0;
            this.createSqlServerDb.Text = "Create SQL Server DB";
            this.createSqlServerDb.UseVisualStyleBackColor = false;
            this.createSqlServerDb.Click += new System.EventHandler(this.CreateSqlServerDb_Click);
            // 
            // GetMongoData
            // 
            this.getMongoData.BackColor = System.Drawing.Color.Azure;
            this.getMongoData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getMongoData.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getMongoData.Location = new System.Drawing.Point(74, 120);
            this.getMongoData.Name = "GetMongoData";
            this.getMongoData.Size = new System.Drawing.Size(163, 29);
            this.getMongoData.TabIndex = 1;
            this.getMongoData.Text = "Fill Data From MongoDB";
            this.getMongoData.UseVisualStyleBackColor = false;
            this.getMongoData.Click += new System.EventHandler(this.GetMongoData_Click);
            // 
            // FillDatFromZip
            // 
            this.fillDatFromZip.BackColor = System.Drawing.Color.Azure;
            this.fillDatFromZip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fillDatFromZip.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fillDatFromZip.Location = new System.Drawing.Point(74, 164);
            this.fillDatFromZip.Name = "FillDatFromZip";
            this.fillDatFromZip.Size = new System.Drawing.Size(163, 29);
            this.fillDatFromZip.TabIndex = 2;
            this.fillDatFromZip.Text = "Fill Data from Zip";
            this.fillDatFromZip.UseVisualStyleBackColor = false;
            this.fillDatFromZip.Click += new System.EventHandler(this.FillDatFromZip_Click);
            // 
            // FillFromXml_btn
            // 
            this.fillFromXmlBtn.BackColor = System.Drawing.Color.Azure;
            this.fillFromXmlBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fillFromXmlBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fillFromXmlBtn.Location = new System.Drawing.Point(74, 208);
            this.fillFromXmlBtn.Name = "FillFromXml_btn";
            this.fillFromXmlBtn.Size = new System.Drawing.Size(163, 29);
            this.fillFromXmlBtn.TabIndex = 3;
            this.fillFromXmlBtn.Text = "Fill Data from Xml ";
            this.fillFromXmlBtn.UseVisualStyleBackColor = false;
            this.fillFromXmlBtn.Click += new System.EventHandler(this.FillFromXml_btn_Click);
            // 
            // CreateMySqlDb
            // 
            this.createMySqlDb.BackColor = System.Drawing.Color.Azure;
            this.createMySqlDb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createMySqlDb.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createMySqlDb.Location = new System.Drawing.Point(74, 383);
            this.createMySqlDb.Name = "CreateMySqlDb";
            this.createMySqlDb.Size = new System.Drawing.Size(163, 29);
            this.createMySqlDb.TabIndex = 7;
            this.createMySqlDb.Text = "Create MySql Db";
            this.createMySqlDb.UseVisualStyleBackColor = false;
            this.createMySqlDb.Click += new System.EventHandler(this.CreateMySqlDb_Click);
            // 
            // GeneratePdfReport_btn
            // 
            this.generatePdfReportBtn.BackColor = System.Drawing.Color.Azure;
            this.generatePdfReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generatePdfReportBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generatePdfReportBtn.Location = new System.Drawing.Point(74, 252);
            this.generatePdfReportBtn.Name = "GeneratePdfReport_btn";
            this.generatePdfReportBtn.Size = new System.Drawing.Size(163, 29);
            this.generatePdfReportBtn.TabIndex = 4;
            this.generatePdfReportBtn.Text = "Generate Pdf report";
            this.generatePdfReportBtn.UseVisualStyleBackColor = false;
            this.generatePdfReportBtn.Click += new System.EventHandler(this.GeneratePdfReport_btn_Click);
            // 
            // GenerateXmlReport_btn
            // 
            this.generateXmlReportBtn.BackColor = System.Drawing.Color.Azure;
            this.generateXmlReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateXmlReportBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generateXmlReportBtn.Location = new System.Drawing.Point(74, 340);
            this.generateXmlReportBtn.Name = "GenerateXmlReport_btn";
            this.generateXmlReportBtn.Size = new System.Drawing.Size(163, 29);
            this.generateXmlReportBtn.TabIndex = 6;
            this.generateXmlReportBtn.Text = "Generate Xml report";
            this.generateXmlReportBtn.UseVisualStyleBackColor = false;
            this.generateXmlReportBtn.Click += new System.EventHandler(this.GenerateXmlReport_btn_Click);
            // 
            // GenerateJsonReport_btn
            // 
            this.generateJsonReportBtn.BackColor = System.Drawing.Color.Azure;
            this.generateJsonReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateJsonReportBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generateJsonReportBtn.Location = new System.Drawing.Point(74, 296);
            this.generateJsonReportBtn.Name = "GenerateJsonReport_btn";
            this.generateJsonReportBtn.Size = new System.Drawing.Size(163, 29);
            this.generateJsonReportBtn.TabIndex = 5;
            this.generateJsonReportBtn.Text = "Generate Json report";
            this.generateJsonReportBtn.UseVisualStyleBackColor = false;
            this.generateJsonReportBtn.Click += new System.EventHandler(this.GenerateJsonReport_btn_Click);
            // 
            // ExcelReportForTeams
            // 
            this.excelReportForTeams.BackColor = System.Drawing.Color.Azure;
            this.excelReportForTeams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excelReportForTeams.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.excelReportForTeams.Location = new System.Drawing.Point(74, 427);
            this.excelReportForTeams.Name = "ExcelReportForTeams";
            this.excelReportForTeams.Size = new System.Drawing.Size(163, 29);
            this.excelReportForTeams.TabIndex = 8;
            this.excelReportForTeams.Text = "Excel Report for Teams";
            this.excelReportForTeams.UseVisualStyleBackColor = false;
            this.excelReportForTeams.Click += new System.EventHandler(this.ExcelReportForTeams_Click);
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
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // FootballManagerClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(318, 509);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.excelReportForTeams);
            this.Controls.Add(this.createMySqlDb);
            this.Controls.Add(this.generateJsonReportBtn);
            this.Controls.Add(this.generateXmlReportBtn);
            this.Controls.Add(this.generatePdfReportBtn);
            this.Controls.Add(this.fillFromXmlBtn);
            this.Controls.Add(this.fillDatFromZip);
            this.Controls.Add(this.getMongoData);
            this.Controls.Add(this.createSqlServerDb);
            this.Name = "FootballManagerClient";
            this.Text = "Football Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}