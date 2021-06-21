using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeelUrPain
{
    class Picture:Shape, IGroupOperator
    {
        public Picture()
        {
            this._name = "Picture";
        }
        public List<Shape> picture { get; set; } = new List<Shape>();
        
        public override string ShowProp()
        {
            string somestring = "";
            somestring = this._name + "{(" + this.minPic().X + "," + this.minPic().Y + "),(" + this.maxPic().X + "," + this.maxPic().Y + ")}";
            return somestring;
        }
        private Point minPic()
        {
            if (this.picture.Count > 0)
            {
                Point isthis = this.picture[0].UpperLeft;
                for (int i = 1; i < this.picture.Count; i++)
                {
                    isthis = ToDo.MinPoint(isthis, this.picture[i].UpperLeft);
                }
                return isthis;
            }
            else return new Point(0, 0);
        }
        private Point maxPic()
        {
            if (this.picture.Count > 0)
            {
                Point isthis = this.picture[0].LowwerRight;
                for (int i = 0; i < this.picture.Count; i++)
                {
                    isthis = ToDo.MaxPoint(isthis, this.picture[i].LowwerRight);
                }
                return isthis;
            }
            else
                return new Point(0, 0);
        }
        public override void Drawing(Graphics g)
        {
            if(this._thisShapeIsChoosing)
            {   
                foreach (Shape i in this.picture)
                {
                    i._thisShapeIsChoosing = true;
                }
            }
            else
            {
                foreach (Shape i in this.picture)
                {
                    i._thisShapeIsChoosing = false;
                }
            }
            this.UpperLeft = this.minPic();
            this.LowwerRight = this.maxPic();
            foreach (Shape i in this.picture)
            {
                i.Drawing(g);
            }

            this.DrawChoose(g);
            this.SetZoomingPoint();
        }
        public override void Moving(Point a)
        {
            foreach (Shape i in this.picture)
            {
                i.Moving(a);
            }
        }
        public override void Zoomming(Point a)
        {
            foreach (Shape i in this.picture)
            {
                i.Zoomming(a);
            }
        }


        public void Group(Shape shape)
        {
            this.picture.Add(shape);
        }
        public void Group(Picture pic)
        {
            this.picture.Add(pic);
        }
    }
}
