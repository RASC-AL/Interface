using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoboOps.Interface
{
    public static class Constants
    {
        public static int joystickSensitivity = 512;
        public static string RoverIP = "128.205.54.5";
        public static int RoverPort = 5000;
        public static int joystickZeroPose = 32767;
        public static int joystickMaxPose = 47000;
        public static int joystickTimeSensitivity = 500;
        

        public static int baseMaxAngle = 90;
        public static int baseMinAngle = 0;
        public static int baseMaxRotation = 120;
        //public static int elbowMaxAngle = 180;
        public static int elbowSensitivity = 5;
        
    }
}
