// Updated by XamlIntelliSenseFileGenerator 14.03.2020 21:44:37
#pragma checksum "..\..\..\..\Controls\TimePickerControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D4A3064BFD644C11A1E93B230B8CD4709E1A039E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using OlibKey.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace OlibKey.Controls
{


    /// <summary>
    /// TimePickerControl
    /// </summary>
    public partial class TimePickerControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/OlibKey;component/controls/timepickercontrol.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\Controls\TimePickerControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.UserControl = ((OlibKey.Controls.TimePickerControl)(target));
                    return;
                case 2:
                    this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
                    return;
                case 3:
                    this.hour = ((System.Windows.Controls.Grid)(target));

#line 18 "..\..\..\..\Controls\TimePickerControl.xaml"
                    this.hour.KeyDown += new System.Windows.Input.KeyEventHandler(this.Down);

#line default
#line hidden
                    return;
                case 4:
                    this.mmTxt = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 5:
                    this.sep1 = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 6:
                    this.min = ((System.Windows.Controls.Grid)(target));

#line 27 "..\..\..\..\Controls\TimePickerControl.xaml"
                    this.min.KeyDown += new System.Windows.Input.KeyEventHandler(this.Down);

#line default
#line hidden
                    return;
                case 7:
                    this.ddTxt = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 8:
                    this.sep2 = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 9:
                    this.sec = ((System.Windows.Controls.Grid)(target));

#line 35 "..\..\..\..\Controls\TimePickerControl.xaml"
                    this.sec.KeyDown += new System.Windows.Input.KeyEventHandler(this.Down);

#line default
#line hidden
                    return;
                case 10:
                    this.yyTxt = ((System.Windows.Controls.TextBlock)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.UserControl UserControl;
        internal System.Windows.Controls.TextBox DateDisplay;
        internal System.Windows.Controls.Primitives.ToggleButton PopUpCalendarButton;
        internal System.Windows.Controls.Primitives.Popup CalendarPopup;
    }
}
