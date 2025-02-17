int num = 0;

do
{
    LinkedList<string> phrase = new LinkedList<string>();


    phrase.AddLast("The ");
    phrase.AddLast("quick ");
    phrase.AddLast("brown ");
    phrase.AddLast("fox ");
    phrase.AddLast("jumps ");
    phrase.AddLast("over ");
    phrase.AddLast("the");
    phrase.AddLast(" ");
    phrase.AddLast("lazy ");
    phrase.AddLast("dog. ");

    foreach (string s in phrase)
    {
        Console.Write(s);
    }
    Console.WriteLine("");

    phrase.Remove("quick ");
    phrase.Remove("The ");

    phrase.AddFirst("the ");
    phrase.AddFirst("Today ");

    foreach (string s in phrase)
    {
        Console.Write(s);
    }
    Console.WriteLine("");

    phrase.Remove("Today ");
    phrase.Remove("fox ");
    phrase.Remove("the ");
    phrase.Remove("the");
    phrase.AddFirst("The ");
    phrase.Remove(" ");

    LinkedListNode<string> phrase1 = phrase.Find("brown ");
    phrase.AddBefore(phrase1, "quick ");

    foreach (string s in phrase)
    {
        Console.Write(s);
    }
    Console.WriteLine("");

    phrase.Remove("Today ");
    phrase.Remove("the ");
    phrase.Remove("The ");
    phrase.Remove("quick ");
    phrase.Remove("lazy ");
    phrase.Remove("dog. ");
    phrase.AddFirst("Yesterday ");

    LinkedListNode<string> phrase3 = phrase.Find("Yesterday ");
    phrase.AddAfter(phrase3, "the ");

    LinkedListNode<string> phrase4 = phrase.Find("the ");
    phrase.AddAfter(phrase4, "lazy ");

    phrase.AddLast("brown.");

    LinkedListNode<string> phrase5 = phrase.Find("brown.");
    phrase.AddBefore(phrase5, "quick ");

    phrase.Remove(" ");

    LinkedListNode<string> phrase6 = phrase.Find("over ");
    phrase.AddAfter(phrase6, "the ");



    foreach (string s in phrase)
    {
        Console.Write(s);
    }
    Console.WriteLine("");

    phrase.Remove("Yesterday ");
    phrase.Remove("the ");
    phrase.Remove("quick ");
    phrase.Remove("brown ");
    phrase.Remove("lazy ");
    phrase.Remove("brown.");

    phrase.AddFirst("The ");

    LinkedListNode<string> phrase7 = phrase.Find("The ");
    phrase.AddAfter(phrase7, "quick ");

    LinkedListNode<string> phrase8 = phrase.Find("quick ");
    phrase.AddAfter(phrase8, "brown ");

    LinkedListNode<string> phrase9 = phrase.Find("brown ");
    phrase.AddAfter(phrase9, "fox ");

    phrase.AddLast("lazy ");
    phrase.AddLast("dog. ");
    foreach (string s in phrase)
    {
        Console.Write(s);
    }
    Console.WriteLine("");

    phrase.Clear();


    num++;
    Console.WriteLine("\n");
}
while (num <= 3);


LinkedList<string> p = new LinkedList<string>();


p.AddLast("The ");
p.AddLast("quick ");
p.AddLast("brown ");
p.AddLast("fox ");
p.AddLast("jumps ");
p.AddLast("over ");
p.AddLast("the");
p.AddLast(" ");
p.AddLast("lazy ");
p.AddLast("dog. ");

foreach (string s in p)
{
    Console.Write(s);
}
Console.WriteLine("");

p.Remove("quick ");
p.Remove("The ");

p.AddFirst("the ");
p.AddFirst("Today ");

foreach (string s in p)
{
    Console.Write(s);
}
Console.WriteLine("");

p.Remove("Today ");
p.Remove("fox ");
p.Remove("the ");
p.Remove("the");
p.AddFirst("The ");
p.Remove(" ");

LinkedListNode<string> phrase11 = p.Find("brown ");
p.AddBefore(phrase11, "quick ");

foreach (string s in p)
{
    Console.Write(s);
}
Console.WriteLine("");

p.Remove("Today ");
p.Remove("the ");
p.Remove("The ");
p.Remove("quick ");
p.Remove("lazy ");
p.Remove("dog. ");
p.AddFirst("Yesterday ");

LinkedListNode<string> phrase31 = p.Find("Yesterday ");
p.AddAfter(phrase31, "the ");

LinkedListNode<string> phrase41 = p.Find("the ");
p.AddAfter(phrase41, "lazy ");

p.AddLast("brown.");

LinkedListNode<string> phrase51 = p.Find("brown.");
p.AddBefore(phrase51, "quick ");

p.Remove(" ");

LinkedListNode<string> phrase61 = p.Find("over ");
p.AddAfter(phrase61, "the ");



foreach (string s in p)
{
    Console.Write(s);
}
Console.WriteLine("");