using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsMVVMTodo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            #region ViewModelInitialization
            var viewModel = new MainFormViewModel();
            DataContext = viewModel; 
            #endregion

            #region DataBindings
            button_Add.DataBindings.Add(new Binding(nameof(button_Add.Command), DataContext, nameof(viewModel.OnAddCommand), true));
            button_Delete.DataBindings.Add(new Binding(nameof(button_Delete.Command), DataContext, nameof(viewModel.OnDeleteCommand), true));
            listBox_Tasks.DataBindings.Add(new Binding(nameof(listBox_Tasks.DataSource), DataContext, nameof(viewModel.TodoList), true));
            textBox_Task.DataBindings.Add(new Binding(nameof(textBox_Task.Text), DataContext, nameof(viewModel.Task), true, DataSourceUpdateMode.OnPropertyChanged));
            listBox_Tasks.DataBindings.Add(new Binding(nameof(listBox_Tasks.SelectedValue), DataContext, nameof(viewModel.SelectedTask), true, DataSourceUpdateMode.OnPropertyChanged)); 
            #endregion
        }
    }
}
