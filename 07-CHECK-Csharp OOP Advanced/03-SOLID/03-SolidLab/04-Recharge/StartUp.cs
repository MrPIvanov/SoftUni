public class StartUp
{
    static void Main()
    {
        var employee = new Employee("1");
        var robot = new Robot("1", 10);

        employee.Work(5);
        employee.Sleep();
        //employee.Recharge();  //Employee dont have Recharge

        robot.Work(5);
        robot.Recharge();
        //robot.Sleep();   //Robot dont dave Sleep
    }
}