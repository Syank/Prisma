namespace Prisma {
    partial class PrismaApplication {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();

            }

            base.Dispose(disposing);

        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.MinimizeWindowButton = new FontAwesome.Sharp.IconButton();
            this.CloseWindowButton = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.MenuOptionPasswordBank = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.TopBar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.MenuOptionPasswordBank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prisma";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Gem;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 24;
            this.iconPictureBox1.Location = new System.Drawing.Point(6, 6);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(24, 24);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click_1);
            // 
            // MinimizeWindowButton
            // 
            this.MinimizeWindowButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeWindowButton.FlatAppearance.BorderSize = 0;
            this.MinimizeWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeWindowButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinimizeWindowButton.IconColor = System.Drawing.Color.White;
            this.MinimizeWindowButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeWindowButton.IconSize = 16;
            this.MinimizeWindowButton.Location = new System.Drawing.Point(864, 0);
            this.MinimizeWindowButton.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeWindowButton.Name = "MinimizeWindowButton";
            this.MinimizeWindowButton.Size = new System.Drawing.Size(48, 30);
            this.MinimizeWindowButton.TabIndex = 2;
            this.MinimizeWindowButton.UseVisualStyleBackColor = false;
            this.MinimizeWindowButton.Click += new System.EventHandler(this.minimizeWindow);
            this.MinimizeWindowButton.MouseEnter += new System.EventHandler(this.hoverEnterButton);
            this.MinimizeWindowButton.MouseLeave += new System.EventHandler(this.hoverExitButton);
            // 
            // CloseWindowButton
            // 
            this.CloseWindowButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseWindowButton.FlatAppearance.BorderSize = 0;
            this.CloseWindowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseWindowButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CloseWindowButton.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.CloseWindowButton.IconColor = System.Drawing.Color.White;
            this.CloseWindowButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseWindowButton.IconSize = 16;
            this.CloseWindowButton.Location = new System.Drawing.Point(912, 0);
            this.CloseWindowButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseWindowButton.Name = "CloseWindowButton";
            this.CloseWindowButton.Size = new System.Drawing.Size(48, 35);
            this.CloseWindowButton.TabIndex = 1;
            this.CloseWindowButton.UseVisualStyleBackColor = false;
            this.CloseWindowButton.Click += new System.EventHandler(this.closeWindow);
            this.CloseWindowButton.MouseEnter += new System.EventHandler(this.hoverEnterButton);
            this.CloseWindowButton.MouseLeave += new System.EventHandler(this.hoverExitButton);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel4.Controls.Add(this.MenuOptionPasswordBank);
            this.panel4.Location = new System.Drawing.Point(0, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 510);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.paintMenu);
            // 
            // MenuOptionPasswordBank
            // 
            this.MenuOptionPasswordBank.Controls.Add(this.label2);
            this.MenuOptionPasswordBank.Controls.Add(this.iconPictureBox2);
            this.MenuOptionPasswordBank.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuOptionPasswordBank.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuOptionPasswordBank.Location = new System.Drawing.Point(0, 0);
            this.MenuOptionPasswordBank.Name = "MenuOptionPasswordBank";
            this.MenuOptionPasswordBank.Size = new System.Drawing.Size(200, 61);
            this.MenuOptionPasswordBank.TabIndex = 3;
            this.MenuOptionPasswordBank.MouseEnter += new System.EventHandler(this.hoverEnterButton);
            this.MenuOptionPasswordBank.MouseLeave += new System.EventHandler(this.hoverExitButton);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(76, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Banco de senhas";
            this.label2.MouseEnter += new System.EventHandler(this.hoverEnterParent);
            this.label2.MouseLeave += new System.EventHandler(this.hoverExitParent);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.iconPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconPictureBox2.Enabled = false;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 40;
            this.iconPictureBox2.Location = new System.Drawing.Point(12, 14);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(41, 40);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox2.TabIndex = 3;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.MouseEnter += new System.EventHandler(this.hoverEnterParent);
            this.iconPictureBox2.MouseLeave += new System.EventHandler(this.hoverExitParent);
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TopBar.Controls.Add(this.MinimizeWindowButton);
            this.TopBar.Controls.Add(this.label1);
            this.TopBar.Controls.Add(this.CloseWindowButton);
            this.TopBar.Controls.Add(this.iconPictureBox1);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Margin = new System.Windows.Forms.Padding(0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(960, 30);
            this.TopBar.TabIndex = 4;
            this.TopBar.Paint += new System.Windows.Forms.PaintEventHandler(this.paintTopBar);
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.startDragScreen);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveScreen);
            this.TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.stopDragScreen);
            // 
            // PrismaApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.TopBar);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrismaApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prisma";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaptionText;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.MenuOptionPasswordBank.ResumeLayout(false);
            this.MenuOptionPasswordBank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.TopBar.ResumeLayout(false);
            this.TopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton MinimizeWindowButton;
        private FontAwesome.Sharp.IconButton CloseWindowButton;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel MenuOptionPasswordBank;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Panel TopBar;
    }

}
