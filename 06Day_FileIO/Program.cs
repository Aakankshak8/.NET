namespace _06Day_FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String path = "D:\\IET\\.NET\\Solution1\\06Day_FileIO\\Data\\Info.txt";

            #region CreateorWrite
            //FileStream fs = null;
            //if (File.Exists(path))
            //{
            //    fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            //}


            //StreamWriter writer = new StreamWriter(fs);
            //writer.WriteLine("HELLO FROM INPUT OUTPUT OPERATION");
            //writer.Flush();
            //writer.Close();
            //fs.Close();
            //Console.WriteLine("Done"); 
            #endregion


            //FileStream fs = null;
            //if (File.Exists(FilePath))
            //{
            //    fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            //}
            //else
            //{
            //    Console.WriteLine("File not found");
            //}

            //StreamReader reader = new StreamReader(fs);
            //String Content = reader.ReadToEnd();
            //reader.Close();
            //fs.Close();
            //Console.WriteLine(Content); 

            FileStream fs = null;
            if (File.Exists(path))
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            }
            else
            {
                Console.WriteLine("File not found");
            }


            StreamReader Reader= new StreamReader(fs);
            String content = Reader.ReadToEnd();
            Reader.Close();
            fs.Close();

            Console.WriteLine(content); 


        }
    }
}