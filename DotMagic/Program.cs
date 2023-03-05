Console.Clear();

int xa = 1, ya = 1, 
    xb = 1, yb = 3, 
    xc = 4, yc = 3;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x=xa, y=xb;
int count = 0, maxCount = 100;

while(count < maxCount) {

    int dotRand = new Random().Next(0,3); // [0;3)
    if (dotRand==0) {
        x=(x+xa)/2;
        y=(y+ya)/2;
    }

    if (dotRand==1) {
        x=(x+xb)/2;
        y=(y+yb)/2;
    }

    if (dotRand==2) {
        x=(x+xc)/2;
        y=(y+yc)/2;
    }

    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count++;
}
