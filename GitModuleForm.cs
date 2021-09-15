using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

namespace GitUI
{
    // NOTE do not make this class abstract as it breaks the WinForms designer in VS

    /// <summary>Base <see cref="Form"/> that provides access to <see cref="GitModule"/> and <see cref="GitUICommands"/>.</summary>
    public class GitModuleForm : GitExtensionsForm
    {
        protected GitModuleForm()
        {
        }
    }
}
