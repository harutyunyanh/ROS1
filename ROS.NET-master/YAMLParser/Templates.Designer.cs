//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YAMLParser {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Templates {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Templates() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("YAMLParser.Templates", typeof(Templates).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System.Reflection;
        ///using System.Runtime.CompilerServices;
        ///using System.Runtime.InteropServices;
        ///
        ///// General Information about an assembly is controlled through the following 
        ///// set of attributes. Change these attribute values to modify the information
        ///// associated with an assembly.
        ///[assembly: AssemblyTitle(&quot;Messages&quot;)]
        ///[assembly: AssemblyDescription(&quot;&quot;)]
        ///[assembly: AssemblyConfiguration(&quot;&quot;)]
        ///[assembly: AssemblyCompany(&quot;&quot;)]
        ///[assembly: AssemblyProduct(&quot;Messages&quot;)]
        ///[assembly: AssemblyCopyri [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AssemblyInfo {
            get {
                return ResourceManager.GetString("AssemblyInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections;
        ///using System.Collections.Generic;
        ///using System.Diagnostics;
        ///using System.IO;
        ///using System.Linq;
        ///using System.Reflection;
        ///using System.Runtime.InteropServices;
        ///using System.Text;
        ///using String = Messages.std_msgs.String;
        ///using uint8 = System.Byte;
        ///
        ///namespace Messages
        ///{
        ///    public class IRosMessage
        ///    {
        ///        internal static Dictionary&lt;MsgTypes, Func&lt;MsgTypes, IRosMessage&gt;&gt; constructors = new Dictionary&lt;MsgTypes, Func&lt;MsgTypes, IRosMessage&gt;&gt;();
        ///       [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Interfaces {
            get {
                return ResourceManager.GetString("Interfaces", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;Project ToolsVersion=&quot;4.0&quot; DefaultTargets=&quot;Build&quot; xmlns=&quot;http://schemas.microsoft.com/developer/msbuild/2003&quot;&gt;
        ///  &lt;PropertyGroup&gt;
        ///    &lt;Configuration Condition=&quot; &apos;$(Configuration)&apos; == &apos;&apos; &quot;&gt;Debug&lt;/Configuration&gt;
        ///    &lt;Platform Condition=&quot; &apos;$(Platform)&apos; == &apos;&apos; &quot;&gt;AnyCPU&lt;/Platform&gt;
        ///    &lt;ProductVersion&gt;9.0.30729&lt;/ProductVersion&gt;
        ///    &lt;SchemaVersion&gt;2.0&lt;/SchemaVersion&gt;
        ///    &lt;ProjectGuid&gt;{94C4DF5B-1566-4ACC-9BD3-167AAC83F9FD}&lt;/ProjectGuid&gt;
        ///    &lt;OutputType&gt;Library&lt;/OutputTy [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MessagesProj {
            get {
                return ResourceManager.GetString("MessagesProj", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Linq;
        ///using System.Text;
        ///using System.IO;
        ///using System.Runtime.InteropServices;
        ///using uint8 = System.Byte;
        ///
        ///namespace Messages
        ///{
        ///	[System.Diagnostics.DebuggerStepThrough]
        ///	public class $WHATAMI : IRosMessage
        ///	{
        ///		$$DOLLADOLLABILLS
        ///
        ///		[System.Diagnostics.DebuggerStepThrough]
        ///		public $WHATAMI() : base($MYMSGTYPE, $MYMESSAGEDEFINITION, $MYHASHEADER, $MYISMETA, new Dictionary&lt;string, MsgFieldInfo&gt;$MYFIELDS, &quot;$MYMD5SUM&quot;)
        ///		{
        ///			$NULL [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string MsgPlaceHolder {
            get {
                return ResourceManager.GetString("MsgPlaceHolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #region Using
        ///
        ///using System;
        ///using System.Collections;
        ///using System.Collections.Generic;
        ///using System.Diagnostics;
        ///using System.IO;
        ///using System.Linq;
        ///using System.Reflection;
        ///using System.Runtime.InteropServices;
        ///using System.Text;
        ///using String = Messages.std_msgs.String;
        ///
        ///#endregion
        ///
        ///namespace Messages
        ///{
        ///#if !TRACE
        ///    [System.Diagnostics.DebuggerStepThrough]
        ///#else
        ///    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        ///#endif
        ///    public static c [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SerializationHelper {
            get {
                return ResourceManager.GetString("SerializationHelper", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Linq;
        ///using System.Text;
        ///using System.IO;
        ///using System.Runtime.InteropServices;
        ///using uint8 = System.Byte;
        ///
        ///namespace Messages
        ///{
        ///	[System.Diagnostics.DebuggerStepThrough]
        ///	public class $WHATAMI : IRosService
        ///	{
        ///		[System.Diagnostics.DebuggerStepThrough]
        ///		public $WHATAMI() : base($MYSRVTYPE, $MYSERVICEDEFINITION, &quot;$MYSRVMD5SUM&quot;)
        ///		{
        ///			InitSubtypes(new Request(), new Response());
        ///		}
        ///		
        ///		public Response Invoke(Func&lt;Request, Res [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SrvPlaceHolder {
            get {
                return ResourceManager.GetString("SrvPlaceHolder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;Project ToolsVersion=&quot;4.0&quot; DefaultTargets=&quot;Build&quot; xmlns=&quot;http://schemas.microsoft.com/developer/msbuild/2003&quot;&gt;
        ///  &lt;PropertyGroup&gt;
        ///    &lt;Configuration Condition=&quot; &apos;$(Configuration)&apos; == &apos;&apos; &quot;&gt;Debug&lt;/Configuration&gt;
        ///    &lt;Platform Condition=&quot; &apos;$(Platform)&apos; == &apos;&apos; &quot;&gt;AnyCPU&lt;/Platform&gt;
        ///    &lt;ProductVersion&gt;9.0.30729&lt;/ProductVersion&gt;
        ///    &lt;SchemaVersion&gt;2.0&lt;/SchemaVersion&gt;
        ///    &lt;ProjectGuid&gt;{94C4DF5B-1566-4ACC-9BD3-167AAC83F9FD}&lt;/ProjectGuid&gt;
        ///    &lt;OutputType&gt;Library&lt;/OutputTy [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TempMessagesProj {
            get {
                return ResourceManager.GetString("TempMessagesProj", resourceCulture);
            }
        }
    }
}
