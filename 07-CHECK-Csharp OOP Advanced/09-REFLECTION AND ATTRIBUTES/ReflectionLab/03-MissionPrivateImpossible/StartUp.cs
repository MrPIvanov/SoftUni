public class StartUp
{
    static void Main()
    {
        var spy = new Spy();

        //var result = spy.StealFieldInfo("Hacker", "username", "password");
        //var result = spy.AnalyzeAcessModifiers("Hacker");
        var result = spy.RevealPrivateMethods("Hacker");

        System.Console.WriteLine(result);
    }

}