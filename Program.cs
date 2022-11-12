using System;
using System.IO;

class Program{
    static void Main(){
        // using block
        /*
            Sintaxe simplificada que garante que os objetos IDisposable serão fechados.
            Objetos IDisposable não são gerenciados pelo CLR, portanto precisam ser manualmente fechados. 
            Exemplos: Font, FileStream, StreamReader, StreamWritter
        */
        try{
            string path = @"C:\Users\Pedro\Documents\aquivos_c#\file1.txt";
            using (FileStream fs = new FileStream(path, FileMode.Open)){ // ao acabar de usar o using fecha automaticamente
                using (StreamReader sr = new StreamReader(fs)){
                    while (!sr.EndOfStream){
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
        } catch(IOException e){
            Console.WriteLine("An error occured");
            Console.WriteLine(e.Message);
        }

        // segunda forma
        string path2 = @"C:\Users\Pedro\Documents\aquivos_c#\file2.txt";
        try{
            using (StreamReader sr2 = File.OpenText(path2)){
                while(!sr2.EndOfStream){
                    string line2 = sr2.ReadLine();
                    Console.WriteLine(line2);
                }
            }
        } catch(IOException e){
            Console.WriteLine("An error occured");
            Console.WriteLine(e.Message);
        }
        
    }
}