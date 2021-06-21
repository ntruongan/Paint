using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeelUrPain
{
    class Bezier : Shape
    {
        public List<Point> points { get; set; } = new List<Point>();
        public Bezier()
        {
            this._name = "Bezier";
        }
        public override void Drawing(Graphics g)
        {
            GraphicsPath a = new GraphicsPath();
            if (points.Count == 2)
            {
                a.AddLine(points[0], points[1]);
            }  
            else if (points.Count == 3)
            {
                a.AddLine(points[0], points[1]);
                a.AddLine(points[1], points[2]);
            }    

            else if (points.Count == 4)
                a.AddBeziers(points.ToArray());


            this.UpperLeft = minInPoly();
            this.LowwerRight = maxInPoly();
            if (this._thisShapeIsChoosing)
            {
                if (!this._fill)
                    g.DrawPath(new Pen(Color.Gray, 3) { DashStyle = this._dashStyle }, a);
                else
                {
                    g.FillPath(new SolidBrush(this._lcolorFill), a);
                    g.DrawPath(new Pen(Color.Gray, 3) { DashStyle = this._dashStyle }, a);
                }
                this.UpperLeft = minInPoly();
                this.LowwerRight = maxInPoly();
                this.DrawChoose(g);
            }
            else if (!this._fill)
                g.DrawPath(new Pen(this._lcolor, this._lwidth) { DashStyle = this._dashStyle }, a);
            else
            {
                g.FillPath(new SolidBrush(this._lcolorFill), a);
                g.DrawPath(new Pen(this._lcolor, this._lwidth) { DashStyle = this._dashStyle }, a);

            }
            this.UpperLeft = minInPoly();
            this.LowwerRight = maxInPoly();
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
            for (int i = 0; i < points.Count; i++)
            {
                points[i] = ToDo.AddPoint(points[i], point);
            }
        }
        public override void Zoomming(Point Vector)
        {
            this._endPoint = ToDo.AddPoint(this._endPoint, Vector);
            for (int i = 1; i < points.Count; i++)
            {
                points[i] = ToDo.AddPoint(points[i], Vector);
            }
        }
        private Point minInPoly()
        {
            Point isthis = new Point(99999, 99999);
            for (int i = 0; i < points.Count; i++)
            {
                if (points[i].X <= isthis.X)
                {
                    isthis.X = points[i].X;
                }
                if (points[i].Y <= isthis.Y)
                {
                    isthis.Y = points[i].Y;
                }
            }
            return isthis;
        }
        private Point maxInPoly()
        {
            Point isthis = new Point(-1, -1);
            for (int i = 0; i < points.Count; i++)
            {
                if (points[i].X >= isthis.X)
                {
                    isthis.X = points[i].X;
                }
                if (points[i].Y >= isthis.Y)
                {
                    isthis.Y = points[i].Y;
                }
            }
            return isthis;
        }
    }
}
