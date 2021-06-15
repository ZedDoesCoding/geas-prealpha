
namespace geas_prealpha_001
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codiceLabel;
            System.Windows.Forms.Label produttoreLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label prezzoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.codiceTextBox = new System.Windows.Forms.TextBox();
            this.prodottiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.geasDataSet = new geas_prealpha_001.GeasDataSet();
            this.produttoreTextBox = new System.Windows.Forms.TextBox();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TextSearch = new System.Windows.Forms.Label();
            this.prezzoTextBox = new System.Windows.Forms.TextBox();
            this.prodottiDataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produttoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezzoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodottiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produttore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezzo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodottiTableAdapter = new geas_prealpha_001.GeasDataSetTableAdapters.ProdottiTableAdapter();
            this.tableAdapterManager = new geas_prealpha_001.GeasDataSetTableAdapters.TableAdapterManager();
            this.button2 = new System.Windows.Forms.Button();
            this.delbutt = new System.Windows.Forms.Button();
            codiceLabel = new System.Windows.Forms.Label();
            produttoreLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            prezzoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prodottiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodottiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodottiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codiceLabel
            // 
            codiceLabel.AutoSize = true;
            codiceLabel.Location = new System.Drawing.Point(555, 15);
            codiceLabel.Name = "codiceLabel";
            codiceLabel.Size = new System.Drawing.Size(43, 13);
            codiceLabel.TabIndex = 2;
            codiceLabel.Text = "Codice:";
            codiceLabel.Click += new System.EventHandler(this.codiceLabel_Click);
            // 
            // produttoreLabel
            // 
            produttoreLabel.AutoSize = true;
            produttoreLabel.Location = new System.Drawing.Point(555, 41);
            produttoreLabel.Name = "produttoreLabel";
            produttoreLabel.Size = new System.Drawing.Size(59, 13);
            produttoreLabel.TabIndex = 4;
            produttoreLabel.Text = "Produttore:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(555, 67);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(31, 13);
            tipoLabel.TabIndex = 6;
            tipoLabel.Text = "Tipo:";
            // 
            // prezzoLabel
            // 
            prezzoLabel.AutoSize = true;
            prezzoLabel.Location = new System.Drawing.Point(555, 93);
            prezzoLabel.Name = "prezzoLabel";
            prezzoLabel.Size = new System.Drawing.Size(42, 13);
            prezzoLabel.TabIndex = 11;
            prezzoLabel.Text = "Prezzo:";
            // 
            // codiceTextBox
            // 
            this.codiceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodottiBindingSource1, "Codice", true));
            this.codiceTextBox.Location = new System.Drawing.Point(637, 12);
            this.codiceTextBox.Name = "codiceTextBox";
            this.codiceTextBox.Size = new System.Drawing.Size(151, 20);
            this.codiceTextBox.TabIndex = 3;
            // 
            // prodottiBindingSource1
            // 
            this.prodottiBindingSource1.DataMember = "Prodotti";
            this.prodottiBindingSource1.DataSource = this.geasDataSet;
            // 
            // geasDataSet
            // 
            this.geasDataSet.DataSetName = "GeasDataSet";
            this.geasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produttoreTextBox
            // 
            this.produttoreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodottiBindingSource1, "Produttore", true));
            this.produttoreTextBox.Location = new System.Drawing.Point(637, 38);
            this.produttoreTextBox.Name = "produttoreTextBox";
            this.produttoreTextBox.Size = new System.Drawing.Size(151, 20);
            this.produttoreTextBox.TabIndex = 5;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodottiBindingSource1, "Tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(637, 64);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(151, 20);
            this.tipoTextBox.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(637, 221);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TextSearch
            // 
            this.TextSearch.AutoSize = true;
            this.TextSearch.Location = new System.Drawing.Point(555, 224);
            this.TextSearch.Name = "TextSearch";
            this.TextSearch.Size = new System.Drawing.Size(47, 13);
            this.TextSearch.TabIndex = 11;
            this.TextSearch.Text = "Ricerca:";
            this.TextSearch.Click += new System.EventHandler(this.label1_Click);
            // 
            // prezzoTextBox
            // 
            this.prezzoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prodottiBindingSource1, "Prezzo", true));
            this.prezzoTextBox.Location = new System.Drawing.Point(637, 90);
            this.prezzoTextBox.Name = "prezzoTextBox";
            this.prezzoTextBox.Size = new System.Drawing.Size(151, 20);
            this.prezzoTextBox.TabIndex = 12;
            // 
            // prodottiDataGridView
            // 
            this.prodottiDataGridView.AutoGenerateColumns = false;
            this.prodottiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodottiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.codiceDataGridViewTextBoxColumn,
            this.produttoreDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.prezzoDataGridViewTextBoxColumn});
            this.prodottiDataGridView.DataSource = this.prodottiBindingSource;
            this.prodottiDataGridView.Location = new System.Drawing.Point(12, 247);
            this.prodottiDataGridView.Name = "prodottiDataGridView";
            this.prodottiDataGridView.Size = new System.Drawing.Size(776, 323);
            this.prodottiDataGridView.TabIndex = 12;
            this.prodottiDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodottiDataGridView_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // codiceDataGridViewTextBoxColumn
            // 
            this.codiceDataGridViewTextBoxColumn.DataPropertyName = "Codice";
            this.codiceDataGridViewTextBoxColumn.HeaderText = "Codice";
            this.codiceDataGridViewTextBoxColumn.Name = "codiceDataGridViewTextBoxColumn";
            // 
            // produttoreDataGridViewTextBoxColumn
            // 
            this.produttoreDataGridViewTextBoxColumn.DataPropertyName = "Produttore";
            this.produttoreDataGridViewTextBoxColumn.HeaderText = "Produttore";
            this.produttoreDataGridViewTextBoxColumn.Name = "produttoreDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // prezzoDataGridViewTextBoxColumn
            // 
            this.prezzoDataGridViewTextBoxColumn.DataPropertyName = "Prezzo";
            this.prezzoDataGridViewTextBoxColumn.HeaderText = "Prezzo";
            this.prezzoDataGridViewTextBoxColumn.Name = "prezzoDataGridViewTextBoxColumn";
            // 
            // prodottiBindingSource
            // 
            this.prodottiBindingSource.DataMember = "Prodotti";
            this.prodottiBindingSource.DataSource = this.geasDataSet;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Codice";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Produttore
            // 
            this.Produttore.DataPropertyName = "Produttore";
            this.Produttore.HeaderText = "Produttore";
            this.Produttore.Name = "Produttore";
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Prezzo
            // 
            this.Prezzo.DataPropertyName = "Prezzo";
            this.Prezzo.HeaderText = "Prezzo";
            this.Prezzo.Name = "Prezzo";
            // 
            // prodottiTableAdapter
            // 
            this.prodottiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProdottiTableAdapter = this.prodottiTableAdapter;
            this.tableAdapterManager.UpdateOrder = geas_prealpha_001.GeasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Aggiungi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // delbutt
            // 
            this.delbutt.Location = new System.Drawing.Point(12, 41);
            this.delbutt.Name = "delbutt";
            this.delbutt.Size = new System.Drawing.Size(75, 23);
            this.delbutt.TabIndex = 15;
            this.delbutt.Text = "Cancella";
            this.delbutt.UseVisualStyleBackColor = true;
            this.delbutt.Click += new System.EventHandler(this.delbutt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 582);
            this.Controls.Add(this.delbutt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.prodottiDataGridView);
            this.Controls.Add(prezzoLabel);
            this.Controls.Add(this.prezzoTextBox);
            this.Controls.Add(this.TextSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoTextBox);
            this.Controls.Add(produttoreLabel);
            this.Controls.Add(this.produttoreTextBox);
            this.Controls.Add(codiceLabel);
            this.Controls.Add(this.codiceTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GEAS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodottiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodottiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodottiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GeasDataSet geasDataSet;
        private System.Windows.Forms.BindingSource prodottiBindingSource;
        private GeasDataSetTableAdapters.ProdottiTableAdapter prodottiTableAdapter;
        private GeasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox codiceTextBox;
        private System.Windows.Forms.TextBox produttoreTextBox;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label TextSearch;
        private System.Windows.Forms.TextBox prezzoTextBox;
        private System.Windows.Forms.DataGridView prodottiDataGridView;
        private System.Windows.Forms.BindingSource prodottiBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produttore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezzo;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produttoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezzoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button delbutt;
    }
}

