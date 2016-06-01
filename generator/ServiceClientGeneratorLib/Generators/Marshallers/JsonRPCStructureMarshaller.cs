﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.Marshallers
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class JsonRPCStructureMarshaller : BaseRequestMarshaller
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"

	AddLicenseHeader();

	AddCommonUsingStatements();

            
            #line default
            #line hidden
            this.Write("using ThirdParty.Json.LitJson;\r\n\r\nnamespace ");
            
            #line 13 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model.Internal.MarshallTransformations\r\n{\r\n\t/// <summary>\r\n\t/// ");
            
            #line 16 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write(" Marshaller\r\n\t/// </summary>       \r\n\tpublic class ");
            
            #line 18 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write("Marshaller : IRequestMarshaller<");
            
            #line 18 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write(@", JsonMarshallerContext> 
	{
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name=""requestObject""></param>
        /// <param name=""context""></param>
        /// <returns></returns>
		public void Marshall(");
            
            #line 26 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write(" requestObject, JsonMarshallerContext context)\r\n\t\t{\r\n");
            
            #line 28 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"

    ProcessMembers(0, "requestObject", this.Structure.Members);

            
            #line default
            #line hidden
            this.Write("\t\t}\r\n\r\n        /// <summary>\r\n        /// Singleton Marshaller.\r\n        /// </su" +
                    "mmary>  \r\n\t\tpublic readonly static ");
            
            #line 36 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write("Marshaller Instance = new ");
            
            #line 36 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Structure.Name));
            
            #line default
            #line hidden
            this.Write("Marshaller();\r\n\r\n\t}\r\n}\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 41 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"

	protected void ProcessMembers(int level, string variableName, IEnumerable<Member> members)
	{
		foreach(var member in members)
		{			

        
        #line default
        #line hidden
        
        #line 47 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(new string(' ', level * 4)));

        
        #line default
        #line hidden
        
        #line 47 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("            if(");

        
        #line default
        #line hidden
        
        #line 47 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 47 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(".IsSet");

        
        #line default
        #line hidden
        
        #line 47 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.PropertyName));

        
        #line default
        #line hidden
        
        #line 47 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("())\r\n");

        
        #line default
        #line hidden
        
        #line 48 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(new string(' ', level * 4)));

        
        #line default
        #line hidden
        
        #line 48 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("            {\r\n");

        
        #line default
        #line hidden
        
        #line 49 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(new string(' ', level * 4)));

        
        #line default
        #line hidden
        
        #line 49 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("                context.Writer.WritePropertyName(\"");

        
        #line default
        #line hidden
        
        #line 49 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallName));

        
        #line default
        #line hidden
        
        #line 49 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("\");\r\n");

        
        #line default
        #line hidden
        
        #line 50 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"

			if(member.IsStructure || member.IsList || member.IsMap)
			{
				this.ProcessStructure(level, variableName + "." + member.PropertyName, member.Shape);
			}
            else if(!string.IsNullOrEmpty(member.CustomMarshallerTransformation))
            {

        
        #line default
        #line hidden
        
        #line 58 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(new string(' ', level * 4)));

        
        #line default
        #line hidden
        
        #line 58 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("                context.Writer.Write(");

        
        #line default
        #line hidden
        
        #line 58 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(member.CustomMarshallerTransformation + "(" + variableName + "." + member.PropertyName + ")"));

        
        #line default
        #line hidden
        
        #line 58 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(");\r\n");

        
        #line default
        #line hidden
        
        #line 59 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"

            }
			else if(member.IsMemoryStream)
			{

        
        #line default
        #line hidden
        
        #line 64 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(new string(' ', level * 4)));

        
        #line default
        #line hidden
        
        #line 64 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("                context.Writer.Write(StringUtils.FromMemoryStream(");

        
        #line default
        #line hidden
        
        #line 64 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName + "." + member.PropertyName));

        
        #line default
        #line hidden
        
        #line 64 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("));\r\n");

        
        #line default
        #line hidden
        
        #line 65 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"

			}
			else
			{

        
        #line default
        #line hidden
        
        #line 70 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(new string(' ', level * 4)));

        
        #line default
        #line hidden
        
        #line 70 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("                context.Writer.Write(");

        
        #line default
        #line hidden
        
        #line 70 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName + "." + member.PropertyName));

        
        #line default
        #line hidden
        
        #line 70 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(");\r\n");

        
        #line default
        #line hidden
        
        #line 71 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"

			}

        
        #line default
        #line hidden
        
        #line 74 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(new string(' ', level * 4)));

        
        #line default
        #line hidden
        
        #line 74 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("            }\r\n\r\n");

        
        #line default
        #line hidden
        
        #line 76 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"

		}
	}

    protected void ProcessRequestPayloadMember(int level, string variableName, Shape structure)
    {

        
        #line default
        #line hidden
        
        #line 82 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("\r\n");

        
        #line default
        #line hidden
        
        #line 84 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(new string(' ', level * 4)));

        
        #line default
        #line hidden
        
        #line 84 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("                var marshaller = ");

        
        #line default
        #line hidden
        
        #line 84 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(structure.Name));

        
        #line default
        #line hidden
        
        #line 84 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("Marshaller.Instance;\r\n");

        
        #line default
        #line hidden
        
        #line 85 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(new string(' ', level * 4)));

        
        #line default
        #line hidden
        
        #line 85 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("                marshaller.Marshall(");

        
        #line default
        #line hidden
        
        #line 85 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 85 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(", context);\r\n");

        
        #line default
        #line hidden
        
        #line 86 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"

    }

	protected void ProcessStructure(int level, string variableName, Shape structure)
	{
			string flatVariableName = variableName.Replace(".", "");

			if(structure.IsList)
			{

        
        #line default
        #line hidden
        
        #line 96 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(new string(' ', level * 4)));

        
        #line default
        #line hidden
        
        #line 96 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("                context.Writer.WriteArrayStart();\r\n");

        
        #line default
        #line hidden
        
        #line 97 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(new string(' ', level * 4)));

        
        #line default
        #line hidden
        
        #line 97 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("                foreach(var ");

        
        #line default
        #line hidden
        
        #line 97 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(flatVariableName));

        
        #line default
        #line hidden
        
        #line 97 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("ListValue in ");

        
        #line default
        #line hidden
        
        #line 97 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 97 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(")\r\n");

        
        #line default
        #line hidden
        
        #line 98 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(new string(' ', level * 4)));

        
        #line default
        #line hidden
        
        #line 98 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("                {\r\n");

        
        #line default
        #line hidden
        
        #line 99 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
 
				ProcessStructure(level + 1, flatVariableName + "ListValue", structure.ListShape);

        
        #line default
        #line hidden
        
        #line 102 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(new string(' ', level * 4)));

        
        #line default
        #line hidden
        
        #line 102 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("                }\r\n");

        
        #line default
        #line hidden
        
        #line 103 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(new string(' ', level * 4)));

        
        #line default
        #line hidden
        
        #line 103 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("                context.Writer.WriteArrayEnd();\r\n");

        
        #line default
        #line hidden
        
        #line 104 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"

			}
			else if(structure.IsMap)
			{

        
        #line default
        #line hidden
        
        #line 109 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(new string(' ', level * 4)));

        
        #line default
        #line hidden
        
        #line 109 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("                context.Writer.WriteObjectStart();\r\n");

        
        #line default
        #line hidden
        
        #line 110 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(new string(' ', level * 4)));

        
        #line default
        #line hidden
        
        #line 110 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("                foreach (var ");

        
        #line default
        #line hidden
        
        #line 110 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(flatVariableName));

        
        #line default
        #line hidden
        
        #line 110 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("Kvp in ");

        
        #line default
        #line hidden
        
        #line 110 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 110 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(")\r\n");

        
        #line default
        #line hidden
        
        #line 111 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(new string(' ', level * 4)));

        
        #line default
        #line hidden
        
        #line 111 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("                {\r\n");

        
        #line default
        #line hidden
        
        #line 112 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(new string(' ', level * 4)));

        
        #line default
        #line hidden
        
        #line 112 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("                    context.Writer.WritePropertyName(");

        
        #line default
        #line hidden
        
        #line 112 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(flatVariableName));

        
        #line default
        #line hidden
        
        #line 112 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("Kvp.Key);\r\n");

        
        #line default
        #line hidden
        
        #line 113 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(new string(' ', level * 4)));

        
        #line default
        #line hidden
        
        #line 113 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("                    var ");

        
        #line default
        #line hidden
        
        #line 113 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(flatVariableName));

        
        #line default
        #line hidden
        
        #line 113 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("Value = ");

        
        #line default
        #line hidden
        
        #line 113 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(flatVariableName));

        
        #line default
        #line hidden
        
        #line 113 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("Kvp.Value;\r\n\r\n");

        
        #line default
        #line hidden
        
        #line 115 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
 
				ProcessStructure(level + 1, flatVariableName + "Value", structure.ValueShape);

        
        #line default
        #line hidden
        
        #line 118 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(new string(' ', level * 4)));

        
        #line default
        #line hidden
        
        #line 118 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("                }\r\n");

        
        #line default
        #line hidden
        
        #line 119 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(new string(' ', level * 4)));

        
        #line default
        #line hidden
        
        #line 119 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("                context.Writer.WriteObjectEnd();\r\n");

        
        #line default
        #line hidden
        
        #line 120 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"

			}
			else if(structure.IsStructure)
			{

        
        #line default
        #line hidden
        
        #line 125 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(new string(' ', level * 4)));

        
        #line default
        #line hidden
        
        #line 125 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("                context.Writer.WriteObjectStart();\r\n\r\n");

        
        #line default
        #line hidden
        
        #line 127 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(new string(' ', level * 4)));

        
        #line default
        #line hidden
        
        #line 127 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("                var marshaller = ");

        
        #line default
        #line hidden
        
        #line 127 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(structure.Name));

        
        #line default
        #line hidden
        
        #line 127 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("Marshaller.Instance;\r\n");

        
        #line default
        #line hidden
        
        #line 128 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(new string(' ', level * 4)));

        
        #line default
        #line hidden
        
        #line 128 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("                marshaller.Marshall(");

        
        #line default
        #line hidden
        
        #line 128 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 128 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(", context);\r\n\r\n");

        
        #line default
        #line hidden
        
        #line 130 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(new string(' ', level * 4)));

        
        #line default
        #line hidden
        
        #line 130 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("                context.Writer.WriteObjectEnd();\r\n");

        
        #line default
        #line hidden
        
        #line 131 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"

			}
			else if(structure.IsMemoryStream)
			{

        
        #line default
        #line hidden
        
        #line 136 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(new string(' ', level * 4)));

        
        #line default
        #line hidden
        
        #line 136 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("                context.Writer.Write(StringUtils.FromMemoryStream(");

        
        #line default
        #line hidden
        
        #line 136 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 136 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("));\r\n");

        
        #line default
        #line hidden
        
        #line 137 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"

			}
			else
			{

        
        #line default
        #line hidden
        
        #line 142 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(new string(' ', level * 4)));

        
        #line default
        #line hidden
        
        #line 142 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write("                    context.Writer.Write(");

        
        #line default
        #line hidden
        
        #line 142 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(this.ToStringHelper.ToStringWithCulture(variableName));

        
        #line default
        #line hidden
        
        #line 142 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"
this.Write(");\r\n");

        
        #line default
        #line hidden
        
        #line 143 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\Marshallers\JsonRPCStructureMarshaller.tt"

			}
	}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
