namespace WindowsFormsApp1
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.label1 = new System.Windows.Forms.Label();
      this.Stock1 = new System.Windows.Forms.Label();
      this.Stock2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(22, 35);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(74, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Stock Trading";
      // 
      // Stock1
      // 
      this.Stock1.AutoSize = true;
      this.Stock1.Location = new System.Drawing.Point(22, 72);
      this.Stock1.Name = "Stock1";
      this.Stock1.Size = new System.Drawing.Size(44, 13);
      this.Stock1.TabIndex = 4;
      this.Stock1.Text = "Stock1:";
      // 
      // Stock2
      // 
      this.Stock2.AutoSize = true;
      this.Stock2.Location = new System.Drawing.Point(22, 101);
      this.Stock2.Name = "Stock2";
      this.Stock2.Size = new System.Drawing.Size(44, 13);
      this.Stock2.TabIndex = 5;
      this.Stock2.Text = "Stock2:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(474, 218);
      this.Controls.Add(this.Stock2);
      this.Controls.Add(this.Stock1);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      //this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label Stock1;
    private System.Windows.Forms.Label Stock2;
  }
}

