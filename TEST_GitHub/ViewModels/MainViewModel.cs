using TEST_GitHub.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TEST_GitHub.ViewModels
{
    public class MainViewModel : BindableBase
    {
        #region Fields
        private Models.MainModel _mainModel;
        #endregion

        #region Constructors
        public MainViewModel()
        {
            _mainModel = new Models.MainModel();
            Initialize();
        }
        #endregion

        #region Methods
        #region Initialize Method 初期化
        private void Initialize()
        {
            // ここに初期化する内容を書く
        }
        #endregion
        #endregion

        #region Properties 
        #region Title Property タイトル
        public string Title => "Hello AutoCAD WPF!!!";
        #endregion
        #endregion

        #region Commands
        #region CloseCommand ウインドウを閉じるコマンド
        private bool _isCloseView;
        public bool IsCloseView {
            get { return _isCloseView; }
            set { SetProperty(ref _isCloseView, value); }
        }
        private void CloseExecute() { IsCloseView = true; }
        public ICommand CloseCommand => new DelegateCommand(CloseExecute);
        #endregion
        #endregion
    }
}
