using ChallangeApp;

var employee = new Employee("Adam", "Kamizelich");
employee.AddGrade(2);
employee.AddGrade(2);
employee.AddGrade(6);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

// referencja
SetSth(out statistics);
// metoda na brak mozliwosci nadpisania statystyk
void SetSth(out Statistics statistics)
{
    statistics = new Statistics();
    //statistics = new Statistics();
}