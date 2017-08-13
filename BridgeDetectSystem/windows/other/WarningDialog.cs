﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace BridgeDetectSystem
{
    public partial class WarningDialog : MetroFramework.Forms.MetroForm
    {
        public WarningDialog(string s)
        {
            InitializeComponent();
            label2.Text = s;
        }
        SoundPlayer sp = new SoundPlayer();
        private void WarningDialog_Load(object sender, EventArgs e)
        {
            
            sp.SoundLocation =GetPath();
            sp.PlayLooping();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sp.Stop();
            sp.Dispose();
            this.Close();
        }
        private static string GetPath()
        {          
           string Path = @"../../warningwave\WarningVoice.wav";          
           return Path;
        }
    }
}
