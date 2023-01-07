// Decompiled with JetBrains decompiler
// Type: k
// Assembly: eCWUrlLaunch, Version=4.0.1745.0, Culture=neutral, PublicKeyToken=null
// MVID: CB040BB1-DE0F-4FAE-AA16-19ACB0F0655F
// Assembly location: C:\ProgramData\eClinicalWorks\plugin\eCWUrlLaunch.exe

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Threading;

public class k
{
  private static Timer a;
  private static int b;

  [ExcludeFromCodeCoverage]
  [DllImport("User32.dll")]
  public static extern bool LockWorkStation();

  [ExcludeFromCodeCoverage]
  [DllImport("User32.dll")]
  private static extern bool GetLastInputInfo(ref j A_0);

  [ExcludeFromCodeCoverage]
  [DllImport("Kernel32.dll")]
  private static extern uint GetLastError();

  public k(int A_0) => k.b = A_0;

  public void d()
  {
    short num1 = 9931;
    int num2 = (int) num1;
    num1 = (short) 9931;
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
        k.a = new Timer(new TimerCallback(k.a), (object) null, 0, 2000);
        break;
      default:
        goto case 1;
    }
  }

  public static uint c()
  {
    short num1 = 23006;
    int num2 = (int) num1;
    num1 = (short) 23006;
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
        j A_0 = new j();
        A_0.a = (uint) Marshal.SizeOf<j>(A_0);
        k.GetLastInputInfo(ref A_0);
        return (uint) Environment.TickCount - A_0.b;
      default:
        goto case 1;
    }
  }

  public static long b()
  {
    short num1 = -14201;
    int num2 = (int) num1;
    num1 = (short) -14201;
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
        return (long) Environment.TickCount;
      default:
        goto case 1;
    }
  }

  public static long a()
  {
label_0:
    j A_0 = new j();
    A_0.a = (uint) Marshal.SizeOf<j>(A_0);
    if (!k.GetLastInputInfo(ref A_0))
      throw new Exception(k.GetLastError().ToString());
    if (false)
      ;
    switch (true ? 1 : 0)
    {
      case 0:
      case 2:
        goto label_0;
      default:
        if (true)
          ;
        return (long) A_0.b;
    }
  }

  private static void a(object A_0)
  {
    int num1 = 2;
    while (true)
    {
      short num2;
      switch (num1)
      {
        case 0:
          goto label_6;
        case 1:
label_7:
          k.LockWorkStation();
          num2 = (short) -20438;
          int num3 = (int) num2;
          num2 = (short) -20438;
          int num4 = (int) num2;
          switch (num3 == num4 ? 1 : 0)
          {
            case 0:
            case 2:
              goto label_7;
            default:
              num2 = (short) 0;
              if (num2 == (short) 0)
                ;
              num2 = (short) 0;
              num1 = (int) (IntPtr) num2;
              continue;
          }
        case 2:
          switch (0)
          {
            case 0:
              break;
            default:
              continue;
          }
          break;
      }
      if ((long) k.c() > (long) k.b)
      {
        num2 = (short) 1;
        if (num2 == (short) 0)
          ;
        num2 = (short) 1;
        num1 = (int) (IntPtr) num2;
      }
      else
        goto label_10;
    }
label_6:
    return;
label_10:;
  }
}

