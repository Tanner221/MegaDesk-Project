namespace MegaDesk
{
    partial class AddQuote
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.num_Width = new System.Windows.Forms.NumericUpDown();
            this.num_Depth = new System.Windows.Forms.NumericUpDown();
            this.label_width = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.num_Drawers = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_Material = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_Order = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Depth)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Drawers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(542, 576);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 69);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 576);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "Get Quote";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "New Quote";
            // 
            // num_Width
            // 
            this.num_Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_Width.Location = new System.Drawing.Point(213, 47);
            this.num_Width.Name = "num_Width";
            this.num_Width.Size = new System.Drawing.Size(120, 44);
            this.num_Width.TabIndex = 3;
            // 
            // num_Depth
            // 
            this.num_Depth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_Depth.Location = new System.Drawing.Point(213, 134);
            this.num_Depth.Name = "num_Depth";
            this.num_Depth.Size = new System.Drawing.Size(120, 44);
            this.num_Depth.TabIndex = 4;
            // 
            // label_width
            // 
            this.label_width.AutoSize = true;
            this.label_width.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_width.Location = new System.Drawing.Point(20, 51);
            this.label_width.Name = "label_width";
            this.label_width.Size = new System.Drawing.Size(100, 37);
            this.label_width.TabIndex = 5;
            this.label_width.Text = "Width";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.num_Width);
            this.groupBox1.Controls.Add(this.num_Depth);
            this.groupBox1.Controls.Add(this.label_width);
            this.groupBox1.Location = new System.Drawing.Point(65, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 216);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desk Dimensions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Depth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customer Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(427, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 44);
            this.textBox1.TabIndex = 8;
            // 
            // num_Drawers
            // 
            this.num_Drawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_Drawers.Location = new System.Drawing.Point(683, 236);
            this.num_Drawers.Name = "num_Drawers";
            this.num_Drawers.Size = new System.Drawing.Size(120, 44);
            this.num_Drawers.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(518, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 37);
            this.label4.TabIndex = 9;
            this.label4.Text = "Drawers";
            // 
            // combo_Material
            // 
            this.combo_Material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Material.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Material.FormattingEnabled = true;
            this.combo_Material.Location = new System.Drawing.Point(683, 305);
            this.combo_Material.Name = "combo_Material";
            this.combo_Material.Size = new System.Drawing.Size(233, 45);
            this.combo_Material.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(524, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "Material";
            // 
            // combo_Order
            // 
            this.combo_Order.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Order.FormattingEnabled = true;
            this.combo_Order.Items.AddRange(new object[] {
            "No Rush",
            "Rush - 3 Days",
            "Rush - 5 Days",
            "Rush - 7 Days"});
            this.combo_Order.Location = new System.Drawing.Point(683, 381);
            this.combo_Order.Name = "combo_Order";
            this.combo_Order.Size = new System.Drawing.Size(233, 45);
            this.combo_Order.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(555, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 37);
            this.label6.TabIndex = 13;
            this.label6.Text = "Order";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 729);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.combo_Order);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combo_Material);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.num_Drawers);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.num_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Depth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Drawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_Width;
        private System.Windows.Forms.NumericUpDown num_Depth;
        private System.Windows.Forms.Label label_width;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown num_Drawers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_Material;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_Order;
        private System.Windows.Forms.Label label6;
    }
}