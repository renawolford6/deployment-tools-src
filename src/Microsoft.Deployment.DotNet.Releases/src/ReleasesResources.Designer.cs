﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Deployment.DotNet.Releases {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ReleasesResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ReleasesResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Deployment.DotNet.Releases.ReleasesResources", typeof(ReleasesResources).Assembly);
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
        ///   Looks up a localized string similar to ASP.NET Core Runtime.
        /// </summary>
        internal static string AspNetCoreReleaseName {
            get {
                return ResourceManager.GetString("AspNetCoreReleaseName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find the specified file: {0}.
        /// </summary>
        internal static string FileNotFound {
            get {
                return ResourceManager.GetString("FileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The expected hash ({0}) and actual hash ({1}) for {2} do not match..
        /// </summary>
        internal static string HashMismatch {
            get {
                return ResourceManager.GetString("HashMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The build metadata value is invalid: {0}.
        /// </summary>
        internal static string InvalidBuildMetadata {
            get {
                return ResourceManager.GetString("InvalidBuildMetadata", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid or missing major version..
        /// </summary>
        internal static string InvalidMajorVersion {
            get {
                return ResourceManager.GetString("InvalidMajorVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid or missing minor version..
        /// </summary>
        internal static string InvalidMinorVersion {
            get {
                return ResourceManager.GetString("InvalidMinorVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid or missing patch version..
        /// </summary>
        internal static string InvalidPatch {
            get {
                return ResourceManager.GetString("InvalidPatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The prerelease value is invalid: {0}.
        /// </summary>
        internal static string InvalidPrerelease {
            get {
                return ResourceManager.GetString("InvalidPrerelease", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid version: {0}.
        /// </summary>
        internal static string InvalidVersion {
            get {
                return ResourceManager.GetString("InvalidVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .NET Core Runtime.
        /// </summary>
        internal static string RuntimeReleaseName {
            get {
                return ResourceManager.GetString("RuntimeReleaseName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SDK.
        /// </summary>
        internal static string SdkReleaseName {
            get {
                return ResourceManager.GetString("SdkReleaseName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value cannot be empty..
        /// </summary>
        internal static string ValueCannotBeEmpty {
            get {
                return ResourceManager.GetString("ValueCannotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; value cannot be less than 0..
        /// </summary>
        internal static string VersionPartLessThanZero {
            get {
                return ResourceManager.GetString("VersionPartLessThanZero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Desktop Runtime.
        /// </summary>
        internal static string WindowsDesktopReleaseName {
            get {
                return ResourceManager.GetString("WindowsDesktopReleaseName", resourceCulture);
            }
        }
    }
}
