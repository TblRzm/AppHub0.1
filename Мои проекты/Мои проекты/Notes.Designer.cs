
namespace Мои_проекты
{
    partial class Notes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notes));
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtnEnt = new System.Windows.Forms.Button();
            this.BtnClrLst = new System.Windows.Forms.Button();
            this.BtnClrAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(251, 381);
            this.listBox2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(284, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите данные:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(284, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 20);
            this.textBox2.TabIndex = 3;
            // 
            // BtnEnt
            // 
            this.BtnEnt.BackColor = System.Drawing.Color.Coral;
            this.BtnEnt.FlatAppearance.BorderSize = 0;
            this.BtnEnt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEnt.Location = new System.Drawing.Point(301, 134);
            this.BtnEnt.Name = "BtnEnt";
            this.BtnEnt.Size = new System.Drawing.Size(100, 50);
            this.BtnEnt.TabIndex = 4;
            this.BtnEnt.Text = "Ввод";
            this.BtnEnt.UseVisualStyleBackColor = false;
            this.BtnEnt.Click += new System.EventHandler(this.BtnEnt_Click);
            // 
            // BtnClrLst
            // 
            this.BtnClrLst.BackColor = System.Drawing.Color.Coral;
            this.BtnClrLst.FlatAppearance.BorderSize = 0;
            this.BtnClrLst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClrLst.Location = new System.Drawing.Point(301, 268);
            this.BtnClrLst.Name = "BtnClrLst";
            this.BtnClrLst.Size = new System.Drawing.Size(100, 25);
            this.BtnClrLst.TabIndex = 5;
            this.BtnClrLst.Text = "Очистить";
            this.BtnClrLst.UseVisualStyleBackColor = false;
            this.BtnClrLst.Click += new System.EventHandler(this.BtnClrLst_Click);
            // 
            // BtnClrAll
            // 
            this.BtnClrAll.BackColor = System.Drawing.Color.Coral;
            this.BtnClrAll.FlatAppearance.BorderSize = 0;
            this.BtnClrAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClrAll.Location = new System.Drawing.Point(301, 316);
            this.BtnClrAll.Name = "BtnClrAll";
            this.BtnClrAll.Size = new System.Drawing.Size(100, 25);
            this.BtnClrAll.TabIndex = 6;
            this.BtnClrAll.Text = "Очистить всё";
            this.BtnClrAll.UseVisualStyleBackColor = false;
            this.BtnClrAll.Click += new System.EventHandler(this.BtnClrAll_Click);
            // 
            // Notes
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.BtnClrAll);
            this.Controls.Add(this.BtnClrLst);
            this.Controls.Add(this.BtnEnt);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Notes";
            this.Text = "Записная книжка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BtnEnt;
        private System.Windows.Forms.Button BtnClrLst;
        private System.Windows.Forms.Button BtnClrAll;
    }
}