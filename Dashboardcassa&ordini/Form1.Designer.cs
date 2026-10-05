namespace Dashboardcassa_ordini
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
            desc = new Label();
            txtArt = new TextBox();
            costo = new Label();
            Quant = new Label();
            txtPrezzo = new TextBox();
            txtQ = new TextBox();
            Agg = new Button();
            rem = new Button();
            lista = new ListBox();
            label4 = new Label();
            Tot = new Label();
            salvaF = new Button();
            SuspendLayout();
            // 
            // desc
            // 
            desc.AutoSize = true;
            desc.Location = new Point(68, 170);
            desc.Name = "desc";
            desc.Size = new Size(139, 20);
            desc.TabIndex = 0;
            desc.Text = "descrizione articolo";
            // 
            // txtArt
            // 
            txtArt.Location = new Point(68, 193);
            txtArt.Name = "txtArt";
            txtArt.Size = new Size(125, 27);
            txtArt.TabIndex = 1;
            // 
            // costo
            // 
            costo.AutoSize = true;
            costo.Location = new Point(67, 223);
            costo.Name = "costo";
            costo.Size = new Size(53, 20);
            costo.TabIndex = 2;
            costo.Text = "Prezzo";
            // 
            // Quant
            // 
            Quant.AutoSize = true;
            Quant.Location = new Point(197, 223);
            Quant.Name = "Quant";
            Quant.Size = new Size(66, 20);
            Quant.TabIndex = 3;
            Quant.Text = "Quantità";
            // 
            // txtPrezzo
            // 
            txtPrezzo.Location = new Point(66, 246);
            txtPrezzo.Name = "txtPrezzo";
            txtPrezzo.Size = new Size(125, 27);
            txtPrezzo.TabIndex = 4;
            txtPrezzo.TextChanged += txtPrezzo_TextChanged;
            // 
            // txtQ
            // 
            txtQ.Location = new Point(197, 246);
            txtQ.Name = "txtQ";
            txtQ.Size = new Size(125, 27);
            txtQ.TabIndex = 5;
            // 
            // Agg
            // 
            Agg.Location = new Point(67, 288);
            Agg.Name = "Agg";
            Agg.Size = new Size(255, 29);
            Agg.TabIndex = 6;
            Agg.Text = "+ Aggiungi voce";
            Agg.UseVisualStyleBackColor = true;
            Agg.Click += Agg_Click;
            // 
            // rem
            // 
            rem.Location = new Point(68, 323);
            rem.Name = "rem";
            rem.Size = new Size(254, 29);
            rem.TabIndex = 7;
            rem.Text = "- Rimuovi voce";
            rem.UseVisualStyleBackColor = true;
            rem.Click += rem_Click_1;
            // 
            // lista
            // 
            lista.FormattingEnabled = true;
            lista.Location = new Point(328, 170);
            lista.Name = "lista";
            lista.Size = new Size(321, 284);
            lista.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 396);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 9;
            label4.Text = "Totale";
            // 
            // Tot
            // 
            Tot.AutoSize = true;
            Tot.Location = new Point(68, 427);
            Tot.Name = "Tot";
            Tot.Size = new Size(0, 20);
            Tot.TabIndex = 10;
            // 
            // salvaF
            // 
            salvaF.Location = new Point(197, 396);
            salvaF.Name = "salvaF";
            salvaF.Size = new Size(125, 56);
            salvaF.TabIndex = 11;
            salvaF.Text = "Salva su file";
            salvaF.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1756, 725);
            Controls.Add(salvaF);
            Controls.Add(Tot);
            Controls.Add(label4);
            Controls.Add(lista);
            Controls.Add(rem);
            Controls.Add(Agg);
            Controls.Add(txtQ);
            Controls.Add(txtPrezzo);
            Controls.Add(Quant);
            Controls.Add(costo);
            Controls.Add(txtArt);
            Controls.Add(desc);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label desc;
        private TextBox txtArt;
        private Label costo;
        private Label Quant;
        private TextBox txtPrezzo;
        private TextBox txtQ;
        private Button Agg;
        private Button rem;
        private ListBox lista;
        private Label label4;
        private Label Tot;
        private Button salvaF;
    }
}
