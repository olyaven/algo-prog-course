Console.WriteLine("Hello, World!");

string myName = "Захарова Оля";
string groupName = "ИСП-252";
int courseNumber = 2;
double averageGrade = 4.9;
bool isBudget = true;

const int birthYear = 2008;
int currentYear = 2026;
int age = currentYear - birthYear;
//дата рождения КОНСТАНТА!!!! она очень логичная 

double physicsGrade = 5.0;
double mathematicsGrade = 5.0;
double programmingGrade = 4.0;

double subjectAverage = (physicsGrade + mathematicsGrade + programmingGrade) / 3;
//я закончила создавать переменные и расчеты. теперь переходим к тому, чтобы выводить их

Console.WriteLine("ВИЗИТКА СТУДЕНТА");
Console.WriteLine();

Console.WriteLine($"Имя: {myName}");
Console.WriteLine($"Группа: {groupName}");
Console.WriteLine($"Курс: {courseNumber}");
Console.WriteLine($"Возраст: {age}");
Console.WriteLine($"Средний балл: {averageGrade}");
Console.WriteLine($"Бюджетное место: {isBudget}");
Console.WriteLine();

Console.WriteLine("Средний балл по предметам:");
Console.WriteLine($"Физика: {physicsGrade}");
Console.WriteLine($"Математика: {mathematicsGrade}");
Console.WriteLine($"Программирование: {programmingGrade}");
Console.WriteLine($"Средний результат: {subjectAverage}");
