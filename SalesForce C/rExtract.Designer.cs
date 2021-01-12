namespace Extract
{
    partial class rExtract : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public rExtract()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Asyst = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.button1 = this.Factory.CreateRibbonButton();
            this.button2 = this.Factory.CreateRibbonButton();
            this.button3 = this.Factory.CreateRibbonButton();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.Asyst.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Asyst
            // 
            this.Asyst.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.Asyst.Groups.Add(this.group1);
            this.Asyst.Label = "iKEP";
            this.Asyst.Name = "Asyst";
            // 
            // group1
            // 
            this.group1.Items.Add(this.button1);
            this.group1.Items.Add(this.button2);
            this.group1.Items.Add(this.separator1);
            this.group1.Items.Add(this.button3);
            this.group1.Label = "iKEP DT SalesForce";
            this.group1.Name = "group1";
            // 
            // button1
            // 
            this.button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button1.Image = global::Extract.Properties.Resources.liste_fw;
            this.button1.Label = "Saisie PM";
            this.button1.Name = "button1";
            this.button1.ShowImage = true;
            this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button2.Image = global::Extract.Properties.Resources.ExportSF_fw;
            this.button2.Label = "Export SalesForce";
            this.button2.Name = "button2";
            this.button2.ShowImage = true;
            // 
            // button3
            // 
            this.button3.Image = global::Extract.Properties.Resources.bControlListe_fw;
            this.button3.Label = "Vérif Traitement";
            this.button3.Name = "button3";
            this.button3.ShowImage = true;
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // rExtract
            // 
            this.Name = "rExtract";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.Asyst);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.Asyst.ResumeLayout(false);
            this.Asyst.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab Asyst;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button3;
    }

    partial class ThisRibbonCollection
    {
        internal rExtract Ribbon1
        {
            get { return this.GetRibbon<rExtract>(); }
        }
    }
}
