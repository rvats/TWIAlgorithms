namespace Models
{
    public class Rectangle2DPlane : IRectangle2DPlane
    {
        public Point Bottom = new Point();
        public Point Top = new Point();

        public Rectangle2DPlane(int x1, int y1, int x2, int y2)
        {
            Bottom.X = x1; Bottom.Y = y1;
            Top.X = x2; Top.Y = y2;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
