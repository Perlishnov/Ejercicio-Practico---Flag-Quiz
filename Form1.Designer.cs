namespace Ejercicio_Practico___Flag_Quiz
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
            groupBox1 = new GroupBox();
            PBCountryImage = new PictureBox();
            label1 = new Label();
            cmbCountries = new ComboBox();
            lblDisplayAnsweredMessage = new Label();
            btnSubmit = new Button();
            btnNextFlag = new Button();
            lblFinalGrade = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBCountryImage).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PBCountryImage);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(234, 166);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Flag";
            // 
            // PBCountryImage
            // 
            PBCountryImage.Location = new Point(17, 30);
            PBCountryImage.Name = "PBCountryImage";
            PBCountryImage.Size = new Size(198, 117);
            PBCountryImage.SizeMode = PictureBoxSizeMode.CenterImage;
            PBCountryImage.TabIndex = 0;
            PBCountryImage.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(271, 12);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 1;
            label1.Text = "Select country:";
            // 
            // cmbCountries
            // 
            cmbCountries.FormattingEnabled = true;
            cmbCountries.Location = new Point(271, 71);
            cmbCountries.Name = "cmbCountries";
            cmbCountries.Size = new Size(182, 33);
            cmbCountries.Sorted = true;
            cmbCountries.TabIndex = 2;
            // 
            // lblDisplayAnsweredMessage
            // 
            lblDisplayAnsweredMessage.BorderStyle = BorderStyle.Fixed3D;
            lblDisplayAnsweredMessage.Location = new Point(271, 134);
            lblDisplayAnsweredMessage.Name = "lblDisplayAnsweredMessage";
            lblDisplayAnsweredMessage.Size = new Size(182, 38);
            lblDisplayAnsweredMessage.TabIndex = 3;
            lblDisplayAnsweredMessage.Text = "Not answered yet";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(487, 12);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(162, 34);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnNextFlag
            // 
            btnNextFlag.Location = new Point(487, 71);
            btnNextFlag.Name = "btnNextFlag";
            btnNextFlag.Size = new Size(162, 34);
            btnNextFlag.TabIndex = 5;
            btnNextFlag.Text = "Next flag";
            btnNextFlag.UseVisualStyleBackColor = true;
            btnNextFlag.Click += btnNextFlag_Click;
            // 
            // lblFinalGrade
            // 
            lblFinalGrade.BorderStyle = BorderStyle.Fixed3D;
            lblFinalGrade.Location = new Point(487, 134);
            lblFinalGrade.Name = "lblFinalGrade";
            lblFinalGrade.Size = new Size(162, 38);
            lblFinalGrade.TabIndex = 6;
            lblFinalGrade.Text = "Final Grade";
            lblFinalGrade.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 210);
            Controls.Add(lblFinalGrade);
            Controls.Add(btnNextFlag);
            Controls.Add(btnSubmit);
            Controls.Add(lblDisplayAnsweredMessage);
            Controls.Add(cmbCountries);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Flag Quiz";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBCountryImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox PBCountryImage;
        private Label label1;
        private ComboBox cmbCountries;
        private Label lblDisplayAnsweredMessage;
        private Button btnSubmit;
        private Button btnNextFlag;
        private Label lblFinalGrade;
    }
}