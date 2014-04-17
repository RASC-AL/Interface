using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoboOps.Interface
{
    public static class Constants
    {
        //Communication config
        //public static string RoverIP = "128.205.54.5";
        public static string RoverIP = "128.205.54.5";
        public static int RoverPort = 5000;
        
        //Arm config
        public static int joystickZeroPose = 32767;
        public static int joystickMaxPose = 65535;
        public static int joystickTimeSensitivity = 500;
        public static int joystickSensitivity = 15512;

        //Drive config
        public static int turnSpeed = 10;
        public static int fwdSpeed = 20;

        //Arm constants
        public static int baseMinRotation = -100;
        public static int baseMaxRotation = 120;
        public static int baseRotationSensitivity = 5;

        public static int baseMinLift = 0;
        public static int baseMaxLift = 90;
        public static int baseLiftSensitivity = 5;

        public static int elbowMinLift = 0;
        public static int elbowMaxLift = 90;
        public static int elbowSensitivity = 5;

        public static int yawMin = 0;
        public static int yawMax = 90;
        public static int yawSensitivity = 1;
        
    }
}
