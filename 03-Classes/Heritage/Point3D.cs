namespace Classes.Heritage
{
    public class Point3D : Point
    {
        public int z;

        public Point3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
            CalculateDistance();
        }

        public static void Calculate()
        {
            // Do something...
        }

        public override void CalculateDistance3()
        {
            // Do something...
        }
    }
}