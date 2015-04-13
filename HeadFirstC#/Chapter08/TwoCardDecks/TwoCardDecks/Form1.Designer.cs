namespace TwoCardDecks
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
            this.deck1Label = new System.Windows.Forms.Label();
            this.deck1List = new System.Windows.Forms.ListBox();
            this.deck2List = new System.Windows.Forms.ListBox();
            this.toDeck2 = new System.Windows.Forms.Button();
            this.toDeck1 = new System.Windows.Forms.Button();
            this.deck2Label = new System.Windows.Forms.Label();
            this.reset1 = new System.Windows.Forms.Button();
            this.shuffle1 = new System.Windows.Forms.Button();
            this.reset2 = new System.Windows.Forms.Button();
            this.shuffle2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deck1Label
            // 
            this.deck1Label.AutoSize = true;
            this.deck1Label.Location = new System.Drawing.Point(16, 13);
            this.deck1Label.Name = "deck1Label";
            this.deck1Label.Size = new System.Drawing.Size(93, 13);
            this.deck1Label.TabIndex = 0;
            this.deck1Label.Text = "Deck #1 (9 cards)";
            // 
            // deck1List
            // 
            this.deck1List.FormattingEnabled = true;
            this.deck1List.Location = new System.Drawing.Point(19, 29);
            this.deck1List.Name = "deck1List";
            this.deck1List.Size = new System.Drawing.Size(149, 290);
            this.deck1List.TabIndex = 1;
            // 
            // deck2List
            // 
            this.deck2List.FormattingEnabled = true;
            this.deck2List.Location = new System.Drawing.Point(249, 29);
            this.deck2List.Name = "deck2List";
            this.deck2List.Size = new System.Drawing.Size(148, 290);
            this.deck2List.TabIndex = 2;
            // 
            // toDeck2
            // 
            this.toDeck2.Location = new System.Drawing.Point(182, 133);
            this.toDeck2.Name = "toDeck2";
            this.toDeck2.Size = new System.Drawing.Size(53, 23);
            this.toDeck2.TabIndex = 3;
            this.toDeck2.Text = ">>";
            this.toDeck2.UseVisualStyleBackColor = true;
            this.toDeck2.Click += new System.EventHandler(this.toDeck2_Click);
            // 
            // toDeck1
            // 
            this.toDeck1.Location = new System.Drawing.Point(182, 171);
            this.toDeck1.Name = "toDeck1";
            this.toDeck1.Size = new System.Drawing.Size(53, 23);
            this.toDeck1.TabIndex = 4;
            this.toDeck1.Text = "<<";
            this.toDeck1.UseVisualStyleBackColor = true;
            this.toDeck1.Click += new System.EventHandler(this.toDeck1_Click);
            // 
            // deck2Label
            // 
            this.deck2Label.AutoSize = true;
            this.deck2Label.Location = new System.Drawing.Point(246, 13);
            this.deck2Label.Name = "deck2Label";
            this.deck2Label.Size = new System.Drawing.Size(99, 13);
            this.deck2Label.TabIndex = 5;
            this.deck2Label.Text = "Deck #2 (52 cards)";
            // 
            // reset1
            // 
            this.reset1.Location = new System.Drawing.Point(19, 334);
            this.reset1.Name = "reset1";
            this.reset1.Size = new System.Drawing.Size(149, 23);
            this.reset1.TabIndex = 6;
            this.reset1.Text = "Reset Deck #1";
            this.reset1.UseVisualStyleBackColor = true;
            this.reset1.Click += new System.EventHandler(this.reset1_Click);
            // 
            // shuffle1
            // 
            this.shuffle1.Location = new System.Drawing.Point(19, 363);
            this.shuffle1.Name = "shuffle1";
            this.shuffle1.Size = new System.Drawing.Size(149, 23);
            this.shuffle1.TabIndex = 7;
            this.shuffle1.Text = "Shuffle Deck1";
            this.shuffle1.UseVisualStyleBackColor = true;
            this.shuffle1.Click += new System.EventHandler(this.shuffle1_Click);
            // 
            // reset2
            // 
            this.reset2.Location = new System.Drawing.Point(249, 334);
            this.reset2.Name = "reset2";
            this.reset2.Size = new System.Drawing.Size(148, 23);
            this.reset2.TabIndex = 8;
            this.reset2.Text = "Reset Deck #2";
            this.reset2.UseVisualStyleBackColor = true;
            this.reset2.Click += new System.EventHandler(this.reset2_Click);
            // 
            // shuffle2
            // 
            this.shuffle2.Location = new System.Drawing.Point(249, 363);
            this.shuffle2.Name = "shuffle2";
            this.shuffle2.Size = new System.Drawing.Size(148, 23);
            this.shuffle2.TabIndex = 9;
            this.shuffle2.Text = "Shuffle Deck 2";
            this.shuffle2.UseVisualStyleBackColor = true;
            this.shuffle2.Click += new System.EventHandler(this.shuffle2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 393);
            this.Controls.Add(this.shuffle2);
            this.Controls.Add(this.reset2);
            this.Controls.Add(this.shuffle1);
            this.Controls.Add(this.reset1);
            this.Controls.Add(this.deck2Label);
            this.Controls.Add(this.toDeck1);
            this.Controls.Add(this.toDeck2);
            this.Controls.Add(this.deck2List);
            this.Controls.Add(this.deck1List);
            this.Controls.Add(this.deck1Label);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Two Decks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deck1Label;
        private System.Windows.Forms.ListBox deck1List;
        private System.Windows.Forms.ListBox deck2List;
        private System.Windows.Forms.Button toDeck2;
        private System.Windows.Forms.Button toDeck1;
        private System.Windows.Forms.Label deck2Label;
        private System.Windows.Forms.Button reset1;
        private System.Windows.Forms.Button shuffle1;
        private System.Windows.Forms.Button reset2;
        private System.Windows.Forms.Button shuffle2;
    }
}

