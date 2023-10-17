namespace WinFormsApp
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
            inputButton = new Button();
            findButton = new Button();
            printButton = new Button();
            exitButton = new Button();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // inputButton
            // 
            inputButton.AccessibleName = "input and edit";
            inputButton.Location = new Point(295, 141);
            inputButton.Name = "inputButton";
            inputButton.Size = new Size(188, 23);
            inputButton.TabIndex = 0;
            inputButton.Text = "ввод и редактирование данных";
            inputButton.UseVisualStyleBackColor = true;
            inputButton.Click += inputButton_Click_1;
            // 
            // findButton
            // 
            findButton.AccessibleName = "find and sort";
            findButton.Location = new Point(295, 180);
            findButton.Name = "findButton";
            findButton.Size = new Size(188, 23);
            findButton.TabIndex = 1;
            findButton.Text = "поиск и сортировка данных";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click_1;
            // 
            // printButton
            // 
            printButton.AccessibleName = "print";
            printButton.Location = new Point(295, 221);
            printButton.Name = "printButton";
            printButton.Size = new Size(188, 23);
            printButton.TabIndex = 2;
            printButton.Text = "режим печати";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click_1;
            // 
            // exitButton
            // 
            exitButton.AccessibleName = "exit";
            exitButton.Location = new Point(295, 262);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(188, 23);
            exitButton.TabIndex = 3;
            exitButton.Text = "выход";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 103);
            label1.Name = "label1";
            label1.Size = new Size(219, 15);
            label1.TabIndex = 4;
            label1.Text = "Досье подготовительного отделения»:";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(528, 141);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(exitButton);
            Controls.Add(printButton);
            Controls.Add(findButton);
            Controls.Add(inputButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button inputButton;
        private Button findButton;
        private Button printButton;
        private Button exitButton;
        private Label label1;
        private Button button1;
    }
}