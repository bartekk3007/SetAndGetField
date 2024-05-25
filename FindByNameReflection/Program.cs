namespace FindByNameReflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House h1 = new House(10, 100, "Philadelphia");
            int area = (int) typeof(House).GetField("Size").GetValue(h1);
            typeof(House).GetField("Street").SetValue(h1, "Lincoln");
            Console.WriteLine(area);
            Console.WriteLine(h1.Street);
        }
    }
}
