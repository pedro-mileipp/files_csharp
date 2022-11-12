using System;
using System.IO;

class Program{
    static void Main(){
        /*
        É uma stream capaz de escrever caracteres a partir de uma stream binária (ex: FileStream)
        Suporte a dados no formato de texto.
        */

        // ler o conteúdo de file1 e transformar em uppercase para file2
        string sourcePath = @"C:\Users\Pedro\Documents\aquivos_c#\file1.txt";
        string targetPath = @"C:\Users\Pedro\Documents\aquivos_c#\file2.txt";

        try{
            string[] lines = File.ReadAllLines(sourcePath);
            
            using (StreamWriter sw = File.AppendText(targetPath)){
                foreach(string line in lines){
                    sw.WriteLine(line.ToUpper());
                }
            }

        } catch(IOException e){
            Console.WriteLine("An error occured");
            Console.WriteLine(e.Message);
        }
        
    }
}