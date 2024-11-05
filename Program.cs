using System;
using System.IO;

namespace TestService
{
    class Program
    {
        static void Main()
        {
            string[] paths = { "/dev/VehicleLeftController", "/dev/RemoteController" };

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
