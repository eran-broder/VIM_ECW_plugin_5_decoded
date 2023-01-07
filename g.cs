// Decompiled with JetBrains decompiler
// Type: g
// Assembly: eCWUrlLaunch, Version=4.0.1745.0, Culture=neutral, PublicKeyToken=null
// MVID: CB040BB1-DE0F-4FAE-AA16-19ACB0F0655F
// Assembly location: C:\ProgramData\eClinicalWorks\plugin\eCWUrlLaunch.exe

using log4net;
using log4net.Config;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

public class g
{
  private static ILog a;

  [CompilerGenerated]
  [SpecialName]
  public static bool b()
  {
    short num1 = -5962;
    int num2 = (int) num1;
    num1 = (short) -5962;
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
        // ISSUE: reference to a compiler-generated field
        return g.b;
      default:
        goto case 1;
    }
  }

  [CompilerGenerated]
  [SpecialName]
  public static void b(bool A_0)
  {
    short num1 = -15436;
    int num2 = (int) num1;
    num1 = (short) -15436;
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
        // ISSUE: reference to a compiler-generated field
        g.b = A_0;
        break;
      default:
        goto case 1;
    }
  }

  [CompilerGenerated]
  [SpecialName]
  public static bool a()
  {
    short num1 = -27813;
    int num2 = (int) num1;
    num1 = (short) -27813;
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
        // ISSUE: reference to a compiler-generated field
        return g.c;
      default:
        goto case 1;
    }
  }

  [CompilerGenerated]
  [SpecialName]
  public static void a(bool A_0)
  {
    short num1 = 1;
    if (num1 == (short) 0)
      ;
    num1 = (short) 19507;
    int num2 = (int) num1;
    num1 = (short) 19507;
    int num3 = (int) num1;
    switch (num2 == num3)
    {
      case true:
        num1 = (short) 0;
        if (num1 == (short) 0)
          ;
        // ISSUE: reference to a compiler-generated field
        g.c = A_0;
        break;
      default:
        goto case 1;
    }
  }

  protected g()
  {
  }

  static g()
  {
    int A_1 = 8;
    short num1;
    int num2;
    string str;
    switch (0)
    {
      case 0:
label_3:
        num1 = (short) -17244;
        int num3 = (int) num1;
        num1 = (short) -17244;
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
            g.a = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
            str = AppDomain.CurrentDomain.BaseDirectory + "\eCWUrlLaunchLog.config";
            num1 = (short) 2;
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
          switch (num2)
          {
            case 0:
              goto label_8;
            case 1:
              XmlConfigurator.ConfigureAndWatch(new FileInfo(str));
              num1 = (short) 0;
              num2 = (int) (IntPtr) num1;
              continue;
            case 2:
              if (File.Exists(str))
              {
                num1 = (short) 1;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              goto label_10;
            default:
              goto label_3;
          }
        }
label_8:
        break;
label_10:
        break;
    }
  }

  public static void c(string A_0)
  {
    int A_1 = 18;
    short num1 = 24276;
    int num2 = (int) num1;
    num1 = (short) 24276;
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
        StackTrace stackTrace = new StackTrace();
        g.a.Debug((object) ("[" + stackTrace.GetFrame(1).GetMethod().ReflectedType.FullName + ", Method: " + stackTrace.GetFrame(1).GetMethod().Name + "]==> " + A_0));
        break;
      default:
        goto case 1;
    }
  }

  public static void b(string A_0)
  {
    int A_1 = 3;
    int num1 = 2;
    while (true)
    {
      short num2;
      switch (num1)
      {
        case 0:
          goto label_8;
        case 1:
          StackTrace stackTrace = new StackTrace();
          g.a.Debug((object) ("[" + stackTrace.GetFrame(1).GetMethod().ReflectedType.FullName + ", Method: " + stackTrace.GetFrame(1).GetMethod().Name + "]==> ##### " + A_0));
          num2 = (short) 0;
          num1 = (int) (IntPtr) num2;
          continue;
        case 2:
          num2 = (short) 1;
          if (num2 == (short) 0)
            ;
          switch (0)
          {
            case 0:
              break;
            default:
              continue;
          }
          break;
      }
      num2 = (short) 15864;
      int num3 = (int) num2;
      num2 = (short) 15864;
      int num4 = (int) num2;
      switch (num3 == num4 ? 1 : 0)
      {
        case 0:
        case 2:
          continue;
        default:
          num2 = (short) 0;
          if (num2 == (short) 0)
            ;
          if (g.b())
          {
            num2 = (short) 1;
            num1 = (int) (IntPtr) num2;
            continue;
          }
          goto label_10;
      }
    }
label_8:
    return;
label_10:;
  }

  public static void a(string A_0)
  {
    int A_1 = 0;
    short num1 = 17670;
    int num2 = (int) num1;
    num1 = (short) 17670;
    int num3 = (int) num1;
    switch (num2 == num3)
    {
      case true:
        if (false)
          ;
        if (true)
          ;
        StackTrace stackTrace = new StackTrace();
        g.a.Debug((object) ("[" + stackTrace.GetFrame(1).GetMethod().ReflectedType.FullName + ", Method: " + stackTrace.GetFrame(1).GetMethod().Name + "]==> " + A_0));
        break;
      default:
        goto case 1;
    }
  }

  public static void a(e A_0)
  {
    int A_1 = 19;
    short num1 = 15660;
    int num2 = (int) num1;
    num1 = (short) 15660;
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
        StackTrace stackTrace = new StackTrace();
        g.a.Error((object) ("[" + stackTrace.GetFrame(1).GetMethod().ReflectedType.FullName + ", Method: " + stackTrace.GetFrame(1).GetMethod().Name + "]==> Application Name: " + A_0.n().ToString() + " ,ServerName: " + A_0.l().ToString() + " ,DebugInfo: " + A_0.h().ToString() + " ,Error Message: " + A_0.k().ToString() + " ,Stack Trace: " + A_0.i()));
        break;
      default:
        goto case 1;
    }
  }
}

