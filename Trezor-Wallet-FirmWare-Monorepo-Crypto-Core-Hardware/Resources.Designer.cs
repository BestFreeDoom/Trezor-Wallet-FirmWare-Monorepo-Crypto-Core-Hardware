﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KeePass2Trezor.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("KeePass2Trezor.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Confirm on your Trezor.
        /// </summary>
        internal static string ConfirmTrezorCaption {
            get {
                return ResourceManager.GetString("ConfirmTrezorCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///
        ///Key ID: {0}.
        /// </summary>
        internal static string ConfirmTrezorKeyID {
            get {
                return ResourceManager.GetString("ConfirmTrezorKeyID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Confirm unlocking the KeePass encrypted storage on your Trezor device..
        /// </summary>
        internal static string ConfirmTrezorMessage {
            get {
                return ResourceManager.GetString("ConfirmTrezorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Trezor connected.
        /// </summary>
        internal static string ConnectedTrezorCaption {
            get {
                return ResourceManager.GetString("ConnectedTrezorCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connect your Trezor.
        /// </summary>
        internal static string ConnectTrezorCaption {
            get {
                return ResourceManager.GetString("ConnectTrezorCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connect your Trezor device.
        /// </summary>
        internal static string ConnectTrezorMessage {
            get {
                return ResourceManager.GetString("ConnectTrezorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Trezor master key version. You may need a newer version of the Trezor Key Provider Plugin..
        /// </summary>
        internal static string ExceptionInvalidTrezorMasterKeyVersion {
            get {
                return ResourceManager.GetString("ExceptionInvalidTrezorMasterKeyVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operation confirmed.
        /// </summary>
        internal static string OperationConfirmedMessage {
            get {
                return ResourceManager.GetString("OperationConfirmedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} Model {1} connection recognized.
        /// </summary>
        internal static string TrezorConnectedMessage {
            get {
                return ResourceManager.GetString("TrezorConnectedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Trezor Key Provider.
        /// </summary>
        internal static string TrezorKeyProvider {
            get {
                return ResourceManager.GetString("TrezorKeyProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Trezor is working now.
        /// </summary>
        internal static string TrezorWorkingCaption {
            get {
                return ResourceManager.GetString("TrezorWorkingCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please wait while Trezor working.
        /// </summary>
        internal static string TrezorWorkingMessage {
            get {
                return ResourceManager.GetString("TrezorWorkingMessage", resourceCulture);
            }
        }
    }
}