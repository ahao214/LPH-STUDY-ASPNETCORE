using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace PowerPoint4.PresetUI
{
    public class FeedBackButton
    {
        public Type PagesWindow { get; set; }

        protected override void OnClick()
        {
            base.OnClick();
            Window win = Activator.CreateInstance(this.PagesWindow) as Window;
            if (win != null)
            {
                win.Show();
            }

        }


    }
}
