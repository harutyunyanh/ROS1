﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Ros_CSharp;
using XmlRpc_Wrapper;
using Messages;
using System.Threading;

namespace SimplePublisher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Publisher<Messages.std_msgs.String> pub;
        NodeHandle nh;

        private bool closing;
        private Thread pubthread;

        public MainWindow()
        {
            InitializeComponent();
            ROS.ROS_MASTER_URI = "http://10.116.1.123:11311";
            ROS.ROS_IP = "10.116.1.80";
            ROS.ROS_HOSTNAME = "10.116.1.80";
            ROS.Init(new string[0], "wpf_talker");
            nh = new NodeHandle();

            pub = nh.advertise<Messages.std_msgs.String>("/chatter", 1, false);
            string text = "";
            for (int i = 0; i < 100000; i++)
            {
                text += "a";
            }
            pubthread = new Thread(() =>
            {
                int i = 0;
                Messages.std_msgs.String msg;


                while (ROS.ok && !closing)
                {
                    msg = new Messages.std_msgs.String("foo " + (i++) + text);
                    pub.publish(msg); 
                    Dispatcher.Invoke(new Action(() =>
                    {
                        l.Content = "Sending: " + msg.data;
                    }),new TimeSpan(0,0,1));
                    Thread.Sleep(100);
                }
            });
            pubthread.Start();
        }

        protected override void  OnClosed(EventArgs e)
        {
            if (!closing)
            {
                closing = true;
                pubthread.Join();
            }
            ROS.shutdown();
            ROS.waitForShutdown();
            base.OnClosed(e);
        }
    }
}
