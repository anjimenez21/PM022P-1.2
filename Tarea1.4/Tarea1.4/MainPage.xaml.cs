using Microsoft.Maui.Controls;
using System;
using System.IO;
using System.Collections.ObjectModel;

using Tarea1._4.Modelos;

namespace Tarea1._4
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<ImagenModel> imagenesList = new ObservableCollection<ImagenModel>();
        public MainPage()
        {
            InitializeComponent();
            ImagenesListView.ItemsSource = imagenesList;
        }


        private async void TomarFoto_Clicked(object sender, EventArgs e)
        {
            var foto = await MediaPicker.CapturePhotoAsync();

            if (foto != null)
            {
                // Guardar la imagen en una ubicación física
                var rutaTemporal = foto.FullPath;
                var rutaImagen = $"Imagen_{DateTime.Now.ToString("yyyyMMddHHmmss")}.jpg";
                await MoverArchivoAsync(rutaTemporal, AppEnvironment.ImagenesPath, rutaImagen);
                //await foto.MoveAsync(AppEnvironment.ImagenesPath, rutaImagen);

                // Guardar la información en SQLite
                var nuevaImagen = new ImagenModel { RutaImagen = rutaImagen, Nombre = $"Imagen {imagenesList.Count + 1}" };
                imagenesList.Add(nuevaImagen);
                AppEnvironment.Database.Insert(nuevaImagen);
            }
        }

        private async Task MoverArchivoAsync(string rutaOrigen, string directorioDestino, string nombreDestino)
        {
            try
            {
                // Combinar el directorio de destino con el nombre del archivo
                var rutaDestino = Path.Combine(directorioDestino, nombreDestino);

                // Copiar el archivo
                using (var origenStream = new FileStream(rutaOrigen, FileMode.Open, FileAccess.Read))
                {
                    using (var destinoStream = new FileStream(rutaDestino, FileMode.Create, FileAccess.Write))
                    {
                        await origenStream.CopyToAsync(destinoStream);
                    }
                }

                // Opcional: Eliminar el archivo original si es necesario
                // File.Delete(rutaOrigen);
            }
            catch (Exception ex)
            {
                // Manejar errores
                Console.WriteLine($"Error al mover el archivo: {ex.Message}");
            }
        }

        private async void ImagenesListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var imagenSeleccionada = (ImagenModel)e.SelectedItem;

            // Abrir una nueva página para mostrar la imagen completa
            await Navigation.PushAsync(new ImagenCompletaPage(imagenSeleccionada.RutaImagen));

            // Deseleccionar el elemento en la lista
            ImagenesListView.SelectedItem = null;
        }

    }
}