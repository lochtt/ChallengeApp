
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Sources;
using zadanie;

Employee employee1 = new Employee("Jakub", "Kowalski", 18 );
Employee employee2 = new Employee("Mateusz", "Kowalski", 28);
Employee employee3 = new Employee("Adam", "Kowalski", 25);

employee1.AddScore(6);
employee1.AddScore(3);
employee1.AddScore(6);
employee1.AddScore(9);
employee1.AddScore(2);

employee2.AddScore(1);
employee2.AddScore(5);
employee2.AddScore(6);
employee2.AddScore(5);
employee2.AddScore(6);

employee3.AddScore(1);
employee3.AddScore(7);
employee3.AddScore(5);
employee3.AddScore(1);
employee3.AddScore(1);

var result = employee1.Result;
var result2 = employee2.Result;
var result3 = employee3.Result;

Console.WriteLine($"Wynik punktowy dla pracownika nr 1 = {result}" + "\n" );
Console.WriteLine($"Wynik punktowy dla pracownika nr 2 = {result2}" + "\n");
Console.WriteLine($"Wynik punktowy dla pracownika nr 3 = {result3}" + "\n");


List<Employee> employees = new List<Employee>()
{
    employee1,employee2,employee3
};

int maxResult = -1;
Employee userWithMaxResult = null;

foreach (var employee in employees )
{
    if( employee.Result > maxResult )
    {
        userWithMaxResult = employee ;
        maxResult = employee.Result ;
    }
   
}
Console.WriteLine($"Użytkownik z największym wynikiem punktowym :" + "\n" + ("Imię:" + " " + userWithMaxResult.Name + "\n" + "Nazwisko:" + " " + userWithMaxResult.Surname + "\n" + "Wiek:" + " " + userWithMaxResult.Age + "\n" + "Zdobyte punkty:" + userWithMaxResult.Result));
