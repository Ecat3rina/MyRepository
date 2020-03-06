using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace StructuralPatterns
{
     public abstract class SmartCar
    {
        public virtual void OpenDoor() {}
        public virtual void CloseDoor() { }
        public virtual void PlayMusic() { }
        public virtual void StopMusic() { }
        public virtual void ConnectBluetooth() { }
        public virtual void DisconnectBluetooth() { }
        public virtual void CallContact() { }
    }

     public class OrderCar : SmartCar
     {
         public override void OpenDoor()
         { 
             new MechanismSystem().OpenDoor();
         }
        public override void CloseDoor()
        {
            new MechanismSystem().CloseDoor();
        }

        public override void PlayMusic()
        {
            new RadioSystem().PlayMusic();
        }
        public override void StopMusic()
        {
            new RadioSystem().StopMusic();
        }

        public override void ConnectBluetooth()
        {
            new BluetoothSystem().ConnectBluetooth();
        }
        public override void DisconnectBluetooth()
        {
            new BluetoothSystem().DisconnectBluetooth();
        }
        public override void CallContact()
        {
            new BluetoothSystem().CallContact();
        }
    }
    public class MechanismSystem : SmartCar
    {
        public override void OpenDoor()
        {
            Console.WriteLine("The door has been opened");
            Console.WriteLine("Anything else to do, BOSS?");
        }
        public override void CloseDoor()
        {
            Console.WriteLine("The door has been closed");
            Console.WriteLine("Anything else to do, BOSS?");
        }
    }

    public class RadioSystem : SmartCar
    {
        public override void PlayMusic()
        {
            Console.WriteLine("Music is playing");
            Console.WriteLine("Anything else to do, BOSS?");
        }
        public override void StopMusic()
        {
            Console.WriteLine("Music stopped playing");
            Console.WriteLine("Anything else to do, BOSS?");
        }
    }

    public class BluetoothSystem : SmartCar
    {
        public override void ConnectBluetooth()
        {
            Console.WriteLine("Bluetooth has been connected");
            Console.WriteLine("Anything else to do, BOSS?");
        }
        public override void DisconnectBluetooth()
        {
            Console.WriteLine("Bluetooth has been disconnected");
            Console.WriteLine("Anything else to do, BOSS?");
        }

        public override void CallContact()
        {
            Console.WriteLine("Select which contact do you want to call");
            Console.WriteLine("Anything else to do, BOSS?");
        }
    }
}
