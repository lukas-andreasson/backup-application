namespace entergateBackup
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
            this.startbutton = new System.Windows.Forms.Button();
            this.browsebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pathtextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backupbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pathtextbox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.startbutton.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.ForeColor = System.Drawing.Color.Black;
            this.startbutton.Location = new System.Drawing.Point(303, 246);
            this.startbutton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(122, 40);
            this.startbutton.TabIndex = 0;
            this.startbutton.Text = "Start BackUp";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // browsebutton
            // 
            this.browsebutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.browsebutton.Location = new System.Drawing.Point(521, 76);
            this.browsebutton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.browsebutton.Name = "browsebutton";
            this.browsebutton.Size = new System.Drawing.Size(122, 39);
            this.browsebutton.TabIndex = 1;
            this.browsebutton.Text = "Browse Paths";
            this.browsebutton.UseVisualStyleBackColor = false;
            this.browsebutton.Click += new System.EventHandler(this.browsebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 34);
            this.label1.TabIndex = 2;
            // 
            // pathtextbox
            // 
            this.pathtextbox.Location = new System.Drawing.Point(176, 75);
            this.pathtextbox.Name = "pathtextbox";
            this.pathtextbox.Size = new System.Drawing.Size(338, 42);
            this.pathtextbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(84, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add Path :";
            // 
            // backupbutton
            // 
            this.backupbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.backupbutton.Location = new System.Drawing.Point(521, 153);
            this.backupbutton.Name = "backupbutton";
            this.backupbutton.Size = new System.Drawing.Size(122, 40);
            this.backupbutton.TabIndex = 5;
            this.backupbutton.Text = "Browse Paths";
            this.backupbutton.UseVisualStyleBackColor = false;
            this.backupbutton.Click += new System.EventHandler(this.backupbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "BackUp Path :";
            // 
            // pathtextbox2
            // 
            this.pathtextbox2.Location = new System.Drawing.Point(176, 153);
            this.pathtextbox2.Name = "pathtextbox2";
            this.pathtextbox2.Size = new System.Drawing.Size(338, 42);
            this.pathtextbox2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(740, 386);
            this.Controls.Add(this.pathtextbox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backupbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pathtextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browsebutton);
            this.Controls.Add(this.startbutton);
            this.Font = new System.Drawing.Font("Javanese Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Back Up Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button browsebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathtextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backupbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pathtextbox2;
    }
}

