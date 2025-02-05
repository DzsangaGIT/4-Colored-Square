//Kocka mátrix létrehozása

char[,] kocka1 = new char[5, 10];
char[,] kocka2 = new char[5, 10];
char[,] kocka3 = new char[5, 10];
char[,] kocka4 = new char[5, 10];


for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 10; j++)
    {
        //Kockák feltöltése ASCII karakterekkel █
        kocka1[i, j] = '█';
        kocka2[i, j] = '█';
        kocka3[i, j] = '█';
        kocka4[i, j] = '█';
    }
}


//Kockák kiíratása
for(int i = 0; i < 5; i++){
    for(int j = 0; j < 10; j++){
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(kocka1[i, j]);
        Console.ResetColor();
    }
    //Kockák elválasztása
    Console.Write("  ");
    for(int j = 0; j < 10; j++){
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(kocka2[i, j]);
        Console.ResetColor();
    }
    Console.WriteLine();
}

//Kockák elválasztása
Console.WriteLine("  ");


//Kockák kiíratása
for(int i = 0; i < 5; i++){
    for(int j = 0; j < 10; j++){
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(kocka3[i, j]);
        Console.ResetColor();
    }
    //Kockák elválasztása
    Console.Write("  ");
    for(int j = 0; j < 10; j++){
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(kocka4[i, j]);
        Console.ResetColor();
    }
    Console.WriteLine();
}