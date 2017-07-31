using System;
using System.Runtime.InteropServices;

namespace Acer
{
        public class INT15_64
        {
                [DllImport("INT15_64.dll")]
                public static extern IntPtr GetBootSequence();

                [DllImport("INT15_64.dll")]
                public static extern bool SetBootSequenceNB(byte[] sequence, int length);

                [DllImport("INT15_64.dll")]
                public static extern bool SetBootSequenceDT(int preset);

                [DllImport("INT15_64.dll")]
                public static extern bool IsBIOSPasswordExist(BIOSUserLevel userlevel);

                [DllImport("INT15_64.dll")]
                public static extern bool SetBIOSPassword(BIOSUserLevel userlevel, char[] password);

                [DllImport("INT15_64.dll")]
                public static extern bool RemoveBIOSPassword(BIOSUserLevel userlevel);

                [DllImport("INT15_64.dll")]
                public static extern bool CheckBIOSPassword(BIOSUserLevel userlevel, char[] password);

                [DllImport("INT15_64.dll")]
                public static extern bool GetFastBoot();

                [DllImport("INT15_64.dll")]
                public static extern bool SetFastBoot(bool state);

                [DllImport("INT15_64.dll")]
                public static extern IntPtr GetAssetTag();

                [DllImport("INT15_64.dll")]
                public static extern bool SetAssetTag(char[] asset);

                [DllImport("INT15_64.dll")]
                public static extern IntPtr GetSerialPortStatus(int portNumber);

                [DllImport("INT15_64.dll")]
                public static extern IntPtr GetParallelPortStatus();

                [DllImport("INT15_64.dll")]
                public static extern IntPtr GetCPUInfo();

                public enum BIOSUserLevel
                {
                        USER,
                        ADMIN
                }

                public static void Main(string[] args)
                {
                        Console.WriteLine("Acer BIOS Password Remover");
                        Console.WriteLine("BIOS User Password: " + (IsBIOSPasswordExist(BIOSUserLevel.USER)? "True":"False"));
                        Console.WriteLine("BIOS Admin Password: " + (IsBIOSPasswordExist(BIOSUserLevel.ADMIN)? "True":"False"));
                        Console.WriteLine("Removing User Password: " + (RemoveBIOSPassword(BIOSUserLevel.USER)? "True":"False"));
                        Console.WriteLine("Removing Admin Password: " + (RemoveBIOSPassword(BIOSUserLevel.ADMIN)? "True":"False"));
                }

        }
}
