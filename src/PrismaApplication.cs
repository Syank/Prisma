using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Prisma.src.Model.Buttons;



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

        private void hoverEnterCloseButton(object sender, EventArgs e) {
            ButtonsHover.hoverEnter(sender);

        }

        private void hoverExitCloseButton(object sender, EventArgs e) {
            ButtonsHover.hoverExit(sender);
            
        }

        private void iconPictureBox1_Click_1(object sender, EventArgs e) {

        }
    }

}
