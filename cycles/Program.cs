//==============================================
// cycles

Console.Clear();

Console.WriteLine("draw with while cycle..."); 

int count = 10;
while(count > 0){

    int x = new Random().Next(0,10);
    int y = new Random().Next(0,10);
    
    Console.SetCursorPosition(x, y);
    Console.Write("*");
    count--;
}


Console.WriteLine("init array with for cycle..."); 

int[] array = new int[10];

Console.Write("array[ ");

for(int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(0,2);
    Console.Write($"{array[i]} ");
}

 Console.WriteLine("]");


Console.WriteLine("press enter when ready..."); Console.ReadLine();