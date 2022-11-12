using System;
using System.IO;
using System.Collections.Generic;

class Program{
    static void Main(){
        // Directory, DirectoryInfo: operações com pastas (create, enumerate, get files, etc.).
        // 1° Teste: Listar subpastas a partir de myFolder
        string path = @"C:\Users\Pedro\Documents\aquivos_c#\myFolder";
        try{
            IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); // var tbm serve
            System.Console.WriteLine();
            System.Console.WriteLine("FOLDERS: ");
            foreach(string s in folders){
                System.Console.WriteLine(s);
            }

        } catch(IOException e){
            System.Console.WriteLine("An error occured");
            System.Console.WriteLine(e.Message);
        }
        System.Console.WriteLine();

        // 2° Teste: Listar todos os arquivos a partir de MyFolder
        try{
            IEnumerable<string> folders = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); // var tbm serve
            System.Console.WriteLine();
            System.Console.WriteLine("FILES : ");
            foreach(string s in folders){
                System.Console.WriteLine(s);
            }
        } catch(IOException e){
            System.Console.WriteLine("An error occured");
            System.Console.WriteLine(e.Message);
        }
        


        // Criando uma pasta (newFolder a partir de MyFolder)
        Directory.CreateDirectory(path + "\\newFolder");

    }
}