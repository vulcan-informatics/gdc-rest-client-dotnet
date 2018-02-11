using System;

namespace GdcRestClient.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new FileGetRequest()
                .WithExperimentalStrategy("RNA-SEQ")
                .WithCancerType("BRCA")
                .WithLimit("10")
                .Execute(new GenomicDataCommonsApi());

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
