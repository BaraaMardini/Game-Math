namespace لعبة_Math_Game
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LbNumberQuestions = new System.Windows.Forms.Label();
            this.RbNumber3 = new System.Windows.Forms.RadioButton();
            this.RbNumber10 = new System.Windows.Forms.RadioButton();
            this.RbNumber15 = new System.Windows.Forms.RadioButton();
            this.RbNumber5 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LbQuestionsLevel = new System.Windows.Forms.Label();
            this.CbQuestionsLevel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbOperationType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RbStartGame = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.TbTextQuestion = new System.Windows.Forms.TextBox();
            this.LbNextQuestion = new System.Windows.Forms.Label();
            this.AnswerQuestion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LbCheakAnswer = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TbAnswerTrue = new System.Windows.Forms.TextBox();
            this.TbAnswerFalse = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LbTimer = new System.Windows.Forms.Label();
            this.LbRstartGame = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(1051, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 80);
            this.label1.TabIndex = 2;
            this.label1.Text = "MATH GAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(22, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(158, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 34);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Baraa Mardini";
            // 
            // LbNumberQuestions
            // 
            this.LbNumberQuestions.AutoSize = true;
            this.LbNumberQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNumberQuestions.ForeColor = System.Drawing.Color.Maroon;
            this.LbNumberQuestions.Location = new System.Drawing.Point(23, 95);
            this.LbNumberQuestions.Name = "LbNumberQuestions";
            this.LbNumberQuestions.Size = new System.Drawing.Size(275, 32);
            this.LbNumberQuestions.TabIndex = 5;
            this.LbNumberQuestions.Text = "Number Questions:";
            // 
            // RbNumber3
            // 
            this.RbNumber3.AutoSize = true;
            this.RbNumber3.ForeColor = System.Drawing.Color.Red;
            this.RbNumber3.Location = new System.Drawing.Point(14, 22);
            this.RbNumber3.Name = "RbNumber3";
            this.RbNumber3.Size = new System.Drawing.Size(35, 20);
            this.RbNumber3.TabIndex = 10;
            this.RbNumber3.TabStop = true;
            this.RbNumber3.Text = "3";
            this.RbNumber3.UseVisualStyleBackColor = true;
            this.RbNumber3.CheckedChanged += new System.EventHandler(this.RbNumber3_CheckedChanged);
            // 
            // RbNumber10
            // 
            this.RbNumber10.AutoSize = true;
            this.RbNumber10.ForeColor = System.Drawing.Color.Red;
            this.RbNumber10.Location = new System.Drawing.Point(138, 21);
            this.RbNumber10.Name = "RbNumber10";
            this.RbNumber10.Size = new System.Drawing.Size(42, 20);
            this.RbNumber10.TabIndex = 11;
            this.RbNumber10.TabStop = true;
            this.RbNumber10.Text = "10";
            this.RbNumber10.UseVisualStyleBackColor = true;
            this.RbNumber10.CheckedChanged += new System.EventHandler(this.RbNumber10_CheckedChanged);
            // 
            // RbNumber15
            // 
            this.RbNumber15.AutoSize = true;
            this.RbNumber15.ForeColor = System.Drawing.Color.Red;
            this.RbNumber15.Location = new System.Drawing.Point(203, 21);
            this.RbNumber15.Name = "RbNumber15";
            this.RbNumber15.Size = new System.Drawing.Size(42, 20);
            this.RbNumber15.TabIndex = 12;
            this.RbNumber15.TabStop = true;
            this.RbNumber15.Text = "15";
            this.RbNumber15.UseVisualStyleBackColor = true;
            this.RbNumber15.CheckedChanged += new System.EventHandler(this.RbNumber15_CheckedChanged);
            // 
            // RbNumber5
            // 
            this.RbNumber5.AutoSize = true;
            this.RbNumber5.ForeColor = System.Drawing.Color.Red;
            this.RbNumber5.Location = new System.Drawing.Point(78, 22);
            this.RbNumber5.Name = "RbNumber5";
            this.RbNumber5.Size = new System.Drawing.Size(35, 20);
            this.RbNumber5.TabIndex = 13;
            this.RbNumber5.TabStop = true;
            this.RbNumber5.Text = "5";
            this.RbNumber5.UseVisualStyleBackColor = true;
            this.RbNumber5.CheckedChanged += new System.EventHandler(this.RbNumber5_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbNumber10);
            this.groupBox1.Controls.Add(this.RbNumber3);
            this.groupBox1.Controls.Add(this.RbNumber5);
            this.groupBox1.Controls.Add(this.RbNumber15);
            this.groupBox1.Location = new System.Drawing.Point(332, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 58);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // LbQuestionsLevel
            // 
            this.LbQuestionsLevel.AutoSize = true;
            this.LbQuestionsLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbQuestionsLevel.ForeColor = System.Drawing.Color.Maroon;
            this.LbQuestionsLevel.Location = new System.Drawing.Point(23, 172);
            this.LbQuestionsLevel.Name = "LbQuestionsLevel";
            this.LbQuestionsLevel.Size = new System.Drawing.Size(242, 32);
            this.LbQuestionsLevel.TabIndex = 16;
            this.LbQuestionsLevel.Text = "Questions  Level";
            // 
            // CbQuestionsLevel
            // 
            this.CbQuestionsLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbQuestionsLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbQuestionsLevel.ForeColor = System.Drawing.Color.IndianRed;
            this.CbQuestionsLevel.FormattingEnabled = true;
            this.CbQuestionsLevel.Items.AddRange(new object[] {
            "Easy",
            "Med",
            "Hard",
            "Mix"});
            this.CbQuestionsLevel.Location = new System.Drawing.Point(285, 175);
            this.CbQuestionsLevel.Name = "CbQuestionsLevel";
            this.CbQuestionsLevel.Size = new System.Drawing.Size(121, 33);
            this.CbQuestionsLevel.TabIndex = 17;
            this.CbQuestionsLevel.SelectedIndexChanged += new System.EventHandler(this.CbQuestionsLevel_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(23, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 32);
            this.label5.TabIndex = 18;
            this.label5.Text = "Operation Type";
            // 
            // CbOperationType
            // 
            this.CbOperationType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbOperationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbOperationType.ForeColor = System.Drawing.Color.IndianRed;
            this.CbOperationType.FormattingEnabled = true;
            this.CbOperationType.Items.AddRange(new object[] {
            "Add",
            "Sub",
            "Mul",
            "Div",
            "Mix"});
            this.CbOperationType.Location = new System.Drawing.Point(285, 238);
            this.CbOperationType.Name = "CbOperationType";
            this.CbOperationType.Size = new System.Drawing.Size(121, 33);
            this.CbOperationType.TabIndex = 19;
            this.CbOperationType.SelectedIndexChanged += new System.EventHandler(this.CbOperationType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(688, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 46);
            this.label3.TabIndex = 22;
            this.label3.Text = "Start Game";
            // 
            // RbStartGame
            // 
            this.RbStartGame.AutoSize = true;
            this.RbStartGame.ForeColor = System.Drawing.Color.Red;
            this.RbStartGame.Location = new System.Drawing.Point(796, 95);
            this.RbStartGame.Name = "RbStartGame";
            this.RbStartGame.Size = new System.Drawing.Size(17, 16);
            this.RbStartGame.TabIndex = 23;
            this.RbStartGame.UseVisualStyleBackColor = true;
            this.RbStartGame.CheckedChanged += new System.EventHandler(this.RbStartGame_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(563, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 32);
            this.label4.TabIndex = 24;
            this.label4.Text = "Question:";
            // 
            // TbTextQuestion
            // 
            this.TbTextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbTextQuestion.Location = new System.Drawing.Point(761, 209);
            this.TbTextQuestion.Name = "TbTextQuestion";
            this.TbTextQuestion.Size = new System.Drawing.Size(254, 34);
            this.TbTextQuestion.TabIndex = 25;
            this.TbTextQuestion.TextChanged += new System.EventHandler(this.TbTextQuestion_TextChanged);
            // 
            // LbNextQuestion
            // 
            this.LbNextQuestion.AutoSize = true;
            this.LbNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNextQuestion.ForeColor = System.Drawing.Color.IndianRed;
            this.LbNextQuestion.Location = new System.Drawing.Point(1085, 211);
            this.LbNextQuestion.Name = "LbNextQuestion";
            this.LbNextQuestion.Size = new System.Drawing.Size(207, 32);
            this.LbNextQuestion.TabIndex = 26;
            this.LbNextQuestion.Text = "Next Question";
            this.LbNextQuestion.Click += new System.EventHandler(this.LbNextQuestion_Click);
            // 
            // AnswerQuestion
            // 
            this.AnswerQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerQuestion.Location = new System.Drawing.Point(761, 353);
            this.AnswerQuestion.Name = "AnswerQuestion";
            this.AnswerQuestion.Size = new System.Drawing.Size(254, 34);
            this.AnswerQuestion.TabIndex = 27;
            this.AnswerQuestion.TextChanged += new System.EventHandler(this.AnswerQuestion_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(563, 353);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 32);
            this.label7.TabIndex = 28;
            this.label7.Text = "Answer:";
            // 
            // LbCheakAnswer
            // 
            this.LbCheakAnswer.AutoSize = true;
            this.LbCheakAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCheakAnswer.ForeColor = System.Drawing.Color.IndianRed;
            this.LbCheakAnswer.Location = new System.Drawing.Point(1085, 355);
            this.LbCheakAnswer.Name = "LbCheakAnswer";
            this.LbCheakAnswer.Size = new System.Drawing.Size(209, 32);
            this.LbCheakAnswer.TabIndex = 29;
            this.LbCheakAnswer.Text = "Cheak Answer";
            this.LbCheakAnswer.Click += new System.EventHandler(this.LbCheakAnswer_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(12, 476);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 32);
            this.label8.TabIndex = 30;
            this.label8.Text = "Answer True";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(258, 427);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 32);
            this.label9.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(12, 562);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 32);
            this.label10.TabIndex = 32;
            this.label10.Text = "Answer False";
            // 
            // TbAnswerTrue
            // 
            this.TbAnswerTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbAnswerTrue.Location = new System.Drawing.Point(264, 476);
            this.TbAnswerTrue.Name = "TbAnswerTrue";
            this.TbAnswerTrue.Size = new System.Drawing.Size(48, 34);
            this.TbAnswerTrue.TabIndex = 33;
            this.TbAnswerTrue.TextChanged += new System.EventHandler(this.TbAnswerTrue_TextChanged);
            // 
            // TbAnswerFalse
            // 
            this.TbAnswerFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbAnswerFalse.Location = new System.Drawing.Point(264, 560);
            this.TbAnswerFalse.Name = "TbAnswerFalse";
            this.TbAnswerFalse.Size = new System.Drawing.Size(48, 34);
            this.TbAnswerFalse.TabIndex = 34;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LbTimer
            // 
            this.LbTimer.AutoSize = true;
            this.LbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTimer.ForeColor = System.Drawing.Color.Brown;
            this.LbTimer.Location = new System.Drawing.Point(1032, 129);
            this.LbTimer.Name = "LbTimer";
            this.LbTimer.Size = new System.Drawing.Size(36, 39);
            this.LbTimer.TabIndex = 35;
            this.LbTimer.Text = "0";
            // 
            // LbRstartGame
            // 
            this.LbRstartGame.AutoSize = true;
            this.LbRstartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRstartGame.Location = new System.Drawing.Point(967, 505);
            this.LbRstartGame.Name = "LbRstartGame";
            this.LbRstartGame.Size = new System.Drawing.Size(279, 46);
            this.LbRstartGame.TabIndex = 36;
            this.LbRstartGame.Text = "Restart Game";
            this.LbRstartGame.Click += new System.EventHandler(this.LbRstartGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1513, 711);
            this.Controls.Add(this.LbRstartGame);
            this.Controls.Add(this.LbTimer);
            this.Controls.Add(this.TbAnswerFalse);
            this.Controls.Add(this.TbAnswerTrue);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LbCheakAnswer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AnswerQuestion);
            this.Controls.Add(this.LbNextQuestion);
            this.Controls.Add(this.TbTextQuestion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RbStartGame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbOperationType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbQuestionsLevel);
            this.Controls.Add(this.LbQuestionsLevel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LbNumberQuestions);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LbNumberQuestions;
        private System.Windows.Forms.RadioButton RbNumber3;
        private System.Windows.Forms.RadioButton RbNumber10;
        private System.Windows.Forms.RadioButton RbNumber15;
        private System.Windows.Forms.RadioButton RbNumber5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LbQuestionsLevel;
        private System.Windows.Forms.ComboBox CbQuestionsLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbOperationType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RbStartGame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbTextQuestion;
        private System.Windows.Forms.Label LbNextQuestion;
        private System.Windows.Forms.TextBox AnswerQuestion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LbCheakAnswer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TbAnswerTrue;
        private System.Windows.Forms.TextBox TbAnswerFalse;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LbTimer;
        private System.Windows.Forms.Label LbRstartGame;
    }
}

