// Задание 2. Напишите программу, содержащую статический метод с тремя действительными (тип double) аргументами.
// Результатом статического метода является ссылка на метод, вычисляющий квадратичный трехчлен с коэффициентами,
// определяемыми аргументами статического метода. Другими словами, если статический метод вызывается с числовыми аргументами a, b и с,
// то результатом является ссылка на метод, который для аргумента x типа double результатом вычисляет значение выражения a*x*x+b*x+c.
//https://it.kgsu.ru/C_Sharp/csharp2010_187.html

Calculation Calc = CalcGenerator(1, 1, 1);
Console.WriteLine(Calc(1));

Calc = CalcGenerator(2, 2, 2);
Console.WriteLine(Calc(2));

double result = CalcGenerator(2, 2, 2)(2);
Console.WriteLine(result);

static Calculation CalcGenerator(double a, double b, double c) => (double x) => a * x * x + b * x + c;

delegate double Calculation(double x);