﻿

#pragma checksum "C:\Users\Lynn\Documents\Visual Studio 2012\Projects\HeadFirstC#\Chapter11\TextEditor11\TextEditor11\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "00803D808BAFA2D39FBA5CD22B7D7B46"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TextEditor11
{
    partial class MainPage : global::TextEditor11.Common.LayoutAwarePage, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 22 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.openButton_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 25 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.saveButton_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 64 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBox)(target)).TextChanged += this.text_TextChanged;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 48 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.GoBack;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

