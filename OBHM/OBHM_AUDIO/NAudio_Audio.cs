using NAudio.Wave;

namespace OBHM.AUDIO
{
    public class NAudio_Audio : IAudio
    {
        public WaveOutEvent DeviceOut = new WaveOutEvent();
        public string Name => "NAudio";
        public void Init()
        {
            var waveOut = new WaveOutEvent();
        }
        public void LoadMusic(string path)
        {
            var file = new Mp3FileReader(path);
        }
        public void UnLoadMusic(string path)
        {

        }
        public void PlayMusic()
        {
            
        }
        public void StopMusic()
        {

        }
        public void UpdateMusic()
        {

        }
        public float GetMusicTime()
        {
            return 0.0f;
        }
        public float GetMusicTimePlayed()
        {
            return 0.0f;
        }
        public void SetMusicTime(float time)
        {

        }
    }
}
