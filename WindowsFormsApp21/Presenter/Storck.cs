using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp21.View;

namespace WindowsFormsApp21.Presenter
{
    class Storck
    {
        IView iview;
        void SalesPresenter(IView view)
        {
            this.iview = view;
        }
        void ShowView()
        {
            iview.ShowView();
        }



    }
}
