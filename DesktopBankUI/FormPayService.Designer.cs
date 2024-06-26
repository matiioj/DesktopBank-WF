﻿namespace DesktopBankUI
{
    partial class FormPayService
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
            menuPay = new MenuStrip();
            nUEVOPAGOToolStripMenuItem = new ToolStripMenuItem();
            rECARGASToolStripMenuItem = new ToolStripMenuItem();
            sUBEToolStripMenuItem = new ToolStripMenuItem();
            cELULARToolStripMenuItem = new ToolStripMenuItem();
            gboxPay = new GroupBox();
            btnAgip = new Button();
            btnMetrogas = new Button();
            btnEdesur = new Button();
            btnAysa = new Button();
            menuPay.SuspendLayout();
            gboxPay.SuspendLayout();
            SuspendLayout();
            // 
            // menuPay
            // 
            menuPay.ImageScalingSize = new Size(24, 24);
            menuPay.Items.AddRange(new ToolStripItem[] { nUEVOPAGOToolStripMenuItem, rECARGASToolStripMenuItem });
            menuPay.Location = new Point(0, 0);
            menuPay.Name = "menuPay";
            menuPay.Size = new Size(1096, 33);
            menuPay.TabIndex = 0;
            menuPay.Text = "menuPayService";
            // 
            // nUEVOPAGOToolStripMenuItem
            // 
            nUEVOPAGOToolStripMenuItem.Name = "nUEVOPAGOToolStripMenuItem";
            nUEVOPAGOToolStripMenuItem.Size = new Size(139, 29);
            nUEVOPAGOToolStripMenuItem.Text = "NUEVO PAGO";
            // 
            // rECARGASToolStripMenuItem
            // 
            rECARGASToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sUBEToolStripMenuItem, cELULARToolStripMenuItem });
            rECARGASToolStripMenuItem.Name = "rECARGASToolStripMenuItem";
            rECARGASToolStripMenuItem.Size = new Size(116, 29);
            rECARGASToolStripMenuItem.Text = "RECARGAS";
            // 
            // sUBEToolStripMenuItem
            // 
            sUBEToolStripMenuItem.Name = "sUBEToolStripMenuItem";
            sUBEToolStripMenuItem.Size = new Size(186, 34);
            sUBEToolStripMenuItem.Text = "SUBE";
            // 
            // cELULARToolStripMenuItem
            // 
            cELULARToolStripMenuItem.Name = "cELULARToolStripMenuItem";
            cELULARToolStripMenuItem.Size = new Size(186, 34);
            cELULARToolStripMenuItem.Text = "CELULAR";
            // 
            // gboxPay
            // 
            gboxPay.Controls.Add(btnAgip);
            gboxPay.Controls.Add(btnMetrogas);
            gboxPay.Controls.Add(btnEdesur);
            gboxPay.Controls.Add(btnAysa);
            gboxPay.Font = new Font("Cascadia Code Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            gboxPay.Location = new Point(146, 101);
            gboxPay.Name = "gboxPay";
            gboxPay.Size = new Size(920, 596);
            gboxPay.TabIndex = 1;
            gboxPay.TabStop = false;
            gboxPay.Text = "Pago de servicios";
            // 
            // btnAgip
            // 
            btnAgip.BackgroundImage = Properties.Resources.agip;
            btnAgip.BackgroundImageLayout = ImageLayout.Stretch;
            btnAgip.Location = new Point(499, 358);
            btnAgip.Name = "btnAgip";
            btnAgip.Size = new Size(269, 136);
            btnAgip.TabIndex = 3;
            btnAgip.UseVisualStyleBackColor = true;
            btnAgip.Click += btnAgip_Click;
            // 
            // btnMetrogas
            // 
            btnMetrogas.BackgroundImage = Properties.Resources.metrogas;
            btnMetrogas.BackgroundImageLayout = ImageLayout.Stretch;
            btnMetrogas.Location = new Point(129, 358);
            btnMetrogas.Name = "btnMetrogas";
            btnMetrogas.Size = new Size(269, 136);
            btnMetrogas.TabIndex = 2;
            btnMetrogas.UseVisualStyleBackColor = true;
            btnMetrogas.Click += btnMetrogas_Click;
            // 
            // btnEdesur
            // 
            btnEdesur.BackgroundImage = Properties.Resources.edesur;
            btnEdesur.BackgroundImageLayout = ImageLayout.Stretch;
            btnEdesur.Location = new Point(499, 131);
            btnEdesur.Name = "btnEdesur";
            btnEdesur.Size = new Size(269, 136);
            btnEdesur.TabIndex = 1;
            btnEdesur.UseVisualStyleBackColor = true;
            btnEdesur.Click += btnEdesur_Click;
            // 
            // btnAysa
            // 
            btnAysa.BackgroundImage = Properties.Resources.aysa;
            btnAysa.BackgroundImageLayout = ImageLayout.Stretch;
            btnAysa.Location = new Point(129, 131);
            btnAysa.Name = "btnAysa";
            btnAysa.Size = new Size(269, 136);
            btnAysa.TabIndex = 0;
            btnAysa.UseVisualStyleBackColor = true;
            btnAysa.Click += btnAysa_Click;
            // 
            // FormPayService
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(229, 239, 243);
            ClientSize = new Size(1096, 854);
            Controls.Add(gboxPay);
            Controls.Add(menuPay);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuPay;
            Name = "FormPayService";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PayService";
            menuPay.ResumeLayout(false);
            menuPay.PerformLayout();
            gboxPay.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuPay;
        private ToolStripMenuItem nUEVOPAGOToolStripMenuItem;
        private ToolStripMenuItem rECARGASToolStripMenuItem;
        private ToolStripMenuItem sUBEToolStripMenuItem;
        private ToolStripMenuItem cELULARToolStripMenuItem;
        private GroupBox gboxPay;
        private Button btnAgip;
        private Button btnMetrogas;
        private Button btnEdesur;
        private Button btnAysa;
    }
}