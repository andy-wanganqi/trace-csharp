namespace CSharp70.ExpandedExpressionBodiedMembers
{
    public class Rectangle
    {
        private int width;
        private int height;

        public int Width
        {
            get => width;
            set => width = value;
        }
        public int Height
        {
            get => height;
            set => height = value;
        }

        public Rectangle() { }
        public Rectangle(int width) => this.width = width;
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public string Calculation => $"{width} * {height}";
        public int Area() => width * height;
        public override string ToString() => $"Rectangle with width {width} and height {height}";

        ~Rectangle() => Console.WriteLine($"Rectangle finalizer is executing.");
    }

    public class Sports
    {
        private string[] types = { "Baseball", "Basketball", "Football",
                              "Hockey", "Soccer", "Tennis",
                              "Volleyball" };

        public string this[int i]
        {
            get => types[i];
            set => types[i] = value;
        }
    }
}
