﻿#pragma checksum "C:\University\PersonalTrainer\Personal-Trainer_Runtime\PersonalTrainer-Client\Flows\Workout\WorkoutSummary.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B08A631A0E4EA747EF1EC39053B443B7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonalTrainer_Client.Flows.Workout
{
    partial class WorkoutSummary : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.UserStatistics = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 90 "..\..\..\..\Flows\Workout\WorkoutSummary.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.UserStatistics).Click += this.UserStatistics_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.OtherUsersStatistics = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 91 "..\..\..\..\Flows\Workout\WorkoutSummary.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.OtherUsersStatistics).Click += this.OtherUsersStatistics_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.MainDashboardReturn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 92 "..\..\..\..\Flows\Workout\WorkoutSummary.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.MainDashboardReturn).Click += this.MainDashboardReturn_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.Title = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.feedback_image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 6:
                {
                    this.CompareToStat = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.calories = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.sweat = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.heartRate = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.peak_heart_rate = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.Time = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.NumOfEx = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
