namespace ACC_FuelCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal total_raceTime = ((numericUpDown_race_hrs.Value * 60) + numericUpDown_race_mins.Value) * 60;
                decimal avg_laptime = (numericUpDown_avg_mins.Value * 60) + numericUpDown_avg_secs.Value;
                int total_laps = (int)(total_raceTime / avg_laptime);
                int total_fuel = (int)Math.Ceiling(total_laps * numericUpDown_fuel.Value);
                int pitstops_counter = 0;


                if (checkBox_extraLap.Checked)
                {
                    total_laps++;
                    total_fuel += (int)Math.Ceiling(numericUpDown_fuel.Value);
                }

                if (checkBox_FormationLap.Checked)
                    total_fuel += (int)Math.Ceiling(numericUpDown_fuel.Value);

                int final_stint = total_fuel;

                if (numericUpDown_tank.Value > 0)
                {
                    while (final_stint > numericUpDown_tank.Value)
                    {
                        final_stint -= (int)numericUpDown_tank.Value;
                        pitstops_counter++;
                    }
                }

                label_totalLaps.Text = total_laps.ToString();
                label_fuelNeeded.Text = total_fuel.ToString();
                label_finalStint.Text = final_stint.ToString();
                label_pitstops.Text = pitstops_counter.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} Fill in the required fields!", "Fill in the required fields!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown_race_hrs.Value = 0;
            numericUpDown_race_mins.Value = 0;
            numericUpDown_avg_mins.Value = 0;
            numericUpDown_avg_secs.Value = 0;
            numericUpDown_fuel.Value = 0;
            numericUpDown_tank.Value = 0;

            label_totalLaps.Text = "0";
            label_fuelNeeded.Text = "0";
            label_finalStint.Text = "0";
            label_pitstops.Text = "0";

            checkBox_extraLap.Checked = false;
            checkBox_FormationLap.Checked = false;
        }
    }
}
