using System;
using System.IO;

namespace moveFicheiros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("... INICIO ...");

            //MoveFiles(@"C:\TEMP", @"E:\TEMP"); // Teste @ Dev

            MoveFiles(@"T:\CEF\Cobranca\Remessa", @"D:\CEF\Cobranca\Remessa");
            MoveFiles(@"D:\CEF\Cobranca\Retorno", @"T:\CEF\Cobranca\Retorno");
            MoveFiles(@"T:\CEF\Pagamento\Remessa", @"D:\CEF\Pagamento\Remessa");
            MoveFiles(@"D:\CEF\Pagamento\Retorno", @"T:\CEF\Pagamento\Retorno");
            MoveFiles(@"D:\CEF\Extrato\Retorno", @"T:\CEF\Extrato\Retorno");

            MoveFiles(@"T:\Bradesco\Remessa", @"D:\Bradesco\Cobranca\Remessa");
            MoveFiles(@"D:\Bradesco\Cobranca\Retorno", @"T:\Bradesco\Retorno");
            MoveFiles(@"T:\Bradesco\Pagamento\Remessa", @"D:\Bradesco\Pagamento\Remessa");
            MoveFiles(@"D:\Bradesco\Pagamento\Retorno", @"T:\Bradesco\Pagamento\Retorno");

            MoveFiles(@"T:\Itau\Cobranca\Remessa", @"D:\Itau\Cobranca\Remessa");
            MoveFiles(@"D:\Itau\Cobranca\Retorno", @"T:\Itau\Cobranca\Retorno");
            MoveFiles(@"T:\Itau\Pagamento\Remessa", @"D:\Itau\Pagamento\Remessa");
            MoveFiles(@"D:\Itau\Pagamento\Retorno", @"T:\Itau\Pagamento\Retorno");
            MoveFiles(@"D:\Itau\Extrato\Retorno", @"T:\Itau\Extrato\Retorno");

        }
        static void MoveFiles(string fromFolder, string toFolder)
        {

            try
            {
                foreach (var file in Directory.EnumerateFiles(fromFolder))
                {
                    string toFile = Path.Combine(toFolder, Path.GetFileName(file));
                    if (!File.Exists(toFile))
                    {
                        Console.Out.WriteLine("Movendo " + file + " para " + toFile);
                        File.Move(file, toFile);
                    }
                    else
                    {
                        Console.Out.WriteLine("Arquivo existe no destino: " + toFile);
                    }
                }
                Console.Out.WriteLine("... FIM ...");
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.ToString());
            }
        }
    }



}
