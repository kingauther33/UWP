﻿#pragma checksum "D:\Documents\UWP\LabS2\LabS2\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6EE3F59282690467A6949CF2F7A26D19C7C7E70BD9821F9921552804712975CB"
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MainPage_obj31_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::LabS2.Models.User dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj31;
            private global::Windows.UI.Xaml.Controls.TextBlock obj32;
            private global::Windows.UI.Xaml.Controls.TextBlock obj33;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj32TextDisabled = false;
            private static bool isobj33TextDisabled = false;

            public MainPage_obj31_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 210 && columnNumber == 48)
                {
                    isobj32TextDisabled = true;
                }
                else if (lineNumber == 211 && columnNumber == 48)
                {
                    isobj33TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 31: // MainPage.xaml line 209
                        this.obj31 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.StackPanel)target);
                        break;
                    case 32: // MainPage.xaml line 210
                        this.obj32 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 33: // MainPage.xaml line 211
                        this.obj33 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj31.Target as global::Windows.UI.Xaml.Controls.StackPanel).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::LabS2.Models.User) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::LabS2.Models.User)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::LabS2.Models.User obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Email(obj.Email, phase);
                        this.Update_Content(obj.Content, phase);
                    }
                }
            }
            private void Update_Email(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainPage.xaml line 210
                    if (!isobj32TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj32, obj, null);
                    }
                }
            }
            private void Update_Content(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainPage.xaml line 211
                    if (!isobj33TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj33, obj, null);
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 27: // MainPage.xaml line 196
                {
                    this.SV = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 28: // MainPage.xaml line 198
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element28 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element28).Click += this.AppbarButton_Click;
                }
                break;
            case 29: // MainPage.xaml line 203
                {
                    this.ListUsers = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.ListUsers).Loaded += this.ListUsers_Loaded;
                }
                break;
            case 34: // MainPage.xaml line 191
                {
                    this.TxtBlockEmail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 35: // MainPage.xaml line 192
                {
                    this.TxtBlockSubject = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 36: // MainPage.xaml line 193
                {
                    this.TxtBlockContent = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 37: // MainPage.xaml line 182
                {
                    this.headerText = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 38: // MainPage.xaml line 185
                {
                    this.inputEmail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 39: // MainPage.xaml line 186
                {
                    this.inputSubject = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 40: // MainPage.xaml line 187
                {
                    this.inputContent = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 41: // MainPage.xaml line 188
                {
                    global::Windows.UI.Xaml.Controls.Button element41 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element41).Click += this.Button_Click;
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
            switch(connectionId)
            {
            case 31: // MainPage.xaml line 209
                {                    
                    global::Windows.UI.Xaml.Controls.StackPanel element31 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                    MainPage_obj31_Bindings bindings = new MainPage_obj31_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element31.DataContext);
                    element31.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element31, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element31, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

