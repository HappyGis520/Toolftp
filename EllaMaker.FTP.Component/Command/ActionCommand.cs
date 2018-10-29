using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace EllaMaker.FTP.Component.Command
{
    /// <summary>
    /// ActionCommand 的摘要说明
    /// 创建人：张天奇
    /// 创建时间：2018/9/11 星期二 下午 4:29:28
    /// </summary>
    public class ActionCommand<T> : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action<object, T> _action;

        public ActionCommand(Action<object, T> action)
        {
            _action = action;
        }

        public bool CanExecute(object parameter) { return true; }

        public void Execute(object parameter)
        {
            if (_action != null)
            {
                if (parameter is object[] parms)
                {
                    var arg = (T)Convert.ChangeType(parms[1], typeof(T));
                    _action(parms[0], arg);
                }
            }
        }
        public void Execute(object sender, object parameter)
        {
            if (_action != null)
            {
                var castParameter = (T)Convert.ChangeType(parameter, typeof(T));
                _action(sender, castParameter);
            }
        }
    }
}
