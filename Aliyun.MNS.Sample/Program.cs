using System;

namespace Aliyun.MNS.Sample
{
    public class Program
    {
        private const string _accessKeyId = "<your access key id>";
        private const string _secretAccessKey = "<your secret access key>";
        private const string _endpoint = "<valid endpoint>";

        static void Main(string[] args)
        {
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. AsyncOperationSample");
            Console.WriteLine("2. SyncOperationSample");
            Console.WriteLine("3. SyncTopicOperation");

            var op = Console.Read();
            switch (op)
            {
                case 1:
                    new AsyncOperationSample(_accessKeyId, _secretAccessKey, _endpoint).Start();
                    break;
                case 2:
                    new SyncOperationSample(_accessKeyId, _secretAccessKey, _endpoint).Start();
                    break;
                case 3:
                    new SyncTopicOperation(_accessKeyId, _secretAccessKey, _endpoint).Start();
                    break;
            }
        }
    }
}