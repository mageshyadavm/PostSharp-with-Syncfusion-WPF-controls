using PostSharp.Patterns.Xaml;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace SyncfusionPostSharp
{
    public class EmployeeViewModel
    {
        private ObservableCollection<Employee> employees;

        public ObservableCollection<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }

        public EmployeeViewModel()
        {
            Employees = new ObservableCollection<Employee>();
            Employees.Add(new Employee("Mark", 10000, 1000));
            Employees.Add(new Employee("Adam", 20000, 2000));
            Employees.Add(new Employee("Michael", 30000, 3000));
            Employees.Add(new Employee("Johnson", 40000, 4000));
            Employees.Add(new Employee("Gayle", 50000, 5000));
            Employees.Add(new Employee("Peter", 60000, 6000));
        }

        [Command(ExecuteMethod = nameof(ExecuteGridWindowLoaded), CanExecuteMethod = nameof(CanExecuteGridWindowLoaded))]
        public ICommand GridWindowLoadedCommand { get; set; }

        private bool CanExecuteGridWindowLoaded()
        {
            return true;
        }

        private void ExecuteGridWindowLoaded()
        {
            MessageBox.Show("GridWindowLoaded command executed");
        }

    }
}
