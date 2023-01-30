//for( int i = 0; i < 10; i++)
//{
    //Console.WriteLine($"i = {i +1}");//avaldus loogiliste sulgude sees on mõeldud kuvamiseks
//}


//for (int i = 10; i < 0; i--) //lahutab väärtusest -1; i-- = i-1
//{
    //Console.WriteLine($"i = {i}");
//}

int sum = 0;
for (int i = 1; i < 11; i++) //liidab kokku kõik i-d
{
    Console.WriteLine($"i = {i}");
    Console.WriteLine($"Current total: {sum}");
    sum = sum + i; //sum += i 
}

Console.WriteLine($"Final total {sum}"); //vahe eelmisega, sest i++ teeb programm kõige viimasena


