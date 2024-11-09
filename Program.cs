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

            string[] paths = { "/dev/serial/VehicleRightController", "/dev/serial/RemoteController" };

            Console.WriteLine("Virtual links of connected serial devices:");

            string devicePath = "/dev/serial/VehicleRightController"; // Gebruik de door udev toegekende naam

            // Controleer of het apparaat beschikbaar is
            if (File.Exists(devicePath))
            {
                Console.WriteLine($"{devicePath} is beschikbaar.");
                // Voeg hier eventueel code toe om een verbinding te maken met het apparaat
            }
            else
            {
                Console.WriteLine($"{devicePath} is niet beschikbaar.");
            }
        }
    }

}
