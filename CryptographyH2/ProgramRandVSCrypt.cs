using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptographyH2
{
    //How do I do properly compare these?
    class ProgramRandVSCrypt
    {
        //static void Main(string[] args)
        //{
        //    Stopwatch watch = new Stopwatch();
        //    Random rand = new Random();

        //    Console.WriteLine("RNGCrypto");
        //    using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
        //    {
        //        byte[] data = new byte[1000];

        //        watch.Start();
        //        for (int i = 0; i < data.Length; i++)
        //        {
        //            rng.GetBytes(data);
        //            int value = BitConverter.ToInt32(data, 0);
        //            Console.WriteLine(value);
        //        }
        //        watch.Stop();
        //        Console.WriteLine(watch.ElapsedMilliseconds);
        //    }
        //    watch.Reset();

        //    Console.WriteLine("Random");
        //    watch.Start();
        //    int[] randData = new int[1000];

        //    //Have this run multiple times
        //    for (int i = 0; i < randData.Length; i++)
        //    {
        //        for (int j = 0; j < randData.Length; j++)
        //        {
        //            randData[j] = rand.Next(-9, 10);
        //        }

        //        string value = randData[0].ToString() + randData[1].ToString() + randData[2].ToString() + randData[3].ToString();

        //        Console.WriteLine(value);
        //    }
        //    watch.Stop();
        //    Console.WriteLine(watch.ElapsedMilliseconds);

        //    Console.ReadLine();
        //}
    }
}
