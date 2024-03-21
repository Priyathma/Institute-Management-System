namespace ADMIN
{
    partial class TIMETABLE
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
            this.gunaAdvenceButton6 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaAdvenceButton6
            // 
            this.gunaAdvenceButton6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaAdvenceButton6.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton6.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gunaAdvenceButton6.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton6.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton6.CheckedImage = null;
            this.gunaAdvenceButton6.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton6.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton6.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton6.Image = null;
            this.gunaAdvenceButton6.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton6.Location = new System.Drawing.Point(23, 16);
            this.gunaAdvenceButton6.Name = "gunaAdvenceButton6";
            this.gunaAdvenceButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton6.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton6.OnHoverImage = null;
            this.gunaAdvenceButton6.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton6.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton6.Size = new System.Drawing.Size(180, 42);
            this.gunaAdvenceButton6.TabIndex = 19;
            this.gunaAdvenceButton6.Text = "TIMETABLE";
            this.gunaAdvenceButton6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton6.Click += new System.EventHandler(this.gunaAdvenceButton6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 667);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(88, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1126, 471);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 42);
            this.label1.TabIndex = 22;
            this.label1.Text = "Timetable";
            // 
            // TIMETABLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 759);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaAdvenceButton6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TIMETABLE";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}