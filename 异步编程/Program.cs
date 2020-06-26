using System;
using System.Threading;
using System.Threading.Tasks;

namespace 异步编程
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = Task.Run(() =>
              {
                  Console.WriteLine("Foo");
                  return 3;
              });

            var result = task.Result;

            Console.WriteLine(result);

            //var res = await GetData();

            //Console.WriteLine(res);
        }

        public static async Task<string> GetData()
        {
            await Task.Delay(1);
            return "Hello";
        }
    }
}
