﻿#pragma checksum "D:\Documents\UWP\LabS2\LabS2\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AA43A70E9DF9C9FCE58F284AF27F46A4EC6AB03E777251C65C5B1B2DABDC7A0E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LabS2
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 27: // MainPage.xaml line 190
                {
                    this.TxtBlockEmail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 28: // MainPage.xaml line 191
                {
                    this.TxtBlockSubject = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 29: // MainPage.xaml line 192
                {
                    this.TxtBlockContent = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 30: // MainPage.xaml line 181
                {
                    this.headerText = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 31: // MainPage.xaml line 184
                {
                    this.inputEmail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 32: // MainPage.xaml line 185
                {
                    this.inputSubject = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 33: // MainPage.xaml line 186
                {
                    this.inputContent = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 34: // MainPage.xaml line 187
                {
                    global::Windows.UI.Xaml.Controls.Button element34 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element34).Click += this.Button_Click;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

