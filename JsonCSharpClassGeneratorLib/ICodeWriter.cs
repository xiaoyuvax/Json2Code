namespace Xamasoft.JsonClassGenerator
{
    public interface ICodeWriter
    {
        string DisplayName { get; }
        string FileExtension { get; }

        string GetTypeName(JsonType type, IJsonClassGeneratorConfig config);

        void WriteClass(IJsonClassGeneratorConfig config, TextWriter sw, JsonType type);

        void WriteFileEnd(IJsonClassGeneratorConfig config, TextWriter sw);

        void WriteFileStart(IJsonClassGeneratorConfig config, TextWriter sw);

        void WriteNamespaceEnd(IJsonClassGeneratorConfig config, TextWriter sw, bool root);

        void WriteNamespaceStart(IJsonClassGeneratorConfig config, TextWriter sw, bool root);
    }
}