namespace GitUI.CommandsDialogs
{
    public sealed partial class FormCreateBranch : GitExtensionsDialog
    {
        public bool CheckoutAfterCreation { get; set; } = true;
        public bool UserAbleToChangeRevision { get; set; } = true;
        public bool CouldBeOrphan { get; set; } = true;

        public FormCreateBranch()
        {
            InitializeComponent();

            // work-around the designer bug that can't add controls to FlowLayoutPanel
            ControlsPanel.Controls.Add(Ok);
            AcceptButton = Ok;

            //InitializeComplete();
        }
    }
}
