using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VerletClasses;
using VerletFunctions;

namespace VerletDraw
{
    public partial class Form1 : Form
    {
        #region Form Variables
        string errorMessage = string.Empty;
        bool noErrors = true;
        Graphics g;
        Font font = new Font("Courier New", 12.0f);
        // graphics variables
        Pen redPen = new Pen(Brushes.Red);
        Pen bluePen = new Pen(Brushes.Blue);
        int sf = 25; //scale factor to get better draw results
        //set maximums to keep on screen
        const int MaxY = 25;
        const int MaxX = 39;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            errorMsg.Text = string.Empty;
        }

        private void VBDraw_Click(object sender, EventArgs e)
        {
            //get dimensions of the PictureBox
            int pbx = VPictureBox.Size.Width;
            int pby = VPictureBox.Size.Height;
            //create a list of points to draw
            List<Vector2D> points = new List<Vector2D>();
            //validate input
            if(!Functions.IsFloat(VGy.Text.Trim())
                || !Functions.IsFloat(VOPx.Text.Trim())
                || !Functions.IsFloat(VOPy.Text.Trim())
                || !Functions.IsFloat(VOVx.Text.Trim())
                || !Functions.IsFloat(VOVy.Text.Trim()))
            {
                noErrors = false;
                errorMessage = "One or more inputs is/are invalid.";
            }
            else if (float.Parse(VOPx.Text.Trim()) > MaxX 
                || float.Parse(VOPy.Text.Trim()) > MaxY
                || float.Parse(VOPx.Text.Trim()) < 0
                || float.Parse(VOPy.Text.Trim())< 0)
            {
                noErrors = false;
                errorMessage = "Initial Position is out of bounds of the display";
            }
            else
            {
                noErrors = true;
                errorMessage = string.Empty;
            }//end validation

            if (noErrors)
            {
                //check to make sure gravityY is negative
                Vector2D gravity = new Vector2D(0.0f, float.Parse(VGy.Text.Trim()));
                if(gravity.Y > 0)
                {
                    gravity.Y *= -1;
                    VGy.Text = gravity.Y.ToString();
                }//end gravity check

                //create the initial point
                Vector2D originalPoint = new Vector2D(float.Parse(VOPx.Text.Trim()), float.Parse(VOPy.Text.Trim()));

                //create initial velocity
                Vector2D velocity = new Vector2D(float.Parse(VOVx.Text.Trim()), float.Parse(VOVy.Text.Trim()));

                //begin to draw
                g = Graphics.FromHwnd(VPictureBox.Handle);
                g.Clear(Color.White);
                //draw starting point
                points.Add(new Vector2D(float.Parse(VOPx.Text.Trim()), float.Parse(VOPy.Text.Trim())));
                g.DrawEllipse(redPen, float.Parse(VOPx.Text.Trim()) * sf, pby - float.Parse(VOPy.Text.Trim()) * sf, 5, 5);
                //get the points to draw
                List<Vector2D> drawPoints = Functions.VelocityVerletList(originalPoint, gravity, velocity, 0.01f);
                // draw the points
                foreach(Vector2D point in drawPoints)
                {
                    g.DrawEllipse(bluePen, point.X * sf, pby - point.Y * sf, 2, 2);
                }//end foreach

            }//eom
            errorMsg.Text = errorMessage;
        }//eom

        private void VBReset_Click(object sender, EventArgs e)
        {
            VGy.Text = "-9.81";
            VOPx.Text = "0.0";
            VOPy.Text = "10.0";
            VOVx.Text = "1.0";
            VOVy.Text = "10.0";
            VPictureBox.Image = null;
        }//eom
    }//eoc
}//eon
