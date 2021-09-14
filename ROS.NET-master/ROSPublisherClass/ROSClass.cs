using Messages.std_msgs;
using Ros_CSharp;

namespace ROSPublisherClass
{
    public  class ROSClass
    {
        public ROSClass()
        {

        }

        public void InitRosIpConfig(string ROS_MASTER_URI,string ROS_IP, string ROS_HOSTNAME)
        {
            ROS.ROS_MASTER_URI = ROS_MASTER_URI;
            ROS.ROS_IP = ROS_IP;
            ROS.ROS_HOSTNAME = ROS_HOSTNAME;
        }

        public Publisher<UInt8MultiArray> InitRos(string Name,string TopicName,int Q_SIZE)
        {
            Publisher<UInt8MultiArray> pub;
            NodeHandle nh;
            ROS.Init(new string[0], Name);
            nh = new NodeHandle();
            pub = nh.advertise<UInt8MultiArray>(TopicName, Q_SIZE);
            return pub;
        }

        public  void Publish(byte[] Array, Publisher<UInt8MultiArray> pub)
        {
                UInt8MultiArray msg = new UInt8MultiArray();
                msg.data = Array;
                pub.publish(msg);
        }

        public  void close()
        {
            ROS.shutdown();
            ROS.waitForShutdown();
        }
    }
}
