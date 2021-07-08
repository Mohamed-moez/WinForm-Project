namespace EasyProjet
{
    partial class Historique
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.GC_H = new DevExpress.XtraGrid.GridControl();
            this.GV_H = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id_emp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_H)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_H)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.GC_H);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1091, 412);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // GC_H
            // 
            this.GC_H.Location = new System.Drawing.Point(12, 12);
            this.GC_H.MainView = this.GV_H;
            this.GC_H.Name = "GC_H";
            this.GC_H.Size = new System.Drawing.Size(1067, 388);
            this.GC_H.TabIndex = 4;
            this.GC_H.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GV_H});
            this.GC_H.Click += new System.EventHandler(this.GC_H_Click);
            // 
            // GV_H
            // 
            this.GV_H.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id_emp,
            this.OV,
            this.FO,
            this.LT,
            this.FT,
            this.gridColumn1,
            this.gridColumn2});
            this.GV_H.GridControl = this.GC_H;
            this.GV_H.Name = "GV_H";
            // 
            // id_emp
            // 
            this.id_emp.Caption = "Code Employé";
            this.id_emp.FieldName = "idEmp";
            this.id_emp.MinWidth = 29;
            this.id_emp.Name = "id_emp";
            this.id_emp.OptionsColumn.AllowEdit = false;
            this.id_emp.OptionsColumn.AllowFocus = false;
            this.id_emp.Width = 107;
            // 
            // OV
            // 
            this.OV.Caption = "Ouverture session";
            this.OV.FieldName = "ouverture_Session";
            this.OV.MinWidth = 29;
            this.OV.Name = "OV";
            this.OV.OptionsColumn.AllowEdit = false;
            this.OV.OptionsColumn.AllowFocus = false;
            this.OV.Visible = true;
            this.OV.VisibleIndex = 0;
            this.OV.Width = 107;
            // 
            // FO
            // 
            this.FO.Caption = "Fermeture session";
            this.FO.FieldName = "fermeture_session";
            this.FO.MinWidth = 29;
            this.FO.Name = "FO";
            this.FO.OptionsColumn.AllowEdit = false;
            this.FO.OptionsColumn.AllowFocus = false;
            this.FO.Visible = true;
            this.FO.VisibleIndex = 1;
            this.FO.Width = 107;
            // 
            // LT
            // 
            this.LT.Caption = "Lancement de tache";
            this.LT.FieldName = "lance_tache";
            this.LT.MinWidth = 29;
            this.LT.Name = "LT";
            this.LT.OptionsColumn.AllowEdit = false;
            this.LT.OptionsColumn.AllowFocus = false;
            this.LT.Visible = true;
            this.LT.VisibleIndex = 2;
            this.LT.Width = 107;
            // 
            // FT
            // 
            this.FT.Caption = "Fermeture de tache";
            this.FT.FieldName = "ferme_tache";
            this.FT.MinWidth = 29;
            this.FT.Name = "FT";
            this.FT.OptionsColumn.AllowEdit = false;
            this.FT.OptionsColumn.AllowFocus = false;
            this.FT.Visible = true;
            this.FT.VisibleIndex = 3;
            this.FT.Width = 107;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tache";
            this.gridColumn1.FieldName = "tache";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Temp Passe (min)";
            this.gridColumn2.FieldName = "tempTache";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            this.gridColumn2.Width = 94;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1091, 412);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.GC_H;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1071, 392);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // Historique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 412);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Historique";
            this.Text = "Historique";
            this.Load += new System.EventHandler(this.Historique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GC_H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_H)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl GC_H;
        private DevExpress.XtraGrid.Views.Grid.GridView GV_H;
        private DevExpress.XtraGrid.Columns.GridColumn id_emp;
        private DevExpress.XtraGrid.Columns.GridColumn OV;
        private DevExpress.XtraGrid.Columns.GridColumn FO;
        private DevExpress.XtraGrid.Columns.GridColumn LT;
        private DevExpress.XtraGrid.Columns.GridColumn FT;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
    }
}