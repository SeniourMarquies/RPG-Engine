namespace RPG_Engine
{
    partial class SuperAdventure
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
            this.lblHitPoints = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblHitPointsValue = new System.Windows.Forms.Label();
            this.lblGoldValue = new System.Windows.Forms.Label();
            this.lblExperienceValue = new System.Windows.Forms.Label();
            this.lblLevelValue = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHitPoints
            // 
            this.lblHitPoints.AutoSize = true;
            this.lblHitPoints.Location = new System.Drawing.Point(31, 43);
            this.lblHitPoints.Name = "lblHitPoints";
            this.lblHitPoints.Size = new System.Drawing.Size(58, 13);
            this.lblHitPoints.TabIndex = 0;
            this.lblHitPoints.Text = "Hit Points :";
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(31, 70);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(35, 13);
            this.lblGold.TabIndex = 1;
            this.lblGold.Text = "Gold :";
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Location = new System.Drawing.Point(31, 97);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(66, 13);
            this.lblExperience.TabIndex = 2;
            this.lblExperience.Text = "Experience :";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(31, 129);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(39, 13);
            this.lblLevel.TabIndex = 3;
            this.lblLevel.Text = "Level :";
            // 
            // lblHitPointsValue
            // 
            this.lblHitPointsValue.AutoSize = true;
            this.lblHitPointsValue.Location = new System.Drawing.Point(103, 43);
            this.lblHitPointsValue.Name = "lblHitPointsValue";
            this.lblHitPointsValue.Size = new System.Drawing.Size(0, 13);
            this.lblHitPointsValue.TabIndex = 4;
            // 
            // lblGoldValue
            // 
            this.lblGoldValue.AutoSize = true;
            this.lblGoldValue.Location = new System.Drawing.Point(103, 70);
            this.lblGoldValue.Name = "lblGoldValue";
            this.lblGoldValue.Size = new System.Drawing.Size(0, 13);
            this.lblGoldValue.TabIndex = 5;
            // 
            // lblExperienceValue
            // 
            this.lblExperienceValue.AutoSize = true;
            this.lblExperienceValue.Location = new System.Drawing.Point(103, 97);
            this.lblExperienceValue.Name = "lblExperienceValue";
            this.lblExperienceValue.Size = new System.Drawing.Size(0, 13);
            this.lblExperienceValue.TabIndex = 6;
            // 
            // lblLevelValue
            // 
            this.lblLevelValue.AutoSize = true;
            this.lblLevelValue.Location = new System.Drawing.Point(103, 129);
            this.lblLevelValue.Name = "lblLevelValue";
            this.lblLevelValue.Size = new System.Drawing.Size(0, 13);
            this.lblLevelValue.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SuperAdventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblLevelValue);
            this.Controls.Add(this.lblExperienceValue);
            this.Controls.Add(this.lblGoldValue);
            this.Controls.Add(this.lblHitPointsValue);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblHitPoints);
            this.Name = "SuperAdventure";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SuperAdventure_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHitPoints;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblHitPointsValue;
        private System.Windows.Forms.Label lblGoldValue;
        private System.Windows.Forms.Label lblExperienceValue;
        private System.Windows.Forms.Label lblLevelValue;
        private System.Windows.Forms.Button button1;
    }
}

