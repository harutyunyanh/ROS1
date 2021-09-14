using ROSPublisherClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RosDllTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ROSClass rosclass = new ROSClass();

            Ros_CSharp.Publisher<global::Messages.std_msgs.UInt8MultiArray> pub = rosclass.InitRos();

            var byteArray = new byte[100001];
            Thread.Sleep(1000);
            for (int i = 0; i < 100; i++)
            {
                byteArray[0] = (byte)i;
                Thread.Sleep(100);
                rosclass.Publish(byteArray, pub);

            }
            rosclass.close();

            Console.WriteLine("finish");
        }
    }
}
