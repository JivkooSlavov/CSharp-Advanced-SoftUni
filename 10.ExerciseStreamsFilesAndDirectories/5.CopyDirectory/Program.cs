﻿namespace CopyDirectory
{
    using System;

    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath = @$"C:\Users\Jivko\Downloads\SU";
            string outputPath = @$"C:\Users\Jivko\Downloads\SU - Copy";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            if (Directory.Exists(outputPath)
)
            {
                Directory.Delete(outputPath, recursive: true);
            }
            Directory.CreateDirectory(outputPath);
            string[] files = Directory.GetFiles(inputPath);
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string destination = Path.Combine(outputPath, fileName);
                File.Copy(file, destination);
            }
        }
    }
}
