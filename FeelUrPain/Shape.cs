using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace FeelUrPain
{

    abstract class Shape
    {
        public const int Limit = 30;
        public Point UpperLeft { get; set; }
        public Point LowwerRight { get; set; }
        public Point _beginPoint { get; set; }
        public Point _endPoint { get; set; }
        public Color _lcolor { get; set; }
        public Color _lcolorFill { get; set; }
        public bool _thisShapeIsChoosing { get; set; }
        public int _lwidth { get; set; }
        public bool _fill { get; set; }
        public Rectangle ToMoving_rec { get; set; }
        public string _name { get; set; }
       // public Ellipse Choose { get; set; }

        public DashStyle _dashStyle { get; set; }

        public abstract void Drawing(Graphics g);
        
        public void DrawChoose(Graphics g)
        {
            g.DrawRectangle(new Pen(Color.Gray, 3) { DashStyle = DashStyle.Dash },
            this.UpperLeft.X, this.UpperLeft.Y,
            this.LowwerRight.X - this.UpperLeft.X,
            this.LowwerRight.Y - this.UpperLeft.Y);
            g.DrawEllipse(new Pen(Color.Blue, 3), LowwerRight.X, LowwerRight.Y, 3, 3);
            g.DrawEllipse(new Pen(Color.Blue, 3), UpperLeft.X, UpperLeft.Y, 3, 3);
        }
        public void SetZoomingPoint()
        {
            Rectangle abrec = new Rectangle();
            abrec.UpperLeft = new Point(LowwerRight.X - Limit, LowwerRight.Y - Limit);
            abrec.LowwerRight = new Point(LowwerRight.X + Limit, LowwerRight.Y + Limit);
            ToMoving_rec = abrec;
        }
        public abstract string ShowProp();
        public abstract void Zoomming(Point Vector);
        public abstract void Moving(Point a);
    }
}
