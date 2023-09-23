using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day8
{
    internal class Buffer
    {
        static byte[] storage = new byte[255];
        static MemoryStream tempmemorarystream = new MemoryStream(storage);
        
        public static void MemStreamWriter()

        {

            // Wrap tempmemorystream in a reader and a writer.

            StreamWriter streamwriter = null;

            // Write to storage, through streamwriter.

            String? inputString = String.Empty;

            try

            {

                Console.WriteLine("Enter a Sentence:");

                inputString = Console.ReadLine();

                streamwriter = new StreamWriter(tempmemorarystream);

                streamwriter.WriteLine(inputString);

                // Put a period at the end.

                streamwriter.WriteLine(".");

                streamwriter.Flush();

                Console.WriteLine("tempmemorystream.Length " + tempmemorarystream.Length);

                Console.WriteLine("tempmemorystream.Capacity " + tempmemorarystream.Capacity);

                Console.WriteLine("tempmemorystream.Postion " + tempmemorarystream.Position);

            }

            catch (Exception err)

            {

                Console.WriteLine("ERROR!!! " + err.Message);

            }

            finally

            {

                //streamwriter.Close();

            }

        }

        public static void MemStreamReader()

        {

            Console.WriteLine("memstrm.Postion " + tempmemorarystream.Position);

            StreamReader memrdr = new StreamReader(tempmemorarystream);

            try

            {

                Console.WriteLine("\nReading through memrdr: ");

                // Read from tempmemorystream using the stream reader.

                tempmemorarystream.Seek(0, SeekOrigin.Begin); // reset file pointer

                Console.WriteLine("tempmemorystream.Postion After seek " + tempmemorarystream.Position);

                string str = memrdr.ReadLine();

                while (str != null)

                {

                    Console.WriteLine(str);

                    //if (str.CompareTo(".") == 0) break;

                    str = memrdr.ReadLine();

                }

            }

            finally

            {

                memrdr.Close();

            }

        }
        //Using BinaryWriter to store random byte value
        public static void WriteBytesToMemoryStream()
        {
            Console.WriteLine("MemoryStream Length " + tempmemorarystream.Length);
            int arrayLength = 10;
            byte[] dataArray = new byte[arrayLength];

            // Create random numbers and fill the dataArray
            Random r1 = new Random();
            r1.NextBytes(dataArray);
            StringBuilder str = new StringBuilder(arrayLength);
            for (int i = 0; i < arrayLength; i++)
            {
                str.Append(dataArray[i]);
                str.Append(";");
            }
            Console.WriteLine(str);



            //bool flag = true;
            //byte[] data = BitConverter.GetBytes(flag);
            BinaryWriter binWriter = new BinaryWriter(tempmemorarystream);
            // read data (the random numbers) from dataArray and write to MemoryStream
            binWriter.Write(dataArray);
            Console.WriteLine("Write Completed " + tempmemorarystream.Length);
        }
        //Using BinaryReader
        public static void ReadBytesFromMemoryStream()
        {
            if (tempmemorarystream.Length == 0)
            {
                Console.WriteLine("Memory Stream is Empty");
                return;
            }
            // Create the reader using the stream from the writer.
            BinaryReader binReader = new BinaryReader(tempmemorarystream);
            // Set Position to the beginning of the stream.
            binReader.BaseStream.Position = 0;
            // Read and verify the data.
            int arrayLength = (int)tempmemorarystream.Length;
            byte[] verifyArray = binReader.ReadBytes(arrayLength);
            StringBuilder str = new StringBuilder(arrayLength);
            for (int i = 0; i < arrayLength; i++)
            {
                str.Append(verifyArray[i]);
                str.Append(";");
            }
            Console.WriteLine(str);
        }
    }
}
