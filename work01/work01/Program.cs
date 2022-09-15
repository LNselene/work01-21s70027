
Console.WriteLine("身長を入力してください(m)");
double height = 0;
bool parseSuccess = false;
bool parseSuccess2 = false;
double yourWeight = 0;
while (!parseSuccess)
{
    string userHeight = Console.ReadLine() ?? "";

    try
    {
        height = double.Parse(userHeight);
        parseSuccess = true;
    }
    catch (Exception)
    {
        Console.WriteLine("身長を入力してください(m)");
    }
}
double weight = height * height * 22;

Console.WriteLine("あなたの身長だと、標準体重は" + weight.ToString("F2") + "kgです。");


Console.WriteLine("体重を入力してください(kg)");

while (!parseSuccess2)
{
    string userWeight = Console.ReadLine() ?? "";

    try
    {
        yourWeight = double.Parse(userWeight);
        parseSuccess2 = true;
    }
    catch (Exception)
    {
        Console.WriteLine("体重を入力してください(kg)");
    }
}

if (yourWeight == weight)
{
    Console.WriteLine("標準体重です。このまま維持していきましょう");
}
else if (yourWeight < weight)
{
    weight -= yourWeight;
    if (weight > 3)
    {
        Console.WriteLine(weight.ToString("F2") + "kgやせているのでもう少し食べても平気ですよ");
    }
    else
    {
        Console.WriteLine("標準体重より少しやせていますが問題はありません。");
    }
}
else if (yourWeight > weight)
{
    yourWeight -= weight;
    if (yourWeight > 3)
    {
        Console.WriteLine(yourWeight.ToString("F2") + "kg太っています。やせていきましょう");
    }
    else
    {
        Console.WriteLine("標準体重より少し太っていますが問題はありません。");
    }
}





