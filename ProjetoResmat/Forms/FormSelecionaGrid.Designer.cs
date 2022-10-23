
namespace ProjetoResmat.Forms
{
    partial class FormSelecionaGrid
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
            this.pnHorizontal = new System.Windows.Forms.Panel();
            this.txtQtdH = new System.Windows.Forms.NumericUpDown();
            this.txtIntervaloH = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnVertical = new System.Windows.Forms.Panel();
            this.txtQtdV = new System.Windows.Forms.NumericUpDown();
            this.txtIntervaloV = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntervaloH)).BeginInit();
            this.pnVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntervaloV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Defina as dimensões do grid:";
            // 
            // pnHorizontal
            // 
            this.pnHorizontal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnHorizontal.Controls.Add(this.txtQtdH);
            this.pnHorizontal.Controls.Add(this.txtIntervaloH);
            this.pnHorizontal.Controls.Add(this.label3);
            this.pnHorizontal.Controls.Add(this.label2);
            this.pnHorizontal.Location = new System.Drawing.Point(37, 56);
            this.pnHorizontal.Name = "pnHorizontal";
            this.pnHorizontal.Size = new System.Drawing.Size(141, 215);
            this.pnHorizontal.TabIndex = 1;
            // 
            // txtQtdH
            // 
            this.txtQtdH.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdH.Location = new System.Drawing.Point(21, 163);
            this.txtQtdH.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtQtdH.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQtdH.Name = "txtQtdH";
            this.txtQtdH.Size = new System.Drawing.Size(93, 27);
            this.txtQtdH.TabIndex = 8;
            this.txtQtdH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQtdH.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // txtIntervaloH
            // 
            this.txtIntervaloH.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntervaloH.Location = new System.Drawing.Point(21, 65);
            this.txtIntervaloH.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtIntervaloH.Name = "txtIntervaloH";
            this.txtIntervaloH.Size = new System.Drawing.Size(93, 27);
            this.txtIntervaloH.TabIndex = 7;
            this.txtIntervaloH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIntervaloH.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade de espaços";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Intervalo entre espaços Horizontais";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnVertical
            // 
            this.pnVertical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnVertical.Controls.Add(this.txtQtdV);
            this.pnVertical.Controls.Add(this.txtIntervaloV);
            this.pnVertical.Controls.Add(this.label4);
            this.pnVertical.Controls.Add(this.label5);
            this.pnVertical.Location = new System.Drawing.Point(230, 56);
            this.pnVertical.Name = "pnVertical";
            this.pnVertical.Size = new System.Drawing.Size(141, 215);
            this.pnVertical.TabIndex = 4;
            // 
            // txtQtdV
            // 
            this.txtQtdV.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdV.Location = new System.Drawing.Point(23, 163);
            this.txtQtdV.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtQtdV.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQtdV.Name = "txtQtdV";
            this.txtQtdV.Size = new System.Drawing.Size(93, 27);
            this.txtQtdV.TabIndex = 9;
            this.txtQtdV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQtdV.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // txtIntervaloV
            // 
            this.txtIntervaloV.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntervaloV.Location = new System.Drawing.Point(23, 65);
            this.txtIntervaloV.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtIntervaloV.Name = "txtIntervaloV";
            this.txtIntervaloV.Size = new System.Drawing.Size(93, 27);
            this.txtIntervaloV.TabIndex = 9;
            this.txtIntervaloV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIntervaloV.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantidade de espaços";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 37);
            this.label5.TabIndex = 0;
            this.label5.Text = "Intervalo entre espaços Verticais";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(37, 293);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(141, 41);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(230, 293);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(141, 41);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormSelecionaGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 361);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.pnVertical);
            this.Controls.Add(this.pnHorizontal);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSelecionaGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Grid";
            this.pnHorizontal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntervaloH)).EndInit();
            this.pnVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntervaloV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnHorizontal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnVertical;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown txtQtdH;
        private System.Windows.Forms.NumericUpDown txtIntervaloH;
        private System.Windows.Forms.NumericUpDown txtQtdV;
        private System.Windows.Forms.NumericUpDown txtIntervaloV;
    }
}