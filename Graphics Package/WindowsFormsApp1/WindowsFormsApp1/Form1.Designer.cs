namespace WindowsFormsApp1
{
    partial class GraphicsPackage
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
            this.drawDDA = new System.Windows.Forms.Button();
            this.panalPixel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.xStart = new System.Windows.Forms.TextBox();
            this.yStart = new System.Windows.Forms.TextBox();
            this.xEnd = new System.Windows.Forms.TextBox();
            this.yEnd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.drawBresenham = new System.Windows.Forms.Button();
            this.circleBres = new System.Windows.Forms.Button();
            this.rCircle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.xcStart = new System.Windows.Forms.TextBox();
            this.ycStart = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rx = new System.Windows.Forms.TextBox();
            this.ry = new System.Windows.Forms.TextBox();
            this.cx = new System.Windows.Forms.TextBox();
            this.cy = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.drawElipse = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tx = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.ty = new System.Windows.Forms.TextBox();
            this.translation2D = new System.Windows.Forms.Button();
            this.textAngle = new System.Windows.Forms.TextBox();
            this.angle = new System.Windows.Forms.Label();
            this.rotate2D = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textX1 = new System.Windows.Forms.TextBox();
            this.textY1 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textWidth = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textLenght = new System.Windows.Forms.TextBox();
            this.Draw2D = new System.Windows.Forms.Button();
            this.scaling2D = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.sX = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.sY = new System.Windows.Forms.TextBox();
            this.shearX = new System.Windows.Forms.Button();
            this.overX = new System.Windows.Forms.Button();
            this.overY = new System.Windows.Forms.Button();
            this.overOrigin = new System.Windows.Forms.Button();
            this.lineOver = new System.Windows.Forms.RadioButton();
            this.Over2D = new System.Windows.Forms.RadioButton();
            this.shearY = new System.Windows.Forms.Button();
            this.ClearDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // drawDDA
            // 
            this.drawDDA.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.drawDDA.Location = new System.Drawing.Point(27, 116);
            this.drawDDA.Name = "drawDDA";
            this.drawDDA.Size = new System.Drawing.Size(130, 30);
            this.drawDDA.TabIndex = 0;
            this.drawDDA.Text = "Draw DDA";
            this.drawDDA.UseVisualStyleBackColor = true;
            this.drawDDA.Click += new System.EventHandler(this.drawDDA_Click);
            // 
            // panalPixel
            // 
            this.panalPixel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panalPixel.BackColor = System.Drawing.SystemColors.Info;
            this.panalPixel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panalPixel.Location = new System.Drawing.Point(329, 27);
            this.panalPixel.Name = "panalPixel";
            this.panalPixel.Size = new System.Drawing.Size(620, 420);
            this.panalPixel.TabIndex = 1;
            this.panalPixel.Paint += new System.Windows.Forms.PaintEventHandler(this.panalPixel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Y";
            // 
            // xStart
            // 
            this.xStart.Location = new System.Drawing.Point(44, 41);
            this.xStart.Name = "xStart";
            this.xStart.Size = new System.Drawing.Size(114, 20);
            this.xStart.TabIndex = 6;
            this.xStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yStart
            // 
            this.yStart.Location = new System.Drawing.Point(44, 73);
            this.yStart.Name = "yStart";
            this.yStart.Size = new System.Drawing.Size(114, 20);
            this.yStart.TabIndex = 6;
            this.yStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xEnd
            // 
            this.xEnd.Location = new System.Drawing.Point(196, 40);
            this.xEnd.Name = "xEnd";
            this.xEnd.Size = new System.Drawing.Size(114, 20);
            this.xEnd.TabIndex = 6;
            this.xEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yEnd
            // 
            this.yEnd.Location = new System.Drawing.Point(196, 69);
            this.yEnd.Name = "yEnd";
            this.yEnd.Size = new System.Drawing.Size(114, 20);
            this.yEnd.TabIndex = 6;
            this.yEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "POINT ONE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "POINT TWO";
            // 
            // drawBresenham
            // 
            this.drawBresenham.Location = new System.Drawing.Point(178, 116);
            this.drawBresenham.Name = "drawBresenham";
            this.drawBresenham.Size = new System.Drawing.Size(130, 30);
            this.drawBresenham.TabIndex = 8;
            this.drawBresenham.Text = "Draw Bresenham";
            this.drawBresenham.UseVisualStyleBackColor = true;
            this.drawBresenham.Click += new System.EventHandler(this.drawBresenham_Click);
            // 
            // circleBres
            // 
            this.circleBres.Location = new System.Drawing.Point(101, 258);
            this.circleBres.Name = "circleBres";
            this.circleBres.Size = new System.Drawing.Size(130, 30);
            this.circleBres.TabIndex = 9;
            this.circleBres.Text = "Draw Circle";
            this.circleBres.UseVisualStyleBackColor = true;
            this.circleBres.Click += new System.EventHandler(this.circleBres_Click);
            // 
            // rCircle
            // 
            this.rCircle.Location = new System.Drawing.Point(196, 206);
            this.rCircle.Name = "rCircle";
            this.rCircle.Size = new System.Drawing.Size(100, 20);
            this.rCircle.TabIndex = 10;
            this.rCircle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "r";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Y";
            // 
            // xcStart
            // 
            this.xcStart.Location = new System.Drawing.Point(44, 189);
            this.xcStart.Name = "xcStart";
            this.xcStart.Size = new System.Drawing.Size(115, 20);
            this.xcStart.TabIndex = 6;
            this.xcStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ycStart
            // 
            this.ycStart.Location = new System.Drawing.Point(44, 221);
            this.ycStart.Name = "ycStart";
            this.ycStart.Size = new System.Drawing.Size(114, 20);
            this.ycStart.TabIndex = 6;
            this.ycStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "START POINT";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(222, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "RADIUS";
            // 
            // rx
            // 
            this.rx.Location = new System.Drawing.Point(44, 310);
            this.rx.Name = "rx";
            this.rx.Size = new System.Drawing.Size(114, 20);
            this.rx.TabIndex = 6;
            this.rx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ry
            // 
            this.ry.Location = new System.Drawing.Point(44, 342);
            this.ry.Name = "ry";
            this.ry.Size = new System.Drawing.Size(114, 20);
            this.ry.TabIndex = 6;
            this.ry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cx
            // 
            this.cx.Location = new System.Drawing.Point(196, 310);
            this.cx.Name = "cx";
            this.cx.Size = new System.Drawing.Size(114, 20);
            this.cx.TabIndex = 6;
            this.cx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cy
            // 
            this.cy.Location = new System.Drawing.Point(196, 342);
            this.cy.Name = "cy";
            this.cy.Size = new System.Drawing.Size(114, 20);
            this.cy.TabIndex = 6;
            this.cy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "rX";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 345);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "rY";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(176, 313);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "cX";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(176, 345);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "cY";
            // 
            // drawElipse
            // 
            this.drawElipse.Location = new System.Drawing.Point(101, 377);
            this.drawElipse.Name = "drawElipse";
            this.drawElipse.Size = new System.Drawing.Size(130, 30);
            this.drawElipse.TabIndex = 9;
            this.drawElipse.Text = "Draw Elipse";
            this.drawElipse.UseVisualStyleBackColor = true;
            this.drawElipse.Click += new System.EventHandler(this.drawElipse_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(986, 147);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "X";
            // 
            // tx
            // 
            this.tx.Location = new System.Drawing.Point(1003, 144);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(50, 20);
            this.tx.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1068, 147);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Y";
            // 
            // ty
            // 
            this.ty.Location = new System.Drawing.Point(1085, 144);
            this.ty.Name = "ty";
            this.ty.Size = new System.Drawing.Size(50, 20);
            this.ty.TabIndex = 13;
            // 
            // translation2D
            // 
            this.translation2D.Location = new System.Drawing.Point(1012, 176);
            this.translation2D.Name = "translation2D";
            this.translation2D.Size = new System.Drawing.Size(111, 23);
            this.translation2D.TabIndex = 14;
            this.translation2D.Text = "Translation";
            this.translation2D.UseVisualStyleBackColor = true;
            this.translation2D.Click += new System.EventHandler(this.translation2D_Click);
            // 
            // textAngle
            // 
            this.textAngle.Location = new System.Drawing.Point(1035, 235);
            this.textAngle.Name = "textAngle";
            this.textAngle.Size = new System.Drawing.Size(100, 20);
            this.textAngle.TabIndex = 15;
            // 
            // angle
            // 
            this.angle.AutoSize = true;
            this.angle.Location = new System.Drawing.Point(995, 238);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(37, 13);
            this.angle.TabIndex = 16;
            this.angle.Text = "Angle ";
            // 
            // rotate2D
            // 
            this.rotate2D.Location = new System.Drawing.Point(1012, 265);
            this.rotate2D.Name = "rotate2D";
            this.rotate2D.Size = new System.Drawing.Size(111, 23);
            this.rotate2D.TabIndex = 17;
            this.rotate2D.Text = "Rotate";
            this.rotate2D.UseVisualStyleBackColor = true;
            this.rotate2D.Click += new System.EventHandler(this.rotate2D_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1054, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "Y1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(971, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(20, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "X1";
            // 
            // textX1
            // 
            this.textX1.Location = new System.Drawing.Point(993, 25);
            this.textX1.Name = "textX1";
            this.textX1.Size = new System.Drawing.Size(50, 20);
            this.textX1.TabIndex = 20;
            // 
            // textY1
            // 
            this.textY1.Location = new System.Drawing.Point(1080, 25);
            this.textY1.Name = "textY1";
            this.textY1.Size = new System.Drawing.Size(50, 20);
            this.textY1.TabIndex = 21;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(1000, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 22;
            this.label20.Text = "Width";
            // 
            // textWidth
            // 
            this.textWidth.Location = new System.Drawing.Point(994, 70);
            this.textWidth.Name = "textWidth";
            this.textWidth.Size = new System.Drawing.Size(50, 20);
            this.textWidth.TabIndex = 23;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(1086, 54);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 13);
            this.label21.TabIndex = 24;
            this.label21.Text = "Lenght";
            // 
            // textLenght
            // 
            this.textLenght.Location = new System.Drawing.Point(1081, 69);
            this.textLenght.Name = "textLenght";
            this.textLenght.Size = new System.Drawing.Size(50, 20);
            this.textLenght.TabIndex = 25;
            // 
            // Draw2D
            // 
            this.Draw2D.Location = new System.Drawing.Point(1013, 95);
            this.Draw2D.Name = "Draw2D";
            this.Draw2D.Size = new System.Drawing.Size(100, 30);
            this.Draw2D.TabIndex = 26;
            this.Draw2D.Text = "Draw";
            this.Draw2D.UseVisualStyleBackColor = true;
            this.Draw2D.Click += new System.EventHandler(this.Draw2D_Click);
            // 
            // scaling2D
            // 
            this.scaling2D.Location = new System.Drawing.Point(1012, 203);
            this.scaling2D.Name = "scaling2D";
            this.scaling2D.Size = new System.Drawing.Size(111, 23);
            this.scaling2D.TabIndex = 27;
            this.scaling2D.Text = "Scaling";
            this.scaling2D.UseVisualStyleBackColor = true;
            this.scaling2D.Click += new System.EventHandler(this.scaling2D_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(995, 309);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 13);
            this.label22.TabIndex = 12;
            this.label22.Text = "X";
            // 
            // sX
            // 
            this.sX.Location = new System.Drawing.Point(1012, 306);
            this.sX.Name = "sX";
            this.sX.Size = new System.Drawing.Size(50, 20);
            this.sX.TabIndex = 13;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(1077, 309);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 13);
            this.label23.TabIndex = 12;
            this.label23.Text = "Y";
            // 
            // sY
            // 
            this.sY.Location = new System.Drawing.Point(1094, 306);
            this.sY.Name = "sY";
            this.sY.Size = new System.Drawing.Size(50, 20);
            this.sY.TabIndex = 13;
            // 
            // shearX
            // 
            this.shearX.Location = new System.Drawing.Point(998, 339);
            this.shearX.Name = "shearX";
            this.shearX.Size = new System.Drawing.Size(65, 23);
            this.shearX.TabIndex = 14;
            this.shearX.Text = "Shear X";
            this.shearX.UseVisualStyleBackColor = true;
            this.shearX.Click += new System.EventHandler(this.shearX_Click);
            // 
            // overX
            // 
            this.overX.Location = new System.Drawing.Point(1079, 374);
            this.overX.Name = "overX";
            this.overX.Size = new System.Drawing.Size(75, 23);
            this.overX.TabIndex = 28;
            this.overX.Text = "Over X";
            this.overX.UseVisualStyleBackColor = true;
            this.overX.Click += new System.EventHandler(this.overX_Click);
            // 
            // overY
            // 
            this.overY.Location = new System.Drawing.Point(1080, 403);
            this.overY.Name = "overY";
            this.overY.Size = new System.Drawing.Size(75, 23);
            this.overY.TabIndex = 28;
            this.overY.Text = "Over Y";
            this.overY.UseVisualStyleBackColor = true;
            this.overY.Click += new System.EventHandler(this.overY_Click);
            // 
            // overOrigin
            // 
            this.overOrigin.Location = new System.Drawing.Point(1080, 432);
            this.overOrigin.Name = "overOrigin";
            this.overOrigin.Size = new System.Drawing.Size(75, 23);
            this.overOrigin.TabIndex = 28;
            this.overOrigin.Text = "Over Origin";
            this.overOrigin.UseVisualStyleBackColor = true;
            this.overOrigin.Click += new System.EventHandler(this.overOrigin_Click);
            // 
            // lineOver
            // 
            this.lineOver.AutoSize = true;
            this.lineOver.Location = new System.Drawing.Point(998, 390);
            this.lineOver.Name = "lineOver";
            this.lineOver.Size = new System.Drawing.Size(45, 17);
            this.lineOver.TabIndex = 29;
            this.lineOver.TabStop = true;
            this.lineOver.Text = "Line";
            this.lineOver.UseVisualStyleBackColor = true;
            // 
            // Over2D
            // 
            this.Over2D.AutoSize = true;
            this.Over2D.Location = new System.Drawing.Point(998, 412);
            this.Over2D.Name = "Over2D";
            this.Over2D.Size = new System.Drawing.Size(39, 17);
            this.Over2D.TabIndex = 29;
            this.Over2D.TabStop = true;
            this.Over2D.Text = "2D";
            this.Over2D.UseVisualStyleBackColor = true;
            // 
            // shearY
            // 
            this.shearY.Location = new System.Drawing.Point(1079, 339);
            this.shearY.Name = "shearY";
            this.shearY.Size = new System.Drawing.Size(65, 23);
            this.shearY.TabIndex = 14;
            this.shearY.Text = "Shear Y";
            this.shearY.UseVisualStyleBackColor = true;
            this.shearY.Click += new System.EventHandler(this.shearY_Click);
            // 
            // ClearDraw
            // 
            this.ClearDraw.Location = new System.Drawing.Point(530, 453);
            this.ClearDraw.Name = "ClearDraw";
            this.ClearDraw.Size = new System.Drawing.Size(231, 38);
            this.ClearDraw.TabIndex = 30;
            this.ClearDraw.Text = "CLEAR";
            this.ClearDraw.UseVisualStyleBackColor = true;
            this.ClearDraw.Click += new System.EventHandler(this.ClearDraw_Click);
            // 
            // GraphicsPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 504);
            this.Controls.Add(this.ClearDraw);
            this.Controls.Add(this.Over2D);
            this.Controls.Add(this.lineOver);
            this.Controls.Add(this.overOrigin);
            this.Controls.Add(this.overY);
            this.Controls.Add(this.overX);
            this.Controls.Add(this.scaling2D);
            this.Controls.Add(this.Draw2D);
            this.Controls.Add(this.textLenght);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.textWidth);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textY1);
            this.Controls.Add(this.textX1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.rotate2D);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.textAngle);
            this.Controls.Add(this.shearY);
            this.Controls.Add(this.shearX);
            this.Controls.Add(this.translation2D);
            this.Controls.Add(this.sY);
            this.Controls.Add(this.ty);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.sX);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.tx);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rCircle);
            this.Controls.Add(this.drawElipse);
            this.Controls.Add(this.circleBres);
            this.Controls.Add(this.drawBresenham);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yEnd);
            this.Controls.Add(this.xEnd);
            this.Controls.Add(this.cy);
            this.Controls.Add(this.ry);
            this.Controls.Add(this.ycStart);
            this.Controls.Add(this.cx);
            this.Controls.Add(this.rx);
            this.Controls.Add(this.xcStart);
            this.Controls.Add(this.yStart);
            this.Controls.Add(this.xStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panalPixel);
            this.Controls.Add(this.drawDDA);
            this.Name = "GraphicsPackage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphics Package";
            this.Load += new System.EventHandler(this.GraphicsPackage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drawDDA;
        private System.Windows.Forms.Panel panalPixel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox xStart;
        private System.Windows.Forms.TextBox yStart;
        private System.Windows.Forms.TextBox xEnd;
        private System.Windows.Forms.TextBox yEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button drawBresenham;
        private System.Windows.Forms.Button circleBres;
        private System.Windows.Forms.TextBox rCircle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox xcStart;
        private System.Windows.Forms.TextBox ycStart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox rx;
        private System.Windows.Forms.TextBox cx;
        private System.Windows.Forms.TextBox cy;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button drawElipse;
        private System.Windows.Forms.TextBox ry;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tx;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox ty;
        private System.Windows.Forms.Button translation2D;
        private System.Windows.Forms.TextBox textAngle;
        private System.Windows.Forms.Label angle;
        private System.Windows.Forms.Button rotate2D;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textX1;
        private System.Windows.Forms.TextBox textY1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textWidth;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textLenght;
        private System.Windows.Forms.Button Draw2D;
        private System.Windows.Forms.Button scaling2D;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox sX;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox sY;
        private System.Windows.Forms.Button shearX;
        private System.Windows.Forms.Button overX;
        private System.Windows.Forms.Button overY;
        private System.Windows.Forms.Button overOrigin;
        private System.Windows.Forms.RadioButton lineOver;
        private System.Windows.Forms.RadioButton Over2D;
        private System.Windows.Forms.Button shearY;
        private System.Windows.Forms.Button ClearDraw;
    }
}

