using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Bookcar.CustomControl
{
    public class CustomPin : Pin
    {
        public static readonly BindableProperty NameProperty;
        public static readonly BindableProperty SrcProperty;
        public string Name { get; set; }
        public string Src { get; set; }
    }
}
