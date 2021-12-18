Console.Write("Введите расстояние между друзьями (в метрах): ");
double distance = Convert.ToDouble(Console.ReadLine ());

Console.Write("Введите скорость первого друга, от которого стартует собака (км/ч): ");
double firstFriendSpeed = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите скорость второго друга, к которому стартует собака (км/ч): ");
double secondFriendSpeed = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите скорость собаки (км/ч): ");
double dogSpeed = Convert.ToDouble(Console.ReadLine());

int count = 0;          // Счетчик
int friend = 2;         // Изначально собака бежит ко второму другу
double time = 0;            // Объявили переменную time

while (distance < 10)
{
    if (friend = 2)
    {
        time = distance*0.001 / ( secondFriendSpeed + dogSpeed); //Дистанцию переводим в километры для более корректного подсчета
        friend = 1;
    }
    else
    {
        time = distance*0.001 / ( firstFriendSpeed + dogSpeed); //Дистанцию переводим в километры для более корректного подсчета
        friend = 2;
    }

distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
count++;
}

Console.Write ("Собака пробежит ");
Console.Write (count);
Console.Write (" раз.");