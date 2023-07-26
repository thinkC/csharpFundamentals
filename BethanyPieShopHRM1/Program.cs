// See https://aka.ms/new-console-template for more information
using BethanyPieShopHRM1;

Console.WriteLine("Creating Employee");
Console.WriteLine("---------------------\n");

Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);

bethany.DisplayEmployeeDetails();
bethany.PerformWork();
bethany.PerformWork();
bethany.PerformedWork(5);
bethany.PerformWork();
bethany.PerformedWork(25);

//int minimumBonus = 100;
//int bonusTax = 0;
//int receivedBonus = bethany.CalculateBonusAndBonusTax(minimumBonus, ref bonusTax);
//Console.WriteLine($"The minimum bonus is {minimumBonus}, the bonus tax is {bonusTax} and {bethany.firstName} has received a bonus of {receivedBonus} ");

int minimumBonus = 100;
int bonusTax;
int receivedBonus = bethany.CalculateBonusAndBonusTax(minimumBonus, out bonusTax);
Console.WriteLine($"The minimum bonus is {minimumBonus}, the bonus tax is {bonusTax} and {bethany.firstName} has received a bonus of {receivedBonus} ");

double receivedWageBethany = bethany.ReceiveWage(true);
Console.WriteLine($"Wage paid {receivedWageBethany}");

Employee john = new Employee("John", "Douglas", "john.douglas@gmail.com", new DateTime(1981, 2, 20), 25);
john.DisplayEmployeeDetails();
john.PerformWork();
john.PerformedWork(12);

double receivedWageJohn = john.ReceiveWage(true);
Console.WriteLine($"Wage paid {receivedWageJohn}");