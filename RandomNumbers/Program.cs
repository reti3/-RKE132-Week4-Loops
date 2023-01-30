Random rnd = new Random(); // random klassi väljakutsumine
                           // juhusliku numbri genereerimine - kasutatakse krüpteerimisel
                           //juhuslik väärtus mingis kindlas vahemikus

//for(int i = 0; i < 3; i++) //genereerib 3 juhuslikku numbrit
//{
//int myRandomNum = rnd.Next(0, 11); // geneeritakse väärtusi 0-10
//Console.WriteLine($"My random number is {myRandomNum}");
//}

int myRandomNum;
int randomSum = 0;

for (int i = 0; i < 3; i++) //genereerib vastava arvu juhuslikku numbrit
{
    myRandomNum = rnd.Next(0, 11); // geneeritakse väärtusi 0-10
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"My random number is {myRandomNum}");
}
Console.WriteLine($"Random sum total: {randomSum}");