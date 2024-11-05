using System;
using System.IO;

using System.IO.Ports;


namespace TestService
{
    class Program
    {
        static void Main()
        {
            string portName = "/dev/VehicleLeftController"; // Gebruik de door udev toegewezen naam
            int baudRate = 9600; // Pas aan op basis van je apparaatvereisten

            try
            {
                using (SerialPort serialPort = new SerialPort(portName, baudRate))
                {
                    // Configureer eventueel andere instellingen zoals Parity, DataBits, StopBits
                    serialPort.Open();

                    Console.WriteLine($"Connected to serial device on {portName}");

                    // Lees gegevens van de seriële poort (of schrijf indien nodig)

                    // Sluit de verbinding wanneer je klaar bent
                    serialPort.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }

}
