//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO.Mensajes {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Mensajes {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Mensajes() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DTO.Mensajes.Mensajes", typeof(Mensajes).Assembly);
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
        ///   Looks up a localized string similar to Registro Creado Exitosamente.
        /// </summary>
        public static string create {
            get {
                return ResourceManager.GetString("create", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ocurrió un error por favor comunicarse con el administrador.
        /// </summary>
        internal static string error {
            get {
                return ResourceManager.GetString("error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ocurrió un error creando el registro.
        /// </summary>
        public static string errorCreate {
            get {
                return ResourceManager.GetString("errorCreate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ocurrió un error consultando los registros.
        /// </summary>
        public static string errorGet {
            get {
                return ResourceManager.GetString("errorGet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usuario o Contraseña Invalida.
        /// </summary>
        public static string errorLogin {
            get {
                return ResourceManager.GetString("errorLogin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ocurrió un error actualizando el registro.
        /// </summary>
        internal static string errorUpdate {
            get {
                return ResourceManager.GetString("errorUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        public static string exception {
            get {
                return ResourceManager.GetString("exception", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ocurrió un error por favor comunicarse con el administrador.
        /// </summary>
        public static string exception2 {
            get {
                return ResourceManager.GetString("exception2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Registro Actualizado Exitosamente.
        /// </summary>
        public static string update {
            get {
                return ResourceManager.GetString("update", resourceCulture);
            }
        }
    }
}
