namespace Atom
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
            this.Pb = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Atuo = new System.Windows.Forms.CheckBox();
            this.ENX = new System.Windows.Forms.TextBox();
            this.MPX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.DiffXY = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AccXY = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pb)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pb
            // 
            this.Pb.BackColor = System.Drawing.Color.White;
            this.Pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pb.Location = new System.Drawing.Point(0, 0);
            this.Pb.Name = "Pb";
            this.Pb.Size = new System.Drawing.Size(737, 418);
            this.Pb.TabIndex = 1;
            this.Pb.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Atuo);
            this.panel1.Controls.Add(this.ENX);
            this.panel1.Controls.Add(this.MPX);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.DiffXY);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AccXY);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 49);
            this.panel1.TabIndex = 7;
            // 
            // Atuo
            // 
            this.Atuo.AutoSize = true;
            this.Atuo.Location = new System.Drawing.Point(303, 29);
            this.Atuo.Name = "Atuo";
            this.Atuo.Size = new System.Drawing.Size(48, 17);
            this.Atuo.TabIndex = 17;
            this.Atuo.Text = "Auto";
            this.Atuo.UseVisualStyleBackColor = true;
            // 
            // ENX
            // 
            this.ENX.Location = new System.Drawing.Point(197, 26);
            this.ENX.Name = "ENX";
            this.ENX.Size = new System.Drawing.Size(100, 20);
            this.ENX.TabIndex = 16;
            this.ENX.Text = "1";
            // 
            // MPX
            // 
            this.MPX.Location = new System.Drawing.Point(197, 3);
            this.MPX.Name = "MPX";
            this.MPX.Size = new System.Drawing.Size(100, 20);
            this.MPX.TabIndex = 15;
            this.MPX.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "EN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "MP:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(569, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DiffXY
            // 
            this.DiffXY.AutoSize = true;
            this.DiffXY.Location = new System.Drawing.Point(85, 22);
            this.DiffXY.Name = "DiffXY";
            this.DiffXY.Size = new System.Drawing.Size(35, 13);
            this.DiffXY.TabIndex = 11;
            this.DiffXY.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "X and Y Diff";
            // 
            // AccXY
            // 
            this.AccXY.AutoSize = true;
            this.AccXY.Location = new System.Drawing.Point(85, 6);
            this.AccXY.Name = "AccXY";
            this.AccXY.Size = new System.Drawing.Size(35, 13);
            this.AccXY.TabIndex = 9;
            this.AccXY.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Acc X and Y";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 418);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pb)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label DiffXY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AccXY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ENX;
        private System.Windows.Forms.TextBox MPX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Atuo;
    }
}

