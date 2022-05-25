using MVVMFlyout.Models;
using MVVMFlyout.Services;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVMFlyout.ViewModels
{
    internal class StudentViewModel: BaseViewModel
    {
        public StudentStore studentStore => DependencyService.Get<StudentStore>();
        public Student student { get; set; }
        public ObservableCollection<string> Countries { get; }
        public ObservableCollection<string> Languages { get; }


        public string FirstName { 
            get { return student?.FirstName; } 
            set {
                if (student == null)
                    student = new Student();
                else if (student.FirstName == value)
                        return;
                    student.FirstName = value;
                OnPropertyChanged(nameof(student.FirstName));
                OnPropertyChanged(nameof(FullName));
            }
        }
        public string LastName
        {
            get { return student?.LastName; }
            set
            {
                if (student == null)
                    student = new Student();
                else if (student.LastName == value)
                    return;
                student.LastName = value;
                OnPropertyChanged(nameof(student.LastName));
                OnPropertyChanged(nameof(FullName));
            }
        }
        public string Country
        {
            get { return student?.Country; }
            set
            {
                if (!IsBusy)
                {
                    if (student == null)
                        student = new Student();
                    else if (student.Country == value)
                        return;
                    student.Country = value;
                    OnPropertyChanged(nameof(student.Country));
                }
            }
        }
        public string Language
        {
            get { return student?.Language; }
            set
            {
                if (student == null)
                    student = new Student();
                else if (student.Language == value)
                    return;
                student.Language = value;
                OnPropertyChanged(nameof(student.Language));
            }
        }

        public string FullName { 
            get 
            { 
                return student == null ? "Student Details" : $"{student.FirstName} {student.LastName}"; 
            } 
            set { } 
        }


        public Command SaveCommand { get; }
        public Command CancelCommand { get; }
        public StudentViewModel(): base()
        {

            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged += (_, __) => SaveCommand.ChangeCanExecute();
            Title = "Profile";
            Languages = new ObservableCollection<string>();
            Countries = new ObservableCollection<string>();
            LoadProfile();
            LoadLists();
        }

        private async void LoadLists()
        {
            await LoadLanguages();
            await LoadCountries();
        }
        private async void LoadProfile()
        {
            student = await studentStore.GetStudentAsync();
        }

        private async Task LoadCountries()
        {
            IsBusy = true;
/*            if (student != null)
                student.ViewModelIsLoading = true; */

            try
            {
                Countries.Clear();
                var items = await CountryStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Countries.Add(item.Name);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
/*                if (student != null)
                    student.ViewModelIsLoading = false;*/
            }
            OnPropertyChanged(nameof(student));
        }

        private async Task LoadLanguages()
        {
            IsBusy = true;

            try
            {
                Languages.Clear();
                var items = await LanguageStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Languages.Add(item.Name);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

#region Commands

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("AboutPage");
        }
        
        private bool ValidateSave()
        {
            return !(student == null)
                && !String.IsNullOrWhiteSpace(student.FirstName)
                && !String.IsNullOrWhiteSpace(student.LastName)
                && !String.IsNullOrWhiteSpace(student.Country)
                && !String.IsNullOrWhiteSpace(student.Language);
        }

        private async void OnSave()
        {

            await studentStore.AddStudent(student);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("AboutPage");
        }
        #endregion
    }
}
