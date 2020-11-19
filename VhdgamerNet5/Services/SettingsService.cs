using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;
using Vhdgamer.ObjectModel;

namespace Vhdgamer.Services
{
    public class SettingsService
    {
        private readonly string settingsFilePath = Path.Combine(Application.StartupPath, "settings.json");

        private const string defaultVhdLocalPath = "vhds";
        private const string defaultVhdServerpath = @"\\games.noproblan.ch\storage\gamepack\vhds";
        private const string defaultStarterFilename = "startpath.txt";

        public Settings Settings { get; private set; }

        public SettingsService()
        {
            this.Load();
        }

        public void SetVhdLocalPath(string path)
        {
            this.Settings = this.Settings with { VhdLocalPath = path };
            this.Save();
        }

        public void SetVhdServerPath(string path)
        {
            this.Settings = this.Settings with { VhdServerPath = path };
            this.Save();
        }

        private void Load()
        {
            if (!File.Exists(this.settingsFilePath))
            {
                this.Settings = new(defaultVhdLocalPath, defaultVhdServerpath, defaultStarterFilename);
            }

            try
            {
                var content = File.ReadAllText(this.settingsFilePath);
                this.Settings = JsonConvert.DeserializeObject<Settings>(content);
            }
            catch
            {
                this.Settings = new(defaultVhdLocalPath, defaultVhdServerpath, defaultStarterFilename);
            }
        }

        private void Save()
        {
            var content = JsonConvert.SerializeObject(this.Settings);
            File.WriteAllText(this.settingsFilePath, content);
        }        
    }
}