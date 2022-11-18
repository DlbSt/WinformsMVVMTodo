using Prism.Commands;
using Prism.Mvvm;
using System.ComponentModel;

namespace WinformsMVVMTodo
{
    public class MainFormViewModel : BindableBase
    {
        #region Properties
        private BindingList<string> todoList = new BindingList<string>();
        public BindingList<string> TodoList
        {
            get { return todoList; }
        }

        private string task;
        public string Task
        {
            get { return task; }
            set { SetProperty(ref task, value); }
        }

        private string selectedTask;
        public string SelectedTask
        {
            get { return selectedTask; }
            set { SetProperty(ref selectedTask, value); }
        }
        #endregion

        #region Commands
        public DelegateCommand OnAddCommand { get; set; }
        public DelegateCommand OnDeleteCommand { get; set; }
        #endregion

        #region Constructor       
        public MainFormViewModel()
        {
            #region Commands
            OnAddCommand = new DelegateCommand(() =>
            {
                TodoList.Add(Task);

                Task = string.Empty;

                OnAddCommand?.RaiseCanExecuteChanged();
                OnDeleteCommand?.RaiseCanExecuteChanged();
            }, () => Task?.Length > 0);
            OnDeleteCommand = new DelegateCommand(() =>
            {
                TodoList.Remove(SelectedTask);

                OnAddCommand?.RaiseCanExecuteChanged();
                OnDeleteCommand.RaiseCanExecuteChanged();
            }, () => TodoList?.Count > 0 && !string.IsNullOrEmpty(SelectedTask));
            #endregion

            PropertyChanged += (_, e) =>
            {
                if (e.PropertyName == nameof(SelectedTask))
                {
                    OnDeleteCommand?.RaiseCanExecuteChanged();
                }
                else if (e.PropertyName == nameof(Task))
                {
                    OnAddCommand?.RaiseCanExecuteChanged(); 
                }
            };
        } 
        #endregion
    }
}
