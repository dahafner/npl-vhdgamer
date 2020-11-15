namespace Vhdgamer.Common
{
    public class Settings
    {
        private const string defaultVhdLocalPath = "vhds";
        private const string defaultVhdServerpath = @"\\games.noproblan.ch\storage\gamepack\vhds";
        private const string defaultStarterFilename = "startpath.txt";

        private string vhdLocalPath;
        private string vhdServerPath;
        private string starterFilename;

        public string VhdLocalPath
        {
            get { return this.vhdLocalPath; }
            set
            {
                this.vhdLocalPath = value;
                this.Save();
            }
        }

        public string VhdServerPath
        {
            get { return this.vhdServerPath; }
            set
            {
                this.vhdServerPath = value;
                this.Save();
            }        
        }

        public string StarterFilename
        {
            get { return this.starterFilename; }
            set
            {
                this.starterFilename = value;
                this.Save();
            }
        }

        public Settings()
        {
            this.Load();
        }

        private void Load()
        {
            //if (string.IsNullOrEmpty(Settings.Default.VhdLocalPath))
            //{
            //    this.vhdLocalPath = defaultVhdLocalPath;
            //}
            //else
            //{
            //    this.vhdLocalPath = Properties.Settings.Default.VhdLocalPath;
            //}

            //if (string.IsNullOrEmpty(Properties.Settings.Default.VhdServerPath))
            //{
            //    this.vhdServerPath = defaultVhdServerpath;
            //}
            //else
            //{
            //    this.vhdServerPath = Properties.Settings.Default.VhdServerPath;
            //}

            //if (string.IsNullOrEmpty(Properties.Settings.Default.StarterFilename))
            //{
            //    this.starterFilename = defaultStarterFilename;
            //}
            //else
            //{
            //    this.starterFilename = Properties.Settings.Default.StarterFilename;
            //}
        }

        private void Save()
        {
            //Properties.Settings.Default.VhdLocalPath = this.VhdLocalPath;
            //Properties.Settings.Default.VhdServerPath = this.VhdServerPath;
            //Properties.Settings.Default.StarterFilename = this.StarterFilename;
            //Properties.Settings.Default.Save();
        }
    }
}