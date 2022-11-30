
namespace archer
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
            this.START = new System.Windows.Forms.Button();
            this.ARCHER = new System.Windows.Forms.Label();
            this.fight = new System.Windows.Forms.Button();
            this.fight1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.player1name = new System.Windows.Forms.TextBox();
            this.player2name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.player1label = new System.Windows.Forms.Label();
            this.player2label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hpplayer1 = new System.Windows.Forms.Label();
            this.attackplayer1 = new System.Windows.Forms.Label();
            this.defenseplayer1 = new System.Windows.Forms.Label();
            this.hpplayer2 = new System.Windows.Forms.Label();
            this.attackplayer2 = new System.Windows.Forms.Label();
            this.defenseplayer2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // START
            // 
            this.START.Location = new System.Drawing.Point(349, 78);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(75, 23);
            this.START.TabIndex = 0;
            this.START.Text = "START";
            this.START.UseVisualStyleBackColor = true;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // ARCHER
            // 
            this.ARCHER.AutoSize = true;
            this.ARCHER.Font = new System.Drawing.Font("Blackadder ITC", 30F);
            this.ARCHER.Location = new System.Drawing.Point(324, 9);
            this.ARCHER.Name = "ARCHER";
            this.ARCHER.Size = new System.Drawing.Size(121, 51);
            this.ARCHER.TabIndex = 1;
            this.ARCHER.Text = "Archer";
            // 
            // fight
            // 
            this.fight.Location = new System.Drawing.Point(27, 116);
            this.fight.Name = "fight";
            this.fight.Size = new System.Drawing.Size(143, 55);
            this.fight.TabIndex = 2;
            this.fight.Text = "Стрелять";
            this.fight.UseVisualStyleBackColor = true;
            this.fight.Click += new System.EventHandler(this.fight_Click);
            // 
            // fight1
            // 
            this.fight1.Location = new System.Drawing.Point(626, 116);
            this.fight1.Name = "fight1";
            this.fight1.Size = new System.Drawing.Size(143, 55);
            this.fight1.TabIndex = 3;
            this.fight1.Text = "Стрелять";
            this.fight1.UseVisualStyleBackColor = true;
            this.fight1.Click += new System.EventHandler(this.fight1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(85, 93);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Зарядить";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(641, 93);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Зарядить";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // player1name
            // 
            this.player1name.Location = new System.Drawing.Point(256, 150);
            this.player1name.Name = "player1name";
            this.player1name.Size = new System.Drawing.Size(100, 20);
            this.player1name.TabIndex = 6;
            this.player1name.TextChanged += new System.EventHandler(this.player1_TextChanged);
            // 
            // player2name
            // 
            this.player2name.Location = new System.Drawing.Point(451, 150);
            this.player2name.Name = "player2name";
            this.player2name.Size = new System.Drawing.Size(100, 20);
            this.player2name.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(256, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите имена:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(256, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "HP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(515, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "HP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(256, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Attack";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(507, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Attack";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(256, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Defense";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(504, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Defense";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(333, 192);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 16;
            // 
            // player1label
            // 
            this.player1label.AutoSize = true;
            this.player1label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player1label.Location = new System.Drawing.Point(55, 178);
            this.player1label.Name = "player1label";
            this.player1label.Size = new System.Drawing.Size(57, 16);
            this.player1label.TabIndex = 17;
            this.player1label.Text = "Игрок 1";
            // 
            // player2label
            // 
            this.player2label.AutoSize = true;
            this.player2label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player2label.Location = new System.Drawing.Point(664, 178);
            this.player2label.Name = "player2label";
            this.player2label.Size = new System.Drawing.Size(57, 16);
            this.player2label.TabIndex = 18;
            this.player2label.Text = "Игрок 2";
            this.player2label.TextChanged += new System.EventHandler(this.player2label_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 50000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hpplayer1
            // 
            this.hpplayer1.AutoSize = true;
            this.hpplayer1.Location = new System.Drawing.Point(256, 248);
            this.hpplayer1.Name = "hpplayer1";
            this.hpplayer1.Size = new System.Drawing.Size(13, 13);
            this.hpplayer1.TabIndex = 19;
            this.hpplayer1.Text = "0";
            // 
            // attackplayer1
            // 
            this.attackplayer1.AutoSize = true;
            this.attackplayer1.Location = new System.Drawing.Point(259, 298);
            this.attackplayer1.Name = "attackplayer1";
            this.attackplayer1.Size = new System.Drawing.Size(13, 13);
            this.attackplayer1.TabIndex = 20;
            this.attackplayer1.Text = "0";
            // 
            // defenseplayer1
            // 
            this.defenseplayer1.AutoSize = true;
            this.defenseplayer1.Location = new System.Drawing.Point(259, 344);
            this.defenseplayer1.Name = "defenseplayer1";
            this.defenseplayer1.Size = new System.Drawing.Size(13, 13);
            this.defenseplayer1.TabIndex = 21;
            this.defenseplayer1.Text = "0";
            // 
            // hpplayer2
            // 
            this.hpplayer2.AutoSize = true;
            this.hpplayer2.Location = new System.Drawing.Point(526, 248);
            this.hpplayer2.Name = "hpplayer2";
            this.hpplayer2.Size = new System.Drawing.Size(13, 13);
            this.hpplayer2.TabIndex = 22;
            this.hpplayer2.Text = "0";
            // 
            // attackplayer2
            // 
            this.attackplayer2.AutoSize = true;
            this.attackplayer2.Location = new System.Drawing.Point(529, 298);
            this.attackplayer2.Name = "attackplayer2";
            this.attackplayer2.Size = new System.Drawing.Size(13, 13);
            this.attackplayer2.TabIndex = 23;
            this.attackplayer2.Text = "0";
            // 
            // defenseplayer2
            // 
            this.defenseplayer2.AutoSize = true;
            this.defenseplayer2.Location = new System.Drawing.Point(538, 344);
            this.defenseplayer2.Name = "defenseplayer2";
            this.defenseplayer2.Size = new System.Drawing.Size(13, 13);
            this.defenseplayer2.TabIndex = 24;
            this.defenseplayer2.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.defenseplayer2);
            this.Controls.Add(this.attackplayer2);
            this.Controls.Add(this.hpplayer2);
            this.Controls.Add(this.defenseplayer1);
            this.Controls.Add(this.attackplayer1);
            this.Controls.Add(this.hpplayer1);
            this.Controls.Add(this.player2label);
            this.Controls.Add(this.player1label);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player2name);
            this.Controls.Add(this.player1name);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.fight1);
            this.Controls.Add(this.fight);
            this.Controls.Add(this.ARCHER);
            this.Controls.Add(this.START);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button START;
        private System.Windows.Forms.Label ARCHER;
        private System.Windows.Forms.Button fight;
        private System.Windows.Forms.Button fight1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox player1name;
        private System.Windows.Forms.TextBox player2name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label player1label;
        private System.Windows.Forms.Label player2label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label hpplayer1;
        private System.Windows.Forms.Label attackplayer1;
        private System.Windows.Forms.Label defenseplayer1;
        private System.Windows.Forms.Label hpplayer2;
        private System.Windows.Forms.Label attackplayer2;
        private System.Windows.Forms.Label defenseplayer2;
        private System.Windows.Forms.Label label8;
    }
}

