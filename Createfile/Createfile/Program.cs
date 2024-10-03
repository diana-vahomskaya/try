using System.Reflection;
using static System.Net.Mime.MediaTypeNames;


string currentDirectory = Directory.GetCurrentDirectory();

string projectPath = Path.GetFullPath(Path.Combine(currentDirectory, @"..\.."));
string outputFilePath = Path.Combine(AppContext.BaseDirectory, "output.txt");
var filePath = $"{projectPath}\\Name.txt";

try
{
    string word = File.ReadAllText(filePath);
    string result = $"{word} hello world";
    File.WriteAllText(outputFilePath, result);
    Console.WriteLine($"Содержимое файла: {word}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}