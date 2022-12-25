// Home work 2

int GetNumber(int length){

    int result, trytime = 5;
    int downBorder = (int)Math.Pow(10,length-1),
        upBorder = (int)Math.Pow(10,length);


    while(true){
        if(length != 0) Console.Write($"Input {length}-digit integer number [{downBorder}..{upBorder}): ");
        else Console.Write("> ");

        if(int.TryParse(Console.ReadLine(), out result)){

            if(length == 0){ 
                return result;
            }
            else if(result >= downBorder && result < upBorder){
                Console.WriteLine($"{result} - ok");
                return result;
            }
            else{
                trytime--;
                if(trytime <=0 ) return -1;
                Console.WriteLine($"Attention! wrong length of number. You have {trytime} tryies...");    
            }
        }     
        else{
            trytime--;
            if(trytime <=0 ) return -1;
            Console.WriteLine($"Attention! wrong input. You have {trytime} tryies...");
        }
    }
}


int number, answer = 0;

// task 10

Console.Clear();

Console.WriteLine("There are three task: 10, 13, 15.");
Console.Write("Give me the number task you want: ");
int task = GetNumber(0);
if(task != -1){
    Console.Clear();
    Console.WriteLine($"You choose {task} task");
}

if(task == 10){

    number = GetNumber(3);
    answer = (number / 10) % 10;

    Console.WriteLine($"The second digit of {number} is {answer}");

}
else if(task == 13){

    Console.Write($"Input any number: ");

    number = GetNumber(0);
    if(number < 100){
        Console.WriteLine($"There is no the third digit in {number}");
    }
    else{
        answer = (number % 1000) / 100;
        Console.WriteLine($"The third digit of {number} is {answer}");
    }
}
else if(task == 15){

    Console.Write($"Input week day number from [1..7]: ");
    number = GetNumber(0);
    if(number > 0 && number < 8){

        if(number > 5) Console.WriteLine($"{number} is a holyday");
        else Console.WriteLine($"{number} is a work day");

    }
    else Console.WriteLine($"{number} is not day's of week number");


}
else Console.WriteLine("There is no such tasks");

Console.WriteLine("Nice to work with you");



