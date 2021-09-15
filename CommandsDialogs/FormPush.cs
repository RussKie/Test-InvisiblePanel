using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GitUI.CommandsDialogs
{
    public partial class FormPush : GitModuleForm
    {
        public bool ErrorOccurred { get; private set; }

        public FormPush()
        {
            InitializeComponent();

            //NewColumn.Width = DpiUtil.Scale(97);
            //PushColumn.Width = DpiUtil.Scale(36);
            //ForceColumn.Width = DpiUtil.Scale(101);
            //DeleteColumn.Width = DpiUtil.Scale(108);

            //InitializeComplete();
        }


        private void FormPushLoad(object sender, EventArgs e)
        {
            _NO_TRANSLATE_Remotes.Select();
        }

        private void ShowOptions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PushOptionsPanel.Visible = true;
            ShowOptions.Visible = false;
            SetFormSizeToFitAllItems();
        }

        private void SetFormSizeToFitAllItems()
        {
            if (Height < MinimumSize.Height + 50)
            {
                Height = MinimumSize.Height + 50;
            }
        }


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
