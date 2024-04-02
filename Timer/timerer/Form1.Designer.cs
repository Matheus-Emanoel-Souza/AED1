namespace timerer
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            btn_iniciar = new Label();
            btn_2 = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(36, 119);
            button1.Name = "button1";
            button1.Size = new Size(151, 64);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(434, 119);
            button2.Name = "button2";
            button2.Size = new Size(151, 64);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btn_iniciar
            // 
            btn_iniciar.AutoSize = true;
            btn_iniciar.Location = new Point(90, 240);
            btn_iniciar.Name = "btn_iniciar";
            btn_iniciar.Size = new Size(38, 15);
            btn_iniciar.TabIndex = 2;
            btn_iniciar.Text = "Inicial";
            // 
            // btn_2
            // 
            btn_2.AutoSize = true;
            btn_2.Location = new Point(505, 240);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(50, 15);
            btn_2.TabIndex = 3;
            btn_2.Text = "Finalizar";
            btn_2.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 450);
            Controls.Add(btn_2);
            Controls.Add(btn_iniciar);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button button2;
        private Label btn_iniciar;
        private Label btn_2;
    }
}
