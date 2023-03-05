
Console.Write("Введите расстояние между друзьями: ");
int distance = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость первого друга: ");
int firstFriendSpeed = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость второго друга: ");
int secondFriendSpeed = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость собаки: ");
int dogSpeed = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное расстояние между друзьями: ");
int minDistance = Convert.ToInt32(Console.ReadLine());

int count = 0;
int time = 0;
int dogDirection = 12;

while(distance > minDistance) {
    if(dogDirection == 12) {
        time = distance / (secondFriendSpeed + dogSpeed);
        dogDirection = 21;
    } else {
        time = distance / (firstFriendSpeed + dogSpeed);
        dogDirection = 12;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;

    Console.WriteLine("Дистанция между друзьями составляет: " + distance + " метров.");
}

Console.Write("Собака пробежала между друзьями до их встречи " + count + " раз.");

