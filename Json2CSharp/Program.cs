using Xamasoft.JsonClassGenerator;
using Xamasoft.JsonClassGenerator.CodeWriters;
using static Xamasoft.JsonClassGenerator.JsonClassGenerator;

public static class Program
{
    private static void Main(string[] args)
    {
        FileInfo fi = null;
        if (args.Contains("-?")) Console.WriteLine("Json2Code <json2file> <outputCodeFile> <Lang:1 or CS,2 or VB,4 or SQL,5 or Java,6 or Php,7 or TS> [useNestedClass:false|true] [usePascalCase:false|true] [useAccessor:true:false][attribue:None|JsonProperty|DataMember] [RootClassName] [NameSpace] ");
        if (File.Exists(args[0]))
        {
            try { fi = new FileInfo(args[1]); }
            catch (Exception ex) { Console.WriteLine($"Error:{ex.Message}"); }

            var json = File.ReadAllText(args[0]);
            if (Enum.TryParse(args[2], out LangEnum lang))
            {
                var nest = args.Length > 3 && bool.TryParse(args[3], out bool n) && n;
                var pascal = args.Length > 4 && bool.TryParse(args[4], out bool p) && p;
                var useAccessors = args.Length <= 5 || !bool.TryParse(args[5], out bool g) || g;
                var attr = args.Length > 6 ? Enum.TryParse(args[6], out AttributeEnum a) ? a : AttributeEnum.None : AttributeEnum.None;
                var className = args.Length > 7 ? args[7] : null;
                var nameSpace = args.Length > 8 ? args[8] : null;

                var code = JsonClassGenerator.Convert(json, lang, className, nameSpace, nest, pascal, useAccessors, attr);
                if (args.Length > 1) File.WriteAllText(fi.FullName, code);

                Console.WriteLine($"Success: code written to:{fi.FullName}");
            }
            else Console.WriteLine("Error:Language not supported!");
        }
        else Console.WriteLine("Error:Json file not found!");
    }
}