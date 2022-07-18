
namespace Мои_проекты
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.lblfirst = new System.Windows.Forms.Label();
            this.lblsecond = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.Label();
            this.txtfirst = new System.Windows.Forms.TextBox();
            this.txtsecond = new System.Windows.Forms.TextBox();
            this.divide = new System.Windows.Forms.Button();
            this.Increasement = new System.Windows.Forms.Button();
            this.decrement = new System.Windows.Forms.Button();
            this.increment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblfirst
            // 
            this.lblfirst.AutoSize = true;
            this.lblfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblfirst.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblfirst.Location = new System.Drawing.Point(12, 43);
            this.lblfirst.Name = "lblfirst";
            this.lblfirst.Size = new System.Drawing.Size(103, 16);
            this.lblfirst.TabIndex = 0;
            this.lblfirst.Text = "Первое число:";
            this.lblfirst.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblsecond
            // 
            this.lblsecond.AutoSize = true;
            this.lblsecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblsecond.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblsecond.Location = new System.Drawing.Point(14, 103);
            this.lblsecond.Name = "lblsecond";
            this.lblsecond.Size = new System.Drawing.Size(101, 16);
            this.lblsecond.TabIndex = 1;
            this.lblsecond.Text = "Второе число:";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblresult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblresult.Location = new System.Drawing.Point(13, 238);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(93, 20);
            this.lblresult.TabIndex = 3;
            this.lblresult.Text = "Результат:";
            this.lblresult.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtresult
            // 
            this.txtresult.AutoSize = true;
            this.txtresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtresult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtresult.Location = new System.Drawing.Point(37, 283);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(20, 24);
            this.txtresult.TabIndex = 4;
            this.txtresult.Text = "0";
            // 
            // txtfirst
            // 
            this.txtfirst.Location = new System.Drawing.Point(132, 42);
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(144, 20);
            this.txtfirst.TabIndex = 5;
            this.txtfirst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            this.txtfirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // txtsecond
            // 
            this.txtsecond.Location = new System.Drawing.Point(132, 102);
            this.txtsecond.Name = "txtsecond";
            this.txtsecond.Size = new System.Drawing.Size(144, 20);
            this.txtsecond.TabIndex = 6;
            this.txtsecond.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            this.txtsecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.Coral;
            this.divide.FlatAppearance.BorderSize = 0;
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divide.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divide.ForeColor = System.Drawing.SystemColors.ControlText;
            this.divide.Location = new System.Drawing.Point(226, 167);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(50, 50);
            this.divide.TabIndex = 7;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.btn_click);
            // 
            // Increasement
            // 
            this.Increasement.BackColor = System.Drawing.Color.Coral;
            this.Increasement.FlatAppearance.BorderSize = 0;
            this.Increasement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Increasement.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Increasement.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Increasement.Location = new System.Drawing.Point(162, 167);
            this.Increasement.Name = "Increasement";
            this.Increasement.Size = new System.Drawing.Size(50, 50);
            this.Increasement.TabIndex = 8;
            this.Increasement.Text = "x";
            this.Increasement.UseVisualStyleBackColor = false;
            this.Increasement.Click += new System.EventHandler(this.btn_click);
            // 
            // decrement
            // 
            this.decrement.BackColor = System.Drawing.Color.Coral;
            this.decrement.FlatAppearance.BorderSize = 0;
            this.decrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decrement.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decrement.ForeColor = System.Drawing.SystemColors.ControlText;
            this.decrement.Location = new System.Drawing.Point(92, 167);
            this.decrement.Name = "decrement";
            this.decrement.Size = new System.Drawing.Size(50, 50);
            this.decrement.TabIndex = 9;
            this.decrement.Text = "-";
            this.decrement.UseVisualStyleBackColor = false;
            this.decrement.Click += new System.EventHandler(this.btn_click);
            // 
            // increment
            // 
            this.increment.BackColor = System.Drawing.Color.Coral;
            this.increment.FlatAppearance.BorderSize = 0;
            this.increment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.increment.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.increment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.increment.Location = new System.Drawing.Point(27, 167);
            this.increment.Name = "increment";
            this.increment.Size = new System.Drawing.Size(50, 50);
            this.increment.TabIndex = 10;
            this.increment.Text = "+";
            this.increment.UseVisualStyleBackColor = false;
            this.increment.Click += new System.EventHandler(this.btn_click);
            // 
            // Calculator
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(299, 333);
            this.Controls.Add(this.increment);
            this.Controls.Add(this.decrement);
            this.Controls.Add(this.Increasement);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.txtsecond);
            this.Controls.Add(this.txtfirst);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblsecond);
            this.Controls.Add(this.lblfirst);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.Text = "AH Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblfirst;
        private System.Windows.Forms.Label lblsecond;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Label txtresult;
        private System.Windows.Forms.TextBox txtfirst;
        private System.Windows.Forms.TextBox txtsecond;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button Increasement;
        private System.Windows.Forms.Button decrement;
        private System.Windows.Forms.Button increment;
    }
}