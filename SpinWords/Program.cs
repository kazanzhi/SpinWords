//SpinWords("emocleW")-> "Welcome"
//SpinWords("olleH yadnoM")-> "Hello Monday"
//SpinWords("This is a test")-> "This is a test"
//SpinWords("You are tsomla to the last test")-> "You are almost to the last test"
//SpinWords("Just gniddik ereht is llits one more")-> "Just kidding there is still one more"

static string SpinWords(string str)
{
    string result;
    string[] array = str.Split(new char[] { ' ' });
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i].Length >= 5)
        {
            char[] chars = array[i].ToCharArray();
            Array.Reverse(chars);
            array[i] = new string(chars);
        }
    }
    result = string.Join(" ", array);
    return result;
}
Console.WriteLine(SpinWords("emocleW"));
Console.WriteLine(SpinWords("olleH yadnoM"));
Console.WriteLine(SpinWords("This is a test"));
Console.WriteLine(SpinWords("You are tsomla to the last test"));
Console.WriteLine(SpinWords("Just gniddik ereht is llits one more"));