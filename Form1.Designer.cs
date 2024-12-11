using System;
using System.Windows.Forms;

namespace kursova
{
    public partial class MainForm : Form
    {
        // TVs
        private TV sony;
        private TV panasonic;
        private TV samsung;

        // Currently selected TV
        private TV currentTV;

        public MainForm()
        {
            InitializeComponent();

            // Initialize TV objects
            sony = new TV("Sony");
            panasonic = new TV("Panasonic");
            samsung = new TV("Samsung");

            // Add TVs to ComboBox
            comboBoxTVs.Items.Add(sony.Brand);
            comboBoxTVs.Items.Add(panasonic.Brand);
            comboBoxTVs.Items.Add(samsung.Brand);

            // Set default selection
            comboBoxTVs.SelectedIndex = 0;

            // Set the initial current TV
            currentTV = sony;
        }

        private void comboBoxTVs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Switch current TV based on selection
            string selectedBrand = comboBoxTVs.SelectedItem.ToString();
            currentTV = selectedBrand switch
            {
                "Sony" => sony,
                "Panasonic" => panasonic,
                "Samsung" => samsung,
                _ => null
            };

            UpdateStatus();
        }

        private void buttonTurnOn_Click(object sender, EventArgs e)
        {
            currentTV?.TurnOn();
            UpdateStatus();
        }

        private void buttonTurnOff_Click(object sender, EventArgs e)
        {
            currentTV?.TurnOff();
            UpdateStatus();
        }

        private void buttonChangeChannel_Click(object sender, EventArgs e)
        {
            if (currentTV != null)
            {
                int channel = (int)numericUpDownChannel.Value;
                currentTV.ChangeChannel(channel);
                UpdateStatus();
            }
        }

        private void UpdateStatus()
        {
            if (currentTV != null)
            {
                labelStatus.Text = currentTV.IsOn
                    ? $"{currentTV.Brand} is ON, Channel: {currentTV.CurrentChannel}"
                    : $"{currentTV.Brand} is OFF";
            }
        }
    }

    public class TV
    {
        public string Brand { get; private set; }
        public bool IsOn { get; private set; }
        public int CurrentChannel { get; private set; }

        public TV(string brand)
        {
            Brand = brand;
            IsOn = false;
            CurrentChannel = 1;
        }

        public void TurnOn()
        {
            IsOn = true;
            MessageBox.Show($"{Brand} TV is now ON.");
        }

        public void TurnOff()
        {
            IsOn = false;
            MessageBox.Show($"{Brand} TV is now OFF.");
        }

        public void ChangeChannel(int channel)
        {
            if (IsOn)
            {
                CurrentChannel = channel;
                MessageBox.Show($"{Brand} TV switched to channel {channel}.");
            }
            else
            {
                MessageBox.Show($"{Brand} TV is OFF. Please turn it on first.");
            }
        }
    }
}
