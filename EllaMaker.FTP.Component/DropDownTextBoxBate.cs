using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using EllaMaker.FTP.Component.Command;

namespace EllaMaker.FTP.Component
{
    /// <summary>
    /// DropDownTextBoxBate.xaml 的交互逻辑
    /// </summary>
    public class DropDownTextBoxBate : Control
    {
        public DropDownTextBoxBate()
        {
            base.DefaultStyleKey = typeof(DropDownTextBoxBate);
            SelectedItems = new ObservableCollection<object>();
            this.TextBox_LostFocusCmd = new ActionCommand<RoutedEventArgs>(TextBox_LostFocus);
            this.TextBox_TextChangedCmd = new ActionCommand<TextChangedEventArgs>(TextBox_TextChanged); 
            this.TextBlock_MouseLeftButtonDownCmd = new ActionCommand<MouseButtonEventArgs>(TextBlock_MouseLeftButtonDown);
            this.TextBox_LoadedCmd = new ActionCommand<RoutedEventArgs>(TextBox_Loaded);
            this.deleteSelected_PreviewMouseLeftButtonUpCmd = new ActionCommand<MouseButtonEventArgs>(deleteSelected_PreviewMouseLeftButtonUp);
            this.TextBox_KeyDownCmd = new ActionCommand<KeyEventArgs>(TextBox_KeyDown);
            this.TextBlock_PreviewKeyUpCmd = new ActionCommand<KeyEventArgs>(TextBlock_PreviewKeyUp);
            this.WrapPanel_MouseLeftButtonDownCmd = new ActionCommand<MouseButtonEventArgs>(WrapPanel_MouseLeftButtonDown);
        }
        public static readonly DependencyProperty IsDropdownOpenedProperty = DependencyProperty.Register("IsDropdownOpened", typeof(bool), typeof(DropDownTextBoxBate), new FrameworkPropertyMetadata(false));

        /// <summary>
        /// 下拉框是否已打开
        /// </summary>
        public bool IsDropdownOpened
        {
            get { return (bool)GetValue(IsDropdownOpenedProperty); }
            set { SetValue(IsDropdownOpenedProperty, value); }
        }
        public static readonly DependencyProperty DropItemsProperty = DependencyProperty.Register("DropItems", typeof(IList), typeof(DropDownTextBoxBate), new FrameworkPropertyMetadata(null));

        /// <summary>
        /// 获取或设置下拉框中显示的项
        /// </summary>
        public IList DropItems
        {
            get { return (IList)GetValue(DropItemsProperty); }
            set { SetValue(DropItemsProperty, value); }
        }

        public static readonly DependencyProperty SelectedItemsProperty = DependencyProperty.Register("SelectedItems", typeof(ObservableCollection<object>), typeof(DropDownTextBoxBate), new FrameworkPropertyMetadata(null));

        /// <summary>
        /// 获取或设置下拉框中显示的项
        /// </summary>
        public ObservableCollection<object> SelectedItems
        {
            get { return (ObservableCollection<object>)GetValue(SelectedItemsProperty); }
            set { SetValue(SelectedItemsProperty, value); }
        }

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(DropDownTextBoxBate), new FrameworkPropertyMetadata(string.Empty));

        /// <summary>
        /// 获取或设置控件中显示的文本
        /// </summary>
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public ActionCommand<RoutedEventArgs> TextBox_LostFocusCmd { get; private set; }
        public ActionCommand<TextChangedEventArgs> TextBox_TextChangedCmd { get; private set; }
        public ActionCommand<MouseButtonEventArgs> TextBlock_MouseLeftButtonDownCmd { get; private set; }
        public ActionCommand<RoutedEventArgs> TextBox_LoadedCmd { get; private set; }
        public ActionCommand<MouseButtonEventArgs> deleteSelected_PreviewMouseLeftButtonUpCmd { get; private set; }
        public ActionCommand<KeyEventArgs> TextBox_KeyDownCmd { get; private set; }
        public ActionCommand<KeyEventArgs> TextBlock_PreviewKeyUpCmd { get; private set; }
        public ActionCommand<MouseButtonEventArgs> WrapPanel_MouseLeftButtonDownCmd { get; private set; }
        
        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            (sender as TextBox).Clear();
            if (dropListBox != null) dropListBox.SelectedIndex = -1;
            Text = string.Empty;
        }
        private int selectedIndex = 0;
        public int SelectedIndex
        {
            get => selectedIndex;
            set => selectedIndex = value;
        }


        private int insetIndex = 0;
        public int InsetIndex { get => insetIndex; set => insetIndex = value; }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var element = sender as FrameworkElement;
            SelectedIndex = GetElementIndexOfList(element);
            if (SelectedIndex != -1)
            {
                InsetIndex = SelectedIndex + Convert.ToInt32(element.Tag.ToString());

            }
            DropSelectedIndex = -1;
            if (dropListBox != null) dropListBox.SelectedIndex = -1;

            IsDropdownOpened = true;
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var item = sender as FrameworkElement;
            AddSelected(item.DataContext);
            e.Handled = true;

        }
        private void AddSelected(object obj)
        {
            Text = string.Empty;
            if (SelectedItems.Contains(obj))
            {
                int orgIndex = SelectedItems.IndexOf(obj);
                SelectedItems.Move(orgIndex, selectedIndex);
                return;
            }
            SelectedItems.Insert(InsetIndex, obj);
            InsetIndex++;
            IsDropdownOpened = false;
            Thread.Sleep(10);
            IsDropdownOpened = true;
            if (dropListBox != null) dropListBox.SelectedIndex = -1;
            DropSelectedIndex = -1;
        }
        private void TextBox_Loaded(object sender, RoutedEventArgs e)
        {
            (sender as TextBox).Focus();
            Text = string.Empty;
            SelectedIndex = GetElementIndexOfList((sender as TextBox));
        }
        private int GetElementIndexOfList(FrameworkElement element)
        {
            var elementCtl = element.TemplatedParent as ContentPresenter;
            if (elementCtl == null) return -1;
            return (VisualTreeHelper.GetParent(elementCtl) as Panel).Children.IndexOf(elementCtl);
        }

        private void deleteSelected_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var removeObj = (sender as FrameworkElement).Tag;
            RemoveItem(removeObj);
        }
        private void RemoveItem(object item)
        {
            if (item != null && SelectedItems.IndexOf(item) > -1)
            {
                SelectedItems.Remove(item);
                InsetIndex--;
                SelectedIndex = InsetIndex;
                WrapPanel_MouseLeftButtonDown(null, null);
            }
        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back)
            {
                var element = sender as TextBox;
                if (string.IsNullOrEmpty(element.Text) && element.DataContext != null)
                {
                    var win = Window.GetWindow(this);
                    var msg = "确认删除" + element.DataContext.ToString() + "吗";
                    var result = MessageBox.Show(win, msg, "删除确认", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (result == MessageBoxResult.Yes)
                    {
                        RemoveItem(element.DataContext);
                    }
                }
            }
            else if (e.Key == Key.Enter)
            {
                if (DropSelectedIndex != -1 && dropListBox.SelectedItem != null)
                {
                    AddSelected(dropListBox.SelectedItem);
                }
            }
            else if (e.Key == Key.Up)
            {

                SelectItem(DropSelectedIndex - 1);
            }
            else if (e.Key == Key.Down)
            {
                if (IsDropdownOpened)
                {

                    SelectItem(DropSelectedIndex + 1);
                }
            }
        }
        private ListBox dropListBox = null;
        private int dropSelectedIndex = -1;
        public int DropSelectedIndex
        {
            get { return dropSelectedIndex; }
            set
            {
                if (value > -2)
                {
                    dropSelectedIndex = value;
                }
            }
        }
        private void SelectItem(int index)
        {
            if (index < -1) index = -1;

            if (dropListBox == null)
            {
                var root = GetChildren(this, "root") as Panel;
                var pop = root.Children[1] as Popup;
                var border = pop.Child as Border;
                dropListBox = border.Child as ListBox;
            }
            if (dropListBox == null) return;
            int trueIndex = GetTrueIndex(index);
            if (trueIndex == -1) return;
            DropSelectedIndex = index;
            dropListBox.SelectedIndex = trueIndex;
            Console.WriteLine(dropListBox.SelectedIndex + dropListBox.SelectedItem.ToString());

        }
        private int GetTrueIndex(int index)
        {
            int totalIndex = index;
            var itemsPanel = GetChildren(dropListBox, "itemsPanel") as Panel;

            for (int i = 0; i < itemsPanel.Children.Count; i++)
            {
                if (itemsPanel.Children[i].RenderSize.Height == 0)
                    continue;
                else
                {
                    totalIndex--;
                    if (totalIndex < 0) return i;
                }
            }
            return -1;
        }

        private FrameworkElement GetChildren(FrameworkElement parent, string name)
        {
            int childCount = VisualTreeHelper.GetChildrenCount(parent);
            if (childCount == 0) return null;
            for (int i = 0; i < childCount; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i) as FrameworkElement;
                if (child == null) continue;
                if (child.Name == name)
                {
                    return child;
                }
                else
                {
                    child = GetChildren(child, name);
                    if (child != null) return child;
                }
            }
            return null;
        }
        private void WrapPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var element = GetChildren(this, "wrapPanel") as WrapPanel;
            int childCount = VisualTreeHelper.GetChildrenCount(element);
            if (childCount == 0) return;
            var c = VisualTreeHelper.GetChild(element.Children[childCount - 1], 0) as Panel;
            c.Children[1].Focus();
        }

        private void TextBlock_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TextBlock_MouseLeftButtonDown(sender, null);
            }
        }
    }
}
