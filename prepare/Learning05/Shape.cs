// See the comment below about the abstract method. Because we have an abstract method,
// this class must also be declared as an abstract class.
public abstract class Shape {
    private string _color;
    public abstract double GetArea();
    public Shape(string color) {
        _color = color;
    }
    public string GetColor() {
        return _color;
    }
}