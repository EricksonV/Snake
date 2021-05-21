using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Snake_Dayana_Erickson.Clases.GameMenu
{
    class ClsSonido
    {
        public void Reproducir()
        {
            try
            {
                WindowsMediaPlayer sonido = new WindowsMediaPlayer();
                sonido.URL = @"audio.mp3";
               
            }catch(Exception ex)
            {
                Console.WriteLine("Error al reproducir el sonido " + ex.Message);
            }
        }
    }
}
