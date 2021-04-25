using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MiBand5WatchFaces.Forms
{
    public partial class SettingsForm : Form
    {
        ComponentResourceManager res = new ComponentResourceManager(typeof(Resources.Resource1));

        public SettingsForm()
        {
            InitializeComponent();
            if (Directory.Exists("WatchFace") == false || File.Exists("WatchFace\\WatchFace.exe.config") == false)
            {
                MessageBox.Show(res.GetString("ConfigNotFound"), res.GetString("Error"), MessageBoxButtons.OK,MessageBoxIcon.Warning);
                this.Close();
            }

            ExeConfigurationFileMap configMap = new ExeConfigurationFileMap();
            configMap.ExeConfigFilename = "WatchFace\\WatchFace.exe.config";
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);
            
            PaletteModeCheckBox.Checked = config.AppSettings.Settings["UsePaletteMode"].Value == "0" ? false : true;
            EnglishRadioButton.Checked = config.AppSettings.Settings["WeekDaysLanguage"].Value == "0" ? true : false;
            SimpleChineseRadioButton.Checked = config.AppSettings.Settings["WeekDaysLanguage"].Value == "1" ? true : false;
            ChineseRadioButton.Checked = config.AppSettings.Settings["WeekDaysLanguage"].Value == "2" ? true : false;
            PreviewSpeedTrack.Value = Convert.ToInt32(config.AppSettings.Settings["PreviewSpeed"].Value);
            ForceImageCompressorCheck.Checked = config.AppSettings.Settings["ForceImageCompressor"].Value == "0" ? false : true;
            label1.Text = String.Format("Preview speed: {0} ms", PreviewSpeedTrack.Value);

            config.Save();
        }

        private void PreviewSpeedTrack_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = String.Format("Preview speed: {0} ms", PreviewSpeedTrack.Value);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("WatchFace") == false || File.Exists("WatchFace\\WatchFace.exe.config") == false)
            {
                MessageBox.Show(res.GetString("ConfigNotFound"), res.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else
            {
                ExeConfigurationFileMap configMap = new ExeConfigurationFileMap();
                configMap.ExeConfigFilename = "WatchFace\\WatchFace.exe.config";
                Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);

                config.AppSettings.Settings["UsePaletteMode"].Value = PaletteModeCheckBox.Checked == true ? "1" : "0";
                if (EnglishRadioButton.Checked) config.AppSettings.Settings["WeekDaysLanguage"].Value = "0";
                if (SimpleChineseRadioButton.Checked) config.AppSettings.Settings["WeekDaysLanguage"].Value = "1";
                if (ChineseRadioButton.Checked) config.AppSettings.Settings["WeekDaysLanguage"].Value = "2";
                config.AppSettings.Settings["PreviewSpeed"].Value = $"{PreviewSpeedTrack.Value}";
                config.AppSettings.Settings["ForceImageCompressor"].Value = ForceImageCompressorCheck.Checked == true ? "1" : "0";

                config.Save();

                configMap = new ExeConfigurationFileMap();
                configMap.ExeConfigFilename = "WatchFace6\\WatchFace.exe.config";
                config = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);

                config.AppSettings.Settings["UsePaletteMode"].Value = PaletteModeCheckBox.Checked == true ? "1" : "0";
                if (EnglishRadioButton.Checked) config.AppSettings.Settings["WeekDaysLanguage"].Value = "0";
                if (SimpleChineseRadioButton.Checked) config.AppSettings.Settings["WeekDaysLanguage"].Value = "1";
                if (ChineseRadioButton.Checked) config.AppSettings.Settings["WeekDaysLanguage"].Value = "2";
                config.AppSettings.Settings["PreviewSpeed"].Value = $"{PreviewSpeedTrack.Value}";
                config.AppSettings.Settings["ForceImageCompressor"].Value = ForceImageCompressorCheck.Checked == true ? "1" : "0";
                //config.AppSettings.Settings["serialKey"].Value = "5B54509BAD-3641238950-C922C0BC46-355BDA67CD";

                config.Save();

                this.Close();
            }
        }
    }
}
