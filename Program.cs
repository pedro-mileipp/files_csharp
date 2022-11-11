using System;
using System.IO;

class Program{
    static void Main(){
        string filePath = @"C:\Users\Pedro\Documents\aquivos_c#\file1.txt";
        string targetPath = @"C:\Users\Pedro\Documents\aquivos_c#\file2.txt";
        // string targetPath2 = @"C:\Users\Pedro\Documents\aquivos_c#\file3.txt";

        try{
            if (!File.Exists(targetPath)){
                FileInfo test_fileInfo = new FileInfo(filePath);
                test_fileInfo.CopyTo(targetPath);
            }
            string[] all_lines = File.ReadAllLines(filePath);
            foreach (string lines in all_lines){
                System.Console.WriteLine(lines);
            }

            // if(!File.Exists(targetPath2)){
            //     File.Copy(filePath, targetPath2);
            // }

        } catch (IOException e){
            Console.WriteLine("An error occured");
            Console.WriteLine(e.Message);
        }

        string stream_path = @"C:\Users\Pedro\Documents\aquivos_c#\stream_file1.txt"; 
        FileStream fs = null;
        StreamReader sr = null;
        try{
            fs = new FileStream(stream_path, FileMode.Open);
            sr = new StreamReader(fs);
            string line = sr.ReadLine();
            Console.WriteLine(line);
            
        }catch(IOException e){
            Console.WriteLine("An error occured");
            Console.WriteLine(e.Message);

        } finally{
            if (sr != null) sr.Close();
            if (fs != null) fs.Close();
        }
    }
}