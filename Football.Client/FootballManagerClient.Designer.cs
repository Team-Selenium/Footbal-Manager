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
            this.CreateSqlServerDb = new System.Windows.Forms.Button();
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
            // FootballManagerClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.CreateSqlServerDb);
            this.Name = "FootballManagerClient";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateSqlServerDb;
    }
}

