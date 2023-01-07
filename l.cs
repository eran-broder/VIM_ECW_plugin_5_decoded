// Decompiled with JetBrains decompiler
// Type: l
// Assembly: eCWUrlLaunch, Version=4.0.1745.0, Culture=neutral, PublicKeyToken=null
// MVID: CB040BB1-DE0F-4FAE-AA16-19ACB0F0655F
// Assembly location: C:\ProgramData\eClinicalWorks\plugin\eCWUrlLaunch.exe

using log4net.Config;
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Windows.Forms;

[ExcludeFromCodeCoverage]
internal static class l
{
  [STAThread]
  private static void a()
  {
    int A_1 = 1;
    int num1 = 0;
    switch (num1)
    {
      default:
        string processName;
        string str;
        short num2;
        switch (0)
        {
          case 0:
label_3:
            processName = Process.GetCurrentProcess().ProcessName;
            str = n.d("SingleInstance");
            num2 = (short) 1;
            num1 = (int) (IntPtr) num2;
            goto default;
          default:
            Mutex mutex;
            while (true)
            {
              bool createdNew;
              bool flag;
              int num3;
              switch (num1)
              {
                case 0:
                  goto label_9;
                case 1:
                  if (!(str.ToLower() == "true"))
                  {
                    num2 = (short) 5;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  num2 = (short) 2;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 2:
                  num3 = 1;
                  break;
                case 3:
                  num2 = (short) 16772;
                  int num4 = (int) num2;
                  num2 = (short) 16772;
                  int num5 = (int) num2;
                  switch (num4 == num5 ? 1 : 0)
                  {
                    case 0:
                    case 2:
                      goto label_9;
                    default:
                      num2 = (short) 0;
                      if (num2 == (short) 0)
                        ;
                      num3 = 0;
                      break;
                  }
                  break;
                case 4:
                  num2 = (short) 1;
                  if (num2 == (short) 0)
                    ;
                  num2 = (short) 7;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 5:
                  num2 = (short) 3;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 6:
                  if (flag)
                  {
                    num2 = (short) 4;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto label_20;
                case 7:
                  if (!createdNew)
                  {
                    num2 = (short) 0;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto label_20;
                default:
                  goto label_3;
              }
              flag = num3 != 0;
              mutex = new Mutex(true, processName, out createdNew);
              num2 = (short) 6;
              num1 = (int) (IntPtr) num2;
            }
label_9:
            int num6 = (int) MessageBox.Show("Another instance of 'Url-Launch' is already running, Please close it and try again.");
            return;
label_20:
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            XmlConfigurator.Configure();
            Application.Run((Form) new h());
            GC.KeepAlive((object) mutex);
            return;
        }
    }
  }
}

