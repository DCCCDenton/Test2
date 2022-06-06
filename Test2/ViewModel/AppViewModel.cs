using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Grid = System.Windows.Controls.Grid;

namespace Test2
{
    public class AppViewModel : INotifyPropertyChanged
    {
        IDialogService dialogService;

        private RelayCommand openXLSX;
        public RelayCommand OpenXLSX
        {
            get => openXLSX ??
                (openXLSX = new RelayCommand(obj =>
                {
                    try
                    {
                        if (dialogService.OpenFileDialog() == true)
                        {
                            Word_Interaction wordInt = new Word_Interaction();
                            wordInt.SetWordData(dialogService.FilePath);
                            wordInt.ConvertToPDF(dialogService.FilePath);   
                            dialogService.ShowMessage("Файл открыт");
                        }
                    }
                    catch (Exception ex)
                    {
                        dialogService.ShowMessage(ex.Message);
                    }
                }));
        }
   
                
        public AppViewModel(IDialogService dialogService)
        {
            this.dialogService = dialogService;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
