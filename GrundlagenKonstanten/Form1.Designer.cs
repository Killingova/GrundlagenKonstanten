namespace GrundlagenKonstanten
{
    partial class Form1
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
            CmdAnzeige1 = new Button();
            LblAnzeigen = new Label();
            CmdAnzeige2 = new Button();
            CmdAnzeige3 = new Button();
            SuspendLayout();
            // 
            // CmdAnzeige1
            // 
            CmdAnzeige1.Location = new Point(466, 44);
            CmdAnzeige1.Name = "CmdAnzeige1";
            CmdAnzeige1.Size = new Size(137, 59);
            CmdAnzeige1.TabIndex = 0;
            CmdAnzeige1.Text = "Anzeige 1";
            CmdAnzeige1.UseVisualStyleBackColor = true;
            CmdAnzeige1.Click += CmdAnzeige1_Click;
            // 
            // LblAnzeigen
            // 
            LblAnzeigen.AutoSize = true;
            LblAnzeigen.BorderStyle = BorderStyle.FixedSingle;
            LblAnzeigen.Location = new Point(167, 44);
            LblAnzeigen.Name = "LblAnzeigen";
            LblAnzeigen.Size = new Size(2, 22);
            LblAnzeigen.TabIndex = 1;
            // 
            // CmdAnzeige2
            // 
            CmdAnzeige2.Location = new Point(466, 158);
            CmdAnzeige2.Name = "CmdAnzeige2";
            CmdAnzeige2.Size = new Size(137, 59);
            CmdAnzeige2.TabIndex = 2;
            CmdAnzeige2.Text = "Anzeige 2";
            CmdAnzeige2.UseVisualStyleBackColor = true;
            CmdAnzeige2.Click += CmdAnzeige2_Click;
            // 
            // CmdAnzeige3
            // 
            CmdAnzeige3.Location = new Point(466, 275);
            CmdAnzeige3.Name = "CmdAnzeige3";
            CmdAnzeige3.Size = new Size(137, 59);
            CmdAnzeige3.TabIndex = 3;
            CmdAnzeige3.Text = "Anzeige 3";
            CmdAnzeige3.UseVisualStyleBackColor = true;
            CmdAnzeige3.Click += CmdAnzeige3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CmdAnzeige3);
            Controls.Add(CmdAnzeige2);
            Controls.Add(LblAnzeigen);
            Controls.Add(CmdAnzeige1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdAnzeige1;
        private Label LblAnzeigen;
        private Button CmdAnzeige2;
        private Button CmdAnzeige3;
    }
}
