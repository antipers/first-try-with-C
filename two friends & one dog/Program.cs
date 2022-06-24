int count = 0;
int first_friend_speed = 1;
int second_friend_speed = 2;
int dog_speed = 5;
int distance = 10000;
int end = 10;
int friend = 2;
while (distance > end)
{
    
    if (friend == 1)
    {
        int time = distance / (first_friend_speed + dog_speed);
        distance = distance - ((first_friend_speed + second_friend_speed) * time);
        friend = 2;
        count++;
    }
    if (friend == 2)
    {
      int time = distance / (second_friend_speed + dog_speed);
      distance = distance - ((first_friend_speed + second_friend_speed) * time);
      friend = 1 ; 
      count++;
    }

}
  Console.WriteLine("Собака пробежит- ");
  Console.Write(count);