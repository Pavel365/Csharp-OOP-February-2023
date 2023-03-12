using System;

namespace P02.Graphic_Editor
{
    public class StartUp
    {
        static void Main()
        {
            IShape circle = new Circle();
            IShape square = new Square();

            GraphicEditor editor = new GraphicEditor();
            editor.DrawShape(circle);
            editor.DrawShape(square);
        }
    }
}
