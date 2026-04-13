using System;
using System.Media; // Required for SoundPlayer [cite: 45]

class AudioPlayer
{
    public void PlayGreeting()
    {
        try
        {
            [cite_start]// Plays the recorded .wav file [cite: 15, 16]
            [cite_start] SoundPlayer player = new SoundPlayer("greeting.wav"); [cite: 46]
            [cite_start] player.Play(); [cite: 46]
        }
        catch (Exception ex)
        {
            Console.WriteLine("Audio error: " + ex.Message);
        }
    }
}