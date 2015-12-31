﻿namespace BenMAP
{
    partial class EffectCoefficients
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpCancelOK = new System.Windows.Forms.GroupBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBetaParameter1 = new System.Windows.Forms.TextBox();
            this.lblBetaParameter1 = new System.Windows.Forms.Label();
            this.txtBetaParameter2 = new System.Windows.Forms.TextBox();
            this.lblBetaParameter2 = new System.Windows.Forms.Label();
            this.txtBconstantValue = new System.Windows.Forms.TextBox();
            this.txtAconstantValue = new System.Windows.Forms.TextBox();
            this.txtCconstantValue = new System.Windows.Forms.TextBox();
            this.lblConstantValue = new System.Windows.Forms.Label();
            this.lblConstantDescription = new System.Windows.Forms.Label();
            this.txtAconstantDescription = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.txtCconstantDescription = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtBconstantDescription = new System.Windows.Forms.TextBox();
            this.txtBeta = new System.Windows.Forms.TextBox();
            this.cboBetaDistribution = new System.Windows.Forms.ComboBox();
            this.lblBetaDisribution = new System.Windows.Forms.Label();
            this.lblBeta = new System.Windows.Forms.Label();
            this.showForSeasonal = new System.Windows.Forms.Panel();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.lblSeason = new System.Windows.Forms.Label();
            this.txtSeason = new System.Windows.Forms.TextBox();
            this.editVarBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVariable = new System.Windows.Forms.Label();
            this.lblModSpec = new System.Windows.Forms.Label();
            this.txtModelSpec = new System.Windows.Forms.TextBox();
            this.lblPollutant = new System.Windows.Forms.Label();
            this.txtPollutant = new System.Windows.Forms.TextBox();
            this.lblSeasMetric = new System.Windows.Forms.Label();
            this.txtSeasMetric = new System.Windows.Forms.TextBox();
            this.txtVariable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSeason = new System.Windows.Forms.ComboBox();
            this.grpCancelOK.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.showForSeasonal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(216, 21);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 27);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(133, 21);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpCancelOK
            // 
            this.grpCancelOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCancelOK.Controls.Add(this.nextBtn);
            this.grpCancelOK.Controls.Add(this.prevBtn);
            this.grpCancelOK.Controls.Add(this.btnOK);
            this.grpCancelOK.Controls.Add(this.btnCancel);
            this.grpCancelOK.Location = new System.Drawing.Point(0, 390);
            this.grpCancelOK.Name = "grpCancelOK";
            this.grpCancelOK.Size = new System.Drawing.Size(425, 55);
            this.grpCancelOK.TabIndex = 26;
            this.grpCancelOK.TabStop = false;
            // 
            // nextBtn
            // 
            this.nextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextBtn.Location = new System.Drawing.Point(345, 21);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 27);
            this.nextBtn.TabIndex = 3;
            this.nextBtn.Text = "Next >";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.prevBtn.Location = new System.Drawing.Point(5, 21);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(75, 27);
            this.prevBtn.TabIndex = 2;
            this.prevBtn.Text = "< Previous";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtBconstantValue);
            this.panel1.Controls.Add(this.txtAconstantValue);
            this.panel1.Controls.Add(this.txtCconstantValue);
            this.panel1.Controls.Add(this.lblConstantValue);
            this.panel1.Controls.Add(this.lblConstantDescription);
            this.panel1.Controls.Add(this.txtAconstantDescription);
            this.panel1.Controls.Add(this.lblC);
            this.panel1.Controls.Add(this.lblA);
            this.panel1.Controls.Add(this.txtCconstantDescription);
            this.panel1.Controls.Add(this.lblB);
            this.panel1.Controls.Add(this.txtBconstantDescription);
            this.panel1.Controls.Add(this.txtBeta);
            this.panel1.Controls.Add(this.cboBetaDistribution);
            this.panel1.Controls.Add(this.lblBetaDisribution);
            this.panel1.Controls.Add(this.lblBeta);
            this.panel1.Controls.Add(this.showForSeasonal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 242);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.txtBetaParameter1);
            this.panel2.Controls.Add(this.lblBetaParameter1);
            this.panel2.Controls.Add(this.txtBetaParameter2);
            this.panel2.Controls.Add(this.lblBetaParameter2);
            this.panel2.Location = new System.Drawing.Point(0, 93);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 43);
            this.panel2.TabIndex = 51;
            // 
            // txtBetaParameter1
            // 
            this.txtBetaParameter1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBetaParameter1.Location = new System.Drawing.Point(61, 18);
            this.txtBetaParameter1.Name = "txtBetaParameter1";
            this.txtBetaParameter1.Size = new System.Drawing.Size(138, 22);
            this.txtBetaParameter1.TabIndex = 32;
            this.txtBetaParameter1.Text = "0";
            // 
            // lblBetaParameter1
            // 
            this.lblBetaParameter1.AutoSize = true;
            this.lblBetaParameter1.Location = new System.Drawing.Point(59, 2);
            this.lblBetaParameter1.Name = "lblBetaParameter1";
            this.lblBetaParameter1.Size = new System.Drawing.Size(100, 14);
            this.lblBetaParameter1.TabIndex = 28;
            this.lblBetaParameter1.Text = "Beta Parameter1:";
            // 
            // txtBetaParameter2
            // 
            this.txtBetaParameter2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBetaParameter2.Location = new System.Drawing.Point(211, 17);
            this.txtBetaParameter2.Name = "txtBetaParameter2";
            this.txtBetaParameter2.Size = new System.Drawing.Size(138, 22);
            this.txtBetaParameter2.TabIndex = 44;
            this.txtBetaParameter2.Text = "0";
            // 
            // lblBetaParameter2
            // 
            this.lblBetaParameter2.AutoSize = true;
            this.lblBetaParameter2.Location = new System.Drawing.Point(209, 1);
            this.lblBetaParameter2.Name = "lblBetaParameter2";
            this.lblBetaParameter2.Size = new System.Drawing.Size(100, 14);
            this.lblBetaParameter2.TabIndex = 41;
            this.lblBetaParameter2.Text = "Beta Parameter2:";
            // 
            // txtBconstantValue
            // 
            this.txtBconstantValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBconstantValue.Location = new System.Drawing.Point(211, 183);
            this.txtBconstantValue.Name = "txtBconstantValue";
            this.txtBconstantValue.Size = new System.Drawing.Size(138, 22);
            this.txtBconstantValue.TabIndex = 42;
            this.txtBconstantValue.Text = "0";
            // 
            // txtAconstantValue
            // 
            this.txtAconstantValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAconstantValue.Location = new System.Drawing.Point(211, 155);
            this.txtAconstantValue.Name = "txtAconstantValue";
            this.txtAconstantValue.Size = new System.Drawing.Size(138, 22);
            this.txtAconstantValue.TabIndex = 40;
            this.txtAconstantValue.Text = "0";
            // 
            // txtCconstantValue
            // 
            this.txtCconstantValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCconstantValue.Location = new System.Drawing.Point(211, 211);
            this.txtCconstantValue.Name = "txtCconstantValue";
            this.txtCconstantValue.Size = new System.Drawing.Size(138, 22);
            this.txtCconstantValue.TabIndex = 45;
            this.txtCconstantValue.Text = "0";
            // 
            // lblConstantValue
            // 
            this.lblConstantValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConstantValue.AutoSize = true;
            this.lblConstantValue.Location = new System.Drawing.Point(209, 139);
            this.lblConstantValue.Name = "lblConstantValue";
            this.lblConstantValue.Size = new System.Drawing.Size(92, 14);
            this.lblConstantValue.TabIndex = 39;
            this.lblConstantValue.Text = "Constant Value:";
            // 
            // lblConstantDescription
            // 
            this.lblConstantDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConstantDescription.AutoSize = true;
            this.lblConstantDescription.Location = new System.Drawing.Point(59, 140);
            this.lblConstantDescription.Name = "lblConstantDescription";
            this.lblConstantDescription.Size = new System.Drawing.Size(123, 14);
            this.lblConstantDescription.TabIndex = 25;
            this.lblConstantDescription.Text = "Constant Description:";
            // 
            // txtAconstantDescription
            // 
            this.txtAconstantDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAconstantDescription.Location = new System.Drawing.Point(61, 157);
            this.txtAconstantDescription.Name = "txtAconstantDescription";
            this.txtAconstantDescription.Size = new System.Drawing.Size(138, 22);
            this.txtAconstantDescription.TabIndex = 27;
            // 
            // lblC
            // 
            this.lblC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(39, 216);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(16, 14);
            this.lblC.TabIndex = 35;
            this.lblC.Text = "C:";
            // 
            // lblA
            // 
            this.lblA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(39, 161);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(17, 14);
            this.lblA.TabIndex = 33;
            this.lblA.Text = "A:";
            // 
            // txtCconstantDescription
            // 
            this.txtCconstantDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCconstantDescription.Location = new System.Drawing.Point(61, 212);
            this.txtCconstantDescription.Name = "txtCconstantDescription";
            this.txtCconstantDescription.Size = new System.Drawing.Size(138, 22);
            this.txtCconstantDescription.TabIndex = 31;
            // 
            // lblB
            // 
            this.lblB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(39, 189);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(17, 14);
            this.lblB.TabIndex = 34;
            this.lblB.Text = "B:";
            // 
            // txtBconstantDescription
            // 
            this.txtBconstantDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBconstantDescription.Location = new System.Drawing.Point(61, 184);
            this.txtBconstantDescription.Name = "txtBconstantDescription";
            this.txtBconstantDescription.Size = new System.Drawing.Size(138, 22);
            this.txtBconstantDescription.TabIndex = 30;
            // 
            // txtBeta
            // 
            this.txtBeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBeta.Location = new System.Drawing.Point(211, 64);
            this.txtBeta.Name = "txtBeta";
            this.txtBeta.Size = new System.Drawing.Size(138, 22);
            this.txtBeta.TabIndex = 43;
            this.txtBeta.Text = "0";
            // 
            // cboBetaDistribution
            // 
            this.cboBetaDistribution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBetaDistribution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBetaDistribution.FormattingEnabled = true;
            this.cboBetaDistribution.Location = new System.Drawing.Point(61, 66);
            this.cboBetaDistribution.Name = "cboBetaDistribution";
            this.cboBetaDistribution.Size = new System.Drawing.Size(138, 22);
            this.cboBetaDistribution.TabIndex = 29;
            // 
            // lblBetaDisribution
            // 
            this.lblBetaDisribution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBetaDisribution.AutoSize = true;
            this.lblBetaDisribution.Location = new System.Drawing.Point(57, 50);
            this.lblBetaDisribution.Name = "lblBetaDisribution";
            this.lblBetaDisribution.Size = new System.Drawing.Size(103, 14);
            this.lblBetaDisribution.TabIndex = 26;
            this.lblBetaDisribution.Text = "Beta Distribution:";
            // 
            // lblBeta
            // 
            this.lblBeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBeta.AutoSize = true;
            this.lblBeta.Location = new System.Drawing.Point(209, 49);
            this.lblBeta.Name = "lblBeta";
            this.lblBeta.Size = new System.Drawing.Size(35, 14);
            this.lblBeta.TabIndex = 38;
            this.lblBeta.Text = "Beta:";
            // 
            // showForSeasonal
            // 
            this.showForSeasonal.AutoSize = true;
            this.showForSeasonal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.showForSeasonal.Controls.Add(this.lblEnd);
            this.showForSeasonal.Controls.Add(this.txtEnd);
            this.showForSeasonal.Controls.Add(this.lblStart);
            this.showForSeasonal.Controls.Add(this.txtStart);
            this.showForSeasonal.Controls.Add(this.lblSeason);
            this.showForSeasonal.Controls.Add(this.txtSeason);
            this.showForSeasonal.Controls.Add(this.editVarBtn);
            this.showForSeasonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showForSeasonal.Location = new System.Drawing.Point(0, 0);
            this.showForSeasonal.Margin = new System.Windows.Forms.Padding(0);
            this.showForSeasonal.Name = "showForSeasonal";
            this.showForSeasonal.Size = new System.Drawing.Size(409, 242);
            this.showForSeasonal.TabIndex = 51;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(306, 4);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(59, 14);
            this.lblEnd.TabIndex = 48;
            this.lblEnd.Text = "End Date:";
            // 
            // txtEnd
            // 
            this.txtEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnd.Enabled = false;
            this.txtEnd.Location = new System.Drawing.Point(308, 19);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(85, 22);
            this.txtEnd.TabIndex = 49;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(209, 4);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(64, 14);
            this.lblStart.TabIndex = 46;
            this.lblStart.Text = "Start Date:";
            // 
            // txtStart
            // 
            this.txtStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStart.BackColor = System.Drawing.SystemColors.Window;
            this.txtStart.Enabled = false;
            this.txtStart.Location = new System.Drawing.Point(211, 19);
            this.txtStart.Name = "txtStart";
            this.txtStart.ReadOnly = true;
            this.txtStart.Size = new System.Drawing.Size(85, 22);
            this.txtStart.TabIndex = 47;
            // 
            // lblSeason
            // 
            this.lblSeason.AutoSize = true;
            this.lblSeason.Location = new System.Drawing.Point(14, 4);
            this.lblSeason.Name = "lblSeason";
            this.lblSeason.Size = new System.Drawing.Size(50, 14);
            this.lblSeason.TabIndex = 36;
            this.lblSeason.Text = "Season:";
            // 
            // txtSeason
            // 
            this.txtSeason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeason.BackColor = System.Drawing.SystemColors.Window;
            this.txtSeason.Enabled = false;
            this.txtSeason.Location = new System.Drawing.Point(16, 19);
            this.txtSeason.Name = "txtSeason";
            this.txtSeason.ReadOnly = true;
            this.txtSeason.Size = new System.Drawing.Size(183, 22);
            this.txtSeason.TabIndex = 37;
            // 
            // editVarBtn
            // 
            this.editVarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.editVarBtn.Location = new System.Drawing.Point(110, 98);
            this.editVarBtn.Margin = new System.Windows.Forms.Padding(0);
            this.editVarBtn.Name = "editVarBtn";
            this.editVarBtn.Size = new System.Drawing.Size(186, 27);
            this.editVarBtn.TabIndex = 50;
            this.editVarBtn.Text = "Edit Variance/ Covariance";
            this.editVarBtn.UseVisualStyleBackColor = true;
            this.editVarBtn.Click += new System.EventHandler(this.editVarBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(5, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 263);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // lblVariable
            // 
            this.lblVariable.AutoSize = true;
            this.lblVariable.Location = new System.Drawing.Point(10, 14);
            this.lblVariable.Name = "lblVariable";
            this.lblVariable.Size = new System.Drawing.Size(56, 14);
            this.lblVariable.TabIndex = 55;
            this.lblVariable.Text = "Variable:";
            // 
            // lblModSpec
            // 
            this.lblModSpec.AutoSize = true;
            this.lblModSpec.Location = new System.Drawing.Point(10, 42);
            this.lblModSpec.Name = "lblModSpec";
            this.lblModSpec.Size = new System.Drawing.Size(116, 14);
            this.lblModSpec.TabIndex = 50;
            this.lblModSpec.Text = "Model Specification:";
            // 
            // txtModelSpec
            // 
            this.txtModelSpec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModelSpec.BackColor = System.Drawing.SystemColors.Window;
            this.txtModelSpec.Enabled = false;
            this.txtModelSpec.Location = new System.Drawing.Point(133, 38);
            this.txtModelSpec.MaximumSize = new System.Drawing.Size(282, 22);
            this.txtModelSpec.Name = "txtModelSpec";
            this.txtModelSpec.ReadOnly = true;
            this.txtModelSpec.Size = new System.Drawing.Size(282, 22);
            this.txtModelSpec.TabIndex = 49;
            // 
            // lblPollutant
            // 
            this.lblPollutant.AutoSize = true;
            this.lblPollutant.Location = new System.Drawing.Point(131, 14);
            this.lblPollutant.Name = "lblPollutant";
            this.lblPollutant.Size = new System.Drawing.Size(60, 14);
            this.lblPollutant.TabIndex = 52;
            this.lblPollutant.Text = "Pollutant:";
            // 
            // txtPollutant
            // 
            this.txtPollutant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPollutant.BackColor = System.Drawing.SystemColors.Window;
            this.txtPollutant.Enabled = false;
            this.txtPollutant.Location = new System.Drawing.Point(197, 10);
            this.txtPollutant.MaximumSize = new System.Drawing.Size(282, 22);
            this.txtPollutant.Name = "txtPollutant";
            this.txtPollutant.ReadOnly = true;
            this.txtPollutant.Size = new System.Drawing.Size(218, 22);
            this.txtPollutant.TabIndex = 51;
            // 
            // lblSeasMetric
            // 
            this.lblSeasMetric.AutoSize = true;
            this.lblSeasMetric.Location = new System.Drawing.Point(10, 70);
            this.lblSeasMetric.Name = "lblSeasMetric";
            this.lblSeasMetric.Size = new System.Drawing.Size(98, 14);
            this.lblSeasMetric.TabIndex = 54;
            this.lblSeasMetric.Text = "Seasonal Metric:";
            // 
            // txtSeasMetric
            // 
            this.txtSeasMetric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeasMetric.BackColor = System.Drawing.SystemColors.Window;
            this.txtSeasMetric.Enabled = false;
            this.txtSeasMetric.Location = new System.Drawing.Point(133, 66);
            this.txtSeasMetric.MaximumSize = new System.Drawing.Size(282, 22);
            this.txtSeasMetric.Name = "txtSeasMetric";
            this.txtSeasMetric.ReadOnly = true;
            this.txtSeasMetric.Size = new System.Drawing.Size(282, 22);
            this.txtSeasMetric.TabIndex = 53;
            // 
            // txtVariable
            // 
            this.txtVariable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVariable.BackColor = System.Drawing.SystemColors.Window;
            this.txtVariable.Enabled = false;
            this.txtVariable.Location = new System.Drawing.Point(71, 10);
            this.txtVariable.MaximumSize = new System.Drawing.Size(282, 22);
            this.txtVariable.Name = "txtVariable";
            this.txtVariable.ReadOnly = true;
            this.txtVariable.Size = new System.Drawing.Size(37, 22);
            this.txtVariable.TabIndex = 56;
            this.txtVariable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 14);
            this.label1.TabIndex = 57;
            this.label1.Text = "Season:";
            // 
            // cboSeason
            // 
            this.cboSeason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSeason.FormattingEnabled = true;
            this.cboSeason.Location = new System.Drawing.Point(177, 94);
            this.cboSeason.Name = "cboSeason";
            this.cboSeason.Size = new System.Drawing.Size(131, 22);
            this.cboSeason.TabIndex = 58;
            //this.cboSeason.SelectedIndexChanged += new System.EventHandler(this.cboSeason_SelectedValueChanged);
            // 
            // EffectCoefficients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(425, 445);
            this.Controls.Add(this.cboSeason);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVariable);
            this.Controls.Add(this.txtSeasMetric);
            this.Controls.Add(this.lblSeasMetric);
            this.Controls.Add(this.txtPollutant);
            this.Controls.Add(this.lblPollutant);
            this.Controls.Add(this.txtModelSpec);
            this.Controls.Add(this.lblModSpec);
            this.Controls.Add(this.lblVariable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpCancelOK);
            this.MaximumSize = new System.Drawing.Size(441, 483);
            this.MinimumSize = new System.Drawing.Size(441, 483);
            this.Name = "EffectCoefficients";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Effect Coefficients";
            this.Load += new System.EventHandler(this.EffectCoefficients_Load);
            this.grpCancelOK.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.showForSeasonal.ResumeLayout(false);
            this.showForSeasonal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpCancelOK;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBetaParameter1;
        private System.Windows.Forms.Label lblBetaParameter1;
        private System.Windows.Forms.TextBox txtBetaParameter2;
        private System.Windows.Forms.Label lblBetaParameter2;
        private System.Windows.Forms.TextBox txtBconstantValue;
        private System.Windows.Forms.TextBox txtAconstantValue;
        private System.Windows.Forms.TextBox txtCconstantValue;
        private System.Windows.Forms.Label lblConstantValue;
        private System.Windows.Forms.Label lblConstantDescription;
        private System.Windows.Forms.TextBox txtAconstantDescription;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtCconstantDescription;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtBconstantDescription;
        private System.Windows.Forms.TextBox txtBeta;
        private System.Windows.Forms.ComboBox cboBetaDistribution;
        private System.Windows.Forms.Label lblBetaDisribution;
        private System.Windows.Forms.Label lblBeta;
        private System.Windows.Forms.Panel showForSeasonal;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label lblSeason;
        private System.Windows.Forms.TextBox txtSeason;
        private System.Windows.Forms.Button editVarBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblVariable;
        private System.Windows.Forms.Label lblModSpec;
        private System.Windows.Forms.TextBox txtModelSpec;
        private System.Windows.Forms.Label lblPollutant;
        private System.Windows.Forms.TextBox txtPollutant;
        private System.Windows.Forms.Label lblSeasMetric;
        private System.Windows.Forms.TextBox txtSeasMetric;
        private System.Windows.Forms.TextBox txtVariable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSeason;
    }
}