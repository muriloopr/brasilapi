using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using brasilapi.Models;
using brasilapi.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace brasilapi.ViewModels
{
    public partial class CidadeViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Cidade> cidades;

        private ICommand getCidadesCommand { get; }

        public CidadeViewModel()
        {
            getCidadesCommand = new Command(getCidades);
        }

        public async void getCidades()
        {
            CidadeServices cidadeService = new CidadeServices();
            cidades = await cidadeService.getCidades();
        }
    }
}
