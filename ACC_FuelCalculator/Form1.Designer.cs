namespace ACC_FuelCalculator
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            numericUpDown_race_hrs = new NumericUpDown();
            checkBox_FormationLap = new CheckBox();
            checkBox_extraLap = new CheckBox();
            panel1 = new Panel();
            label_pitstops = new Label();
            label_finalStint = new Label();
            label_fuelNeeded = new Label();
            label_totalLaps = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            button1 = new Button();
            numericUpDown_race_mins = new NumericUpDown();
            numericUpDown_avg_mins = new NumericUpDown();
            numericUpDown_avg_secs = new NumericUpDown();
            numericUpDown_fuel = new NumericUpDown();
            numericUpDown_tank = new NumericUpDown();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_race_hrs).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_race_mins).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_avg_mins).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_avg_secs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_fuel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_tank).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(126, 21);
            label1.TabIndex = 0;
            label1.Text = "Total race time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 94);
            label2.Name = "label2";
            label2.Size = new Size(136, 21);
            label2.TabIndex = 1;
            label2.Text = "Average laptime";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 21);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 2;
            label3.Text = "Total laps";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 186);
            label4.Name = "label4";
            label4.Size = new Size(101, 21);
            label4.TabIndex = 3;
            label4.Text = "Fuel per lap";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 269);
            label5.Name = "label5";
            label5.Size = new Size(150, 21);
            label5.TabIndex = 4;
            label5.Text = "Fuel tank capacity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(168, 55);
            label6.Name = "label6";
            label6.Size = new Size(30, 20);
            label6.TabIndex = 12;
            label6.Text = "hrs";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(383, 55);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 13;
            label7.Text = "mins";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(168, 120);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 14;
            label8.Text = "mins";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(383, 120);
            label9.Name = "label9";
            label9.Size = new Size(36, 20);
            label9.TabIndex = 15;
            label9.Text = "secs";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.Location = new Point(168, 212);
            label10.Name = "label10";
            label10.Size = new Size(42, 20);
            label10.TabIndex = 16;
            label10.Text = "litres";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.Location = new Point(168, 295);
            label11.Name = "label11";
            label11.Size = new Size(42, 20);
            label11.TabIndex = 17;
            label11.Text = "litres";
            // 
            // numericUpDown_race_hrs
            // 
            numericUpDown_race_hrs.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numericUpDown_race_hrs.Location = new Point(12, 53);
            numericUpDown_race_hrs.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numericUpDown_race_hrs.Name = "numericUpDown_race_hrs";
            numericUpDown_race_hrs.Size = new Size(150, 27);
            numericUpDown_race_hrs.TabIndex = 18;
            numericUpDown_race_hrs.Tag = "";
            numericUpDown_race_hrs.TextAlign = HorizontalAlignment.Center;
            // 
            // checkBox_FormationLap
            // 
            checkBox_FormationLap.AutoSize = true;
            checkBox_FormationLap.Cursor = Cursors.Hand;
            checkBox_FormationLap.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBox_FormationLap.Location = new Point(12, 339);
            checkBox_FormationLap.Name = "checkBox_FormationLap";
            checkBox_FormationLap.Size = new Size(131, 22);
            checkBox_FormationLap.TabIndex = 24;
            checkBox_FormationLap.Text = "Formation lap";
            checkBox_FormationLap.UseVisualStyleBackColor = true;
            // 
            // checkBox_extraLap
            // 
            checkBox_extraLap.AutoSize = true;
            checkBox_extraLap.BackColor = Color.Gainsboro;
            checkBox_extraLap.Cursor = Cursors.Hand;
            checkBox_extraLap.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            checkBox_extraLap.Location = new Point(12, 375);
            checkBox_extraLap.Name = "checkBox_extraLap";
            checkBox_extraLap.Size = new Size(99, 22);
            checkBox_extraLap.TabIndex = 25;
            checkBox_extraLap.Text = "Extra lap";
            checkBox_extraLap.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label_pitstops);
            panel1.Controls.Add(label_finalStint);
            panel1.Controls.Add(label_fuelNeeded);
            panel1.Controls.Add(label_totalLaps);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(279, 207);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 190);
            panel1.TabIndex = 26;
            // 
            // label_pitstops
            // 
            label_pitstops.AutoSize = true;
            label_pitstops.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_pitstops.Location = new Point(332, 142);
            label_pitstops.Name = "label_pitstops";
            label_pitstops.Size = new Size(17, 20);
            label_pitstops.TabIndex = 9;
            label_pitstops.Text = "0";
            // 
            // label_finalStint
            // 
            label_finalStint.AutoSize = true;
            label_finalStint.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_finalStint.Location = new Point(332, 102);
            label_finalStint.Name = "label_finalStint";
            label_finalStint.Size = new Size(17, 20);
            label_finalStint.TabIndex = 8;
            label_finalStint.Text = "0";
            // 
            // label_fuelNeeded
            // 
            label_fuelNeeded.AutoSize = true;
            label_fuelNeeded.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_fuelNeeded.Location = new Point(332, 61);
            label_fuelNeeded.Name = "label_fuelNeeded";
            label_fuelNeeded.Size = new Size(17, 20);
            label_fuelNeeded.TabIndex = 7;
            label_fuelNeeded.Text = "0";
            // 
            // label_totalLaps
            // 
            label_totalLaps.AutoSize = true;
            label_totalLaps.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_totalLaps.Location = new Point(332, 21);
            label_totalLaps.Name = "label_totalLaps";
            label_totalLaps.Size = new Size(17, 20);
            label_totalLaps.TabIndex = 6;
            label_totalLaps.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(3, 142);
            label14.Name = "label14";
            label14.Size = new Size(70, 21);
            label14.TabIndex = 5;
            label14.Text = "Pitstops";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(3, 102);
            label13.Name = "label13";
            label13.Size = new Size(217, 21);
            label13.TabIndex = 4;
            label13.Text = "Total needed for final stint";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(3, 61);
            label12.Name = "label12";
            label12.Size = new Size(146, 21);
            label12.TabIndex = 3;
            label12.Text = "Total fuel needed";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(508, 179);
            button1.Name = "button1";
            button1.Size = new Size(148, 28);
            button1.TabIndex = 0;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // numericUpDown_race_mins
            // 
            numericUpDown_race_mins.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numericUpDown_race_mins.Location = new Point(227, 53);
            numericUpDown_race_mins.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            numericUpDown_race_mins.Name = "numericUpDown_race_mins";
            numericUpDown_race_mins.Size = new Size(150, 27);
            numericUpDown_race_mins.TabIndex = 27;
            numericUpDown_race_mins.Tag = "";
            numericUpDown_race_mins.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDown_avg_mins
            // 
            numericUpDown_avg_mins.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numericUpDown_avg_mins.Location = new Point(12, 118);
            numericUpDown_avg_mins.Name = "numericUpDown_avg_mins";
            numericUpDown_avg_mins.Size = new Size(150, 27);
            numericUpDown_avg_mins.TabIndex = 28;
            numericUpDown_avg_mins.Tag = "";
            numericUpDown_avg_mins.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDown_avg_secs
            // 
            numericUpDown_avg_secs.DecimalPlaces = 1;
            numericUpDown_avg_secs.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numericUpDown_avg_secs.Location = new Point(227, 118);
            numericUpDown_avg_secs.Name = "numericUpDown_avg_secs";
            numericUpDown_avg_secs.Size = new Size(150, 27);
            numericUpDown_avg_secs.TabIndex = 29;
            numericUpDown_avg_secs.Tag = "";
            numericUpDown_avg_secs.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDown_fuel
            // 
            numericUpDown_fuel.DecimalPlaces = 2;
            numericUpDown_fuel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numericUpDown_fuel.Location = new Point(12, 210);
            numericUpDown_fuel.Name = "numericUpDown_fuel";
            numericUpDown_fuel.Size = new Size(150, 27);
            numericUpDown_fuel.TabIndex = 30;
            numericUpDown_fuel.Tag = "";
            numericUpDown_fuel.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDown_tank
            // 
            numericUpDown_tank.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            numericUpDown_tank.Location = new Point(12, 293);
            numericUpDown_tank.Maximum = new decimal(new int[] { 190, 0, 0, 0 });
            numericUpDown_tank.Name = "numericUpDown_tank";
            numericUpDown_tank.Size = new Size(150, 27);
            numericUpDown_tank.TabIndex = 31;
            numericUpDown_tank.Tag = "";
            numericUpDown_tank.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.Location = new Point(581, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 32;
            button2.Text = "Reset all";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(668, 409);
            Controls.Add(button2);
            Controls.Add(numericUpDown_tank);
            Controls.Add(numericUpDown_fuel);
            Controls.Add(numericUpDown_avg_secs);
            Controls.Add(numericUpDown_avg_mins);
            Controls.Add(numericUpDown_race_mins);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(checkBox_extraLap);
            Controls.Add(checkBox_FormationLap);
            Controls.Add(numericUpDown_race_hrs);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fuel Calculator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_race_hrs).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_race_mins).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_avg_mins).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_avg_secs).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_fuel).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_tank).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private NumericUpDown numericUpDown_race_hrs;
        private CheckBox checkBox_FormationLap;
        private CheckBox checkBox_extraLap;
        private Panel panel1;
        private Button button1;
        private Label label14;
        private Label label13;
        private Label label12;
        private NumericUpDown numericUpDown_race_mins;
        private NumericUpDown numericUpDown_avg_mins;
        private NumericUpDown numericUpDown_avg_secs;
        private NumericUpDown numericUpDown_fuel;
        private NumericUpDown numericUpDown_tank;
        private Label label_pitstops;
        private Label label_finalStint;
        private Label label_fuelNeeded;
        private Label label_totalLaps;
        private Button button2;
    }
}
