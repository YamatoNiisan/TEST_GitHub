using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TEST_GitHub.Mvvm
{
    public class DelegateCommand : ICommand
    {
        /// <summary>
        /// 引数も戻り値もないデリゲート
        /// </summary>
        private Action _execute;

        /// <summary>
        /// 引数がなしで、戻り値がbool型のデリゲート
        /// </summary>
        private Func<bool> _canExecute;

        public DelegateCommand(Action execute, Func<bool> canExecute)
        {
            this._execute = execute;
            this._canExecute = canExecute;
        }

        /// <summary>
        /// Action型の引数だけのコンストラクタ
        /// </summary>
        /// <param name="execute"></param>
        public DelegateCommand(Action execute) : this(execute, () => true)
        {

        }

        public event EventHandler CanExecuteChanged {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute();
        }
    }
}
