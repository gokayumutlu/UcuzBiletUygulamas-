namespace UcuzBiletProje
{
    partial class MAna
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
            this.araButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboNereden = new System.Windows.Forms.ComboBox();
            this.comboNereye = new System.Windows.Forms.ComboBox();
            this.aktarmasizCheckBox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // araButton
            // 
            this.araButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araButton.Location = new System.Drawing.Point(113, 220);
            this.araButton.Name = "araButton";
            this.araButton.Size = new System.Drawing.Size(75, 28);
            this.araButton.TabIndex = 0;
            this.araButton.Text = "Ara";
            this.araButton.UseVisualStyleBackColor = true;
            this.araButton.Click += new System.EventHandler(this.araButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nereden";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nereye";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(48, 148);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // comboNereden
            // 
            this.comboNereden.FormattingEnabled = true;
            this.comboNereden.Location = new System.Drawing.Point(12, 38);
            this.comboNereden.Name = "comboNereden";
            this.comboNereden.Size = new System.Drawing.Size(121, 21);
            this.comboNereden.TabIndex = 6;
            this.comboNereden.SelectedIndexChanged += new System.EventHandler(this.comboNereden_SelectedIndexChanged);
            // 
            // comboNereye
            // 
            this.comboNereye.FormattingEnabled = true;
            this.comboNereye.Location = new System.Drawing.Point(161, 38);
            this.comboNereye.Name = "comboNereye";
            this.comboNereye.Size = new System.Drawing.Size(121, 21);
            this.comboNereye.TabIndex = 7;
            this.comboNereye.SelectedIndexChanged += new System.EventHandler(this.comboNereye_SelectedIndexChanged);
            // 
            // aktarmasizCheckBox
            // 
            this.aktarmasizCheckBox.AutoSize = true;
            this.aktarmasizCheckBox.Location = new System.Drawing.Point(95, 85);
            this.aktarmasizCheckBox.Name = "aktarmasizCheckBox";
            this.aktarmasizCheckBox.Size = new System.Drawing.Size(116, 17);
            this.aktarmasizCheckBox.TabIndex = 8;
            this.aktarmasizCheckBox.Text = "Sadece aktarmasız";
            this.aktarmasizCheckBox.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 283);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.aktarmasizCheckBox);
            this.Controls.Add(this.comboNereye);
            this.Controls.Add(this.comboNereden);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.araButton);
            this.Name = "MAna";
            this.Text = "MAna";
            this.Load += new System.EventHandler(this.MAna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button araButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboNereden;
        private System.Windows.Forms.ComboBox comboNereye;
        private System.Windows.Forms.CheckBox aktarmasizCheckBox;
        private System.Windows.Forms.Button button2;
    }
}