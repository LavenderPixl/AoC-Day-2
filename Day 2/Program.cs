using static System.Formats.Asn1.AsnWriter;

var text = File.ReadAllLines("Plays.txt");

int Score = 0;

// X/A = Rock = 1;
// B/Y = Paper = 2;
// C/Z = Scissors = 3;
// Win = 6;
// Draw = 3;

// X 

foreach (var line in text)
{
    if (line.Contains("A") && line.Contains("Y"))
    {
        Score += 8;
    }
    else if (line.Contains("A") && line.Contains("X"))
    {
        Score += 4;
    }
    else if (line.Contains("A") && line.Contains("Z"))
    {
        Score += 3;
    }

    else if (line.Contains("B") && line.Contains("Y"))
    {
        Score += 5;
    }
    else if (line.Contains("B") && line.Contains("X"))
    {
        Score += 1;
    }
    else if (line.Contains("B") && line.Contains("Z"))
    {
        Score += 9;
    }

    else if (line.Contains("C") && line.Contains("Y"))
    {
        Score += 2;
    }
    else if (line.Contains("C") && line.Contains("X"))
    {
        Score += 7;
    }
    else if (line.Contains("C") && line.Contains("Z"))
    {
        Score += 6;
    }
}
Console.WriteLine($"Your score is {Score}!");

//for (int i = 0; i < text.Length; i++)
//{
//    if (text[i].Contains("A"))
//    {
//        Elf = Arock;
//    }
//    else if (text[i].Contains("B"))
//    {
//        Elf = BPaper;
//    }
//    else if (text[i].Contains("C"))
//    {
//        Elf = CScissors;
//    }
//    bool v = text[i] == text[i + 1];
//}


