namespace DigitalClock;

public partial class Form1 : Form
{   
    private Label labelTime;
    public Form1()
    {
        InitializeComponent();
        this.TransparencyKey = this.BackColor;


        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        timer.Interval = 1000;
        timer.Tick += Timer_Tick;
        timer.Start();
    }

    private void Timer_Tick(object sender,EventArgs e)
    {
        labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
    }
}
