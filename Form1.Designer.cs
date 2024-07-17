
namespace Decibel_Notepad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ChromiumPanel = new System.Windows.Forms.Panel();
            this.Window = new System.Windows.Forms.Panel();
            this.Cross = new System.Windows.Forms.PictureBox();
            this.WindowName = new System.Windows.Forms.Label();
            this.Maximize = new System.Windows.Forms.PictureBox();
            this.WindowsStateCounter = new System.Windows.Forms.Label();
            this.WindowMargin = new System.Windows.Forms.PictureBox();
            this.WindowLogo = new System.Windows.Forms.PictureBox();
            this.Window.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowMargin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ChromiumPanel
            // 
            this.ChromiumPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChromiumPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChromiumPanel.Location = new System.Drawing.Point(0, 25);
            this.ChromiumPanel.Name = "ChromiumPanel";
            this.ChromiumPanel.Size = new System.Drawing.Size(860, 600);
            this.ChromiumPanel.TabIndex = 0;
            // 
            // Window
            // 
            this.Window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.Window.Controls.Add(this.WindowLogo);
            this.Window.Controls.Add(this.WindowMargin);
            this.Window.Controls.Add(this.Maximize);
            this.Window.Controls.Add(this.Cross);
            this.Window.Controls.Add(this.WindowName);
            this.Window.Controls.Add(this.WindowsStateCounter);
            this.Window.Dock = System.Windows.Forms.DockStyle.Top;
            this.Window.Location = new System.Drawing.Point(0, 0);
            this.Window.Name = "Window";
            this.Window.Size = new System.Drawing.Size(860, 25);
            this.Window.TabIndex = 1;
            this.Window.Paint += new System.Windows.Forms.PaintEventHandler(this.Window_Paint);
            // 
            // Cross
            // 
            this.Cross.Dock = System.Windows.Forms.DockStyle.Right;
            this.Cross.Image = ((System.Drawing.Image)(resources.GetObject("Cross.Image")));
            this.Cross.Location = new System.Drawing.Point(835, 0);
            this.Cross.Name = "Cross";
            this.Cross.Size = new System.Drawing.Size(25, 25);
            this.Cross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Cross.TabIndex = 1;
            this.Cross.TabStop = false;
            this.Cross.Click += new System.EventHandler(this.Cross_Click);
            // 
            // WindowName
            // 
            this.WindowName.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WindowName.ForeColor = System.Drawing.Color.White;
            this.WindowName.Location = new System.Drawing.Point(25, 0);
            this.WindowName.Name = "WindowName";
            this.WindowName.Size = new System.Drawing.Size(148, 25);
            this.WindowName.TabIndex = 0;
            this.WindowName.Text = "Decibel Note [ Testing 2.0 ]";
            this.WindowName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Maximize
            // 
            this.Maximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.Maximize.Image = ((System.Drawing.Image)(resources.GetObject("Maximize.Image")));
            this.Maximize.Location = new System.Drawing.Point(810, 0);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(25, 25);
            this.Maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Maximize.TabIndex = 2;
            this.Maximize.TabStop = false;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // WindowsStateCounter
            // 
            this.WindowsStateCounter.AutoSize = true;
            this.WindowsStateCounter.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WindowsStateCounter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.WindowsStateCounter.Location = new System.Drawing.Point(525, 6);
            this.WindowsStateCounter.Name = "WindowsStateCounter";
            this.WindowsStateCounter.Size = new System.Drawing.Size(33, 13);
            this.WindowsStateCounter.TabIndex = 3;
            this.WindowsStateCounter.Text = "False";
            // 
            // WindowMargin
            // 
            this.WindowMargin.Dock = System.Windows.Forms.DockStyle.Left;
            this.WindowMargin.Location = new System.Drawing.Point(0, 0);
            this.WindowMargin.Name = "WindowMargin";
            this.WindowMargin.Size = new System.Drawing.Size(3, 25);
            this.WindowMargin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WindowMargin.TabIndex = 4;
            this.WindowMargin.TabStop = false;
            // 
            // WindowLogo
            // 
            this.WindowLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.WindowLogo.Image = ((System.Drawing.Image)(resources.GetObject("WindowLogo.Image")));
            this.WindowLogo.Location = new System.Drawing.Point(3, 0);
            this.WindowLogo.Name = "WindowLogo";
            this.WindowLogo.Size = new System.Drawing.Size(25, 25);
            this.WindowLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.WindowLogo.TabIndex = 5;
            this.WindowLogo.TabStop = false;
            this.WindowLogo.Click += new System.EventHandler(this.WindowLogo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 625);
            this.Controls.Add(this.ChromiumPanel);
            this.Controls.Add(this.Window);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decibel Note [ Testing 2.0 ]";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Window.ResumeLayout(false);
            this.Window.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowMargin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ChromiumPanel;
        private System.Windows.Forms.Panel Window;
        private System.Windows.Forms.Label WindowName;
        private System.Windows.Forms.PictureBox Cross;
        private System.Windows.Forms.PictureBox Maximize;
        private System.Windows.Forms.Label WindowsStateCounter;
        private System.Windows.Forms.PictureBox WindowMargin;
        private System.Windows.Forms.PictureBox WindowLogo;
    }
}

