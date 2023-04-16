namespace laba_4._2
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
            big_label = new Label();
            textBoxA = new TextBox();
            textBoxC = new TextBox();
            textBoxB = new TextBox();
            numericUpDownA = new NumericUpDown();
            numericUpDownC = new NumericUpDown();
            numericUpDownB = new NumericUpDown();
            trackBarA = new TrackBar();
            trackBarB = new TrackBar();
            trackBarC = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)numericUpDownA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarC).BeginInit();
            SuspendLayout();
            // 
            // big_label
            // 
            big_label.AutoSize = true;
            big_label.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            big_label.Location = new Point(130, 30);
            big_label.Name = "big_label";
            big_label.Size = new Size(521, 112);
            big_label.TabIndex = 0;
            big_label.Text = "A <= B <= C";
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(130, 145);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(125, 27);
            textBoxA.TabIndex = 1;
            textBoxA.KeyDown += textBoxA_KeyDown;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(526, 145);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(125, 27);
            textBoxC.TabIndex = 2;
            textBoxC.KeyDown += textBoxC_KeyDown;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(332, 145);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(125, 27);
            textBoxB.TabIndex = 3;
            textBoxB.KeyDown += textBoxB_KeyDown;
            // 
            // numericUpDownA
            // 
            numericUpDownA.Location = new Point(130, 187);
            numericUpDownA.Name = "numericUpDownA";
            numericUpDownA.Size = new Size(125, 27);
            numericUpDownA.TabIndex = 4;
            numericUpDownA.ValueChanged += numericUpDownA_ValueChanged;
            // 
            // numericUpDownC
            // 
            numericUpDownC.Location = new Point(526, 187);
            numericUpDownC.Name = "numericUpDownC";
            numericUpDownC.Size = new Size(125, 27);
            numericUpDownC.TabIndex = 5;
            numericUpDownC.ValueChanged += numericUpDownC_ValueChanged;
            // 
            // numericUpDownB
            // 
            numericUpDownB.Location = new Point(332, 187);
            numericUpDownB.Name = "numericUpDownB";
            numericUpDownB.Size = new Size(125, 27);
            numericUpDownB.TabIndex = 6;
            numericUpDownB.ValueChanged += numericUpDownB_ValueChanged;
            // 
            // trackBarA
            // 
            trackBarA.Location = new Point(130, 232);
            trackBarA.Maximum = 100;
            trackBarA.Name = "trackBarA";
            trackBarA.Size = new Size(125, 56);
            trackBarA.TabIndex = 7;
            trackBarA.ValueChanged += trackBarA_ValueChanged;
            // 
            // trackBarB
            // 
            trackBarB.Location = new Point(332, 232);
            trackBarB.Maximum = 100;
            trackBarB.Name = "trackBarB";
            trackBarB.Size = new Size(125, 56);
            trackBarB.TabIndex = 8;
            trackBarB.ValueChanged += trackBarB_ValueChanged;
            // 
            // trackBarC
            // 
            trackBarC.Location = new Point(526, 232);
            trackBarC.Maximum = 100;
            trackBarC.Name = "trackBarC";
            trackBarC.Size = new Size(125, 56);
            trackBarC.TabIndex = 9;
            trackBarC.ValueChanged += trackBarC_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(trackBarC);
            Controls.Add(trackBarB);
            Controls.Add(trackBarA);
            Controls.Add(numericUpDownB);
            Controls.Add(numericUpDownC);
            Controls.Add(numericUpDownA);
            Controls.Add(textBoxB);
            Controls.Add(textBoxC);
            Controls.Add(textBoxA);
            Controls.Add(big_label);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownC).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownB).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarA).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarB).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label big_label;
        private TextBox textBoxA;
        private TextBox textBoxC;
        private TextBox textBoxB;
        private NumericUpDown numericUpDownA;
        private NumericUpDown numericUpDownC;
        private NumericUpDown numericUpDownB;
        private TrackBar trackBarB;
        private TrackBar trackBarC;
        public TrackBar trackBarA;
    }
}