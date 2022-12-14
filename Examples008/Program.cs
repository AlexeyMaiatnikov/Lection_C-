double
    distance = 10000,
    firstFriendSpeed = 1,
    secondFriendSpeed = 2,
    dogSpeed = 5,
    count = 0,
    time = 0,
    friend = 2;

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (secondFriendSpeed - firstFriendSpeed) * time;
    count = count + 1;
}
Console.Write("Собака пробежит: ");
Console.Write(count);
Console.Write(" раз.");
