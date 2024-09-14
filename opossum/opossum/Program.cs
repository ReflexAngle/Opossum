using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.IO;
using static opossum.opossum.uploadList;
using opossum.opossum;

static void main()
{
    string wordList = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "File", "wordList.txt");
    // checks if a word list exists in the program
    if (File.Exists(wordList)){ Console.WriteLine("List Found");}
    else{ // if one doesnt exist then it prompt to have one added
        Console.WriteLine("Word List Not Found Please upload one");
        string wordListpath = Console.ReadLine();
        //uploadList.uploadList(wordListpath);
    }

    string hello = Console.ReadLine();
    
    Console.WriteLine(computerMD5(hello));
    
    
}
main();

static string computerMD5(string hello)
{
    using (MD5 md5 = MD5.Create())
    {
        byte[] inputBytes = Encoding.UTF8.GetBytes(hello);
        byte[] hashBytes = md5.ComputeHash(inputBytes);

        StringBuilder sb = new StringBuilder();
        foreach (byte i in hashBytes) { sb.Append(i.ToString("X2")); }

        return sb.ToString();
    }
}