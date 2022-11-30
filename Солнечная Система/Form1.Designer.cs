namespace Солнечная_Система
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.солнцеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kometaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crescentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 425);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.солнцеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // солнцеToolStripMenuItem
            // 
            this.солнцеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sunToolStripMenuItem,
            this.saturnToolStripMenuItem,
            this.kometaToolStripMenuItem,
            this.moonToolStripMenuItem,
            this.marsToolStripMenuItem,
            this.crescentToolStripMenuItem});
            this.солнцеToolStripMenuItem.Name = "солнцеToolStripMenuItem";
            this.солнцеToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.солнцеToolStripMenuItem.Text = "Выбор";
            this.солнцеToolStripMenuItem.Click += new System.EventHandler(this.Form1_Load);
            // 
            // sunToolStripMenuItem
            // 
            this.sunToolStripMenuItem.Name = "sunToolStripMenuItem";
            this.sunToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sunToolStripMenuItem.Text = "Sun";
            this.sunToolStripMenuItem.Click += new System.EventHandler(this.sunToolStripMenuItem_Click);
            // 
            // saturnToolStripMenuItem
            // 
            this.saturnToolStripMenuItem.Name = "saturnToolStripMenuItem";
            this.saturnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saturnToolStripMenuItem.Text = "Saturn";
            this.saturnToolStripMenuItem.Click += new System.EventHandler(this.saturnToolStripMenuItem_Click);
            // 
            // kometaToolStripMenuItem
            // 
            this.kometaToolStripMenuItem.Name = "kometaToolStripMenuItem";
            this.kometaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kometaToolStripMenuItem.Text = "Kometa";
            this.kometaToolStripMenuItem.Click += new System.EventHandler(this.kometaToolStripMenuItem_Click);
            // 
            // moonToolStripMenuItem
            // 
            this.moonToolStripMenuItem.Name = "moonToolStripMenuItem";
            this.moonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moonToolStripMenuItem.Text = "Moon";
            this.moonToolStripMenuItem.Click += new System.EventHandler(this.moonToolStripMenuItem_Click);
            // 
            // marsToolStripMenuItem
            // 
            this.marsToolStripMenuItem.Name = "marsToolStripMenuItem";
            this.marsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.marsToolStripMenuItem.Text = "Mars";
            this.marsToolStripMenuItem.Click += new System.EventHandler(this.marsToolStripMenuItem_Click);
            // 
            // crescentToolStripMenuItem
            // 
            this.crescentToolStripMenuItem.Name = "crescentToolStripMenuItem";
            this.crescentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crescentToolStripMenuItem.Text = "Crescent";
            this.crescentToolStripMenuItem.Click += new System.EventHandler(this.crescentToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem солнцеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kometaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crescentToolStripMenuItem;
    }
}

