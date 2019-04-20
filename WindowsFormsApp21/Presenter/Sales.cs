using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp21.View;

namespace WindowsFormsApp21.Presenter
{
    class Sales
    {
        IView views;


        void SalesPresenter(IView view)
        {
            this.views = view;
        }
        void ShowView()
        {
            views.ShowView();
        }
    }
}
