
namespace Project2
{
    partial class AddStaff
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlastnameAS = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtboxnameAS = new System.Windows.Forms.TextBox();
            this.txtboxlastnameAS = new System.Windows.Forms.TextBox();
            this.txtboxcontactAS = new System.Windows.Forms.TextBox();
            this.txtboxemailAS = new System.Windows.Forms.TextBox();
            this.txtboxaddressAS = new System.Windows.Forms.TextBox();
            this.txtboxroleAS = new System.Windows.Forms.ComboBox();
            this.lblstaffidAS = new System.Windows.Forms.Label();
            this.btnbrowseAS = new System.Windows.Forms.Button();
            this.pctboxAS = new System.Windows.Forms.PictureBox();
            this.btnsaveAS = new System.Windows.Forms.Button();
            this.btncancelAS = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pctboxAS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(417, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Staff";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Staff ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(16, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // txtlastnameAS
            // 
            this.txtlastnameAS.AutoSize = true;
            this.txtlastnameAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtlastnameAS.Location = new System.Drawing.Point(16, 242);
            this.txtlastnameAS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtlastnameAS.Name = "txtlastnameAS";
            this.txtlastnameAS.Size = new System.Drawing.Size(114, 24);
            this.txtlastnameAS.TabIndex = 3;
            this.txtlastnameAS.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(16, 295);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contact:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(16, 351);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(16, 405);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(651, 405);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Role:";
            // 
            // txtboxnameAS
            // 
            this.txtboxnameAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxnameAS.Location = new System.Drawing.Point(149, 171);
            this.txtboxnameAS.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxnameAS.Name = "txtboxnameAS";
            this.txtboxnameAS.Size = new System.Drawing.Size(204, 29);
            this.txtboxnameAS.TabIndex = 9;
            // 
            // txtboxlastnameAS
            // 
            this.txtboxlastnameAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxlastnameAS.Location = new System.Drawing.Point(149, 235);
            this.txtboxlastnameAS.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxlastnameAS.Name = "txtboxlastnameAS";
            this.txtboxlastnameAS.Size = new System.Drawing.Size(204, 29);
            this.txtboxlastnameAS.TabIndex = 10;
            // 
            // txtboxcontactAS
            // 
            this.txtboxcontactAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxcontactAS.Location = new System.Drawing.Point(149, 288);
            this.txtboxcontactAS.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxcontactAS.Name = "txtboxcontactAS";
            this.txtboxcontactAS.Size = new System.Drawing.Size(204, 29);
            this.txtboxcontactAS.TabIndex = 11;
            // 
            // txtboxemailAS
            // 
            this.txtboxemailAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxemailAS.Location = new System.Drawing.Point(149, 343);
            this.txtboxemailAS.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxemailAS.Name = "txtboxemailAS";
            this.txtboxemailAS.Size = new System.Drawing.Size(204, 29);
            this.txtboxemailAS.TabIndex = 12;
            // 
            // txtboxaddressAS
            // 
            this.txtboxaddressAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxaddressAS.Location = new System.Drawing.Point(149, 398);
            this.txtboxaddressAS.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxaddressAS.Name = "txtboxaddressAS";
            this.txtboxaddressAS.Size = new System.Drawing.Size(421, 29);
            this.txtboxaddressAS.TabIndex = 13;
            // 
            // txtboxroleAS
            // 
            this.txtboxroleAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxroleAS.FormattingEnabled = true;
            this.txtboxroleAS.Items.AddRange(new object[] {
            "CEO",
            "Manager",
            "Assistant",
            "Worker"});
            this.txtboxroleAS.Location = new System.Drawing.Point(775, 395);
            this.txtboxroleAS.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxroleAS.Name = "txtboxroleAS";
            this.txtboxroleAS.Size = new System.Drawing.Size(197, 32);
            this.txtboxroleAS.TabIndex = 14;
            // 
            // lblstaffidAS
            // 
            this.lblstaffidAS.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblstaffidAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblstaffidAS.Location = new System.Drawing.Point(144, 113);
            this.lblstaffidAS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstaffidAS.Name = "lblstaffidAS";
            this.lblstaffidAS.Size = new System.Drawing.Size(263, 28);
            this.lblstaffidAS.TabIndex = 15;
            // 
            // btnbrowseAS
            // 
            this.btnbrowseAS.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnbrowseAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbrowseAS.Location = new System.Drawing.Point(749, 295);
            this.btnbrowseAS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbrowseAS.Name = "btnbrowseAS";
            this.btnbrowseAS.Size = new System.Drawing.Size(224, 37);
            this.btnbrowseAS.TabIndex = 20;
            this.btnbrowseAS.Text = "Browse..";
            this.btnbrowseAS.UseVisualStyleBackColor = false;
            this.btnbrowseAS.Click += new System.EventHandler(this.btnbrowseAS_Click);
            // 
            // pctboxAS
            // 
            this.pctboxAS.BackColor = System.Drawing.Color.Silver;
            this.pctboxAS.Location = new System.Drawing.Point(696, 113);
            this.pctboxAS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctboxAS.Name = "pctboxAS";
            this.pctboxAS.Size = new System.Drawing.Size(321, 174);
            this.pctboxAS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctboxAS.TabIndex = 19;
            this.pctboxAS.TabStop = false;
            // 
            // btnsaveAS
            // 
            this.btnsaveAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnsaveAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsaveAS.Location = new System.Drawing.Point(16, 501);
            this.btnsaveAS.Margin = new System.Windows.Forms.Padding(4);
            this.btnsaveAS.Name = "btnsaveAS";
            this.btnsaveAS.Size = new System.Drawing.Size(157, 38);
            this.btnsaveAS.TabIndex = 21;
            this.btnsaveAS.Text = "Save";
            this.btnsaveAS.UseVisualStyleBackColor = false;
            this.btnsaveAS.Click += new System.EventHandler(this.btnsaveAS_Click);
            // 
            // btncancelAS
            // 
            this.btncancelAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btncancelAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncancelAS.Location = new System.Drawing.Point(893, 501);
            this.btncancelAS.Margin = new System.Windows.Forms.Padding(4);
            this.btncancelAS.Name = "btncancelAS";
            this.btncancelAS.Size = new System.Drawing.Size(157, 38);
            this.btncancelAS.TabIndex = 22;
            this.btncancelAS.Text = "Cancel";
            this.btncancelAS.UseVisualStyleBackColor = false;
            this.btncancelAS.Click += new System.EventHandler(this.btncancelAS_Click);
            // 
            // AddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btncancelAS);
            this.Controls.Add(this.btnsaveAS);
            this.Controls.Add(this.btnbrowseAS);
            this.Controls.Add(this.pctboxAS);
            this.Controls.Add(this.lblstaffidAS);
            this.Controls.Add(this.txtboxroleAS);
            this.Controls.Add(this.txtboxaddressAS);
            this.Controls.Add(this.txtboxemailAS);
            this.Controls.Add(this.txtboxcontactAS);
            this.Controls.Add(this.txtboxlastnameAS);
            this.Controls.Add(this.txtboxnameAS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtlastnameAS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddStaff";
            this.Text = "AddStaff";
            this.Load += new System.EventHandler(this.AddStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctboxAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtlastnameAS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtboxnameAS;
        private System.Windows.Forms.TextBox txtboxlastnameAS;
        private System.Windows.Forms.TextBox txtboxcontactAS;
        private System.Windows.Forms.TextBox txtboxemailAS;
        private System.Windows.Forms.TextBox txtboxaddressAS;
        private System.Windows.Forms.ComboBox txtboxroleAS;
        private System.Windows.Forms.Button btnbrowseAS;
        private System.Windows.Forms.PictureBox pctboxAS;
        private System.Windows.Forms.Button btnsaveAS;
        private System.Windows.Forms.Button btncancelAS;
        private System.Windows.Forms.Label lblstaffidAS;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}