namespace MyDictionaryExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            // I have created object from MyDictionary Class.
            MyDictionary<char,bool> dictionary = new MyDictionary<char,bool>();
            
            // I used to Method Add
            dictionary.Add('A', true);
            dictionary.Add('B', false);
            dictionary.Add('C', true);
            dictionary.Add('D', true);
            
            //I used to Write Method in the MyDictionary Class
            dictionary.Write();
            Console.WriteLine(dictionary);

        }
    }
}