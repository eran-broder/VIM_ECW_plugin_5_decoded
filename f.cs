// Decompiled with JetBrains decompiler
// Type: f
// Assembly: eCWUrlLaunch, Version=4.0.1745.0, Culture=neutral, PublicKeyToken=null
// MVID: CB040BB1-DE0F-4FAE-AA16-19ACB0F0655F
// Assembly location: C:\ProgramData\eClinicalWorks\plugin\eCWUrlLaunch.exe

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

[ExcludeFromCodeCoverage]
internal class f
{
  private const int a = 13;
  private const int b = 256;
  private const int c = 257;
  private const int d = 260;
  private const int e = 261;
  private const int f = 16;
  private const int g = 17;
  private const int h = 18;
  private const int i = 20;
  public List<Keys> j = new List<Keys>();
  public int k;
  private IntPtr l = IntPtr.Zero;

  [CompilerGenerated]
  [SpecialName]
  public void f(KeyEventHandler A_0)
  {
    int num1;
    short num2;
    KeyEventHandler keyEventHandler;
    switch (0)
    {
      case 0:
label_2:
        num2 = (short) 2499;
        int num3 = (int) num2;
        num2 = (short) 2499;
        int num4 = (int) num2;
        switch (num3 == num4 ? 1 : 0)
        {
          case 0:
            return;
          case 2:
            return;
          default:
            num2 = (short) 0;
            if (num2 == (short) 0)
              ;
            // ISSUE: reference to a compiler-generated field
            keyEventHandler = this.m;
            num2 = (short) 1;
            num1 = (int) (IntPtr) num2;
            goto label_1;
        }
      default:
label_1:
        KeyEventHandler comparand;
        while (true)
        {
          switch (num1)
          {
            case 0:
              if (keyEventHandler == comparand)
              {
                num2 = (short) 1;
                if (num2 == (short) 0)
                  ;
                num2 = (short) 2;
                num1 = (int) (IntPtr) num2;
                continue;
              }
              goto case 1;
            case 1:
              comparand = keyEventHandler;
              // ISSUE: reference to a compiler-generated field
              keyEventHandler = Interlocked.CompareExchange<KeyEventHandler>(ref this.m, comparand + A_0, comparand);
              num2 = (short) 0;
              num1 = (int) (IntPtr) num2;
              continue;
            case 2:
              goto label_10;
            default:
              goto label_2;
          }
        }
label_10:
        break;
    }
  }

  [CompilerGenerated]
  [SpecialName]
  public void e(KeyEventHandler A_0)
  {
    short num1;
    int num2;
    KeyEventHandler keyEventHandler;
    switch (0)
    {
      case 0:
label_3:
        num1 = (short) 6108;
        int num3 = (int) num1;
        num1 = (short) 6108;
        int num4 = (int) num1;
        switch (num3 == num4 ? 1 : 0)
        {
          case 0:
            return;
          case 2:
            return;
          default:
            num1 = (short) 0;
            if (num1 == (short) 0)
              ;
            // ISSUE: reference to a compiler-generated field
            keyEventHandler = this.m;
            num1 = (short) 1;
            num2 = (int) (IntPtr) num1;
            goto label_1;
        }
      default:
label_1:
        while (true)
        {
          num1 = (short) 1;
          if (num1 == (short) 0)
            ;
          KeyEventHandler comparand;
          switch (num2)
          {
            case 0:
              if (keyEventHandler == comparand)
              {
                num1 = (short) 2;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              goto case 1;
            case 1:
              comparand = keyEventHandler;
              // ISSUE: reference to a compiler-generated field
              keyEventHandler = Interlocked.CompareExchange<KeyEventHandler>(ref this.m, comparand - A_0, comparand);
              num1 = (short) 0;
              num2 = (int) (IntPtr) num1;
              continue;
            case 2:
              goto label_10;
            default:
              goto label_3;
          }
        }
label_10:
        break;
    }
  }

  [CompilerGenerated]
  [SpecialName]
  public void d(KeyEventHandler A_0)
  {
    int num1;
    short num2;
    KeyEventHandler keyEventHandler;
    switch (0)
    {
      case 0:
label_2:
        num2 = (short) -2286;
        int num3 = (int) num2;
        num2 = (short) -2286;
        int num4 = (int) num2;
        switch (num3 == num4 ? 1 : 0)
        {
          case 0:
            return;
          case 2:
            return;
          default:
            num2 = (short) 0;
            if (num2 == (short) 0)
              ;
            // ISSUE: reference to a compiler-generated field
            keyEventHandler = this.n;
            num2 = (short) 1;
            num1 = (int) (IntPtr) num2;
            goto label_1;
        }
      default:
label_1:
        while (true)
        {
          KeyEventHandler comparand;
          switch (num1)
          {
            case 0:
              if (keyEventHandler == comparand)
              {
                num2 = (short) 2;
                num1 = (int) (IntPtr) num2;
                continue;
              }
              break;
            case 1:
              num2 = (short) 1;
              if (num2 == (short) 0)
                break;
              break;
            case 2:
              goto label_10;
            default:
              goto label_2;
          }
          comparand = keyEventHandler;
          // ISSUE: reference to a compiler-generated field
          keyEventHandler = Interlocked.CompareExchange<KeyEventHandler>(ref this.n, comparand + A_0, comparand);
          num2 = (short) 0;
          num1 = (int) (IntPtr) num2;
        }
label_10:
        break;
    }
  }

  [CompilerGenerated]
  [SpecialName]
  public void c(KeyEventHandler A_0)
  {
    int num1;
    short num2;
    KeyEventHandler keyEventHandler;
    switch (0)
    {
      case 0:
label_2:
        num2 = (short) -23613;
        int num3 = (int) num2;
        num2 = (short) -23613;
        int num4 = (int) num2;
        switch (num3 == num4 ? 1 : 0)
        {
          case 0:
            return;
          case 2:
            return;
          default:
            num2 = (short) 0;
            if (num2 == (short) 0)
              ;
            // ISSUE: reference to a compiler-generated field
            keyEventHandler = this.n;
            num2 = (short) 1;
            num1 = (int) (IntPtr) num2;
            goto label_1;
        }
      default:
label_1:
        KeyEventHandler comparand;
        while (true)
        {
          switch (num1)
          {
            case 0:
              num2 = (short) 1;
              if (num2 == (short) 0)
                ;
              if (keyEventHandler == comparand)
              {
                num2 = (short) 2;
                num1 = (int) (IntPtr) num2;
                continue;
              }
              goto case 1;
            case 1:
              comparand = keyEventHandler;
              // ISSUE: reference to a compiler-generated field
              keyEventHandler = Interlocked.CompareExchange<KeyEventHandler>(ref this.n, comparand - A_0, comparand);
              num2 = (short) 0;
              num1 = (int) (IntPtr) num2;
              continue;
            case 2:
              goto label_10;
            default:
              goto label_2;
          }
        }
label_10:
        break;
    }
  }

  public f(int A_0)
  {
    this.k = A_0;
    this.d();
  }

  ~f()
  {
    short num1 = -20696;
    int num2 = (int) num1;
    num1 = (short) -20696;
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
        this.c();
        break;
      default:
        goto case 1;
    }
  }

  public void d()
  {
    int A_1 = 13;
    short num1 = -11709;
    int num2 = (int) num1;
    num1 = (short) -11709;
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
        this.l = global::f.SetWindowsHookEx(13, new global::f.a(this.c), global::f.LoadLibrary("User32"), 0U);
        break;
      default:
        goto case 1;
    }
  }

  public void c()
  {
    short num1 = 1;
    if (num1 == (short) 0)
      ;
    num1 = (short) -19614;
    int num2 = (int) num1;
    num1 = (short) -19614;
    int num3 = (int) num1;
    switch (num2 == num3)
    {
      case true:
        num1 = (short) 0;
        if (num1 == (short) 0)
          ;
        global::f.UnhookWindowsHookEx(this.l);
        break;
      default:
        goto case 1;
    }
  }

  public int c(int A_0, int A_1, ref global::f.b A_2)
  {
    switch (0)
    {
      default:
        short num1 = 27;
        int num2 = (int) (IntPtr) num1;
        while (true)
        {
          Keys keys1;
          Keys keys2;
          KeyEventArgs e;
          Keys keys3;
          Keys keys4;
          Keys keys5;
          switch (num2)
          {
            case 0:
              if (keys1 != keys4)
              {
                num1 = (short) 22;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              goto case 26;
            case 1:
              if (A_1 == 260)
              {
                num1 = (short) 25;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              break;
            case 2:
              if (A_1 != 256)
              {
                num1 = (short) 3;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              goto case 25;
            case 3:
              num1 = (short) 1;
              num2 = (int) (IntPtr) num1;
              continue;
            case 4:
              if (keys1 != Keys.F12)
              {
                num1 = (short) 8;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              goto case 26;
            case 5:
            case 7:
              num1 = (short) 29;
              num2 = (int) (IntPtr) num1;
              continue;
            case 6:
              if (A_1 != 257)
              {
                num1 = (short) 19;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              goto case 28;
            case 8:
              num1 = (short) 23;
              num2 = (int) (IntPtr) num1;
              continue;
            case 9:
              if (this.j.Contains(keys1))
              {
                num1 = (short) 31;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              goto label_54;
            case 10:
              num1 = (short) 15;
              num2 = (int) (IntPtr) num1;
              continue;
            case 11:
              // ISSUE: reference to a compiler-generated field
              this.n((object) this, e);
              num1 = (short) 5;
              num2 = (int) (IntPtr) num1;
              continue;
            case 12:
              goto label_34;
            case 13:
              // ISSUE: reference to a compiler-generated field
              if (this.n != null)
              {
                num1 = (short) 11;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              goto case 5;
            case 14:
              if (global::n.b(this.k))
              {
                num1 = (short) 21;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              goto label_54;
            case 15:
              if (keys1 != keys2)
              {
                num1 = (short) 17;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              goto case 26;
            case 16:
              if (keys1 == keys5)
              {
                num1 = (short) 26;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              goto label_54;
            case 17:
              num1 = (short) 0;
              num2 = (int) (IntPtr) num1;
              continue;
            case 18:
              if (A_1 == 261)
              {
                num1 = (short) 28;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              goto case 5;
            case 19:
              num1 = (short) 18;
              num2 = (int) (IntPtr) num1;
              continue;
            case 20:
label_53:
              // ISSUE: reference to a compiler-generated field
              this.m((object) this, e);
              num1 = (short) 7;
              num2 = (int) (IntPtr) num1;
              continue;
            case 21:
              e = new KeyEventArgs(keys1);
              num1 = (short) 2;
              num2 = (int) (IntPtr) num1;
              continue;
            case 22:
              num1 = (short) 16;
              num2 = (int) (IntPtr) num1;
              continue;
            case 23:
              if (keys1 != keys3)
              {
                num1 = (short) 10;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              goto case 26;
            case 24:
              keys1 = (Keys) A_2.a;
              num1 = (short) 9;
              num2 = (int) (IntPtr) num1;
              continue;
            case 25:
              num1 = (short) 30;
              num2 = (int) (IntPtr) num1;
              continue;
            case 26:
              num1 = (short) 14;
              num2 = (int) (IntPtr) num1;
              continue;
            case 27:
              switch (0)
              {
                case 0:
                  goto label_4;
                default:
                  continue;
              }
            case 28:
              num1 = (short) 13;
              num2 = (int) (IntPtr) num1;
              continue;
            case 29:
              if (e.Handled)
              {
                num1 = (short) 12;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              goto label_54;
            case 30:
              // ISSUE: reference to a compiler-generated field
              if (this.m != null)
              {
                num1 = (short) 20;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              break;
            case 31:
              num1 = (short) -11899;
              int num3 = (int) num1;
              num1 = (short) -11899;
              int num4 = (int) num1;
              switch (num3 == num4 ? 1 : 0)
              {
                case 0:
                case 2:
                  goto label_53;
                default:
                  num1 = (short) 1;
                  if (num1 == (short) 0)
                    ;
                  num1 = (short) 0;
                  if (num1 == (short) 0)
                    ;
                  keys1 = this.c(keys1);
                  keys3 = Keys.I | Keys.Shift | Keys.Control;
                  keys4 = Keys.J | Keys.Shift | Keys.Control;
                  keys5 = Keys.C | Keys.Shift | Keys.Control;
                  keys2 = Keys.U | Keys.Control;
                  num1 = (short) 4;
                  num2 = (int) (IntPtr) num1;
                  continue;
              }
            default:
label_4:
              if (A_0 >= 0)
              {
                num1 = (short) 24;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              goto label_54;
          }
          num1 = (short) 6;
          num2 = (int) (IntPtr) num1;
        }
label_34:
        return 1;
label_54:
        return global::f.CallNextHookEx(this.l, A_0, A_1, ref A_2);
    }
  }

  private Keys c(Keys A_0)
  {
    int num1 = 7;
    while (true)
    {
      short num2;
      switch (num1)
      {
        case 0:
          num2 = (short) 1;
          if (num2 == (short) 0)
            break;
          break;
        case 1:
          A_0 |= Keys.Alt;
          num2 = (short) 5;
          num1 = (int) (IntPtr) num2;
          continue;
        case 2:
          num2 = (short) 11;
          num1 = (int) (IntPtr) num2;
          continue;
        case 3:
          num2 = (short) 8;
          num1 = (int) (IntPtr) num2;
          continue;
        case 4:
          num2 = (short) 132;
          int num3 = (int) num2;
          num2 = (short) 132;
          int num4 = (int) num2;
          switch (num3 == num4 ? 1 : 0)
          {
            case 0:
            case 2:
              goto label_5;
            default:
              num2 = (short) 0;
              if (num2 == (short) 0)
                ;
              A_0 |= Keys.Shift;
              num2 = (short) 3;
              num1 = (int) (IntPtr) num2;
              continue;
          }
        case 5:
          goto label_21;
        case 6:
          if (((int) global::f.GetKeyState(16) & 32768) != 0)
          {
            num2 = (short) 4;
            num1 = (int) (IntPtr) num2;
            continue;
          }
          goto case 3;
        case 7:
          switch (0)
          {
            case 0:
              goto label_3;
            default:
              continue;
          }
        case 8:
          if (((int) global::f.GetKeyState(17) & 32768) != 0)
          {
            num2 = (short) 9;
            num1 = (int) (IntPtr) num2;
            continue;
          }
          goto case 2;
        case 9:
label_5:
          A_0 |= Keys.Control;
          num2 = (short) 2;
          num1 = (int) (IntPtr) num2;
          continue;
        case 10:
          A_0 |= Keys.Capital;
          num2 = (short) 0;
          num1 = (int) (IntPtr) num2;
          continue;
        case 11:
          if (((int) global::f.GetKeyState(18) & 32768) != 0)
          {
            num2 = (short) 1;
            num1 = (int) (IntPtr) num2;
            continue;
          }
          goto label_21;
        default:
label_3:
          if (((int) global::f.GetKeyState(20) & 1) != 0)
          {
            num2 = (short) 10;
            num1 = (int) (IntPtr) num2;
            continue;
          }
          break;
      }
      num2 = (short) 6;
      num1 = (int) (IntPtr) num2;
    }
label_21:
    return A_0;
  }

  [DllImport("user32.dll")]
  private static extern IntPtr SetWindowsHookEx(int A_0, global::f.a A_1, IntPtr A_2, uint A_3);

  [DllImport("user32.dll")]
  private static extern bool UnhookWindowsHookEx(IntPtr A_0);

  [DllImport("user32.dll")]
  private static extern int CallNextHookEx(IntPtr A_0, int A_1, int A_2, ref global::f.b A_3);

  [DllImport("kernel32.dll")]
  private static extern IntPtr LoadLibrary(string A_0);

  [DllImport("user32.dll", CharSet = CharSet.Auto)]
  public static extern short GetKeyState(int A_0);

  public delegate int a(int A_0, int A_1, ref global::f.b A_2);

  public struct b
  {
    public int a;
    public int b;
    public int c;
    public int d;
    public int e;
  }
}

