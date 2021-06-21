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
    class Ellipse:Shape
    {
        //public double Diameter;
        private float Height;
        private float Width;
        public Ellipse()
        {
            this._name = "Ellipse";
        }
        public override void Drawing(Graphics g)
        {
            GraphicsPath a = new GraphicsPath();
            RectangleF ab = new RectangleF();
            ab.Location = this._beginPoint;
            this.Height = (_endPoint.Y - _beginPoint.Y);
            this.Width = (_endPoint.X - _beginPoint.X);

            ab.Width = this.Width;
            ab.Height = this.Height;
            a.AddEllipse(ab);
            if (this._thisShapeIsChoosing)
            {
                if (!this._fill)
                    g.DrawPath(new Pen(Color.Gray, 3) { DashStyle = this._dashStyle }, a);
                else
                {
                    g.FillPath(new SolidBrush(this._lcolorFill), a);
                    g.DrawPath(new Pen(Color.Gray, 3) { DashStyle = this._dashStyle }, a);
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
