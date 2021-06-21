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
    class Circl : Shape
    {
        public double Diameter;
        public Circl()
        {
            this._name = "Circle";
        }
        public override void Drawing(Graphics g)
        {
            GraphicsPath a = new GraphicsPath();
            this.Diameter = (((_endPoint.X - _beginPoint.X)) + ((_endPoint.Y - _beginPoint.Y))) / 2;
            RectangleF ab = new RectangleF();
            ab.Location = this._beginPoint;
            ab.Width = (float)this.Diameter;
            ab.Height = (float)this.Diameter;
            a.AddEllipse(ab);
            #region Function Point
            this.UpperLeft = new Point(ToDo.min(this._beginPoint.X, this._endPoint.X), ToDo.min(this._beginPoint.Y, this._endPoint.Y));
            if (this.UpperLeft == this._beginPoint)
            {
                this.LowwerRight = new Point(_beginPoint.X + (int)this.Diameter, _beginPoint.Y + (int)Diameter);

            }
            else
            {
                this.LowwerRight = this._beginPoint;
                this.UpperLeft = new Point(this._beginPoint.X - (int)this.Diameter, this._beginPoint.Y - (int)Diameter);
            }
            #endregion
            //this.LowwerRight = new Point(ToDo.max(this._beginPoint.X, this._endPoint.X), ToDo.max(this._beginPoint.Y, this._endPoint.Y));
            if (this._thisShapeIsChoosing)
            {
                if (!this._fill)
                { }
                   // g.DrawPath(new Pen(Color.Gray, 3) { DashStyle = this._dashStyle }, a);
                else
                {
                    g.FillPath(new SolidBrush(this._lcolorFill), a);
                    //g.DrawPath(new Pen(Color.Gray, 3) { DashStyle = this._dashStyle }, a);
                }
                this.DrawChoose(g);
            }
            else if (!_fill)
                g.DrawPath(new Pen(this._lcolor, this._lwidth) { DashStyle = this._dashStyle }, a);
            else
            {
                g.FillPath(new SolidBrush(this._lcolorFill), a);
                g.DrawPath(new Pen(this._lcolor, this._lwidth) { DashStyle = this._dashStyle }, a);
                //g.FillPath(new SolidBrush(this._lcolorFill), a);
            }
            this.SetZoomingPoint();
            //   this.UpperLeft = new Point(ToDo.min(this._beginPoint.X, this._endPoint.X), ToDo.min(this._beginPoint.Y, this._endPoint.Y));
            //   this.LowwerRight = new Point(ToDo.max(this._beginPoint.X, this._endPoint.X), ToDo.max(this._beginPoint.Y, this._endPoint.Y));
        }

        public override string ShowProp()
        {
            string somestring = null;
            somestring = this._name + "{(" + this._beginPoint.X + "," + this._beginPoint.Y + "),(" + this._endPoint.X + "," + this._endPoint.Y + ")}";
            return somestring;
        }
        //public override int get_X(Point a)
        //{
        //    return a.X;
        //}
        //public override int get_Y(Point a)
        //{
        //    return a.Y;
        //}
        //public override Point ADDPoint(Point a, Point b)
        //{
        //    Point k = new Point();
        //    k.X = a.X + b.X;
        //    k.Y = a.Y + b.Y;
        //    return k;
        //}
        public override void Moving(Point point)
        {
            this._beginPoint = ToDo.AddPoint(this._beginPoint, point);
            this._endPoint = ToDo.AddPoint(this._endPoint, point);
        }
        public override void Zoomming(Point Vector)
        {
            this._endPoint = ToDo.AddPoint(this._endPoint, Vector);
        }
    }
}
