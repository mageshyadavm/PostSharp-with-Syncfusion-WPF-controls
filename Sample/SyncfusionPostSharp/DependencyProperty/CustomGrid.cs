using PostSharp.Patterns.Model;
using PostSharp.Patterns.Xaml;
using Syncfusion.UI.Xaml.Grid;
using System.Windows;

namespace SyncfusionPostSharp
{
    public class CustomGrid : SfDataGrid
    {
        [DependencyProperty(ValidateValueMethod = "ValidateTextChanged")]
        public string CustomText { get; set; }

        [AttachedProperty]
        public static Attached<int> SecurityId { get; set; }
        public static void SetSecurityId(DependencyObject host, int value) => SecurityId.SetValue(host, value);

        private bool ValidateTextChanged(string value)
        {
            if (!string.IsNullOrEmpty(value))
                return true;

            return false;
        }
    }
}
