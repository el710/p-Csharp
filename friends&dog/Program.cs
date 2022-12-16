
int sprintCount = 0;
int distance = 0;
int firstFriendSpeed = 7, secondFriendSpeed = 7,
    dogSpeed = 13;
int dogFriend = 2;

int time;
int tryTimes = 2;

Console.Clear();

Console.WriteLine("   Here the history about two friends and their dog.");
Console.WriteLine("There were friends who went to each other and dog run between them from one to another until friends met");
Console.WriteLine("And who knows how many times dog made a sprint");

while(distance <= 0){

    Console.Write("--- give me the distance between friends (more than 0): ");
    string line = Console.ReadLine() ?? "";
    distance = int.Parse(line);
 
    if(distance <= 0 && tryTimes > 0){
        Console.WriteLine($"--- try one more time - {tryTimes}");
    }
    else 
    if(distance > 0){
        Console.WriteLine($"So, the distance between frinds was {distance}...");
    }
   
    if(tryTimes == 0 && distance == 0){
        Console.WriteLine("Ok man, distance was about 10000 metres...");
        distance = 10000;
    } 
    tryTimes--;
}

Console.Write("--- do you know how fast first friend was going?: ");
string speed = Console.ReadLine() ?? "";
firstFriendSpeed = int.Parse(speed);
 
if(firstFriendSpeed < 7){
    Console.WriteLine("No, it was 7");
    firstFriendSpeed = 7;
}
else
if(firstFriendSpeed == 7){
    Console.WriteLine("Yea, it was 7");
}
else {
    Console.WriteLine($"{firstFriendSpeed}? really");
}

Console.Write("--- and what about the second?: ");
speed = Console.ReadLine() ?? "";
secondFriendSpeed = int.Parse(speed);
 
if(secondFriendSpeed < 7){
    Console.WriteLine("No, it was 7");
    secondFriendSpeed = 7;
}
else
if(secondFriendSpeed == 7){
    Console.WriteLine("Yea, it was 7");
}
else {
    Console.WriteLine($"{secondFriendSpeed}? maybe");
}

Console.WriteLine($"You know the speed of dog was {dogSpeed}");


while(distance > (dogSpeed+firstFriendSpeed+secondFriendSpeed)){
    
    if(dogFriend == 1){
        time =  distance / (dogSpeed + firstFriendSpeed);
        dogFriend = 1;
    }
    else
    {
        time =  distance / (dogSpeed + secondFriendSpeed);
        dogFriend = 2;
    }

    distance = distance - time * (firstFriendSpeed + secondFriendSpeed);
    sprintCount++;
    Console.WriteLine($"after {sprintCount} time dog run {distance} m. for {time} instances");
}

Console.WriteLine($"And so dog had made {sprintCount} sprints.");
Console.WriteLine("The end.");