class Program {
    static void Main(string[] args) {
        List<Shape> shapes = new List<Shape>();
        Square shape1 = new Square("Purple", 18);
        Rectangle shape2 = new Rectangle("[Missing Texture]", 2, 7);
        Circle shape3 = new Circle("Barf", 314);
        shapes.Add(shape1);
        shapes.Add(shape2);
        shapes.Add(shape3);

        foreach (Shape shape in shapes) {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color}-colored shape has an area of {area}.");
        }
    }
}