﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Limnor.PhpComponents {
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
    internal class Resource1 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource1() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Limnor.PhpComponents.Resource1", typeof(Resource1).Assembly);
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
        ///   Looks up a localized string similar to &lt;?php
        ///class PhpComponent
        ///{
        ///.
        /// </summary>
        internal static string phpComponent_php {
            get {
                return ResourceManager.GetString("phpComponent_php", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap sendMail {
            get {
                object obj = ResourceManager.GetObject("sendMail", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?php
        ///class SendMail
        ///{
        ///	public $SMTP_Debug;
        ///	public $SMTP_Server;
        ///	public $SMTP_Port;
        ///	public $SMTP_Authenticate;
        ///	public $SMTP_UserName;
        ///	public $SMTP_Password;
        ///	public $MailSender;
        ///	public $From;
        ///	public $FromName;
        ///	public $To;
        ///	public $ToName;
        ///	public $Cc;
        ///	public $Bcc;
        ///	public $Body;
        ///	public $Subject;
        ///	public $Charset;
        ///	public $IsBodyHtml;
        ///	public $MimeVersion;
        ///	public $ErrorMessage;
        ///	public $SendCompleted;
        ///	public $files;
        ///	function __construct() 
        ///	{
        ///		$this-&gt;files = array();
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SendMail_php {
            get {
                return ResourceManager.GetString("SendMail_php", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?php
        ///class ServerFile
        ///{
        ///	public $Filename;
        ///	public $handle;
        ///	public $ForReading;
        ///	public $ForWriting;
        ///	public $FileOpenMode;//0:TruncateFile; 1: AppendFile; 2: CreateNewFile; 3: UseExistFile
        ///	//
        ///	public function GetFileMode()
        ///	{
        ///		$mode;
        ///		if($this-&gt;ForReading)
        ///		{
        ///			if($this-&gt;ForWriting)
        ///			{
        ///				if($this-&gt;FileCreation == 0)
        ///				{
        ///					$mode = &apos;w+&apos;;
        ///				}
        ///				else if($this-&gt;FileCreation == 1)
        ///				{
        ///					$mode = &apos;a+&apos;;
        ///				}
        ///				else if($this-&gt;FileCreation == 2)
        ///				{
        ///					$mode = [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string serverfile_php {
            get {
                return ResourceManager.GetString("serverfile_php", resourceCulture);
            }
        }
    }
}