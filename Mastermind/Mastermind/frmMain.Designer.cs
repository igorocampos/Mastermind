namespace Mastermind
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVerify = new System.Windows.Forms.Button();
            this.grpGuesses = new System.Windows.Forms.GroupBox();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.flpResults = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGiveUp = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.grpAnswer = new System.Windows.Forms.GroupBox();
            this.pnlHide = new System.Windows.Forms.Panel();
            this.grpGuesses.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.grpAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpLayout
            // 
            this.flpLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flpLayout.Location = new System.Drawing.Point(6, 15);
            this.flpLayout.Name = "flpLayout";
            this.flpLayout.Size = new System.Drawing.Size(107, 308);
            this.flpLayout.TabIndex = 0;
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(195, 90);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(75, 50);
            this.btnVerify.TabIndex = 1;
            this.btnVerify.Text = "Verify\r\n(10 left)";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // grpGuesses
            // 
            this.grpGuesses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpGuesses.Controls.Add(this.flpLayout);
            this.grpGuesses.Location = new System.Drawing.Point(12, 12);
            this.grpGuesses.Name = "grpGuesses";
            this.grpGuesses.Size = new System.Drawing.Size(116, 329);
            this.grpGuesses.TabIndex = 2;
            this.grpGuesses.TabStop = false;
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.flpResults);
            this.grpResults.Location = new System.Drawing.Point(134, 12);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(35, 329);
            this.grpResults.TabIndex = 3;
            this.grpResults.TabStop = false;
            // 
            // flpResults
            // 
            this.flpResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flpResults.Location = new System.Drawing.Point(6, 15);
            this.flpResults.Name = "flpResults";
            this.flpResults.Size = new System.Drawing.Size(25, 308);
            this.flpResults.TabIndex = 0;
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.Location = new System.Drawing.Point(195, 146);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(75, 50);
            this.btnGiveUp.TabIndex = 1;
            this.btnGiveUp.Text = "Give Up";
            this.btnGiveUp.UseVisualStyleBackColor = true;
            this.btnGiveUp.Click += new System.EventHandler(this.btnGiveUp_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(195, 202);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 50);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New Game";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(195, 258);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 50);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // grpAnswer
            // 
            this.grpAnswer.Controls.Add(this.pnlHide);
            this.grpAnswer.Location = new System.Drawing.Point(175, 12);
            this.grpAnswer.Name = "grpAnswer";
            this.grpAnswer.Size = new System.Drawing.Size(116, 55);
            this.grpAnswer.TabIndex = 4;
            this.grpAnswer.TabStop = false;
            // 
            // pnlHide
            // 
            this.pnlHide.BackColor = System.Drawing.Color.LightGray;
            this.pnlHide.Location = new System.Drawing.Point(6, 14);
            this.pnlHide.Name = "pnlHide";
            this.pnlHide.Size = new System.Drawing.Size(104, 34);
            this.pnlHide.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 354);
            this.Controls.Add(this.grpAnswer);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnGiveUp);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.grpGuesses);
            this.Controls.Add(this.btnVerify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Senha Mastermind";
            this.grpGuesses.ResumeLayout(false);
            this.grpResults.ResumeLayout(false);
            this.grpAnswer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpLayout;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.GroupBox grpGuesses;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.FlowLayoutPanel flpResults;
        private System.Windows.Forms.Button btnGiveUp;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.GroupBox grpAnswer;
        private System.Windows.Forms.Panel pnlHide;
    }
}

