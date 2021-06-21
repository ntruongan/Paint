using System.Drawing;
using System.Drawing.Drawing2D;

namespace FeelUrPain
{
    class Line:Shape
    {

        public Line()
        {
            this._name = "Line";
        }

        public override void Drawing(Graphics g)
        {
            GraphicsPath a = new GraphicsPath();
            a.AddLine(this._beginPoint, this._endPoint);
            if (this._thisShapeIsChoosing)
            {
                g.DrawPath(new Pen(Color.Gray, 2) { DashStyle = this._dashStyle }, a);
                this.UpperLeft = new Point(ToDo.min(this._beginPoint.X, this._endPoint.X), ToDo.min(this._beginPoint.Y, this._endPoint.Y));
                this.LowwerRight = new Point(ToDo.max(this._beginPoint.X, this._endPoint.X), ToDo.max(this._beginPoint.Y, this._endPoint.Y));
                this.DrawChoose(g);
            }
            else
                g.DrawPath(new Pen(this._lcolor, this._lwidth) { DashStyle = _dashStyle }, a);
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
        //public override int get_X(Point a)
        //{
        //    return a.X;
        //}
        //public override int get_Y(Point a)
        //{
        //    return a.Y;
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
