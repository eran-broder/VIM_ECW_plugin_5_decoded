// Decompiled with JetBrains decompiler
// Type: m
// Assembly: eCWUrlLaunch, Version=4.0.1745.0, Culture=neutral, PublicKeyToken=null
// MVID: CB040BB1-DE0F-4FAE-AA16-19ACB0F0655F
// Assembly location: C:\ProgramData\eClinicalWorks\plugin\eCWUrlLaunch.exe

using eCWUrlLaunch.Properties;
using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Windows.Forms;

[ExcludeFromCodeCoverage]
public class m : Form
{
  private IContainer a;
  private PictureBox b;

  public m() => this.a();

  protected override void Dispose(bool disposing)
  {
    int num1 = 2;
    while (true)
    {
      short num2;
      switch (num1)
      {
        case 0:
          this.a.Dispose();
          num2 = (short) 27612;
          int num3 = (int) num2;
          num2 = (short) 27612;
          int num4 = (int) num2;
          switch (num3 == num4 ? 1 : 0)
          {
            case 0:
            case 2:
              break;
            default:
              num2 = (short) 0;
              if (num2 == (short) 0)
                ;
              num2 = (short) 1;
              num1 = (int) (IntPtr) num2;
              continue;
          }
          break;
        case 1:
          goto label_12;
        case 2:
          switch (0)
          {
            case 0:
              goto label_3;
            default:
              continue;
          }
        case 3:
          if (this.a == null)
            goto label_12;
          else
            break;
        case 4:
          num2 = (short) 3;
          num1 = (int) (IntPtr) num2;
          continue;
        default:
label_3:
          num2 = (short) 1;
          if (num2 == (short) 0)
            ;
          if (disposing)
          {
            num2 = (short) 4;
            num1 = (int) (IntPtr) num2;
            continue;
          }
          goto label_12;
      }
      num2 = (short) 0;
      num1 = (int) (IntPtr) num2;
    }
label_12:
    base.Dispose(disposing);
  }

  private void a()
  {
    int A_1 = 15;
    short num1 = -16102;
    int num2 = (int) num1;
    num1 = (short) -16102;
    int num3 = (int) num1;
    switch (num2 == num3)
    {
      case true:
        short num4 = 0;
        if (num4 == (short) 0)
          ;
        num4 = (short) 1;
        if (num4 == (short) 0)
          ;
        this.b = new PictureBox();
        ((ISupportInitialize) this.b).BeginInit();
        this.SuspendLayout();
        this.b.Image = (Image) Resources.Loading;
        this.b.Location = new Point(12, 12);
        this.b.Name = "pictureBox1";
        this.b.Size = new Size(257, 50);
        this.b.SizeMode = PictureBoxSizeMode.CenterImage;
        this.b.TabIndex = 0;
        this.b.TabStop = false;
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(281, 71);
        this.Controls.Add((Control) this.b);
        this.FormBorderStyle = FormBorderStyle.None;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "SplashScreen";
        this.ShowIcon = false;
        this.SizeGripStyle = SizeGripStyle.Hide;
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "SplashScreen";
        this.TopMost = true;
        ((ISupportInitialize) this.b).EndInit();
        this.ResumeLayout(false);
        break;
      default:
        goto case 1;
    }
  }
}

