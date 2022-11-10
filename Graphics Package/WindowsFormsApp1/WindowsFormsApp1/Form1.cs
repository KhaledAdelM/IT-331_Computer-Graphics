using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class GraphicsPackage : Form
    {
        public Point center = new Point(310, 210);
        algorithms algorithm = new algorithms();



        public GraphicsPackage()
        {
            InitializeComponent();
        }
        public void Shearing_Y(ref int X, ref int Y, int X_Shearing)
        {
            int x, y;
            x = X * 1;
            y = X * X_Shearing + Y;
            X = x;
            Y = y;
        }
        public void Shearing_X(ref int X, ref int Y, int Y_Shearing)
        {
            int x, y;
            x = X + Y_Shearing * Y;
            y = Y;
            X = x;
            Y = y;
        }

       




        private void drawDDA_Click(object sender, EventArgs e)
        {
            var pixelArt = panalPixel.CreateGraphics();
            try { 
            var pXStart = int.Parse(xStart.Text); // x0
            var pYStart = int.Parse(yStart.Text); // y0
            var pXEnd = int.Parse(xEnd.Text); // x end
            var pYEnd = int.Parse(yEnd.Text); // y end
                algorithm.LineDDA(pixelArt, center.X + pXStart, center.Y - pYStart, center.X + pXEnd, center.Y - pYEnd);
            }catch(FormatException ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void drawBresenham_Click(object sender, EventArgs e)
        {
           var pixelArt = panalPixel.CreateGraphics();
            try
            {
                var pXStart = int.Parse(xStart.Text); // x0
                var pYStart = int.Parse(yStart.Text); // y0
                var pXEnd = int.Parse(xEnd.Text); // x end
                var pYEnd = int.Parse(yEnd.Text); // y end
                algorithm.LineBresenham(pixelArt, center.X + pXStart, center.Y - pYStart, center.X + pXEnd, center.Y - pYEnd);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void circleBres_Click(object sender, EventArgs e)
        {
            var pixelArt = panalPixel.CreateGraphics();
            try
            {
                var xc = int.Parse(xcStart.Text);
                var yc = int.Parse(ycStart.Text);
                var rc = int.Parse(rCircle.Text);
                algorithm.circleBres(pixelArt, center.X + xc, center.Y - yc, rc);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void drawElipse_Click(object sender, EventArgs e)
        {
            var pixelArt = panalPixel.CreateGraphics();
            try
            {
                var erx = double.Parse(rx.Text);
                var ery = double.Parse(ry.Text);
                var ecx = double.Parse(cx.Text);
                var ecy = double.Parse(cy.Text);

                algorithm.elipse(pixelArt,  erx,  ery,   ecx , ecy);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void translation2D_Click(object sender, EventArgs e)
        {
            var pixelArt = panalPixel.CreateGraphics();
            int itx = int.Parse(tx.Text);
            int ity = int.Parse(ty.Text);
            var x1 = int.Parse(textX1.Text);
            var y1 = int.Parse(textY1.Text);
            var xWidth = int.Parse(textWidth.Text);
            var yLenght = int.Parse(textLenght.Text);
            algorithm.translation2D(pixelArt, x1, y1, itx, ity, xWidth, yLenght);
        }

        private void rotate2D_Click(object sender, EventArgs e)
        {
            var pixelArt = panalPixel.CreateGraphics();
            var x1 = int.Parse(textX1.Text);
            var y1 = int.Parse(textY1.Text);
            var xWidth = int.Parse(textWidth.Text);
            var yLenght = int.Parse(textLenght.Text);
            int angel = Convert.ToInt32(textAngle.Text);
            algorithm.rotation2D(pixelArt,  x1,  y1,  xWidth,  yLenght,  angel);

        }

        private void Draw2D_Click(object sender, EventArgs e)
        {
            var pixelArt = panalPixel.CreateGraphics();
            var x1 = int.Parse(textX1.Text);
            var y1 = int.Parse(textY1.Text);
            var xWidth = int.Parse(textWidth.Text);
            var yLenght = int.Parse(textLenght.Text);
            algorithm.LineBresenham(pixelArt, center.X + x1, center.Y - y1, center.X + x1, center.Y - (y1+ yLenght));
            algorithm.LineBresenham(pixelArt, center.X + x1, center.Y - (y1+yLenght), center.X + (x1+ xWidth), center.Y - (y1+ yLenght));
            algorithm.LineBresenham(pixelArt, center.X + (x1 + xWidth), center.Y - (y1 + yLenght), center.X + (x1+ xWidth), center.Y - y1);
            algorithm.LineBresenham(pixelArt, center.X + (x1 + xWidth), center.Y - y1, center.X + x1, center.Y - y1);
        }

        private void scaling2D_Click(object sender, EventArgs e)
        {
            var pixelArt = panalPixel.CreateGraphics();
            int scX = int.Parse(tx.Text);
            int scY = int.Parse(ty.Text);
            var x1 = int.Parse(textX1.Text);
            var y1 = int.Parse(textY1.Text) ;
            var xWidth = int.Parse(textWidth.Text) ;
            var yLenght = int.Parse(textLenght.Text);

            algorithm.scaling2D(pixelArt, x1, y1, scX, scY, xWidth, yLenght);
        }

        private void GraphicsPackage_Load(object sender, EventArgs e)
        {

        }

        private void shearingD2_Click(object sender, EventArgs e)
        {
            
        }

        private void panalPixel_Paint(object sender, PaintEventArgs e)
        {
            var g = panalPixel.CreateGraphics();
            Pen pen = new Pen(Color.DarkSlateBlue);


            Point p1 = new Point(center.X + 400, center.Y);
            Point p2 = new Point(center.X - 400, center.Y);
            Point p3 = new Point(center.X, center.Y + 400);
            Point p4 = new Point(center.X, center.Y - 400);

            g.DrawLine(pen, p1, p2);
            g.DrawLine(pen, p3, p4);
        }
 

        private void overX_Click(object sender, EventArgs e)
        {
            if (lineOver.Checked == true)
            {
                var pixelArt = panalPixel.CreateGraphics();
                try
                {
                    var pXStart = int.Parse(xStart.Text); // x0
                    var pYStart = int.Parse(yStart.Text); // y0
                    var pXEnd = int.Parse(xEnd.Text); // x end
                    var pYEnd = int.Parse(yEnd.Text); // y end

                    algorithm.overX_Line(pixelArt, pXStart, pYStart, pXEnd, pYEnd);              }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
               
            } 
            else if (Over2D.Checked == true)
            {
                var pixelArt = panalPixel.CreateGraphics();
                var x1 = int.Parse(textX1.Text);
                var y1 = int.Parse(textY1.Text);
                var xWidth = int.Parse(textWidth.Text);
                var yLenght = int.Parse(textLenght.Text);
                algorithm.overX_2D(pixelArt,  x1,  y1,  xWidth,  yLenght);
            }
        }

        private void overY_Click(object sender, EventArgs e)
        {
            if (lineOver.Checked == true)
            {
                var pixelArt = panalPixel.CreateGraphics();
                try
                {
                    var pXStart = int.Parse(xStart.Text); // x0
                    var pYStart = int.Parse(yStart.Text); // y0
                    var pXEnd = int.Parse(xEnd.Text); // x end
                    var pYEnd = int.Parse(yEnd.Text); // y end

                    algorithm.overY_Line(pixelArt, pXStart, pYStart, pXEnd, pYEnd);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else if (Over2D.Checked == true)
            {
                var pixelArt = panalPixel.CreateGraphics();
                var x1 = int.Parse(textX1.Text);
                var y1 = int.Parse(textY1.Text);
                var xWidth = int.Parse(textWidth.Text);
                var yLenght = int.Parse(textLenght.Text);
                algorithm.overY_2D(pixelArt, x1, y1, xWidth, yLenght);
            }
        }

        private void overOrigin_Click(object sender, EventArgs e)
        {
            if (lineOver.Checked == true)
            {
                var pixelArt = panalPixel.CreateGraphics();
                try
                {
                    var pXStart = int.Parse(xStart.Text); // x0
                    var pYStart = int.Parse(yStart.Text); // y0
                    var pXEnd = int.Parse(xEnd.Text); // x end
                    var pYEnd = int.Parse(yEnd.Text); // y end

                    algorithm.overOrigin_Line(pixelArt, pXStart, pYStart, pXEnd, pYEnd);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else if (Over2D.Checked == true)
            {
                var pixelArt = panalPixel.CreateGraphics();
                var x1 = int.Parse(textX1.Text);
                var y1 = int.Parse(textY1.Text);
                var xWidth = int.Parse(textWidth.Text);
                var yLenght = int.Parse(textLenght.Text);
                algorithm.overOrigin_2D(pixelArt, x1, y1, xWidth, yLenght);
            }
        }

        private void shearX_Click(object sender, EventArgs e)
        {
            var pixelArt = panalPixel.CreateGraphics();
            var x1 = int.Parse(textX1.Text);
            var y1 = int.Parse(textY1.Text);
            var xWidth = int.Parse(textWidth.Text);
            var yLenght = int.Parse(textLenght.Text);
            int Shearing_shx = Convert.ToInt32(sX.Text);

            algorithm.shearX(pixelArt, x1, y1, Shearing_shx, xWidth, yLenght);
           
        }

        private void shearY_Click(object sender, EventArgs e)
        {
            var pixelArt = panalPixel.CreateGraphics();
            var x1 = int.Parse(textX1.Text);
            var y1 = int.Parse(textY1.Text);
            var xWidth = int.Parse(textWidth.Text);
            var yLenght = int.Parse(textLenght.Text);

            int Shearing_shy = Convert.ToInt32(sY.Text);

            algorithm.shearY(pixelArt,  x1,  y1,  Shearing_shy,  xWidth,  yLenght);

        }

        private void ClearDraw_Click(object sender, EventArgs e)
        {
            panalPixel.Refresh();
        }
    }
}
