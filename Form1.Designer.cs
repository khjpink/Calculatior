namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
         
        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.display = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Add = new System.Windows.Forms.Button();
            this.ButtonDot = new System.Windows.Forms.Button();
            this.ButtonZero = new System.Windows.Forms.Button();
            this.None = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.ButtonThree = new System.Windows.Forms.Button();
            this.ButtonTwo = new System.Windows.Forms.Button();
            this.ButtonOne = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.ButtonSix = new System.Windows.Forms.Button();
            this.ButtonFive = new System.Windows.Forms.Button();
            this.ButtonFour = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.ButtonNine = new System.Windows.Forms.Button();
            this.ButtonEight = new System.Windows.Forms.Button();
            this.ButtonSeven = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Dock = System.Windows.Forms.DockStyle.Top;
            this.display.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.display.Location = new System.Drawing.Point(0, 0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(309, 51);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Controls.Add(this.Add, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.ButtonDot, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.ButtonZero, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.None, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.Subtract, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.ButtonThree, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.ButtonTwo, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.ButtonOne, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.Multiply, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.ButtonSix, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.ButtonFive, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.ButtonFour, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.Divide, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.ButtonNine, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.ButtonEight, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.ButtonSeven, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(5, 66);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(296, 310);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Add.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Add.Location = new System.Drawing.Point(225, 234);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(67, 71);
            this.Add.TabIndex = 17;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonDot
            // 
            this.ButtonDot.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonDot.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonDot.Location = new System.Drawing.Point(151, 234);
            this.ButtonDot.Name = "ButtonDot";
            this.ButtonDot.Size = new System.Drawing.Size(67, 71);
            this.ButtonDot.TabIndex = 16;
            this.ButtonDot.Text = ".";
            this.ButtonDot.UseVisualStyleBackColor = false;
            this.ButtonDot.Click += new System.EventHandler(this.ButtonDot_Click);
            // 
            // ButtonZero
            // 
            this.ButtonZero.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonZero.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonZero.Location = new System.Drawing.Point(77, 234);
            this.ButtonZero.Name = "ButtonZero";
            this.ButtonZero.Size = new System.Drawing.Size(67, 71);
            this.ButtonZero.TabIndex = 15;
            this.ButtonZero.Text = "0";
            this.ButtonZero.UseVisualStyleBackColor = false;
            this.ButtonZero.Click += new System.EventHandler(this.ButtonZero_Click);
            // 
            // None
            // 
            this.None.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.None.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.None.Location = new System.Drawing.Point(3, 234);
            this.None.Name = "None";
            this.None.Size = new System.Drawing.Size(67, 71);
            this.None.TabIndex = 14;
            this.None.Text = "AC";
            this.None.UseVisualStyleBackColor = false;
            this.None.Click += new System.EventHandler(this.ButtonNone_Click);
            // 
            // Subtract
            // 
            this.Subtract.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Subtract.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Subtract.Location = new System.Drawing.Point(225, 157);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(67, 71);
            this.Subtract.TabIndex = 13;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = false;
            this.Subtract.Click += new System.EventHandler(this.ButtonSubtract_Click);
            // 
            // ButtonThree
            // 
            this.ButtonThree.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonThree.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonThree.Location = new System.Drawing.Point(151, 157);
            this.ButtonThree.Name = "ButtonThree";
            this.ButtonThree.Size = new System.Drawing.Size(67, 71);
            this.ButtonThree.TabIndex = 12;
            this.ButtonThree.Text = "3";
            this.ButtonThree.UseVisualStyleBackColor = false;
            this.ButtonThree.Click += new System.EventHandler(this.ButtonThree_Click);
            // 
            // ButtonTwo
            // 
            this.ButtonTwo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonTwo.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonTwo.Location = new System.Drawing.Point(77, 157);
            this.ButtonTwo.Name = "ButtonTwo";
            this.ButtonTwo.Size = new System.Drawing.Size(67, 71);
            this.ButtonTwo.TabIndex = 11;
            this.ButtonTwo.Text = "2";
            this.ButtonTwo.UseVisualStyleBackColor = false;
            this.ButtonTwo.Click += new System.EventHandler(this.ButtonTwo_Click);
            // 
            // ButtonOne
            // 
            this.ButtonOne.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonOne.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonOne.Location = new System.Drawing.Point(3, 157);
            this.ButtonOne.Name = "ButtonOne";
            this.ButtonOne.Size = new System.Drawing.Size(67, 71);
            this.ButtonOne.TabIndex = 10;
            this.ButtonOne.Text = "1";
            this.ButtonOne.UseVisualStyleBackColor = false;
            this.ButtonOne.Click += new System.EventHandler(this.ButtonOne_Click);
            // 
            // Multiply
            // 
            this.Multiply.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Multiply.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Multiply.Location = new System.Drawing.Point(225, 80);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(67, 71);
            this.Multiply.TabIndex = 9;
            this.Multiply.Text = "×";
            this.Multiply.UseVisualStyleBackColor = false;
            this.Multiply.Click += new System.EventHandler(this.ButtonMultiply_Click);
            // 
            // ButtonSix
            // 
            this.ButtonSix.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonSix.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonSix.Location = new System.Drawing.Point(151, 80);
            this.ButtonSix.Name = "ButtonSix";
            this.ButtonSix.Size = new System.Drawing.Size(67, 71);
            this.ButtonSix.TabIndex = 8;
            this.ButtonSix.Text = "6";
            this.ButtonSix.UseVisualStyleBackColor = false;
            this.ButtonSix.Click += new System.EventHandler(this.ButtonSix_Click);
            // 
            // ButtonFive
            // 
            this.ButtonFive.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonFive.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonFive.Location = new System.Drawing.Point(77, 80);
            this.ButtonFive.Name = "ButtonFive";
            this.ButtonFive.Size = new System.Drawing.Size(67, 71);
            this.ButtonFive.TabIndex = 7;
            this.ButtonFive.Text = "5";
            this.ButtonFive.UseVisualStyleBackColor = false;
            this.ButtonFive.Click += new System.EventHandler(this.ButtonFive_Click);
            // 
            // ButtonFour
            // 
            this.ButtonFour.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonFour.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonFour.Location = new System.Drawing.Point(3, 80);
            this.ButtonFour.Name = "ButtonFour";
            this.ButtonFour.Size = new System.Drawing.Size(67, 71);
            this.ButtonFour.TabIndex = 6;
            this.ButtonFour.Text = "4";
            this.ButtonFour.UseVisualStyleBackColor = false;
            this.ButtonFour.Click += new System.EventHandler(this.ButtonFour_Click);
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Divide.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Divide.Location = new System.Drawing.Point(225, 3);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(67, 71);
            this.Divide.TabIndex = 5;
            this.Divide.Text = "÷";
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.Click += new System.EventHandler(this.ButtonDivide_Click);
            // 
            // ButtonNine
            // 
            this.ButtonNine.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonNine.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonNine.Location = new System.Drawing.Point(151, 3);
            this.ButtonNine.Name = "ButtonNine";
            this.ButtonNine.Size = new System.Drawing.Size(67, 71);
            this.ButtonNine.TabIndex = 4;
            this.ButtonNine.Text = "9";
            this.ButtonNine.UseVisualStyleBackColor = false;
            this.ButtonNine.Click += new System.EventHandler(this.ButtonNine_Click);
            // 
            // ButtonEight
            // 
            this.ButtonEight.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonEight.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonEight.Location = new System.Drawing.Point(77, 3);
            this.ButtonEight.Name = "ButtonEight";
            this.ButtonEight.Size = new System.Drawing.Size(67, 71);
            this.ButtonEight.TabIndex = 3;
            this.ButtonEight.Text = "8";
            this.ButtonEight.UseVisualStyleBackColor = false;
            this.ButtonEight.Click += new System.EventHandler(this.ButtonEight_Click);
            // 
            // ButtonSeven
            // 
            this.ButtonSeven.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonSeven.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonSeven.Location = new System.Drawing.Point(3, 3);
            this.ButtonSeven.Name = "ButtonSeven";
            this.ButtonSeven.Size = new System.Drawing.Size(67, 71);
            this.ButtonSeven.TabIndex = 2;
            this.ButtonSeven.Text = "7";
            this.ButtonSeven.UseVisualStyleBackColor = false;
            this.ButtonSeven.Click += new System.EventHandler(this.ButtonSeven_Click);
            // 
            // Result
            // 
            this.Result.AllowDrop = true;
            this.Result.AutoSize = true;
            this.Result.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Result.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Result.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Result.Location = new System.Drawing.Point(0, 381);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(309, 53);
            this.Result.TabIndex = 2;
            this.Result.Text = "=";
            this.Result.UseVisualStyleBackColor = false;
            this.Result.Click += new System.EventHandler(this.ButtonResult_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(309, 434);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "계산기";
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label display;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button ButtonSeven;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button ButtonDot;
        private System.Windows.Forms.Button ButtonZero;
        private System.Windows.Forms.Button None;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button ButtonThree;
        private System.Windows.Forms.Button ButtonTwo;
        private System.Windows.Forms.Button ButtonOne;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button ButtonSix;
        private System.Windows.Forms.Button ButtonFive;
        private System.Windows.Forms.Button ButtonFour;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button ButtonNine;
        private System.Windows.Forms.Button ButtonEight;
        private System.Windows.Forms.Button Result;
    }
}

