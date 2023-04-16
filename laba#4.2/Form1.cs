namespace laba_4._2
{

    public partial class Form1 : Form
    {
        Model model;
        public Form1()
        {

            InitializeComponent();
            model = new Model();
            model.observer += new System.EventHandler(this.updateFromModel);
        }
        public void updateFromModel(object sender, EventArgs e)
        {
            textBoxA.Text = model.getValue('a').ToString();
            numericUpDownA.Value = model.getValue('a');
            trackBarA.Value = model.getValue('a');
            textBoxB.Text = model.getValue('b').ToString();
            numericUpDownB.Value = model.getValue('b');
            trackBarB.Value = model.getValue('b');
            textBoxC.Text = model.getValue('c').ToString();
            numericUpDownC.Value = model.getValue('c');
            trackBarC.Value = model.getValue('c');
        }
        public class Model
        {
            private int valueA;
            private int valueB;
            private int valueC;
            public System.EventHandler observer;
            public void setValueA(int value)
            {
                if (value > this.valueB)
                {
                    this.valueB = value;

                }
                if (value > this.valueC)
                {
                    this.valueC = value;
                }
                this.valueA = value;
                observer.Invoke(this, null);
            }
            public void setValueB(int value)
            {
                if (value < valueA)
                {
                    this.valueB = this.valueA;
                }
                else if (value > this.valueC)
                {
                    this.valueB = this.valueC;
                }
                else this.valueB = value;
                observer.Invoke(this, null);
            }
            public void setValueC(int value)
            {
                if (value < this.valueA)
                {
                    this.valueA = value;
                    this.valueB = value;
                    this.valueC = value;
                }
                else if (value < this.valueB)
                {
                    this.valueB = value;
                    this.valueC = value;
                }
                else this.valueC = value;
                observer.Invoke(this, null);
            }
            public int getValue(char letter)
            {
                switch (letter)
                {
                    case 'a': return valueA;
                    case 'b': return valueB;
                    case 'c': return valueC;
                    default: throw new Exception("Invalid letter input");
                }
            }

        }

        private void textBoxA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setValueA(Int32.Parse(textBoxA.Text));
            }
        }

        private void textBoxB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setValueB(Int32.Parse(textBoxB.Text));
            }
        }

        private void textBoxC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setValueC(Int32.Parse(textBoxC.Text));
            }
        }

        private void numericUpDownA_ValueChanged(object sender, EventArgs e)
        {
            model.setValueA(Decimal.ToInt32(numericUpDownA.Value));
        }

        private void numericUpDownB_ValueChanged(object sender, EventArgs e)
        {
            model.setValueB(Decimal.ToInt32(numericUpDownB.Value));
        }

        private void numericUpDownC_ValueChanged(object sender, EventArgs e)
        {
            model.setValueC(Decimal.ToInt32(numericUpDownC.Value));
        }

        private void trackBarA_ValueChanged(object sender, EventArgs e)
        {
            model.setValueA(Decimal.ToInt32(trackBarA.Value));
        }

        private void trackBarB_ValueChanged(object sender, EventArgs e)
        {
            model.setValueB(Decimal.ToInt32(trackBarB.Value));
        }

        private void trackBarC_ValueChanged(object sender, EventArgs e)
        {
            model.setValueC(Decimal.ToInt32(trackBarC.Value));
        }
    }
}