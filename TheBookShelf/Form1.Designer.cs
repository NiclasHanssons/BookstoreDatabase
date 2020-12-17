namespace TheBookShelf
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBoxButikID = new System.Windows.Forms.TextBox();
            this.labelButikID = new System.Windows.Forms.Label();
            this.labelLand = new System.Windows.Forms.Label();
            this.labelStad = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.textBoxLand = new System.Windows.Forms.TextBox();
            this.textBoxStad = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 195;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textBoxButikID);
            this.splitContainer2.Panel1.Controls.Add(this.labelButikID);
            this.splitContainer2.Panel1.Controls.Add(this.labelLand);
            this.splitContainer2.Panel1.Controls.Add(this.labelStad);
            this.splitContainer2.Panel1.Controls.Add(this.labelAdress);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxLand);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxStad);
            this.splitContainer2.Panel1.Controls.Add(this.textBoxAdress);
            this.splitContainer2.Size = new System.Drawing.Size(601, 450);
            this.splitContainer2.SplitterDistance = 175;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.Text = "splitContainer2";
            // 
            // textBoxButikID
            // 
            this.textBoxButikID.Location = new System.Drawing.Point(66, 6);
            this.textBoxButikID.Name = "textBoxButikID";
            this.textBoxButikID.Size = new System.Drawing.Size(48, 23);
            this.textBoxButikID.TabIndex = 7;
            // 
            // labelButikID
            // 
            this.labelButikID.AutoSize = true;
            this.labelButikID.Location = new System.Drawing.Point(12, 9);
            this.labelButikID.Name = "labelButikID";
            this.labelButikID.Size = new System.Drawing.Size(48, 15);
            this.labelButikID.TabIndex = 6;
            this.labelButikID.Text = "ButikID:";
            // 
            // labelLand
            // 
            this.labelLand.AutoSize = true;
            this.labelLand.Location = new System.Drawing.Point(24, 96);
            this.labelLand.Name = "labelLand";
            this.labelLand.Size = new System.Drawing.Size(36, 15);
            this.labelLand.TabIndex = 5;
            this.labelLand.Text = "Land:";
            // 
            // labelStad
            // 
            this.labelStad.AutoSize = true;
            this.labelStad.Location = new System.Drawing.Point(27, 67);
            this.labelStad.Name = "labelStad";
            this.labelStad.Size = new System.Drawing.Size(33, 15);
            this.labelStad.TabIndex = 4;
            this.labelStad.Text = "Stad:";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(15, 38);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(45, 15);
            this.labelAdress.TabIndex = 3;
            this.labelAdress.Text = "Adress:";
            // 
            // textBoxLand
            // 
            this.textBoxLand.Location = new System.Drawing.Point(66, 93);
            this.textBoxLand.Name = "textBoxLand";
            this.textBoxLand.Size = new System.Drawing.Size(236, 23);
            this.textBoxLand.TabIndex = 2;
            // 
            // textBoxStad
            // 
            this.textBoxStad.Location = new System.Drawing.Point(66, 64);
            this.textBoxStad.Name = "textBoxStad";
            this.textBoxStad.Size = new System.Drawing.Size(236, 23);
            this.textBoxStad.TabIndex = 1;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(66, 35);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(236, 23);
            this.textBoxAdress.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label labelLand;
        private System.Windows.Forms.Label labelStad;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.TextBox textBoxLand;
        private System.Windows.Forms.TextBox textBoxStad;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxButikID;
        private System.Windows.Forms.Label labelButikID;
    }
}

