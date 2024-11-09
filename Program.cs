using System;
using System.IO;

using System.IO.Ports;


namespace TestService
{
    class Program
    {
        static void Main()
        {
            //string portName = "/dev/VehicleLeftController"; // Gebruik de door udev toegewezen naam
            //int baudRate = 9600; // Pas aan op basis van je apparaatvereisten

            //try
            //{
            //    using (SerialPort serialPort = new SerialPort(portName, baudRate))
            //    {
            //        // Configureer eventueel andere instellingen zoals Parity, DataBits, StopBits
            //        serialPort.Open();

            //        Console.WriteLine($"Connected to serial device on {portName}");

            //        // Lees gegevens van de seriële poort (of schrijf indien nodig)

            //        // Sluit de verbinding wanneer je klaar bent
            //        serialPort.Close();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"An error occurred: {ex.Message}");
            //}

            string[] paths = { "/dev/VehicleRightController", "/dev/RemoteController" };

            Console.WriteLine("Virtual links of connected serial devices:");

            foreach (string path in paths)
            {
                if (Directory.Exists(path))
                {
                    string[] symlinks = Directory.GetFiles(path);

                    foreach (string symlink in symlinks)
                    {
                        try
                        {
                            // Get the actual device file the symlink points to
                            string target = Path.GetFullPath(symlink);

                            Console.WriteLine($"{symlink} -> {target}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error reading symlink {symlink}: {ex.Message}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Directory '{path}' does not exist or is not accessible.");
                }
            }
        }
    }

}
