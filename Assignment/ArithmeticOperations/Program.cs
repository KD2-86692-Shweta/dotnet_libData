using System.Reflection;
using MathsLib;
namespace ArithmeticOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly mathsAssembly = Assembly.Load("MathsLib");
            Type mathsType = mathsAssembly.GetType();

            object mathsInstance=Activator.CreateInstance(mathsType);




        }
    }
}
