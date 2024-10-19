namespace DigitalClock;

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
        this.labelTime = new System.Windows.Forms.Label();
        this.SuspendLayout();

        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;


        this.labelTime.AutoSize = true;
        this.labelTime.Font = new System.Drawing.Font("Roboto", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.labelTime.ForeColor = System.Drawing.Color.White;
        this.labelTime.Location = new System.Drawing.Point(50, 20); // Adjust location as needed
        this.labelTime.Name = "labelTime";
        this.labelTime.Size = new System.Drawing.Size(130, 32);
        this.labelTime.TabIndex = 0;


        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.Black; // Same as the transparency key color
        this.ClientSize = new System.Drawing.Size(300, 100); // Adjust size as needed
        this.Controls.Add(this.labelTime);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Name = "Clock";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.TopMost = true;
        this.TransparencyKey = System.Drawing.Color.Black; // Transparent background
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
}
