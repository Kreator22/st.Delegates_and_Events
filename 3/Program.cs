// Задание 3. Напишите программу, в которой есть класс с событием.
// Событие обрабатывается методами, имеющими текстовый аргумент и не возвращающими результат.

// У класса должно быть текстовое поле, в которое при создании объекта класса записывается название объекта.
// В классе должен быть описан метод для генерирования события, который вызывается без аргументов.
// При генерировании события аргументом передается значение текстового поля объекта, генерирующего событие.

// Еще один класс, описанный в программе, должен содержать метод с текстовым аргументом, не возвращающий результат.
// При вызове метод отображает значение своего текстового аргумента.

// В главном методе программы необходимо создать два объекта первого класса и один объект второго класса.
// Для событий объектов первого класса обработчиком регистрируется метод объекта второго класса
// (получается, что метод одного и того же объекта зарегистрирован обработчиком для событий двух объектов).
// Для каждого из объектов первого класса необходимо сгенерировать событие.
// При этом метод, зарегистрированный обработчиком, должен выводить название объекта, сгенерировавшего событие.
// https://it.kgsu.ru/C_Sharp/csharp2010_187.html


EventsGeneratorNamed generator_1 = new("Events generator 1");
EventsGeneratorNamed generator_2 = new("Events generator 2");
Printer printer = new();

generator_1.EventHandler += printer.Print;
generator_1.GenerateEvent();
generator_2.EventHandler += printer.Print;
generator_2.GenerateEvent();

class EventsGeneratorNamed
{
    public string name { get; private set; }
    public event Event? EventHandler;
    public EventsGeneratorNamed(string name)
    {
        this.name = name;
    }
    public void GenerateEvent()
    {
        if(EventHandler is not null)  
            EventHandler(name);
    }
}

class Printer
{
    public void Print(string str) => Console.WriteLine(str);
}

    delegate void Event(string str);