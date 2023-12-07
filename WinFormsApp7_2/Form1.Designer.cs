namespace WinFormsApp7_2
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
            label1 = new Label();
            label2 = new Label();
            nameList = new ListBox();
            phoneNumber = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 78);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "名前";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(327, 78);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "電話番号";
            // 
            // nameList
            // 
            nameList.FormattingEnabled = true;
            nameList.ItemHeight = 20;
            nameList.Location = new Point(66, 112);
            nameList.Name = "nameList";
            nameList.Size = new Size(175, 144);
            nameList.TabIndex = 2;
            // 
            // phoneNumber
            // 
            phoneNumber.Enabled = false;
            phoneNumber.Location = new Point(327, 112);
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(201, 27);
            phoneNumber.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 356);
            Controls.Add(phoneNumber);
            Controls.Add(nameList);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox nameList;
        private TextBox phoneNumber;
    }
}