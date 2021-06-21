using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FeelUrPain
{ 
    partial class Form1 : Form
    {
        bool bLine = false;
        bool bCir = false;
        bool bRec = false;
        bool bSqua = false;
        bool PolyDrawing = false;
        bool BezierDrawing = false;
        bool bEllip = false;
        bool bBezier = false;
        bool bPolyg = false;
        bool down = false;
        bool Moving = false;
        bool changesSize = false;
        int IndexMoving = -1;
        int IndexZooming = -1;
        Point SomePoit = new Point();

        List<Shape> shapes = new List<Shape>();
        List<Button> buttons = new List<Button>();
        List<Shape> LowerRight = new List<Shape>();
        public Form1()
        {
            InitializeComponent();
            buttons.Add(btnLine);
            buttons.Add(btnCir);
            buttons.Add(btnRec);
            buttons.Add(btnSqua);
            buttons.Add(btnEllipse);
            buttons.Add(btnPolygon);
            buttons.Add(btnBezier);
            cbbDashStyle.Items.AddRange(new string[] { DashStyle.Solid.ToString(),
                DashStyle.Dash.ToString(),
                DashStyle.Dot.ToString(),
                DashStyle.DashDot.ToString(),
                DashStyle.DashDotDot.ToString(),
                DashStyle.Custom.ToString()
            });
            cbbDashStyle.SelectedIndex = 0;
            rdb_NoFill.Checked = true;
        }
        #region methods
        private bool Ischoose_Button()
        {
            return bLine || bRec || bSqua || bCir || bEllip || bPolyg || bBezier;
        }
        private void OffAllButton()
        {
            this.bLine = false;
            this.bRec = false;
            this.bSqua = false;
            this.bCir = false;
            this.bEllip = false;
            this.bPolyg = false;
            this.bBezier = false;
        }
        private void UnCheckAll()
        {
            while (clb_listHinh.CheckedIndices.Count > 0)
                clb_listHinh.SetItemChecked(clb_listHinh.CheckedIndices[0], false);
        }

        private bool IsHitPoint(Point a, Point Hit)
        {
            int X = a.X;
            int Y = a.Y;
            if (Hit.X == X  && Hit.Y == Y )
                return true;
            else return false;
        }


        private bool IsHit(Point a, Point b, Point Hit)
        {
            int min_X = a.X;
            int min_Y = a.Y;
            int max_X = b.X;
            int max_Y = b.Y;
            if (Hit.X <= max_X && Hit.X >= min_X && Hit.Y <= max_Y && Hit.Y >= min_Y)
                return true;
            else return false;
        }
        private void clb_listHinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_listHinh.Items.Count; i++)
            {
                shapes[i]._thisShapeIsChoosing = clb_listHinh.GetItemChecked(i);
                this.bePainted1.Invalidate();
            }
        }
        private void bePainted1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            shapes.ForEach(Shape => {
                Shape.Drawing(e.Graphics);
            });
        }
        #endregion

        #region Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            UnCheckAll();
            this.bEllip = false;
            this.bPolyg = false;
            this.bRec = false;
            this.bSqua = false;
            this.bCir = false;
            buttons.ForEach(Button => { Button.BackColor = Color.FromArgb(224, 224, 224); });
            // foreach(Button a in buttons)
            if (this.bLine)
            {
                this.bLine = false;
            }
            else
            {
                this.bLine = true;
                this.btnLine.BackColor = Color.Aqua;
            }
            this.bePainted1.Refresh();
        }
        private void btnEllipse_Click(object sender, EventArgs e)
        {
            UnCheckAll();
            buttons.ForEach(Button => { Button.BackColor = Color.FromArgb(224, 224, 224); });
            this.bLine = false;
            this.bBezier = false;
            this.bPolyg = false;
            this.bRec = false;
            this.bSqua = false;
            this.bCir = false;
            if (this.bEllip)
            {
                this.bEllip = false;
            }
            else
            {
                this.bEllip = true;
                this.btnEllipse.BackColor = Color.Aqua;
            }
            this.bePainted1.Refresh();
        }
        private void btnBezier_Click(object sender, EventArgs e)
        {
            UnCheckAll();
            buttons.ForEach(Button => { Button.BackColor = Color.FromArgb(224, 224, 224); });
            this.bEllip = false;
            this.bSqua = false;
            this.bPolyg = false;
            this.bRec = false;
            this.bCir = false;
            this.bLine = false;
            if (this.bBezier)
            {
                this.bBezier = false;
            }
            else
            {
                this.bBezier = true;
                this.btnBezier.BackColor = Color.Aqua;
            }
            this.bePainted1.Refresh();
        }
        private void btnCir_Click(object sender, EventArgs e)
        {
            UnCheckAll();
            buttons.ForEach(Button => { Button.BackColor = Color.FromArgb(224, 224, 224); });
            this.bEllip = false;
            this.bBezier = false;
            this.bPolyg = false;
            this.bRec = false;
            this.bSqua = false;
            this.bLine = false;
            if (this.bCir)
            {
                this.bCir = false;
            }
            else
            {
                this.bCir = true;
                this.btnCir.BackColor = Color.Aqua;
            }
            this.bePainted1.Refresh();
        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            UnCheckAll();
            buttons.ForEach(Button => { Button.BackColor = Color.FromArgb(224, 224, 224); });
            this.bEllip = false;
            this.bBezier = false;
            this.bPolyg = false;
            this.bCir = false;
            this.bSqua = false;
            this.bLine = false;

            if (this.bRec)
            {
                this.bRec = false;
            }
            else
            {
                this.bRec = true;
                this.btnRec.BackColor = Color.Aqua;
            }
            this.bePainted1.Refresh();
        }

        private void btnSqua_Click(object sender, EventArgs e)
        {
            UnCheckAll();
            buttons.ForEach(Button => { Button.BackColor = Color.FromArgb(224, 224, 224); });
            this.bEllip = false;
            this.bPolyg = false;
            this.bRec = false;
            this.bBezier = false;
            this.bCir = false;
            this.bLine = false;


            if (this.bSqua)
            {
                this.bSqua = false;
            }
            else
            {
                this.bSqua = true;
                this.btnSqua.BackColor = Color.Aqua;
            }
            this.bePainted1.Refresh();
        }


        private void btnPolygon_Click(object sender, EventArgs e)
        {
            UnCheckAll();
            buttons.ForEach(Button => { Button.BackColor = Color.FromArgb(224, 224, 224); });
            this.bEllip = false;
            this.bSqua = false;
            this.bBezier = false;
            this.bRec = false;
            this.bCir = false;
            this.bLine = false;
            if (this.bPolyg)
            {
                this.bPolyg = false;
            }
            else
            {
                this.bPolyg = true;
                this.btnPolygon.BackColor = Color.Aqua;
            }
            this.bePainted1.Refresh();
        }

        //
        #endregion

        #region Color button
        private void btn_colorFill_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                btn_colorFill.BackColor = color.Color;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = color.Color;
            }
        }

        #endregion

        #region MouseProcees

        private void bePainted1_MouseClick(object sender, MouseEventArgs e)
        {
            UnCheckAll();
            for (int i = shapes.Count - 1; i >= 0; i--)
            {
                shapes[i]._thisShapeIsChoosing = false;
                this.bePainted1.Refresh();
            }
            if (!Ischoose_Button())// nếu không có btn nào được chọn
            {
                for (int i = shapes.Count-1; i>=0; i--)
                {
                    if (IsHit(shapes[i].UpperLeft, shapes[i].LowwerRight, e.Location))
                    {
                        clb_listHinh.SetItemChecked(i, true);
                        shapes[i]._thisShapeIsChoosing = true;
                        this.IndexMoving = i;
                        i = 0;
                        clb_listHinh.Focus();
                        this.bePainted1.Refresh();
                    }
                }
            }
            else
            {
            }    

        }


        private void bePainted1_DoubleClick(object sender, EventArgs e)
        {
            if(this.PolyDrawing)
            {
                this.PolyDrawing = false;
                Polygon polygon = this.shapes[shapes.Count - 1] as Polygon;
                string a = "";
                if (shapes.Count != 0 && Ischoose_Button())
                {
                    a = shapes[shapes.Count - 1].ShowProp();
                    clb_listHinh.Items.Add(a);
                }
            }
        }

        private void bePainted1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Moving = false;
            this.changesSize = false;
            if( !bPolyg && !bBezier )
            {
                this.down = false;
                string a = "";
                if (shapes.Count != 0 && Ischoose_Button())
                {
                    a = shapes[shapes.Count - 1].ShowProp();
                    clb_listHinh.Items.Add(a);
                }
                else;
            }
            else
            {

            }

        }

        private void bePainted1_MouseDown(object sender, MouseEventArgs e)
        {
            this.down = true;
            if (Ischoose_Button()&& this.down) 
            {
                #region Button
                if (this.bLine && this.down)
                {
                    Line ay = new Line();
                    ay._beginPoint = e.Location;
                    ay._endPoint = ay._beginPoint;
                    ay._lcolor = btnColor.BackColor;
                    ay._lwidth = (int)numericUpDown1.Value;
                    ay._dashStyle = (DashStyle)cbbDashStyle.SelectedIndex;
                    ay._lcolorFill = btn_colorFill.BackColor;
                    if (rdb_NoFill.Checked)
                        ay._fill = false;
                    else if (rdb_Fill.Checked)
                        ay._fill = true;
                    shapes.Add(ay);
                 //   Rectangle a = new Rectangle();
                    
                    
                  //  LowerRight.Add()

                }
                else if (this.bCir && this.down)
                {
                    Circl cir = new Circl();
                    cir._beginPoint = e.Location;
                    cir._endPoint = cir._beginPoint;
                    cir._lcolor = btnColor.BackColor;
                    cir._lwidth = (int)numericUpDown1.Value;
                    cir._dashStyle = (DashStyle)cbbDashStyle.SelectedIndex;
                    cir._lcolorFill = btn_colorFill.BackColor;
                    if (rdb_NoFill.Checked)
                        cir._fill = false;
                    else if (rdb_Fill.Checked)
                        cir._fill = true;
                    shapes.Add(cir);
                }
                else if (this.bSqua && this.down)
                {
                    Square squa = new Square();
                    squa._beginPoint = e.Location;
                    squa._endPoint = squa._beginPoint;
                    squa._lcolor = btnColor.BackColor;
                    squa._lwidth = (int)numericUpDown1.Value;
                    squa._dashStyle = (DashStyle)cbbDashStyle.SelectedIndex;
                    squa._lcolorFill = btn_colorFill.BackColor;
                    if (rdb_NoFill.Checked)
                        squa._fill = false;
                    else if(rdb_Fill.Checked)
                        squa._fill = true;
                    shapes.Add(squa);
                }
                else if (this.bRec && this.down)
                {
                    Rectangle rec = new Rectangle();
                    rec._beginPoint = e.Location;
                    rec._endPoint = rec._beginPoint;
                    rec._lcolorFill = btn_colorFill.BackColor;
                    rec._lcolor = btnColor.BackColor;
                    rec._lwidth = (int)numericUpDown1.Value;
                    rec._dashStyle = (DashStyle)cbbDashStyle.SelectedIndex;
                    if (rdb_NoFill.Checked)
                        rec._fill = false;
                    else if (rdb_Fill.Checked)
                        rec._fill = true;
                    shapes.Add(rec);
                }
                else if (this.bEllip && this.down)
                {
                    Ellipse elip = new Ellipse();
                    elip._beginPoint = e.Location;
                    elip._endPoint = elip._beginPoint;
                    elip._lcolor = btnColor.BackColor;
                    elip._lcolorFill = btn_colorFill.BackColor;
                    elip._lwidth = (int)numericUpDown1.Value;
                    elip._dashStyle = (DashStyle)cbbDashStyle.SelectedIndex;
                    if (rdb_NoFill.Checked)
                        elip._fill = false;
                    else if (rdb_Fill.Checked)
                        elip._fill = true;
                    shapes.Add(elip);
                }
                else if (this.bPolyg && this.down)
                {
                    if (!this.PolyDrawing)
                    {
                        this.PolyDrawing = true;
                        Polygon poly = new Polygon();
                        poly._beginPoint = e.Location;
                        poly._endPoint = poly._beginPoint;
                        poly._lcolorFill = btn_colorFill.BackColor;
                        poly._lcolor = btnColor.BackColor;
                        poly._lwidth = (int)numericUpDown1.Value;
                        poly._dashStyle = (DashStyle)cbbDashStyle.SelectedIndex;
                        if (rdb_NoFill.Checked)
                            poly._fill = false;
                        else if (rdb_Fill.Checked)
                            poly._fill = true;
                        poly.points.Add(poly._beginPoint);
                        poly.points.Add(poly._beginPoint);
                        shapes.Add(poly);
                    }
                    else
                    {
                        Polygon polygon = this.shapes[shapes.Count - 1] as Polygon;
                        polygon.points.Add(e.Location);
                    }
                    //this.LowerRight.Add()

                }
                else if (this.bBezier && this.down)
                {
                    if (!this.BezierDrawing)
                    {
                        this.BezierDrawing = true;
                        Bezier bezier = new Bezier();
                        bezier._beginPoint = e.Location;
                        bezier._endPoint = bezier._beginPoint;
                        bezier._lcolorFill = btn_colorFill.BackColor;
                        bezier._lcolor = btnColor.BackColor;
                        bezier._lwidth = (int)numericUpDown1.Value;
                        bezier._dashStyle = (DashStyle)cbbDashStyle.SelectedIndex;
                        if (rdb_NoFill.Checked)
                            bezier._fill = false;
                        else if (rdb_Fill.Checked)
                            bezier._fill = true;
                        bezier.points.Add(bezier._beginPoint);
                        bezier.points.Add(bezier._beginPoint);
                        shapes.Add(bezier);
                    }
                    else
                    {
                        Bezier bezier = this.shapes[shapes.Count - 1] as Bezier;
                        if (bezier.points.Count<4)
                            bezier.points.Add(e.Location);
                        else
                        {
                            this.BezierDrawing = false;
                            //Bezier bezier = this.shapes[shapes.Count - 1] as Bezier;
                            string a = "";
                            if (shapes.Count != 0 && Ischoose_Button())
                            {
                                a = shapes[shapes.Count - 1].ShowProp();
                                clb_listHinh.Items.Add(a);
                            }
                        }
                    }
                }
            }
            #endregion
            else if (!this.Moving)
            {
                for (int i = shapes.Count - 1; i >= 0; i--)
                {
                    if(shapes[i]._thisShapeIsChoosing && IsHit(shapes[i].ToMoving_rec.UpperLeft, shapes[i].ToMoving_rec.LowwerRight,e.Location))
                    {
                        this.changesSize = true;
                        this.SomePoit = e.Location;
                        IndexZooming = i;
                        i = 0;
                        //Cursor.Current = Cursors.Hand;
                    }
                    else if (IsHit(shapes[i].UpperLeft, shapes[i].LowwerRight, e.Location))
                    {
                        clb_listHinh.SetItemChecked(i, true);
                        shapes[i]._thisShapeIsChoosing = true;
                        this.Moving = true;
                        IndexMoving = i;
                        this.SomePoit = e.Location;
                        i = 0;
                        this.bePainted1.Refresh();
                    }
                }
            }
            else 
            {

            }
        }
        public  bool someShapeIschoose()
        {
            for (int i = shapes.Count - 1; i >= 0; i--)
                if (shapes[i]._thisShapeIsChoosing)
                    return true;
            return false;
        }

        private void bePainted1_MouseMove(object sender, MouseEventArgs e)
        {
            if(Ischoose_Button()&& this.down)
            {

                if (this.bLine && this.down)
                {
                    shapes[shapes.Count - 1]._endPoint = e.Location;
                    bePainted1.Invalidate();
                }
                else if (this.bRec && this.down)
                {
                    shapes[shapes.Count - 1]._endPoint = e.Location;
                    bePainted1.Invalidate();
                }
                else if (this.bCir && this.down)
                {
                    shapes[shapes.Count - 1]._endPoint = e.Location;
                    bePainted1.Invalidate();
                }
                else if (this.bSqua && this.down)
                {
                    shapes[shapes.Count - 1]._endPoint = e.Location;
                    bePainted1.Invalidate();
                }
                else if (this.bEllip && this.down)
                {
                    shapes[shapes.Count - 1]._endPoint = e.Location;
                    bePainted1.Invalidate();
                }
                else if (this.bPolyg && this.down)
                {
                    if (this.PolyDrawing)
                    {
                        Polygon polygon = shapes[shapes.Count - 1] as Polygon;
                        polygon.points[polygon.points.Count - 1] = e.Location;
                        this.bePainted1.Invalidate();
                    }
                }
                else if(this.bBezier && this.down)
                {
                    if (this.BezierDrawing)
                    {
                        Bezier bezier = shapes[shapes.Count - 1] as Bezier;
                        bezier.points[bezier.points.Count - 1] = e.Location;
                        this.bePainted1.Invalidate();
                    }
                }
            }
            else if(this.Moving)
            {
                Cursor.Current = Cursors.SizeAll;
                Point distance = new Point(e.X - SomePoit.X, e.Y - SomePoit.Y);
                SomePoit = e.Location;
                shapes[IndexMoving].Moving(distance);
                this.bePainted1.Invalidate();
            }
            else if(changesSize)
            {
                Cursor.Current = Cursors.SizeNWSE;
                Point distance = new Point(e.X - SomePoit.X, e.Y - SomePoit.Y);
                SomePoit = e.Location;
                shapes[IndexZooming].Zoomming(distance);
                this.bePainted1.Invalidate();
            }    

        }
        #endregion

        #region Delete
        private void btnDel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i]._thisShapeIsChoosing)
                {
                    shapes.RemoveAt(i);
                    clb_listHinh.Items.RemoveAt(i);
                    i--;
                }
            }
            this.bePainted1.Refresh();
        }
        #endregion

        #region Group Procees

        private void btnGroup_Click(object sender, EventArgs e)
        {
            if(clb_listHinh.CheckedItems.Count>=2)
            {
                Picture newGroup = new Picture();
                for (int i = 0; i < shapes.Count; i++)
                {
                    if (shapes[i]._thisShapeIsChoosing)
                    {
                        newGroup.Group(shapes[i]);
                        shapes.RemoveAt(i);
                        clb_listHinh.Items.RemoveAt(i);
                        i--;
                    }
                }
                this.shapes.Add(newGroup);
                string a = shapes[shapes.Count - 1].ShowProp();
                clb_listHinh.Items.Add(a);
                this.bePainted1.Refresh();
            }
        }

        private void btnUnGroup_Click(object sender, EventArgs e)
        {

            if (clb_listHinh.CheckedItems.Count >= 1)
            {
                for (int i = 0; i < shapes.Count; i++)
                {
                    if (shapes[i]._thisShapeIsChoosing)
                    {
                        if(shapes[i]._name=="Picture")
                        {
                            Picture pic = shapes[i] as Picture;
                            shapes.RemoveAt(i);
                            clb_listHinh.Items.RemoveAt(i);
                            while (pic.picture.Count>0)
                            {
                                shapes.Add(pic.picture[pic.picture.Count - 1]);
                                pic.picture.RemoveAt(pic.picture.Count - 1);
                                string a = shapes[shapes.Count - 1].ShowProp();
                                clb_listHinh.Items.Add(a);
                            }
                        }
                    }
                }
                for (int i = 0; i < shapes.Count; i++)
                {
                    shapes[i]._thisShapeIsChoosing = false;
                }
                UnCheckAll();
                this.bePainted1.Refresh();
            }
        }
        #endregion

        #region Key Event

        private void clb_listHinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (clb_listHinh.CheckedItems.Count != 0)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    for (int i = 0; i < shapes.Count; i++)
                    {
                        if (shapes[i]._thisShapeIsChoosing)
                        {
                            shapes.RemoveAt(i);
                            clb_listHinh.Items.RemoveAt(i);
                            i--;
                        }
                    }
                    this.bePainted1.Refresh();
                }
                else if((e.KeyCode == Keys.Up))
                {
                    Point distance = new Point(0, -5);
                    shapes[IndexMoving].Moving(distance);
                    this.bePainted1.Invalidate();
                }
                else if ((e.KeyCode == Keys.Down))
                {
                    Point distance = new Point(0, 5);
                    shapes[IndexMoving].Moving(distance);
                    this.bePainted1.Invalidate();
                }
                else if ((e.KeyCode == Keys.Left))
                {
                    Point distance = new Point(-5, 0);
                    shapes[IndexMoving].Moving(distance);
                    this.bePainted1.Invalidate();
                }
                else if ((e.KeyCode == Keys.Right))
                {
                    Point distance = new Point(5, 0);
                    shapes[IndexMoving].Moving(distance);
                    this.bePainted1.Invalidate();
                }
            }
        }
        #endregion

        private void btnClear_Click(object sender, EventArgs e)
        {
            while(shapes.Count>0)
            {
                shapes.RemoveAt(shapes.Count - 1);
               // clb_listHinh.Items.Clear();
            }
            clb_listHinh.Items.Clear();
            //shapes.RemoveAt
            this.bePainted1.Refresh();
        }

        private void rdb_NoFill_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_NoFill.Checked)
            {
                btn_colorFill.Enabled = false;
                label4.Enabled = false;
            }    

            else if (rdb_Fill.Checked)
            {
                btn_colorFill.Enabled = true;
                label4.Enabled = true;
            }
        }


    }
}
