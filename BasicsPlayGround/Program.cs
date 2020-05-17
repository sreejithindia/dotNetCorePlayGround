using System;

namespace BasicsPlayGround
{
    interface IDataContainer
    {
        public string Data { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void DoWork (object obj)
        {
            var dataContainer = obj as IDataContainer;
            if(dataContainer != null)
            {
                Console.WriteLine(dataContainer.Data);
            }
        }
    }
}
