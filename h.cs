// Decompiled with JetBrains decompiler
// Type: h
// Assembly: eCWUrlLaunch, Version=4.0.1745.0, Culture=neutral, PublicKeyToken=null
// MVID: CB040BB1-DE0F-4FAE-AA16-19ACB0F0655F
// Assembly location: C:\ProgramData\eClinicalWorks\plugin\eCWUrlLaunch.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Web;
using System.Windows.Forms;

[ExcludeFromCodeCoverage]
public class h : Form
{
  private static readonly IntPtr a;
  private int b;
  private global::f c;
  private static CookieContainer d;
  private static bool e;
  private static string f;
  private static m g;
  private const string h = "eClinicalWorks_WebView2_Browser";
  private static string i;
  private IContainer j;

  public h()
  {
    int A_1_1 = 18;
    // ISSUE: explicit constructor call
    base.\u002Ector();
    this.a();
    global::h.g = new m();
    Thread A_0_1 = new Thread(new ThreadStart(this.b));
    try
    {
      this.Activate();
      global::h.SetWindowPos(this.Handle, global::h.a, 0, 0, 0, 0, 3U);
      global::h.SetForegroundWindow(this.Handle);
      A_0_1.Start();
      string[] commandLineArgs = Environment.GetCommandLineArgs();
      if (commandLineArgs.Length == 4)
      {
        global::h.e = true;
        global::g.a(global::h.e);
        global::g.c("4 Parameter case");
        global::g.c("Parameter 1: " + commandLineArgs[0]);
        global::g.c("Parameter 2: " + commandLineArgs[1]);
        global::g.c("Parameter 3: " + commandLineArgs[2]);
        global::g.c("Parameter 4: " + commandLineArgs[3]);
        n.a(commandLineArgs[1].Trim(), false, true);
      }
      else if (commandLineArgs.Length != 3)
      {
        if (commandLineArgs.Length == 2)
        {
          global::g.c("2 Parameter case");
          n.ao();
          string str1 = commandLineArgs[1].Trim();
          if (str1.Contains(".exe"))
            str1 = n.e(str1);
          n.q();
          n.p();
          n.a(str1, out global::h.f);
          Uri uri = new Uri(str1);
          string A_1_2 = uri.Scheme + "://" + uri.Authority;
          string A_0_2 = A_1_2 + "/mobiledoc/jsp/webemr/login/newLogin.jsp";
          global::g.b("Trying to ping the server and validate server SSL certificate.");
          global::g.c("Pinging the url using HTTP GET:" + A_0_2);
          string str2 = n.b(A_0_2, out global::h.d);
          if (!string.IsNullOrEmpty(str2))
          {
            global::h.a(A_0_1);
            if (str2 == "ping_failed")
            {
              int num = (int) MessageBox.Show("Server is not reachable, please check Internet/Network connectivity" + Environment.NewLine + "URL: " + str1, "eClinicalWorks", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
              global::g.c("Server is not reachable, please check Internet/Network connectivity" + Environment.NewLine + "URL: " + str1);
            }
            else
            {
              int num = (int) MessageBox.Show("The security certificate presented by this website was not issued by a trusted certificate authority." + Environment.NewLine + Environment.NewLine + "URL: " + str1 + Environment.NewLine + Environment.NewLine + "Please close proxy applications and launch again.", "eClinicalWorks", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
              global::g.c("The security certificate presented by this website was not issued by a trusted certificate authority." + Environment.NewLine + Environment.NewLine + "URL: " + str1 + Environment.NewLine + Environment.NewLine + "Please close proxy applications and launch again.");
            }
          }
          else
          {
            global::g.c("Basic connectivity to server is working.");
            global::g.b("Successfully validated server SSL certificate or it could be HTTP traffic.");
            CookieContainer A_1_3 = n.a(global::h.d);
            string A_4;
            string A_2_1;
            if (n.a(A_0_2, A_1_3, out A_2_1, out string _, out A_4))
            {
              global::g.b("Security Patch Applied.");
              global::g.b("Trying to validate server token");
              CookieContainer A_2_2 = n.a(global::h.d);
              string A_3 = HttpUtility.UrlEncode(n.a(A_0_2, A_2_1, A_2_2));
              if (!string.IsNullOrEmpty(A_3))
              {
                global::g.b("Successfully verified server token.");
                global::g.b("Launching for new server build.");
                this.a(A_0_1, A_1_2, str1, A_3);
              }
              else
              {
                global::h.a(A_0_1);
                int num = (int) MessageBox.Show("Failed to verify server token. Please check the logs for more details.", "eClinicalWorks", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                global::g.c("Failed to verify server token.");
              }
            }
            else if (string.IsNullOrEmpty(A_4) || !(A_4 == "server_patch_not_available"))
            {
              global::h.a(A_0_1);
              int num = (int) MessageBox.Show("Hostname verification failed. Unable to verify secure end to end connection.", "eClinicalWorks", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
              global::g.c("Hostname verification failed. Unable to verify end to end connection");
              global::g.b("Client ping failed, please check errors.");
            }
            else
            {
              global::g.b("Server side patch not applied (client ping and server ping).");
              global::g.b("Launching for old server build.");
              this.a(A_0_1, A_1_2, str1, "");
            }
          }
        }
      }
      else
      {
        global::g.c("3 Parameter case");
        global::g.c("Parameter 1: " + commandLineArgs[0]);
        global::g.c("Parameter 2: " + commandLineArgs[1]);
        global::g.c("Parameter 3: " + commandLineArgs[2]);
        n.b(commandLineArgs[1].Trim(), false);
      }
    }
    catch (Exception ex)
    {
      global::h.a(A_0_1);
      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
      Environment.Exit(0);
    }
    Environment.Exit(0);
  }

  private void a(Thread A_0, string A_1, string A_2, string A_3)
  {
    int A_1_1 = 12;
    int num1 = 0;
    switch (num1)
    {
      default:
        short num2;
        switch (0)
        {
          case 0:
label_3:
            this.b = n.l();
            num2 = (short) 6;
            num1 = (int) (IntPtr) num2;
            goto default;
          default:
            string str1;
            bool A_1_2;
            string A_2_1;
            while (true)
            {
              string path;
              int A_0_1;
              string str2;
              string str3;
              Process process;
              string str4;
              bool flag1;
              bool flag2;
              DialogResult dialogResult;
              bool flag3;
              string str5;
              switch (num1)
              {
                case 0:
                case 8:
                case 25:
                  str2 = n.m(str2);
                  str3 = "Ecw:ProjectE?id=EmbeddedBrowser&server=" + HttpUtility.UrlEncode(str2) + "&userdatafolder=eClinicalWorks_WebView2_Browser" + str4;
                  str1 = n.e();
                  flag1 = n.b("Evergreen Mode");
                  num2 = (short) 1;
                  if (num2 == (short) 0)
                    ;
                  num2 = (short) 32;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 1:
                  if (n.a())
                  {
                    num2 = (short) 28;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  n.a(Process.GetProcessesByName("WinProjectE"));
                  n.a(global::h.i, 3);
                  num2 = (short) 25;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 2:
                  n.c(A_0_1);
                  num2 = (short) 4;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 3:
                  new Thread(new ThreadStart(this.c)).Start();
                  num2 = (short) 15;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 4:
                  num2 = (short) 33;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 5:
                  num2 = (short) 1;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 6:
label_4:
                  if (this.b > 0)
                  {
                    num2 = (short) 3;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto case 15;
                case 7:
                  num2 = (short) 37;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 9:
                  global::h.a(A_0);
                  process.WaitForExit();
                  num2 = (short) 38;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 10:
                  str5 = A_2 + "?tk=" + A_3;
                  break;
                case 11:
                  if (!flag2)
                  {
                    num2 = (short) 27;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto case 34;
                case 12:
                  n.a(Process.GetProcessesByName("WinProjectE"));
                  n.a(global::h.i, 3);
                  num2 = (short) 8;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 13:
                  if (!A_2.Contains("ecwauth"))
                  {
                    num2 = (short) 7;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto label_33;
                case 14:
                  str5 = A_2 + "&tk=" + A_3;
                  break;
                case 15:
                  str2 = string.Empty;
                  num2 = (short) 13;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 16:
                case 21:
                case 29:
                  num2 = (short) 35;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 17:
                  num2 = (short) 10;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 18:
                  str4 = string.Format("{0}", (object) Guid.NewGuid());
                  global::h.i += str4;
                  num2 = (short) 24;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 19:
                  if (!Directory.Exists(path))
                  {
                    num2 = (short) 42;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  global::g.a("Downloading Default WebView Failed.");
                  num2 = (short) 648;
                  int num3 = (int) num2;
                  num2 = (short) 648;
                  int num4 = (int) num2;
                  switch (num3 == num4 ? 1 : 0)
                  {
                    case 0:
                    case 2:
                      goto label_4;
                    default:
                      num2 = (short) 0;
                      if (num2 == (short) 0)
                        ;
                      num2 = (short) 16;
                      num1 = (int) (IntPtr) num2;
                      continue;
                  }
                case 20:
                  goto label_39;
                case 22:
                  if (!A_1_2)
                  {
                    str3 = n.a(str2, global::h.f, out A_2_1);
                    str1 = n.g();
                    num2 = (short) 21;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  num2 = (short) 18;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 23:
                  Directory.CreateDirectory(global::h.i);
                  num2 = (short) 0;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 24:
                  if (!Directory.Exists(global::h.i))
                  {
                    num2 = (short) 23;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  num2 = (short) 41;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 26:
                  if (flag3)
                  {
                    num2 = (short) 30;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto case 16;
                case 27:
                  global::g.a("Webview2 Enabled but Server is not compatible with Webview runtime. Switching to Chrome.");
                  A_1_2 = false;
                  num2 = (short) 34;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 28:
                  dialogResult = MessageBox.Show("Click OK to close all running sessions and to launch new session", "eClinicalWorks - Browser Shared Folder Expired", MessageBoxButtons.OKCancel);
                  num2 = (short) 40;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 30:
                  n.b();
                  num2 = (short) 29;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 31:
                  n.ad();
                  Environment.SetEnvironmentVariable("CHROME_LOG_FILE", "");
                  this.a(n.a(5));
                  num2 = (short) 9;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 32:
                  if (flag1)
                  {
                    num2 = (short) 36;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto case 16;
                case 33:
                  if (!A_1_2)
                  {
                    num2 = (short) 31;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto case 9;
                case 34:
                  num2 = (short) 22;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 35:
                  if (string.IsNullOrEmpty(str1))
                  {
                    num2 = (short) 20;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  process = new Process();
                  process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                  process.StartInfo.CreateNoWindow = true;
                  process.StartInfo.UseShellExecute = false;
                  process.StartInfo.FileName = str1;
                  process.StartInfo.Arguments = str3;
                  process.EnableRaisingEvents = true;
                  process.Exited += new EventHandler(global::h.a);
                  process.Start();
                  A_0_1 = n.k();
                  num2 = (short) 39;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 36:
                  global::g.a("Using Default WebView.");
                  path = Path.Combine(Path.GetDirectoryName(n.b), "WebViewRunTime");
                  num2 = (short) 19;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 37:
                  if (!A_2.Contains("?"))
                  {
                    num2 = (short) 17;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto label_33;
                case 38:
                  goto label_67;
                case 39:
                  if (A_0_1 > 0)
                  {
                    num2 = (short) 2;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto case 4;
                case 40:
                  if (dialogResult == DialogResult.OK)
                  {
                    num2 = (short) 12;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto case 0;
                case 41:
                  if (n.a(global::h.i))
                  {
                    num2 = (short) 5;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto case 0;
                case 42:
                  flag3 = n.c();
                  num2 = (short) 26;
                  num1 = (int) (IntPtr) num2;
                  continue;
                default:
                  goto label_3;
              }
              str2 = str5;
              str1 = string.Empty;
              str3 = string.Empty;
              A_2_1 = string.Empty;
              A_1_2 = n.d();
              flag2 = n.a(A_1 + "/mobiledoc/jsp/webemr/login/img/plugin-webview2.png", out CookieContainer _);
              num2 = (short) 11;
              num1 = (int) (IntPtr) num2;
              continue;
label_33:
              num2 = (short) 14;
              num1 = (int) (IntPtr) num2;
            }
label_39:
            global::h.a(A_0);
            int num5 = (int) MessageBox.Show("Please check browser's path, Browser is not found at location:" + str1 + ".", "eClinicalWorks", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            return;
label_67:
            try
            {
              n.ac();
              n.a(A_2_1, A_1_2);
              return;
            }
            catch (Exception ex)
            {
              global::g.c("Temp Cleanup failed: " + ex.Message);
              return;
            }
        }
    }
  }

  private void c()
  {
    try
    {
      short num1 = 18097;
      int num2 = (int) num1;
      num1 = (short) 18097;
      int num3 = (int) num1;
      switch (num2 == num3)
      {
        case true:
          if (true)
            ;
          new k(this.b).d();
          break;
        default:
          goto case 1;
      }
    }
    catch (Exception ex)
    {
      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
    }
    if (false)
      ;
  }

  [DllImport("user32.dll")]
  [return: MarshalAs(UnmanagedType.Bool)]
  public static extern bool SetWindowPos(
    IntPtr A_0,
    IntPtr A_1,
    int A_2,
    int A_3,
    int A_4,
    int A_5,
    uint A_6);

  [DllImport("user32.dll")]
  private static extern bool SetForegroundWindow(IntPtr A_0);

  private void b()
  {
    int A_1 = 9;
    try
    {
      short num1 = -7740;
      int num2 = (int) num1;
      num1 = (short) -7740;
      int num3 = (int) num1;
      switch (num2 == num3)
      {
        case true:
          num1 = (short) 1;
          if (num1 == (short) 0)
            ;
          num1 = (short) 0;
          if (num1 == (short) 0)
            ;
          Application.Run((Form) global::h.g);
          break;
        default:
          goto case 1;
      }
    }
    catch (ThreadAbortException ex)
    {
      global::g.c("Splash screen aborted.");
    }
    catch (Exception ex)
    {
      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
    }
  }

  private static void a(Thread A_0)
  {
    try
    {
      int num1 = 4;
      while (true)
      {
        short num2;
        switch (num1)
        {
          case 0:
            goto label_11;
          case 1:
            if (A_0 == null)
            {
              num2 = (short) 3;
              num1 = (int) (IntPtr) num2;
              continue;
            }
            A_0.Abort();
            num2 = (short) 0;
            num1 = (int) (IntPtr) num2;
            continue;
          case 2:
            goto label_8;
          case 3:
            num2 = (short) 1414;
            int num3 = (int) num2;
            num2 = (short) 1414;
            int num4 = (int) num2;
            switch (num3 == num4 ? 1 : 0)
            {
              case 0:
              case 2:
                break;
              default:
                num2 = (short) 1;
                if (num2 == (short) 0)
                  ;
                num2 = (short) 0;
                if (num2 == (short) 0)
                  ;
                num2 = (short) 2;
                num1 = (int) (IntPtr) num2;
                continue;
            }
            break;
          case 4:
            switch (0)
            {
              case 0:
                break;
              default:
                continue;
            }
            break;
        }
        global::h.g.Invoke((Delegate) (() =>
        {
          short num5 = 17378;
          int num6 = (int) num5;
          num5 = (short) 17378;
          int num7 = (int) num5;
          switch (num6 == num7)
          {
            case true:
              short num8 = 1;
              if (num8 == (short) 0)
                ;
              num8 = (short) 0;
              if (num8 == (short) 0)
                ;
              global::h.g.Close();
              global::h.g.Dispose();
              break;
            default:
              goto case 1;
          }
        }));
        Thread.Sleep(1000);
        num2 = (short) 1;
        num1 = (int) (IntPtr) num2;
      }
label_11:
      return;
label_8:;
    }
    catch (Exception ex)
    {
      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
    }
  }

  private void a(int A_0)
  {
    try
    {
      short num1 = -3051;
      int num2 = (int) num1;
      num1 = (short) -3051;
      int num3 = (int) num1;
      switch (num2 == num3)
      {
        case true:
          if (true)
            ;
          this.c = new global::f(A_0);
          this.c.j.Add(Keys.F12);
          this.c.j.Add(Keys.I);
          this.c.j.Add(Keys.U);
          this.c.j.Add(Keys.J);
          this.c.j.Add(Keys.C);
          this.c.f(new KeyEventHandler(global::h.a));
          this.c.d(new KeyEventHandler(global::h.b));
          break;
        default:
          goto case 1;
      }
    }
    catch (Exception ex)
    {
      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
    }
    if (false)
      ;
  }

  private static void b(object A_0, KeyEventArgs A_1)
  {
    short num1 = 7731;
    int num2 = (int) num1;
    num1 = (short) 7731;
    int num3 = (int) num1;
    switch (num2 == num3)
    {
      case true:
        short num4 = 1;
        if (num4 == (short) 0)
          ;
        num4 = (short) 0;
        if (num4 == (short) 0)
          ;
        A_1.Handled = true;
        break;
      default:
        goto case 1;
    }
  }

  private static void a(object A_0, KeyEventArgs A_1)
  {
    short num1 = 7700;
    int num2 = (int) num1;
    num1 = (short) 7700;
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
        A_1.Handled = true;
        break;
      default:
        goto case 1;
    }
  }

  private static void a(object A_0, EventArgs A_1)
  {
    try
    {
      int num1;
      short num2;
      switch (0)
      {
        case 0:
label_2:
          Thread.Sleep(1000);
          num2 = (short) 2;
          num1 = (int) (IntPtr) num2;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
                Directory.Delete(global::h.i, true);
                num2 = (short) 1;
                num1 = (int) (IntPtr) num2;
                continue;
              case 1:
                num2 = (short) -22138;
                int num3 = (int) num2;
                num2 = (short) -22138;
                int num4 = (int) num2;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    break;
                  default:
                    num2 = (short) 0;
                    if (num2 == (short) 0)
                      break;
                    break;
                }
                break;
              case 2:
                if (Directory.Exists(global::h.i))
                {
                  num2 = (short) 0;
                  num1 = (int) (IntPtr) num2;
                  continue;
                }
                break;
              case 3:
                goto label_11;
              default:
                goto label_2;
            }
            num2 = (short) 3;
            num1 = (int) (IntPtr) num2;
          }
label_11:
          num2 = (short) 1;
          if (num2 == (short) 0)
            break;
          break;
      }
    }
    catch (Exception ex)
    {
      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
    }
  }

  protected override void Dispose(bool disposing)
  {
    int num1 = 3;
    while (true)
    {
      short num2 = -4667;
      int num3 = (int) num2;
      num2 = (short) -4667;
      int num4 = (int) num2;
      switch (num3 == num4 ? 1 : 0)
      {
        case 0:
        case 2:
label_9:
          num2 = (short) 2;
          num1 = (int) (IntPtr) num2;
          continue;
        default:
          num2 = (short) 0;
          if (num2 == (short) 0)
            ;
          switch (num1)
          {
            case 0:
              goto label_9;
            case 1:
              goto label_12;
            case 2:
              if (this.j != null)
              {
                num2 = (short) 4;
                num1 = (int) (IntPtr) num2;
                continue;
              }
              goto label_12;
            case 3:
              switch (0)
              {
                case 0:
                  break;
                default:
                  continue;
              }
              break;
            case 4:
              this.j.Dispose();
              num2 = (short) 1;
              num1 = (int) (IntPtr) num2;
              continue;
          }
          num2 = (short) 1;
          if (num2 == (short) 0)
            ;
          if (disposing)
          {
            num2 = (short) 0;
            num1 = (int) (IntPtr) num2;
            continue;
          }
          goto label_12;
      }
    }
label_12:
    base.Dispose(disposing);
  }

  private void a()
  {
    int A_1 = 14;
    short num1 = 1;
    if (num1 == (short) 0)
      ;
    num1 = (short) -26256;
    int num2 = (int) num1;
    num1 = (short) -26256;
    int num3 = (int) num1;
    switch (num2 == num3)
    {
      case true:
        num1 = (short) 0;
        if (num1 == (short) 0)
          ;
        this.SuspendLayout();
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(284, 261);
        this.Name = "MainForm";
        this.ShowIcon = false;
        this.ShowInTaskbar = false;
        this.Text = "eCWUrlLauncher";
        this.WindowState = FormWindowState.Minimized;
        this.ResumeLayout(false);
        break;
      default:
        goto case 1;
    }
  }

  static h()
  {
    int A_1 = 15;
    short num1 = -30917;
    int num2 = (int) num1;
    num1 = (short) -30917;
    int num3 = (int) num1;
    switch (num2 == num3)
    {
      case true:
        if (false)
          ;
        if (true)
          ;
        global::h.a = new IntPtr(-1);
        global::h.i = Path.Combine(Path.GetTempPath(), "eClinicalWorks_WebView2_Browser");
        break;
      default:
        goto case 1;
    }
  }
}

