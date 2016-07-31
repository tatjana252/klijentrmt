namespace GUI
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
            this.console = new System.Windows.Forms.TextBox();
            this.odgovori = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // console
            // 
            this.console.Enabled = false;
            this.console.Location = new System.Drawing.Point(12, 12);
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(260, 114);
            this.console.TabIndex = 0;
            this.console.TextChanged += new System.EventHandler(this.console_TextChanged);
            // 
            // odgovori
            // 
            this.odgovori.Location = new System.Drawing.Point(12, 158);
            this.odgovori.Name = "odgovori";
            this.odgovori.Size = new System.Drawing.Size(259, 20);
            this.odgovori.TabIndex = 1;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(195, 201);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 2;
            this.send.Text = "send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.send);
            this.Controls.Add(this.odgovori);
            this.Controls.Add(this.console);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox console;
        private System.Windows.Forms.TextBox odgovori;
        private System.Windows.Forms.Button send;
    }
}

