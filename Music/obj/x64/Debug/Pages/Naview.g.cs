﻿#pragma checksum "C:\Users\nmqua\Desktop\New folder\Music\Pages\Naview.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F601112A963D781D872EDF0733A3103E"
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
    partial class Naview : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
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

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class Naview_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            INaview_Bindings
        {
            private global::Music.Pages.Naview dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj16;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj16TextDisabled = false;

            private Naview_obj1_BindingsTracking bindingsTracking;

            public Naview_obj1_Bindings()
            {
                this.bindingsTracking = new Naview_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 103 && columnNumber == 24)
                {
                    isobj16TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 16: // Pages\Naview.xaml line 103
                        this.obj16 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
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

            // INaview_Bindings

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
                    this.dataRoot = (global::Music.Pages.Naview)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Music.Pages.Naview obj, int phase)
            {
                this.Update_Windows_ApplicationModel_Package_Current(global::Windows.ApplicationModel.Package.Current, phase);
            }
            private void Update_Windows_ApplicationModel_Package_Current(global::Windows.ApplicationModel.Package obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Windows_ApplicationModel_Package_Current_DisplayName(obj.DisplayName, phase);
                    }
                }
            }
            private void Update_Windows_ApplicationModel_Package_Current_DisplayName(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\Naview.xaml line 103
                    if (!isobj16TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj16, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class Naview_obj1_BindingsTracking
            {
                private global::System.WeakReference<Naview_obj1_Bindings> weakRefToBindingObj; 

                public Naview_obj1_BindingsTracking(Naview_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<Naview_obj1_Bindings>(obj);
                }

                public Naview_obj1_Bindings TryGetBindingObject()
                {
                    Naview_obj1_Bindings bindingObject = null;
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
            switch(connectionId)
            {
            case 2: // Pages\Naview.xaml line 29
                {
                    this.NavView = (global::Windows.UI.Xaml.Controls.NavigationView)(target);
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.NavView).Loaded += this.NavView_Loaded;
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.NavView).ItemInvoked += this.NavView_ItemInvoked;
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.NavView).BackRequested += this.NavView_BackRequested;
                }
                break;
            case 3: // Pages\Naview.xaml line 84
                {
                    this.AppTitleBar = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4: // Pages\Naview.xaml line 127
                {
                    this.mediaPlayer = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                    ((global::Windows.UI.Xaml.Controls.MediaElement)this.mediaPlayer).MediaOpened += this.MediaPlayer_OnMediaOpened;
                    ((global::Windows.UI.Xaml.Controls.MediaElement)this.mediaPlayer).CurrentStateChanged += this.MediaPlayer_OnCurrentStateChanged;
                }
                break;
            case 5: // Pages\Naview.xaml line 160
                {
                    this.volume = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)this.volume).ValueChanged += this.Volume_OnValueChanged;
                }
                break;
            case 6: // Pages\Naview.xaml line 155
                {
                    this.MuteButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.MuteButton).Click += this.Mute_OnClick;
                }
                break;
            case 7: // Pages\Naview.xaml line 151
                {
                    this.timelineSlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)this.timelineSlider).ValueChanged += this.timelineSlider_ValueChanged;
                }
                break;
            case 8: // Pages\Naview.xaml line 152
                {
                    this.timeSlider = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // Pages\Naview.xaml line 131
                {
                    this.PreviousButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.PreviousButton).Click += this.PreviousButton_OnClick;
                }
                break;
            case 10: // Pages\Naview.xaml line 132
                {
                    this.StatusButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.StatusButton).Click += this.StatusButton_OnClick;
                }
                break;
            case 11: // Pages\Naview.xaml line 133
                {
                    this.NextButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.NextButton).Click += this.NextButton_OnClick;
                }
                break;
            case 12: // Pages\Naview.xaml line 134
                {
                    this.RefreshButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.RefreshButton).Click += this.RefreshButton_OnClick;
                }
                break;
            case 13: // Pages\Naview.xaml line 136
                {
                    this.ControlLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14: // Pages\Naview.xaml line 86
                {
                    this.LeftPaddingColumn = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 15: // Pages\Naview.xaml line 89
                {
                    this.BackButtonBackground = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                    ((global::Windows.UI.Xaml.Shapes.Rectangle)this.BackButtonBackground).Tapped += this.BackButtonBackground_OnTapped;
                }
                break;
            case 17: // Pages\Naview.xaml line 39
                {
                    this.MainPagesHeader = (global::Windows.UI.Xaml.Controls.NavigationViewItemHeader)(target);
                }
                break;
            case 18: // Pages\Naview.xaml line 59
                {
                    this.Register = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 19: // Pages\Naview.xaml line 60
                {
                    this.Login = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 20: // Pages\Naview.xaml line 61
                {
                    this.myInfo = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 21: // Pages\Naview.xaml line 74
                {
                    this.NavViewSearchBox = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                }
                break;
            case 22: // Pages\Naview.xaml line 78
                {
                    this.ContentFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                    ((global::Windows.UI.Xaml.Controls.Frame)this.ContentFrame).NavigationFailed += this.ContentFrame_NavigationFailed;
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
            switch(connectionId)
            {
            case 1: // Pages\Naview.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    Naview_obj1_Bindings bindings = new Naview_obj1_Bindings();
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

