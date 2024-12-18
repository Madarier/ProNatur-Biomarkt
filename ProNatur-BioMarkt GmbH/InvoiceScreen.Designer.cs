namespace ProNatur_BioMarkt_GmbH
{
    partial class InvoiceScreen
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
            this.invoiceDGV = new System.Windows.Forms.DataGridView();
            this.labelInvoiceScreenReceiver = new System.Windows.Forms.Label();
            this.labelInvoiceScreenBillText = new System.Windows.Forms.Label();
            this.labelInvoiceScreenTotalPrice = new System.Windows.Forms.Label();
            this.textBoxInvoiceReceiver = new System.Windows.Forms.TextBox();
            this.textBoxInvoiceBillText = new System.Windows.Forms.TextBox();
            this.textBoxInvoiceTotalPrice = new System.Windows.Forms.TextBox();
            this.btnInvoiceSave = new System.Windows.Forms.Button();
            this.btnInvoiceEdit = new System.Windows.Forms.Button();
            this.btnInvoiceClear = new System.Windows.Forms.Button();
            this.btnInvoiceDelete = new System.Windows.Forms.Button();
            this.btnInvoiceScreenBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceDGV
            // 
            this.invoiceDGV.AllowUserToAddRows = false;
            this.invoiceDGV.AllowUserToDeleteRows = false;
            this.invoiceDGV.AllowUserToResizeColumns = false;
            this.invoiceDGV.AllowUserToResizeRows = false;
            this.invoiceDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invoiceDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.invoiceDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.invoiceDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceDGV.Location = new System.Drawing.Point(12, 142);
            this.invoiceDGV.MultiSelect = false;
            this.invoiceDGV.Name = "invoiceDGV";
            this.invoiceDGV.ReadOnly = true;
            this.invoiceDGV.RowHeadersVisible = false;
            this.invoiceDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.invoiceDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.invoiceDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.invoiceDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.invoiceDGV.Size = new System.Drawing.Size(772, 307);
            this.invoiceDGV.TabIndex = 14;
            this.invoiceDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoiceDGV_CellContentClick);
            // 
            // labelInvoiceScreenReceiver
            // 
            this.labelInvoiceScreenReceiver.AutoSize = true;
            this.labelInvoiceScreenReceiver.BackColor = System.Drawing.Color.Transparent;
            this.labelInvoiceScreenReceiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvoiceScreenReceiver.ForeColor = System.Drawing.Color.White;
            this.labelInvoiceScreenReceiver.Location = new System.Drawing.Point(9, 21);
            this.labelInvoiceScreenReceiver.Name = "labelInvoiceScreenReceiver";
            this.labelInvoiceScreenReceiver.Size = new System.Drawing.Size(130, 13);
            this.labelInvoiceScreenReceiver.TabIndex = 15;
            this.labelInvoiceScreenReceiver.Text = "Rechnungsempfänger";
            // 
            // labelInvoiceScreenBillText
            // 
            this.labelInvoiceScreenBillText.AutoSize = true;
            this.labelInvoiceScreenBillText.BackColor = System.Drawing.Color.Transparent;
            this.labelInvoiceScreenBillText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvoiceScreenBillText.ForeColor = System.Drawing.Color.White;
            this.labelInvoiceScreenBillText.Location = new System.Drawing.Point(12, 50);
            this.labelInvoiceScreenBillText.Name = "labelInvoiceScreenBillText";
            this.labelInvoiceScreenBillText.Size = new System.Drawing.Size(92, 13);
            this.labelInvoiceScreenBillText.TabIndex = 16;
            this.labelInvoiceScreenBillText.Text = "Rechnungstext";
            // 
            // labelInvoiceScreenTotalPrice
            // 
            this.labelInvoiceScreenTotalPrice.AutoSize = true;
            this.labelInvoiceScreenTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelInvoiceScreenTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvoiceScreenTotalPrice.ForeColor = System.Drawing.Color.White;
            this.labelInvoiceScreenTotalPrice.Location = new System.Drawing.Point(12, 77);
            this.labelInvoiceScreenTotalPrice.Name = "labelInvoiceScreenTotalPrice";
            this.labelInvoiceScreenTotalPrice.Size = new System.Drawing.Size(76, 13);
            this.labelInvoiceScreenTotalPrice.TabIndex = 17;
            this.labelInvoiceScreenTotalPrice.Text = "Gesamtpreis";
            // 
            // textBoxInvoiceReceiver
            // 
            this.textBoxInvoiceReceiver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxInvoiceReceiver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInvoiceReceiver.ForeColor = System.Drawing.Color.White;
            this.textBoxInvoiceReceiver.Location = new System.Drawing.Point(157, 19);
            this.textBoxInvoiceReceiver.Name = "textBoxInvoiceReceiver";
            this.textBoxInvoiceReceiver.Size = new System.Drawing.Size(253, 20);
            this.textBoxInvoiceReceiver.TabIndex = 18;
            // 
            // textBoxInvoiceBillText
            // 
            this.textBoxInvoiceBillText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxInvoiceBillText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInvoiceBillText.ForeColor = System.Drawing.Color.White;
            this.textBoxInvoiceBillText.Location = new System.Drawing.Point(157, 48);
            this.textBoxInvoiceBillText.Name = "textBoxInvoiceBillText";
            this.textBoxInvoiceBillText.Size = new System.Drawing.Size(377, 20);
            this.textBoxInvoiceBillText.TabIndex = 19;
            // 
            // textBoxInvoiceTotalPrice
            // 
            this.textBoxInvoiceTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxInvoiceTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInvoiceTotalPrice.ForeColor = System.Drawing.Color.White;
            this.textBoxInvoiceTotalPrice.Location = new System.Drawing.Point(157, 74);
            this.textBoxInvoiceTotalPrice.Name = "textBoxInvoiceTotalPrice";
            this.textBoxInvoiceTotalPrice.Size = new System.Drawing.Size(142, 20);
            this.textBoxInvoiceTotalPrice.TabIndex = 20;
            // 
            // btnInvoiceSave
            // 
            this.btnInvoiceSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnInvoiceSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoiceSave.ForeColor = System.Drawing.Color.White;
            this.btnInvoiceSave.Location = new System.Drawing.Point(157, 113);
            this.btnInvoiceSave.Name = "btnInvoiceSave";
            this.btnInvoiceSave.Size = new System.Drawing.Size(75, 23);
            this.btnInvoiceSave.TabIndex = 21;
            this.btnInvoiceSave.Text = "Speichern";
            this.btnInvoiceSave.UseVisualStyleBackColor = false;
            this.btnInvoiceSave.Click += new System.EventHandler(this.btnInvoiceSave_Click);
            // 
            // btnInvoiceEdit
            // 
            this.btnInvoiceEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnInvoiceEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoiceEdit.ForeColor = System.Drawing.Color.White;
            this.btnInvoiceEdit.Location = new System.Drawing.Point(238, 113);
            this.btnInvoiceEdit.Name = "btnInvoiceEdit";
            this.btnInvoiceEdit.Size = new System.Drawing.Size(75, 23);
            this.btnInvoiceEdit.TabIndex = 22;
            this.btnInvoiceEdit.Text = "Bearbeiten";
            this.btnInvoiceEdit.UseVisualStyleBackColor = false;
            this.btnInvoiceEdit.Click += new System.EventHandler(this.btnInvoiceEdit_Click);
            // 
            // btnInvoiceClear
            // 
            this.btnInvoiceClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnInvoiceClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoiceClear.ForeColor = System.Drawing.Color.White;
            this.btnInvoiceClear.Location = new System.Drawing.Point(319, 113);
            this.btnInvoiceClear.Name = "btnInvoiceClear";
            this.btnInvoiceClear.Size = new System.Drawing.Size(91, 23);
            this.btnInvoiceClear.TabIndex = 23;
            this.btnInvoiceClear.Text = "Felder Leeren";
            this.btnInvoiceClear.UseVisualStyleBackColor = false;
            this.btnInvoiceClear.Click += new System.EventHandler(this.btnInvoiceClear_Click);
            // 
            // btnInvoiceDelete
            // 
            this.btnInvoiceDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnInvoiceDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoiceDelete.ForeColor = System.Drawing.Color.White;
            this.btnInvoiceDelete.Location = new System.Drawing.Point(416, 113);
            this.btnInvoiceDelete.Name = "btnInvoiceDelete";
            this.btnInvoiceDelete.Size = new System.Drawing.Size(75, 23);
            this.btnInvoiceDelete.TabIndex = 24;
            this.btnInvoiceDelete.Text = "Löschen";
            this.btnInvoiceDelete.UseVisualStyleBackColor = false;
            this.btnInvoiceDelete.Click += new System.EventHandler(this.btnInvoiceDelete_Click);
            // 
            // btnInvoiceScreenBack
            // 
            this.btnInvoiceScreenBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnInvoiceScreenBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoiceScreenBack.ForeColor = System.Drawing.Color.White;
            this.btnInvoiceScreenBack.Location = new System.Drawing.Point(712, 12);
            this.btnInvoiceScreenBack.Name = "btnInvoiceScreenBack";
            this.btnInvoiceScreenBack.Size = new System.Drawing.Size(75, 23);
            this.btnInvoiceScreenBack.TabIndex = 25;
            this.btnInvoiceScreenBack.Text = "Zurück";
            this.btnInvoiceScreenBack.UseVisualStyleBackColor = false;
            this.btnInvoiceScreenBack.Click += new System.EventHandler(this.btnInvoiceScreenBack_Click);
            // 
            // InvoiceScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = global::ProNatur_BioMarkt_GmbH.Properties.Resources.ImgBgProducts;
            this.ClientSize = new System.Drawing.Size(799, 461);
            this.Controls.Add(this.btnInvoiceScreenBack);
            this.Controls.Add(this.btnInvoiceDelete);
            this.Controls.Add(this.btnInvoiceClear);
            this.Controls.Add(this.btnInvoiceEdit);
            this.Controls.Add(this.btnInvoiceSave);
            this.Controls.Add(this.textBoxInvoiceTotalPrice);
            this.Controls.Add(this.textBoxInvoiceBillText);
            this.Controls.Add(this.textBoxInvoiceReceiver);
            this.Controls.Add(this.labelInvoiceScreenTotalPrice);
            this.Controls.Add(this.labelInvoiceScreenBillText);
            this.Controls.Add(this.labelInvoiceScreenReceiver);
            this.Controls.Add(this.invoiceDGV);
            this.Name = "InvoiceScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rechnungen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InvoiceScreen_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView invoiceDGV;
        private System.Windows.Forms.Label labelInvoiceScreenReceiver;
        private System.Windows.Forms.Label labelInvoiceScreenBillText;
        private System.Windows.Forms.Label labelInvoiceScreenTotalPrice;
        private System.Windows.Forms.TextBox textBoxInvoiceReceiver;
        private System.Windows.Forms.TextBox textBoxInvoiceBillText;
        private System.Windows.Forms.TextBox textBoxInvoiceTotalPrice;
        private System.Windows.Forms.Button btnInvoiceSave;
        private System.Windows.Forms.Button btnInvoiceEdit;
        private System.Windows.Forms.Button btnInvoiceClear;
        private System.Windows.Forms.Button btnInvoiceDelete;
        private System.Windows.Forms.Button btnInvoiceScreenBack;
    }
}