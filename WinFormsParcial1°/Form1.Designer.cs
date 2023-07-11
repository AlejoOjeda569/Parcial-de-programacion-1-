namespace WinFormsParcial1_
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            btnSalir = new Button();
            btnCancelar = new Button();
            btnOk = new Button();
            txtAltura = new TextBox();
            txtRadio = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ColAltura = new DataGridViewTextBoxColumn();
            ColRadio = new DataGridViewTextBoxColumn();
            ColBase = new DataGridViewTextBoxColumn();
            ColArea = new DataGridViewTextBoxColumn();
            ColVolumen = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnSalir);
            splitContainer1.Panel1.Controls.Add(btnCancelar);
            splitContainer1.Panel1.Controls.Add(btnOk);
            splitContainer1.Panel1.Controls.Add(txtAltura);
            splitContainer1.Panel1.Controls.Add(txtRadio);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(631, 48);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(122, 55);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(259, 176);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(122, 55);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(75, 176);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(122, 55);
            btnOk.TabIndex = 4;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(183, 109);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(147, 23);
            txtAltura.TabIndex = 3;
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(183, 30);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(147, 23);
            txtRadio.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 112);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingresar el Altura=";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 33);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingresar el Radio=";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColAltura, ColRadio, ColBase, ColArea, ColVolumen });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 180);
            dataGridView1.TabIndex = 0;
            // 
            // ColAltura
            // 
            ColAltura.HeaderText = "Altura";
            ColAltura.Name = "ColAltura";
            ColAltura.ReadOnly = true;
            // 
            // ColRadio
            // 
            ColRadio.HeaderText = "Radio";
            ColRadio.Name = "ColRadio";
            ColRadio.ReadOnly = true;
            // 
            // ColBase
            // 
            ColBase.HeaderText = "Base";
            ColBase.Name = "ColBase";
            ColBase.ReadOnly = true;
            // 
            // ColArea
            // 
            ColArea.HeaderText = "Area";
            ColArea.Name = "ColArea";
            ColArea.ReadOnly = true;
            // 
            // ColVolumen
            // 
            ColVolumen.HeaderText = "Volumen";
            ColVolumen.Name = "ColVolumen";
            ColVolumen.ReadOnly = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColAltura;
        private DataGridViewTextBoxColumn ColRadio;
        private DataGridViewTextBoxColumn ColBase;
        private DataGridViewTextBoxColumn ColArea;
        private DataGridViewTextBoxColumn ColVolumen;
        private Button btnSalir;
        private Button btnCancelar;
        private Button btnOk;
        private TextBox txtAltura;
        private TextBox txtRadio;
        private Label label2;
        private ErrorProvider errorProvider1;
    }
}