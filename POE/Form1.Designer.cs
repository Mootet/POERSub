namespace POE._1
{
    partial class Hero_label
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
            this.Map_label = new System.Windows.Forms.Label();
            this.LAbel_hero = new System.Windows.Forms.Label();
            this.Keypress = new System.Windows.Forms.Label();
            this.Enemeys_textbox = new System.Windows.Forms.RichTextBox();
            this.Attack_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.Load_button = new System.Windows.Forms.Button();
            this.shopinventory = new System.Windows.Forms.ComboBox();
            this.debugbox = new System.Windows.Forms.RichTextBox();
            this.Buy_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Map_label
            // 
            this.Map_label.AutoSize = true;
            this.Map_label.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Map_label.Location = new System.Drawing.Point(356, 11);
            this.Map_label.Name = "Map_label";
            this.Map_label.Size = new System.Drawing.Size(68, 18);
            this.Map_label.TabIndex = 0;
            this.Map_label.Text = "label1";
            this.Map_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAbel_hero
            // 
            this.LAbel_hero.AutoSize = true;
            this.LAbel_hero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAbel_hero.Location = new System.Drawing.Point(12, 9);
            this.LAbel_hero.Name = "LAbel_hero";
            this.LAbel_hero.Size = new System.Drawing.Size(51, 20);
            this.LAbel_hero.TabIndex = 1;
            this.LAbel_hero.Text = "label1";
            // 
            // Keypress
            // 
            this.Keypress.AutoSize = true;
            this.Keypress.Location = new System.Drawing.Point(12, 522);
            this.Keypress.Name = "Keypress";
            this.Keypress.Size = new System.Drawing.Size(35, 13);
            this.Keypress.TabIndex = 2;
            this.Keypress.Text = "label1";
            // 
            // Enemeys_textbox
            // 
            this.Enemeys_textbox.Location = new System.Drawing.Point(12, 218);
            this.Enemeys_textbox.Name = "Enemeys_textbox";
            this.Enemeys_textbox.ReadOnly = true;
            this.Enemeys_textbox.Size = new System.Drawing.Size(288, 261);
            this.Enemeys_textbox.TabIndex = 3;
            this.Enemeys_textbox.Text = "";
            this.Enemeys_textbox.TextChanged += new System.EventHandler(this.Enemeys_textbox_TextChanged);
            // 
            // Attack_button
            // 
            this.Attack_button.Location = new System.Drawing.Point(13, 485);
            this.Attack_button.Name = "Attack_button";
            this.Attack_button.Size = new System.Drawing.Size(50, 23);
            this.Attack_button.TabIndex = 4;
            this.Attack_button.Text = "Attack";
            this.Attack_button.UseVisualStyleBackColor = true;
            this.Attack_button.Click += new System.EventHandler(this.Attack_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(69, 485);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(45, 23);
            this.Save_button.TabIndex = 5;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Load_button
            // 
            this.Load_button.Location = new System.Drawing.Point(120, 485);
            this.Load_button.Name = "Load_button";
            this.Load_button.Size = new System.Drawing.Size(41, 23);
            this.Load_button.TabIndex = 6;
            this.Load_button.Text = "Load";
            this.Load_button.UseVisualStyleBackColor = true;
            this.Load_button.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // shopinventory
            // 
            this.shopinventory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shopinventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopinventory.FormattingEnabled = true;
            this.shopinventory.ItemHeight = 20;
            this.shopinventory.Location = new System.Drawing.Point(940, 12);
            this.shopinventory.Name = "shopinventory";
            this.shopinventory.Size = new System.Drawing.Size(266, 28);
            this.shopinventory.TabIndex = 7;
            this.shopinventory.SelectedIndexChanged += new System.EventHandler(this.shopinventory_SelectedIndexChanged);
            // 
            // debugbox
            // 
            this.debugbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugbox.Location = new System.Drawing.Point(940, 182);
            this.debugbox.Name = "debugbox";
            this.debugbox.Size = new System.Drawing.Size(266, 268);
            this.debugbox.TabIndex = 8;
            this.debugbox.Text = "";
            // 
            // Buy_button
            // 
            this.Buy_button.Location = new System.Drawing.Point(940, 134);
            this.Buy_button.Name = "Buy_button";
            this.Buy_button.Size = new System.Drawing.Size(94, 33);
            this.Buy_button.TabIndex = 9;
            this.Buy_button.Text = "Buy!";
            this.Buy_button.UseVisualStyleBackColor = true;
            this.Buy_button.Click += new System.EventHandler(this.Buy_button_Click);
            // 
            // Hero_label
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1218, 544);
            this.Controls.Add(this.Buy_button);
            this.Controls.Add(this.debugbox);
            this.Controls.Add(this.shopinventory);
            this.Controls.Add(this.Load_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Attack_button);
            this.Controls.Add(this.Enemeys_textbox);
            this.Controls.Add(this.Keypress);
            this.Controls.Add(this.LAbel_hero);
            this.Controls.Add(this.Map_label);
            this.Name = "Hero_label";
            this.Text = "Rouge lite";
            this.Load += new System.EventHandler(this.Hero_label_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Map_label;
        private System.Windows.Forms.Label LAbel_hero;
        private System.Windows.Forms.Label Keypress;
        private System.Windows.Forms.RichTextBox Enemeys_textbox;
        private System.Windows.Forms.Button Attack_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Load_button;
        private System.Windows.Forms.ComboBox shopinventory;
        private System.Windows.Forms.RichTextBox debugbox;
        private System.Windows.Forms.Button Buy_button;
    }
}

