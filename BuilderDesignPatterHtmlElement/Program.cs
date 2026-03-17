using System;
using System.Text;

namespace BuilderDesignPatterHtmlElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Builder!");
            var builder = new HtmlBuilder("ul");
            builder.Clear(); // disengage builder from the object it's building, then...
            builder.AddChild("li", "hello").AddChild("li", "world");
            Console.WriteLine(builder);


            var cb = new CodeBuilder("Person")
                .AddField("Name", "string")
                .AddField("Age", "int");

            Console.WriteLine(cb.ToString());
        }
    }

    public class HtmlElement
    {
        private const int indentSize = 2;


        public string? Name { get; set; }
        public string? Text { get; set; }


        public List<HtmlElement> Elements = [];


        public HtmlElement()
        {

        }

        public HtmlElement(string name, string text)
        {
            Name = name;
            Text = text;
        }

        public string ToStringImplementation(int indent)
        {
            var sb = new StringBuilder();
            string i = new string(' ', indentSize * indent);
            sb.Append($"{i}<{Name}>\n");
            if (!string.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new string(' ', indentSize * (indent + 1)));
                sb.Append(Text);
                sb.Append("\n");
            }

            foreach (var e in Elements)
                sb.Append(e.ToStringImplementation(indent + 1));

            sb.Append($"{i}</{Name}>\n");
            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImplementation(0);
        }
    }

    public class HtmlBuilder
    {
        private readonly string rootName;

        public HtmlBuilder(string rootName)
        {
            this.rootName = rootName;
            root.Name = rootName;
        }

        public HtmlBuilder AddChild(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            root.Elements.Add(e);
            return this;
        }

        public override string ToString()
        {
            return root.ToString();
        }

        public void Clear()
        {
            root = new HtmlElement { Name = rootName };
        }

        HtmlElement root = new HtmlElement();
    }


    public class CodeBuilderOld
    {
        // TODO
        private StringBuilder sb = new StringBuilder();
        private const int indentSize = 2;

        public CodeBuilderOld(string className)
        {
            var i = new string(' ', indentSize * 1);
            sb.Append($"{i} public class {className} \n");
            sb.Append($"{i}");
            sb.Append("{");
        }

        public CodeBuilderOld AddField(int indent, string name, string type)
        {
            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(type))
            {
                var i = new string(' ', indentSize * (indent + 1));
                sb.Append($"{i}public {type} {name};\n");
            }
            return this;
        }

        public override string ToString()
        {
            var i = new string(' ', indentSize * 1);
            sb.Append($"{i}");
            sb.Append("}");
            return sb.ToString();
        }
    }

    public class CodeBuilder
    {
        CodeElement root = new();

        public CodeBuilder(string name)
        {
            root.Name = name;
            root.DataType = "class";
        }

        public CodeBuilder AddField(string name, string type)
        {
            var e = new FieldElement(name, type);
            root.Elements.Add(e);
            return this;
        }

        public override string ToString()
        {
            return root.ToString();
        }
    }

    public class CodeElement
    {
        private const int indentSize = 2;
        public string Name { get; set; }
        public string DataType { get; set; }
        public List<FieldElement> Elements = [];


        public override string ToString()
        {
            var sb = new StringBuilder();
            var i = new string(' ', indentSize);
            sb.AppendLine($"public {DataType} {Name}");
            sb.AppendLine("{");
            foreach (var field in Elements)
            {
                sb.AppendLine($"{i}{field}");
            }
            sb.AppendLine("}");
            return sb.ToString();
        }
    }

    public class FieldElement
    {
        public string Name { get; set; }
        public string DataType { get; set; }
        public string AccessModifier { get; set; }


        public FieldElement(string name, string type, string accessModifier = "public")
        {
            Name = name;
            DataType = type;
            AccessModifier = accessModifier;
        }

        public override string ToString()
        {
            return $"{AccessModifier} {DataType} {Name};";
        }
    }


}
