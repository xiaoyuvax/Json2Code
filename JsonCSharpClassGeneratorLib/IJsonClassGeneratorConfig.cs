using Xamasoft.JsonClassGenerator.CodeWriters;

namespace Xamasoft.JsonClassGenerator
{
    public interface IJsonClassGeneratorConfig
    {
        bool AlwaysUseNullableValues { get; set; }
        bool ApplyObfuscationAttributes { get; set; }
        ICodeWriter CodeWriter { get; set; }
        bool ExamplesInDocumentation { get; set; }
        bool ExplicitDeserialization { get; set; }
        bool HasSecondaryClasses { get; }
        bool InternalVisibility { get; set; }
        string MainClass { get; set; }
        string Namespace { get; set; }
        bool NoHelperClass { get; set; }
        AttributeEnum PropertyAttribute { get; set; }
        string SecondaryNamespace { get; set; }
        bool SingleFile { get; set; }
        bool UseNamespaces { get; }
        bool UseNestedClasses { get; set; }
        bool UsePascalCase { get; set; }
        bool UseProperties { get; set; }
    }
}