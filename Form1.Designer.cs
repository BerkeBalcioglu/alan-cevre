namespace ödev_alan_çevre
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
            kkenarlabel=new Label();
            UzunKla=new Label();
            Alan=new Label();
            button=new Button();
            UzunKtxt=new TextBox();
            KısaKtxt=new TextBox();
            cevre=new Label();
            alanlbl=new Label();
            cevrelbl=new Label();
            label1=new Label();
            SuspendLayout();
            // 
            // kkenarlabel
            // 
            kkenarlabel.AutoSize=true;
            kkenarlabel.Font=new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            kkenarlabel.Location=new Point(26, 57);
            kkenarlabel.Name="kkenarlabel";
            kkenarlabel.Size=new Size(83, 19);
            kkenarlabel.TabIndex=0;
            kkenarlabel.Text="KISA KENAR";
            // 
            // UzunKla
            // 
            UzunKla.AutoSize=true;
            UzunKla.Location=new Point(225, 57);
            UzunKla.Name="UzunKla";
            UzunKla.Size=new Size(93, 19);
            UzunKla.TabIndex=1;
            UzunKla.Text="UZUN KENAR";
            // 
            // Alan
            // 
            Alan.AutoSize=true;
            Alan.Location=new Point(111, 294);
            Alan.Name="Alan";
            Alan.Size=new Size(51, 19);
            Alan.TabIndex=2;
            Alan.Text="ALAN :";
            // 
            // button
            // 
            button.Location=new Point(489, 54);
            button.Name="button";
            button.Size=new Size(95, 28);
            button.TabIndex=3;
            button.Text="HESAPLA";
            button.UseVisualStyleBackColor=true;
            button.Click+=button_Click;
            // 
            // UzunKtxt
            // 
            UzunKtxt.Location=new Point(324, 54);
            UzunKtxt.Name="UzunKtxt";
            UzunKtxt.Size=new Size(100, 25);
            UzunKtxt.TabIndex=4;
            // 
            // KısaKtxt
            // 
            KısaKtxt.Location=new Point(115, 53);
            KısaKtxt.Name="KısaKtxt";
            KısaKtxt.Size=new Size(100, 25);
            KısaKtxt.TabIndex=5;
            // 
            // cevre
            // 
            cevre.AutoSize=true;
            cevre.Location=new Point(111, 362);
            cevre.Name="cevre";
            cevre.Size=new Size(56, 19);
            cevre.TabIndex=6;
            cevre.Text="CEVRE :";
            // 
            // alanlbl
            // 
            alanlbl.AutoSize=true;
            alanlbl.BackColor=SystemColors.ActiveCaptionText;
            alanlbl.Font=new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            alanlbl.ForeColor=Color.Transparent;
            alanlbl.Location=new Point(170, 294);
            alanlbl.Name="alanlbl";
            alanlbl.Size=new Size(0, 25);
            alanlbl.TabIndex=7;
            // 
            // cevrelbl
            // 
            cevrelbl.AutoSize=true;
            cevrelbl.BackColor=Color.Black;
            cevrelbl.Font=new Font("Segoe UI", 14.25F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            cevrelbl.ForeColor=Color.Transparent;
            cevrelbl.Location=new Point(170, 362);
            cevrelbl.Name="cevrelbl";
            cevrelbl.Size=new Size(0, 25);
            cevrelbl.TabIndex=8;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.BackColor=Color.Black;
            label1.Font=new Font("Century Gothic", 14.25F, FontStyle.Bold|FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor=Color.Snow;
            label1.Location=new Point(630, 663);
            label1.Name="label1";
            label1.Size=new Size(174, 23);
            label1.TabIndex=9;
            label1.Text="BERKE BALCIOĞLU";
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 17F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.ControlLightLight;
            BackgroundImage=Properties.Resources.berkerersim__1_;
            BackgroundImageLayout=ImageLayout.None;
            ClientSize=new Size(804, 686);
            Controls.Add(label1);
            Controls.Add(cevrelbl);
            Controls.Add(alanlbl);
            Controls.Add(cevre);
            Controls.Add(KısaKtxt);
            Controls.Add(UzunKtxt);
            Controls.Add(button);
            Controls.Add(Alan);
            Controls.Add(UzunKla);
            Controls.Add(kkenarlabel);
            Font=new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor=Color.Black;
            Name="Form1";
            Text="DİKDÖRTGEN'İN ALANIIN VE ÇEVRESİNİ HESAPLAMA";
            Load+=Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label kkenarlabel;
        private Label UzunKla;
        private Label Alan;
        private Button button;
        private TextBox UzunKtxt;
        private TextBox KısaKtxt;
        private Label cevre;
        private Label alanlbl;
        private Label cevrelbl;
        private Label label1;
    }
}