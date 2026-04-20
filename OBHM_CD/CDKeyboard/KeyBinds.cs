using Raylib_cs;
using System.Buffers.Text;
using System.Net;
using System.Text.Json;

namespace Creative_Dive.CDKeyboard
{
    public class Keybinds
    {
        public Dictionary<string, KeyboardKey> Key_Binds {  get; set; }

        public Keybinds(Dictionary<string, KeyboardKey> binds)
        {
            Key_Binds = binds;
        }

        public KeyboardKey GetKey(string key)
        {
            Key_Binds.TryGetValue(key, out KeyboardKey result);
            return result;
        }
    }

    public class KeyBindsGestion
    {
        public Keybinds Key_Binds { get; set; }
        private string KBFilePath { get; set; }
        public KeyBindsGestion(string KbFilePath) 
        {
            Dictionary<string, KeyboardKey> KB = new Dictionary<string, KeyboardKey>();
            Key_Binds = new Keybinds(KB);
            KBFilePath = KbFilePath;
            WriteKBJson();
        }

        public void CreateBaseKB(Dictionary<string, KeyboardKey> BaseKB)
        {
            Key_Binds.Key_Binds = BaseKB;
            WriteKBJson();
        }

        public void NewKB(Dictionary<string, KeyboardKey> NewKB)
        {
            Key_Binds.Key_Binds = NewKB;
            WriteKBJson();
        }

        public void GetBinds(string FilePath)
        {
            Dictionary<string, KeyboardKey> test = new();
            Keybinds Keybinds = new Keybinds(test);

            string filecontent = File.ReadAllText(FilePath);
            Keybinds = JsonSerializer.Deserialize<Keybinds>(filecontent);

            Key_Binds = Keybinds;
        }

        private void WriteKBJson()
        {
            File.WriteAllText(KBFilePath, JsonSerializer.Serialize(Key_Binds));
        }
    }
}
