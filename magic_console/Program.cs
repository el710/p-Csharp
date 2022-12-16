// See https://aka.ms/new-console-template for more information

// Serpinsky's Fractal

Console.Clear();


int xFirst = 40, yFirst = 1;
int xSecond = 1, ySecond = 24,
    xThird = 80, yThird = 24;

Console.SetCursorPosition(xFirst, yFirst);
Console.Write("*");
Console.SetCursorPosition(xSecond, ySecond);
Console.Write("*");
//Console.SetCursorPosition(xThird, yThird);
//Console.Write("*");

int x = xFirst, y =yFirst;
int pointCount = 10000;
int startPoint = 0;

while(pointCount > 0){

    startPoint = new Random().Next(0,3);

    if (startPoint == 0){
        x = (x + xFirst) / 2;
        y = (y + yFirst) / 2;
    }
    else
    if(startPoint == 1){
        x = (x + xSecond) / 2;
        y = (y + ySecond) / 2;
    }
    else
    if(startPoint == 2){
        x = (x + xThird) / 2;
        y = (y + yThird) / 2;        
    }

    Console.SetCursorPosition(x, y);
    Console.Write("*");
    pointCount--;
}

Console.SetCursorPosition(xThird, yThird);
Console.Write("*");