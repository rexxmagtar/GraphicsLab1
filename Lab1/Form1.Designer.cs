
namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ColorPicker = new System.Windows.Forms.ColorDialog();
            this.ColorPickerButton = new System.Windows.Forms.Button();
            this.C_Input = new System.Windows.Forms.NumericUpDown();
            this.M_Input = new System.Windows.Forms.NumericUpDown();
            this.Y_Input = new System.Windows.Forms.NumericUpDown();
            this.K_Input = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Z_Input = new System.Windows.Forms.NumericUpDown();
            this.YY_input = new System.Windows.Forms.NumericUpDown();
            this.X_input = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.L_Input = new System.Windows.Forms.NumericUpDown();
            this.S_Input = new System.Windows.Forms.NumericUpDown();
            this.H_Input = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.C_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.K_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YY_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.S_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_Input)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorPickerButton
            // 
            this.ColorPickerButton.Location = new System.Drawing.Point(45, 50);
            this.ColorPickerButton.Name = "ColorPickerButton";
            this.ColorPickerButton.Size = new System.Drawing.Size(130, 23);
            this.ColorPickerButton.TabIndex = 0;
            this.ColorPickerButton.Text = "Pick color";
            this.ColorPickerButton.UseVisualStyleBackColor = true;
            this.ColorPickerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // C_Input
            // 
            this.C_Input.Location = new System.Drawing.Point(264, 171);
            this.C_Input.Name = "C_Input";
            this.C_Input.Size = new System.Drawing.Size(120, 22);
            this.C_Input.TabIndex = 1;
            this.C_Input.ValueChanged += new System.EventHandler(this.CMYK_Input_ValueChanged);
            // 
            // M_Input
            // 
            this.M_Input.Location = new System.Drawing.Point(264, 239);
            this.M_Input.Name = "M_Input";
            this.M_Input.Size = new System.Drawing.Size(120, 22);
            this.M_Input.TabIndex = 2;
            this.M_Input.ValueChanged += new System.EventHandler(this.CMYK_Input_ValueChanged);
            // 
            // Y_Input
            // 
            this.Y_Input.Location = new System.Drawing.Point(264, 306);
            this.Y_Input.Name = "Y_Input";
            this.Y_Input.Size = new System.Drawing.Size(120, 22);
            this.Y_Input.TabIndex = 3;
            this.Y_Input.ValueChanged += new System.EventHandler(this.CMYK_Input_ValueChanged);
            // 
            // K_Input
            // 
            this.K_Input.Location = new System.Drawing.Point(264, 352);
            this.K_Input.Name = "K_Input";
            this.K_Input.Size = new System.Drawing.Size(120, 22);
            this.K_Input.TabIndex = 4;
            this.K_Input.ValueChanged += new System.EventHandler(this.CMYK_Input_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "M";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "K";
            // 
            // Z_Input
            // 
            this.Z_Input.DecimalPlaces = 1;
            this.Z_Input.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Z_Input.Location = new System.Drawing.Point(570, 306);
            this.Z_Input.Maximum = new decimal(new int[] {
            110,
            0,
            0,
            0});
            this.Z_Input.Name = "Z_Input";
            this.Z_Input.Size = new System.Drawing.Size(120, 22);
            this.Z_Input.TabIndex = 11;
            this.Z_Input.ValueChanged += new System.EventHandler(this.XYZ_Input_ValueChanged);
            // 
            // YY_input
            // 
            this.YY_input.DecimalPlaces = 1;
            this.YY_input.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.YY_input.Location = new System.Drawing.Point(570, 238);
            this.YY_input.Maximum = new decimal(new int[] {
            110,
            0,
            0,
            0});
            this.YY_input.Name = "YY_input";
            this.YY_input.Size = new System.Drawing.Size(120, 22);
            this.YY_input.TabIndex = 10;
            this.YY_input.ValueChanged += new System.EventHandler(this.XYZ_Input_ValueChanged);
            // 
            // X_input
            // 
            this.X_input.DecimalPlaces = 1;
            this.X_input.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.X_input.Location = new System.Drawing.Point(570, 170);
            this.X_input.Maximum = new decimal(new int[] {
            110,
            0,
            0,
            0});
            this.X_input.Name = "X_input";
            this.X_input.Size = new System.Drawing.Size(120, 22);
            this.X_input.TabIndex = 9;
            this.X_input.ValueChanged += new System.EventHandler(this.XYZ_Input_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Z";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(532, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "X";
            // 
            // L_Input
            // 
            this.L_Input.Location = new System.Drawing.Point(785, 305);
            this.L_Input.Name = "L_Input";
            this.L_Input.Size = new System.Drawing.Size(120, 22);
            this.L_Input.TabIndex = 17;
            this.L_Input.ValueChanged += new System.EventHandler(this.HSL_Input_ValueChanged);
            // 
            // S_Input
            // 
            this.S_Input.Location = new System.Drawing.Point(785, 238);
            this.S_Input.Name = "S_Input";
            this.S_Input.Size = new System.Drawing.Size(120, 22);
            this.S_Input.TabIndex = 16;
            this.S_Input.ValueChanged += new System.EventHandler(this.HSL_Input_ValueChanged);
            // 
            // H_Input
            // 
            this.H_Input.Location = new System.Drawing.Point(785, 170);
            this.H_Input.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.H_Input.Name = "H_Input";
            this.H_Input.Size = new System.Drawing.Size(120, 22);
            this.H_Input.TabIndex = 15;
            this.H_Input.ValueChanged += new System.EventHandler(this.HSL_Input_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(744, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "L";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(744, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "S";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(744, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "H";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 582);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.L_Input);
            this.Controls.Add(this.S_Input);
            this.Controls.Add(this.H_Input);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Z_Input);
            this.Controls.Add(this.YY_input);
            this.Controls.Add(this.X_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.K_Input);
            this.Controls.Add(this.Y_Input);
            this.Controls.Add(this.M_Input);
            this.Controls.Add(this.C_Input);
            this.Controls.Add(this.ColorPickerButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.C_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.K_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YY_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.S_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.H_Input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog ColorPicker;
        private System.Windows.Forms.Button ColorPickerButton;
        private System.Windows.Forms.NumericUpDown C_Input;
        private System.Windows.Forms.NumericUpDown M_Input;
        private System.Windows.Forms.NumericUpDown Y_Input;
        private System.Windows.Forms.NumericUpDown K_Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Z_Input;
        private System.Windows.Forms.NumericUpDown YY_input;
        private System.Windows.Forms.NumericUpDown X_input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown L_Input;
        private System.Windows.Forms.NumericUpDown S_Input;
        private System.Windows.Forms.NumericUpDown H_Input;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

