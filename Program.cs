using System;
using System.Text;
using System.Windows.Forms;

namespace Passwordm
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            string password = GenPassword(16);
            Clipboard.SetText(password);
            Console.WriteLine($"Password copied to clipboard: {password} ");
            System.Threading.Thread.Sleep(2000);
        }

        static string GenPassword(int length)
        {
        
        const string validChars =  "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$&_-+=?";
        StringBuilder result = new StringBuilder();
        Random random = new Random();

        for(int i = 0; i < length; i++){
            result.Append(validChars[random.Next(validChars.Length)]);
        }
        return result.ToString();
        }
    }

}