using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SharpDX.DirectInput;

namespace RoboOps.Interface
{
    

   
        public class Gamepad
        {
            private SharpDX.DirectInput.Joystick Controller;


            public Gamepad()
            {
                initialize_joystick();
            }

            private void initialize_joystick()
            {
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
                Controller = new Joystick(directInput, joystickGuid);

                Console.WriteLine("Found Joystick/Gamepad with GUID: {0}", joystickGuid);

                // Query all suported ForceFeedback effects
                var allEffects = Controller.GetEffects();
                foreach (var effectInfo in allEffects)
                    Console.WriteLine("Effect available {0}", effectInfo.Name);

                // Set BufferSize in order to use buffered data.
                Controller.Properties.BufferSize = 128;

                // Acquire the joystick
                Controller.Acquire();

            }


            /// <summary>
            /// Returns current Mouse-Position
            /// </summary>
            /// <returns></returns>
            //public bool CheckGamepadButton(Button Button)
            //{
            //    if (Controller.IsConnected)
            //    {
            //        GamepadButtonFlags CheckButton = GamepadButtonFlags.None;
            //        switch (Button)
            //        {
            //            case Button.A:
            //                {
            //                    CheckButton = GamepadButtonFlags.A;
            //                    break;
            //                }
            //        }
            //        return Controller.GetState().Gamepad.Buttons == CheckButton;
            //    }
            //    return false;
            //}

            public void GetGamepadButton()
            {
                Controller.Poll();

                var state = Controller.GetCurrentState();
                double theta = 0.0;
                double radius = 0.0;



            }

            //private Button ConvertButtonFlag()

            public enum Button
            {
                A,
                B,
                X,
                Y,
                LT,
                RT,
                LS,
                RS,
                BACK,
                START,
                UP,
                DOWN,
                LEFT,
                RIGHT
            }

        }
    
}
