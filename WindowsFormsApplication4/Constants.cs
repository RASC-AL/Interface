using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoboOps.Interface
{
    public static class Constants
    {
        //Communication config
        //public static string RoverIP = "127.0.0.1";
        public static string RoverIP = "128.205.54.5";
        public static int RoverPort = 5000;
        
        //Arm config
        public static int joystickZeroPose = 32767;
        public static int joystickMaxPose = 65535;
        public static int joystickTimeSensitivity = 500;
        public static int joystickSensitivity = 15512;

        //Drive config
        public static int turnSpeed = 100;
        public static int fwdSpeed = 50;

        //Arm constants
        public static int baseMinRotation = 5;
        public static int baseMaxRotation = 85;
        public static int baseRotationSensitivity = 5;

        public static int baseMinLift = 90;
        public static int baseMaxLift = 150;
        public static int baseLiftSensitivity = 5;

        public static int elbowMinLift = 30;
        public static int elbowMaxLift = 130;
        public static int elbowSensitivity = 5;

        public static int yawMin = 5;
        public static int yawMax = 175;
        public static int yawSensitivity = 15;

        public static string scoopOpen = "70";
        public static string scoopClose = "40";
        
    }
}
