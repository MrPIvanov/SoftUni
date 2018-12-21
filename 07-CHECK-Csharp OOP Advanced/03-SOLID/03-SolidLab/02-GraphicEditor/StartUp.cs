public class StartUp
{
    static void Main()
    {
        var editor = new GraphicEditor();

        System.Console.WriteLine(editor.DrawShape(new Circle()));
        System.Console.WriteLine(editor.DrawShape(new Square()));
        System.Console.WriteLine(editor.DrawShape(new Rectangle()));
    }
}