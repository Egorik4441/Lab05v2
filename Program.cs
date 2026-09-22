using System.Data;

int dayNumber = 6;

switch (dayNumber)
{
    case 6 or 7: Console.WriteLine("Выходной"); break;
    default: Console.WriteLine("Будний"); break;
}

int score = 78;

switch (score)
{
    case >= 0 and < 50:
        Console.WriteLine("Неудовлетворительно");
        break;
    case >= 50 and < 70:
        Console.WriteLine("Удовлетворительно");
        break;
    case >= 70 and < 85:
        Console.WriteLine("Хорошо");
        break;
    case >= 85:
        Console.WriteLine("Отлично");
        break;
}

int score = 78;

string result = score switch
{
    >= 85 => "Отлично",
    >= 70 => "Хорошо",
    >= 50 => "Удовлетворительно",
    _ => "Неудовлетворительно",
};

Console.WriteLine(result);

string role = "user";

string result = role switch
{
    "admin" => "Полный доступ",
    not "admin" => "Ограниченный доступ"
};

Console.WriteLine(result);

int age = 20;
bool hasTicket = true;

switch (age)
{
    case >= 18 when hasTicket: Console.WriteLine("Вход разрешён"); break;
    case >= 18 Console.WriteLine("Нет билета"); break;
    default: Console.WriteLine("Возраст не подходит"); break;
}

int level = 2;

switch (level)
{
    case 1:
        Console.WriteLine("Начальный уровень");
        break;
    case 2:
        Console.WriteLine("Средний уровень");
        goto case 1;
    case 3:
        Console.WriteLine("Продвинутый уровень");
        break;
}
int dayNumber = 6;

switch (dayNumber)
{
    case 6 or 7: Console.WriteLine("Выходной"); break;
    default: Console.WriteLine("Будний"); break;
}

int score = 78;

switch(score)
{
    case >= 0 and < 50:
        Console.WriteLine("Неудовлетворительно");
        break;
    case >= 50 and < 70:
        Console.WriteLine("Удовлетворительно");
        break;
    case >= 70 and < 85:
        Console.WriteLine("Хорошо");
        break;
    case >= 85 and < 100:
        Console.WriteLine("Отлично");
        break;
    default:
        Console.WriteLine("Некорректный балл");
        break;                         
}
int score = 78;

string result = score switch
{
    >= 85 => "Отлично",
    >= 70 => "Хорошо",
    >= 50 => "Удовлетворительно",
    >= 0 => "Неудовлетворительно",
    _ => "Некорректный балл"
};

Console.WriteLine(result);

string role = "user";

string result = role switch
{
    "admin" => "Полный доступ",
    not "admin" => "Ограниченный доступ"
};

Console.WriteLine(result);

int age = 20;
bool hasTicket = true;

switch (age)
{
    case >= 19 when hasTicket:
        Console.WriteLine("Вход разрешён");
        break;
    case >= 18:
        Console.WriteLine("Вход разрешён");
        break;
    default:
        Console.WriteLine("Возраст не подходит");
        break;   
}

int level = 2;

switch (level)
{
    case 1:
        Console.WriteLine("Начальный уровень");
        break;
    case 2:
        Console.WriteLine("Начальный уровень");
        goto case 1;
    case 3:
        Console.WriteLine("Продвинутый уровень");
        break;
}


int score = 1;

string result = score switch
{
    >= 12 => "Зима"
    >= 10 => "Весна"
    >= 3 => "Лето"
    >= 2  => "Осень"
    _ => ""
};

Console.WriteLine(result);