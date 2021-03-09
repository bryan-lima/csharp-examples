namespace Classes.Heritage
{
    public class Point
    {
        public int x, y;

        private int distance;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected void CalculateDistance()
        {
            // Do something...
        }

        private void CalculateDistance2()
        {
            // Do something...
        }

        public virtual void CalculateDistance3()
        {
            // Do something...
        }
    }
}