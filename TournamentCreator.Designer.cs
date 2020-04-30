namespace Eksamensprojekt_Programmering_v2
{
    partial class TournamentCreator
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
            this.lsbTestTeam = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lsbTestTeam
            // 
            this.lsbTestTeam.FormattingEnabled = true;
            this.lsbTestTeam.ItemHeight = 16;
            this.lsbTestTeam.Location = new System.Drawing.Point(97, 62);
            this.lsbTestTeam.Name = "lsbTestTeam";
            this.lsbTestTeam.Size = new System.Drawing.Size(385, 612);
            this.lsbTestTeam.TabIndex = 0;
            // 
            // TournamentCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(821, 736);
            this.Controls.Add(this.lsbTestTeam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TournamentCreator";
            this.ShowIcon = false;
            this.Text = "Tournament Creator";
            this.Shown += new System.EventHandler(this.TournamentCreator_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbTestTeam;
    }
}