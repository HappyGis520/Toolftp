using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EllaMaker.FTP.Component.Command;

namespace EllaMaker.FTP.Component
{
    /// <summary>
    /// SingleDropDownTextBoxBate.xaml 的交互逻辑
    /// </summary>
    public  class SingleDropDownTextBoxBate : Control
    {
        public SingleDropDownTextBoxBate()
        {
            base.DefaultStyleKey = typeof(SingleDropDownTextBoxBate);
            this.TextBox_TextChangedCmd = new ActionCommand<TextChangedEventArgs>(TextBox_TextChanged);
            this.TextBlock_MouseLeftButtonDownCmd = new ActionCommand<MouseButtonEventArgs>(TextBlock_MouseLeftButtonDown);
            this.TextBox_PreviewMouseLeftButtonDownCmd = new ActionCommand<MouseButtonEventArgs>(TextBox_PreviewMouseLeftButtonDown);
            this.TextBox_KeyDownCmd = new ActionCommand<KeyEventArgs>(TextBox_KeyDown);

        }

        public ActionCommand<TextChangedEventArgs> TextBox_TextChangedCmd { get; private set; }
        public ActionCommand<MouseButtonEventArgs> TextBlock_MouseLeftButtonDownCmd { get; private set; }
        public ActionCommand<MouseButtonEventArgs> TextBox_PreviewMouseLeftButtonDownCmd { get; private set; }
        public ActionCommand<KeyEventArgs> TextBox_KeyDownCmd { get; private set; }

        public static readonly DependencyProperty IsDropdownOpenedProperty = DependencyProperty.Register("IsDropdownOpened", typeof(bool), typeof(SingleDropDownTextBoxBate), new FrameworkPropertyMetadata(false));

        /// <summary>
        /// 下拉框是否已打开
        /// </summary>
        public bool IsDropdownOpened
        {
            get { return (bool)GetValue(IsDropdownOpenedProperty); }
            set { SetValue(IsDropdownOpenedProperty, value); }
        }
        public static readonly DependencyProperty DropItemsProperty = DependencyProperty.Register("DropItems", typeof(IList), typeof(SingleDropDownTextBoxBate), new FrameworkPropertyMetadata(null));

        /// <summary>
        /// 获取或设置下拉框中显示的项
        /// </summary>
        public IList DropItems
        {
            get { return (IList)GetValue(DropItemsProperty); }
            set { SetValue(DropItemsProperty, value); }
        }


        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(object), typeof(SingleDropDownTextBoxBate), new FrameworkPropertyMetadata(null));

        /// <summary>
        /// 获取或设置控件中显示的文本
        /// </summary>
        public object Text
        {
            get { return GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }


        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var item = sender as FrameworkElement;
            Text = item.DataContext;

            IsDropdownOpened = false;
            if (dropListBox != null) dropListBox.SelectedIndex = -1;
            e.Handled = true;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (dropListBox != null) dropListBox.SelectedIndex = -1;
            DropSelectedIndex = -1;
            IsDropdownOpened = true;
        }

       

        private void TextBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var element = sender as TextBox;
            element.Focus();
            element.SelectAll();
            e.Handled = true;
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

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (DropSelectedIndex != -1 && dropListBox.SelectedItem != null)
                {
                    var element = sender as TextBox;
                    Text =dropListBox.SelectedItem;
                    element.Focus();
                    element.SelectAll();
                    IsDropdownOpened = false;
                    if (dropListBox != null) dropListBox.SelectedIndex = -1;
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
    }
}
