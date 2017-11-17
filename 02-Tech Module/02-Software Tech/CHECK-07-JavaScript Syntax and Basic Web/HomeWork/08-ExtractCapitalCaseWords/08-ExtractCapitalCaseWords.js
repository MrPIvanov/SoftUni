function solution(input) {


    let result = input.join('').match(/\b[A-Z]+\b/g);
    console.log(result.join(', '));


}
solution(["We start by HTML, CSS, JavaScript, JSON and REST.\n" +
"Later we touch some PHP, MySQL and SQL.\n" +
"Later we play with C#, EF, SQL Server and ASP.NET MVC.\n" +
"Finally, we touch some Java, Hibernate and Spring.MVC.\n"]);