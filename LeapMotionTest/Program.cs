using Leap;
using LightBuzz.LeapMotion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeapMotionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            LeapMotion leap = new LeapMotion();

            leap.EnableGestures();

            leap.FrameReady += Leap_FrameReady;
            leap.GestureRecognized += Leap_GestureRecognized;

            Console.ReadKey();
        }

        static void Leap_FrameReady(object sender, LeapMotionEventArgs e)
        {
            Console.WriteLine("Number of fingers detected: " + e.Frame.Fingers.Count);
        }

        static void Leap_GestureRecognized(object sender, LeapMotionEventArgs e)
        {
            Console.WriteLine("Gesture detected: " + e.Gesture.Type);
        }
    }
}
