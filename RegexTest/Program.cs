using System.Text.RegularExpressions;
string pattern = @"^\w[\w-]*@[\w]+(\.[\w]+)+";
Console.WriteLine(Regex.IsMatch("nurlan@gmail.com",pattern));
Console.WriteLine(Regex.IsMatch("nurlan@code.edu.az", pattern));
Console.WriteLine(Regex.IsMatch("nur-lan@code.edu.az", pattern));
Console.WriteLine(Regex.IsMatch("-nurlan@code.edu.az", pattern)); // bu false olmalidi