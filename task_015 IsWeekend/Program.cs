
int number;

Console.Clear();
Console.WriteLine("Задача 15: define weekend or workday by user's number in [1 ..7]");
    
    Console.Write($"Input week day number from [1..7]: ");
    number = GetNumber(0);
    if(number > 0 && number < 8){

        if(number > 5) Console.WriteLine($"{number} is a holyday");
        else Console.WriteLine($"{number} is a work day");

    }
    else Console.WriteLine($"{number} is not day's of week number");

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