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
    class Rectangle:Shape
    {
        //private float Diameter;
        private int Height;
        private int Width;
        public Rectangle()
        {
            this._name = "Rectangle";
        }
        public override void Drawing(Graphics g)
        {
            GraphicsPath a = new GraphicsPath();
            this.Height = Math.Abs(_endPoint.Y - _beginPoint.Y);
            this.Width = Math.Abs(_endPoint.X - _beginPoint.X);
            System.Drawing.Rectangle ab = new System.Drawing.Rectangle();
            ab.Width = Math.Abs(this.Width);
            ab.Height = Math.Abs(this.Height);
            #region SetLocation
            if (_endPoint.X < _beginPoint.X && _endPoint.Y < _beginPoint.Y)
            {
                ab.Location = _endPoint;
            }
            else if (_beginPoint.X > _endPoint.X && _beginPoint.Y < _endPoint.Y)
            {
                ab.Location = new Point(_endPoint.X, _beginPoint.Y);
            }
            else if (_beginPoint.X < _endPoint.X && _beginPoint.Y > _endPoint.Y)
            {
                ab.Location = new Point(_beginPoint.X, _endPoint.Y);
            }
            else
            {
                ab.Location = _beginPoint;
            }
            #endregion

            a.AddRectangle(ab);
            if (this._thisShapeIsChoosing)
            {
                if (!this._fill)
                {
                }    
                else
                {
                    g.FillPath(new SolidBrush(this._lcolorFill), a);
                }
                this.DrawChoose(g);
            }
            else if (!this._fill)
                g.DrawPath(new Pen(this._lcolor, this._lwidth) { DashStyle = this._dashStyle }, a);
            else
            {
                g.FillPath(new SolidBrush(this._lcolorFill), a);
                g.DrawPath(new Pen(this._lcolor, this._lwidth) { DashStyle = this._dashStyle }, a);
            }

            this.UpperLeft = new Point(ToDo.min(this._beginPoint.X, this._endPoint.X), ToDo.min(this._beginPoint.Y, this._endPoint.Y));
            this.LowwerRight = new Point(ToDo.max(this._beginPoint.X, this._endPoint.X), ToDo.max(this._beginPoint.Y, this._endPoint.Y));
            this.SetZoomingPoint();
        }


        public override string ShowProp()
        {
            string somestring = null;
            somestring = this._name + "{(" + this._beginPoint.X + "," + this._beginPoint.Y + "),(" + this._endPoint.X + "," + this._endPoint.Y + ")}";
            return somestring;
        }


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
