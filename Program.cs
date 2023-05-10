using System.Diagnostics.CodeAnalysis;

namespace git_ejercicio
{
    internal class Program
    {
        void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int resutl = Sum(2, 3);
        }
       
    }
    public int Sum(int n1,int n2)
    {
        return n1 + n2;
    }
}