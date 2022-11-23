namespace TradingCompany.WF
{
    partial class EditPost
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpInfo = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPostID = new System.Windows.Forms.TextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPostID = new System.Windows.Forms.Label();
            this.tpRelatedProducts = new System.Windows.Forms.TabPage();
            this.bsProducts = new System.Windows.Forms.BindingSource(this.components);
            this.clbProducts = new System.Windows.Forms.CheckedListBox();
            this.tabControl1.SuspendLayout();
            this.tpInfo.SuspendLayout();
            this.tpRelatedProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpInfo);
            this.tabControl1.Controls.Add(this.tpRelatedProducts);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(576, 293);
            this.tabControl1.TabIndex = 6;
            // 
            // tpInfo
            // 
            this.tpInfo.Controls.Add(this.btnCancel);
            this.tpInfo.Controls.Add(this.btnSave);
            this.tpInfo.Controls.Add(this.txtContent);
            this.tpInfo.Controls.Add(this.txtTitle);
            this.tpInfo.Controls.Add(this.txtPostID);
            this.tpInfo.Controls.Add(this.lblContent);
            this.tpInfo.Controls.Add(this.lblTitle);
            this.tpInfo.Controls.Add(this.lblPostID);
            this.tpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tpInfo.Location = new System.Drawing.Point(4, 25);
            this.tpInfo.Name = "tpInfo";
            this.tpInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpInfo.Size = new System.Drawing.Size(568, 264);
            this.tpInfo.TabIndex = 0;
            this.tpInfo.Text = "Info";
            this.tpInfo.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnCancel.Location = new System.Drawing.Point(147, 201);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 39);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnSave.Location = new System.Drawing.Point(311, 201);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 39);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtContent.Location = new System.Drawing.Point(174, 135);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(337, 34);
            this.txtContent.TabIndex = 11;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtTitle.Location = new System.Drawing.Point(174, 79);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(337, 34);
            this.txtTitle.TabIndex = 10;
            // 
            // txtPostID
            // 
            this.txtPostID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtPostID.Location = new System.Drawing.Point(174, 29);
            this.txtPostID.Name = "txtPostID";
            this.txtPostID.Size = new System.Drawing.Size(337, 34);
            this.txtPostID.TabIndex = 9;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblContent.Location = new System.Drawing.Point(48, 138);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(96, 29);
            this.lblContent.TabIndex = 8;
            this.lblContent.Text = "Content";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTitle.Location = new System.Drawing.Point(48, 82);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(61, 29);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Title";
            // 
            // lblPostID
            // 
            this.lblPostID.AutoSize = true;
            this.lblPostID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPostID.Location = new System.Drawing.Point(48, 32);
            this.lblPostID.Name = "lblPostID";
            this.lblPostID.Size = new System.Drawing.Size(84, 29);
            this.lblPostID.TabIndex = 6;
            this.lblPostID.Text = "PostID";
            // 
            // tpRelatedProducts
            // 
            this.tpRelatedProducts.Controls.Add(this.clbProducts);
            this.tpRelatedProducts.Location = new System.Drawing.Point(4, 25);
            this.tpRelatedProducts.Name = "tpRelatedProducts";
            this.tpRelatedProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tpRelatedProducts.Size = new System.Drawing.Size(568, 264);
            this.tpRelatedProducts.TabIndex = 1;
            this.tpRelatedProducts.Text = "RelatedProducts";
            this.tpRelatedProducts.UseVisualStyleBackColor = true;
            // 
            // clbProducts
            // 
            this.clbProducts.FormattingEnabled = true;
            this.clbProducts.Location = new System.Drawing.Point(0, 3);
            this.clbProducts.Name = "clbProducts";
            this.clbProducts.Size = new System.Drawing.Size(568, 259);
            this.clbProducts.TabIndex = 0;
            // 
            // EditPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 294);
            this.Controls.Add(this.tabControl1);
            this.Name = "EditPost";
            this.Text = "EditPost";
            this.tabControl1.ResumeLayout(false);
            this.tpInfo.ResumeLayout(false);
            this.tpInfo.PerformLayout();
            this.tpRelatedProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpInfo;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPostID;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPostID;
        private System.Windows.Forms.TabPage tpRelatedProducts;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource bsProducts;
        private System.Windows.Forms.CheckedListBox clbProducts;
    }
}