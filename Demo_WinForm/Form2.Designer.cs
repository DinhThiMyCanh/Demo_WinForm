
namespace Demo_WinForm
{
    partial class frmMain
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
            this.btnMayTinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMayTinh
            // 
            this.btnMayTinh.Location = new System.Drawing.Point(12, 12);
            this.btnMayTinh.Name = "btnMayTinh";
            this.btnMayTinh.Size = new System.Drawing.Size(228, 109);
            this.btnMayTinh.TabIndex = 0;
            this.btnMayTinh.Text = "Máy tính";
            this.btnMayTinh.UseVisualStyleBackColor = true;
            this.btnMayTinh.Click += new System.EventHandler(this.btnMayTinh_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(697, 405);
            this.Controls.Add(this.btnMayTinh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmMain";
            this.Text = "CÁC ỨNG DỤNG ĐƠN GIẢN";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMayTinh;
    }
}