﻿
int number, answer;

Console.Clear();
Console.WriteLine("Задача 13: find the third digit of user's number");
    
Console.Write($"Input any number: ");

number = GetNumber(0);

if(number < 100){
    Console.WriteLine($"There is no the third digit in {number}");
}
else{
        answer = (number % 1000) / 100;
        Console.WriteLine($"The third digit of {number} is {answer}");
}

Console.WriteLine("Nice to work with you");

    
//--------------------- implementaion

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