﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrmTraceReader.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CrmTraceReader.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Connected to {0}.
        /// </summary>
        internal static string ConnectedTo {
            get {
                return ResourceManager.GetString("ConnectedTo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured while filtering trace: .
        /// </summary>
        internal static string ErrorWhileFilteringMessage {
            get {
                return ResourceManager.GetString("ErrorWhileFilteringMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured while loading files:.
        /// </summary>
        internal static string ErrorWhileLoadingFileMessage {
            get {
                return ResourceManager.GetString("ErrorWhileLoadingFileMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error while resolving names: .
        /// </summary>
        internal static string ErrorWhileResolvingNames {
            get {
                return ResourceManager.GetString("ErrorWhileResolvingNames", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Filtering....
        /// </summary>
        internal static string FilteringLoadingPanelMessage {
            get {
                return ResourceManager.GetString("FilteringLoadingPanelMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loading file(s)....
        /// </summary>
        internal static string LoadingFileLoadingPanelMessage {
            get {
                return ResourceManager.GetString("LoadingFileLoadingPanelMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error.
        /// </summary>
        internal static string MessageBoxErrorTitle {
            get {
                return ResourceManager.GetString("MessageBoxErrorTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not connected.
        /// </summary>
        internal static string NotConnected {
            get {
                return ResourceManager.GetString("NotConnected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Log file|*.log.
        /// </summary>
        internal static string OpenFileFilter {
            get {
                return ResourceManager.GetString("OpenFileFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select the log file to open.
        /// </summary>
        internal static string OpenFileTitleMessage {
            get {
                return ResourceManager.GetString("OpenFileTitleMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select the folder that contains log files to open.
        /// </summary>
        internal static string OpenFolderDescriptionMessage {
            get {
                return ResourceManager.GetString("OpenFolderDescriptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Searching for available organizations....
        /// </summary>
        internal static string SearchingForAvailableOrganizations {
            get {
                return ResourceManager.GetString("SearchingForAvailableOrganizations", resourceCulture);
            }
        }
    }
}
