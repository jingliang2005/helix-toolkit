﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelixToolkit.Wpf.SharpDX.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HelixToolkit.Wpf.SharpDX.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] _default {
            get {
                object obj = ResourceManager.GetObject("_default", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] _deferred {
            get {
                object obj = ResourceManager.GetObject("_deferred", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //--------------------------------------------------------------------------------------
        ///// File: Header for HelixToolkitDX
        ///// Author: Przemyslaw Musialski
        ///// Date: 11/11/12
        ///// References &amp; Sources: 
        /////--------------------------------------------------------------------------------------
        ///
        ///
        /////--------------------------------------------------------------------------------------
        /////  STATES DEFININITIONS 
        /////--------------------------------------------------------------------------------------
        ///Sample [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Common {
            get {
                return ResourceManager.GetString("Common", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //--------------------------------------------------------------------------------------
        ///// File: Default Effect for HelixToolkitDX
        ///// Author: Przemyslaw Musialski
        ///// Date: 11/11/12
        ///// References &amp; Sources: 
        ///// light equations from OpenGL Spec: http://www.opengl.org/documentation/specs/version1.2/OpenGL_spec_1.2.1.pdf
        ///// spotlight equation from DX9: http://msdn.microsoft.com/en-us/library/windows/desktop/bb174697(v=vs.85).aspx
        ///// parts of the code based on: http://takinginitiative.net/2010/08/30/dire [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Default {
            get {
                return ResourceManager.GetString("Default", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //--------------------------------------------------------------------------------------
        ///// File: Deferred G-Buffer Rendering for HelixToolkitDX
        ///// Author: Przemyslaw Musialski
        ///// Date: 03/03/13
        ///// References &amp; Sources: 
        ///// code based on: http://hieroglyph3.codeplex.com/
        /////--------------------------------------------------------------------------------------
        ///
        ///#include &quot;./Shaders/Common.fx&quot;
        ///#include &quot;./Shaders/Material.fx&quot;
        ///#include &quot;./Shaders/DeferredLighting.fx&quot;
        ///
        ///
        /////---------------------------- [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Deferred {
            get {
                return ResourceManager.GetString("Deferred", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //--------------------------------------------------------------------------------------
        ///// File: Deferred Lighting for HelixToolkitDX
        ///// Author: Przemyslaw Musialski
        ///// Created:  03/03/13
        ///// Modified: 06/18/13
        ///// References &amp; Sources: 
        ///// code based on the shader from: http://hieroglyph3.codeplex.com/
        /////--------------------------------------------------------------------------------------
        ///
        /////#include &quot;./Shaders/Common.fx&quot;
        /////#define MSAA
        ///#define EXERCISE3
        ///
        ///
        ///#ifdef MSAA
        ///	#define NUMSUBSAMPLES  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DeferredLighting {
            get {
                return ResourceManager.GetString("DeferredLighting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        /////--------------------------------------------------------------------------------------
        ///// File: Line Effects for HelixToolkitDX
        ///// Author: Przemyslaw Musialski
        ///// Date: 11/11/12
        ///// References &amp; Sources: 
        ///// http://cgg-journal.com/2008-2/06/index.html
        ///// http://developer.download.nvidia.com/SDK/10/direct3d/Source/SolidWireframe/Doc/SolidWireframe.pdf
        /////-------------------------------------------------------------------------------------
        ///
        /////#include &quot;./Shaders/Common.fx&quot;
        /////#include &quot;./Shaders/De [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Lines {
            get {
                return ResourceManager.GetString("Lines", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //--------------------------------------------------------------------------------------
        ///// File: Materials header for HelixToolkit.SharpDX
        ///// Author: Przemyslaw Musialski
        ///// Date: 11/11/12
        ///// References &amp; Sources: 
        /////--------------------------------------------------------------------------------------
        ///
        ///
        /////--------------------------------------------------------------------------------------
        ///// CONSTANT BUFF VARIABLES
        /////----------------------------------------------------------------------------- [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Material {
            get {
                return ResourceManager.GetString("Material", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap random_dot3 {
            get {
                object obj = ResourceManager.GetObject("random_dot3", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap random4x4_dot3 {
            get {
                object obj = ResourceManager.GetObject("random4x4_dot3", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //--------------------------------------------------------------------------------------
        ///// File: Tessellation Functions for HelixToolkitDX
        ///// Author: Przemyslaw Musialski
        ///// Date: 03/21/13
        ///// References &amp; Sources: Based on NVidia SDK 2011 
        /////--------------------------------------------------------------------------------------
        ///
        /////--------------------------------------------------------------------------------------
        ///// Work-around for an optimization rule problem in the June 2010 HLSL Compiler
        ///// ( [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Tessellation {
            get {
                return ResourceManager.GetString("Tessellation", resourceCulture);
            }
        }
    }
}
