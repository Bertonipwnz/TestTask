﻿#pragma checksum "D:\ProjectSharp\TestTaskUWP\Views\TestView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4F599429269B3929ED8968D7E2542774"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestTaskUWP.Views
{
    partial class TestView : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBox_Text(global::Windows.UI.Xaml.Controls.TextBox obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class TestView_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ITestView_Bindings
        {
            private global::TestTaskUWP.Views.TestView dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBox obj2;
            private global::Windows.UI.Xaml.Controls.TextBlock obj3;
            private global::Windows.UI.Xaml.Controls.Button obj4;
            private global::Windows.UI.Xaml.Controls.Button obj5;

            // Fields for each event bindings event handler.
            private global::Windows.UI.Xaml.RoutedEventHandler obj4Click;
            private global::Windows.UI.Xaml.RoutedEventHandler obj5Click;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2TextDisabled = false;
            private static bool isobj3TextDisabled = false;

            private TestView_obj1_BindingsTracking bindingsTracking;

            public TestView_obj1_Bindings()
            {
                this.bindingsTracking = new TestView_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 13 && columnNumber == 18)
                {
                    isobj2TextDisabled = true;
                }
                else if (lineNumber == 15 && columnNumber == 20)
                {
                    isobj3TextDisabled = true;
                }
                else if (lineNumber == 17 && columnNumber == 32)
                {
                    this.obj4.Click -= obj4Click;
                }
                else if (lineNumber == 18 && columnNumber == 32)
                {
                    this.obj5.Click -= obj5Click;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Views\TestView.xaml line 13
                        this.obj2 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        this.bindingsTracking.RegisterTwoWayListener_2(this.obj2);
                        break;
                    case 3: // Views\TestView.xaml line 15
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 4: // Views\TestView.xaml line 17
                        this.obj4 = (global::Windows.UI.Xaml.Controls.Button)target;
                        this.obj4Click = (global::System.Object p0, global::Windows.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.Transaction.Save();
                        };
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += obj4Click;
                        break;
                    case 5: // Views\TestView.xaml line 18
                        this.obj5 = (global::Windows.UI.Xaml.Controls.Button)target;
                        this.obj5Click = (global::System.Object p0, global::Windows.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.Transaction.Load();
                        };
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += obj5Click;
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

            // ITestView_Bindings

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
                    this.dataRoot = (global::TestTaskUWP.Views.TestView)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::TestTaskUWP.Views.TestView obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Transaction(obj.Transaction, phase);
                    }
                }
            }
            private void Update_Transaction(global::TestTaskUWP.ViewModels.TransactionVM obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_Transaction(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Transaction_Type_Transaction(obj.Type_Transaction, phase);
                    }
                }
            }
            private void Update_Transaction_Type_Transaction(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\TestView.xaml line 13
                    if (!isobj2TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj2, obj, null);
                    }
                    // Views\TestView.xaml line 15
                    if (!isobj3TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj3, obj, null);
                    }
                }
            }
            private void UpdateTwoWay_2_Text()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.Transaction != null)
                        {
                            this.dataRoot.Transaction.Type_Transaction = this.obj2.Text;
                        }
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class TestView_obj1_BindingsTracking
            {
                private global::System.WeakReference<TestView_obj1_Bindings> weakRefToBindingObj; 

                public TestView_obj1_BindingsTracking(TestView_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<TestView_obj1_Bindings>(obj);
                }

                public TestView_obj1_Bindings TryGetBindingObject()
                {
                    TestView_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_Transaction(null);
                }

                public void PropertyChanged_Transaction(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    TestView_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::TestTaskUWP.ViewModels.TransactionVM obj = sender as global::TestTaskUWP.ViewModels.TransactionVM;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_Transaction_Type_Transaction(obj.Type_Transaction, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Type_Transaction":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Transaction_Type_Transaction(obj.Type_Transaction, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::TestTaskUWP.ViewModels.TransactionVM cache_Transaction = null;
                public void UpdateChildListeners_Transaction(global::TestTaskUWP.ViewModels.TransactionVM obj)
                {
                    if (obj != cache_Transaction)
                    {
                        if (cache_Transaction != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_Transaction).PropertyChanged -= PropertyChanged_Transaction;
                            cache_Transaction = null;
                        }
                        if (obj != null)
                        {
                            cache_Transaction = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_Transaction;
                        }
                    }
                }
                public void RegisterTwoWayListener_2(global::Windows.UI.Xaml.Controls.TextBox sourceObject)
                {
                    sourceObject.LostFocus += (sender, e) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_2_Text();
                        }
                    };
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
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
            switch(connectionId)
            {
            case 1: // Views\TestView.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    TestView_obj1_Bindings bindings = new TestView_obj1_Bindings();
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

