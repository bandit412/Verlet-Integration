namespace VerletDraw
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorMsg = new System.Windows.Forms.Label();
            this.VBReset = new System.Windows.Forms.Button();
            this.VBDraw = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.VOVy = new System.Windows.Forms.TextBox();
            this.VOVx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.VOPy = new System.Windows.Forms.TextBox();
            this.VOPx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VGy = new System.Windows.Forms.TextBox();
            this.VGx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.errorMsg);
            this.groupBox1.Controls.Add(this.VBReset);
            this.groupBox1.Controls.Add(this.VBDraw);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.VOVy);
            this.groupBox1.Controls.Add(this.VOVx);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.VOPy);
            this.groupBox1.Controls.Add(this.VOPx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.VGy);
            this.groupBox1.Controls.Add(this.VGx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verlet Inputs";
            // 
            // errorMsg
            // 
            this.errorMsg.AutoSize = true;
            this.errorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMsg.ForeColor = System.Drawing.Color.Red;
            this.errorMsg.Location = new System.Drawing.Point(62, 44);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(33, 13);
            this.errorMsg.TabIndex = 15;
            this.errorMsg.Text = "error";
            // 
            // VBReset
            // 
            this.VBReset.Location = new System.Drawing.Point(883, 16);
            this.VBReset.Name = "VBReset";
            this.VBReset.Size = new System.Drawing.Size(75, 23);
            this.VBReset.TabIndex = 14;
            this.VBReset.Text = "Reset";
            this.VBReset.UseVisualStyleBackColor = true;
            this.VBReset.Click += new System.EventHandler(this.VBReset_Click);
            // 
            // VBDraw
            // 
            this.VBDraw.Location = new System.Drawing.Point(786, 15);
            this.VBDraw.Name = "VBDraw";
            this.VBDraw.Size = new System.Drawing.Size(75, 23);
            this.VBDraw.TabIndex = 13;
            this.VBDraw.Text = "Draw";
            this.VBDraw.UseVisualStyleBackColor = true;
            this.VBDraw.Click += new System.EventHandler(this.VBDraw_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(721, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "] m/s";
            // 
            // VOVy
            // 
            this.VOVy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.VOVy.Location = new System.Drawing.Point(661, 18);
            this.VOVy.Name = "VOVy";
            this.VOVy.Size = new System.Drawing.Size(54, 20);
            this.VOVy.TabIndex = 11;
            this.VOVy.Text = "10.0";
            this.VOVy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VOVx
            // 
            this.VOVx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.VOVx.Location = new System.Drawing.Point(601, 17);
            this.VOVx.Name = "VOVx";
            this.VOVx.Size = new System.Drawing.Size(54, 20);
            this.VOVx.TabIndex = 10;
            this.VOVx.Text = "1.0";
            this.VOVx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Initial Velocity: [";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "] m";
            // 
            // VOPy
            // 
            this.VOPy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.VOPy.Location = new System.Drawing.Point(407, 17);
            this.VOPy.Name = "VOPy";
            this.VOPy.Size = new System.Drawing.Size(54, 20);
            this.VOPy.TabIndex = 7;
            this.VOPy.Text = "10.0";
            this.VOPy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VOPx
            // 
            this.VOPx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.VOPx.Location = new System.Drawing.Point(347, 17);
            this.VOPx.Name = "VOPx";
            this.VOPx.Size = new System.Drawing.Size(54, 20);
            this.VOPx.TabIndex = 6;
            this.VOPx.Text = "0.0";
            this.VOPx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Initial Position: [";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "] m/s^2";
            // 
            // VGy
            // 
            this.VGy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.VGy.Location = new System.Drawing.Point(122, 17);
            this.VGy.Name = "VGy";
            this.VGy.ShortcutsEnabled = false;
            this.VGy.Size = new System.Drawing.Size(54, 20);
            this.VGy.TabIndex = 3;
            this.VGy.Text = "-9.81";
            this.VGy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VGx
            // 
            this.VGx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.VGx.Enabled = false;
            this.VGx.Location = new System.Drawing.Point(62, 17);
            this.VGx.Name = "VGx";
            this.VGx.Size = new System.Drawing.Size(54, 20);
            this.VGx.TabIndex = 2;
            this.VGx.Text = "0.0";
            this.VGx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gravity: [";
            // 
            // VPictureBox
            // 
            this.VPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.VPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VPictureBox.Location = new System.Drawing.Point(13, 91);
            this.VPictureBox.Name = "VPictureBox";
            this.VPictureBox.Size = new System.Drawing.Size(975, 625);
            this.VPictureBox.TabIndex = 1;
            this.VPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.VPictureBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Verlet Projectile Demo (Adapted from https://www.algorithm-archive.org/contents/v" +
    "erlet_integration/verlet_integration.html)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.Button VBReset;
        private System.Windows.Forms.Button VBDraw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox VOVy;
        private System.Windows.Forms.TextBox VOVx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox VOPy;
        private System.Windows.Forms.TextBox VOPx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VGy;
        private System.Windows.Forms.TextBox VGx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox VPictureBox;
    }
}

