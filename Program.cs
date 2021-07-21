using System;
using Newtonsoft.Json;

namespace paradigma
{
    class Program
    {
        static void Main(string[] args)
        {
            //[A,B] [A,C] [B,G] [C,H] [E,F] [B,D] [C,E]
            var arr = new string[,] {
                {"A","B"},
                {"A","C"},
                {"B","G"},
                {"C","H"},
                {"E","F"},
                {"B","D"},
                {"C","E"}
            };
            //[B,D] [D,E] [A,B] [C,F] [E,G] [A,C]
            // var arr = new string[,] {
            //     {"B","D"},
            //     {"D","E"},
            //     {"A","B"},
            //     {"C","F"},
            //     {"E","G"},
            //     {"A","C"}
            // };


            var solveTheArray = new SolveTheArray(arr);
            var retorno = solveTheArray.Resolve();
            Console.WriteLine(JsonConvert.DeserializeObject(JsonConvert.SerializeObject(retorno)));
            return;
        }
    }
}
