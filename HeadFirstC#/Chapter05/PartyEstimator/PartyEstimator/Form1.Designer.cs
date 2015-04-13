﻿namespace PartyEstimator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.fancyDecorationsCheckBox = new System.Windows.Forms.CheckBox();
            this.healthyOptionCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.numberOfPeopleUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeopleUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of People";
            // 
            // fancyDecorationsCheckBox
            // 
            this.fancyDecorationsCheckBox.AutoSize = true;
            this.fancyDecorationsCheckBox.Checked = true;
            this.fancyDecorationsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyDecorationsCheckBox.Location = new System.Drawing.Point(30, 90);
            this.fancyDecorationsCheckBox.Name = "fancyDecorationsCheckBox";
            this.fancyDecorationsCheckBox.Size = new System.Drawing.Size(115, 17);
            this.fancyDecorationsCheckBox.TabIndex = 1;
            this.fancyDecorationsCheckBox.Text = "Fancy Decorations";
            this.fancyDecorationsCheckBox.UseVisualStyleBackColor = true;
            this.fancyDecorationsCheckBox.CheckedChanged += new System.EventHandler(this.fancyDecorationsCheckBox_CheckedChanged);
            // 
            // healthyOptionCheckBox
            // 
            this.healthyOptionCheckBox.AutoSize = true;
            this.healthyOptionCheckBox.Location = new System.Drawing.Point(30, 114);
            this.healthyOptionCheckBox.Name = "healthyOptionCheckBox";
            this.healthyOptionCheckBox.Size = new System.Drawing.Size(96, 17);
            this.healthyOptionCheckBox.TabIndex = 2;
            this.healthyOptionCheckBox.Text = "Healthy Option";
            this.healthyOptionCheckBox.UseVisualStyleBackColor = true;
            this.healthyOptionCheckBox.CheckedChanged += new System.EventHandler(this.healthyOptionCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cost";
            // 
            // costLabel
            // 
            this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costLabel.Location = new System.Drawing.Point(72, 151);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(100, 23);
            this.costLabel.TabIndex = 4;
            // 
            // numberOfPeopleUpDown
            // 
            this.numberOfPeopleUpDown.Location = new System.Drawing.Point(30, 48);
            this.numberOfPeopleUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numberOfPeopleUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfPeopleUpDown.Name = "numberOfPeopleUpDown";
            this.numberOfPeopleUpDown.Size = new System.Drawing.Size(60, 20);
            this.numberOfPeopleUpDown.TabIndex = 5;
            this.numberOfPeopleUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberOfPeopleUpDown.ValueChanged += new System.EventHandler(this.numberOfPeopleUpDown_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 212);
            this.Controls.Add(this.numberOfPeopleUpDown);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.healthyOptionCheckBox);
            this.Controls.Add(this.fancyDecorationsCheckBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeopleUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox fancyDecorationsCheckBox;
        private System.Windows.Forms.CheckBox healthyOptionCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.NumericUpDown numberOfPeopleUpDown;
    }
}

