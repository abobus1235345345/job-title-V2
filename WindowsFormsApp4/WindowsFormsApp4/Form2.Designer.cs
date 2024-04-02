namespace WindowsFormsApp4
{
    partial class Form2
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
            this.NameLabel1 = new System.Windows.Forms.Label();
            this.PositionLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel1
            // 
            this.NameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel1.Location = new System.Drawing.Point(37, 44);
            this.NameLabel1.Name = "NameLabel1";
            this.NameLabel1.Size = new System.Drawing.Size(115, 23);
            this.NameLabel1.TabIndex = 0;
            this.NameLabel1.Text = "label1";
            // 
            // PositionLabel1
            // 
            this.PositionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PositionLabel1.Location = new System.Drawing.Point(33, 114);
            this.PositionLabel1.Name = "PositionLabel1";
            this.PositionLabel1.Size = new System.Drawing.Size(119, 62);
            this.PositionLabel1.TabIndex = 1;
            this.PositionLabel1.Text = "label2";
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(420, 374);
            this.Controls.Add(this.PositionLabel1);
            this.Controls.Add(this.NameLabel1);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox NameLabel;
        private System.Windows.Forms.TextBox PositionLabel;
        private System.Windows.Forms.Label NameLabel1;
        private System.Windows.Forms.Label PositionLabel1;
    }
}