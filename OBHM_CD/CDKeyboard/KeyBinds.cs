using System.Text.Json;
using Raylib_cs;

namespace Creative_Dive.CDKeyboard
{
    public class Keybinds
    {
        public Keybinds(Dictionary<string, KeyboardKey> binds)
        {
            Key_Binds = binds;
        }

        public Dictionary<string, KeyboardKey> Key_Binds { get; set; }

        public KeyboardKey GetKey(string key)
        {
            Key_Binds.TryGetValue(key, out var result);
            return result;
        }
    }

    public class KeyBindsGestion
    {
        public KeyBindsGestion(string KbFilePath)
        {
            var KB = new Dictionary<string, KeyboardKey>();
            Key_Binds = new Keybinds(KB);
            KBFilePath = KbFilePath;
            WriteKBJson();
        }

        public Keybinds Key_Binds { get; set; }
        private string KBFilePath { get; }

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
            var test = new Dictionary<string, KeyboardKey>();
            var Keybinds = new Keybinds(test);

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
