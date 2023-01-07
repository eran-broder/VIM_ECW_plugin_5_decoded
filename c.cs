// Decompiled with JetBrains decompiler
// Type: c
// Assembly: eCWUrlLaunch, Version=4.0.1745.0, Culture=neutral, PublicKeyToken=null
// MVID: CB040BB1-DE0F-4FAE-AA16-19ACB0F0655F
// Assembly location: C:\ProgramData\eClinicalWorks\plugin\eCWUrlLaunch.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

public class c
{
  private static Uri a;
  private static string b;
  private static NetworkCredential c;
  private static Uri d;

  [CompilerGenerated]
  [SpecialName]
  public static void b(global::c.a A_0)
  {
    int num1;
    short num2;
    global::c.a a1;
    switch (0)
    {
      case 0:
label_2:
        num2 = (short) -14618;
        int num3 = (int) num2;
        num2 = (short) -14618;
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
            // ISSUE: reference to a compiler-generated field
            a1 = global::c.e;
            num2 = (short) 1;
            num1 = (int) (IntPtr) num2;
            goto label_1;
        }
        break;
      default:
label_1:
        global::c.a comparand;
        while (true)
        {
          switch (num1)
          {
            case 0:
              goto label_9;
            case 1:
              comparand = a1;
              global::c.a a2 = comparand + A_0;
              // ISSUE: reference to a compiler-generated field
              a1 = Interlocked.CompareExchange<global::c.a>(ref global::c.e, a2, comparand);
              num2 = (short) 2;
              num1 = (int) (IntPtr) num2;
              continue;
            case 2:
              if (a1 != comparand)
                goto case 1;
              else
                goto label_8;
            default:
              goto label_2;
          }
        }
label_9:
        return;
    }
label_8:
    num2 = (short) 0;
    num1 = (int) (IntPtr) num2;
    goto label_1;
  }

  [CompilerGenerated]
  [SpecialName]
  public static void a(global::c.a A_0)
  {
    int num1;
    short num2;
    global::c.a a1;
    switch (0)
    {
      case 0:
label_2:
        num2 = (short) 30047;
        int num3 = (int) num2;
        num2 = (short) 30047;
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
            // ISSUE: reference to a compiler-generated field
            a1 = global::c.e;
            num2 = (short) 1;
            num1 = (int) (IntPtr) num2;
            goto label_1;
        }
        break;
      default:
label_1:
        global::c.a comparand;
        while (true)
        {
          switch (num1)
          {
            case 0:
              goto label_9;
            case 1:
              comparand = a1;
              global::c.a a2 = comparand - A_0;
              // ISSUE: reference to a compiler-generated field
              a1 = Interlocked.CompareExchange<global::c.a>(ref global::c.e, a2, comparand);
              num2 = (short) 2;
              num1 = (int) (IntPtr) num2;
              continue;
            case 2:
              num2 = (short) 1;
              if (num2 == (short) 0)
                ;
              if (a1 != comparand)
                goto case 1;
              else
                goto label_8;
            default:
              goto label_2;
          }
        }
label_9:
        return;
    }
label_8:
    num2 = (short) 0;
    num1 = (int) (IntPtr) num2;
    goto label_1;
  }

  protected c()
  {
  }

  public static bool b(Uri A_0, string A_1, NetworkCredential A_2 = null)
  {
    int A_1_1 = 6;
label_1:
    g.a("Started");
    bool flag = false;
    try
    {
      global::c.a = A_0;
      global::c.b = A_1;
      flag = global::c.a<bool>(new Func<bool>(global::c.b), TimeSpan.FromSeconds(1.0));
    }
    catch (Exception ex)
    {
      g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
      flag = false;
    }
    finally
    {
      g.a("Completed");
    }
    short num = -5836;
    switch ((short) -5836 == num ? 1 : 0)
    {
      case 0:
      case 2:
        goto label_1;
      default:
        num = (short) 0;
        if (num == (short) 0)
          ;
        num = (short) 1;
        if (num == (short) 0)
          ;
        return flag;
    }
  }

  public static string a(Uri A_0, NetworkCredential A_1 = null)
  {
    int A_1_1 = 5;
label_1:
    g.a("Started");
    string str = string.Empty;
    try
    {
      if (false)
        ;
      global::c.a = A_0;
      global::c.c = A_1;
      str = global::c.a<string>(new Func<string>(global::c.c), TimeSpan.FromSeconds(1.0));
    }
    catch (Exception ex)
    {
      g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
      str = string.Empty;
    }
    finally
    {
      g.a("Completed");
    }
    switch (true ? 1 : 0)
    {
      case 0:
      case 2:
        goto label_1;
      default:
        if (true)
          ;
        return str;
    }
  }

  private static string c()
  {
    int A_1 = 10;
    switch (0)
    {
      default:
        if (false)
          ;
        g.a("Started");
        string str = string.Empty;
        try
        {
          short num1 = 2;
          int num2 = (int) (IntPtr) num1;
          while (true)
          {
            Stream responseStream;
            WebResponse response;
            global::d A_0;
            switch (num2)
            {
              case 0:
                num1 = (short) 27420;
                int num3 = (int) num1;
                num1 = (short) 27420;
                int num4 = (int) num1;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    continue;
                  default:
                    num1 = (short) 0;
                    if (num1 == (short) 0)
                      ;
                    // ISSUE: reference to a compiler-generated field
                    global::c.e(A_0);
                    num1 = (short) 5;
                    num2 = (int) (IntPtr) num1;
                    continue;
                }
              case 1:
                // ISSUE: reference to a compiler-generated field
                if (global::c.e != null)
                {
                  num1 = (short) 0;
                  num2 = (int) (IntPtr) num1;
                  continue;
                }
                goto case 5;
              case 2:
                switch (0)
                {
                  case 0:
                    break;
                  default:
                    continue;
                }
                break;
              case 3:
                try
                {
                  str = new StreamReader(responseStream, Encoding.UTF8).ReadToEnd();
                }
                finally
                {
                  short num5 = 1;
                  int num6 = (int) (IntPtr) num5;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 0:
                        goto label_14;
                      case 1:
                        switch (0)
                        {
                          case 0:
                            break;
                          default:
                            continue;
                        }
                        break;
                      case 2:
                        responseStream.Dispose();
                        num5 = (short) 0;
                        num6 = (int) (IntPtr) num5;
                        continue;
                    }
                    if (responseStream != null)
                    {
                      num5 = (short) 2;
                      num6 = (int) (IntPtr) num5;
                    }
                    else
                      break;
                  }
label_14:;
                }
                num1 = (short) 4;
                num2 = (int) (IntPtr) num1;
                continue;
              case 4:
                goto label_24;
              case 5:
                responseStream = response.GetResponseStream();
                num1 = (short) 3;
                num2 = (int) (IntPtr) num1;
                continue;
            }
            g.a("Download Url :: " + global::c.a?.ToString());
            ServicePointManager.SecurityProtocol = (SecurityProtocolType) 4032;
            response = WebRequest.Create(global::c.a).GetResponse();
            A_0 = new global::d();
            A_0.d(0L);
            num1 = (short) 1;
            num2 = (int) (IntPtr) num1;
          }
        }
        catch (Exception ex)
        {
          g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
          str = string.Empty;
        }
        finally
        {
          g.a("Completed");
        }
label_24:
        return str;
    }
  }

  private static bool b()
  {
    int A_1 = 14;
    switch (0)
    {
      default:
        g.a("Started");
        bool flag = false;
        try
        {
          short num1 = 5;
          int num2 = (int) (IntPtr) num1;
          global::d A_0_1;
          WebResponse response;
          Stream responseStream;
          byte[] buffer;
          long A_0_2;
          while (true)
          {
            switch (num2)
            {
              case 0:
                // ISSUE: reference to a compiler-generated field
                if (global::c.e != null)
                {
                  num1 = (short) 3;
                  num2 = (int) (IntPtr) num1;
                  continue;
                }
                goto case 2;
              case 1:
                num1 = (short) 7;
                num2 = (int) (IntPtr) num1;
                continue;
              case 2:
                num1 = (short) 1;
                if (num1 == (short) 0)
                  ;
                responseStream = response.GetResponseStream();
                num1 = (short) 4;
                num2 = (int) (IntPtr) num1;
                continue;
              case 3:
                // ISSUE: reference to a compiler-generated field
                global::c.e(A_0_1);
                num1 = (short) 2;
                num2 = (int) (IntPtr) num1;
                continue;
              case 4:
label_15:
                try
                {
                  FileStream fileStream = System.IO.File.Create(global::c.b);
label_16:
                  try
                  {
                    int count;
                    switch (0)
                    {
                      case 0:
label_18:
                        count = responseStream.Read(buffer, 0, buffer.Length);
                        num1 = (short) 5;
                        num2 = (int) (IntPtr) num1;
                        goto default;
                      default:
                        while (true)
                        {
                          switch (num2)
                          {
                            case 0:
                              // ISSUE: reference to a compiler-generated field
                              if (global::c.e != null)
                              {
                                num1 = (short) 3;
                                num2 = (int) (IntPtr) num1;
                                continue;
                              }
                              goto label_16;
                            case 1:
                              num1 = (short) 7;
                              num2 = (int) (IntPtr) num1;
                              continue;
                            case 2:
                              // ISSUE: reference to a compiler-generated field
                              if (global::c.e != null)
                              {
                                num1 = (short) 8;
                                num2 = (int) (IntPtr) num1;
                                continue;
                              }
                              goto case 1;
                            case 3:
                              // ISSUE: reference to a compiler-generated field
                              global::c.e(A_0_1);
                              num1 = (short) 4;
                              num2 = (int) (IntPtr) num1;
                              continue;
                            case 4:
                              goto label_16;
                            case 5:
                              if (count == 0)
                              {
                                num1 = (short) 6;
                                num2 = (int) (IntPtr) num1;
                                continue;
                              }
                              fileStream.Write(buffer, 0, count);
                              A_0_1.d(long.Parse(fileStream.Length.ToString()));
                              A_0_1.c(A_0_2);
                              num1 = (short) 0;
                              num2 = (int) (IntPtr) num1;
                              continue;
                            case 6:
                              A_0_1.d(A_0_2);
                              A_0_1.c(A_0_2);
                              num1 = (short) 2;
                              num2 = (int) (IntPtr) num1;
                              continue;
                            case 7:
                              goto label_37;
                            case 8:
                              // ISSUE: reference to a compiler-generated field
                              global::c.e(A_0_1);
                              num1 = (short) 1;
                              num2 = (int) (IntPtr) num1;
                              continue;
                            default:
                              goto label_18;
                          }
                        }
                    }
                  }
                  finally
                  {
                    short num3 = 1;
                    num2 = (int) (IntPtr) num3;
                    while (true)
                    {
                      switch (num2)
                      {
                        case 0:
                          goto label_36;
                        case 1:
                          switch (0)
                          {
                            case 0:
                              break;
                            default:
                              continue;
                          }
                          break;
                        case 2:
                          fileStream.Dispose();
                          num3 = (short) 0;
                          num2 = (int) (IntPtr) num3;
                          continue;
                      }
                      if (fileStream != null)
                      {
                        num3 = (short) 2;
                        num2 = (int) (IntPtr) num3;
                      }
                      else
                        break;
                    }
label_36:;
                  }
label_37:
                  num1 = (short) -5714;
                  int num4 = (int) num1;
                  num1 = (short) -5714;
                  int num5 = (int) num1;
                  switch (num4 == num5 ? 1 : 0)
                  {
                    case 0:
                    case 2:
                      goto label_15;
                    default:
                      num1 = (short) 0;
                      if (num1 == (short) 0)
                        break;
                      break;
                  }
                }
                finally
                {
                  int num6 = 1;
                  while (true)
                  {
                    short num7;
                    switch (num6)
                    {
                      case 0:
                        goto label_45;
                      case 1:
                        switch (0)
                        {
                          case 0:
                            break;
                          default:
                            continue;
                        }
                        break;
                      case 2:
                        responseStream.Dispose();
                        num7 = (short) 0;
                        num6 = (int) (IntPtr) num7;
                        continue;
                    }
                    if (responseStream != null)
                    {
                      num7 = (short) 2;
                      num6 = (int) (IntPtr) num7;
                    }
                    else
                      break;
                  }
label_45:;
                }
                flag = true;
                num1 = (short) 1;
                num2 = (int) (IntPtr) num1;
                continue;
              case 5:
                switch (0)
                {
                  case 0:
                    goto label_5;
                  default:
                    continue;
                }
              case 6:
                num1 = (short) 8;
                num2 = (int) (IntPtr) num1;
                continue;
              case 7:
                goto label_49;
              case 8:
                g.a("Download Url :: " + global::c.a?.ToString());
                g.a("File Path :: " + global::c.b);
                ServicePointManager.SecurityProtocol = (SecurityProtocolType) 4032;
                response = WebRequest.Create(global::c.a).GetResponse();
                buffer = new byte[8192];
                A_0_2 = 125829120L;
                A_0_1 = new global::d();
                A_0_1.d(0L);
                num1 = (short) 0;
                num2 = (int) (IntPtr) num1;
                continue;
              default:
label_5:
                if (global::c.a != (Uri) null)
                {
                  num1 = (short) 6;
                  num2 = (int) (IntPtr) num1;
                  continue;
                }
                goto case 1;
            }
          }
        }
        catch (Exception ex)
        {
          g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
          throw;
        }
        finally
        {
          g.a("Completed");
        }
label_49:
        return flag;
    }
  }

  public static bool a(Uri A_0, string A_1, NetworkCredential A_2 = null)
  {
    int A_1_1 = 12;
label_1:
    short num1 = 1;
    if (num1 == (short) 0)
      ;
    g.a("Started");
    bool flag = false;
    try
    {
      global::c.d = A_0;
      global::c.b = A_1;
      global::c.c = A_2;
      flag = global::c.a<bool>(new Func<bool>(global::c.a), TimeSpan.FromSeconds(1.0));
    }
    catch (Exception ex)
    {
      g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
      flag = false;
    }
    finally
    {
      g.a("Completed");
    }
    num1 = (short) 30266;
    int num2 = (int) num1;
    num1 = (short) 30266;
    int num3 = (int) num1;
    switch (num2 == num3 ? 1 : 0)
    {
      case 0:
      case 2:
        goto label_1;
      default:
        num1 = (short) 0;
        if (num1 == (short) 0)
          ;
        return flag;
    }
  }

  private static bool a()
  {
    int A_1 = 18;
    switch (0)
    {
      default:
        short num1 = 1;
        if (num1 == (short) 0)
          ;
        g.a("Started");
        bool flag1 = false;
        bool flag2;
        try
        {
          num1 = (short) 14;
          int num2 = (int) (IntPtr) num1;
          global::d A_0;
          FtpWebRequest ftpWebRequest;
          byte[] buffer;
          long contentLength;
          Stream responseStream;
          while (true)
          {
            switch (num2)
            {
              case 0:
                ftpWebRequest = (FtpWebRequest) WebRequest.Create(global::c.d);
                num1 = (short) 8;
                num2 = (int) (IntPtr) num1;
                continue;
              case 1:
                // ISSUE: reference to a compiler-generated field
                if (global::c.e != null)
                {
                  num1 = (short) 3;
                  num2 = (int) (IntPtr) num1;
                  continue;
                }
                goto case 0;
              case 2:
                ftpWebRequest.Credentials = (ICredentials) global::c.c;
                num1 = (short) 13;
                num2 = (int) (IntPtr) num1;
                continue;
              case 3:
                // ISSUE: reference to a compiler-generated field
                global::c.e(A_0);
                num1 = (short) 0;
                num2 = (int) (IntPtr) num1;
                continue;
              case 4:
                num1 = (short) 9;
                num2 = (int) (IntPtr) num1;
                continue;
              case 5:
label_28:
                try
                {
                  FileStream fileStream = System.IO.File.Create(global::c.b);
label_29:
                  try
                  {
                    int count;
                    switch (0)
                    {
                      case 0:
label_31:
                        count = responseStream.Read(buffer, 0, buffer.Length);
                        num1 = (short) 5;
                        num2 = (int) (IntPtr) num1;
                        goto default;
                      default:
                        while (true)
                        {
                          switch (num2)
                          {
                            case 0:
                              // ISSUE: reference to a compiler-generated field
                              if (global::c.e != null)
                              {
                                num1 = (short) 3;
                                num2 = (int) (IntPtr) num1;
                                continue;
                              }
                              goto case 4;
                            case 1:
                              goto label_29;
                            case 2:
                              // ISSUE: reference to a compiler-generated field
                              if (global::c.e != null)
                              {
                                num1 = (short) 8;
                                num2 = (int) (IntPtr) num1;
                                continue;
                              }
                              goto label_29;
                            case 3:
                              // ISSUE: reference to a compiler-generated field
                              global::c.e(A_0);
                              num1 = (short) 4;
                              num2 = (int) (IntPtr) num1;
                              continue;
                            case 4:
                              num1 = (short) 7;
                              num2 = (int) (IntPtr) num1;
                              continue;
                            case 5:
                              if (count == 0)
                              {
                                num1 = (short) 6;
                                num2 = (int) (IntPtr) num1;
                                continue;
                              }
                              fileStream.Write(buffer, 0, count);
                              A_0.d(long.Parse(fileStream.Length.ToString()));
                              A_0.c(contentLength);
                              num1 = (short) 2;
                              num2 = (int) (IntPtr) num1;
                              continue;
                            case 6:
                              A_0.d(contentLength);
                              A_0.c(contentLength);
                              num1 = (short) 0;
                              num2 = (int) (IntPtr) num1;
                              continue;
                            case 7:
                              goto label_50;
                            case 8:
                              // ISSUE: reference to a compiler-generated field
                              global::c.e(A_0);
                              num1 = (short) 1;
                              num2 = (int) (IntPtr) num1;
                              continue;
                            default:
                              goto label_31;
                          }
                        }
                    }
                  }
                  finally
                  {
                    short num3 = 1;
                    num2 = (int) (IntPtr) num3;
                    while (true)
                    {
                      switch (num2)
                      {
                        case 0:
                          goto label_49;
                        case 1:
                          switch (0)
                          {
                            case 0:
                              break;
                            default:
                              continue;
                          }
                          break;
                        case 2:
                          fileStream.Dispose();
                          num3 = (short) 0;
                          num2 = (int) (IntPtr) num3;
                          continue;
                      }
                      if (fileStream != null)
                      {
                        num3 = (short) 2;
                        num2 = (int) (IntPtr) num3;
                      }
                      else
                        break;
                    }
label_49:;
                  }
label_50:
                  num1 = (short) 31608;
                  int num4 = (int) num1;
                  num1 = (short) 31608;
                  int num5 = (int) num1;
                  switch (num4 == num5 ? 1 : 0)
                  {
                    case 0:
                    case 2:
                      goto label_28;
                    default:
                      num1 = (short) 0;
                      if (num1 == (short) 0)
                        break;
                      break;
                  }
                }
                finally
                {
                  int num6 = 1;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 0:
                        goto label_58;
                      case 1:
                        switch (0)
                        {
                          case 0:
                            break;
                          default:
                            continue;
                        }
                        break;
                      case 2:
                        responseStream.Dispose();
                        num6 = 0;
                        continue;
                    }
                    if (responseStream != null)
                      num6 = 2;
                    else
                      break;
                  }
label_58:;
                }
                flag1 = true;
                num1 = (short) 10;
                num2 = (int) (IntPtr) num1;
                continue;
              case 6:
                if (contentLength < 0L)
                {
                  num1 = (short) 7;
                  num2 = (int) (IntPtr) num1;
                  continue;
                }
                A_0 = new global::d();
                A_0.d(0L);
                A_0.c(contentLength);
                num1 = (short) 1;
                num2 = (int) (IntPtr) num1;
                continue;
              case 7:
                flag2 = false;
                num1 = (short) 15;
                num2 = (int) (IntPtr) num1;
                continue;
              case 8:
                if (global::c.c != null)
                {
                  num1 = (short) 2;
                  num2 = (int) (IntPtr) num1;
                  continue;
                }
                goto case 13;
              case 9:
                g.a("FTP Download Url :: " + global::c.d?.ToString());
                g.a("File Path :: " + global::c.b);
                ftpWebRequest = (FtpWebRequest) WebRequest.Create(global::c.d);
                num1 = (short) 11;
                num2 = (int) (IntPtr) num1;
                continue;
              case 10:
                num1 = (short) 16;
                num2 = (int) (IntPtr) num1;
                continue;
              case 11:
                if (global::c.c != null)
                {
                  num1 = (short) 12;
                  num2 = (int) (IntPtr) num1;
                  continue;
                }
                goto case 17;
              case 12:
                ftpWebRequest.Credentials = (ICredentials) global::c.c;
                num1 = (short) 17;
                num2 = (int) (IntPtr) num1;
                continue;
              case 13:
                ftpWebRequest.Method = "RETR";
                ftpWebRequest.Proxy = (IWebProxy) null;
                ftpWebRequest.UsePassive = true;
                ftpWebRequest.UseBinary = true;
                ftpWebRequest.KeepAlive = true;
                ftpWebRequest.Credentials = (ICredentials) global::c.c;
                responseStream = ftpWebRequest.GetResponse().GetResponseStream();
                num1 = (short) 5;
                num2 = (int) (IntPtr) num1;
                continue;
              case 14:
                switch (0)
                {
                  case 0:
                    goto label_7;
                  default:
                    continue;
                }
              case 15:
                goto label_62;
              case 16:
                goto label_3;
              case 17:
                ftpWebRequest.Method = "SIZE";
                ftpWebRequest.Proxy = (IWebProxy) null;
                ftpWebRequest.UsePassive = true;
                ftpWebRequest.UseBinary = true;
                ftpWebRequest.KeepAlive = true;
                ftpWebRequest.Credentials = (ICredentials) global::c.c;
                FtpWebResponse response = (FtpWebResponse) ftpWebRequest.GetResponse();
                buffer = new byte[8192];
                contentLength = response.ContentLength;
                num1 = (short) 6;
                num2 = (int) (IntPtr) num1;
                continue;
              default:
label_7:
                if (global::c.d != (Uri) null)
                {
                  num1 = (short) 4;
                  num2 = (int) (IntPtr) num1;
                  continue;
                }
                goto case 10;
            }
          }
        }
        catch (Exception ex)
        {
          g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
          throw;
        }
        finally
        {
          g.a("Completed");
        }
label_3:
        return flag1;
label_62:
        return flag2;
    }
  }

  public static a a<a>(Func<a> A_0, TimeSpan A_1, int A_2 = 3)
  {
    int A_1_1 = 10;
    int num1 = 0;
    switch (num1)
    {
      default:
        List<Exception> innerExceptions;
        int num2;
        short num3;
        switch (0)
        {
          case 0:
label_3:
            g.a("Started");
            innerExceptions = new List<Exception>();
            num2 = 1;
            num3 = (short) 3;
            num1 = (int) (IntPtr) num3;
            goto default;
          default:
            a a;
            while (true)
            {
              switch (num1)
              {
                case 0:
                  goto label_10;
                case 1:
                case 3:
label_4:
                  num3 = (short) 2;
                  num1 = (int) (IntPtr) num3;
                  continue;
                case 2:
                  if (num2 >= A_2)
                  {
                    num3 = (short) -27880;
                    int num4 = (int) num3;
                    num3 = (short) -27880;
                    int num5 = (int) num3;
                    switch (num4 == num5 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        goto label_4;
                      default:
                        num3 = (short) 0;
                        if (num3 == (short) 0)
                          ;
                        num3 = (short) 0;
                        num1 = (int) (IntPtr) num3;
                        continue;
                    }
                  }
                  else
                  {
                    g.a("Retry Attempt to downloading :: " + num2.ToString());
                    num3 = (short) 4;
                    num1 = (int) (IntPtr) num3;
                    continue;
                  }
                case 4:
                  try
                  {
                    num3 = (short) 2;
                    int num6 = (int) (IntPtr) num3;
                    while (true)
                    {
                      switch (num6)
                      {
                        case 0:
                          Thread.Sleep(A_1);
                          num3 = (short) 1;
                          num6 = (int) (IntPtr) num3;
                          continue;
                        case 1:
                          a = A_0();
                          num3 = (short) 3;
                          num6 = (int) (IntPtr) num3;
                          continue;
                        case 2:
                          switch (0)
                          {
                            case 0:
                              goto label_14;
                            default:
                              continue;
                          }
                        case 3:
                          goto label_21;
                        default:
label_14:
                          if (num2 > 1)
                          {
                            num3 = (short) 0;
                            num6 = (int) (IntPtr) num3;
                            continue;
                          }
                          goto case 1;
                      }
                    }
                  }
                  catch (Exception ex)
                  {
                    innerExceptions.Add(ex);
                  }
                  ++num2;
                  if (false)
                    ;
                  num1 = 1;
                  continue;
                default:
                  goto label_3;
              }
            }
label_10:
            throw new AggregateException((IEnumerable<Exception>) innerExceptions);
label_21:
            return a;
        }
    }
  }

  static c()
  {
    short num1 = -15690;
    int num2 = (int) num1;
    num1 = (short) -15690;
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
        global::c.b = string.Empty;
        break;
      default:
        goto case 1;
    }
  }

  public delegate void a(global::d A_0);
}

