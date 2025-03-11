namespace Project
{
    partial class userMenuForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblname = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnTiket = new System.Windows.Forms.Button();
            this.btnmypage = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 78);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(36, 56);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(87, 10);
            this.panel5.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(168, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Let\'s corail";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(12, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(87, 10);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(12, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(87, 10);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(52, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(87, 10);
            this.panel2.TabIndex = 1;
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblname.Location = new System.Drawing.Point(21, 97);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(116, 23);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "성이름";
            // 
            // lblAge
            // 
            this.lblAge.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAge.Location = new System.Drawing.Point(107, 97);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(126, 23);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "[네나이]";
            // 
            // btnTiket
            // 
            this.btnTiket.BackColor = System.Drawing.Color.Green;
            this.btnTiket.ForeColor = System.Drawing.Color.White;
            this.btnTiket.Location = new System.Drawing.Point(12, 133);
            this.btnTiket.Name = "btnTiket";
            this.btnTiket.Size = new System.Drawing.Size(140, 40);
            this.btnTiket.TabIndex = 3;
            this.btnTiket.Text = "열차예매";
            this.btnTiket.UseVisualStyleBackColor = false;
            // 
            // btnmypage
            // 
            this.btnmypage.BackColor = System.Drawing.Color.Green;
            this.btnmypage.ForeColor = System.Drawing.Color.White;
            this.btnmypage.Location = new System.Drawing.Point(158, 133);
            this.btnmypage.Name = "btnmypage";
            this.btnmypage.Size = new System.Drawing.Size(140, 40);
            this.btnmypage.TabIndex = 3;
            this.btnmypage.Text = "마이페이지";
            this.btnmypage.UseVisualStyleBackColor = false;
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.Green;
            this.btnMain.ForeColor = System.Drawing.Color.White;
            this.btnMain.Location = new System.Drawing.Point(304, 133);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(140, 40);
            this.btnMain.TabIndex = 3;
            this.btnMain.Text = "메인";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.기차1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // userMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnmypage);
            this.Controls.Add(this.btnTiket);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.panel1);
            this.Name = "userMenuForm";
            this.Text = "회원 메뉴";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnTiket;
        private System.Windows.Forms.Button btnmypage;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}