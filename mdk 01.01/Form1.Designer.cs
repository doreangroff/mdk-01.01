namespace mdk_01._01
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
            this.data_class = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_class)).BeginInit();
            this.SuspendLayout();
            // 
            // data_class
            // 
            this.data_class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_class.Location = new System.Drawing.Point(121, 32);
            this.data_class.Name = "data_class";
            this.data_class.RowTemplate.Height = 25;
            this.data_class.Size = new System.Drawing.Size(503, 296);
            this.data_class.TabIndex = 0;
            this.data_class.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_class_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.data_class);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.data_class)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView data_class;
    }
}