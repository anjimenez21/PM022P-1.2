using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Layouts;
using System;
using System.Collections.ObjectModel;

namespace Tarea1._4
{
    public partial class ImagenCompletaPage : ContentPage
    {
        [Obsolete]
        public ImagenCompletaPage(string rutaImagen)
        {
            var imagen = new Image { Source = rutaImagen, Aspect = Aspect.AspectFit };
            Content = new StackLayout { Children = { imagen } };


            //var imagen = new Image
            //{
            //    Source = rutaImagen,
            //    Aspect = Aspect.AspectFit,
            //    VerticalOptions = LayoutOptions.FillAndExpand
            //};

            //var closeButton = new Button
            //{
            //    Text = "Cerrar",
            //    HorizontalOptions = LayoutOptions.End,
            //    VerticalOptions = LayoutOptions.Start
            //};

            //closeButton.Clicked += async (sender, args) =>
            //{
            //    await Navigation.PopAsync();
            //};

            //var stackLayout = new StackLayout
            //{
            //    Children = { imagen },
            //    BackgroundColor = Color.Black,
            //    VerticalOptions = LayoutOptions.FillAndExpand
            //};

            //var absoluteLayout = new AbsoluteLayout
            //{
            //    Children = { stackLayout, closeButton },
            //};

            //AbsoluteLayout.SetLayoutBounds(stackLayout, new Rectangle(0, 0, 1, 1));
            //AbsoluteLayout.SetLayoutFlags(stackLayout, AbsoluteLayoutFlags.All);

            //AbsoluteLayout.SetLayoutBounds(closeButton, new Rectangle(1, 0, 0.1, 0.1));
            //AbsoluteLayout.SetLayoutFlags(closeButton, AbsoluteLayoutFlags.PositionProportional);

            //Content = absoluteLayout;
        //}
        }

        private async void CerrarButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }

 }
