
namespace Project2
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnshowc = new System.Windows.Forms.Button();
            this.btnaddcus = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnshows = new System.Windows.Forms.Button();
            this.btnadds = new System.Windows.Forms.Button();
            this.btnexitform1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Bank Managment";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LimeGreen;
            this.groupBox1.Controls.Add(this.btnshowc);
            this.groupBox1.Controls.Add(this.btnaddcus);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(445, 187);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Control";
            // 
            // btnshowc
            // 
            this.btnshowc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnshowc.Location = new System.Drawing.Point(104, 114);
            this.btnshowc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnshowc.Name = "btnshowc";
            this.btnshowc.Size = new System.Drawing.Size(240, 57);
            this.btnshowc.TabIndex = 5;
            this.btnshowc.Text = "Show Customers";
            this.btnshowc.UseVisualStyleBackColor = true;
            this.btnshowc.Click += new System.EventHandler(this.btnshowc_Click);
            // 
            // btnaddcus
            // 
            this.btnaddcus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnaddcus.Location = new System.Drawing.Point(104, 36);
            this.btnaddcus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnaddcus.Name = "btnaddcus";
            this.btnaddcus.Size = new System.Drawing.Size(240, 57);
            this.btnaddcus.TabIndex = 4;
            this.btnaddcus.Text = "Add Customers";
            this.btnaddcus.UseVisualStyleBackColor = true;
            this.btnaddcus.Click += new System.EventHandler(this.btnaddc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btnshows);
            this.groupBox2.Controls.Add(this.btnadds);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(13, 260);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(445, 194);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Staff Control";
            // 
            // btnshows
            // 
            this.btnshows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnshows.Location = new System.Drawing.Point(104, 121);
            this.btnshows.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnshows.Name = "btnshows";
            this.btnshows.Size = new System.Drawing.Size(240, 57);
            this.btnshows.TabIndex = 7;
            this.btnshows.Text = "Show Staff";
            this.btnshows.UseVisualStyleBackColor = true;
            this.btnshows.Click += new System.EventHandler(this.btnshows_Click);
            // 
            // btnadds
            // 
            this.btnadds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnadds.Location = new System.Drawing.Point(104, 39);
            this.btnadds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnadds.Name = "btnadds";
            this.btnadds.Size = new System.Drawing.Size(240, 57);
            this.btnadds.TabIndex = 6;
            this.btnadds.Text = "Add Staff";
            this.btnadds.UseVisualStyleBackColor = true;
            this.btnadds.Click += new System.EventHandler(this.btnadds_Click);
            // 
            // btnexitform1
            // 
            this.btnexitform1.BackColor = System.Drawing.Color.Red;
            this.btnexitform1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnexitform1.Location = new System.Drawing.Point(12, 514);
            this.btnexitform1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnexitform1.Name = "btnexitform1";
            this.btnexitform1.Size = new System.Drawing.Size(445, 42);
            this.btnexitform1.TabIndex = 8;
            this.btnexitform1.Text = "Exit";
            this.btnexitform1.UseVisualStyleBackColor = false;
            this.btnexitform1.Click += new System.EventHandler(this.btnexitform1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(44, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Programmed by Project X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 569);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnexitform1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnshowc;
        private System.Windows.Forms.Button btnaddcus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnshows;
        private System.Windows.Forms.Button btnadds;
        private System.Windows.Forms.Button btnexitform1;
        private System.Windows.Forms.Label label2;
    }
}

