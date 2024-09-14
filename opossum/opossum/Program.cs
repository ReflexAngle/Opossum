using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.IO;
using opossum.opossum;
using opossum.Hashing;


static void main()
{
    string wordList = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "files", "wordList.txt");
    // checks if a word list exists in the program
    if (File.Exists(wordList)){ Console.WriteLine("List Found");}
    else{ // if one doesnt exist then it prompt to have one added
        Console.WriteLine("Word List Not Found Please upload one");
        string wordListPath = Console.ReadLine();
        uploadList.wordListUpload(wordListPath);
    }

    string hello = Console.ReadLine();
    
    Console.WriteLine(hashToMD5.computerMD5(hello));
    
    
}
main();
