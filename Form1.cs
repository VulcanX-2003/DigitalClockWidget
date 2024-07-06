namespace DigitalClock;

public partial class Form1 : Form
{   
    private Label labelTime;

    private bool dragging = false;
    private Point dragCursorPoint;
    private Point dragFormPoint;
    public Form1()
    {   
        

        InitializeComponent();
        //this.TransparencyKey = this.BackColor;


        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        timer.Interval = 1000;
        timer.Tick += Timer_Tick;
        timer.Start();

        this.Controls.Add(labelTime);
    }

    private void Timer_Tick(object sender,EventArgs e)
    {
        labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
    }

    private void Form1_MouseDown(object sender, MouseEventArgs e)
    {
        dragging = true;
        dragCursorPoint = Cursor.Position;
        dragFormPoint = this.Location;
    }

    private void Form1_MouseMove(object sender, MouseEventArgs e)
    {
        if (dragging)
        {
            Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
            this.Location = Point.Add(dragFormPoint, new Size(dif));
        }
    }

    private void Form1_MouseUp(object sender, MouseEventArgs e)
    {
        dragging = false;
    }

}
