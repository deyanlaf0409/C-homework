using System;
using System.Windows.Forms;

namespace kursova
{
    public partial class MainForm : Form
    {
        // Declare UI components at the class level
        private System.Windows.Forms.ComboBox comboBoxTVs;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonTurnOn;
        private System.Windows.Forms.Button buttonTurnOff;
        private System.Windows.Forms.Button buttonChangeChannel;
        private System.Windows.Forms.NumericUpDown numericUpDownChannel;

        private void InitializeComponent()
        {
            // Initialize UI components
            this.comboBoxTVs = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonTurnOn = new System.Windows.Forms.Button();
            this.buttonTurnOff = new System.Windows.Forms.Button();
            this.buttonChangeChannel = new System.Windows.Forms.Button();
            this.numericUpDownChannel = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChannel)).BeginInit();
            this.SuspendLayout();

            // 
            // comboBoxTVs
            // 
            this.comboBoxTVs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTVs.FormattingEnabled = true;
            this.comboBoxTVs.Location = new System.Drawing.Point(12, 12);
            this.comboBoxTVs.Name = "comboBoxTVs";
            this.comboBoxTVs.Size = new System.Drawing.Size(200, 21);
            this.comboBoxTVs.TabIndex = 0;
            this.comboBoxTVs.SelectedIndexChanged += new System.EventHandler(this.comboBoxTVs_SelectedIndexChanged);

            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 46);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(97, 13);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "Status will appear...";

            // 
            // buttonTurnOn
            // 
            this.buttonTurnOn.Location = new System.Drawing.Point(12, 72);
            this.buttonTurnOn.Name = "buttonTurnOn";
            this.buttonTurnOn.Size = new System.Drawing.Size(75, 23);
            this.buttonTurnOn.TabIndex = 2;
            this.buttonTurnOn.Text = "Turn On";
            this.buttonTurnOn.UseVisualStyleBackColor = true;
            this.buttonTurnOn.Click += new System.EventHandler(this.buttonTurnOn_Click);

            // 
            // buttonTurnOff
            // 
            this.buttonTurnOff.Location = new System.Drawing.Point(137, 72);
            this.buttonTurnOff.Name = "buttonTurnOff";
            this.buttonTurnOff.Size = new System.Drawing.Size(75, 23);
            this.buttonTurnOff.TabIndex = 3;
            this.buttonTurnOff.Text = "Turn Off";
            this.buttonTurnOff.UseVisualStyleBackColor = true;
            this.buttonTurnOff.Click += new System.EventHandler(this.buttonTurnOff_Click);

            // 
            // buttonChangeChannel
            // 
            this.buttonChangeChannel.Location = new System.Drawing.Point(12, 136);
            this.buttonChangeChannel.Name = "buttonChangeChannel";
            this.buttonChangeChannel.Size = new System.Drawing.Size(200, 23);
            this.buttonChangeChannel.TabIndex = 4;
            this.buttonChangeChannel.Text = "Change Channel";
            this.buttonChangeChannel.UseVisualStyleBackColor = true;
            this.buttonChangeChannel.Click += new System.EventHandler(this.buttonChangeChannel_Click);

            // 
            // numericUpDownChannel
            // 
            this.numericUpDownChannel.Location = new System.Drawing.Point(12, 110);
            this.numericUpDownChannel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownChannel.Name = "numericUpDownChannel";
            this.numericUpDownChannel.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownChannel.TabIndex = 5;
            this.numericUpDownChannel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(224, 181);
            this.Controls.Add(this.numericUpDownChannel);
            this.Controls.Add(this.buttonChangeChannel);
            this.Controls.Add(this.buttonTurnOff);
            this.Controls.Add(this.buttonTurnOn);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.comboBoxTVs);
            this.Name = "MainForm";
            this.Text = "TV Remote";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChannel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Event handlers and other methods go here
    }
}
