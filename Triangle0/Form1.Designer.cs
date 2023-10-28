namespace Triangle0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ResultButton = new Button();
            Label1 = new Label();
            Label2 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            Label5 = new Label();
            ABox = new TextBox();
            BBox = new TextBox();
            CBox = new TextBox();
            LabelResult = new Label();
            SuspendLayout();
            // 
            // ResultButton
            // 
            ResultButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ResultButton.BackColor = SystemColors.ControlDarkDark;
            ResultButton.Font = new Font("GOST Type BU", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point);
            ResultButton.ForeColor = SystemColors.ButtonHighlight;
            ResultButton.Location = new Point(359, 397);
            ResultButton.Name = "ResultButton";
            ResultButton.Size = new Size(387, 101);
            ResultButton.TabIndex = 0;
            ResultButton.Text = "Выполнить проверку";
            ResultButton.UseVisualStyleBackColor = false;
            ResultButton.Click += ResultButton_Click;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Top;
            Label1.AutoSize = true;
            Label1.BackColor = Color.Transparent;
            Label1.Font = new Font("Rousseau Deco", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.ForeColor = SystemColors.ControlDarkDark;
            Label1.Location = new Point(108, 51);
            Label1.MinimumSize = new Size(200, 100);
            Label1.Name = "Label1";
            Label1.Size = new Size(820, 100);
            Label1.TabIndex = 1;
            Label1.Text = "Является ли треугольник равносторонним?";
            // 
            // Label2
            // 
            Label2.Anchor = AnchorStyles.Top;
            Label2.AutoSize = true;
            Label2.BackColor = Color.Transparent;
            Label2.Font = new Font("GOST Type BU", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.ForeColor = SystemColors.ControlDarkDark;
            Label2.Location = new Point(48, 110);
            Label2.Name = "Label2";
            Label2.Size = new Size(957, 27);
            Label2.TabIndex = 2;
            Label2.Text = "Чтобы узнать ответ на этот вопрос - введите три числа равные длине сторон треугольника:";
            // 
            // Label3
            // 
            Label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Label3.AutoSize = true;
            Label3.BackColor = Color.Transparent;
            Label3.Font = new Font("GOST Type BU", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            Label3.ForeColor = SystemColors.ControlDarkDark;
            Label3.Location = new Point(359, 215);
            Label3.Name = "Label3";
            Label3.Size = new Size(192, 27);
            Label3.TabIndex = 3;
            Label3.Text = "Размер стороны A";
            // 
            // Label4
            // 
            Label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Label4.AutoSize = true;
            Label4.BackColor = Color.Transparent;
            Label4.Font = new Font("GOST Type BU", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            Label4.ForeColor = SystemColors.ControlDarkDark;
            Label4.Location = new Point(359, 256);
            Label4.Name = "Label4";
            Label4.Size = new Size(191, 27);
            Label4.TabIndex = 4;
            Label4.Text = "Размер стороны B";
            // 
            // Label5
            // 
            Label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Label5.AutoSize = true;
            Label5.BackColor = Color.Transparent;
            Label5.Font = new Font("GOST Type BU", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            Label5.ForeColor = SystemColors.ControlDarkDark;
            Label5.Location = new Point(359, 297);
            Label5.Name = "Label5";
            Label5.Size = new Size(189, 27);
            Label5.TabIndex = 5;
            Label5.Text = "Размер стороны C";
            // 
            // ABox
            // 
            ABox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ABox.Font = new Font("GOST Type BU", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            ABox.Location = new Point(566, 207);
            ABox.Name = "ABox";
            ABox.Size = new Size(180, 35);
            ABox.TabIndex = 6;
            // 
            // BBox
            // 
            BBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BBox.Font = new Font("GOST Type BU", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            BBox.Location = new Point(566, 248);
            BBox.Name = "BBox";
            BBox.Size = new Size(180, 35);
            BBox.TabIndex = 7;
            // 
            // CBox
            // 
            CBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CBox.Font = new Font("GOST Type BU", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            CBox.Location = new Point(566, 289);
            CBox.Name = "CBox";
            CBox.Size = new Size(180, 35);
            CBox.TabIndex = 8;
            // 
            // LabelResult
            // 
            LabelResult.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LabelResult.AutoSize = true;
            LabelResult.Font = new Font("GOST Type BU", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            LabelResult.Location = new Point(317, 481);
            LabelResult.Name = "LabelResult";
            LabelResult.Size = new Size(0, 27);
            LabelResult.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.photo_1575459255526_f514e7a42f3c;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1048, 660);
            Controls.Add(LabelResult);
            Controls.Add(CBox);
            Controls.Add(BBox);
            Controls.Add(ABox);
            Controls.Add(Label5);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(ResultButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(200, 350);
            Name = "Form1";
            Text = "Какой это треугольник?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ResultButton;
        private Label Label1;
        private Label Label2;
        private Label Label3;
        private Label Label4;
        private Label Label5;
        private TextBox ABox;
        private TextBox BBox;
        private TextBox CBox;
        private Label LabelResult;
    }
}