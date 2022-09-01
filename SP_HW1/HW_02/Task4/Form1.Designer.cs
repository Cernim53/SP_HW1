namespace Task4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnNotepad = new System.Windows.Forms.Button();
            this.tbNameProc = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStopProc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lRes = new System.Windows.Forms.Label();
            this.btnStRes = new System.Windows.Forms.Button();
            this.btnQuantity = new System.Windows.Forms.Button();
            this.lQuentity = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbWord = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNotepad
            // 
            this.btnNotepad.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNotepad.Location = new System.Drawing.Point(166, 12);
            this.btnNotepad.Name = "btnNotepad";
            this.btnNotepad.Size = new System.Drawing.Size(138, 70);
            this.btnNotepad.TabIndex = 0;
            this.btnNotepad.Text = "notepad";
            this.btnNotepad.UseVisualStyleBackColor = true;
            this.btnNotepad.Click += new System.EventHandler(this.btn_Click);
            // 
            // tbNameProc
            // 
            this.tbNameProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNameProc.Location = new System.Drawing.Point(310, 12);
            this.tbNameProc.Name = "tbNameProc";
            this.tbNameProc.Size = new System.Drawing.Size(199, 26);
            this.tbNameProc.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(310, 44);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(199, 38);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Запуск";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnStopProc
            // 
            this.btnStopProc.Enabled = false;
            this.btnStopProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStopProc.ForeColor = System.Drawing.Color.Red;
            this.btnStopProc.Location = new System.Drawing.Point(515, 12);
            this.btnStopProc.Name = "btnStopProc";
            this.btnStopProc.Size = new System.Drawing.Size(198, 70);
            this.btnStopProc.TabIndex = 6;
            this.btnStopProc.Text = "Kill";
            this.btnStopProc.UseVisualStyleBackColor = true;
            this.btnStopProc.Click += new System.EventHandler(this.btnStopProc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Task 1-2";
            // 
            // Status
            // 
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status.Location = new System.Drawing.Point(719, 13);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(283, 69);
            this.Status.TabIndex = 8;
            this.Status.Text = "Приложение запущено";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "Task 3";
            // 
            // tbA
            // 
            this.tbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbA.Location = new System.Drawing.Point(166, 143);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(138, 38);
            this.tbA.TabIndex = 10;
            this.tbA.Text = "7";
            this.tbA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(310, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "+";
            // 
            // tbB
            // 
            this.tbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbB.Location = new System.Drawing.Point(343, 143);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(138, 38);
            this.tbB.TabIndex = 12;
            this.tbB.Text = "3";
            this.tbB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(610, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "=";
            // 
            // lRes
            // 
            this.lRes.AutoSize = true;
            this.lRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lRes.Location = new System.Drawing.Point(523, 149);
            this.lRes.Name = "lRes";
            this.lRes.Size = new System.Drawing.Size(0, 31);
            this.lRes.TabIndex = 14;
            // 
            // btnStRes
            // 
            this.btnStRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStRes.Location = new System.Drawing.Point(711, 140);
            this.btnStRes.Name = "btnStRes";
            this.btnStRes.Size = new System.Drawing.Size(198, 42);
            this.btnStRes.TabIndex = 15;
            this.btnStRes.Text = "Result";
            this.btnStRes.UseVisualStyleBackColor = true;
            this.btnStRes.Click += new System.EventHandler(this.btnStRes_Click);
            // 
            // btnQuantity
            // 
            this.btnQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnQuantity.Location = new System.Drawing.Point(711, 238);
            this.btnQuantity.Name = "btnQuantity";
            this.btnQuantity.Size = new System.Drawing.Size(198, 74);
            this.btnQuantity.TabIndex = 22;
            this.btnQuantity.Text = "Result quentity";
            this.btnQuantity.UseVisualStyleBackColor = true;
            this.btnQuantity.Click += new System.EventHandler(this.btnQuantity_Click);
            // 
            // lQuentity
            // 
            this.lQuentity.AutoSize = true;
            this.lQuentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lQuentity.Location = new System.Drawing.Point(646, 257);
            this.lQuentity.Name = "lQuentity";
            this.lQuentity.Size = new System.Drawing.Size(0, 31);
            this.lQuentity.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(423, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 31);
            this.label6.TabIndex = 20;
            this.label6.Text = "path";
            // 
            // tbPath
            // 
            this.tbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPath.Location = new System.Drawing.Point(324, 254);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(269, 38);
            this.tbPath.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(197, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 31);
            this.label7.TabIndex = 18;
            this.label7.Text = "word";
            // 
            // tbWord
            // 
            this.tbWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWord.Location = new System.Drawing.Point(166, 254);
            this.tbWord.Name = "tbWord";
            this.tbWord.Size = new System.Drawing.Size(138, 38);
            this.tbWord.TabIndex = 17;
            this.tbWord.Text = "bicycle";
            this.tbWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(8, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 39);
            this.label8.TabIndex = 16;
            this.label8.Text = "Task 4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(938, 324);
            this.Controls.Add(this.btnQuantity);
            this.Controls.Add(this.lQuentity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbWord);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnStRes);
            this.Controls.Add(this.lRes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStopProc);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbNameProc);
            this.Controls.Add(this.btnNotepad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNotepad;
        private System.Windows.Forms.TextBox tbNameProc;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStopProc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lRes;
        private System.Windows.Forms.Button btnStRes;
        private System.Windows.Forms.Button btnQuantity;
        private System.Windows.Forms.Label lQuentity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbWord;
        private System.Windows.Forms.Label label8;
    }
}

