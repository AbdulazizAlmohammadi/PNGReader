using System;
using System.IO;

namespace PNGReader
{
    class Program
    {
        const string _path = "C:\\Users\\3zAl7arbi\\Desktop\\img.png";
        static void Main(string[] args)
        {
            DisplayValuesFromList();
        }

        public static void DisplayValuesFromList()
        {
            byte[] MagicNumber;
            uint length;
            int width;
            int height;
            int depth;
            int colorType;
            if (File.Exists(_path))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(_path, FileMode.Open)))
                {
                    // MagicNumber = reader.ReadInt32();
                    Console.Write("Magic number for PNG : ");
                    MagicNumber = reader.ReadBytes(8);
                    foreach (var mn in MagicNumber)
                    {
                        Console.Write(mn+" ");
                    }
                    length = reader.ReadUInt32();
                    Console.WriteLine("\nLength : "+length);
                    byte[] ChunkType = reader.ReadBytes(4);
                    width = Convert.ToInt32(BitConverter.ToString(reader.ReadBytes(4)).Replace("-",""),16);
                    Console.WriteLine("Width : "+ width);
                    height = Convert.ToInt32(BitConverter.ToString(reader.ReadBytes(4)).Replace("-",""),16);
                    Console.WriteLine("Height : " + height);
                    depth = Convert.ToInt32(BitConverter.ToString(reader.ReadBytes(1)));
                    Console.WriteLine("Depth : " + depth);depth = Convert.ToInt32(BitConverter.ToString(reader.ReadBytes(1)));
                    colorType = Convert.ToInt32(BitConverter.ToString(reader.ReadBytes(1)));
                    Console.WriteLine("Color Type : " + colorType);depth = Convert.ToInt32(BitConverter.ToString(reader.ReadBytes(1)));
                    



                    // Console.Write();
                }


            }
        }
    }
}
