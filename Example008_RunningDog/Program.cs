Console.Write("Введите расстояние между друзьями (в метрах): ");
double distance = 0.001 * Convert.ToDouble(Console.ReadLine ()); //Дистанцию переводим в километры для более корректного подсчета

Console.Write("Введите скорость первого друга, от которого стартует собака (км/ч): ");
double firstFriendSpeed = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите скорость второго друга, к которому стартует собака (км/ч): ");
double secondFriendSpeed = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите скорость собаки (км/ч): ");
double dogSpeed = Convert.ToDouble(Console.ReadLine());

int count = 0;                  // Счетчик
bool ToFriend2 = true;          // Изначально собака бежит ко второму другу
double time;                    // Объявили переменную time

while (distance > 0.01)         // Пока дистанция между ними больше 10 метров, выполняем цикл
{
    if (ToFriend2 == true)
    {
        time = distance / (secondFriendSpeed + dogSpeed); 
        ToFriend2 = false;
    }
    else
    {
        time = distance / (firstFriendSpeed + dogSpeed); 
        ToFriend2 = true;
    }

distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
count++;
}

Console.Write ("Собака пробежит ");
Console.Write (count);
Console.Write (" раз(а).");