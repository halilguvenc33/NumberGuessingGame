namespace NumberGuessingGame
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pc_txt = new System.Windows.Forms.RichTextBox();
            this.user_txt = new System.Windows.Forms.RichTextBox();
            this.zero_btn = new System.Windows.Forms.Button();
            this.one_btn = new System.Windows.Forms.Button();
            this.two_btn = new System.Windows.Forms.Button();
            this.three_btn = new System.Windows.Forms.Button();
            this.four_btn = new System.Windows.Forms.Button();
            this.nine_btn = new System.Windows.Forms.Button();
            this.eigth_btn = new System.Windows.Forms.Button();
            this.seven_btn = new System.Windows.Forms.Button();
            this.six_btn = new System.Windows.Forms.Button();
            this.five_btn = new System.Windows.Forms.Button();
            this.plus_btn = new System.Windows.Forms.Button();
            this.plus_txt = new System.Windows.Forms.TextBox();
            this.minus_txt = new System.Windows.Forms.TextBox();
            this.minus_btn = new System.Windows.Forms.Button();
            this.enter_user_btn = new System.Windows.Forms.Button();
            this.user_groupbox = new System.Windows.Forms.GroupBox();
            this.reset_btn = new System.Windows.Forms.Button();
            this.computer_groupbox = new System.Windows.Forms.GroupBox();
            this.enter_pc_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.dijit1_txt = new System.Windows.Forms.TextBox();
            this.dijit10_txt = new System.Windows.Forms.TextBox();
            this.dijit100_txt = new System.Windows.Forms.TextBox();
            this.dijit1000_txt = new System.Windows.Forms.TextBox();
            this.user_groupbox.SuspendLayout();
            this.computer_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pc_txt
            // 
            this.pc_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pc_txt.Location = new System.Drawing.Point(17, 43);
            this.pc_txt.Name = "pc_txt";
            this.pc_txt.Size = new System.Drawing.Size(398, 227);
            this.pc_txt.TabIndex = 0;
            this.pc_txt.Text = "";
            // 
            // user_txt
            // 
            this.user_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.user_txt.Location = new System.Drawing.Point(6, 43);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(371, 227);
            this.user_txt.TabIndex = 2;
            this.user_txt.Text = "";
            this.user_txt.TextChanged += new System.EventHandler(this.user_txt_TextChanged);
            // 
            // zero_btn
            // 
            this.zero_btn.Location = new System.Drawing.Point(20, 346);
            this.zero_btn.Name = "zero_btn";
            this.zero_btn.Size = new System.Drawing.Size(75, 49);
            this.zero_btn.TabIndex = 4;
            this.zero_btn.Text = "0";
            this.zero_btn.UseVisualStyleBackColor = true;
            this.zero_btn.Click += new System.EventHandler(this.zero_btn_Click);
            // 
            // one_btn
            // 
            this.one_btn.Location = new System.Drawing.Point(101, 346);
            this.one_btn.Name = "one_btn";
            this.one_btn.Size = new System.Drawing.Size(75, 49);
            this.one_btn.TabIndex = 5;
            this.one_btn.Text = "1";
            this.one_btn.UseVisualStyleBackColor = true;
            this.one_btn.Click += new System.EventHandler(this.one_btn_Click);
            // 
            // two_btn
            // 
            this.two_btn.Location = new System.Drawing.Point(182, 346);
            this.two_btn.Name = "two_btn";
            this.two_btn.Size = new System.Drawing.Size(75, 49);
            this.two_btn.TabIndex = 6;
            this.two_btn.Text = "2";
            this.two_btn.UseVisualStyleBackColor = true;
            this.two_btn.Click += new System.EventHandler(this.two_btn_Click);
            // 
            // three_btn
            // 
            this.three_btn.Location = new System.Drawing.Point(263, 346);
            this.three_btn.Name = "three_btn";
            this.three_btn.Size = new System.Drawing.Size(75, 49);
            this.three_btn.TabIndex = 7;
            this.three_btn.Text = "3";
            this.three_btn.UseVisualStyleBackColor = true;
            this.three_btn.Click += new System.EventHandler(this.three_btn_Click);
            // 
            // four_btn
            // 
            this.four_btn.Location = new System.Drawing.Point(344, 346);
            this.four_btn.Name = "four_btn";
            this.four_btn.Size = new System.Drawing.Size(75, 49);
            this.four_btn.TabIndex = 8;
            this.four_btn.Text = "4";
            this.four_btn.UseVisualStyleBackColor = true;
            this.four_btn.Click += new System.EventHandler(this.four_btn_Click);
            // 
            // nine_btn
            // 
            this.nine_btn.Location = new System.Drawing.Point(344, 401);
            this.nine_btn.Name = "nine_btn";
            this.nine_btn.Size = new System.Drawing.Size(75, 49);
            this.nine_btn.TabIndex = 13;
            this.nine_btn.Text = "9";
            this.nine_btn.UseVisualStyleBackColor = true;
            this.nine_btn.Click += new System.EventHandler(this.nine_btn_Click);
            // 
            // eigth_btn
            // 
            this.eigth_btn.Location = new System.Drawing.Point(263, 401);
            this.eigth_btn.Name = "eigth_btn";
            this.eigth_btn.Size = new System.Drawing.Size(75, 49);
            this.eigth_btn.TabIndex = 12;
            this.eigth_btn.Text = "8";
            this.eigth_btn.UseVisualStyleBackColor = true;
            this.eigth_btn.Click += new System.EventHandler(this.eigth_btn_Click);
            // 
            // seven_btn
            // 
            this.seven_btn.Location = new System.Drawing.Point(182, 401);
            this.seven_btn.Name = "seven_btn";
            this.seven_btn.Size = new System.Drawing.Size(75, 49);
            this.seven_btn.TabIndex = 11;
            this.seven_btn.Text = "7";
            this.seven_btn.UseVisualStyleBackColor = true;
            this.seven_btn.Click += new System.EventHandler(this.seven_btn_Click);
            // 
            // six_btn
            // 
            this.six_btn.Location = new System.Drawing.Point(101, 401);
            this.six_btn.Name = "six_btn";
            this.six_btn.Size = new System.Drawing.Size(75, 49);
            this.six_btn.TabIndex = 10;
            this.six_btn.Text = "6";
            this.six_btn.UseVisualStyleBackColor = true;
            this.six_btn.Click += new System.EventHandler(this.six_btn_Click);
            // 
            // five_btn
            // 
            this.five_btn.Location = new System.Drawing.Point(20, 401);
            this.five_btn.Name = "five_btn";
            this.five_btn.Size = new System.Drawing.Size(75, 49);
            this.five_btn.TabIndex = 9;
            this.five_btn.Text = "5";
            this.five_btn.UseVisualStyleBackColor = true;
            this.five_btn.Click += new System.EventHandler(this.five_btn_Click);
            // 
            // plus_btn
            // 
            this.plus_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plus_btn.Location = new System.Drawing.Point(80, 388);
            this.plus_btn.Name = "plus_btn";
            this.plus_btn.Size = new System.Drawing.Size(75, 49);
            this.plus_btn.TabIndex = 14;
            this.plus_btn.Text = "+";
            this.plus_btn.UseVisualStyleBackColor = true;
            this.plus_btn.Click += new System.EventHandler(this.plus_btn_Click);
            // 
            // plus_txt
            // 
            this.plus_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.plus_txt.Location = new System.Drawing.Point(80, 346);
            this.plus_txt.Name = "plus_txt";
            this.plus_txt.Size = new System.Drawing.Size(75, 36);
            this.plus_txt.TabIndex = 15;
            // 
            // minus_txt
            // 
            this.minus_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.minus_txt.Location = new System.Drawing.Point(171, 346);
            this.minus_txt.Name = "minus_txt";
            this.minus_txt.Size = new System.Drawing.Size(75, 36);
            this.minus_txt.TabIndex = 17;
            // 
            // minus_btn
            // 
            this.minus_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.minus_btn.Location = new System.Drawing.Point(171, 388);
            this.minus_btn.Name = "minus_btn";
            this.minus_btn.Size = new System.Drawing.Size(75, 49);
            this.minus_btn.TabIndex = 16;
            this.minus_btn.Text = "-";
            this.minus_btn.UseVisualStyleBackColor = true;
            this.minus_btn.Click += new System.EventHandler(this.minus_btn_Click);
            // 
            // enter_user_btn
            // 
            this.enter_user_btn.Location = new System.Drawing.Point(80, 449);
            this.enter_user_btn.Name = "enter_user_btn";
            this.enter_user_btn.Size = new System.Drawing.Size(166, 49);
            this.enter_user_btn.TabIndex = 18;
            this.enter_user_btn.Text = "ENTER";
            this.enter_user_btn.UseVisualStyleBackColor = true;
            this.enter_user_btn.Click += new System.EventHandler(this.enter_user_btn_Click);
            // 
            // user_groupbox
            // 
            this.user_groupbox.Controls.Add(this.reset_btn);
            this.user_groupbox.Controls.Add(this.enter_user_btn);
            this.user_groupbox.Controls.Add(this.user_txt);
            this.user_groupbox.Controls.Add(this.minus_txt);
            this.user_groupbox.Controls.Add(this.plus_txt);
            this.user_groupbox.Controls.Add(this.minus_btn);
            this.user_groupbox.Controls.Add(this.plus_btn);
            this.user_groupbox.Location = new System.Drawing.Point(470, 12);
            this.user_groupbox.Name = "user_groupbox";
            this.user_groupbox.Size = new System.Drawing.Size(398, 517);
            this.user_groupbox.TabIndex = 19;
            this.user_groupbox.TabStop = false;
            this.user_groupbox.Text = "User";
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(273, 449);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(75, 49);
            this.reset_btn.TabIndex = 19;
            this.reset_btn.Text = "RESET";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // computer_groupbox
            // 
            this.computer_groupbox.Controls.Add(this.enter_pc_btn);
            this.computer_groupbox.Controls.Add(this.delete_btn);
            this.computer_groupbox.Controls.Add(this.dijit1_txt);
            this.computer_groupbox.Controls.Add(this.dijit10_txt);
            this.computer_groupbox.Controls.Add(this.dijit100_txt);
            this.computer_groupbox.Controls.Add(this.dijit1000_txt);
            this.computer_groupbox.Controls.Add(this.pc_txt);
            this.computer_groupbox.Controls.Add(this.nine_btn);
            this.computer_groupbox.Controls.Add(this.zero_btn);
            this.computer_groupbox.Controls.Add(this.eigth_btn);
            this.computer_groupbox.Controls.Add(this.one_btn);
            this.computer_groupbox.Controls.Add(this.seven_btn);
            this.computer_groupbox.Controls.Add(this.two_btn);
            this.computer_groupbox.Controls.Add(this.six_btn);
            this.computer_groupbox.Controls.Add(this.three_btn);
            this.computer_groupbox.Controls.Add(this.five_btn);
            this.computer_groupbox.Controls.Add(this.four_btn);
            this.computer_groupbox.Location = new System.Drawing.Point(12, 12);
            this.computer_groupbox.Name = "computer_groupbox";
            this.computer_groupbox.Size = new System.Drawing.Size(452, 517);
            this.computer_groupbox.TabIndex = 20;
            this.computer_groupbox.TabStop = false;
            this.computer_groupbox.Text = "Computer";
            // 
            // enter_pc_btn
            // 
            this.enter_pc_btn.Location = new System.Drawing.Point(133, 454);
            this.enter_pc_btn.Name = "enter_pc_btn";
            this.enter_pc_btn.Size = new System.Drawing.Size(161, 49);
            this.enter_pc_btn.TabIndex = 19;
            this.enter_pc_btn.Text = "ENTER";
            this.enter_pc_btn.UseVisualStyleBackColor = true;
            this.enter_pc_btn.Click += new System.EventHandler(this.enter_pc_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(326, 290);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(89, 39);
            this.delete_btn.TabIndex = 18;
            this.delete_btn.Text = "DELETE";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // dijit1_txt
            // 
            this.dijit1_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dijit1_txt.Location = new System.Drawing.Point(149, 290);
            this.dijit1_txt.Name = "dijit1_txt";
            this.dijit1_txt.Size = new System.Drawing.Size(37, 36);
            this.dijit1_txt.TabIndex = 17;
            // 
            // dijit10_txt
            // 
            this.dijit10_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dijit10_txt.Location = new System.Drawing.Point(106, 290);
            this.dijit10_txt.Name = "dijit10_txt";
            this.dijit10_txt.Size = new System.Drawing.Size(37, 36);
            this.dijit10_txt.TabIndex = 16;
            // 
            // dijit100_txt
            // 
            this.dijit100_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dijit100_txt.Location = new System.Drawing.Point(63, 290);
            this.dijit100_txt.Name = "dijit100_txt";
            this.dijit100_txt.Size = new System.Drawing.Size(37, 36);
            this.dijit100_txt.TabIndex = 15;
            // 
            // dijit1000_txt
            // 
            this.dijit1000_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dijit1000_txt.Location = new System.Drawing.Point(20, 290);
            this.dijit1000_txt.Name = "dijit1000_txt";
            this.dijit1000_txt.Size = new System.Drawing.Size(37, 36);
            this.dijit1000_txt.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 541);
            this.Controls.Add(this.computer_groupbox);
            this.Controls.Add(this.user_groupbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.user_groupbox.ResumeLayout(false);
            this.user_groupbox.PerformLayout();
            this.computer_groupbox.ResumeLayout(false);
            this.computer_groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox pc_txt;
        private System.Windows.Forms.RichTextBox user_txt;
        private System.Windows.Forms.Button zero_btn;
        private System.Windows.Forms.Button one_btn;
        private System.Windows.Forms.Button two_btn;
        private System.Windows.Forms.Button three_btn;
        private System.Windows.Forms.Button four_btn;
        private System.Windows.Forms.Button nine_btn;
        private System.Windows.Forms.Button eigth_btn;
        private System.Windows.Forms.Button seven_btn;
        private System.Windows.Forms.Button six_btn;
        private System.Windows.Forms.Button five_btn;
        private System.Windows.Forms.Button plus_btn;
        private System.Windows.Forms.TextBox plus_txt;
        private System.Windows.Forms.TextBox minus_txt;
        private System.Windows.Forms.Button minus_btn;
        private System.Windows.Forms.Button enter_user_btn;
        private System.Windows.Forms.GroupBox user_groupbox;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.GroupBox computer_groupbox;
        private System.Windows.Forms.Button enter_pc_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.TextBox dijit1_txt;
        private System.Windows.Forms.TextBox dijit10_txt;
        private System.Windows.Forms.TextBox dijit100_txt;
        private System.Windows.Forms.TextBox dijit1000_txt;
    }
}

