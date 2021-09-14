using Messages.std_msgs;
using Ros_CSharp;
using System;
using System.Threading;

namespace ROSPublisherConsole
{
    class Program
    {

        static void Main(string[] args)
        {     
            Publisher<UInt8MultiArray> pub;
            NodeHandle nh;
            ROS.ROS_MASTER_URI = "http://10.116.1.123:11311";
            ROS.ROS_IP = "10.116.1.80";
            ROS.ROS_HOSTNAME = "10.116.1.80";
            ROS.Init(args, "wpf_talker");
            nh = new NodeHandle();
            pub = nh.advertise<UInt8MultiArray>("/robot_news_radio_num", 10, false);
                                                                                                                                                                                                                             
            var byteArray = new byte[1000001];
            for (int i = 0; i < byteArray.Length; i++)
            {
                byteArray[i] = 17;
            }

            UInt8MultiArray msg = new UInt8MultiArray();
            msg.data = byteArray;
            Thread.Sleep(1000);

            for (int i = 0; i < 10 && ROS.ok; i++)
            {
                msg.data[1000000] = (byte)i;
                pub.publish(msg);
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            ROS.shutdown();
            ROS.waitForShutdown();
        }
    }
}
