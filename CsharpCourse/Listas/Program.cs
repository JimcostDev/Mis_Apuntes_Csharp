//crear lista
List<int> numbers = new List<int>();
numbers.Add(9);
numbers.Add(1);

List<int> numbers2 = new List<int>()
{
    1,2,3, 4,5, 6, 7,
};
Console.WriteLine(numbers.Count);
Console.WriteLine(numbers2.Count);

//limpiar lista
numbers2.Clear();
Console.WriteLine(numbers2.Count);
