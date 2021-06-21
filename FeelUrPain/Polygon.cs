using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace FeelUrPain
{
    class Polygon:Shape
    {
        public Point _pointTemp { get; set; } = new Point();
        public List<Point> points { get; set; } = new List<Point>();
        public Polygon()
        {
            this._name = "Polygon";
        }
        public override void Drawing(Graphics g)
        {
           // this.points.Add(this._endPoint);
            GraphicsPath a = new GraphicsPath();
            Polygon polygon = new Polygon();

            if (points.Count < 3)
                a.AddLine(points[0], points[1]);
            else
                a.AddPolygon(points.ToArray());
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

        private Point minInPoly()
        {
            Point isthis = new Point(99999,99999);
            for(int i=0;i<points.Count;i++)
            {
                if(points[i].X<=isthis.X)
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
            for(int i = 0;i<points.Count;i++)
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



    }
}

