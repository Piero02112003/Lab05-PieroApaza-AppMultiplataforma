using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio03
{
    [PreserveSig(AllMembers = true)]
    [ContentProperty(nameof(Source))]
    public class ImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; }
        public IRunningObjectTable ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
                return null;
            var imageSource =ImageSource.FromResource(Source,
                typeof(ImageSourceExtension).GetTypeInfo().Assembly);
            return imageSource;
        }
    }
}
