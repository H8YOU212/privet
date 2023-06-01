using OOO_debili.Models;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOO_debili.ViewModels
{
    public class StaffsWindowViewModel : ViewModelBase
    {
        private User user;

        public StaffsWindowViewModel(User user)
        {
            this.user = user;
        }
    }
}
