﻿#pragma checksum "C:\University\PersonalTrainer\Personal-Trainer_Runtime\PersonalTrainer-Client\Flows\Workout\WorkoutDashboard.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CDB7C9D5178E0560E0524C232341A88B"
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
    partial class WorkoutDashboard : 
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
                    this.media = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 2:
                {
                    this.WorkoutDetails = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 44 "..\..\..\..\Flows\Workout\WorkoutDashboard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.WorkoutDetails).Click += this.WorkoutDetails_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.Finish = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 45 "..\..\..\..\Flows\Workout\WorkoutDashboard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Finish).Click += this.Finish_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.Next = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.NextEx = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.StartExercise = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 38 "..\..\..\..\Flows\Workout\WorkoutDashboard.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.StartExercise).Click += this.StartExercise_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.time = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.calories = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
