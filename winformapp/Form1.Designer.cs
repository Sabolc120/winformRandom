namespace winformapp
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.randomGenbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.resultListbox = new System.Windows.Forms.ListBox();
            this.howMany = new System.Windows.Forms.NumericUpDown();
            this.firstNumberradius = new System.Windows.Forms.NumericUpDown();
            this.secondNumberradius = new System.Windows.Forms.NumericUpDown();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNumberradius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumberradius)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mennyi legyen?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(153, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mennyitől?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(287, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Meddig?";
            // 
            // randomGenbutton
            // 
            this.randomGenbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.randomGenbutton.Location = new System.Drawing.Point(113, 301);
            this.randomGenbutton.Name = "randomGenbutton";
            this.randomGenbutton.Size = new System.Drawing.Size(163, 33);
            this.randomGenbutton.TabIndex = 6;
            this.randomGenbutton.Text = "Random szám lekérés";
            this.randomGenbutton.UseVisualStyleBackColor = true;
            this.randomGenbutton.Click += new System.EventHandler(this.randomGenbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Eredmény:";
            // 
            // resultListbox
            // 
            this.resultListbox.FormattingEnabled = true;
            this.resultListbox.Location = new System.Drawing.Point(144, 50);
            this.resultListbox.Name = "resultListbox";
            this.resultListbox.Size = new System.Drawing.Size(216, 173);
            this.resultListbox.TabIndex = 9;
            this.resultListbox.SelectedIndexChanged += new System.EventHandler(this.resultListbox_SelectedIndexChanged);
            // 
            // howMany
            // 
            this.howMany.Location = new System.Drawing.Point(7, 239);
            this.howMany.Name = "howMany";
            this.howMany.Size = new System.Drawing.Size(120, 20);
            this.howMany.TabIndex = 10;
            this.howMany.ValueChanged += new System.EventHandler(this.howMany_ValueChanged);
            // 
            // firstNumberradius
            // 
            this.firstNumberradius.Location = new System.Drawing.Point(144, 239);
            this.firstNumberradius.Name = "firstNumberradius";
            this.firstNumberradius.Size = new System.Drawing.Size(120, 20);
            this.firstNumberradius.TabIndex = 11;
            this.firstNumberradius.ValueChanged += new System.EventHandler(this.firstNumberradius_ValueChanged);
            // 
            // secondNumberradius
            // 
            this.secondNumberradius.Location = new System.Drawing.Point(270, 239);
            this.secondNumberradius.Name = "secondNumberradius";
            this.secondNumberradius.Size = new System.Drawing.Size(120, 20);
            this.secondNumberradius.TabIndex = 12;
            this.secondNumberradius.ValueChanged += new System.EventHandler(this.secondNumberradius_ValueChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(144, 340);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(94, 23);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Tartalom törlése.";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(396, 363);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.secondNumberradius);
            this.Controls.Add(this.firstNumberradius);
            this.Controls.Add(this.howMany);
            this.Controls.Add(this.resultListbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.randomGenbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.howMany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNumberradius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumberradius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button randomGenbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox resultListbox;
        private System.Windows.Forms.NumericUpDown howMany;
        private System.Windows.Forms.NumericUpDown firstNumberradius;
        private System.Windows.Forms.NumericUpDown secondNumberradius;
        private System.Windows.Forms.Button deleteButton;
    }
}

