using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TEST_GitHub.Mvvm
{
    /// <summary>
    /// ViewModelからウィンドウを閉じる添付ビヘイビア
    /// </summary>
    /// http://sourcechord.hatenablog.com/entry/2014/04/05/225250
    public class CloseWindowAttachedBehavior
    {
        public static bool GetClose(DependencyObject obj)
        {
            return (bool)obj.GetValue(CloseProperty);
        }
        public static void SetClose(DependencyObject obj, bool value)
        {
            obj.SetValue(CloseProperty, value);
        }
        // Using a DependencyProperty as the backing store for Close.  This enables animation, styling, binding, etc...
        // DependencyPropertyをCloseのバッキングストアとして使用します。
        // これにより、アニメーション、スタイリング、バインディングなどが可能になります...
        public static readonly DependencyProperty CloseProperty =
            DependencyProperty.RegisterAttached("Close", typeof(bool), typeof(CloseWindowAttachedBehavior), new PropertyMetadata(false, OnCloseChanged));

        private static void OnCloseChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var win = d as Window;
            if (win == null)
            {
                // Window以外のコントロールにこの添付ビヘイビアが付けられていた場合は、
                // コントロールの属しているWindowを取得
                win = Window.GetWindow(d);
            }

            if (GetClose(d))
                win.Close();
        }
    }
}
