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
    class Square:Shape 
    {
        private int Diameter;
        public Square()
        {
            this._name = "Square";
        }
        public override void Drawing(Graphics g)
        {
            GraphicsPath a = new GraphicsPath();
            this.Diameter = ((Math.Abs(_endPoint.X - _beginPoint.X)) + Math.Abs((_endPoint.Y - _beginPoint.Y))) / 2;
            //this.Diameter = ((Math.Abs(_endPoint.X - _beginPoint.X)) + Math.Abs((_endPoint.Y - _beginPoint.Y))) / 2;
            //RectangleF ab = new RectangleF();
            //ab.Location = this._beginPoint;
            //ab.Width = (float)this.Diameter;
            //ab.Height = (float)this.Diameter;

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
            if (_endPoint.X < _beginPoint.X && _endPoint.Y < _beginPoint.Y)
            {
                a.AddRectangle(new System.Drawing.Rectangle(new Point(_beginPoint.X - Diameter, _beginPoint.Y - Diameter), new Size(Diameter, Diameter)));
            }
            else if (_beginPoint.X > _endPoint.X && _beginPoint.Y < _endPoint.Y)
            {
                a.AddRectangle(new System.Drawing.Rectangle(new Point(_beginPoint.X - Diameter, _beginPoint.Y), new Size(Diameter, Diameter)));
            }
            else if (_beginPoint.X < _endPoint.X && _beginPoint.Y > _endPoint.Y)
            {
                a.AddRectangle(new System.Drawing.Rectangle(new Point(_beginPoint.X, _endPoint.Y), new Size(Diameter, Diameter)));
            }
            else
            {
                a.AddRectangle(new System.Drawing.Rectangle(_beginPoint, new Size(Diameter, Diameter)));
            }




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
            else
            if (!this._fill)
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
