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
        public void Reproducir(int i)
        {
            try
            {
                WindowsMediaPlayer sonido = new WindowsMediaPlayer();
                switch (i)
                {
                    case 1:
                        sonido.URL = @"audio.mp3";
                        break;
                    case 2:
                        sonido.URL = @"menu.mp3";
                        break;
                    case 3:
                        sonido.URL = @"enter.mp3";
                        break;
                    case 4:
                        sonido.URL = @"loser.mp3";
                        break;
                    case 5:
                        sonido.URL = @"topjugadores.mp3";
                        break;
                    case 6:
                        sonido.URL = @"salir.mp3";
                        break;
                }

               
            }catch(Exception ex)
            {
                Console.WriteLine("Error al reproducir el sonido " + ex.Message);
            }
        }
      
    }
}
