﻿#pragma checksum "E:\APTECH\Sem3\Music\Music\Pages\Upload.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F7FAD03489880CB3A0FDE98384535286"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Music.Pages
{
    partial class Upload : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Pages\Upload.xaml line 15
                {
                    this.name = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // Pages\Upload.xaml line 16
                {
                    this.name_validate = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // Pages\Upload.xaml line 18
                {
                    this.description = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // Pages\Upload.xaml line 20
                {
                    this.singer = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // Pages\Upload.xaml line 21
                {
                    this.singer_validate = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // Pages\Upload.xaml line 23
                {
                    this.author = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // Pages\Upload.xaml line 25
                {
                    this.thumbnail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // Pages\Upload.xaml line 26
                {
                    this.thumbnail_validate = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // Pages\Upload.xaml line 28
                {
                    this.link = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 11: // Pages\Upload.xaml line 29
                {
                    this.link_validate = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // Pages\Upload.xaml line 38
                {
                    global::Windows.UI.Xaml.Controls.Button element12 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element12).Click += this.ButtonUpload_OnClick;
                }
                break;
            case 13: // Pages\Upload.xaml line 39
                {
                    global::Windows.UI.Xaml.Controls.Button element13 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element13).Click += this.ButtonReset_OnClick;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
