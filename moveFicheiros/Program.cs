using System;
using System.IO;


namespace moveFicheiros
{
    class Program
    {
        static void Main(string[] args)
        {
            //MoveFiles(@"C:\TEMP", @"E:\TEMP"); // Teste @ Dev

            MoveFiles(@"T:\CEF\Cobranca\Remessa", @"C:\CEF\Cobranca\Remessa");
            MoveFiles(@"C:\CEF\Cobranca\Retorno", @"T:\CEF\Cobranca\Retorno");
            MoveFiles(@"T:\CEF\Pagamento\Remessa", @"C:\CEF\Pagamento\Remessa");
            MoveFiles(@"C:\CEF\Pagamento\Retorno", @"T:\CEF\Pagamento\Retorno");
            MoveFiles(@"C:\CEF\Extrato\Retorno", @"T:\CEF\Extrato\Retorno");

            MoveFiles(@"T:\Bradesco\Remessa", @"C:\Bradesco\Cobranca\Remessa");
            MoveFiles(@"C:\Bradesco\Cobranca\Retorno", @"T:\Bradesco\Retorno");
            MoveFiles(@"T:\Bradesco\Pagamento\Remessa", @"C:\Bradesco\Pagamento\Remessa");
            MoveFiles(@"C:\Bradesco\Pagamento\Retorno", @"T:\Bradesco\Pagamento\Retorno");

            MoveFiles(@"T:\Itau\Cobranca\Remessa", @"C:\Itau\Cobranca\Remessa");
            MoveFiles(@"C:\Itau\Cobranca\Retorno", @"T:\Itau\Cobranca\Retorno");
            MoveFiles(@"T:\Itau\Pagamento\Remessa", @"C:\Itau\Pagamento\Remessa");
            MoveFiles(@"C:\Itau\Pagamento\Retorno", @"T:\Itau\Pagamento\Retorno");
            MoveFiles(@"C:\Itau\Extrato\Retorno", @"T:\Itau\Extrato\Retorno");
        }
        static void MoveFiles(string fromFolder, string toFolder)
        {
            try
            {
                foreach (var file in Directory.EnumerateFiles(fromFolder))
                {
                    string toFile = Path.Combine(toFolder, Path.GetFileName(file));
                    if (!File.Exists(toFile))
                        File.Move(file, toFile);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }



}
