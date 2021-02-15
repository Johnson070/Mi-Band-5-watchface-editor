using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiBand5WatchFaces
{
    public partial class WatchfaceStateEditor : Form
    {
        public StateWatchface state;
        public bool save;

        bool notChange = true;
        WatchFaceLibrary watch;
        VisualRender render;

        public WatchfaceStateEditor(StateWatchface state,WatchFaceLibrary watch)
        {
            InitializeComponent();
            this.state = DeepCopy(state);
            this.watch = watch;
            groupBox1.Enabled = !state.notGen;
            notGenState.Checked = state.notGen;
            FillValues(state);
            Render(state);
        }

        public static T DeepCopy<T>(T other)
        {
            if (other == null) return default(T);

            string clone = JsonConvert.SerializeObject(other);
            return JsonConvert.DeserializeObject<T>(clone);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            save = true;
            this.Close();
        }

        private void FillValues(StateWatchface state_new)
        {
            TimeState.Value = state_new.Time;
            AlarmTimeState.Value = state_new.alarm;
            TimeZoneState.Value = state_new.TimeZone;
            StepsState.Value = state_new.Steps;
            CaloriesState.Value = state_new.Calories;
            DistanceState.Value = state_new.Distance;
            PulseState.Value = state_new.Pulse;
            PAIState.Value = state_new.PAIIndex;
            BatteryState.Value = state_new.BatteryLevel;
            HumidityState.Value = state_new.Humidity;
            WeatherState.SelectedIndex = state_new.CurrentWeather;
            CurrTempState.Value = state_new.CurrentTemperature;
            DayTempState.Value = state_new.DayTemperature;
            NightTempState.Value = state_new.NightTemperature;
            AirQualState.Value = state_new.AirQuality;
            UVIndexState.Value = state_new.UVIndex;
            WindState.Value = state_new.Wind;
            BluetoothState.Checked = !state_new.Bluetooth;
            LockState.Checked = !state_new.Unlocked;
            DoNotSState.Checked = state_new.DoNotDisturb;
            AlarmSetState.Checked = state_new.DoNotDisturb;
            NoTimeZoneState.Checked = state_new.NoTimeZone;
            if (state_new.MiKm) KilometersState.Checked = true;
            else MilesState.Checked = true;
        }

        private void FillState()
        {
            state.Time = TimeState.Value;
            state.alarm = AlarmTimeState.Value;
            state.TimeZone = TimeZoneState.Value;
            state.Steps = StepsState.Value;
            state.Calories = CaloriesState.Value;
            state.Distance = DistanceState.Value;
            state.Pulse = PulseState.Value;
            state.PAIIndex = PAIState.Value;
            state.BatteryLevel = BatteryState.Value;
            state.Humidity = HumidityState.Value;
            state.CurrentWeather = WeatherState.SelectedIndex;
            state.CurrentTemperature = (int)CurrTempState.Value;
            state.DayTemperature = (int)DayTempState.Value;
            state.NightTemperature = (int)NightTempState.Value;
            state.AirQuality = (int)AirQualState.Value;
            state.UVIndex = (int)UVIndexState.Value;
            state.Wind = (int)WindState.Value;
            state.Bluetooth = !BluetoothState.Checked;
            state.Unlocked = !LockState.Checked;
            state.DoNotDisturb = DoNotSState.Checked;
            state.AlarmIsSet = AlarmSetState.Checked;
            state.NoTimeZone = NoTimeZoneState.Checked;
            if (KilometersState.Checked) state.MiKm = true;
            else state.MiKm = false;
        }

        private void notGenState_CheckedChanged(object sender, EventArgs e)
        {
            state.notGen = notGenState.Checked;
            groupBox1.Enabled = !state.notGen;
        }

        private void RandomFillButton_Click(object sender, EventArgs e)
        {
            state = new StateWatchface() { notGen = state.notGen };
            notChange = false;
            FillValues(state);
            notChange = true;
            Render(state);
        }

        private void ChangeValue(object sender, EventArgs e)
        {
            if (notChange)
            {
                FillState();
                Render(state);
            }
        }

        public void Render(StateWatchface state = null)
        {
            render = new VisualRender(watch, state);
            ImagePic.BackgroundImage = render.GenWatchface();
        }

        private void WatchfaceStateEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (save == false && MessageBox.Show("Do you want to get out without saving?", "Don't Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                save = true;
            }
        }
    }
}
