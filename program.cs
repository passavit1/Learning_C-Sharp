

namespace MyApplication
{
    class Program
    {

        static void Main(string[] args)
        {

            try
            {
                int[] myNumbers = new int[4 ]{ 1, 2, 3 ,4};
                Console.WriteLine(myNumbers[2]);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
       
    }
}