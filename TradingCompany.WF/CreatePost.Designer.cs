namespace TradingCompany.WF
{
    partial class CreatePost
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
            this.bsProducts = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpInfo = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tpRelatedProducts = new System.Windows.Forms.TabPage();
            this.clbProducts = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpInfo.SuspendLayout();
            this.tpRelatedProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpInfo);
            this.tabControl1.Controls.Add(this.tpRelatedProducts);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(515, 262);
            this.tabControl1.TabIndex = 12;
            // 
            // tpInfo
            // 
            this.tpInfo.Controls.Add(this.btnCancel);
            this.tpInfo.Controls.Add(this.btnCreate);
            this.tpInfo.Controls.Add(this.txtContent);
            this.tpInfo.Controls.Add(this.txtTitle);
            this.tpInfo.Controls.Add(this.lblContent);
            this.tpInfo.Controls.Add(this.lblTitle);
            this.tpInfo.Location = new System.Drawing.Point(4, 25);
            this.tpInfo.Name = "tpInfo";
            this.tpInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpInfo.Size = new System.Drawing.Size(507, 233);
            this.tpInfo.TabIndex = 0;
            this.tpInfo.Text = "Info";
            this.tpInfo.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnCancel.Location = new System.Drawing.Point(102, 164);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 39);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnCreate.Location = new System.Drawing.Point(266, 164);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(121, 39);
            this.btnCreate.TabIndex = 16;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtContent.Location = new System.Drawing.Point(192, 90);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(263, 34);
            this.txtContent.TabIndex = 15;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtTitle.Location = new System.Drawing.Point(192, 30);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(263, 34);
            this.txtTitle.TabIndex = 14;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblContent.Location = new System.Drawing.Point(38, 93);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(96, 29);
            this.lblContent.TabIndex = 13;
            this.lblContent.Text = "Content";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTitle.Location = new System.Drawing.Point(38, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(61, 29);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Title";
            // 
            // tpRelatedProducts
            // 
            this.tpRelatedProducts.Controls.Add(this.clbProducts);
            this.tpRelatedProducts.Location = new System.Drawing.Point(4, 25);
            this.tpRelatedProducts.Name = "tpRelatedProducts";
            this.tpRelatedProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tpRelatedProducts.Size = new System.Drawing.Size(507, 233);
            this.tpRelatedProducts.TabIndex = 1;
            this.tpRelatedProducts.Text = "Related products";
            this.tpRelatedProducts.UseVisualStyleBackColor = true;
            // 
            // clbProducts
            // 
            this.clbProducts.FormattingEnabled = true;
            this.clbProducts.Location = new System.Drawing.Point(0, 16);
            this.clbProducts.Name = "clbProducts";
            this.clbProducts.Size = new System.Drawing.Size(504, 208);
            this.clbProducts.TabIndex = 0;
            // 
            // CreatePost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 261);
            this.Controls.Add(this.tabControl1);
            this.Name = "CreatePost";
            this.Text = "CreatePost";
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpInfo.ResumeLayout(false);
            this.tpInfo.PerformLayout();
            this.tpRelatedProducts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsProducts;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpInfo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabPage tpRelatedProducts;
        private System.Windows.Forms.CheckedListBox clbProducts;
    }
}