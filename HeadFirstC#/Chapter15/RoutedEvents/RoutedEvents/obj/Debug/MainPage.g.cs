﻿

#pragma checksum "C:\Users\Lynn\Documents\Visual Studio 2012\Projects\HeadFirstC#\Chapter15\RoutedEvents\RoutedEvents\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "67FF1D714B6B1D765D469B4A3AB85525"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RoutedEvents
{
    partial class MainPage : global::RoutedEvents.Common.LayoutAwarePage, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 46 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).PointerPressed += this.StackPanel_PointerPressed;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 66 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.UpdateHitTestButton;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 48 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).PointerPressed += this.Border_PointerPressed;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 49 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).PointerPressed += this.Grid_PointerPressed;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 51 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).PointerPressed += this.Ellipse_PointerPressed;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 53 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).PointerPressed += this.Rectangle_PointerPressed;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

