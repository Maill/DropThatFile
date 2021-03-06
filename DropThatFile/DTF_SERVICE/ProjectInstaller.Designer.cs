﻿namespace DTF_SERVICE
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.DTFServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.DTFServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            this.Logs = new System.Diagnostics.EventLog();
            ((System.ComponentModel.ISupportInitialize)(this.Logs)).BeginInit();
            // 
            // DTFServiceProcessInstaller
            // 
            this.DTFServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.DTFServiceProcessInstaller.Password = null;
            this.DTFServiceProcessInstaller.Username = null;
            // 
            // DTFServiceInstaller
            // 
            this.DTFServiceInstaller.DisplayName = "DTF Service";
            this.DTFServiceInstaller.ServiceName = "DTF Service";
            this.DTFServiceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.DTFServiceInstaller,
            this.DTFServiceProcessInstaller});
            ((System.ComponentModel.ISupportInitialize)(this.Logs)).EndInit();

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller DTFServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller DTFServiceInstaller;
        private System.Diagnostics.EventLog Logs;
    }
}