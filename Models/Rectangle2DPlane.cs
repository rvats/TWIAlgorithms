namespace Models
{
    public class Rectangle2DPlane : IRectangle2DPlane
    {
        public int BottomX;
        public int BottomY;
        public int TopX;
        public int TopY;

        public Rectangle2DPlane(int x1, int y1, int x2, int y2)
        {
            BottomX = x1; BottomY = y1;
            TopX = x2; TopY = y2;
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
