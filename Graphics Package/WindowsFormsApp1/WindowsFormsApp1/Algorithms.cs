using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class algorithms
    {
        public Point center = new Point(310, 210);

        public void LineDDA(Graphics g, int x0, int y0, int xEnd, int yEnd)
        {
            var aBruch = Brushes.Black;
            int dx = xEnd - x0, dy = yEnd - y0, steps, k;
            float xIncrement, yIncrement, x = x0, y = y0;

            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);
            xIncrement = (float)(dx) / (float)(steps);
            yIncrement = (float)(dy) / (float)(steps);

            g.FillRectangle(aBruch, (int)Math.Round(x), (int)Math.Round(y), 2, 2);
            Console.WriteLine((int)Math.Round(x) + "  " + (int)Math.Round(y));
            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;
                g.FillRectangle(aBruch, (int)Math.Round(x), (int)Math.Round(y), 2, 2);
                Console.WriteLine((int)Math.Round(x) + "  " + (int)Math.Round(y));
            }
        }

        /*  Bresenham line-drawing procedure for |m| < 1.0.  */
        public void LineBresenham(Graphics g, int x, int y, int x2, int y2)
        {
            var aBruch = Brushes.Black;
            int w = x2 - x;
            int h = y2 - y;
            int dx1 = 0, dy1 = 0, dx2 = 0, dy2 = 0;
            if (w < 0) dx1 = -1; else if (w > 0) dx1 = 1;
            if (h < 0) dy1 = -1; else if (h > 0) dy1 = 1;
            if (w < 0) dx2 = -1; else if (w > 0) dx2 = 1;
            int longest = Math.Abs(w);
            int shortest = Math.Abs(h);
            if (!(longest > shortest))
            {
                longest = Math.Abs(h);
                shortest = Math.Abs(w);
                if (h < 0) dy2 = -1; else if (h > 0) dy2 = 1;
                dx2 = 0;
            }
            int numerator = longest >> 1;
            for (int i = 0; i <= longest; i++)
            {
                // putpixel(x, y, color);
                g.FillRectangle(aBruch, x, y, 2, 2);
                numerator += shortest;
                if (!(numerator < longest))
                {
                    numerator -= longest;
                    x += dx1;
                    y += dy1;
                }
                else
                {
                    x += dx2;
                    y += dy2;
                }
            }
        }

        // Function to put pixels
        // at subsequence points
        public void drawCircle(Graphics g, int xc, int yc, int x, int y)
        {
            var aBruch = Brushes.Black;
            g.FillRectangle(aBruch, xc + x, yc + y, 2, 2);
            g.FillRectangle(aBruch, xc - x, yc + y, 2, 2);
            g.FillRectangle(aBruch, xc + x, yc - y, 2, 2);
            g.FillRectangle(aBruch, xc - x, yc - y, 2, 2);
            g.FillRectangle(aBruch, xc + y, yc + x, 2, 2);
            g.FillRectangle(aBruch, xc - y, yc + x, 2, 2);
            g.FillRectangle(aBruch, xc + y, yc - x, 2, 2);
            g.FillRectangle(aBruch, xc - y, yc - x, 2, 2);
        }

        // Function for circle-generation
        // using Bresenham's algorithm
        public void circleBres(Graphics g, int xc, int yc, int r)
        {
            int x = 0, y = r;
            int d = 3 - 2 * r;
            drawCircle(g, xc, yc, x, y);
            while (y >= x)
            {
                // for each pixel we will
                // draw all eight pixels

                x++;

                // check for decision parameter
                // and correspondingly
                // update d, x, y
                if (d > 0)
                {
                    y--;
                    d = d + 4 * (x - y) + 10;
                }
                else
                    d = d + 4 * x + 6;
                drawCircle(g, xc, yc, x, y);
            }
        }

        public void elipse(Graphics g, double rx, double ry, double xc, double yc)
        {
            var aBrush = Brushes.Black;
            double dx, dy, d1, d2, x, y;
            x = 0;
            y = ry;
            d1 = (ry * ry) - (rx * rx * ry) +
                            (0.25f * rx * rx);
            dx = 2 * ry * ry * x;
            dy = 2 * rx * rx * y;
            while (dx < dy)
            {
                g.FillRectangle(aBrush, center.X + Convert.ToInt32(x + xc), center.Y - Convert.ToInt32(y + yc), 2, 2);
                g.FillRectangle(aBrush, center.X + Convert.ToInt32(-x + xc), center.Y - Convert.ToInt32(y + yc), 2, 2);
                g.FillRectangle(aBrush, center.X + Convert.ToInt32(x + xc), center.Y -Convert.ToInt32(-y + yc), 2, 2);
                g.FillRectangle(aBrush, center.X + Convert.ToInt32(-x + xc), center.Y - Convert.ToInt32(-y + yc), 2, 2);
                if (d1 < 0)
                {
                    x++;
                    dx = dx + (2 * ry * ry);
                    d1 = d1 + dx + (ry * ry);
                }
                else
                {
                    x++;
                    y--;
                    dx = dx + (2 * ry * ry);
                    dy = dy - (2 * rx * rx);
                    d1 = d1 + dx - dy + (ry * ry);
                }

            }
            d2 = ((ry * ry) * ((x + 0.5f) * (x + 0.5f)))
                + ((rx * rx) * ((y - 1) * (y - 1)))
                - (rx * rx * ry * ry);
            while (y >= 0)
            {
                g.FillRectangle(aBrush, center.X + Convert.ToInt32(x + xc), center.Y - Convert.ToInt32(y + yc), 2, 2);
                g.FillRectangle(aBrush, center.X + Convert.ToInt32(-x + xc), center.Y - Convert.ToInt32(y + yc), 2, 2);
                g.FillRectangle(aBrush, center.X + Convert.ToInt32(x + xc), center.Y - Convert.ToInt32(-y + yc), 2, 2);
                g.FillRectangle(aBrush, center.X + Convert.ToInt32(-x + xc), center.Y - Convert.ToInt32(-y + yc), 2, 2);
                if (d2 > 0)
                {
                    y--;
                    dy = dy - (2 * rx * rx);
                    d2 = d2 + (rx * rx) - dy;
                }
                else
                {
                    y--;
                    x++;
                    dx = dx + (2 * ry * ry);
                    dy = dy - (2 * rx * rx);
                    d2 = d2 + dx - dy + (rx * rx);
                }
            }

        }
        public void rotation2D(Graphics g, int x1, int y1, int xWidth, int yLenght, int angel)
        {
            var aBrush = Brushes.Black;

            var X1 = x1;
            var Y1 = y1;

            var x2 = x1;
            var y2 = (y1 + yLenght);


            var x3 = (x1 + xWidth);
            var y3 = (y1 + yLenght);


            var x4 = (x1 + xWidth);
            var y4 = y1;


            Rotation(ref X1, ref Y1, angel);
            Rotation(ref x2, ref y2, angel);
            Rotation(ref x3, ref y3, angel);
            Rotation(ref x4, ref y4, angel);


            LineBresenham(g, center.X + (int)X1, center.Y - (int)Y1, center.X + (int)x2, center.Y - (int)y2);
            LineBresenham(g, center.X + (int)x2, center.Y - (int)y2, center.X + (int)x3, center.Y - (int)y3);
            LineBresenham(g, center.X + (int)x3, center.Y - (int)y3, center.X + (int)x4, center.Y - (int)y4);
            LineBresenham(g, center.X + (int)x4, center.Y - (int)y4, center.X + (int)X1, center.Y - (int)Y1);

        }
        private double Cos(double Angel)
        {
            double angel = Convert.ToInt32(Math.Cos(Math.PI * Angel / 180) * 100);
            angel = Convert.ToDouble(angel / 100);
            return angel;
        }
        private void Rotation(ref int X, ref int Y, double Angel)
        {

            double x, y, con, sin;
            con = Cos(Angel);
            sin = Math.Sin(Math.PI * Convert.ToDouble(Angel / 180));

            x = (X * con) + (Y * sin);
            y = (X * sin) - (Y * con);

            X = Convert.ToInt32(Math.Round(x));
            Y = Convert.ToInt32(Math.Round(y));

        }
        public void translation2D(Graphics g, int X, int Y, int itX, int itY, int xWidth, int yLenght)
        {
            var x1 = X + itX;
            var y1 = Y + itY;
            LineBresenham(g, center.X + x1, center.Y - y1, center.X + x1, center.Y - (y1 + yLenght));
            LineBresenham(g, center.X + x1, center.Y - (y1 + yLenght), center.X + (x1 + xWidth), center.Y - (y1 + yLenght));
            LineBresenham(g, center.X + (x1 + xWidth), center.Y - (y1 + yLenght), center.X + (x1 + xWidth), center.Y - y1);
            LineBresenham(g, center.X + (x1 + xWidth), center.Y - y1, center.X + x1, center.Y - y1);

        }
        public void scaling2D(Graphics g, int x1, int y1, int scX, int scY, int xWidth, int yLenght)
        {
            xWidth = xWidth * scX;
            yLenght = yLenght * scY;
            LineBresenham(g, center.X + x1, center.Y - y1, center.X + x1, center.Y - (y1 + yLenght));
            LineBresenham(g, center.X + x1, center.Y - (y1 + yLenght), center.X + (x1 + xWidth), center.Y - (y1 + yLenght));
            LineBresenham(g, center.X + (x1 + xWidth), center.Y - (y1 + yLenght), center.X + (x1 + xWidth), center.Y - y1);
            LineBresenham(g, center.X + (x1 + xWidth), center.Y - y1, center.X + x1, center.Y - y1);

        }
        private void Shearing_X(ref int X, ref int Y, int X_Shearing)
        {
            int x, y;
            x = X * 1;
            y = X * X_Shearing + Y;
            X = x;
            Y = y;
        }
        private void Shearing_Y(ref int X, ref int Y, int Y_Shearing)
        {
            int x, y;
            x = X + Y_Shearing * Y;
            y = Y;
            X = x;
            Y = y;
        }
        public void shearX(Graphics g, int x1, int y1, int Shearing_shx, int xWidth, int yLenght)
        {
            var x2 = x1;
            var y2 = (y1 + yLenght);


            var x3 = (x1 + xWidth);
            var y3 = (y1 + yLenght);


            var x4 = (x1 + xWidth);
            var y4 = y1;


            Shearing_X(ref x1, ref y1, Shearing_shx);
            Shearing_X(ref x2, ref y2, Shearing_shx);
            Shearing_X(ref x3, ref y3, Shearing_shx);
            Shearing_X(ref x4, ref y4, Shearing_shx);


            LineBresenham(g, center.X + (int)x1, center.Y - (int)y1, center.X + (int)x2, center.Y - (int)y2);
            LineBresenham(g, center.X + (int)x2, center.Y - (int)y2, center.X + (int)x3, center.Y - (int)y3);
            LineBresenham(g, center.X + (int)x3, center.Y - (int)y3, center.X + (int)x4, center.Y - (int)y4);
            LineBresenham(g, center.X + (int)x4, center.Y - (int)y4, center.X + (int)x1, center.Y - (int)y1);
        }
        public void shearY(Graphics g, int x1, int y1, int Shearing_shy, int xWidth, int yLenght)
        {
        var x2 = x1;
        var y2 = (y1 + yLenght);


        var x3 = (x1 + xWidth);
        var y3 = (y1 + yLenght);


        var x4 = (x1 + xWidth);
        var y4 = y1;


        Shearing_Y(ref x1, ref y1, Shearing_shy);
        Shearing_Y(ref x2, ref y2, Shearing_shy);
        Shearing_Y(ref x3, ref y3, Shearing_shy);
        Shearing_Y(ref x4, ref y4, Shearing_shy);


        LineBresenham(g, center.X + (int) x1, center.Y - (int) y1, center.X + (int) x2, center.Y - (int) y2);
        LineBresenham(g, center.X + (int) x2, center.Y - (int) y2, center.X + (int) x3, center.Y - (int) y3);
        LineBresenham(g, center.X + (int) x3, center.Y - (int) y3, center.X + (int) x4, center.Y - (int) y4);
        LineBresenham(g, center.X + (int) x4, center.Y - (int) y4, center.X + (int) x1, center.Y - (int) y1);
        }


        public void overX_Line(Graphics g, int xStart, int yStart, int xEnd, int yEnd)
        {
            LineBresenham(g, (center.X - xStart), center.Y - yStart, (center.X - xEnd), center.Y - yEnd);
        }
        public void overY_Line(Graphics g, int xStart, int yStart, int xEnd, int yEnd)
        {
            LineBresenham(g, (center.X + xStart), center.Y + yStart, (center.X + xEnd), center.Y + yEnd);
        }
        public void overOrigin_Line(Graphics g, int xStart, int yStart, int xEnd, int yEnd)
        {
            LineBresenham(g, (center.X - xStart), center.Y + yStart, (center.X - xEnd), center.Y + yEnd);
        }


        public void overX_2D(Graphics g, int x1, int y1, int xWidth, int yLenght)
        {
            LineBresenham(g, (center.X - x1), center.Y - y1, (center.X - x1), center.Y - (y1 + yLenght));
            LineBresenham(g, (center.X - x1), center.Y - (y1 + yLenght), (center.X - (x1 + xWidth)), center.Y - (y1 + yLenght));
            LineBresenham(g, (center.X - (x1 + xWidth)), center.Y - (y1 + yLenght), (center.X - (x1 + xWidth)), center.Y - y1);
            LineBresenham(g, (center.X - (x1 + xWidth)), center.Y - y1, (center.X - x1), center.Y - y1);
        }
        public void overY_2D(Graphics g, int x1, int y1, int xWidth, int yLenght)
        {
            LineBresenham(g, (center.X + x1), center.Y + y1, (center.X + x1), center.Y + (y1 + yLenght));
            LineBresenham(g, (center.X + x1), center.Y + (y1 + yLenght), (center.X + (x1 + xWidth)), center.Y + (y1 + yLenght));
            LineBresenham(g, (center.X + (x1 + xWidth)), center.Y + (y1 + yLenght), (center.X + (x1 + xWidth)), center.Y + y1);
            LineBresenham(g, (center.X + (x1 + xWidth)), center.Y + y1, (center.X + x1), center.Y + y1);
        }
        public void overOrigin_2D(Graphics g, int x1, int y1, int xWidth, int yLenght)
        {
            LineBresenham(g, (center.X - x1), center.Y + y1, (center.X - x1), center.Y + (y1 + yLenght));
            LineBresenham(g, (center.X - x1), center.Y + (y1 + yLenght), (center.X - (x1 + xWidth)), center.Y + (y1 + yLenght));
            LineBresenham(g, (center.X - (x1 + xWidth)), center.Y + (y1 + yLenght), (center.X - (x1 + xWidth)), center.Y + y1);
            LineBresenham(g, (center.X - (x1 + xWidth)), center.Y + y1, (center.X - x1), center.Y + y1);
        }

    }

}
