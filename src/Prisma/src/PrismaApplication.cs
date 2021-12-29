using Prisma.src.Model.Buttons;
using Prisma.src.Model.ColorUtils;
using Prisma.src.Model.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;



namespace Prisma {
    public partial class PrismaApplication: Form {

        private int initialMousePositionX;
        private int initialMousePositionY;

        private bool draggingScreen = false;


        public PrismaApplication(){
            InitializeComponent();

        }

        private void closeWindow(object sender, EventArgs e) {
            this.Close();

        }

        private void minimizeWindow(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;

        }

        private void startDragScreen(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                this.draggingScreen = true;

                this.initialMousePositionX = MousePosition.X;
                this.initialMousePositionY = MousePosition.Y;

            }

        }

        private void stopDragScreen(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                this.draggingScreen = false;

            }

        }

        private void moveScreen(object sender, MouseEventArgs e) {
            if (this.draggingScreen) {
                int screenX = this.Location.X + (MousePosition.X - this.initialMousePositionX);
                int screenY = this.Location.Y + (MousePosition.Y - this.initialMousePositionY);

                this.initialMousePositionX = MousePosition.X;
                this.initialMousePositionY = MousePosition.Y;

                this.Location = new Point(screenX, screenY);

            }
            
        }

        private void Form1_Load(object sender, EventArgs e) {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e) {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void hoverEnterButton(object sender, EventArgs e) {
            ButtonsHover.hoverEnter(sender);

        }

        private void hoverExitButton(object sender, EventArgs e) {
            ButtonsHover.hoverExit(sender);
            
        }

        private void iconPictureBox1_Click_1(object sender, EventArgs e) {

        }

        private void iconButton1_Click(object sender, EventArgs e) {

        }

        private void hoverEnterParent(object sender, EventArgs e) {
            Control targetElement = sender as Control;

            Control targetParent = targetElement.Parent;

            ButtonsHover.hoverEnter(targetParent);

        }

        private void hoverExitParent(object sender, EventArgs e) {
            Control targetElement = sender as Control;

            Control targetParent = targetElement.Parent;

            ButtonsHover.hoverExit(targetParent);

        }

        private void paintTopBar(object sender, PaintEventArgs e) {
            Dictionary<Color, float> sortedDictionary = TopBarProperties.colorsGradient;

            LinearGradientBrush brush = GradientBuilder.buildGradientBrush(this.ClientRectangle, sortedDictionary, 0);

            e.Graphics.FillRectangle(brush, this.ClientRectangle);

        }

    }

}
