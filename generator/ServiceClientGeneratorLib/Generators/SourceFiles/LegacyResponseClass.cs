﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.SourceFiles
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\LegacyResponseClass.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class LegacyResponseClass : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\LegacyResponseClass.tt"

	AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("\r\nusing System;\r\n\r\nnamespace ");
            
            #line 12 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\LegacyResponseClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model\r\n{\r\n    /// <summary>\r\n    /// Configuration for accessing Amazon ");
            
            #line 15 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\LegacyResponseClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.OperationName));
            
            #line default
            #line hidden
            this.Write(" service\r\n    /// </summary>\r\n\tpublic partial class ");
            
            #line 17 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\LegacyResponseClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.OperationName));
            
            #line default
            #line hidden
            this.Write("Response : ");
            
            #line 17 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\LegacyResponseClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.OperationName));
            
            #line default
            #line hidden
            this.Write("Result\r\n\t{\r\n        /// <summary>\r\n        /// Gets and sets the ");
            
            #line 20 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\LegacyResponseClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.OperationName));
            
            #line default
            #line hidden
            this.Write("Result property.\r\n        /// Represents the output of a ");
            
            #line 21 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\LegacyResponseClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.OperationName));
            
            #line default
            #line hidden
            this.Write(" operation.\r\n        /// </summary>\r\n        [Obsolete(@\"This property has been d" +
                    "eprecated. All properties of the ");
            
            #line 23 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\LegacyResponseClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.OperationName));
            
            #line default
            #line hidden
            this.Write("Result class are now available on the ");
            
            #line 23 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\LegacyResponseClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.OperationName));
            
            #line default
            #line hidden
            this.Write("Response class. You should use the properties on ");
            
            #line 23 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\LegacyResponseClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.OperationName));
            
            #line default
            #line hidden
            this.Write("Response instead of accessing them through ");
            
            #line 23 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\LegacyResponseClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.OperationName));
            
            #line default
            #line hidden
            this.Write("Result.\")]\r\n        public ");
            
            #line 24 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\LegacyResponseClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.OperationName));
            
            #line default
            #line hidden
            this.Write("Result ");
            
            #line 24 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\LegacyResponseClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.OperationName));
            
            #line default
            #line hidden
            this.Write("Result\r\n        {\r\n            get\r\n            {\r\n                return this;\r\n" +
                    "            }\r\n        }\r\n    }\r\n}\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 34 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\LegacyResponseClass.tt"

    public string OperationName { get; set; }

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
