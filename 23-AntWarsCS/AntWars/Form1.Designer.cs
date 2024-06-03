
namespace AntWars
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TimMove = new System.Windows.Forms.Timer(this.components);
            this.L1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.T1 = new System.Windows.Forms.Timer(this.components);
            this.A1 = new System.Windows.Forms.PictureBox();
            this.A2 = new System.Windows.Forms.PictureBox();
            this.A3 = new System.Windows.Forms.PictureBox();
            this.A4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.A1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A4)).BeginInit();
            this.SuspendLayout();
           
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.Location = new System.Drawing.Point(564, 370);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(57, 20);
            this.L1.TabIndex = 7;
            this.L1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(562, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // T1
            // 
            this.T1.Interval = 200;
            this.T1.Tick += new System.EventHandler(this.T1_Tick);
            // 
            // A1
            // 
            this.A1.Image = ((System.Drawing.Image)(resources.GetObject("A1.Image")));
            this.A1.Location = new System.Drawing.Point(88, 224);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(71, 74);
            this.A1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A1.TabIndex = 9;
            this.A1.TabStop = false;
            this.A1.Click += new System.EventHandler(this.A1_Click);
            // 
            // A2
            // 
            this.A2.Image = ((System.Drawing.Image)(resources.GetObject("A2.Image")));
            this.A2.Location = new System.Drawing.Point(225, 224);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(71, 74);
            this.A2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A2.TabIndex = 10;
            this.A2.TabStop = false;
            this.A2.Click += new System.EventHandler(this.A2_Click);
            // 
            // A3
            // 
            this.A3.Image = ((System.Drawing.Image)(resources.GetObject("A3.Image")));
            this.A3.Location = new System.Drawing.Point(365, 216);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(71, 74);
            this.A3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A3.TabIndex = 11;
            this.A3.TabStop = false;
            this.A3.Click += new System.EventHandler(this.A3_Click);
            // 
            // A4
            // 
            this.A4.Image = ((System.Drawing.Image)(resources.GetObject("A4.Image")));
            this.A4.Location = new System.Drawing.Point(509, 216);
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(71, 74);
            this.A4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.A4.TabIndex = 12;
            this.A4.TabStop = false;
            this.A4.Click += new System.EventHandler(this.A4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.A4);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.L1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.A1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer TimMove;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer T1;
        private System.Windows.Forms.PictureBox A1;
        private System.Windows.Forms.PictureBox A2;
        private System.Windows.Forms.PictureBox A3;
        private System.Windows.Forms.PictureBox A4;
    }
}

