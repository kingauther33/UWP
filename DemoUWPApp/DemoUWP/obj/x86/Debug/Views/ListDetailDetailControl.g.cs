﻿#pragma checksum "D:\Documents\UWP\DemoUWPApp\DemoUWP\Views\ListDetailDetailControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C69BE380EBEA8242490C24132E2EF44987E0196A64EB0DEC1E85489AC9557A44"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoUWP.Views
{
    partial class ListDetailDetailControl : 
        global::Windows.UI.Xaml.Controls.UserControl, 
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
            public static void Set_Windows_UI_Xaml_Controls_FontIcon_Glyph(global::Windows.UI.Xaml.Controls.FontIcon obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Glyph = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class ListDetailDetailControl_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IListDetailDetailControl_Bindings
        {
            private global::DemoUWP.Views.ListDetailDetailControl dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj4;
            private global::Windows.UI.Xaml.Controls.TextBlock obj5;
            private global::Windows.UI.Xaml.Controls.TextBlock obj6;
            private global::Windows.UI.Xaml.Controls.TextBlock obj7;
            private global::Windows.UI.Xaml.Controls.TextBlock obj8;
            private global::Windows.UI.Xaml.Controls.FontIcon obj9;
            private global::Windows.UI.Xaml.Controls.TextBlock obj10;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj4TextDisabled = false;
            private static bool isobj5TextDisabled = false;
            private static bool isobj6TextDisabled = false;
            private static bool isobj7TextDisabled = false;
            private static bool isobj8TextDisabled = false;
            private static bool isobj9GlyphDisabled = false;
            private static bool isobj10TextDisabled = false;

            private ListDetailDetailControl_obj1_BindingsTracking bindingsTracking;

            public ListDetailDetailControl_obj1_Bindings()
            {
                this.bindingsTracking = new ListDetailDetailControl_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 32 && columnNumber == 79)
                {
                    isobj4TextDisabled = true;
                }
                else if (lineNumber == 37 && columnNumber == 79)
                {
                    isobj5TextDisabled = true;
                }
                else if (lineNumber == 42 && columnNumber == 79)
                {
                    isobj6TextDisabled = true;
                }
                else if (lineNumber == 47 && columnNumber == 79)
                {
                    isobj7TextDisabled = true;
                }
                else if (lineNumber == 52 && columnNumber == 79)
                {
                    isobj8TextDisabled = true;
                }
                else if (lineNumber == 23 && columnNumber == 21)
                {
                    isobj9GlyphDisabled = true;
                }
                else if (lineNumber == 27 && columnNumber == 21)
                {
                    isobj10TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4: // Views\ListDetailDetailControl.xaml line 32
                        this.obj4 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 5: // Views\ListDetailDetailControl.xaml line 37
                        this.obj5 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 6: // Views\ListDetailDetailControl.xaml line 42
                        this.obj6 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 7: // Views\ListDetailDetailControl.xaml line 47
                        this.obj7 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 8: // Views\ListDetailDetailControl.xaml line 52
                        this.obj8 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 9: // Views\ListDetailDetailControl.xaml line 19
                        this.obj9 = (global::Windows.UI.Xaml.Controls.FontIcon)target;
                        break;
                    case 10: // Views\ListDetailDetailControl.xaml line 24
                        this.obj10 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IListDetailDetailControl_Bindings

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
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::DemoUWP.Views.ListDetailDetailControl)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::DemoUWP.Views.ListDetailDetailControl obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ListMenuItem(obj.ListMenuItem, phase);
                    }
                }
            }
            private void Update_ListMenuItem(global::DemoUWP.Core.Models.SampleOrder obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ListMenuItem_Status(obj.Status, phase);
                        this.Update_ListMenuItem_OrderDate(obj.OrderDate, phase);
                        this.Update_ListMenuItem_Company(obj.Company, phase);
                        this.Update_ListMenuItem_ShipTo(obj.ShipTo, phase);
                        this.Update_ListMenuItem_OrderTotal(obj.OrderTotal, phase);
                        this.Update_ListMenuItem_Symbol(obj.Symbol, phase);
                    }
                }
            }
            private void Update_ListMenuItem_Status(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\ListDetailDetailControl.xaml line 32
                    if (!isobj4TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj4, obj, null);
                    }
                }
            }
            private void Update_ListMenuItem_OrderDate(global::System.DateTime obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\ListDetailDetailControl.xaml line 37
                    if (!isobj5TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj5, obj.ToString(), null);
                    }
                }
            }
            private void Update_ListMenuItem_Company(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\ListDetailDetailControl.xaml line 42
                    if (!isobj6TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj6, obj, null);
                    }
                    // Views\ListDetailDetailControl.xaml line 24
                    if (!isobj10TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj10, obj, null);
                    }
                }
            }
            private void Update_ListMenuItem_ShipTo(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\ListDetailDetailControl.xaml line 47
                    if (!isobj7TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj7, obj, null);
                    }
                }
            }
            private void Update_ListMenuItem_OrderTotal(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\ListDetailDetailControl.xaml line 52
                    if (!isobj8TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj8, obj.ToString(), null);
                    }
                }
            }
            private void Update_ListMenuItem_Symbol(global::System.Char obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\ListDetailDetailControl.xaml line 19
                    if (!isobj9GlyphDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_FontIcon_Glyph(this.obj9, obj.ToString(), null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class ListDetailDetailControl_obj1_BindingsTracking
            {
                private global::System.WeakReference<ListDetailDetailControl_obj1_Bindings> weakRefToBindingObj; 

                public ListDetailDetailControl_obj1_BindingsTracking(ListDetailDetailControl_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<ListDetailDetailControl_obj1_Bindings>(obj);
                }

                public ListDetailDetailControl_obj1_Bindings TryGetBindingObject()
                {
                    ListDetailDetailControl_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void DependencyPropertyChanged_ListMenuItem(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    ListDetailDetailControl_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::DemoUWP.Views.ListDetailDetailControl obj = sender as global::DemoUWP.Views.ListDetailDetailControl;
                        if (obj != null)
                        {
                            bindings.Update_ListMenuItem(obj.ListMenuItem, DATA_CHANGED);
                        }
                    }
                }
                private long tokenDPC_ListMenuItem = 0;
                public void UpdateChildListeners_(global::DemoUWP.Views.ListDetailDetailControl obj)
                {
                    ListDetailDetailControl_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::DemoUWP.Views.ListDetailDetailControl.ListMenuItemProperty, tokenDPC_ListMenuItem);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_ListMenuItem = obj.RegisterPropertyChangedCallback(global::DemoUWP.Views.ListDetailDetailControl.ListMenuItemProperty, DependencyPropertyChanged_ListMenuItem);
                        }
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
            case 2: // Views\ListDetailDetailControl.xaml line 10
                {
                    this.ForegroundElement = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                }
                break;
            case 3: // Views\ListDetailDetailControl.xaml line 30
                {
                    this.block = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
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
            case 1: // Views\ListDetailDetailControl.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    ListDetailDetailControl_obj1_Bindings bindings = new ListDetailDetailControl_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

