using System;
using System.Media;

namespace Functions
{
    public class Music
    {
        SoundPlayer SongPlayer = new SoundPlayer();
        
        public void Track(string songno)
        {
            
            string CurrentSong = "";
            if (CurrentSong != songno)
            {
                SongPlayer.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + songno + ".wav";
                CurrentSong = songno;
                SongPlayer.Play();
                return;
                // "0" = Main Menu
                // "1" = Town -not implemented-
                // "2" = Battle -not implemented-
            }
            else
            {
                return;
            }
        }
    }
}
