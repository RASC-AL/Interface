using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SharpDX.DirectInput;

namespace ConsoleApplication3
{
    class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            MainForJoystick();
            //MainForKeyboard();
        }

        static void MainForJoystick()
        {
            // Initialize DirectInput
            var directInput = new DirectInput();

            // Find a Joystick Guid
            var joystickGuid = Guid.Empty;

            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
                joystickGuid = deviceInstance.InstanceGuid;

            // If Gamepad not found, look for a Joystick
            if (joystickGuid == Guid.Empty)
                foreach (var deviceInstance in directInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AllDevices))
                    joystickGuid = deviceInstance.InstanceGuid;

            // If Joystick not found, throws an error
            if (joystickGuid == Guid.Empty)
            {
                Console.WriteLine("No joystick/Gamepad found.");
                Console.ReadKey();
                Environment.Exit(1);
            }
            // Instantiate the joystick
            var joystick = new Joystick(directInput, joystickGuid);

            Console.WriteLine("Found Joystick/Gamepad with GUID: {0}", joystickGuid);

            // Query all suported ForceFeedback effects
            var allEffects = joystick.GetEffects();
            foreach (var effectInfo in allEffects)
                Console.WriteLine("Effect available {0}", effectInfo.Name);

            // Set BufferSize in order to use buffered data.
            joystick.Properties.BufferSize = 128;

            // Acquire the joystick
            joystick.Acquire();
            string s = "there is a cat";
            string[] words = s.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            // Poll events from joystick
            var originX = 0;
            var originY = 0;
            var lastStateX = -1;
            var lastStateY = -1;
            var startFlag = false;
            while (true)
            {
                joystick.Poll();
                var datas = joystick.GetBufferedData();
                double theta = 0.0;
                double radius = 0.0;

                foreach (var state in datas)
                {
                    if (state.Sequence == 1)
                    {
                        s = (state.Offset).ToString();
                        if (s == "X")
                            originX = state.Value;
                        else if (s == "Y")
                            originY = state.Value;
                    }
                    s = (state.Offset).ToString();
                    if (s == "X")
                        lastStateX = state.Value;
                    else if (s == "Y")
                        lastStateY = state.Value;
                    startFlag = true;
                }
                if (startFlag && datas.Length == 0 && lastStateX != -1 && lastStateY != -1)
                {
                    var slope = 0.0;
                    if ((lastStateX - originX) == 0)
                        slope = Math.PI / 2;
                    else
                        slope = (lastStateY - originY) / (lastStateX - originX);
                    theta = Math.Atan(slope);
                    radius = Math.Sqrt(Math.Pow(originX - lastStateX, 2) + Math.Pow(originY - lastStateY, 2));
                    originX = lastStateX;
                    originY = lastStateY;
                    Console.WriteLine(theta);
                    Console.WriteLine(radius);
                    startFlag = false;
                }
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void MainForKeyboard()
        {
            // Initialize DirectInput
            var directInput = new DirectInput();

            // Instantiate the joystick
            var keyboard = new Keyboard(directInput);

            // Acquire the joystick
            keyboard.Properties.BufferSize = 128;
            keyboard.Acquire();

            // Poll events from joystick
            while (true)
            {
                keyboard.Poll();
                var datas = keyboard.GetBufferedData();
                foreach (var state in datas)
                    Console.WriteLine(datas);
            }
        }
    }
}
