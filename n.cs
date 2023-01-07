// Decompiled with JetBrains decompiler
// Type: n
// Assembly: eCWUrlLaunch, Version=4.0.1745.0, Culture=neutral, PublicKeyToken=null
// MVID: CB040BB1-DE0F-4FAE-AA16-19ACB0F0655F
// Assembly location: C:\ProgramData\eClinicalWorks\plugin\eCWUrlLaunch.exe

using eCWUrlLaunch.Properties;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.Deployment.Compression;
using Microsoft.Deployment.Compression.Cab;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

public class n
{
  private static string a;
  public static readonly string b;
  private static bool c;

  public static string ap()
  {
    int num1 = 0;
    switch (num1)
    {
      default:
        string str1 = "";
        string str2;
        try
        {
          NetworkInterface[] networkInterfaces;
          int index;
          short num2;
          switch (0)
          {
            case 0:
label_4:
              networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
              index = 0;
              num2 = (short) 1;
              num1 = (int) (IntPtr) num2;
              goto default;
            default:
              NetworkInterface networkInterface;
              while (true)
              {
                switch (num1)
                {
                  case 0:
                    str2 = str1;
                    num2 = (short) 3;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 1:
                  case 4:
                    num2 = (short) 5;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 2:
                    try
                    {
                      IPInterfaceProperties ipProperties;
                      switch (0)
                      {
                        case 0:
label_7:
                          ipProperties = networkInterface.GetIPProperties();
                          num2 = (short) 1;
                          num1 = (int) (IntPtr) num2;
                          goto default;
                        default:
                          while (true)
                          {
                            IEnumerator<UnicastIPAddressInformation> enumerator;
                            switch (num1)
                            {
                              case 0:
                                goto label_40;
                              case 1:
                                if (ipProperties.GatewayAddresses.Count > 0)
                                {
                                  num2 = (short) 3;
                                  num1 = (int) (IntPtr) num2;
                                  continue;
                                }
                                break;
                              case 2:
                                try
                                {
                                  num2 = (short) 2;
                                  int num3 = (int) (IntPtr) num2;
                                  while (true)
                                  {
                                    IPAddressInformation current;
                                    switch (num3)
                                    {
                                      case 0:
                                        if (current.Address.AddressFamily == AddressFamily.InterNetwork)
                                        {
                                          num2 = (short) 5;
                                          num3 = (int) (IntPtr) num2;
                                          continue;
                                        }
                                        goto default;
                                      case 1:
                                        str1 = current.Address.ToString();
                                        num2 = (short) 7;
                                        num3 = (int) (IntPtr) num2;
                                        continue;
                                      case 2:
                                        switch (0)
                                        {
                                          case 0:
                                            goto label_13;
                                          default:
                                            continue;
                                        }
                                      case 3:
                                        if (!IPAddress.IsLoopback(current.Address))
                                        {
                                          num2 = (short) 1;
                                          num3 = (int) (IntPtr) num2;
                                          continue;
                                        }
                                        goto default;
                                      case 4:
                                        if (!enumerator.MoveNext())
                                        {
                                          num2 = (short) 8;
                                          num3 = (int) (IntPtr) num2;
                                          continue;
                                        }
                                        break;
                                      case 5:
                                        num2 = (short) 19702;
                                        int num4 = (int) num2;
                                        num2 = (short) 19702;
                                        int num5 = (int) num2;
                                        switch (num4 == num5 ? 1 : 0)
                                        {
                                          case 0:
                                          case 2:
                                            break;
                                          default:
                                            num2 = (short) 0;
                                            if (num2 == (short) 0)
                                              ;
                                            num2 = (short) 3;
                                            num3 = (int) (IntPtr) num2;
                                            continue;
                                        }
                                        break;
                                      case 6:
                                        goto label_34;
                                      case 8:
                                        num2 = (short) 6;
                                        num3 = (int) (IntPtr) num2;
                                        continue;
                                      default:
label_13:
                                        num2 = (short) 4;
                                        num3 = (int) (IntPtr) num2;
                                        continue;
                                    }
                                    current = (IPAddressInformation) enumerator.Current;
                                    num2 = (short) 0;
                                    num3 = (int) (IntPtr) num2;
                                  }
                                }
                                finally
                                {
                                  int num6 = 2;
                                  while (true)
                                  {
                                    switch (num6)
                                    {
                                      case 0:
                                        goto label_32;
                                      case 1:
                                        enumerator.Dispose();
                                        num6 = 0;
                                        continue;
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
                                    if (enumerator != null)
                                      num6 = 1;
                                    else
                                      break;
                                  }
label_32:;
                                }
                              case 3:
                                enumerator = ipProperties.UnicastAddresses.GetEnumerator();
                                num2 = (short) 2;
                                num1 = (int) (IntPtr) num2;
                                continue;
                              default:
                                goto label_7;
                            }
label_34:
                            num2 = (short) 0;
                            num1 = (int) (IntPtr) num2;
                          }
                      }
                    }
                    catch (Exception ex)
                    {
                      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
                    }
label_40:
                    ++index;
                    num1 = 4;
                    continue;
                  case 3:
                    goto label_43;
                  case 5:
                    if (index >= networkInterfaces.Length)
                    {
                      num2 = (short) 0;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    networkInterface = networkInterfaces[index];
                    num2 = (short) 2;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  default:
                    goto label_4;
                }
              }
          }
        }
        catch (Exception ex)
        {
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
          str2 = (string) null;
        }
label_43:
        if (false)
          ;
        return str2;
    }
  }

  internal static void a(string A_0, bool A_1 = false, bool A_2 = false)
  {
    int A_1_1 = 3;
    try
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          string A_0_1;
          string str1;
          short num2;
          switch (0)
          {
            case 0:
label_4:
              global::g.c("Begin create desktop shortcut for non-admin user");
              A_0_1 = string.Empty;
              str1 = string.Empty;
              num2 = (short) 5;
              num1 = (int) (IntPtr) num2;
              goto default;
            default:
              while (true)
              {
                string A_2_1;
                string A_0_2;
                int port;
                Uri A_0_3;
                string str2;
                switch (num1)
                {
                  case 0:
                  case 9:
                    A_0_3 = new Uri(str1);
                    port = new Uri(str1).Port;
                    num2 = (short) 8;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 1:
                    if (!global::n.a(A_0_3, global::n.a.b))
                    {
                      num2 = (short) 12;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto case 11;
                  case 2:
                    num2 = (short) 3;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 3:
                    string str3 = "-";
                    port = new Uri(str1).Port;
                    string str4 = port.ToString();
                    str2 = str3 + str4;
                    goto label_22;
                  case 4:
                    global::g.c("Failed to create shortcut.");
                    num2 = (short) 11;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 5:
                    if (!A_1)
                    {
                      num2 = (short) 7;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    str1 = A_0;
                    num2 = (short) -4468;
                    int num3 = (int) num2;
                    num2 = (short) -4468;
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
                        num2 = (short) 9;
                        num1 = (int) (IntPtr) num2;
                        continue;
                    }
                    break;
                  case 6:
                    str2 = "";
                    goto label_22;
                  case 7:
                    A_0 = global::n.k(Path.GetFileNameWithoutExtension(A_0));
                    Uri uri = new Uri(A_0);
                    str1 = uri.Scheme + "://" + uri.Authority + "/mobiledoc/jsp/webemr/login/newLogin.jsp";
                    num2 = (short) 0;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 8:
                    if (!string.IsNullOrEmpty(port.ToString()))
                    {
                      num2 = (short) 2;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    num2 = (short) 6;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 10:
                    goto label_29;
                  case 11:
                    global::g.c("End create desktop shortcut");
                    num2 = (short) 10;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 12:
                    A_2_1 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\eClinicalWorks\SecureShell\";
                    global::g.c("Trying to create shortcut in users app data folder");
                    string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    A_0_1 = global::n.c(A_0_2, folderPath);
                    num2 = (short) 13;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 13:
                    if (global::n.b(A_0_1, str1, A_2_1))
                      goto case 11;
                    else
                      break;
                  default:
                    goto label_4;
                }
                num2 = (short) 4;
                num1 = (int) (IntPtr) num2;
                continue;
label_22:
                string str5 = str2;
                A_0_2 = new Uri(str1).Host + str5;
                num2 = (short) 1;
                num1 = (int) (IntPtr) num2;
              }
          }
      }
    }
    catch (Exception ex)
    {
      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
    }
label_29:
    if (false)
      ;
  }

  internal static string b(string A_0, out CookieContainer A_1)
  {
    // ISSUE: unable to decompile the method.
  }

  private static bool b(object A_0, X509Certificate A_1, X509Chain A_2, SslPolicyErrors A_3)
  {
    short num1 = 9159;
    int num2 = (int) num1;
    num1 = (short) 9159;
    int num3 = (int) num1;
    bool flag;
    switch (num2 == num3 ? 1 : 0)
    {
      case 0:
      case 2:
label_12:
        return flag;
      default:
        short num4 = 0;
        if (num4 == (short) 0)
          ;
        num4 = (short) 1;
        if (num4 == (short) 0)
          ;
        flag = false;
        try
        {
          num4 = (short) 1;
          int num5 = (int) (IntPtr) num4;
          while (true)
          {
            switch (num5)
            {
              case 0:
                goto label_12;
              case 1:
                switch (0)
                {
                  case 0:
                    goto label_7;
                  default:
                    continue;
                }
              case 2:
                flag = true;
                num4 = (short) 3;
                num5 = (int) (IntPtr) num4;
                continue;
              case 3:
                num4 = (short) 0;
                num5 = (int) (IntPtr) num4;
                continue;
              default:
label_7:
                if (A_3 == SslPolicyErrors.None)
                {
                  num4 = (short) 2;
                  num5 = (int) (IntPtr) num4;
                  continue;
                }
                goto case 3;
            }
          }
        }
        catch (Exception ex)
        {
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
          goto case 0;
        }
    }
  }

  internal static CookieContainer n(string A_0)
  {
    int num1 = 0;
    switch (num1)
    {
      default:
        short num2 = 1;
        if (num2 == (short) 0)
          ;
        CookieContainer cookieContainer = new CookieContainer();
        try
        {
          HttpWebRequest http;
          switch (0)
          {
            case 0:
label_5:
              ServicePointManager.SecurityProtocol = (SecurityProtocolType) 3072;
              http = WebRequest.CreateHttp(A_0);
              http.CookieContainer = cookieContainer;
              http.Timeout = 10000;
              num2 = (short) 3;
              num1 = (int) (IntPtr) num2;
              goto default;
            default:
              HttpWebResponse response;
              while (true)
              {
                switch (num1)
                {
                  case 0:
                    http.Proxy = GlobalProxySelection.GetEmptyWebProxy();
                    num2 = (short) 4;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 1:
                    try
                    {
                      num2 = (short) 4;
                      int num3 = (int) (IntPtr) num2;
                      while (true)
                      {
                        IEnumerator enumerator;
                        switch (num3)
                        {
                          case 0:
                            num2 = (short) 5;
                            num3 = (int) (IntPtr) num2;
                            continue;
                          case 1:
                            try
                            {
                              num2 = (short) 3;
                              num3 = (int) (IntPtr) num2;
                              while (true)
                              {
                                switch (num3)
                                {
                                  case 0:
                                    num2 = (short) -10018;
                                    int num4 = (int) num2;
                                    num2 = (short) -10018;
                                    int num5 = (int) num2;
                                    switch (num4 == num5 ? 1 : 0)
                                    {
                                      case 0:
                                      case 2:
                                        break;
                                      default:
                                        num2 = (short) 0;
                                        if (num2 == (short) 0)
                                          ;
                                        if (!enumerator.MoveNext())
                                        {
                                          num2 = (short) 4;
                                          num3 = (int) (IntPtr) num2;
                                          continue;
                                        }
                                        Cookie current = (Cookie) enumerator.Current;
                                        cookieContainer.Add(current);
                                        num2 = (short) 1;
                                        num3 = (int) (IntPtr) num2;
                                        continue;
                                    }
                                    break;
                                  case 2:
                                    goto label_36;
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
                                    num2 = (short) 2;
                                    num3 = (int) (IntPtr) num2;
                                    continue;
                                }
                                num2 = (short) 0;
                                num3 = (int) (IntPtr) num2;
                              }
                            }
                            finally
                            {
                              IDisposable disposable;
                              switch (0)
                              {
                                case 0:
label_31:
                                  disposable = enumerator as IDisposable;
                                  num3 = 1;
                                  goto default;
                                default:
                                  while (true)
                                  {
                                    switch (num3)
                                    {
                                      case 0:
                                        goto label_35;
                                      case 1:
                                        if (disposable != null)
                                        {
                                          num3 = 2;
                                          continue;
                                        }
                                        goto label_35;
                                      case 2:
                                        disposable.Dispose();
                                        num3 = 0;
                                        continue;
                                      default:
                                        goto label_31;
                                    }
                                  }
label_35:;
                              }
                            }
                          case 2:
                            enumerator = response.Cookies.GetEnumerator();
                            num2 = (short) 1;
                            num3 = (int) (IntPtr) num2;
                            continue;
                          case 3:
                            goto label_44;
                          case 4:
                            switch (0)
                            {
                              case 0:
                                goto label_13;
                              default:
                                continue;
                            }
                          case 5:
                            if (response.StatusCode == HttpStatusCode.OK)
                            {
                              num2 = (short) 2;
                              num3 = (int) (IntPtr) num2;
                              continue;
                            }
                            break;
                          default:
label_13:
                            if (response != null)
                            {
                              num2 = (short) 0;
                              num3 = (int) (IntPtr) num2;
                              continue;
                            }
                            break;
                        }
label_36:
                        num3 = 3;
                      }
                    }
                    finally
                    {
                      short num6 = 1;
                      int num7 = (int) (IntPtr) num6;
                      while (true)
                      {
                        switch (num7)
                        {
                          case 0:
                            goto label_43;
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
                            ((IDisposable) response).Dispose();
                            num6 = (short) 0;
                            num7 = (int) (IntPtr) num6;
                            continue;
                        }
                        if (response != null)
                        {
                          num6 = (short) 2;
                          num7 = (int) (IntPtr) num6;
                        }
                        else
                          break;
                      }
label_43:;
                    }
label_44:
                    num2 = (short) 2;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 2:
                    goto label_46;
                  case 3:
                    if (global::n.c)
                    {
                      num2 = (short) 0;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto case 4;
                  case 4:
                    response = (HttpWebResponse) http.GetResponse();
                    num2 = (short) 1;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  default:
                    goto label_5;
                }
              }
          }
        }
        catch (Exception ex)
        {
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
        }
label_46:
        return cookieContainer;
    }
  }

  internal static void ao()
  {
    int A_1 = 4;
    try
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          Process[] processesByName;
          short num2;
          switch (0)
          {
            case 0:
label_4:
              global::n.a(Process.GetProcessesByName("Charles"));
              global::n.a(Process.GetProcessesByName("BURP"));
              global::n.a(Process.GetProcessesByName("WireShark"));
              global::n.a(Process.GetProcessesByName("RawCap"));
              processesByName = Process.GetProcessesByName("javaw");
              num2 = (short) 6;
              num1 = (int) (IntPtr) num2;
              goto default;
            default:
              while (true)
              {
                int index;
                Process process;
                Process[] processArray;
                switch (num1)
                {
                  case 0:
                    processArray = processesByName;
                    index = 0;
                    num2 = (short) 2;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 1:
label_20:
                    num2 = (short) 7;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 2:
                    num2 = (short) -31313;
                    int num3 = (int) num2;
                    num2 = (short) -31313;
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
                        if (num2 == (short) 0)
                          goto label_20;
                        else
                          goto label_20;
                    }
                    break;
                  case 3:
                    goto label_24;
                  case 4:
                    try
                    {
                      num2 = (short) 2;
                      int num5 = (int) (IntPtr) num2;
                      while (true)
                      {
                        switch (num5)
                        {
                          case 0:
                            goto label_7;
                          case 1:
                            process.Kill();
                            num2 = (short) 3;
                            num5 = (int) (IntPtr) num2;
                            continue;
                          case 2:
                            switch (0)
                            {
                              case 0:
                                goto label_11;
                              default:
                                continue;
                            }
                          case 3:
                            num2 = (short) 0;
                            num5 = (int) (IntPtr) num2;
                            continue;
                          default:
label_11:
                            if (process.StartInfo.Arguments.ToLower().Contains("burp"))
                            {
                              num2 = (short) 1;
                              num5 = (int) (IntPtr) num2;
                              continue;
                            }
                            goto case 3;
                        }
                      }
                    }
                    catch (Exception ex)
                    {
                      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
                    }
label_7:
                    ++index;
                    num1 = 1;
                    continue;
                  case 5:
                    num2 = (short) 3;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 6:
                    if (processesByName.Length != 0)
                    {
                      num2 = (short) 0;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto case 5;
                  case 7:
                    if (index >= processArray.Length)
                    {
                      num2 = (short) 5;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    break;
                  default:
                    goto label_4;
                }
                process = processArray[index];
                num2 = (short) 4;
                num1 = (int) (IntPtr) num2;
              }
label_24:
              return;
          }
      }
    }
    catch (Exception ex)
    {
      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
    }
  }

  public static void a(Process[] A_0)
  {
    try
    {
      switch (0)
      {
        default:
          int num1 = 6;
          short num2;
          int index;
          Process process;
          Process[] processArray;
          while (true)
          {
            switch (num1)
            {
              case 0:
label_9:
                processArray = A_0;
                index = 0;
                num2 = (short) 2;
                num1 = (int) (IntPtr) num2;
                continue;
              case 1:
              case 2:
                num2 = (short) 7;
                num1 = (int) (IntPtr) num2;
                continue;
              case 3:
                goto label_20;
              case 4:
                try
                {
                  process.Kill();
                }
                catch (Exception ex)
                {
                  global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
                }
                ++index;
                num1 = 1;
                continue;
              case 5:
                num2 = (short) 3;
                num1 = (int) (IntPtr) num2;
                continue;
              case 6:
                switch (0)
                {
                  case 0:
                    goto label_4;
                  default:
                    continue;
                }
              case 7:
                num2 = (short) 1442;
                int num3 = (int) num2;
                num2 = (short) 1442;
                int num4 = (int) num2;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_9;
                  default:
                    num2 = (short) 0;
                    if (num2 == (short) 0)
                      ;
                    if (index >= processArray.Length)
                    {
                      num2 = (short) 5;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    process = processArray[index];
                    num2 = (short) 4;
                    num1 = (int) (IntPtr) num2;
                    continue;
                }
              default:
label_4:
                if (A_0.Length != 0)
                {
                  num2 = (short) 0;
                  num1 = (int) (IntPtr) num2;
                  continue;
                }
                goto case 5;
            }
          }
      }
    }
    catch (Exception ex)
    {
      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
    }
label_20:
    if (false)
      ;
  }

  public static string an()
  {
    int A_1 = 19;
    switch (0)
    {
      default:
        if (false)
          ;
        string empty1 = string.Empty;
        try
        {
          string empty2 = string.Empty;
          string empty3 = string.Empty;
          ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_OperatingSystem").Get().GetEnumerator();
          try
          {
            int num1 = 3;
            while (true)
            {
              ManagementObject current;
              short num2;
              switch (num1)
              {
                case 0:
                  try
                  {
                    empty2 = (string) current["Caption"];
                    empty3 = (string) current["Version"];
                    break;
                  }
                  catch (Exception ex)
                  {
                    global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
                    break;
                  }
                case 1:
                  num2 = (short) 2;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 2:
                  goto label_23;
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
                  if (enumerator.MoveNext())
                  {
                    current = (ManagementObject) enumerator.Current;
                    num2 = (short) -7043;
                    int num3 = (int) num2;
                    num2 = (short) -7043;
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
                        num2 = (short) 0;
                        num1 = (int) (IntPtr) num2;
                        continue;
                    }
                  }
                  else
                  {
                    num2 = (short) 1;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  break;
              }
              num2 = (short) 4;
              num1 = (int) (IntPtr) num2;
            }
          }
          finally
          {
            int num5 = 1;
            while (true)
            {
              short num6;
              switch (num5)
              {
                case 0:
                  goto label_22;
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
                  enumerator.Dispose();
                  num6 = (short) 0;
                  num5 = (int) (IntPtr) num6;
                  continue;
              }
              if (enumerator != null)
              {
                num6 = (short) 2;
                num5 = (int) (IntPtr) num6;
              }
              else
                break;
            }
label_22:;
          }
label_23:
          return empty1 + empty2 + " " + empty3;
        }
        catch (Exception ex)
        {
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
          return string.Empty;
        }
    }
  }

  internal static string a(string A_0, string A_1, out string A_2)
  {
    int A_1_1 = 9;
    int num1 = 0;
    switch (num1)
    {
      default:
        short num2 = 1;
        if (num2 == (short) 0)
          ;
        string str1 = string.Empty;
        A_2 = string.Empty;
        try
        {
          string str2;
          string str3;
          string str4;
          bool flag;
          switch (0)
          {
            case 0:
label_5:
              str2 = string.Empty;
              str3 = " --incognito";
              str4 = " --disable-renderer-accessibility";
              flag = false;
              num2 = (short) 3;
              num1 = (int) (IntPtr) num2;
              goto default;
            default:
              string str5;
              int result;
              string str6;
              while (true)
              {
                switch (num1)
                {
                  case 0:
                  case 1:
                    num2 = (short) 6;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 2:
                    if (!string.IsNullOrEmpty(str2))
                    {
                      num2 = (short) 7;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    str1 = "--app=" + A_0 + "  --start-maximized --no-experiments --test-type " + A_1 + " --no-first-run" + str3 + " --disable-popup-blocking --no-default-browser-check" + str6 + str4 + " --disable-dev-tools --use-fake-ui-for-media-stream";
                    num2 = (short) 0;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 3:
                    try
                    {
                      XmlDocument xmlDocument;
                      switch (0)
                      {
                        case 0:
label_37:
                          xmlDocument = new XmlDocument();
                          num2 = (short) 1;
                          num1 = (int) (IntPtr) num2;
                          goto default;
                        default:
                          while (true)
                          {
                            IEnumerator<XElement> enumerator;
                            switch (num1)
                            {
                              case 0:
                                xmlDocument.Load(global::n.a + "\PluginSettings.xml");
                                XDocument.Parse(xmlDocument.InnerXml);
                                enumerator = XDocument.Parse(xmlDocument.InnerXml).Descendants((XName) "DisplayName").GetEnumerator();
                                num2 = (short) 2;
                                num1 = (int) (IntPtr) num2;
                                continue;
                              case 1:
                                if (System.IO.File.Exists(global::n.a + "\PluginSettings.xml"))
                                {
                                  num2 = (short) 0;
                                  num1 = (int) (IntPtr) num2;
                                  continue;
                                }
                                break;
                              case 2:
                                try
                                {
                                  num2 = (short) 0;
                                  int num3 = (int) (IntPtr) num2;
                                  while (true)
                                  {
                                    XElement current;
                                    switch (num3)
                                    {
                                      case 0:
                                        switch (0)
                                        {
                                          case 0:
                                            break;
                                          default:
                                            continue;
                                        }
                                        break;
                                      case 1:
                                        num2 = (short) 10;
                                        num3 = (int) (IntPtr) num2;
                                        continue;
                                      case 2:
                                        str3 = "";
                                        num2 = (short) 5;
                                        num3 = (int) (IntPtr) num2;
                                        continue;
                                      case 3:
                                        num2 = (short) 4;
                                        num3 = (int) (IntPtr) num2;
                                        continue;
                                      case 4:
                                        goto label_67;
                                      case 5:
                                        num2 = (short) 8;
                                        num3 = (int) (IntPtr) num2;
                                        continue;
                                      case 6:
                                        str4 = "";
                                        num2 = (short) 12;
                                        num3 = (int) (IntPtr) num2;
                                        continue;
                                      case 7:
                                        if (current.Value == "DefaultBrowserSettings")
                                        {
                                          num2 = (short) 11;
                                          num3 = (int) (IntPtr) num2;
                                          continue;
                                        }
                                        goto case 1;
                                      case 8:
                                        if (current.Value == "EnableRendererAccessibility")
                                        {
                                          num2 = (short) 6;
                                          num3 = (int) (IntPtr) num2;
                                          continue;
                                        }
                                        break;
                                      case 9:
                                        if (!enumerator.MoveNext())
                                        {
                                          num2 = (short) 3;
                                          num3 = (int) (IntPtr) num2;
                                          continue;
                                        }
                                        current = enumerator.Current;
                                        num2 = (short) 7;
                                        num3 = (int) (IntPtr) num2;
                                        continue;
                                      case 10:
                                        if (current.Value == "IncognitoMode")
                                        {
                                          num2 = (short) 2;
                                          num3 = (int) (IntPtr) num2;
                                          continue;
                                        }
                                        goto case 5;
                                      case 11:
                                        flag = true;
                                        num2 = (short) 1;
                                        num3 = (int) (IntPtr) num2;
                                        continue;
                                    }
                                    num2 = (short) 9;
                                    num3 = (int) (IntPtr) num2;
                                  }
                                }
                                finally
                                {
                                  short num4 = 0;
                                  int num5 = (int) (IntPtr) num4;
                                  while (true)
                                  {
                                    switch (num5)
                                    {
                                      case 0:
                                        switch (0)
                                        {
                                          case 0:
                                            break;
                                          default:
                                            continue;
                                        }
                                        break;
                                      case 1:
                                        enumerator.Dispose();
                                        num4 = (short) 2;
                                        num5 = (int) (IntPtr) num4;
                                        continue;
                                      case 2:
                                        goto label_65;
                                    }
                                    if (enumerator != null)
                                    {
                                      num4 = (short) 1;
                                      num5 = (int) (IntPtr) num4;
                                    }
                                    else
                                      break;
                                  }
label_65:;
                                }
                              case 3:
                                goto label_6;
                              default:
                                goto label_37;
                            }
label_67:
                            num2 = (short) 3;
                            num1 = (int) (IntPtr) num2;
                          }
                      }
                    }
                    catch (Exception ex)
                    {
                      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
                    }
label_6:
                    str5 = string.Empty;
                    num1 = 8;
                    continue;
                  case 4:
                    global::n.a(A_2, A_0);
                    num2 = (short) 5;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 5:
                    result = -1;
                    str6 = string.Empty;
                    num2 = (short) 10;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 6:
                    goto label_75;
                  case 7:
                    str1 = "--app=" + A_0 + str5 + "  --start-maximized --no-experiments --test-type " + A_1 + " --no-first-run" + str3 + " --disable-popup-blocking --no-default-browser-check" + str6 + str4 + " --disable-dev-tools --use-fake-ui-for-media-stream";
                    num2 = (short) 1;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 8:
                    try
                    {
                      num2 = (short) 1;
                      int num6 = (int) (IntPtr) num2;
                      while (true)
                      {
                        switch (num6)
                        {
                          case 0:
                            str2 = "ecwchrome_" + Guid.NewGuid().ToString();
                            A_2 = Path.GetTempPath() + str2;
                            Directory.CreateDirectory(A_2);
                            str5 = "--user-data-dir="" + A_2 + """;
                            num2 = (short) 2;
                            num6 = (int) (IntPtr) num2;
                            continue;
                          case 1:
                            switch (0)
                            {
                              case 0:
                                goto label_29;
                              default:
                                continue;
                            }
                          case 2:
                            num2 = (short) 3;
                            num6 = (int) (IntPtr) num2;
                            continue;
                          case 3:
                            goto label_69;
                          default:
label_29:
                            if (!flag)
                            {
                              num2 = (short) 0;
                              num6 = (int) (IntPtr) num2;
                              continue;
                            }
                            goto case 2;
                        }
                      }
                    }
                    catch (Exception ex)
                    {
                      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
                    }
label_69:
                    num1 = 9;
                    continue;
                  case 9:
                    if (!flag)
                    {
                      num2 = (short) 4;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto case 5;
                  case 10:
                    try
                    {
                      num2 = (short) 4;
                      int num7 = (int) (IntPtr) num2;
                      while (true)
                      {
                        switch (num7)
                        {
                          case 0:
                            str6 = " --enable-logging --v=" + result.ToString() + " ";
                            global::n.ab();
                            num2 = (short) 2;
                            num7 = (int) (IntPtr) num2;
                            continue;
                          case 1:
                            num2 = (short) 5;
                            num7 = (int) (IntPtr) num2;
                            continue;
                          case 2:
                            num2 = (short) 6642;
                            int num8 = (int) num2;
                            num2 = (short) 6642;
                            int num9 = (int) num2;
                            switch (num8 == num9 ? 1 : 0)
                            {
                              case 0:
                              case 2:
                                goto label_15;
                              default:
                                num2 = (short) 0;
                                if (num2 == (short) 0)
                                  break;
                                break;
                            }
                            break;
                          case 3:
label_15:
                            int.TryParse(ConfigurationManager.AppSettings["EnableConsoleLogging"], out result);
                            num2 = (short) 1;
                            num7 = (int) (IntPtr) num2;
                            continue;
                          case 4:
                            switch (0)
                            {
                              case 0:
                                goto label_13;
                              default:
                                continue;
                            }
                          case 5:
                            if (result > -1)
                            {
                              num2 = (short) 0;
                              num7 = (int) (IntPtr) num2;
                              continue;
                            }
                            break;
                          case 6:
                            goto label_7;
                          default:
label_13:
                            if (ConfigurationManager.AppSettings["EnableConsoleLogging"] != null)
                            {
                              num2 = (short) 3;
                              num7 = (int) (IntPtr) num2;
                              continue;
                            }
                            goto case 1;
                        }
                        num2 = (short) 6;
                        num7 = (int) (IntPtr) num2;
                      }
                    }
                    catch (Exception ex)
                    {
                      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
                    }
label_7:
                    A_0 = global::n.m(A_0);
                    num1 = 2;
                    continue;
                  default:
                    goto label_5;
                }
              }
          }
        }
        catch (Exception ex)
        {
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
        }
label_75:
        global::g.b("GC parameters: " + str1);
        return str1;
    }
  }

  internal static string m(string A_0)
  {
    int A_1 = 13;
    short num1 = 19017;
    int num2 = (int) num1;
    num1 = (short) 19017;
    int num3 = (int) num1;
    short num4;
    int num5;
    switch (num2 == num3 ? 1 : 0)
    {
      case 0:
      case 2:
label_5:
        if (A_0.Contains("?"))
        {
          num4 = (short) 0;
          num5 = (int) (IntPtr) num4;
          break;
        }
        A_0 = """ + A_0 + "?" + global::n.b(global::n.g(A_0), A_0) + "" ";
        num4 = (short) 2;
        num5 = (int) (IntPtr) num4;
        break;
      default:
        if (true)
          ;
        num4 = (short) 1;
        num5 = (int) (IntPtr) num4;
        break;
    }
label_4:
    while (true)
    {
      switch (num5)
      {
        case 0:
          A_0 = """ + A_0 + "&" + global::n.b(global::n.g(A_0), A_0) + "" ";
          num4 = (short) 3;
          num5 = (int) (IntPtr) num4;
          continue;
        case 1:
          goto label_3;
        case 2:
          goto label_8;
        case 3:
          goto label_10;
        default:
          goto label_5;
      }
    }
label_3:
    switch (0)
    {
      case 0:
        goto label_5;
      default:
        goto label_4;
    }
label_8:
    num4 = (short) 1;
    if (num4 == (short) 0)
      ;
label_10:
    return A_0;
  }

  public static bool a(string A_0, out string A_1)
  {
    int A_1_1 = 6;
    int num1 = 0;
    switch (num1)
    {
      default:
label_1:
        bool flag1 = false;
        A_1 = "--no-proxy-server";
        bool A_0_1 = false;
        Dictionary<string, string> dictionary = (Dictionary<string, string>) null;
        short num2;
        bool flag2;
        try
        {
          string str1;
          switch (0)
          {
            case 0:
label_5:
              str1 = global::n.d("eCWSettings");
              num2 = (short) 4;
              num1 = (int) (IntPtr) num2;
              goto default;
            default:
              while (true)
              {
                int index;
                string[] strArray;
                string str2;
                string str3;
                string str4;
                int port;
                string str5;
                long ticks;
                string str6;
                string str7;
                string str8;
                int num3;
                switch (num1)
                {
                  case 0:
                    global::g.a("Proxy Mode = 2");
                    num2 = (short) 11;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 1:
                    num2 = (short) 28;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 2:
                    num2 = (short) 19;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 3:
                    DateTime utcNow = DateTime.UtcNow;
                    str5 = utcNow.Ticks.ToString();
                    dictionary.TryGetValue("Expiry", out str5);
                    utcNow = DateTime.UtcNow;
                    ticks = utcNow.Ticks;
                    num2 = (short) 20;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 4:
                    if (!string.IsNullOrEmpty(str1))
                    {
                      num2 = (short) 7;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto case 8;
                  case 5:
                    string str9 = "-";
                    port = new Uri(A_0).Port;
                    string str10 = port.ToString();
                    str8 = str9 + str10;
                    goto label_44;
                  case 6:
                    if (!A_1.Contains("--proxy-server"))
                    {
                      global::g.b("Proxy Mode = Not supported. URL: " + A_0 + "Enc Value: " + str1);
                      global::g.a("Resetting proxy flag.");
                      A_1 = "--no-proxy-server";
                      num2 = (short) 8;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    num2 = (short) 29;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 7:
                    string empty = string.Empty;
                    strArray = str1.Split(';');
                    index = 0;
                    num2 = (short) 12;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 8:
                  case 11:
                  case 14:
                  case 17:
                  case 23:
                  case 27:
                    flag1 = true;
                    num2 = (short) 10;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 9:
                    num3 = 1;
                    break;
                  case 10:
                    goto label_2;
                  case 12:
                  case 18:
                    num2 = (short) 38;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 13:
                    num3 = 0;
                    break;
                  case 15:
                    if (!(str7 != str3))
                    {
                      num2 = (short) 32;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    num2 = (short) 33;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 16:
                    if (!string.IsNullOrEmpty(port.ToString()))
                    {
                      num2 = (short) 39;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    num2 = (short) 21;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 19:
                    if (dictionary == null)
                    {
                      global::g.a("ProxySetting value in config is wrong, Error: empty dictionary");
                      num2 = (short) 17;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    num2 = (short) 3;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 20:
                    if (ticks < Convert.ToInt64(str5))
                    {
                      num2 = (short) 26;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    global::g.a("eCWSettings are expired.");
                    num2 = (short) 27;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 21:
                    str8 = "";
                    goto label_44;
                  case 22:
                    if (!(str4.ToLower() == "true"))
                    {
                      num2 = (short) 25;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    num2 = (short) 9;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 24:
                  case 34:
                    goto label_68;
                  case 25:
                    num2 = (short) 13;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 26:
                    str2 = "";
                    str3 = "";
                    str4 = "false";
                    dictionary.TryGetValue("MUUID", out str2);
                    dictionary.TryGetValue("SURL", out str3);
                    port = new Uri(A_0).Port;
                    num2 = (short) 16;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 28:
                    if (str6 != str2)
                    {
                      num2 = (short) 35;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto label_54;
                  case 29:
                    global::g.a("Proxy Mode = 3");
                    num2 = (short) 14;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 30:
                    if (dictionary == null)
                    {
                      num2 = (short) 36;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto case 2;
                  case 31:
                    A_1 = "";
                    global::n.c = false;
                    global::g.a("Proxy Mode = 1");
                    num2 = (short) 23;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 32:
                    if (!string.IsNullOrEmpty(str2))
                    {
                      num2 = (short) 1;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto label_54;
                  case 33:
                    global::g.a("Hostname didn't match in eCWSettings");
                    flag2 = false;
                    num2 = (short) 24;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 35:
                    global::g.a("Machine ID didn't match in eCWSettings");
                    flag2 = false;
                    num2 = (short) 34;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 36:
                    ++index;
                    num2 = (short) 18;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 37:
                    if (!(A_1 == "--allow-proxy"))
                    {
                      num2 = (short) 43;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    num2 = (short) 31;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 38:
                    if (index >= strArray.Length)
                    {
                      num2 = (short) 2;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    dictionary = global::n.d(strArray[index], A_0);
                    num2 = (short) 30;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 39:
                    num2 = (short) 5;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 40:
                    global::g.b(A_0_1);
                    num2 = (short) 42;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 41:
                    if (A_0_1)
                    {
                      num2 = (short) 40;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto case 42;
                  case 42:
                    global::g.a("Secure logging: " + A_0_1.ToString() + " URL :" + A_0);
                    num2 = (short) 37;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 43:
                    if (!(A_1 == "--proxy-auto-detect"))
                    {
                      num2 = (short) 6;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    num2 = (short) 0;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  default:
                    goto label_5;
                }
                A_0_1 = num3 != 0;
                num2 = (short) 41;
                num1 = (int) (IntPtr) num2;
                continue;
label_44:
                string str11 = str8;
                str7 = new Uri(A_0).Host + str11;
                str6 = global::n.am();
                num2 = (short) 15;
                num1 = (int) (IntPtr) num2;
                continue;
label_54:
                dictionary.TryGetValue("ProxySetting", out A_1);
                dictionary.TryGetValue("SecureLogging", out str4);
                num2 = (short) 22;
                num1 = (int) (IntPtr) num2;
              }
          }
        }
        catch (Exception ex)
        {
          flag1 = false;
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
        }
label_2:
        return flag1;
label_68:
        num2 = (short) -25126;
        int num4 = (int) num2;
        num2 = (short) -25126;
        int num5 = (int) num2;
        switch (num4 == num5 ? 1 : 0)
        {
          case 0:
          case 2:
            goto label_1;
          default:
            num2 = (short) 1;
            if (num2 == (short) 0)
              ;
            num2 = (short) 0;
            if (num2 == (short) 0)
              ;
            return flag2;
        }
    }
  }

  private static string e(string A_0, string A_1)
  {
    int A_1_1 = 10;
    int num1 = 0;
    switch (num1)
    {
      default:
        if (false)
          ;
        string empty = string.Empty;
        try
        {
          int port;
          short num2;
          switch (0)
          {
            case 0:
label_5:
              port = new Uri(A_1).Port;
              num2 = (short) 6;
              num1 = (int) (IntPtr) num2;
              goto default;
            default:
              while (true)
              {
                string str1;
                string str2;
                int num3;
                switch (num1)
                {
                  case 0:
                    global::g.a("Proxy Mode = 2");
                    num2 = (short) 7;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 1:
                    if (empty.Contains("--proxy-server"))
                    {
                      num2 = (short) -23341;
                      int num4 = (int) num2;
                      num2 = (short) -23341;
                      int num5 = (int) num2;
                      switch (num4 == num5 ? 1 : 0)
                      {
                        case 0:
                        case 2:
                          goto label_24;
                        default:
                          num2 = (short) 0;
                          if (num2 == (short) 0)
                            ;
                          num2 = (short) 2;
                          num1 = (int) (IntPtr) num2;
                          continue;
                      }
                    }
                    else
                    {
                      empty = string.Empty;
                      global::g.a("Proxy Mode = Not supported. URL: " + A_1 + "Enc Value: " + A_0);
                      num2 = (short) 8;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                  case 2:
                    global::g.a("Proxy Mode = 3");
                    num2 = (short) 3;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 3:
                  case 7:
                  case 8:
                  case 15:
                    num2 = (short) 5;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 4:
                    string str3 = "-";
                    port = new Uri(A_1).Port;
                    string str4 = port.ToString();
                    str2 = str3 + str4;
                    goto label_26;
                  case 5:
                    goto label_36;
                  case 6:
                    if (!string.IsNullOrEmpty(port.ToString()))
                    {
                      num2 = (short) 13;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    num2 = (short) 17;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 9:
                    num3 = 1;
                    break;
                  case 10:
                    if (empty == "--allow-proxy")
                    {
                      num2 = (short) 11;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    num2 = (short) 16;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 11:
                    global::g.a("Proxy Mode = 1");
                    num2 = (short) 15;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 12:
                    if (str1.Split('|')[1].ToLower() == "true")
                    {
                      num2 = (short) 9;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    num2 = (short) 18;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 13:
                    num2 = (short) 4;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 14:
                    num3 = 0;
                    break;
                  case 16:
label_24:
                    if (!(empty == "--proxy-auto-detect"))
                    {
                      num2 = (short) 1;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    num2 = (short) 0;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 17:
                    str2 = "";
                    goto label_26;
                  case 18:
                    num2 = (short) 14;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  default:
                    goto label_5;
                }
                bool flag = num3 != 0;
                num2 = (short) 10;
                num1 = (int) (IntPtr) num2;
                continue;
label_26:
                string str5 = str2;
                string str6 = new Uri(A_1).Host + str5;
                string str7 = global::n.am();
                str1 = new global::b().b("aInMmm", A_0, str6 + str7).Trim();
                empty = str1.Split('|')[0];
                num2 = (short) 12;
                num1 = (int) (IntPtr) num2;
              }
          }
        }
        catch (Exception ex)
        {
          empty = string.Empty;
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
        }
label_36:
        return empty;
    }
  }

  private static Dictionary<string, string> d(string A_0, string A_1)
  {
    int A_1_1 = 18;
    int num1 = 0;
    switch (num1)
    {
      default:
        if (false)
          ;
        string empty = string.Empty;
        Dictionary<string, string> dictionary1 = (Dictionary<string, string>) null;
        Dictionary<string, string> dictionary2;
        try
        {
          int port;
          short num2;
          switch (0)
          {
            case 0:
label_6:
              port = new Uri(A_1).Port;
              num2 = (short) 7;
              num1 = (int) (IntPtr) num2;
              goto default;
            default:
              while (true)
              {
                string str1;
                string str2;
                string str3;
                switch (num1)
                {
                  case 0:
                    string str4 = "-";
                    port = new Uri(A_1).Port;
                    string str5 = port.ToString();
                    str3 = str4 + str5;
                    break;
                  case 1:
                    goto label_21;
                  case 2:
                    str3 = "";
                    break;
                  case 3:
                    num2 = (short) 0;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 4:
                    goto label_3;
                  case 5:
label_15:
                    if (str1 != str2)
                    {
                      num2 = (short) 6;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    num2 = (short) 4;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 6:
                    global::g.a("Hostname didn't match in eCWSettings, trying next one.");
                    dictionary2 = (Dictionary<string, string>) null;
                    num2 = (short) 7226;
                    int num3 = (int) num2;
                    num2 = (short) 7226;
                    int num4 = (int) num2;
                    switch (num3 == num4 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        goto label_15;
                      default:
                        num2 = (short) 0;
                        if (num2 == (short) 0)
                          ;
                        num2 = (short) 1;
                        num1 = (int) (IntPtr) num2;
                        continue;
                    }
                  case 7:
                    if (!string.IsNullOrEmpty(port.ToString()))
                    {
                      num2 = (short) 3;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    num2 = (short) 2;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  default:
                    goto label_6;
                }
                string str6 = str3;
                str1 = new Uri(A_1).Host + str6;
                global::n.am();
                dictionary1 = JsonConvert.DeserializeObject<Dictionary<string, string>>(global::n.h(A_0));
                str2 = "";
                dictionary1.TryGetValue("SURL", out str2);
                num2 = (short) 5;
                num1 = (int) (IntPtr) num2;
              }
          }
        }
        catch (Exception ex)
        {
          empty = string.Empty;
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
        }
label_3:
        return dictionary1;
label_21:
        return dictionary2;
    }
  }

  private static string am()
  {
    int A_1 = 13;
    switch (0)
    {
      default:
        string str1 = "";
        try
        {
          string str2 = "localhost";
          ManagementScope scope = new ManagementScope(string.Format("\\{0}\root\CIMV2", (object) str2), (ConnectionOptions) null);
          scope.Connect();
          ObjectQuery query = new ObjectQuery("SELECT UUID FROM Win32_ComputerSystemProduct");
          ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher(scope, query).Get().GetEnumerator();
          try
          {
            int num1 = 5;
            while (true)
            {
              short num2 = 15699;
              int num3 = (int) num2;
              num2 = (short) 15699;
              int num4 = (int) num2;
              switch (num3 == num4 ? 1 : 0)
              {
                case 0:
                case 2:
label_11:
                  num2 = (short) 3;
                  num1 = (int) (IntPtr) num2;
                  continue;
                default:
                  num2 = (short) 0;
                  if (num2 == (short) 0)
                    ;
                  switch (num1)
                  {
                    case 0:
                      if (string.IsNullOrEmpty(str1))
                      {
                        num2 = (short) 1;
                        num1 = (int) (IntPtr) num2;
                        continue;
                      }
                      goto case 4;
                    case 2:
                      goto label_23;
                    case 3:
                      if (enumerator.MoveNext())
                      {
                        str1 = enumerator.Current["UUID"].ToString();
                        num2 = (short) 0;
                        num1 = (int) (IntPtr) num2;
                        continue;
                      }
                      num2 = (short) 4;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    case 4:
                      num2 = (short) 2;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    case 5:
                      switch (0)
                      {
                        case 0:
                          goto label_11;
                        default:
                          continue;
                      }
                    default:
                      goto label_11;
                  }
              }
            }
          }
          finally
          {
            int num5 = 2;
            while (true)
            {
              short num6;
              switch (num5)
              {
                case 0:
                  goto label_21;
                case 1:
                  enumerator.Dispose();
                  num6 = (short) 0;
                  num5 = (int) (IntPtr) num6;
                  continue;
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
              if (enumerator != null)
              {
                num6 = (short) 1;
                num5 = (int) (IntPtr) num6;
              }
              else
                break;
            }
label_21:;
          }
        }
        catch (Exception ex)
        {
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
        }
label_23:
        if (false)
          ;
        return str1;
    }
  }

  public static string al()
  {
    int A_1_1 = 4;
    int num1 = 0;
    switch (num1)
    {
      default:
        string str;
        NetworkInterface[] networkInterfaces;
        int index;
        short num2;
        switch (0)
        {
          case 0:
label_3:
            str = string.Empty;
            networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            index = 0;
            num2 = (short) 4;
            num1 = (int) (IntPtr) num2;
            goto default;
          default:
            NetworkInterface networkInterface;
            while (true)
            {
              switch (num1)
              {
                case 0:
                case 4:
                  num2 = (short) 3;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 1:
                  goto label_15;
                case 2:
                  try
                  {
                    str = string.Join("-", ((IEnumerable<byte>) networkInterface.GetPhysicalAddress().GetAddressBytes()).Select<byte, string>((Func<byte, string>) (A_0 =>
                    {
                      int A_1_2 = 12;
                      short num3 = 23944;
                      int num4 = (int) num3;
                      num3 = (short) 23944;
                      int num5 = (int) num3;
                      switch (num4 == num5)
                      {
                        case true:
                          if (true)
                            ;
                          if (false)
                            ;
                          return A_0.ToString("X2");
                        default:
                          goto case 1;
                      }
                    })).ToArray<string>());
                    goto label_15;
                  }
                  catch (Exception ex)
                  {
                    global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
                  }
                  ++index;
                  num1 = 0;
                  continue;
                case 3:
                  if (index < networkInterfaces.Length)
                    networkInterface = networkInterfaces[index];
                  else
                    goto label_9;
label_6:
                  num2 = (short) 2;
                  num1 = (int) (IntPtr) num2;
                  continue;
label_9:
                  num2 = (short) -22967;
                  int num6 = (int) num2;
                  num2 = (short) -22967;
                  int num7 = (int) num2;
                  switch (num6 == num7 ? 1 : 0)
                  {
                    case 0:
                    case 2:
                      goto label_6;
                    default:
                      num2 = (short) 1;
                      if (num2 == (short) 0)
                        ;
                      num2 = (short) 0;
                      if (num2 == (short) 0)
                        ;
                      num2 = (short) 1;
                      num1 = (int) (IntPtr) num2;
                      continue;
                  }
                default:
                  goto label_3;
              }
            }
label_15:
            return str;
        }
    }
  }

  public static string ak()
  {
    int A_1 = 19;
    short num1 = 19183;
    int num2 = (int) num1;
    num1 = (short) 19183;
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
        return Environment.UserDomainName + "\\" + Environment.UserName;
      default:
        goto case 1;
    }
  }

  public static string aj()
  {
    int A_1 = 13;
    string str1 = string.Empty;
    try
    {
      int num1 = 7;
      while (true)
      {
        short num2;
        string str2;
        switch (num1)
        {
          case 0:
            num2 = (short) -7272;
            int num3 = (int) num2;
            num2 = (short) -7272;
            int num4 = (int) num2;
            switch (num3 == num4 ? 1 : 0)
            {
              case 0:
              case 2:
                goto label_8;
              default:
                num2 = (short) 0;
                if (num2 == (short) 0)
                  goto label_16;
                else
                  goto label_16;
            }
          case 1:
            str2 = Environment.UserDomainName;
            break;
          case 2:
label_8:
            str1 = Environment.UserDomainName;
            num2 = (short) 0;
            num1 = (int) (IntPtr) num2;
            continue;
          case 3:
            num2 = (short) 1;
            num1 = (int) (IntPtr) num2;
            continue;
          case 4:
            goto label_18;
          case 5:
            str2 = IPGlobalProperties.GetIPGlobalProperties().DomainName;
            break;
          case 6:
            if (string.IsNullOrEmpty(str1))
            {
              num2 = (short) 2;
              num1 = (int) (IntPtr) num2;
              continue;
            }
            goto label_16;
          case 7:
            switch (0)
            {
              case 0:
                goto label_4;
              default:
                continue;
            }
          default:
label_4:
            if (IPGlobalProperties.GetIPGlobalProperties().DomainName.Length <= 0)
            {
              num2 = (short) 3;
              num1 = (int) (IntPtr) num2;
              continue;
            }
            num2 = (short) 5;
            num1 = (int) (IntPtr) num2;
            continue;
        }
        str1 = str2;
        num2 = (short) 6;
        num1 = (int) (IntPtr) num2;
        continue;
label_16:
        num2 = (short) 4;
        num1 = (int) (IntPtr) num2;
      }
    }
    catch (Exception ex)
    {
      str1 = Environment.UserDomainName;
    }
label_18:
    if (false)
      ;
    global::g.a("HostOSDomain : " + str1);
    return str1;
  }

  public static string ai()
  {
    int A_1 = 2;
    int num1 = 0;
    switch (num1)
    {
      default:
        if (false)
          ;
        string str = string.Empty;
        try
        {
          string fileName;
          short num2;
          switch (0)
          {
            case 0:
label_5:
              global::g.c("Checking version");
              fileName = string.Empty;
              num2 = (short) 4;
              num1 = (int) (IntPtr) num2;
              goto default;
            default:
              while (true)
              {
                switch (num1)
                {
                  case 0:
                    num2 = (short) 29268;
                    int num3 = (int) num2;
                    num2 = (short) 29268;
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
                        fileName = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + "\eClinicalWorks\plugin\WinProjectE.exe";
                        num2 = (short) 2;
                        num1 = (int) (IntPtr) num2;
                        continue;
                    }
                  case 1:
                    goto label_14;
                  case 2:
                  case 3:
                    global::g.c("filePath to check version: " + fileName);
                    str = FileVersionInfo.GetVersionInfo(fileName).FileVersion;
                    global::g.c("Version: " + str);
                    num2 = (short) 1;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 4:
                    if (global::n.af())
                    {
                      num2 = (short) 0;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    fileName = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles) + "\eClinicalWorks\plugin\WinProjectE.exe";
                    num2 = (short) 3;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  default:
                    goto label_5;
                }
              }
          }
        }
        catch (Exception ex)
        {
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
          str = "";
        }
label_14:
        return str;
    }
  }

  private static string ah()
  {
    int A_1 = 1;
    short num1 = 1;
    if (num1 == (short) 0)
      ;
    num1 = (short) 0;
    int num2 = (int) num1;
    switch (num2)
    {
      default:
        string str1 = string.Empty;
        try
        {
          RegistryKey registryKey;
          switch (0)
          {
            case 0:
label_5:
              registryKey = Registry.ClassesRoot.OpenSubKey("Ecw");
              num1 = (short) 4;
              num2 = (int) (IntPtr) num1;
              goto default;
            default:
              while (true)
              {
                string str2;
                switch (num2)
                {
                  case 0:
                    str2 = registryKey.GetValue("Version") as string;
                    num1 = (short) 6;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 1:
                  case 2:
                    num1 = (short) 15008;
                    int num3 = (int) num1;
                    num1 = (short) 15008;
                    int num4 = (int) num1;
                    switch (num3 == num4 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        break;
                      default:
                        num1 = (short) 0;
                        if (num1 == (short) 0)
                          ;
                        num1 = (short) 3;
                        num2 = (int) (IntPtr) num1;
                        continue;
                    }
                    break;
                  case 3:
                    goto label_17;
                  case 4:
                    if (registryKey == null)
                      goto case 1;
                    else
                      break;
                  case 5:
                    str1 = "";
                    num1 = (short) 2;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 6:
                    if (string.IsNullOrEmpty(str2))
                    {
                      num1 = (short) 5;
                      num2 = (int) (IntPtr) num1;
                      continue;
                    }
                    str1 = str2;
                    num1 = (short) 1;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  default:
                    goto label_5;
                }
                num1 = (short) 0;
                num2 = (int) (IntPtr) num1;
              }
          }
        }
        catch (Exception ex)
        {
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
        }
label_17:
        return str1;
    }
  }

  private static bool ag()
  {
    int num1 = 0;
    switch (num1)
    {
      default:
        short num2 = 1;
        if (num2 == (short) 0)
          ;
        bool flag = false;
        try
        {
          SecurityIdentifier sid;
          WindowsPrincipal currentPrincipal;
          switch (0)
          {
            case 0:
label_5:
              sid = new SecurityIdentifier(WellKnownSidType.BuiltinAdministratorsSid, (SecurityIdentifier) null);
              Thread.GetDomain().SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
              currentPrincipal = (WindowsPrincipal) Thread.CurrentPrincipal;
              num2 = (short) 2;
              num1 = (int) (IntPtr) num2;
              goto default;
            default:
              while (true)
              {
                switch (num1)
                {
                  case 0:
                  case 4:
                    num2 = (short) 3;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 1:
                    flag = true;
                    break;
                  case 2:
                    if (currentPrincipal.IsInRole(sid))
                    {
                      num2 = (short) 17242;
                      int num3 = (int) num2;
                      num2 = (short) 17242;
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
                    }
                    else
                    {
                      flag = false;
                      num2 = (short) 0;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    break;
                  case 3:
                    goto label_15;
                  default:
                    goto label_5;
                }
                num2 = (short) 4;
                num1 = (int) (IntPtr) num2;
              }
          }
        }
        catch (Exception ex)
        {
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
        }
label_15:
        return flag;
    }
  }

  private static bool af()
  {
    int A_1 = 0;
    int num1 = 1;
    while (true)
    {
      short num2;
      switch (num1)
      {
        case 0:
          if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432")))
          {
            num2 = (short) 2;
            num1 = (int) (IntPtr) num2;
            continue;
          }
          goto label_12;
        case 1:
          num2 = (short) 20157;
          int num3 = (int) num2;
          num2 = (short) 20157;
          int num4 = (int) num2;
          switch (num3 == num4 ? 1 : 0)
          {
            case 0:
            case 2:
              goto label_8;
            default:
              num2 = (short) 1;
              if (num2 == (short) 0)
                ;
              num2 = (short) 0;
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
        case 2:
          goto label_8;
        case 3:
          num2 = (short) 0;
          num1 = (int) (IntPtr) num2;
          continue;
      }
      if (8 != IntPtr.Size)
      {
        num2 = (short) 3;
        num1 = (int) (IntPtr) num2;
      }
      else
        break;
    }
label_8:
    return true;
label_12:
    return false;
  }

  public static string ae()
  {
    int A_1 = 15;
    int num1 = 0;
    switch (num1)
    {
      default:
        string str1;
        string str2;
        short num2;
        switch (0)
        {
          case 0:
label_3:
            str1 = string.Empty;
            str2 = string.Empty;
            num2 = (short) 24;
            num1 = (int) (IntPtr) num2;
            goto default;
          default:
            RegistryKey registryKey;
            string name;
            int index;
            bool flag;
            string[] subKeyNames;
            object obj;
            while (true)
            {
              switch (num1)
              {
                case 0:
                case 3:
                  num2 = (short) 8;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 1:
                  num2 = (short) -206;
                  int num3 = (int) num2;
                  num2 = (short) -206;
                  int num4 = (int) num2;
                  switch (num3 == num4 ? 1 : 0)
                  {
                    case 0:
                    case 2:
                      goto label_20;
                    default:
                      num2 = (short) 0;
                      if (num2 == (short) 0)
                        ;
                      str1 = "Chrome-" + registryKey.OpenSubKey(name).GetValue("pv")?.ToString();
                      num2 = (short) 7;
                      num1 = (int) (IntPtr) num2;
                      continue;
                  }
                case 2:
                  num2 = (short) 15;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 4:
                  num2 = (short) 1;
                  if (num2 == (short) 0)
                    ;
                  registryKey = Registry.CurrentUser.OpenSubKey("Software\Google\Update\Clients");
                  num2 = (short) 22;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 5:
                  num2 = (short) 1;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 6:
                case 11:
                  goto label_41;
                case 7:
                  ++index;
                  num2 = (short) 3;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 8:
                  if (index < subKeyNames.Length)
                  {
                    name = subKeyNames[index];
                    obj = registryKey.OpenSubKey(name).GetValue("name");
                    flag = false;
                    num2 = (short) 10;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  num2 = (short) 13;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 9:
                  registryKey = Registry.LocalMachine.OpenSubKey("Software\" + str2 + "Google\Update\Clients");
                  num2 = (short) 25;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 10:
                  if (obj != null)
                  {
                    num2 = (short) 12;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto case 18;
                case 12:
                  flag = obj.ToString().Equals("Google Chrome", StringComparison.InvariantCultureIgnoreCase);
                  num2 = (short) 18;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 13:
                  num2 = (short) 11;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 14:
                  if (registryKey == null)
                  {
                    num2 = (short) 19;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto case 2;
                case 15:
                  if (registryKey == null)
                  {
                    num2 = (short) 4;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto case 22;
                case 16:
                  num2 = (short) 14;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 17:
                  registryKey = Registry.CurrentUser.OpenSubKey("Software\" + str2 + "Google\Update\Clients");
                  num2 = (short) 16;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 18:
                  num2 = (short) 20;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 19:
                  registryKey = Registry.LocalMachine.OpenSubKey("Software\Google\Update\Clients");
                  num2 = (short) 2;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 20:
                  if (flag)
                  {
                    num2 = (short) 5;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto case 7;
                case 21:
                  str2 = "Wow6432Node\";
                  num2 = (short) 9;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 22:
                  num2 = (short) 26;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 23:
label_20:
                  subKeyNames = registryKey.GetSubKeyNames();
                  index = 0;
                  num2 = (short) 0;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 24:
                  if (Environment.Is64BitOperatingSystem)
                  {
                    num2 = (short) 21;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto case 9;
                case 25:
                  if (registryKey == null)
                  {
                    num2 = (short) 17;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto case 16;
                case 26:
                  if (registryKey != null)
                  {
                    num2 = (short) 23;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  str1 = "Chrome-registry key not found.";
                  num2 = (short) 6;
                  num1 = (int) (IntPtr) num2;
                  continue;
                default:
                  goto label_3;
              }
            }
label_41:
            return str1;
        }
    }
  }

  public static string a(int[] A_0)
  {
    int A_1 = 3;
label_1:
    string str = "";
    try
    {
      str = new global::i("CbDGjubbjl$!@890231#@FSDs", 6, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890", "cfhistuCFHISTU").b(A_0);
    }
    catch (Exception ex)
    {
      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
    }
    short num1 = -27464;
    int num2 = (int) num1;
    num1 = (short) -27464;
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
        num1 = (short) 1;
        if (num1 == (short) 0)
          ;
        return str;
    }
  }

  public static bool b(string A_0, int A_1)
  {
    short num1 = 1;
    if (num1 == (short) 0)
      ;
    num1 = (short) 0;
    int num2 = (int) num1;
    switch (num2)
    {
      default:
        bool flag = false;
        try
        {
          string[] files;
          int index;
          switch (0)
          {
            case 0:
label_5:
              files = Directory.GetFiles(A_0);
              index = 0;
              break;
            default:
label_4:
              FileInfo fileInfo;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    if (fileInfo.LastAccessTime < DateTime.Now.AddDays((double) -A_1))
                    {
                      num1 = (short) 4;
                      num2 = (int) (IntPtr) num1;
                      continue;
                    }
                    goto case 2;
                  case 1:
                    num1 = (short) -4026;
                    int num3 = (int) num1;
                    num1 = (short) -4026;
                    int num4 = (int) num1;
                    switch (num3 == num4 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        goto label_6;
                      default:
                        num1 = (short) 0;
                        if (num1 == (short) 0)
                          goto label_10;
                        else
                          goto label_10;
                    }
                  case 2:
                    ++index;
                    num1 = (short) 1;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 3:
                    flag = true;
                    num1 = (short) 6;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 4:
                    fileInfo.Delete();
                    num1 = (short) 2;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 5:
label_10:
                    num1 = (short) 7;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 6:
                    goto label_19;
                  case 7:
                    if (index < files.Length)
                    {
                      fileInfo = new FileInfo(files[index]);
                      num1 = (short) 0;
                      num2 = (int) (IntPtr) num1;
                      continue;
                    }
                    num1 = (short) 3;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  default:
                    goto label_5;
                }
              }
          }
label_6:
          num1 = (short) 5;
          num2 = (int) (IntPtr) num1;
          goto label_4;
        }
        catch (Exception ex)
        {
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
        }
label_19:
        return flag;
    }
  }

  public static string d(int A_0)
  {
    int A_1 = 9;
    switch (0)
    {
      default:
        string str = string.Empty;
        try
        {
          short num1 = 1;
          int num2 = (int) (IntPtr) num1;
          while (true)
          {
            switch (num2)
            {
              case 0:
                num1 = (short) -28664;
                int num3 = (int) num1;
                num1 = (short) -28664;
                int num4 = (int) num1;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_3;
                  default:
                    num1 = (short) 0;
                    if (num1 == (short) 0)
                      goto label_13;
                    else
                      goto label_13;
                }
              case 1:
label_3:
                switch (0)
                {
                  case 0:
                    break;
                  default:
                    continue;
                }
                break;
              case 2:
                goto label_15;
              case 3:
              case 4:
              case 5:
label_13:
                num1 = (short) 2;
                num2 = (int) (IntPtr) num1;
                continue;
              case 6:
                num1 = (short) 4;
                num2 = (int) (IntPtr) num1;
                continue;
            }
            switch (A_0)
            {
              case 1:
                str = global::n.l("https://api.ipify.org");
                num1 = (short) 3;
                num2 = (int) (IntPtr) num1;
                continue;
              case 2:
                str = global::n.l("http://checkip.dyndns.org").Split(':')[1].Trim();
                num1 = (short) 5;
                num2 = (int) (IntPtr) num1;
                continue;
              case 3:
                str = global::n.l("http://whatismyip.org");
                num1 = (short) 0;
                num2 = (int) (IntPtr) num1;
                continue;
              default:
                num1 = (short) 6;
                num2 = (int) (IntPtr) num1;
                continue;
            }
          }
        }
        catch (Exception ex)
        {
          str = string.Empty;
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
        }
label_15:
        if (false)
          ;
        return str;
    }
  }

  private static string l(string A_0)
  {
    int num1 = 0;
    switch (num1)
    {
      default:
        short num2;
        HttpWebRequest httpWebRequest;
        switch (0)
        {
          case 0:
label_3:
            num2 = (short) 1;
            if (num2 == (short) 0)
              ;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType) 3072;
            httpWebRequest = (HttpWebRequest) WebRequest.Create(A_0);
            httpWebRequest.Timeout = 5000;
            httpWebRequest.ReadWriteTimeout = 5000;
            httpWebRequest.UserAgent = global::n.z();
            break;
          default:
label_2:
            HttpWebResponse response;
            while (true)
            {
              switch (num1)
              {
                case 0:
                  num2 = (short) 11383;
                  int num3 = (int) num2;
                  num2 = (short) 11383;
                  int num4 = (int) num2;
                  switch (num3 == num4 ? 1 : 0)
                  {
                    case 0:
                    case 2:
                      goto label_5;
                    default:
                      num2 = (short) 0;
                      if (num2 == (short) 0)
                        break;
                      break;
                  }
                  break;
                case 1:
                  if (global::n.c)
                  {
                    num2 = (short) 3;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  break;
                case 2:
                  goto label_8;
                case 3:
                  httpWebRequest.Proxy = GlobalProxySelection.GetEmptyWebProxy();
                  num2 = (short) 0;
                  num1 = (int) (IntPtr) num2;
                  continue;
                default:
                  goto label_3;
              }
              response = (HttpWebResponse) httpWebRequest.GetResponse();
              num2 = (short) 2;
              num1 = (int) (IntPtr) num2;
            }
label_8:
            string end;
            try
            {
              Encoding ascii = Encoding.ASCII;
              StreamReader streamReader = new StreamReader(response.GetResponseStream(), ascii);
              try
              {
                end = streamReader.ReadToEnd();
              }
              finally
              {
                int num5 = 2;
                while (true)
                {
                  short num6;
                  switch (num5)
                  {
                    case 0:
                      goto label_16;
                    case 1:
                      streamReader.Dispose();
                      num6 = (short) 0;
                      num5 = (int) (IntPtr) num6;
                      continue;
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
                  if (streamReader != null)
                  {
                    num6 = (short) 1;
                    num5 = (int) (IntPtr) num6;
                  }
                  else
                    break;
                }
label_16:;
              }
            }
            finally
            {
              short num7 = 2;
              int num8 = (int) (IntPtr) num7;
              while (true)
              {
                switch (num8)
                {
                  case 0:
                    goto label_23;
                  case 1:
                    ((IDisposable) response).Dispose();
                    num7 = (short) 0;
                    num8 = (int) (IntPtr) num7;
                    continue;
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
                if (response != null)
                {
                  num7 = (short) 1;
                  num8 = (int) (IntPtr) num7;
                }
                else
                  break;
              }
label_23:;
            }
            return end.Trim();
        }
label_5:
        num2 = (short) 1;
        num1 = (int) (IntPtr) num2;
        goto label_2;
    }
  }

  public static void b(string A_0, bool A_1 = false)
  {
    int A_1_1 = 9;
    try
    {
      short num1 = 0;
      int num2 = (int) num1;
      switch (num2)
      {
        default:
          string A_0_1;
          string str1;
          switch (0)
          {
            case 0:
label_4:
              global::g.c("Begin create desktop shortcut");
              A_0_1 = string.Empty;
              str1 = string.Empty;
              num1 = (short) 12;
              num2 = (int) (IntPtr) num1;
              goto default;
            default:
              while (true)
              {
                Uri uri1;
                int port;
                string A_2;
                string A_0_2;
                string str2;
                switch (num2)
                {
                  case 0:
                    global::g.c("Trying to create shortcut in user desktop");
                    string folderPath1 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    A_0_1 = global::n.c(A_0_2, folderPath1);
                    global::n.b(A_0_1, str1, A_2);
                    num1 = (short) 5;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 1:
                    A_0 = global::n.k(Path.GetFileNameWithoutExtension(A_0));
                    Uri uri2 = new Uri(A_0);
                    str1 = uri2.Scheme + "://" + uri2.Authority + "/mobiledoc/jsp/webemr/login/newLogin.jsp";
                    num1 = (short) 15;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 2:
label_26:
                    if (!global::n.a(uri1))
                    {
                      num1 = (short) 9;
                      num2 = (int) (IntPtr) num1;
                      continue;
                    }
                    goto case 5;
                  case 3:
                    str2 = "";
                    break;
                  case 4:
                    if (!global::n.a(uri1, global::n.a.b))
                    {
                      num1 = (short) 0;
                      num2 = (int) (IntPtr) num1;
                      continue;
                    }
                    goto case 5;
                  case 5:
                  case 17:
                    global::g.c("End create desktop shortcut");
                    num1 = (short) 8;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 6:
                    num1 = (short) 4;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 7:
                    if (global::n.b(A_0_1, str1, A_2))
                    {
                      num1 = (short) 18;
                      num2 = (int) (IntPtr) num1;
                      continue;
                    }
                    num1 = (short) 6;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 8:
                    goto label_36;
                  case 9:
                    A_2 = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\eClinicalWorks\plugin\";
                    global::g.c("Trying to create shortcut in public desktop");
                    string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
                    A_0_1 = global::n.c(A_0_2, folderPath2);
                    num1 = (short) 7;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 10:
                    global::n.a(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), uri1);
                    num1 = (short) -2232;
                    int num3 = (int) num1;
                    num1 = (short) -2232;
                    int num4 = (int) num1;
                    switch (num3 == num4 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        goto label_26;
                      default:
                        num1 = (short) 0;
                        if (num1 == (short) 0)
                          ;
                        num1 = (short) 17;
                        num2 = (int) (IntPtr) num1;
                        continue;
                    }
                  case 11:
                    num1 = (short) 14;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 12:
                    if (!A_1)
                    {
                      num1 = (short) 1;
                      num2 = (int) (IntPtr) num1;
                      continue;
                    }
                    str1 = A_0;
                    num1 = (short) 16;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 13:
                    if (!string.IsNullOrEmpty(port.ToString()))
                    {
                      num1 = (short) 11;
                      num2 = (int) (IntPtr) num1;
                      continue;
                    }
                    num1 = (short) 3;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 14:
                    string str3 = "-";
                    port = new Uri(str1).Port;
                    string str4 = port.ToString();
                    str2 = str3 + str4;
                    break;
                  case 15:
                  case 16:
                    uri1 = new Uri(str1);
                    port = new Uri(str1).Port;
                    num1 = (short) 13;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 18:
                    if (global::n.a(uri1, global::n.a.b))
                    {
                      num1 = (short) 10;
                      num2 = (int) (IntPtr) num1;
                      continue;
                    }
                    goto case 5;
                  default:
                    goto label_4;
                }
                string str5 = str2;
                A_0_2 = new Uri(str1).Host + str5;
                num1 = (short) 2;
                num2 = (int) (IntPtr) num1;
              }
          }
      }
    }
    catch (Exception ex)
    {
      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
    }
label_36:
    if (false)
      ;
  }

  public static bool a(string A_0, Uri A_1)
  {
    int A_1_1 = 0;
    int num1 = 0;
    switch (num1)
    {
      default:
        if (false)
          ;
        bool flag = false;
        try
        {
          string[] files;
          int index;
          short num2;
          switch (0)
          {
            case 0:
label_5:
              files = Directory.GetFiles(A_0, "*.lnk");
              index = 0;
              num2 = (short) 6;
              num1 = (int) (IntPtr) num2;
              goto default;
            default:
              string str;
              // ISSUE: variable of a compiler-generated type
              global::t instance;
              // ISSUE: variable of a compiler-generated type
              global::s s;
              while (true)
              {
                switch (num1)
                {
                  case 0:
                    // ISSUE: reference to a compiler-generated method
                    if (s.h().Contains(A_1.Scheme + "://" + A_1.Authority))
                    {
                      num2 = (short) 5;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto case 10;
                  case 1:
                    if (index < files.Length)
                    {
                      num2 = (short) 20391;
                      int num3 = (int) num2;
                      num2 = (short) 20391;
                      int num4 = (int) num2;
                      switch (num3 == num4 ? 1 : 0)
                      {
                        case 0:
                        case 2:
                          goto label_6;
                        default:
                          num2 = (short) 0;
                          if (num2 == (short) 0)
                            ;
                          str = files[index];
                          instance = (global::t) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
                          num2 = (short) 12;
                          num1 = (int) (IntPtr) num2;
                          continue;
                      }
                    }
                    else
                    {
                      num2 = (short) 9;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                  case 2:
                    goto label_25;
                  case 3:
                    // ISSUE: reference to a compiler-generated method
                    if (s.k().EndsWith("eCWUrlLaunch.exe"))
                    {
                      num2 = (short) 11;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto case 10;
                  case 4:
                  case 6:
                    num2 = (short) 1;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 5:
                    System.IO.File.Delete(str);
                    num2 = (short) 10;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 7:
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    s = global::n.b.a.Target((CallSite) global::n.b.a, instance.a(str));
                    num2 = (short) 3;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 8:
label_6:
                    // ISSUE: reference to a compiler-generated field
                    global::n.b.a = CallSite<Func<CallSite, object, global::s>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof (global::s), typeof (global::n)));
                    num2 = (short) 7;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 9:
                    flag = true;
                    num2 = (short) 2;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 10:
                    ++index;
                    num2 = (short) 4;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 11:
                    num2 = (short) 0;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 12:
                    // ISSUE: reference to a compiler-generated field
                    if (global::n.b.a == null)
                    {
                      num2 = (short) 8;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto case 7;
                  default:
                    goto label_5;
                }
              }
          }
        }
        catch (Exception ex)
        {
          flag = false;
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
        }
label_25:
        return flag;
    }
  }

  private static bool b(string A_0, string A_1, string A_2)
  {
    int A_1_1 = 18;
label_1:
    short num = 1;
    if (num == (short) 0)
      ;
    bool flag;
    try
    {
      // ISSUE: variable of a compiler-generated type
      global::t instance = (global::t) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
      // ISSUE: reference to a compiler-generated method
      // ISSUE: variable of a compiler-generated type
      global::s s = instance.a(A_0) as global::s;
      // ISSUE: reference to a compiler-generated method
      s.g(A_1);
      // ISSUE: reference to a compiler-generated method
      s.i(A_2 + "eCWUrlLaunch.exe");
      // ISSUE: reference to a compiler-generated method
      s.g(1);
      // ISSUE: reference to a compiler-generated method
      s.h("Launch eClinicalWorks Web");
      // ISSUE: reference to a compiler-generated method
      s.j(A_2);
      // ISSUE: reference to a compiler-generated method
      s.o();
      flag = true;
    }
    catch (Exception ex)
    {
      flag = false;
      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
    }
    num = (short) 9534;
    switch ((short) 9534 == num ? 1 : 0)
    {
      case 0:
      case 2:
        goto label_1;
      default:
        num = (short) 0;
        if (num == (short) 0)
          ;
        return flag;
    }
  }

  public static string k(string A_0)
  {
    int A_1 = 17;
    int num1 = 0;
    switch (num1)
    {
      default:
        string str = string.Empty;
        try
        {
          string[] strArray1;
          short num2;
          switch (0)
          {
            case 0:
label_4:
              strArray1 = A_0.Split('_');
              num2 = (short) -13617;
              int num3 = (int) num2;
              num2 = (short) -13617;
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
                  num2 = (short) 4;
                  num1 = (int) (IntPtr) num2;
                  goto label_3;
              }
              break;
            default:
label_3:
              while (true)
              {
                switch (num1)
                {
                  case 0:
                    goto label_22;
                  case 1:
                    string[] strArray2 = strArray1[2].Split('-');
                    str = str + strArray2[0] + ":" + strArray2[1].Split(' ')[0];
                    num2 = (short) 2;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 2:
                  case 6:
                    num2 = (short) 0;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 3:
                    if (!strArray1[2].Contains("-"))
                    {
                      str += strArray1[2].Split(' ')[0];
                      num2 = (short) 6;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    num2 = (short) 1;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 4:
                    if (strArray1.Length > 1)
                    {
                      num2 = (short) 5;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto case 2;
                  case 5:
                    num2 = (short) 8;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 7:
                    goto label_9;
                  case 8:
                    if (strArray1[1].ToLower() == "s")
                    {
                      num2 = (short) 7;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    str = "http://";
                    num2 = (short) 9;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 9:
                  case 10:
                    num2 = (short) 3;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_9:
              str = "https://";
              break;
          }
          num2 = (short) 10;
          num1 = (int) (IntPtr) num2;
          goto label_3;
        }
        catch (Exception ex)
        {
          str = string.Empty;
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
        }
label_22:
        if (false)
          ;
        return str;
    }
  }

  private static bool a(Uri A_0, global::n.a A_1 = global::n.a.a)
  {
    int A_1_1 = 15;
    int num1 = 0;
    switch (num1)
    {
      default:
        bool flag;
        short num2;
        switch (0)
        {
          case 0:
label_3:
            flag = false;
            num2 = (short) 0;
            num1 = (int) (IntPtr) num2;
            goto default;
          default:
            // ISSUE: variable of a compiler-generated type
            global::t instance1;
            string A_0_1;
            // ISSUE: variable of a compiler-generated type
            global::s s1;
            string[] files1;
            int index1;
            // ISSUE: variable of a compiler-generated type
            global::t instance2;
            string A_0_2;
            // ISSUE: variable of a compiler-generated type
            global::s s2;
            string[] files2;
            int index2;
            while (true)
            {
              switch (num1)
              {
                case 0:
                  if (A_1 == global::n.a.a)
                  {
                    num2 = (short) 11;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  files1 = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "*.lnk");
                  index1 = 0;
                  num2 = (short) 18;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 1:
                case 7:
                  goto label_39;
                case 2:
                  ++index2;
                  num2 = (short) 14;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 3:
                  if (index2 < files2.Length)
                  {
                    A_0_2 = files2[index2];
                    instance2 = (global::t) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
                    num2 = (short) 16;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  num2 = (short) 5;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 4:
                  // ISSUE: reference to a compiler-generated field
                  global::n.c.a = CallSite<Func<CallSite, object, global::s>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof (global::s), typeof (global::n)));
                  num2 = (short) 23;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 5:
                  num2 = (short) 1;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 6:
                  num2 = (short) 1;
                  if (num2 == (short) 0)
                    ;
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  s1 = global::n.c.b.Target((CallSite) global::n.c.b, instance1.a(A_0_1));
                  num2 = (short) 21;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 8:
                  flag = true;
                  num2 = (short) 13;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 9:
                  if (index1 >= files1.Length)
                  {
                    num2 = (short) 7;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  A_0_1 = files1[index1];
                  instance1 = (global::t) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
                  num2 = (short) 20;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 10:
                  // ISSUE: reference to a compiler-generated method
                  if (s1.k().EndsWith("eCWUrlLaunch.exe"))
                  {
                    num2 = (short) -10479;
                    int num3 = (int) num2;
                    num2 = (short) -10479;
                    int num4 = (int) num2;
                    switch (num3 == num4 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        goto label_16;
                      default:
                        num2 = (short) 0;
                        if (num2 == (short) 0)
                          ;
                        num2 = (short) 8;
                        num1 = (int) (IntPtr) num2;
                        continue;
                    }
                  }
                  else
                    goto case 13;
                case 11:
                  files2 = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory), "*.lnk");
                  index2 = 0;
                  num2 = (short) 15;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 12:
                  // ISSUE: reference to a compiler-generated method
                  if (s2.h().Contains(A_0.Scheme + "://" + A_0.Authority))
                  {
                    num2 = (short) 17;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto case 2;
                case 13:
                  ++index1;
                  num2 = (short) 24;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 14:
                case 15:
                  num2 = (short) 3;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 16:
label_16:
                  // ISSUE: reference to a compiler-generated field
                  if (global::n.c.a == null)
                  {
                    num2 = (short) 4;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto case 23;
                case 17:
                  flag = true;
                  num2 = (short) 2;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 18:
                case 24:
                  num2 = (short) 9;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 19:
                  num2 = (short) 10;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 20:
                  // ISSUE: reference to a compiler-generated field
                  if (global::n.c.b == null)
                  {
                    num2 = (short) 22;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto case 6;
                case 21:
                  // ISSUE: reference to a compiler-generated method
                  if (s1.h().Contains(A_0.Scheme + "://" + A_0.Authority))
                  {
                    num2 = (short) 19;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto case 13;
                case 22:
                  // ISSUE: reference to a compiler-generated field
                  global::n.c.b = CallSite<Func<CallSite, object, global::s>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof (global::s), typeof (global::n)));
                  num2 = (short) 6;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 23:
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated field
                  // ISSUE: reference to a compiler-generated method
                  s2 = global::n.c.a.Target((CallSite) global::n.c.a, instance2.a(A_0_2));
                  num2 = (short) 12;
                  num1 = (int) (IntPtr) num2;
                  continue;
                default:
                  goto label_3;
              }
            }
label_39:
            return flag;
        }
    }
  }

  private static string c(string A_0, string A_1)
  {
    int A_1_1 = 6;
    int num1 = 0;
    switch (num1)
    {
      default:
label_1:
        string path1;
        short num2;
        switch (0)
        {
          case 0:
label_3:
            path1 = A_1 + "\eClinicalWorks - Web.lnk";
            num2 = (short) 2;
            num1 = (int) (IntPtr) num2;
            goto default;
          default:
            string withoutExtension;
            int num3;
            string directoryName;
            string extension;
            string path2;
            while (true)
            {
              switch (num1)
              {
                case 0:
                  if (System.IO.File.Exists(path2))
                  {
                    num2 = (short) 8485;
                    int num4 = (int) num2;
                    num2 = (short) 8485;
                    int num5 = (int) num2;
                    switch (num4 == num5 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        goto label_1;
                      default:
                        num2 = (short) 0;
                        if (num2 == (short) 0)
                          ;
                        string str = string.Format("{0}({1})", (object) withoutExtension, (object) num3++);
                        path2 = Path.Combine(directoryName, str + extension);
                        num2 = (short) 1;
                        if (num2 == (short) 0)
                          ;
                        num2 = (short) 3;
                        num1 = (int) (IntPtr) num2;
                        continue;
                    }
                  }
                  else
                  {
                    num2 = (short) 4;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                case 1:
                  goto label_11;
                case 2:
                  if (!System.IO.File.Exists(path1))
                  {
                    num2 = (short) 1;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  path1 = A_1 + "\eClinicalWorks - Web (" + A_0 + ").lnk";
                  num3 = 1;
                  withoutExtension = Path.GetFileNameWithoutExtension(path1);
                  extension = Path.GetExtension(path1);
                  directoryName = Path.GetDirectoryName(path1);
                  path2 = path1;
                  num2 = (short) 5;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 3:
                case 5:
                  num2 = (short) 0;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 4:
                  goto label_15;
                default:
                  goto label_3;
              }
            }
label_11:
            return path1;
label_15:
            return path2;
        }
    }
  }

  public static void ad()
  {
    int A_1 = 1;
    try
    {
      int num1;
      string str1;
      string str2;
      short num2;
      switch (0)
      {
        case 0:
label_3:
          str1 = "";
          str2 = Environment.GetEnvironmentVariable("CW_HOME").Trim();
          num2 = (short) 1;
          num1 = (int) (IntPtr) num2;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
                global::n.b(str1, 7);
                num2 = (short) 12;
                num1 = (int) (IntPtr) num2;
                continue;
              case 1:
                if (!str2.EndsWith("\"))
                {
                  num2 = (short) 11;
                  num1 = (int) (IntPtr) num2;
                  continue;
                }
                goto case 13;
              case 2:
label_6:
                num2 = (short) 8;
                num1 = (int) (IntPtr) num2;
                continue;
              case 3:
                global::n.b(str1, 7);
                num2 = (short) 10;
                num1 = (int) (IntPtr) num2;
                continue;
              case 4:
                if (Directory.Exists(str1))
                {
                  num2 = (short) 0;
                  num1 = (int) (IntPtr) num2;
                  continue;
                }
                break;
              case 5:
                goto label_28;
              case 6:
                num2 = (short) 14;
                num1 = (int) (IntPtr) num2;
                continue;
              case 7:
                str1 = ConfigurationManager.AppSettings["ConsoleLogFolderPath"].Trim();
                num2 = (short) 2;
                num1 = (int) (IntPtr) num2;
                continue;
              case 8:
                if (!string.IsNullOrEmpty(str1))
                {
                  num2 = (short) 6;
                  num1 = (int) (IntPtr) num2;
                  continue;
                }
                goto case 10;
              case 9:
                if (ConfigurationManager.AppSettings["ConsoleLogFolderPath"] != null)
                {
                  num2 = (short) 7;
                  num1 = (int) (IntPtr) num2;
                  continue;
                }
                goto case 2;
              case 10:
                num2 = (short) 5;
                num1 = (int) (IntPtr) num2;
                continue;
              case 11:
                str2 += "\";
                num2 = (short) 13;
                num1 = (int) (IntPtr) num2;
                continue;
              case 12:
                num2 = (short) -10234;
                int num3 = (int) num2;
                num2 = (short) -10234;
                int num4 = (int) num2;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_6;
                  default:
                    num2 = (short) 0;
                    if (num2 == (short) 0)
                      break;
                    break;
                }
                break;
              case 13:
                str1 = str2 + "ChromeLogs";
                num2 = (short) 4;
                num1 = (int) (IntPtr) num2;
                continue;
              case 14:
                if (Directory.Exists(str1))
                {
                  num2 = (short) 3;
                  num1 = (int) (IntPtr) num2;
                  continue;
                }
                goto case 10;
              default:
                goto label_3;
            }
            num2 = (short) 9;
            num1 = (int) (IntPtr) num2;
          }
      }
    }
    catch (Exception ex)
    {
      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
    }
label_28:
    if (false)
      ;
  }

  public static bool ac()
  {
    int A_1 = 10;
    short num1 = -6561;
    int num2 = (int) num1;
    num1 = (short) -6561;
    int num3 = (int) num1;
    bool flag;
    switch (num2 == num3 ? 1 : 0)
    {
      case 0:
      case 2:
label_21:
        return flag;
      default:
        if (true)
          ;
        short num4 = 0;
        int num5 = (int) num4;
        switch (num5)
        {
          default:
            num4 = (short) 1;
            if (num4 == (short) 0)
              ;
            flag = false;
            try
            {
              string[] directories;
              int index;
              switch (0)
              {
                case 0:
label_7:
                  directories = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\eClinicalWorks\plugin\midmark");
                  index = 0;
                  num4 = (short) 6;
                  num5 = (int) (IntPtr) num4;
                  goto default;
                default:
                  string path;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 0:
                        Directory.Delete(path, true);
                        num4 = (short) 7;
                        num5 = (int) (IntPtr) num4;
                        continue;
                      case 1:
                        if (index >= directories.Length)
                        {
                          num4 = (short) 5;
                          num5 = (int) (IntPtr) num4;
                          continue;
                        }
                        path = directories[index];
                        num4 = (short) 8;
                        num5 = (int) (IntPtr) num4;
                        continue;
                      case 2:
                        if (!(new DirectoryInfo(path).Name.ToLower() == "config"))
                        {
                          num4 = (short) 0;
                          num5 = (int) (IntPtr) num4;
                          continue;
                        }
                        goto case 7;
                      case 3:
                      case 6:
                        num4 = (short) 1;
                        num5 = (int) (IntPtr) num4;
                        continue;
                      case 4:
                        goto label_21;
                      case 5:
                        flag = true;
                        num4 = (short) 4;
                        num5 = (int) (IntPtr) num4;
                        continue;
                      case 7:
                        ++index;
                        num4 = (short) 3;
                        num5 = (int) (IntPtr) num4;
                        continue;
                      case 8:
                        if (!(new DirectoryInfo(path).Name.ToLower() == "calibration"))
                        {
                          num4 = (short) 9;
                          num5 = (int) (IntPtr) num4;
                          continue;
                        }
                        goto case 7;
                      case 9:
                        num4 = (short) 2;
                        num5 = (int) (IntPtr) num4;
                        continue;
                      default:
                        goto label_7;
                    }
                  }
              }
            }
            catch (Exception ex)
            {
              global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
              goto label_21;
            }
        }
    }
  }

  public static bool? ab()
  {
    int A_1 = 0;
label_1:
    short num1 = 0;
    int num2 = (int) num1;
    switch (num2)
    {
      default:
        num1 = (short) 2321;
        int num3 = (int) num1;
        num1 = (short) 2321;
        int num4 = (int) num1;
        switch (num3 == num4 ? 1 : 0)
        {
          case 0:
          case 2:
            goto label_1;
          default:
            num1 = (short) 0;
            if (num1 == (short) 0)
              ;
            bool? nullable = new bool?(false);
            try
            {
              string str1;
              string path;
              switch (0)
              {
                case 0:
label_7:
                  str1 = string.Empty;
                  path = string.Empty;
                  num1 = (short) 9;
                  num2 = (int) (IntPtr) num1;
                  goto default;
                default:
                  string str2;
                  while (true)
                  {
                    switch (num2)
                    {
                      case 0:
                        path += "\";
                        num1 = (short) 19;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      case 1:
                        nullable = new bool?(true);
                        num1 = (short) 20;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      case 2:
                        if (!str2.EndsWith("\"))
                        {
                          num1 = (short) 6;
                          num2 = (int) (IntPtr) num1;
                          continue;
                        }
                        goto case 18;
                      case 3:
                        num1 = (short) 10;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      case 4:
                        str1 = str2 + "ChromeLogs\chrome_console_" + DateTime.Now.ToString("MM-dd-yyyy HH-mm-ss", (IFormatProvider) CultureInfo.InvariantCulture) + ".log";
                        num1 = (short) 16;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      case 5:
                        if (!path.EndsWith("\"))
                        {
                          num1 = (short) 0;
                          num2 = (int) (IntPtr) num1;
                          continue;
                        }
                        goto case 19;
                      case 6:
                        str2 += "\";
                        num1 = (short) 18;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      case 7:
                        num1 = (short) 1;
                        if (num1 == (short) 0)
                          ;
                        path = ConfigurationManager.AppSettings["ConsoleLogFolderPath"];
                        num1 = (short) 3;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      case 8:
                      case 16:
                        num1 = (short) 21;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      case 9:
                        if (ConfigurationManager.AppSettings["ConsoleLogFolderPath"] != null)
                        {
                          num1 = (short) 7;
                          num2 = (int) (IntPtr) num1;
                          continue;
                        }
                        goto case 3;
                      case 10:
                        if (!string.IsNullOrEmpty(path))
                        {
                          num1 = (short) 15;
                          num2 = (int) (IntPtr) num1;
                          continue;
                        }
                        str2 = Environment.GetEnvironmentVariable("CW_HOME").Trim();
                        num1 = (short) 2;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      case 11:
                        if (!Directory.Exists(str2 + "ChromeLogs"))
                        {
                          num1 = (short) 14;
                          num2 = (int) (IntPtr) num1;
                          continue;
                        }
                        goto case 4;
                      case 12:
                        if (!Directory.Exists(path))
                        {
                          num1 = (short) 17;
                          num2 = (int) (IntPtr) num1;
                          continue;
                        }
                        goto case 13;
                      case 13:
                        str1 = path + "\chrome_console_" + DateTime.Now.ToString("MM-dd-yyyy HH-mm-ss", (IFormatProvider) CultureInfo.InvariantCulture) + ".log";
                        num1 = (short) 8;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      case 14:
                        Directory.CreateDirectory(str2 + "ChromeLogs");
                        num1 = (short) 4;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      case 15:
                        num1 = (short) 5;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      case 17:
                        Directory.CreateDirectory(path);
                        num1 = (short) 13;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      case 18:
                        num1 = (short) 11;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      case 19:
                        num1 = (short) 12;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      case 20:
                        goto label_39;
                      case 21:
                        if (!string.IsNullOrEmpty(str1))
                        {
                          num1 = (short) 22;
                          num2 = (int) (IntPtr) num1;
                          continue;
                        }
                        goto case 1;
                      case 22:
                        Environment.SetEnvironmentVariable("CHROME_LOG_FILE", str1);
                        num1 = (short) 1;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      default:
                        goto label_7;
                    }
                  }
              }
            }
            catch (Exception ex)
            {
              nullable = new bool?();
              global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
            }
label_39:
            return nullable;
        }
    }
  }

  [DllImport("User32.dll")]
  private static extern int SetForegroundWindow(IntPtr A_0);

  public static void c(int A_0)
  {
    int A_1 = 1;
    try
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          short num2;
          switch (0)
          {
            case 0:
label_4:
              Thread.Sleep(2000);
              num2 = (short) 5;
              num1 = (int) (IntPtr) num2;
              goto default;
            default:
              while (true)
              {
                int num3;
                Process[] processes;
                int index;
                Process process;
                switch (num1)
                {
                  case 0:
                    if (num3 < A_0)
                    {
                      SendKeys.SendWait("^-");
                      ++num3;
                      num2 = (short) 8;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    num2 = (short) 6;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 1:
                    if (!process.MainWindowTitle.Contains("Web EMR Login Page"))
                    {
                      ++index;
                      num2 = (short) 4;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    num2 = (short) 3;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 2:
                    if (index < processes.Length)
                    {
                      process = processes[index];
                      num2 = (short) 1;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    break;
                  case 3:
                    global::n.SetForegroundWindow(process.MainWindowHandle);
                    num3 = 0;
                    num2 = (short) -18596;
                    int num4 = (int) num2;
                    num2 = (short) -18596;
                    int num5 = (int) num2;
                    switch (num4 == num5 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        break;
                      default:
                        num2 = (short) 0;
                        if (num2 == (short) 0)
                          ;
                        num2 = (short) 12;
                        num1 = (int) (IntPtr) num2;
                        continue;
                    }
                    break;
                  case 4:
                  case 13:
                    num2 = (short) 2;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 5:
                    if (A_0 > 10)
                    {
                      num2 = (short) 9;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto case 11;
                  case 6:
                    num2 = (short) 7;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 7:
                  case 10:
                    num2 = (short) 14;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 8:
                  case 12:
                    num2 = (short) 0;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 9:
                    A_0 = 10;
                    num2 = (short) 11;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 11:
                    processes = Process.GetProcesses();
                    index = 0;
                    num2 = (short) 13;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 14:
                    goto label_28;
                  default:
                    goto label_4;
                }
                num2 = (short) 10;
                num1 = (int) (IntPtr) num2;
              }
          }
      }
    }
    catch (Exception ex)
    {
      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
    }
label_28:
    if (false)
      ;
  }

  public static bool a(string A_0, bool A_1 = false)
  {
    int A_1_1 = 14;
    switch (0)
    {
      default:
        bool flag = false;
        try
        {
          int num1 = 4;
          while (true)
          {
            short num2;
            Process process;
            Process[] processesByName;
            int index1;
            DirectoryInfo[] directories;
            int index2;
            DirectoryInfo directoryInfo;
            switch (num1)
            {
              case 0:
              case 9:
                num2 = (short) 11;
                num1 = (int) (IntPtr) num2;
                continue;
              case 1:
                flag = global::n.a(A_0, 5);
                global::g.a("CleanUpAndCloseApp result: " + flag.ToString());
                num2 = (short) 5;
                num1 = (int) (IntPtr) num2;
                continue;
              case 2:
              case 3:
                num2 = (short) 12;
                num1 = (int) (IntPtr) num2;
                continue;
              case 4:
                switch (0)
                {
                  case 0:
                    goto label_5;
                  default:
                    continue;
                }
              case 5:
                directories = new DirectoryInfo(Path.GetTempPath()).GetDirectories();
                index2 = 0;
                num2 = (short) 3;
                num1 = (int) (IntPtr) num2;
                continue;
              case 6:
                try
                {
                  process.Kill();
                }
                catch (Exception ex)
                {
                  global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
                }
                ++index1;
                num1 = 0;
                continue;
              case 7:
                try
                {
                  num2 = (short) 0;
                  int num3 = (int) (IntPtr) num2;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 0:
                        switch (0)
                        {
                          case 0:
                            goto label_20;
                          default:
                            continue;
                        }
                      case 1:
                        try
                        {
                          Directory.Delete(directoryInfo.FullName, true);
                          break;
                        }
                        catch (Exception ex)
                        {
                          global::g.a(ex.Message);
                          break;
                        }
                      case 2:
                        if (directoryInfo.CreationTime < DateTime.Now.AddHours(-24.0))
                        {
                          num2 = (short) 1;
                          num3 = (int) (IntPtr) num2;
                          continue;
                        }
                        break;
                      case 3:
                        num2 = (short) 2;
                        num3 = (int) (IntPtr) num2;
                        continue;
                      case 4:
                        goto label_15;
                      default:
label_20:
                        if (directoryInfo.Name.ToLower().StartsWith("ecwchrome_"))
                        {
                          num2 = (short) 3;
                          num3 = (int) (IntPtr) num2;
                          continue;
                        }
                        break;
                    }
                    num2 = (short) 4;
                    num3 = (int) (IntPtr) num2;
                  }
                }
                catch (IOException ex)
                {
                  global::g.a(ex.Message);
                }
label_15:
                ++index2;
                break;
              case 8:
                processesByName = Process.GetProcessesByName("WinProjectE");
                index1 = 0;
                num2 = (short) 9;
                num1 = (int) (IntPtr) num2;
                continue;
              case 10:
                flag = true;
                num2 = (short) 13;
                num1 = (int) (IntPtr) num2;
                continue;
              case 11:
                num2 = (short) 28023;
                int num4 = (int) num2;
                num2 = (short) 28023;
                int num5 = (int) num2;
                switch (num4 == num5 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    break;
                  default:
                    num2 = (short) 0;
                    if (num2 == (short) 0)
                      ;
                    if (index1 < processesByName.Length)
                    {
                      process = processesByName[index1];
                      num2 = (short) 6;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    num2 = (short) 1;
                    num1 = (int) (IntPtr) num2;
                    continue;
                }
                break;
              case 12:
                if (index2 < directories.Length)
                {
                  directoryInfo = directories[index2];
                  num2 = (short) 7;
                  num1 = (int) (IntPtr) num2;
                  continue;
                }
                num2 = (short) 10;
                num1 = (int) (IntPtr) num2;
                continue;
              case 13:
                goto label_39;
              default:
label_5:
                if (!A_1)
                {
                  num2 = (short) 8;
                  num1 = (int) (IntPtr) num2;
                  continue;
                }
                goto case 5;
            }
            num2 = (short) 2;
            num1 = (int) (IntPtr) num2;
          }
        }
        catch (Exception ex)
        {
          flag = false;
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
        }
label_39:
        if (false)
          ;
        return flag;
    }
  }

  public static bool a(string A_0, int A_1)
  {
label_0:
    bool flag1 = false;
    bool flag2;
    try
    {
      short num1 = 3;
      int num2 = (int) (IntPtr) num1;
      while (true)
      {
        switch (num2)
        {
          case 0:
            if (A_1 > 0)
            {
              num1 = (short) 8;
              num2 = (int) (IntPtr) num1;
              continue;
            }
            goto case 2;
          case 1:
            if (Directory.Exists(A_0))
            {
              num1 = (short) 9;
              num2 = (int) (IntPtr) num1;
              continue;
            }
            flag1 = true;
            num1 = (short) 5;
            num2 = (int) (IntPtr) num1;
            continue;
          case 2:
            num1 = (short) 1;
            num2 = (int) (IntPtr) num1;
            continue;
          case 3:
            switch (0)
            {
              case 0:
                goto label_8;
              default:
                continue;
            }
          case 4:
            if (Directory.Exists(A_0))
            {
              Directory.Delete(A_0, true);
              --A_1;
              Thread.Sleep(2000);
              num1 = (short) 10;
              num2 = (int) (IntPtr) num1;
              continue;
            }
            num1 = (short) 2;
            num2 = (int) (IntPtr) num1;
            continue;
          case 5:
          case 6:
            num1 = (short) 12;
            num2 = (int) (IntPtr) num1;
            continue;
          case 7:
            flag2 = false;
            num1 = (short) 11;
            num2 = (int) (IntPtr) num1;
            continue;
          case 8:
            num1 = (short) 4;
            num2 = (int) (IntPtr) num1;
            continue;
          case 9:
            flag1 = false;
            num1 = (short) 6;
            num2 = (int) (IntPtr) num1;
            continue;
          case 10:
            num1 = (short) 0;
            num2 = (int) (IntPtr) num1;
            continue;
          case 11:
            goto label_25;
          case 12:
            goto label_1;
          default:
label_8:
            if (string.IsNullOrEmpty(A_0))
            {
              num1 = (short) 7;
              num2 = (int) (IntPtr) num1;
              continue;
            }
            goto case 10;
        }
      }
    }
    catch (Exception ex)
    {
      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
    }
label_1:
    switch (true ? 1 : 0)
    {
      case 0:
      case 2:
        goto label_0;
      default:
        if (true)
          ;
        if (false)
          ;
        return flag1;
    }
label_25:
    return flag2;
  }

  public static string aa()
  {
    int A_1 = 1;
    int num1 = 2;
    short num2;
    while (true)
    {
      switch (num1)
      {
        case 0:
          if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432")))
          {
            num2 = (short) 3;
            num1 = (int) (IntPtr) num2;
            continue;
          }
          goto label_12;
        case 1:
label_7:
          num2 = (short) 0;
          num1 = (int) (IntPtr) num2;
          continue;
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
          num2 = (short) -3387;
          int num3 = (int) num2;
          num2 = (short) -3387;
          int num4 = (int) num2;
          switch (num3 == num4 ? 1 : 0)
          {
            case 0:
            case 2:
              goto label_7;
            default:
              goto label_11;
          }
      }
      num2 = (short) 1;
      if (num2 == (short) 0)
        ;
      if (8 != IntPtr.Size)
      {
        num2 = (short) 1;
        num1 = (int) (IntPtr) num2;
      }
      else
        break;
    }
label_6:
    return Environment.GetEnvironmentVariable("ProgramFiles(x86)");
label_11:
    num2 = (short) 0;
    if (num2 == (short) 0)
      goto label_6;
    else
      goto label_6;
label_12:
    return Environment.GetEnvironmentVariable("ProgramFiles");
  }

  private static string z()
  {
    int A_1 = 12;
    short num1 = -31562;
    int num2 = (int) num1;
    num1 = (short) -31562;
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
        FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
        return string.Format("eClinicalWorks-Plugin/{0} ({1};{2};{3};{4};{5};)", (object) versionInfo.FileVersion.ToString(), (object) Environment.OSVersion.Platform, (object) Environment.OSVersion.VersionString, (object) Environment.OSVersion.ServicePack, (object) global::n.y(), (object) global::n.aj());
      default:
        goto case 1;
    }
  }

  public static string y()
  {
    int A_1 = 8;
    int num1;
    short num2;
    IPHostEntry ipHostEntry;
    switch (0)
    {
      case 0:
label_2:
        num2 = (short) 1;
        if (num2 == (short) 0)
          ;
        num2 = (short) -3025;
        int num3 = (int) num2;
        num2 = (short) -3025;
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
            ipHostEntry = (IPHostEntry) null;
            num2 = (short) 1;
            num1 = (int) (IntPtr) num2;
            goto label_1;
        }
        break;
      default:
label_1:
        while (true)
        {
          switch (num1)
          {
            case 0:
              if (ipHostEntry == null)
              {
                num2 = (short) 2;
                num1 = (int) (IntPtr) num2;
                continue;
              }
              goto label_12;
            case 1:
              goto label_9;
            case 2:
              goto label_11;
            default:
              goto label_2;
          }
        }
label_9:
        try
        {
          ipHostEntry = Dns.GetHostEntry(Dns.GetHostName());
          break;
        }
        catch (Exception ex)
        {
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
          break;
        }
label_11:
        return "Not Available";
label_12:
        return ipHostEntry.HostName.Split('.')[0];
    }
    num2 = (short) 0;
    num1 = (int) (IntPtr) num2;
    goto label_1;
  }

  public static string a(string A_0, string A_1, CookieContainer A_2)
  {
    int A_1_1 = 16;
label_1:
    short num1 = 0;
    int num2 = (int) num1;
    switch (num2)
    {
      default:
        num1 = (short) -12468;
        int num3 = (int) num1;
        num1 = (short) -12468;
        int num4 = (int) num1;
        switch (num3 == num4 ? 1 : 0)
        {
          case 0:
          case 2:
            goto label_1;
          default:
            num1 = (short) 1;
            if (num1 == (short) 0)
              ;
            num1 = (short) 0;
            if (num1 == (short) 0)
              ;
            string str1 = "";
            try
            {
              string str2;
              switch (0)
              {
                case 0:
label_8:
                  string A_1_2 = global::n.j("server|" + A_1);
                  global::n.a(A_2);
                  str2 = global::n.a(A_0, A_1_2, A_2, true);
                  num1 = (short) 5;
                  num2 = (int) (IntPtr) num1;
                  goto default;
                default:
                  string str3;
                  while (true)
                  {
                    switch (num2)
                    {
                      case 0:
                        if (!str2.ToLower().Contains("false"))
                        {
                          num1 = (short) 9;
                          num2 = (int) (IntPtr) num1;
                          continue;
                        }
                        goto case 7;
                      case 1:
                        if (!str2.ToLower().Contains("<html"))
                        {
                          num1 = (short) 6;
                          num2 = (int) (IntPtr) num1;
                          continue;
                        }
                        goto case 7;
                      case 2:
                        str1 = global::n.j(A_1);
                        global::g.b("Redirecting to login page");
                        num1 = (short) 8;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      case 3:
                        if (!(str3.Split('|')[0].ToLower() == "true"))
                        {
                          str1 = "";
                          num1 = (short) 7;
                          num2 = (int) (IntPtr) num1;
                          continue;
                        }
                        num1 = (short) 2;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      case 4:
                        num1 = (short) 1;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      case 5:
                        if (!str2.ToLower().Contains("sorry session is not valid"))
                        {
                          num1 = (short) 4;
                          num2 = (int) (IntPtr) num1;
                          continue;
                        }
                        goto case 7;
                      case 6:
                        num1 = (short) 0;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      case 7:
                      case 8:
                        num1 = (short) 10;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      case 9:
                        str2 = HttpUtility.UrlDecode(str2);
                        string[] strArray = str2.Split('|');
                        global::g.b("Got encrypted message from server.");
                        str3 = global::n.i(strArray[0]);
                        global::g.b("Decrypted server message:" + str3);
                        num1 = (short) 3;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      case 10:
                        goto label_24;
                      default:
                        goto label_8;
                    }
                  }
              }
            }
            catch (Exception ex)
            {
              str1 = (string) null;
              global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
            }
label_24:
            return str1;
        }
    }
  }

  public static string a(string A_0, string A_1, CookieContainer A_2, bool A_3 = false)
  {
    int A_1_1 = 10;
    short num1 = 1;
    if (num1 == (short) 0)
      ;
    num1 = (short) 0;
    int num2 = (int) num1;
    switch (num2)
    {
      default:
        string str = string.Empty;
        global::g.a(" PostHttpResponse started ");
        ServicePointManager.SecurityProtocol = (SecurityProtocolType) 3072;
        try
        {
          HttpWebRequest httpWebRequest;
          switch (0)
          {
            case 0:
label_5:
              httpWebRequest = WebRequest.Create(A_0) as HttpWebRequest;
              Uri uri = new Uri(A_0);
              global::g.b("URL: " + A_0);
              httpWebRequest.PreAuthenticate = true;
              httpWebRequest.KeepAlive = false;
              httpWebRequest.Method = "POST";
              httpWebRequest.UserAgent = global::n.z();
              httpWebRequest.CookieContainer = A_2;
              num1 = (short) 3;
              num2 = (int) (IntPtr) num1;
              goto default;
            default:
label_4:
              HttpWebResponse response;
              byte[] bytes;
              Stream requestStream;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    bytes = Encoding.UTF8.GetBytes(A_1);
                    httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                    httpWebRequest.ContentLength = (long) bytes.Length;
                    requestStream = httpWebRequest.GetRequestStream();
                    num1 = (short) 4;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 1:
                    num1 = (short) 7;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 2:
                    httpWebRequest.Proxy = GlobalProxySelection.GetEmptyWebProxy();
                    num1 = (short) 1;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 3:
                    if (global::n.c)
                    {
                      num1 = (short) 2;
                      num2 = (int) (IntPtr) num1;
                      continue;
                    }
                    goto case 1;
                  case 4:
                    try
                    {
                      requestStream.Write(bytes, 0, bytes.Length);
                      requestStream.Close();
                    }
                    finally
                    {
                      short num3 = 1;
                      int num4 = (int) (IntPtr) num3;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 0:
                            requestStream.Dispose();
                            num3 = (short) 2;
                            num4 = (int) (IntPtr) num3;
                            continue;
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
                            goto label_39;
                        }
                        if (requestStream != null)
                        {
                          num3 = (short) 0;
                          num4 = (int) (IntPtr) num3;
                        }
                        else
                          break;
                      }
label_39:;
                    }
                    response = (HttpWebResponse) httpWebRequest.GetResponse();
                    num1 = (short) 6;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 5:
                    A_1 = "FormData=" + HttpUtility.UrlEncode(A_1);
                    num1 = (short) 0;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 6:
                    try
                    {
                      StreamReader streamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                      try
                      {
                        str = streamReader.ReadToEnd();
                        response.Close();
                        streamReader.Close();
                      }
                      finally
                      {
                        int num5 = 1;
                        while (true)
                        {
                          short num6;
                          switch (num5)
                          {
                            case 0:
                              streamReader.Dispose();
                              num6 = (short) 2;
                              num5 = (int) (IntPtr) num6;
                              continue;
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
                              goto label_16;
                          }
                          if (streamReader != null)
                          {
                            num6 = (short) 0;
                            num5 = (int) (IntPtr) num6;
                          }
                          else
                            break;
                        }
label_16:;
                      }
                    }
                    finally
                    {
                      short num7 = 1;
                      int num8 = (int) (IntPtr) num7;
                      while (true)
                      {
                        switch (num8)
                        {
                          case 0:
                            ((IDisposable) response).Dispose();
                            num7 = (short) 2;
                            num8 = (int) (IntPtr) num7;
                            continue;
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
                            goto label_23;
                        }
                        if (response != null)
                        {
                          num7 = (short) 0;
                          num8 = (int) (IntPtr) num7;
                        }
                        else
                          break;
                      }
label_23:;
                    }
                    num1 = (short) 8;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 7:
                    while (A_3)
                    {
                      num1 = (short) 11661;
                      int num9 = (int) num1;
                      num1 = (short) 11661;
                      int num10 = (int) num1;
                      switch (num9 == num10 ? 1 : 0)
                      {
                        case 0:
                        case 2:
                          continue;
                        default:
                          num1 = (short) 0;
                          if (num1 == (short) 0)
                            ;
                          num1 = (short) 5;
                          num2 = (int) (IntPtr) num1;
                          goto label_4;
                      }
                    }
                    goto case 0;
                  case 8:
                    goto label_44;
                  default:
                    goto label_5;
                }
              }
          }
        }
        catch (HttpException ex)
        {
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
          throw new Exception("Error Code ::" + ex.ErrorCode.ToString() + "Message :: " + ex.Message, ex.InnerException);
        }
        catch (Exception ex)
        {
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
          throw ex;
        }
label_44:
        global::g.b(" Data From Server = " + str.Trim());
        global::g.a(" PostHttpResponse Completed ");
        return str.Trim();
    }
  }

  public static string x()
  {
    short num1 = 706;
    int num2 = (int) num1;
    num1 = (short) 706;
    int num3 = (int) num1;
    string str;
    switch (num2 == num3 ? 1 : 0)
    {
      case 0:
      case 2:
        return str;
      default:
        short num4 = 1;
        if (num4 == (short) 0)
          ;
        num4 = (short) 0;
        if (num4 == (short) 0)
          ;
        str = string.Empty;
        try
        {
          str = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;
          goto case 0;
        }
        catch (Exception ex)
        {
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
          goto case 0;
        }
    }
  }

  public static string j(string A_0)
  {
    short num1 = 30566;
    int num2 = (int) num1;
    num1 = (short) 30566;
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
        RSACryptoServiceProvider cryptoServiceProvider = global::n.u();
        byte[] inArray = cryptoServiceProvider.Encrypt(Encoding.UTF8.GetBytes(A_0), false);
        cryptoServiceProvider.Dispose();
        return Convert.ToBase64String(inArray);
      default:
        goto case 1;
    }
  }

  public static string i(string A_0)
  {
    short num1 = -16584;
    int num2 = (int) num1;
    num1 = (short) -16584;
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
        RSACryptoServiceProvider cryptoServiceProvider = global::n.t();
        byte[] bytes = cryptoServiceProvider.Decrypt(Convert.FromBase64String(A_0), false);
        cryptoServiceProvider.Dispose();
        return Encoding.UTF8.GetString(bytes);
      default:
        goto case 1;
    }
  }

  public static string h(string A_0)
  {
    short num1 = -10879;
    int num2 = (int) num1;
    num1 = (short) -10879;
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
        RSACryptoServiceProvider cryptoServiceProvider = global::n.w();
        byte[] bytes = cryptoServiceProvider.Decrypt(Convert.FromBase64String(A_0), false);
        cryptoServiceProvider.Dispose();
        return Encoding.UTF8.GetString(bytes);
      default:
        goto case 1;
    }
  }

  private static RSACryptoServiceProvider w()
  {
    short num1 = -5769;
    int num2 = (int) num1;
    num1 = (short) -5769;
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
        string xmlString = global::n.v();
        RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider(2048);
        cryptoServiceProvider.FromXmlString(xmlString);
        return cryptoServiceProvider;
      default:
        goto case 1;
    }
  }

  private static string v()
  {
    short num1 = -19564;
    int num2 = (int) num1;
    num1 = (short) -19564;
    int num3 = (int) num1;
    string str;
    switch (num2 == num3 ? 1 : 0)
    {
      case 0:
      case 2:
        return str;
      default:
        short num4 = 1;
        if (num4 == (short) 0)
          ;
        num4 = (short) 0;
        if (num4 == (short) 0)
          ;
        try
        {
          str = global::n.c(HttpUtility.UrlDecode(Resources.RRPR));
          goto case 0;
        }
        catch (Exception ex)
        {
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
          return (string) null;
        }
    }
  }

  private static RSACryptoServiceProvider u()
  {
    short num1 = 32151;
    int num2 = (int) num1;
    num1 = (short) 32151;
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
        string xmlString = global::n.i();
        RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider(2048);
        cryptoServiceProvider.FromXmlString(xmlString);
        return cryptoServiceProvider;
      default:
        goto case 1;
    }
  }

  private static RSACryptoServiceProvider t()
  {
    short num1 = -5368;
    int num2 = (int) num1;
    num1 = (short) -5368;
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
        string xmlString = global::n.h();
        RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider(2048);
        cryptoServiceProvider.FromXmlString(xmlString);
        return cryptoServiceProvider;
      default:
        goto case 1;
    }
  }

  private static string b(string A_0, string A_1)
  {
    int A_1_1 = 12;
    short num1 = 15830;
    int num2 = (int) num1;
    num1 = (short) 15830;
    int num3 = (int) num1;
    int num4;
    switch (num2 == num3 ? 1 : 0)
    {
      case 0:
      case 2:
label_4:
        global::b b = new global::b();
        string str1 = "";
        try
        {
          string str2;
          string A_0_1;
          string str3;
          short num5;
          switch (0)
          {
            case 0:
label_7:
              global::g.b("Encrypting token with shared key logic.");
              Uri uri = new Uri(A_1);
              str2 = uri.Scheme + "://" + uri.Authority;
              A_0_1 = string.Empty;
              str3 = global::n.ai();
              num5 = (short) 1;
              num4 = (int) (IntPtr) num5;
              goto default;
            default:
              while (true)
              {
                switch (num4)
                {
                  case 0:
                    goto label_17;
                  case 1:
                    if (!string.IsNullOrEmpty(str3))
                    {
                      num5 = (short) 4;
                      num4 = (int) (IntPtr) num5;
                      continue;
                    }
                    goto case 3;
                  case 2:
                    str1 = b.c(A_0_1, A_0, "CbDGjubbjl$!@890231#@FSDs" + DateTime.UtcNow.ToString("yyyyMMdd", (IFormatProvider) CultureInfo.InvariantCulture));
                    str1 = "k=" + HttpUtility.UrlEncode(str1, Encoding.UTF8) + "&l=" + HttpUtility.UrlEncode(A_0_1.Length.ToString(), Encoding.UTF8) + "&tl=" + HttpUtility.UrlEncode(str2);
                    global::g.b("Encrypted token parameters: " + str1);
                    num5 = (short) 0;
                    num4 = (int) (IntPtr) num5;
                    continue;
                  case 3:
                    num5 = (short) 5;
                    num4 = (int) (IntPtr) num5;
                    continue;
                  case 4:
                    A_0_1 = global::n.a(((IEnumerable<string>) str3.Split('.')).Select<string, int>(new Func<string, int>(int.Parse)).ToList<int>().ToArray());
                    num5 = (short) 3;
                    num4 = (int) (IntPtr) num5;
                    continue;
                  case 5:
                    if (string.IsNullOrEmpty(A_0_1))
                    {
                      num5 = (short) 6;
                      num4 = (int) (IntPtr) num5;
                      continue;
                    }
                    goto case 2;
                  case 6:
                    A_0_1 = "Fju07q";
                    num5 = (short) 2;
                    num4 = (int) (IntPtr) num5;
                    continue;
                  default:
                    goto label_7;
                }
              }
          }
        }
        catch (Exception ex)
        {
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
        }
label_17:
        return str1;
      default:
        if (true)
          ;
        if (false)
          ;
        num4 = 0;
        switch (num4)
        {
          default:
            goto label_4;
        }
    }
  }

  private static string g(string A_0 = "")
  {
    int A_1 = 14;
    short num1 = 1764;
    int num2 = (int) num1;
    num1 = (short) 1764;
    int num3 = (int) num1;
    short num4;
    int num5;
    switch (num2 == num3 ? 1 : 0)
    {
      case 0:
      case 2:
label_3:
        global::b b = new global::b();
        string str1 = "";
        try
        {
          string str2;
          switch (0)
          {
            case 0:
label_6:
              num4 = (short) 1;
              if (num4 == (short) 0)
                ;
              global::g.c("Generating token with machine specific information.");
              string empty = string.Empty;
              str2 = global::n.ai();
              num4 = (short) 1;
              num5 = (int) (IntPtr) num4;
              goto default;
            default:
              while (true)
              {
                switch (num5)
                {
                  case 0:
                    str2 = "";
                    num4 = (short) 2;
                    num5 = (int) (IntPtr) num4;
                    continue;
                  case 1:
                    if (string.IsNullOrEmpty(str2))
                    {
                      num4 = (short) 0;
                      num5 = (int) (IntPtr) num4;
                      continue;
                    }
                    goto case 2;
                  case 2:
                    str1 = "embeddedlogin|" + global::n.s() + "|WPE:" + str2 + "|" + Guid.NewGuid().ToString() + "|" + A_0 + "|" + ((long) (DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds).ToString();
                    global::g.b("Plain machine specific token: " + str1);
                    num4 = (short) 3;
                    num5 = (int) (IntPtr) num4;
                    continue;
                  case 3:
                    goto label_13;
                  default:
                    goto label_6;
                }
              }
          }
        }
        catch (Exception ex)
        {
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
        }
label_13:
        return str1;
      default:
        num4 = (short) 0;
        if (num4 == (short) 0)
          ;
        num4 = (short) 0;
        num5 = (int) num4;
        switch (num5)
        {
          default:
            goto label_3;
        }
    }
  }

  public static string s()
  {
    int A_1 = 3;
    short num1 = 10369;
    int num2 = (int) num1;
    num1 = (short) 10369;
    int num3 = (int) num1;
    switch (num2 == num3)
    {
      case true:
        if (false)
          ;
        if (true)
          ;
        return global::n.aj() + "|" + global::n.ak() + "|" + global::n.an() + "##@" + global::n.am() + "|" + global::n.al() + "|" + global::n.ap() + "|" + global::n.ae();
      default:
        goto case 1;
    }
  }

  public static bool a(string A_0_1, string A_1)
  {
    int A_1_1 = 10;
    short num1 = 29276;
    int num2 = (int) num1;
    num1 = (short) 29276;
    int num3 = (int) num1;
    short num4;
    int num5;
    switch (num2 == num3 ? 1 : 0)
    {
      case 0:
      case 2:
label_3:
        bool flag = false;
        try
        {
          string A_2;
          string path;
          switch (0)
          {
            case 0:
label_6:
              global::g.c("Started Protocol_handler...");
              Uri uri = new Uri(A_1);
              A_2 = uri.Scheme + "://" + uri.Authority;
              global::g.c("Protocol_handler: BaseUrl =" + A_2);
              path = Environment.GetEnvironmentVariable("LocalAppData") + "\Google\Chrome\User Data\Local State";
              num4 = (short) 2;
              num5 = (int) (IntPtr) num4;
              goto default;
            default:
              while (true)
              {
                List<string>.Enumerator enumerator;
                switch (num5)
                {
                  case 0:
                    global::g.c("Protocol_handler: LocalStateFile =" + path);
                    JObject jobject = JObject.Parse(System.IO.File.ReadAllText(path));
                    JObject content1 = JObject.Parse("{'protocol_handler': { 'excluded_schemes' : { 'ecw' : false }}}");
                    JObject content2 = JObject.Parse("{'protocol_handler': {'allowed_origin_protocol_pairs' : { '" + A_2 + "' : { 'ecw' : true}}}}");
                    global::g.c("Protocol_handler: new entry =" + content2.ToString());
                    jobject.Merge((object) content1, new JsonMergeSettings()
                    {
                      MergeArrayHandling = MergeArrayHandling.Union
                    });
                    jobject.Merge((object) content2, new JsonMergeSettings()
                    {
                      MergeArrayHandling = MergeArrayHandling.Union
                    });
                    System.IO.File.WriteAllText(A_0_1 + "\Local State", jobject.ToString());
                    num4 = (short) 4;
                    num5 = (int) (IntPtr) num4;
                    continue;
                  case 1:
                    goto label_26;
                  case 2:
                    if (System.IO.File.Exists(path))
                    {
                      num4 = (short) 0;
                      num5 = (int) (IntPtr) num4;
                      continue;
                    }
                    goto case 4;
                  case 3:
                    num4 = (short) 5;
                    num5 = (int) (IntPtr) num4;
                    continue;
                  case 4:
                    num4 = (short) 6;
                    num5 = (int) (IntPtr) num4;
                    continue;
                  case 5:
                    enumerator = ((IEnumerable<string>) Directory.GetFiles(Environment.GetEnvironmentVariable("LocalAppData") + "\Google\Chrome\User Data", "*.*", SearchOption.AllDirectories)).Where<string>((Func<string, bool>) (A_0_2 =>
                    {
                      int A_1_2 = 9;
                      short num6 = 22913;
                      int num7 = (int) num6;
                      num6 = (short) 22913;
                      int num8 = (int) num6;
                      switch (num7 == num8)
                      {
                        case true:
                          if (false)
                            ;
                          if (true)
                            ;
                          return Path.GetFileName(A_0_2).Equals("Preferences");
                        default:
                          goto case 1;
                      }
                    })).Select<string, string>((Func<string, string>) (A_0_3 =>
                    {
                      short num9 = 1;
                      if (num9 == (short) 0)
                        ;
                      num9 = (short) -15434;
                      int num10 = (int) num9;
                      num9 = (short) -15434;
                      int num11 = (int) num9;
                      switch (num10 == num11)
                      {
                        case true:
                          num9 = (short) 0;
                          if (num9 == (short) 0)
                            ;
                          return Path.GetFullPath(A_0_3);
                        default:
                          goto case 1;
                      }
                    })).ToList<string>().GetEnumerator();
                    num4 = (short) 7;
                    num5 = (int) (IntPtr) num4;
                    continue;
                  case 6:
                    if (!global::n.r())
                    {
                      num4 = (short) 3;
                      num5 = (int) (IntPtr) num4;
                      continue;
                    }
                    break;
                  case 7:
                    try
                    {
                      num4 = (short) 0;
                      int num12 = (int) (IntPtr) num4;
                      while (true)
                      {
                        switch (num12)
                        {
                          case 0:
                            switch (0)
                            {
                              case 0:
                                break;
                              default:
                                continue;
                            }
                            break;
                          case 1:
                            num4 = (short) 4;
                            num12 = (int) (IntPtr) num4;
                            continue;
                          case 3:
                            if (enumerator.MoveNext())
                            {
                              global::n.a(enumerator.Current, A_0_1, A_2);
                              num4 = (short) 2;
                              num12 = (int) (IntPtr) num4;
                              continue;
                            }
                            num4 = (short) 1;
                            num12 = (int) (IntPtr) num4;
                            continue;
                          case 4:
                            goto label_24;
                        }
                        num4 = (short) 3;
                        num12 = (int) (IntPtr) num4;
                      }
                    }
                    finally
                    {
                      enumerator.Dispose();
                    }
                  default:
                    goto label_6;
                }
label_24:
                flag = true;
                num4 = (short) 1;
                num5 = (int) (IntPtr) num4;
              }
          }
        }
        catch (Exception ex)
        {
          flag = false;
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
        }
label_26:
        if (false)
          ;
        return flag;
      default:
        if (true)
          ;
        num4 = (short) 0;
        num5 = (int) num4;
        switch (num5)
        {
          default:
            goto label_3;
        }
    }
  }

  private static bool r()
  {
    int A_1 = 6;
    short num1 = 19908;
    int num2 = (int) num1;
    num1 = (short) 19908;
    int num3 = (int) num1;
    short num4;
    int num5;
    switch (num2 == num3 ? 1 : 0)
    {
      case 0:
      case 2:
label_4:
        bool flag = true;
        global::g.c("Started");
        try
        {
          string str1;
          switch (0)
          {
            case 0:
label_7:
              str1 = global::n.ae().Trim();
              global::g.c("Installed chrome:" + str1);
              num4 = (short) 1;
              num5 = (int) (IntPtr) num4;
              goto default;
            default:
              Version version1;
              Version version2;
              while (true)
              {
                switch (num5)
                {
                  case 0:
                    goto label_17;
                  case 1:
                    if (!string.IsNullOrEmpty(str1))
                    {
                      num4 = (short) 4;
                      num5 = (int) (IntPtr) num4;
                      continue;
                    }
                    goto case 5;
                  case 2:
                    flag = false;
                    num4 = (short) 6;
                    num5 = (int) (IntPtr) num4;
                    continue;
                  case 3:
                    if (version1.Major < version2.Major)
                    {
                      num4 = (short) 2;
                      num5 = (int) (IntPtr) num4;
                      continue;
                    }
                    flag = true;
                    num4 = (short) 5;
                    num5 = (int) (IntPtr) num4;
                    continue;
                  case 4:
                    string str2 = "Chrome-";
                    string version3 = str1.Substring(str2.Length);
                    global::g.c("Installed chrome version number:" + str1);
                    version1 = new Version(version3);
                    version2 = new Version("91.0.4472");
                    num4 = (short) 3;
                    num5 = (int) (IntPtr) num4;
                    continue;
                  case 5:
                  case 6:
                    num4 = (short) 0;
                    num5 = (int) (IntPtr) num4;
                    continue;
                  default:
                    goto label_7;
                }
              }
          }
        }
        catch (Exception ex)
        {
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
        }
label_17:
        global::g.c("Result: " + flag.ToString());
        global::g.c("Ended");
        return flag;
      default:
        num4 = (short) 1;
        if (num4 == (short) 0)
          ;
        num4 = (short) 0;
        if (num4 == (short) 0)
          ;
        num4 = (short) 0;
        num5 = (int) num4;
        switch (num5)
        {
          default:
            goto label_4;
        }
    }
  }

  private static void a(string A_0, string A_1, string A_2)
  {
    int A_1_1 = 12;
    try
    {
      short num1;
      int num2;
      switch (true ? 1 : 0)
      {
        case 0:
        case 2:
label_11:
          num1 = (short) 3;
          num2 = (int) (IntPtr) num1;
          break;
        default:
          num1 = (short) 0;
          if (num1 == (short) 0)
            ;
          num1 = (short) 0;
          switch (num1)
          {
            default:
              num1 = (short) 1;
              num2 = (int) (IntPtr) num1;
              break;
          }
          break;
      }
      JObject jobject;
      string str;
      while (true)
      {
        num1 = (short) 1;
        if (num1 == (short) 0)
          ;
        switch (num2)
        {
          case 0:
            goto label_16;
          case 1:
            switch (0)
            {
              case 0:
                goto label_8;
              default:
                continue;
            }
          case 2:
            goto label_10;
          case 3:
            num1 = (short) 0;
            num2 = (int) (IntPtr) num1;
            continue;
          case 4:
            global::g.c("SuppressChromeExternalProtocolPopup: preference file =" + A_0);
            jobject = JObject.Parse(System.IO.File.ReadAllText(A_0));
            JObject content1 = JObject.Parse("{'protocol_handler': { 'excluded_schemes' : { 'ecw' : false }}}");
            JObject content2 = JObject.Parse("{'protocol_handler': {'allowed_origin_protocol_pairs' : { '" + A_2 + "' : { 'ecw' : true}}}}");
            jobject.Merge((object) content1, new JsonMergeSettings()
            {
              MergeArrayHandling = MergeArrayHandling.Union
            });
            jobject.Merge((object) content2, new JsonMergeSettings()
            {
              MergeArrayHandling = MergeArrayHandling.Union
            });
            global::g.c("Protocol_handler: new entry =" + content2.ToString());
            string directoryName = Path.GetDirectoryName(A_0);
            str = directoryName.Substring(directoryName.IndexOf("User Data") + 9);
            num1 = (short) 5;
            num2 = (int) (IntPtr) num1;
            continue;
          case 5:
            if (!Directory.Exists(A_1 + str))
            {
              num1 = (short) 6;
              num2 = (int) (IntPtr) num1;
              continue;
            }
            goto label_10;
          case 6:
            Directory.CreateDirectory(A_1 + str);
            num1 = (short) 2;
            num2 = (int) (IntPtr) num1;
            continue;
          default:
label_8:
            if (System.IO.File.Exists(A_0))
            {
              num1 = (short) 4;
              num2 = (int) (IntPtr) num1;
              continue;
            }
            goto case 3;
        }
      }
label_16:
      return;
label_10:
      JObject content = JObject.Parse("{'profile': { 'password_manager_enabled' : false }}");
      jobject.Merge((object) content, new JsonMergeSettings()
      {
        MergeArrayHandling = MergeArrayHandling.Union
      });
      System.IO.File.WriteAllText(A_1 + str + "\Preferences", jobject.ToString());
      goto label_11;
    }
    catch (Exception ex)
    {
      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
    }
  }

  public static bool q()
  {
    int A_1 = 1;
    short num1 = 1;
    if (num1 == (short) 0)
      ;
    num1 = (short) 5110;
    int num2 = (int) num1;
    num1 = (short) 5110;
    int num3 = (int) num1;
    int num4;
    switch (num2 == num3 ? 1 : 0)
    {
      case 0:
      case 2:
label_4:
        bool flag = false;
        try
        {
          RegistryKey registryKey;
          switch (0)
          {
            case 0:
label_7:
              registryKey = Registry.CurrentUser.OpenSubKey("Software\Policies\Google\Chrome", true);
              num1 = (short) 3;
              num4 = (int) (IntPtr) num1;
              goto default;
            default:
              object obj;
              while (true)
              {
                switch (num4)
                {
                  case 0:
                    goto label_21;
                  case 1:
                  case 7:
                  case 8:
                    flag = true;
                    num1 = (short) 0;
                    num4 = (int) (IntPtr) num1;
                    continue;
                  case 2:
                    if (obj.ToString() != "1")
                    {
                      num1 = (short) 9;
                      num4 = (int) (IntPtr) num1;
                      continue;
                    }
                    goto case 1;
                  case 3:
                    if (registryKey != null)
                    {
                      num1 = (short) 4;
                      num4 = (int) (IntPtr) num1;
                      continue;
                    }
                    registryKey = Registry.CurrentUser.CreateSubKey("Software\Policies\Google\Chrome");
                    registryKey.SetValue("DeveloperToolsDisabled", (object) 1, RegistryValueKind.DWord);
                    registryKey.Close();
                    num1 = (short) 1;
                    num4 = (int) (IntPtr) num1;
                    continue;
                  case 4:
                    obj = registryKey.GetValue("DeveloperToolsDisabled");
                    num1 = (short) 5;
                    num4 = (int) (IntPtr) num1;
                    continue;
                  case 5:
                    if (obj == null)
                    {
                      num1 = (short) 6;
                      num4 = (int) (IntPtr) num1;
                      continue;
                    }
                    num1 = (short) 2;
                    num4 = (int) (IntPtr) num1;
                    continue;
                  case 6:
                    registryKey.SetValue("DeveloperToolsDisabled", (object) 1, RegistryValueKind.DWord);
                    registryKey.Close();
                    num1 = (short) 7;
                    num4 = (int) (IntPtr) num1;
                    continue;
                  case 9:
                    registryKey.SetValue("DeveloperToolsDisabled", (object) 1, RegistryValueKind.DWord);
                    registryKey.Close();
                    num1 = (short) 8;
                    num4 = (int) (IntPtr) num1;
                    continue;
                  default:
                    goto label_7;
                }
              }
          }
        }
        catch (Exception ex)
        {
          flag = false;
        }
label_21:
        return flag;
      default:
        num1 = (short) 0;
        if (num1 == (short) 0)
          ;
        num1 = (short) 0;
        num4 = (int) num1;
        switch (num4)
        {
          default:
            goto label_4;
        }
    }
  }

  public static bool p()
  {
    int A_1 = 10;
    short num1 = -27714;
    int num2 = (int) num1;
    num1 = (short) -27714;
    int num3 = (int) num1;
    short num4;
    int num5;
    switch (num2 == num3 ? 1 : 0)
    {
      case 0:
      case 2:
label_3:
        bool flag1 = false;
        try
        {
          string str;
          switch (0)
          {
            case 0:
label_6:
              str = global::n.d("HardwareAccelerationModeEnabled");
              num4 = (short) 2;
              num5 = (int) (IntPtr) num4;
              goto default;
            default:
              while (true)
              {
                RegistryKey registryKey1;
                object obj1;
                RegistryKey registryKey2;
                object obj2;
                bool flag2;
                int num6;
                switch (num5)
                {
                  case 0:
                    registryKey1.SetValue("HardwareAccelerationModeEnabled", (object) 1, RegistryValueKind.DWord);
                    registryKey1.Close();
                    num4 = (short) 20;
                    num5 = (int) (IntPtr) num4;
                    continue;
                  case 1:
                    registryKey1.SetValue("HardwareAccelerationModeEnabled", (object) 1, RegistryValueKind.DWord);
                    registryKey1.Close();
                    num4 = (short) 19;
                    num5 = (int) (IntPtr) num4;
                    continue;
                  case 2:
                    if (!string.IsNullOrEmpty(str))
                    {
                      num4 = (short) 5;
                      num5 = (int) (IntPtr) num4;
                      continue;
                    }
                    goto case 14;
                  case 3:
                    num6 = 0;
                    break;
                  case 4:
                    if (obj1.ToString() != "1")
                    {
                      num4 = (short) 1;
                      num5 = (int) (IntPtr) num4;
                      continue;
                    }
                    goto case 14;
                  case 5:
                    global::g.a("Setting up Hardware-Acceleration-Mode");
                    num4 = (short) 25;
                    num5 = (int) (IntPtr) num4;
                    continue;
                  case 6:
                    if (registryKey2 != null)
                    {
                      num4 = (short) 23;
                      num5 = (int) (IntPtr) num4;
                      continue;
                    }
                    registryKey2 = Registry.CurrentUser.CreateSubKey("Software\Policies\Google\Chrome");
                    registryKey2.SetValue("HardwareAccelerationModeEnabled", (object) 0, RegistryValueKind.DWord);
                    registryKey2.Close();
                    num4 = (short) 26;
                    num5 = (int) (IntPtr) num4;
                    continue;
                  case 7:
                    registryKey2.SetValue("HardwareAccelerationModeEnabled", (object) 0, RegistryValueKind.DWord);
                    registryKey2.Close();
                    num4 = (short) 14;
                    num5 = (int) (IntPtr) num4;
                    continue;
                  case 8:
                    num4 = (short) 22;
                    num5 = (int) (IntPtr) num4;
                    continue;
                  case 9:
                    if (obj2.ToString() != "0")
                    {
                      num4 = (short) 7;
                      num5 = (int) (IntPtr) num4;
                      continue;
                    }
                    goto case 14;
                  case 10:
                    if (registryKey1 != null)
                    {
                      num4 = (short) 24;
                      num5 = (int) (IntPtr) num4;
                      continue;
                    }
                    registryKey1 = Registry.CurrentUser.CreateSubKey("Software\Policies\Google\Chrome");
                    registryKey1.SetValue("HardwareAccelerationModeEnabled", (object) 1, RegistryValueKind.DWord);
                    registryKey1.Close();
                    num4 = (short) 18;
                    num5 = (int) (IntPtr) num4;
                    continue;
                  case 11:
                    goto label_45;
                  case 12:
                    registryKey2.SetValue("HardwareAccelerationModeEnabled", (object) 0, RegistryValueKind.DWord);
                    registryKey2.Close();
                    num4 = (short) 16;
                    num5 = (int) (IntPtr) num4;
                    continue;
                  case 13:
                    if (obj1 == null)
                    {
                      num4 = (short) 0;
                      num5 = (int) (IntPtr) num4;
                      continue;
                    }
                    num4 = (short) 4;
                    num5 = (int) (IntPtr) num4;
                    continue;
                  case 14:
                  case 16:
                  case 18:
                  case 19:
                  case 20:
                  case 26:
                    global::g.a("Successfully set Hardware-Acceleration-Mode to config value.");
                    flag1 = true;
                    num4 = (short) 11;
                    num5 = (int) (IntPtr) num4;
                    continue;
                  case 15:
                    registryKey1 = Registry.CurrentUser.OpenSubKey("Software\Policies\Google\Chrome", true);
                    num4 = (short) 10;
                    num5 = (int) (IntPtr) num4;
                    continue;
                  case 17:
                    if (flag2)
                    {
                      num4 = (short) 15;
                      num5 = (int) (IntPtr) num4;
                      continue;
                    }
                    registryKey2 = Registry.CurrentUser.OpenSubKey("Software\Policies\Google\Chrome", true);
                    num4 = (short) 6;
                    num5 = (int) (IntPtr) num4;
                    continue;
                  case 21:
                    if (obj2 == null)
                    {
                      num4 = (short) 12;
                      num5 = (int) (IntPtr) num4;
                      continue;
                    }
                    num4 = (short) 9;
                    num5 = (int) (IntPtr) num4;
                    continue;
                  case 22:
                    num6 = 1;
                    break;
                  case 23:
                    obj2 = registryKey2.GetValue("HardwareAccelerationModeEnabled");
                    num4 = (short) 21;
                    num5 = (int) (IntPtr) num4;
                    continue;
                  case 24:
                    obj1 = registryKey1.GetValue("HardwareAccelerationModeEnabled");
                    num4 = (short) 13;
                    num5 = (int) (IntPtr) num4;
                    continue;
                  case 25:
                    if (str.ToLower() == "false")
                    {
                      num4 = (short) 3;
                      num5 = (int) (IntPtr) num4;
                      continue;
                    }
                    num4 = (short) 8;
                    num5 = (int) (IntPtr) num4;
                    continue;
                  default:
                    goto label_6;
                }
                flag2 = num6 != 0;
                global::g.a("Setting Hardware-Acceleration-Mode = " + flag2.ToString());
                num4 = (short) 17;
                num5 = (int) (IntPtr) num4;
              }
          }
        }
        catch (Exception ex)
        {
          global::g.a("Failed to set HardwareAccelerationModeEnabled" + ex.Message);
          flag1 = false;
        }
label_45:
        if (false)
          ;
        return flag1;
      default:
        num4 = (short) 0;
        if (num4 == (short) 0)
          ;
        num4 = (short) 0;
        num5 = (int) num4;
        switch (num5)
        {
          default:
            goto label_3;
        }
    }
  }

  public static bool? o()
  {
    int A_1 = 1;
    short num1 = 1;
    if (num1 == (short) 0)
      ;
    bool? nullable = new bool?(false);
label_2:
    try
    {
      int num2;
      RegistryKey registryKey;
      switch (0)
      {
        case 0:
label_4:
          registryKey = Registry.CurrentUser.OpenSubKey("Software\Policies\Google\Chrome\URLBlacklist", true);
          num1 = (short) 3;
          num2 = (int) (IntPtr) num1;
          goto default;
        default:
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_12;
              case 1:
                registryKey.SetValue("101", (object) "*", RegistryValueKind.String);
                registryKey.Close();
                nullable = new bool?(true);
                num1 = (short) -21401;
                int num3 = (int) num1;
                num1 = (short) -21401;
                int num4 = (int) num1;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_2;
                  default:
                    num1 = (short) 0;
                    if (num1 == (short) 0)
                      ;
                    num1 = (short) 0;
                    num2 = (int) (IntPtr) num1;
                    continue;
                }
              case 2:
                registryKey = Registry.CurrentUser.CreateSubKey("Software\Policies\Google\Chrome\URLBlacklist");
                num1 = (short) 1;
                num2 = (int) (IntPtr) num1;
                continue;
              case 3:
                if (registryKey == null)
                {
                  num1 = (short) 2;
                  num2 = (int) (IntPtr) num1;
                  continue;
                }
                goto case 1;
              default:
                goto label_4;
            }
          }
      }
    }
    catch (Exception ex)
    {
      nullable = new bool?();
      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
    }
label_12:
    return nullable;
  }

  public static bool? n()
  {
    int A_1 = 11;
    int num1 = 0;
    switch (num1)
    {
      default:
        bool? nullable = new bool?(false);
        try
        {
          short num2;
          RegistryKey registryKey1;
          switch (0)
          {
            case 0:
label_4:
              num2 = (short) 1;
              if (num2 == (short) 0)
                ;
              registryKey1 = Registry.CurrentUser.OpenSubKey("Software\Policies\Google\Chrome\URLBlacklist", true);
              num2 = (short) 2;
              num1 = (int) (IntPtr) num2;
              goto default;
            default:
              RegistryKey registryKey2;
              while (true)
              {
                switch (num1)
                {
                  case 0:
                    try
                    {
                      num2 = (short) 3;
                      int num3 = (int) (IntPtr) num2;
                      while (true)
                      {
                        num2 = (short) -29082;
                        int num4 = (int) num2;
                        num2 = (short) -29082;
                        int num5 = (int) num2;
                        switch (num4 == num5 ? 1 : 0)
                        {
                          case 0:
                          case 2:
label_28:
                            num2 = (short) 0;
                            num3 = (int) (IntPtr) num2;
                            continue;
                          default:
                            num2 = (short) 0;
                            if (num2 == (short) 0)
                              ;
                            switch (num3)
                            {
                              case 0:
                                goto label_37;
                              case 1:
                                goto label_28;
                              case 2:
                                registryKey2.DeleteSubKeyTree("URLBlacklist");
                                num2 = (short) 1;
                                num3 = (int) (IntPtr) num2;
                                continue;
                              case 3:
                                switch (0)
                                {
                                  case 0:
                                    break;
                                  default:
                                    continue;
                                }
                                break;
                            }
                            if (registryKey2.OpenSubKey("URLBlacklist") != null)
                            {
                              num2 = (short) 2;
                              num3 = (int) (IntPtr) num2;
                              continue;
                            }
                            goto case 0;
                        }
                      }
                    }
                    finally
                    {
                      int num6 = 2;
                      while (true)
                      {
                        short num7;
                        switch (num6)
                        {
                          case 0:
                            registryKey2.Dispose();
                            num7 = (short) 1;
                            num6 = (int) (IntPtr) num7;
                            continue;
                          case 1:
                            goto label_35;
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
                        if (registryKey2 != null)
                        {
                          num7 = (short) 0;
                          num6 = (int) (IntPtr) num7;
                        }
                        else
                          break;
                      }
label_35:;
                    }
label_37:
                    nullable = new bool?(true);
                    num2 = (short) 1;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 1:
                    goto label_39;
                  case 2:
                    try
                    {
                      num2 = (short) 3;
                      int num8 = (int) (IntPtr) num2;
                      while (true)
                      {
                        switch (num8)
                        {
                          case 0:
                            goto label_36;
                          case 1:
                            num2 = (short) 0;
                            num8 = (int) (IntPtr) num2;
                            continue;
                          case 2:
                            registryKey1.DeleteValue("101");
                            num2 = (short) 1;
                            num8 = (int) (IntPtr) num2;
                            continue;
                          case 3:
                            switch (0)
                            {
                              case 0:
                                goto label_9;
                              default:
                                continue;
                            }
                          default:
label_9:
                            if (registryKey1 != null)
                            {
                              num2 = (short) 2;
                              num8 = (int) (IntPtr) num2;
                              continue;
                            }
                            goto case 1;
                        }
                      }
                    }
                    finally
                    {
                      int num9 = 2;
                      while (true)
                      {
                        switch (num9)
                        {
                          case 0:
                            registryKey1.Dispose();
                            num9 = 1;
                            continue;
                          case 1:
                            goto label_19;
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
                        if (registryKey1 != null)
                          num9 = 0;
                        else
                          break;
                      }
label_19:;
                    }
label_36:
                    registryKey2 = Registry.CurrentUser.OpenSubKey("Software\Policies\Google\Chrome\", true);
                    num2 = (short) 0;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  default:
                    goto label_4;
                }
              }
          }
        }
        catch (Exception ex)
        {
          nullable = new bool?();
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
        }
label_39:
        return nullable;
    }
  }

  public static bool? f(string A_0)
  {
    int A_1 = 12;
    int num1 = 0;
    switch (num1)
    {
      default:
        bool? nullable = new bool?(false);
        try
        {
          short num2;
          string[] strArray1;
          int num3;
          RegistryKey registryKey;
          int index;
          string[] strArray2;
          switch (0)
          {
            case 0:
label_4:
              num2 = (short) -18950;
              int num4 = (int) num2;
              num2 = (short) -18950;
              int num5 = (int) num2;
              switch (num4 == num5 ? 1 : 0)
              {
                case 0:
                case 2:
                  break;
                default:
                  num2 = (short) 0;
                  if (num2 == (short) 0)
                    ;
                  strArray1 = A_0.Split(';');
                  num3 = 101;
                  registryKey = Registry.CurrentUser.OpenSubKey("Software\Policies\Google\Chrome\URLWhitelist", true);
                  num2 = (short) 4;
                  num1 = (int) (IntPtr) num2;
                  goto label_3;
              }
              break;
            default:
label_3:
              while (true)
              {
                switch (num1)
                {
                  case 0:
                    goto label_17;
                  case 1:
                  case 3:
                    num2 = (short) 5;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 2:
                    registryKey.Close();
                    nullable = new bool?(true);
                    num2 = (short) 0;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 4:
                    if (registryKey == null)
                    {
                      num2 = (short) 7;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto label_13;
                  case 5:
                    if (index >= strArray2.Length)
                    {
                      num2 = (short) 2;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    string str = strArray2[index];
                    registryKey.SetValue(num3.ToString(), (object) str, RegistryValueKind.String);
                    ++num3;
                    ++index;
                    num2 = (short) 1;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 6:
                    goto label_13;
                  case 7:
                    registryKey = Registry.CurrentUser.CreateSubKey("Software\Policies\Google\Chrome\URLWhitelist");
                    num2 = (short) 6;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  default:
                    goto label_4;
                }
              }
          }
label_13:
          strArray2 = strArray1;
          index = 0;
          num2 = (short) 3;
          num1 = (int) (IntPtr) num2;
          goto label_3;
        }
        catch (Exception ex)
        {
          nullable = new bool?();
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
        }
label_17:
        if (false)
          ;
        return nullable;
    }
  }

  public static bool? m()
  {
    int A_1 = 2;
    bool? nullable1 = new bool?(false);
label_1:
    bool? nullable2;
    try
    {
      RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\Policies\Google\Chrome\", true);
      short num1;
      try
      {
        num1 = (short) 3;
        int num2 = (int) (IntPtr) num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_16;
            case 1:
              num1 = (short) 0;
              num2 = (int) (IntPtr) num1;
              continue;
            case 2:
              registryKey.DeleteSubKeyTree("URLWhitelist");
              num1 = (short) 1;
              num2 = (int) (IntPtr) num1;
              continue;
            case 3:
              switch (0)
              {
                case 0:
                  goto label_5;
                default:
                  continue;
              }
            default:
label_5:
              if (registryKey.OpenSubKey("URLWhitelist") != null)
              {
                num1 = (short) 2;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              goto case 1;
          }
        }
      }
      finally
      {
        int num3 = 2;
        while (true)
        {
          short num4;
          switch (num3)
          {
            case 0:
              registryKey.Dispose();
              num4 = (short) 1;
              num3 = (int) (IntPtr) num4;
              continue;
            case 1:
              goto label_15;
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
          if (registryKey != null)
          {
            num4 = (short) 0;
            num3 = (int) (IntPtr) num4;
          }
          else
            break;
        }
label_15:;
      }
label_16:
      num1 = (short) -16577;
      int num5 = (int) num1;
      num1 = (short) -16577;
      int num6 = (int) num1;
      switch (num5 == num6 ? 1 : 0)
      {
        case 0:
        case 2:
          goto label_1;
        default:
          num1 = (short) 1;
          if (num1 == (short) 0)
            ;
          num1 = (short) 0;
          if (num1 == (short) 0)
            ;
          nullable2 = new bool?(true);
          break;
      }
    }
    catch (Exception ex)
    {
      nullable2 = new bool?();
      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
    }
    return nullable2;
  }

  public static string e(string A_0)
  {
    int A_1 = 12;
    short num1 = 20258;
    int num2 = (int) num1;
    num1 = (short) 20258;
    int num3 = (int) num1;
    switch (num2 == num3)
    {
      case true:
        if (true)
          ;
        if (false)
          ;
        Uri uri = new Uri(global::n.k(Path.GetFileNameWithoutExtension(A_0)));
        A_0 = uri.Scheme + "://" + uri.Authority + "/mobiledoc/jsp/webemr/login/newLogin.jsp";
        return A_0;
      default:
        goto case 1;
    }
  }

  public static int l()
  {
    int A_1 = 3;
    short num1 = 1;
    if (num1 == (short) 0)
      ;
    int num2 = 0;
    if (ConfigurationManager.AppSettings["ScreenLockTimeout"] != null)
    {
      num1 = (short) 29496;
      int num3 = (int) num1;
      num1 = (short) 29496;
      int num4 = (int) num1;
      switch (num3 == num4 ? 1 : 0)
      {
        case 0:
        case 2:
          break;
        default:
          num1 = (short) 0;
          if (num1 == (short) 0)
            ;
          try
          {
            num2 = Convert.ToInt32(ConfigurationManager.AppSettings["ScreenLockTimeout"]) * 60 * 1000;
            break;
          }
          catch (Exception ex)
          {
            num2 = -1;
            global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
            break;
          }
      }
    }
    return num2;
  }

  public static int k()
  {
    int A_1 = 9;
    int result = 0;
    try
    {
      int num1 = 3;
      while (true)
      {
        short num2 = 31924;
        int num3 = (int) num2;
        num2 = (short) 31924;
        int num4 = (int) num2;
        switch (num3 == num4 ? 1 : 0)
        {
          case 0:
          case 2:
label_10:
            num2 = (short) 0;
            num1 = (int) (IntPtr) num2;
            continue;
          default:
            num2 = (short) 0;
            if (num2 == (short) 0)
              ;
            switch (num1)
            {
              case 0:
                goto label_12;
              case 1:
                goto label_10;
              case 2:
                num2 = (short) 1;
                if (num2 == (short) 0)
                  ;
                int.TryParse(ConfigurationManager.AppSettings["ZoomOutSetting"], out result);
                num2 = (short) 1;
                num1 = (int) (IntPtr) num2;
                continue;
              case 3:
                switch (0)
                {
                  case 0:
                    break;
                  default:
                    continue;
                }
                break;
            }
            if (ConfigurationManager.AppSettings["ZoomOutSetting"] != null)
            {
              num2 = (short) 2;
              num1 = (int) (IntPtr) num2;
              continue;
            }
            goto case 0;
        }
      }
    }
    catch (Exception ex)
    {
      result = -1;
      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
    }
label_12:
    return result;
  }

  public static string d(string A_0)
  {
    short num1 = 1;
    if (num1 == (short) 0)
      ;
    string str = string.Empty;
    try
    {
      num1 = (short) 3;
      int num2 = (int) (IntPtr) num1;
      while (true)
      {
        num1 = (short) -13107;
        int num3 = (int) num1;
        num1 = (short) -13107;
        int num4 = (int) num1;
        switch (num3 == num4 ? 1 : 0)
        {
          case 0:
          case 2:
label_10:
            num1 = (short) 0;
            num2 = (int) (IntPtr) num1;
            continue;
          default:
            num1 = (short) 0;
            if (num1 == (short) 0)
              ;
            switch (num2)
            {
              case 0:
                goto label_12;
              case 1:
                goto label_10;
              case 2:
                str = ConfigurationManager.AppSettings[A_0];
                num1 = (short) 1;
                num2 = (int) (IntPtr) num1;
                continue;
              case 3:
                switch (0)
                {
                  case 0:
                    break;
                  default:
                    continue;
                }
                break;
            }
            if (ConfigurationManager.AppSettings[A_0] != null)
            {
              num1 = (short) 2;
              num2 = (int) (IntPtr) num1;
              continue;
            }
            goto case 0;
        }
      }
    }
    catch (Exception ex)
    {
      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
    }
label_12:
    return str;
  }

  internal static bool b(int A_0)
  {
    int A_1 = 3;
    bool flag = false;
label_1:
    try
    {
      int num1;
      short num2;
      switch (0)
      {
        case 0:
label_3:
          global::g.c("eCW Chrome #PID: " + A_0.ToString());
          num2 = (short) 3;
          num1 = (int) (IntPtr) num2;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
                goto label_10;
              case 1:
                global::g.c("#Result" + flag.ToString());
                num2 = (short) 13786;
                int num3 = (int) num2;
                num2 = (short) 13786;
                int num4 = (int) num2;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_1;
                  default:
                    num2 = (short) 0;
                    if (num2 == (short) 0)
                      ;
                    num2 = (short) 0;
                    num1 = (int) (IntPtr) num2;
                    continue;
                }
              case 2:
                flag = true;
                num2 = (short) 1;
                num1 = (int) (IntPtr) num2;
                continue;
              case 3:
                if (global::n.j() == A_0)
                {
                  num2 = (short) 2;
                  num1 = (int) (IntPtr) num2;
                  continue;
                }
                goto case 1;
              default:
                goto label_3;
            }
          }
label_10:
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
    return flag;
  }

  [DllImport("user32.dll")]
  public static extern IntPtr GetWindowThreadProcessId(IntPtr A_0, out uint A_1);

  [DllImport("user32.dll")]
  private static extern IntPtr GetForegroundWindow();

  public static int j()
  {
    int A_1_1 = 7;
label_1:
    uint A_1_2 = 0;
    short num1;
    int num2;
    try
    {
      num1 = (short) 1;
      if (num1 == (short) 0)
        ;
      global::n.GetWindowThreadProcessId(global::n.GetForegroundWindow(), out A_1_2);
      num2 = Convert.ToInt32(A_1_2);
      global::g.c("Active Window #PID: " + A_1_2.ToString());
    }
    catch (Exception ex)
    {
      num2 = -1;
      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
    }
    num1 = (short) 13378;
    switch ((short) 13378 == num1 ? 1 : 0)
    {
      case 0:
      case 2:
        goto label_1;
      default:
        num1 = (short) 0;
        if (num1 == (short) 0)
          ;
        return num2;
    }
  }

  public static int a(int A_0)
  {
    int A_1 = 17;
    int num1 = 0;
    try
    {
      short num2 = -4372;
      int num3 = (int) num2;
      num2 = (short) -4372;
      int num4 = (int) num2;
      int num5;
      switch (num3 == num4 ? 1 : 0)
      {
        case 0:
        case 2:
label_7:
          num2 = (short) 6;
          num5 = (int) (IntPtr) num2;
          break;
        default:
          num2 = (short) 0;
          if (num2 == (short) 0)
            ;
          num2 = (short) 3;
          num5 = (int) (IntPtr) num2;
          break;
      }
      while (true)
      {
        switch (num5)
        {
          case 0:
            goto label_16;
          case 1:
            num2 = (short) 0;
            num5 = (int) (IntPtr) num2;
            continue;
          case 2:
            if (A_0 > 0)
            {
              num2 = (short) 4;
              num5 = (int) (IntPtr) num2;
              continue;
            }
            goto case 1;
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
            num2 = (short) 5;
            num5 = (int) (IntPtr) num2;
            continue;
          case 5:
            if (num1 != 0)
            {
              num2 = (short) 1;
              num5 = (int) (IntPtr) num2;
              continue;
            }
            goto label_6;
        }
        num2 = (short) 2;
        num5 = (int) (IntPtr) num2;
      }
label_6:
      Thread.Sleep(1000);
      num1 = (int) global::n.a(global::n.a((uint) Process.GetCurrentProcess().Id), true);
      global::g.c("Retry Count: " + A_0.ToString() + " Chrome PID: " + num1.ToString());
      --A_0;
      goto label_7;
    }
    catch (Exception ex)
    {
      num1 = -1;
      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
    }
label_16:
    if (false)
      ;
    return num1;
  }

  private static uint a(uint A_0, bool A_1 = false)
  {
    int A_1_1 = 12;
    int num1 = 0;
    switch (num1)
    {
      default:
        ManagementObjectCollection objectCollection;
        short num2;
        switch (0)
        {
          case 0:
label_3:
            objectCollection = new ManagementObjectSearcher("SELECT * FROM Win32_Process WHERE ParentProcessId=" + A_0.ToString()).Get();
            num2 = (short) 2;
            num1 = (int) (IntPtr) num2;
            goto default;
          default:
            ManagementObjectCollection.ManagementObjectEnumerator enumerator;
            while (true)
            {
              switch (num1)
              {
                case 0:
                  enumerator = objectCollection.GetEnumerator();
                  num2 = (short) 1;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 1:
                  goto label_7;
                case 2:
                  num2 = (short) 1;
                  if (num2 == (short) 0)
                    ;
                  if (objectCollection.Count > 0)
                  {
                    num2 = (short) 0;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto label_38;
                default:
                  goto label_3;
              }
            }
label_7:
            uint id;
            try
            {
              num2 = (short) 2;
              int num3 = (int) (IntPtr) num2;
              while (true)
              {
                uint processId;
                Process processById1;
                Process processById2;
                switch (num3)
                {
                  case 0:
                    if (!enumerator.MoveNext())
                    {
                      num2 = (short) 12;
                      num3 = (int) (IntPtr) num2;
                      continue;
                    }
                    break;
                  case 1:
                    num2 = (short) -8841;
                    int num4 = (int) num2;
                    num2 = (short) -8841;
                    int num5 = (int) num2;
                    switch (num4 == num5 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        break;
                      default:
                        num2 = (short) 0;
                        if (num2 == (short) 0)
                          ;
                        id = (uint) processById2.Id;
                        num2 = (short) 11;
                        num3 = (int) (IntPtr) num2;
                        continue;
                    }
                    break;
                  case 2:
                    switch (0)
                    {
                      case 0:
                        goto label_14;
                      default:
                        continue;
                    }
                  case 3:
                  case 11:
                    goto label_39;
                  case 4:
                    if ((int) processId != Process.GetCurrentProcess().Id)
                    {
                      num2 = (short) 7;
                      num3 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto label_21;
                  case 5:
                    id = (uint) processById1.Id;
                    num2 = (short) 3;
                    num3 = (int) (IntPtr) num2;
                    continue;
                  case 6:
                    if (processById2.ProcessName.Contains("cmd"))
                    {
                      num2 = (short) 1;
                      num3 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto default;
                  case 7:
                    processById2 = Process.GetProcessById((int) processId);
                    num2 = (short) 6;
                    num3 = (int) (IntPtr) num2;
                    continue;
                  case 8:
                    goto label_38;
                  case 9:
                    if (processById1.ProcessName.Contains("chrome"))
                    {
                      num2 = (short) 5;
                      num3 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto default;
                  case 10:
                    if (!A_1)
                    {
                      num2 = (short) 13;
                      num3 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto label_21;
                  case 12:
                    num2 = (short) 8;
                    num3 = (int) (IntPtr) num2;
                    continue;
                  case 13:
                    num2 = (short) 4;
                    num3 = (int) (IntPtr) num2;
                    continue;
                  default:
label_14:
                    num2 = (short) 0;
                    num3 = (int) (IntPtr) num2;
                    continue;
                }
                processId = (uint) enumerator.Current["ProcessId"];
                num2 = (short) 10;
                num3 = (int) (IntPtr) num2;
                continue;
label_21:
                processById1 = Process.GetProcessById((int) processId);
                num2 = (short) 9;
                num3 = (int) (IntPtr) num2;
              }
            }
            finally
            {
              short num6 = 2;
              int num7 = (int) (IntPtr) num6;
              while (true)
              {
                switch (num7)
                {
                  case 0:
                    enumerator.Dispose();
                    num6 = (short) 1;
                    num7 = (int) (IntPtr) num6;
                    continue;
                  case 1:
                    goto label_36;
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
                if (enumerator != null)
                {
                  num6 = (short) 0;
                  num7 = (int) (IntPtr) num6;
                }
                else
                  break;
              }
label_36:;
            }
label_39:
            return id;
label_38:
            return 0;
        }
    }
  }

  public static bool a(string A_0, out CookieContainer A_1)
  {
    int A_1_1 = 15;
    short num1 = 1;
    if (num1 == (short) 0)
      ;
    num1 = (short) 0;
    int num2 = (int) num1;
    switch (num2)
    {
      default:
        global::g.c("PingServer started");
        bool flag = false;
        A_1 = new CookieContainer();
        try
        {
          IDisposable disposable;
          try
          {
            CookieContainer cookieContainer;
            HttpWebRequest httpWebRequest;
            switch (0)
            {
              case 0:
label_5:
                cookieContainer = new CookieContainer();
                ServicePointManager.SecurityProtocol = (SecurityProtocolType) 3072;
                httpWebRequest = (HttpWebRequest) WebRequest.Create(A_0);
                num1 = (short) 9;
                num2 = (int) (IntPtr) num1;
                goto default;
              default:
                HttpWebResponse response;
                IEnumerator enumerator;
                while (true)
                {
                  switch (num2)
                  {
                    case 0:
                      try
                      {
                        num1 = (short) 4;
                        num2 = (int) (IntPtr) num1;
                        while (true)
                        {
                          switch (num2)
                          {
                            case 0:
                              if (!enumerator.MoveNext())
                              {
                                num1 = (short) 1;
                                num2 = (int) (IntPtr) num1;
                                continue;
                              }
                              Cookie current = (Cookie) enumerator.Current;
                              A_1.Add(current);
                              num1 = (short) 3;
                              num2 = (int) (IntPtr) num1;
                              continue;
                            case 1:
                              num1 = (short) 2;
                              num2 = (int) (IntPtr) num1;
                              continue;
                            case 2:
                              goto label_29;
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
                          num1 = (short) 0;
                          num2 = (int) (IntPtr) num1;
                        }
                      }
                      finally
                      {
                        short num3;
                        switch (0)
                        {
                          case 0:
label_24:
                            disposable = enumerator as IDisposable;
                            num3 = (short) 2;
                            num2 = (int) (IntPtr) num3;
                            goto default;
                          default:
                            while (true)
                            {
                              switch (num2)
                              {
                                case 0:
                                  goto label_28;
                                case 1:
                                  disposable.Dispose();
                                  num3 = (short) 0;
                                  num2 = (int) (IntPtr) num3;
                                  continue;
                                case 2:
                                  if (disposable != null)
                                  {
                                    num3 = (short) 1;
                                    num2 = (int) (IntPtr) num3;
                                    continue;
                                  }
                                  goto label_28;
                                default:
                                  goto label_24;
                              }
                            }
label_28:;
                        }
                      }
label_29:
                      flag = true;
                      num1 = (short) 2;
                      num2 = (int) (IntPtr) num1;
                      continue;
                    case 1:
                      num1 = (short) 8;
                      num2 = (int) (IntPtr) num1;
                      continue;
                    case 2:
                      num1 = (short) 7;
                      num2 = (int) (IntPtr) num1;
                      continue;
                    case 3:
                      enumerator = response.Cookies.GetEnumerator();
                      num1 = (short) 0;
                      num2 = (int) (IntPtr) num1;
                      continue;
                    case 4:
label_11:
                      num1 = (short) -29661;
                      int num4 = (int) num1;
                      num1 = (short) -29661;
                      int num5 = (int) num1;
                      switch (num4 == num5 ? 1 : 0)
                      {
                        case 0:
                        case 2:
                          goto label_11;
                        default:
                          num1 = (short) 0;
                          if (num1 == (short) 0)
                            ;
                          httpWebRequest.Proxy = GlobalProxySelection.GetEmptyWebProxy();
                          num1 = (short) 5;
                          num2 = (int) (IntPtr) num1;
                          continue;
                      }
                    case 5:
                      httpWebRequest.Method = "GET";
                      httpWebRequest.Timeout = 5000;
                      httpWebRequest.CookieContainer = cookieContainer;
                      response = (HttpWebResponse) httpWebRequest.GetResponse();
                      num1 = (short) 6;
                      num2 = (int) (IntPtr) num1;
                      continue;
                    case 6:
                      if (response != null)
                      {
                        num1 = (short) 1;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      }
                      goto case 2;
                    case 7:
                      goto label_54;
                    case 8:
                      if (response.StatusCode == HttpStatusCode.OK)
                      {
                        num1 = (short) 3;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      }
                      goto case 2;
                    case 9:
                      if (global::n.c)
                      {
                        num1 = (short) 4;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      }
                      goto case 5;
                    default:
                      goto label_5;
                  }
                }
            }
          }
          catch (Exception ex)
          {
            ServicePointManager.SecurityProtocol = (SecurityProtocolType) 3072;
            global::g.c("1st attempt tp ping server URL failed.  result:" + flag.ToString());
            global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
            WebRequest webRequest = WebRequest.Create(A_0);
            webRequest.Proxy = WebRequest.DefaultWebProxy;
            webRequest.Timeout = 10000;
            HttpWebResponse response = (HttpWebResponse) webRequest.GetResponse();
            if (response != null)
            {
              if (response.StatusCode == HttpStatusCode.OK)
              {
                IEnumerator enumerator = response.Cookies.GetEnumerator();
                try
                {
                  short num6 = 4;
                  num2 = (int) (IntPtr) num6;
                  while (true)
                  {
                    switch (num2)
                    {
                      case 0:
                        if (!enumerator.MoveNext())
                        {
                          num6 = (short) 1;
                          num2 = (int) (IntPtr) num6;
                          continue;
                        }
                        Cookie current = (Cookie) enumerator.Current;
                        A_1.Add(current);
                        num6 = (short) 3;
                        num2 = (int) (IntPtr) num6;
                        continue;
                      case 1:
                        num6 = (short) 2;
                        num2 = (int) (IntPtr) num6;
                        continue;
                      case 2:
                        goto label_53;
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
                    num6 = (short) 0;
                    num2 = (int) (IntPtr) num6;
                  }
                }
                finally
                {
                  short num7;
                  switch (0)
                  {
                    case 0:
label_46:
                      disposable = enumerator as IDisposable;
                      num7 = (short) 2;
                      num2 = (int) (IntPtr) num7;
                      goto default;
                    default:
                      while (true)
                      {
                        switch (num2)
                        {
                          case 0:
                            goto label_50;
                          case 1:
                            disposable.Dispose();
                            num7 = (short) 0;
                            num2 = (int) (IntPtr) num7;
                            continue;
                          case 2:
                            if (disposable != null)
                            {
                              num7 = (short) 1;
                              num2 = (int) (IntPtr) num7;
                              continue;
                            }
                            goto label_50;
                          default:
                            goto label_46;
                        }
                      }
label_50:;
                  }
                }
label_53:
                flag = true;
              }
            }
          }
label_54:
          global::g.c("Ping Server Url result:" + flag.ToString());
          global::g.c("PingServer ended");
        }
        catch (Exception ex)
        {
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
        }
        return flag;
    }
  }

  public static bool a(
    string A_0,
    CookieContainer A_1,
    out string A_2,
    out string A_3,
    out string A_4)
  {
    int A_1_1 = 4;
    short num1 = 1;
    if (num1 == (short) 0)
      ;
    num1 = (short) 0;
    int num2 = (int) num1;
    switch (num2)
    {
      default:
        global::g.b("Hostname verification (clientPing.jsp) started");
        bool flag = false;
        A_3 = string.Empty;
        A_4 = string.Empty;
        A_2 = string.Empty;
        string str1 = string.Empty;
        try
        {
          string str2;
          string str3;
          switch (0)
          {
            case 0:
label_5:
              Uri uri = new Uri(A_0);
              str2 = uri.Scheme + "://" + uri.Authority;
              string str4 = "client|";
              global::g.b("Client is calling (domain): " + str2);
              string A_1_2 = global::n.j(str4 + str2);
              global::g.b("Sending RSA encrypted value to server: " + A_1_2);
              str3 = HttpUtility.UrlDecode(global::n.a(A_0, A_1_2, A_1, true));
              num1 = (short) 17;
              num2 = (int) (IntPtr) num1;
              goto default;
            default:
              while (true)
              {
                string[] strArray1;
                string[] strArray2;
                int num3;
                switch (num2)
                {
                  case 0:
                    strArray2 = global::n.i(strArray1[0]).Split('|');
                    num1 = (short) 1;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 1:
                    if (strArray2.Length == 4)
                    {
                      num1 = (short) 8;
                      num2 = (int) (IntPtr) num1;
                      continue;
                    }
                    goto case 3;
                  case 2:
                    if (strArray1.Length != 0)
                    {
                      num1 = (short) 0;
                      num2 = (int) (IntPtr) num1;
                      continue;
                    }
                    goto case 3;
                  case 3:
                  case 6:
                  case 7:
                    num1 = (short) 15;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 4:
                    try
                    {
                      A_3 = HttpUtility.UrlDecode(global::a.a(strArray1[1], "secPWTL*TPl!@Ta$US" + DateTime.UtcNow.ToString("yyyyMMdd", (IFormatProvider) CultureInfo.InvariantCulture)));
                    }
                    catch (Exception ex)
                    {
                      global::g.b("Client host-name Whitelisting extraction failed. Client:" + str2 + " Server:" + str1);
                    }
                    global::g.b("Whitelist URLs:" + A_3);
                    global::g.b("Client host-name verification passed. Client:" + str2 + " Server:" + str1);
                    num2 = 7;
                    continue;
                  case 5:
label_17:
                    num3 = 1;
                    goto label_29;
                  case 8:
                    num1 = (short) 12;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 9:
                    num1 = (short) 10;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 10:
                    if (!str3.ToLower().Contains("<html"))
                    {
                      num1 = (short) 16;
                      num2 = (int) (IntPtr) num1;
                      continue;
                    }
                    break;
                  case 11:
                    num1 = (short) 32655;
                    int num4 = (int) num1;
                    num1 = (short) 32655;
                    int num5 = (int) num1;
                    switch (num4 == num5 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        goto label_17;
                      default:
                        num1 = (short) 0;
                        if (num1 == (short) 0)
                          ;
                        if (!flag)
                        {
                          global::g.b("Client host-name validation failed. Client:" + str2 + " Server:" + str1);
                          num1 = (short) 6;
                          num2 = (int) (IntPtr) num1;
                          continue;
                        }
                        num1 = (short) 4;
                        num2 = (int) (IntPtr) num1;
                        continue;
                    }
                  case 12:
                    if (!(strArray2[0].Trim().ToLower() == "true"))
                    {
                      num1 = (short) 14;
                      num2 = (int) (IntPtr) num1;
                      continue;
                    }
                    num1 = (short) 5;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 13:
                    num3 = 0;
                    goto label_29;
                  case 14:
                    num1 = (short) 13;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 15:
                    goto label_36;
                  case 16:
                    strArray1 = str3.Split('|');
                    num1 = (short) 2;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 17:
                    if (!str3.ToLower().Contains("sorry session is not valid"))
                    {
                      num1 = (short) 9;
                      num2 = (int) (IntPtr) num1;
                      continue;
                    }
                    break;
                  default:
                    goto label_5;
                }
                flag = false;
                A_4 = "server_patch_not_available";
                num1 = (short) 3;
                num2 = (int) (IntPtr) num1;
                continue;
label_29:
                flag = num3 != 0;
                str1 = strArray2[1].Trim();
                A_2 = strArray2[2].Trim();
                global::g.b("Server token: " + A_2);
                num1 = (short) 11;
                num2 = (int) (IntPtr) num1;
              }
          }
        }
        catch (Exception ex)
        {
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
        }
label_36:
        global::g.b("Hostname verification (mode=client) ended");
        return flag;
    }
  }

  public static string c(string A_0)
  {
    int A_1 = 19;
    int num1 = 0;
    switch (num1)
    {
      default:
        if (false)
          ;
        string str1 = string.Empty;
        try
        {
          SecureString password;
          string str2;
          int index;
          short num2;
          switch (0)
          {
            case 0:
label_5:
              string str3 = "secPWTL*TPl!@Ta$USXPymIUc690p0MHu1";
              password = new SecureString();
              str2 = str3;
              index = 0;
              num2 = (short) 4;
              num1 = (int) (IntPtr) num2;
              goto default;
            default:
              while (true)
              {
                switch (num1)
                {
                  case 0:
                  case 4:
                    num2 = (short) 1;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 1:
                    if (index < str2.Length)
                    {
                      char c = str2[index];
                      password.AppendChar(c);
                      ++index;
                      num2 = (short) -18967;
                      int num3 = (int) num2;
                      num2 = (short) -18967;
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
                          num2 = (short) 0;
                          num1 = (int) (IntPtr) num2;
                          continue;
                      }
                    }
                    else
                    {
                      num2 = (short) 3;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                  case 2:
                    goto label_14;
                  case 3:
                    str1 = global::a.a(A_0, new NetworkCredential(string.Empty, password).Password);
                    num2 = (short) 2;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  default:
                    goto label_5;
                }
              }
          }
        }
        catch (Exception ex)
        {
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
        }
label_14:
        return str1;
    }
  }

  public static string i()
  {
    string str1 = "";
    string str2;
    try
    {
      str1 = global::n.c(HttpUtility.UrlDecode(Resources.RPU));
    }
    catch (Exception ex)
    {
      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
      str2 = (string) null;
      goto label_4;
    }
label_1:
    return str1;
label_4:
    short num1 = 20267;
    int num2 = (int) num1;
    num1 = (short) 20267;
    int num3 = (int) num1;
    switch (num2 == num3 ? 1 : 0)
    {
      case 0:
      case 2:
        goto label_1;
      default:
        if (false)
          ;
        if (true)
          ;
        return str2;
    }
  }

  public static string h()
  {
    string str1 = "";
    string str2;
    try
    {
      str1 = global::n.c(HttpUtility.UrlDecode(Resources.RPR));
    }
    catch (Exception ex)
    {
      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
      str2 = (string) null;
      goto label_5;
    }
label_1:
    short num = 1;
    if (num == (short) 0)
      ;
    return str1;
label_5:
    num = (short) 32624;
    switch ((short) 32624 == num ? 1 : 0)
    {
      case 0:
      case 2:
        goto label_1;
      default:
        num = (short) 0;
        if (num == (short) 0)
          ;
        return str2;
    }
  }

  private static bool a(object A_0_1, X509Certificate A_1, X509Chain A_2, SslPolicyErrors A_3)
  {
    int A_1_1 = 9;
    short num1 = 1;
    if (num1 == (short) 0)
      ;
    num1 = (short) 0;
    switch (num1)
    {
      default:
        bool flag = false;
        try
        {
          num1 = (short) 17;
          int num2 = (int) (IntPtr) num1;
          while (true)
          {
            CultureInfo culture;
            Regex regex;
            Dictionary<string, string> dictionary1;
            Dictionary<string, string> dictionary2;
            switch (num2)
            {
              case 0:
                num1 = (short) 12;
                num2 = (int) (IntPtr) num1;
                continue;
              case 1:
                global::g.b("Certificate issued to: " + A_1.Subject);
                num1 = (short) 8;
                num2 = (int) (IntPtr) num1;
                continue;
              case 2:
                if (!A_1.Subject.ToLower().Contains("incapsula"))
                {
                  num1 = (short) 0;
                  num2 = (int) (IntPtr) num1;
                  continue;
                }
                goto case 14;
              case 3:
                global::g.b("Checking for SAN");
                flag = global::n.a(A_1);
                num1 = (short) 11;
                num2 = (int) (IntPtr) num1;
                continue;
              case 4:
              case 6:
              case 11:
                num1 = (short) 15;
                num2 = (int) (IntPtr) num1;
                continue;
              case 5:
                try
                {
                  num1 = (short) 4;
                  int num3 = (int) (IntPtr) num1;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 0:
                        num1 = (short) 1;
                        num3 = (int) (IntPtr) num1;
                        continue;
                      case 1:
                        num1 = (short) -11867;
                        int num4 = (int) num1;
                        num1 = (short) -11867;
                        int num5 = (int) num1;
                        switch (num4 == num5 ? 1 : 0)
                        {
                          case 0:
                          case 2:
                            break;
                          default:
                            num1 = (short) 0;
                            if (num1 == (short) 0)
                              ;
                            if (!dictionary1["O"].ToString().StartsWith("symantec", true, culture))
                            {
                              flag = false;
                              num1 = (short) 6;
                              num3 = (int) (IntPtr) num1;
                              continue;
                            }
                            num1 = (short) 3;
                            num3 = (int) (IntPtr) num1;
                            continue;
                        }
                        break;
                      case 2:
                        goto label_32;
                      case 3:
                        flag = true;
                        break;
                      case 4:
                        switch (0)
                        {
                          case 0:
                            goto label_20;
                          default:
                            continue;
                        }
                      case 5:
                      case 6:
                        num1 = (short) 2;
                        num3 = (int) (IntPtr) num1;
                        continue;
                      default:
label_20:
                        if (!dictionary1["O"].ToString().StartsWith("DigiCert", true, culture))
                        {
                          num1 = (short) 0;
                          num3 = (int) (IntPtr) num1;
                          continue;
                        }
                        goto case 3;
                    }
                    num1 = (short) 5;
                    num3 = (int) (IntPtr) num1;
                  }
                }
                catch (Exception ex)
                {
                  flag = false;
                  global::g.b("Dictionary key='O' ," + ex.Message);
                }
label_32:
                num2 = 13;
                continue;
              case 7:
                dictionary1 = ((IEnumerable<string>) A_1.Issuer.Split(',')).Select<string, string[]>((Func<string, string[]>) (A_0_2 =>
                {
                  short num6 = 18013;
                  int num7 = (int) num6;
                  num6 = (short) 18013;
                  int num8 = (int) num6;
                  switch (num7 == num8)
                  {
                    case true:
                      short num9 = 0;
                      if (num9 == (short) 0)
                        ;
                      num9 = (short) 1;
                      if (num9 == (short) 0)
                        ;
                      return A_0_2.Trim().Split('=');
                    default:
                      goto case 1;
                  }
                })).ToDictionary<string[], string, string>((Func<string[], string>) (A_0_3 =>
                {
                  short num10 = -2481;
                  int num11 = (int) num10;
                  num10 = (short) -2481;
                  int num12 = (int) num10;
                  switch (num11 == num12)
                  {
                    case true:
                      short num13 = 1;
                      if (num13 == (short) 0)
                        ;
                      num13 = (short) 0;
                      if (num13 == (short) 0)
                        ;
                      return A_0_3[0];
                    default:
                      goto case 1;
                  }
                }), (Func<string[], string>) (A_0_4 =>
                {
                  short num14 = 15924;
                  int num15 = (int) num14;
                  num14 = (short) 15924;
                  int num16 = (int) num14;
                  switch (num15 == num16)
                  {
                    case true:
                      short num17 = 1;
                      if (num17 == (short) 0)
                        ;
                      num17 = (short) 0;
                      if (num17 == (short) 0)
                        ;
                      return A_0_4[1];
                    default:
                      goto case 1;
                  }
                }));
                num1 = (short) 5;
                num2 = (int) (IntPtr) num1;
                continue;
              case 8:
                dictionary2 = ((IEnumerable<string>) regex.Split(A_1.Subject)).Select<string, string[]>((Func<string, string[]>) (A_0_5 =>
                {
                  short num18 = 4109;
                  int num19 = (int) num18;
                  num18 = (short) 4109;
                  int num20 = (int) num18;
                  switch (num19 == num20)
                  {
                    case true:
                      short num21 = 1;
                      if (num21 == (short) 0)
                        ;
                      num21 = (short) 0;
                      if (num21 == (short) 0)
                        ;
                      return A_0_5.Trim().Split('=');
                    default:
                      goto case 1;
                  }
                })).ToDictionary<string[], string, string>((Func<string[], string>) (A_0_6 =>
                {
                  short num22 = -8598;
                  int num23 = (int) num22;
                  num22 = (short) -8598;
                  int num24 = (int) num22;
                  switch (num23 == num24)
                  {
                    case true:
                      short num25 = 1;
                      if (num25 == (short) 0)
                        ;
                      num25 = (short) 0;
                      if (num25 == (short) 0)
                        ;
                      return A_0_6[0];
                    default:
                      goto case 1;
                  }
                }), (Func<string[], string>) (A_0_7 =>
                {
                  short num26 = -28790;
                  int num27 = (int) num26;
                  num26 = (short) -28790;
                  int num28 = (int) num26;
                  switch (num27 == num28)
                  {
                    case true:
                      short num29 = 1;
                      if (num29 == (short) 0)
                        ;
                      num29 = (short) 0;
                      if (num29 == (short) 0)
                        ;
                      return A_0_7[1];
                    default:
                      goto case 1;
                  }
                }));
                num1 = (short) 10;
                num2 = (int) (IntPtr) num1;
                continue;
              case 9:
                global::g.b("Certificate OK - No default errors.");
                global::g.b("Checking for eCW specific validations: ");
                global::g.b("Certificate issuer: " + A_1.Subject);
                num1 = (short) 2;
                num2 = (int) (IntPtr) num1;
                continue;
              case 10:
                try
                {
                  string empty;
                  switch (0)
                  {
                    case 0:
label_39:
                      empty = string.Empty;
                      num1 = (short) 8;
                      num2 = (int) (IntPtr) num1;
                      goto default;
                    default:
                      while (true)
                      {
                        string str;
                        switch (num2)
                        {
                          case 0:
                            num1 = (short) 4;
                            num2 = (int) (IntPtr) num1;
                            continue;
                          case 1:
                          case 3:
                            num1 = (short) 5;
                            num2 = (int) (IntPtr) num1;
                            continue;
                          case 2:
                            num1 = (short) 10;
                            num2 = (int) (IntPtr) num1;
                            continue;
                          case 4:
                            if (!empty.Contains(".eclinicalworks.com"))
                            {
                              num1 = (short) 17;
                              num2 = (int) (IntPtr) num1;
                              continue;
                            }
                            goto case 15;
                          case 5:
                            goto label_69;
                          case 6:
                            if (!empty.Contains(".eclinicalweb.com"))
                            {
                              num1 = (short) 2;
                              num2 = (int) (IntPtr) num1;
                              continue;
                            }
                            goto case 15;
                          case 7:
                            num1 = (short) 13;
                            num2 = (int) (IntPtr) num1;
                            continue;
                          case 8:
                            if (!dictionary2.TryGetValue("O", out str))
                            {
                              num1 = (short) 12;
                              num2 = (int) (IntPtr) num1;
                              continue;
                            }
                            goto case 7;
                          case 9:
                            if (empty.Contains(".ecwcloud.in"))
                            {
                              num1 = (short) 15;
                              num2 = (int) (IntPtr) num1;
                              continue;
                            }
                            break;
                          case 10:
                            if (!empty.Contains(".ecwcloud.com"))
                            {
                              num1 = (short) 0;
                              num2 = (int) (IntPtr) num1;
                              continue;
                            }
                            goto case 15;
                          case 11:
                            num1 = (short) 14;
                            num2 = (int) (IntPtr) num1;
                            continue;
                          case 12:
                            global::g.b("Dictionary key='O' not found in the certificate");
                            num1 = (short) 7;
                            num2 = (int) (IntPtr) num1;
                            continue;
                          case 13:
                            if (!dictionary2.TryGetValue("CN", out empty))
                            {
                              num1 = (short) 20;
                              num2 = (int) (IntPtr) num1;
                              continue;
                            }
                            goto case 16;
                          case 14:
                            if (!empty.ToLower().Contains(".ecwlab.com"))
                            {
                              num1 = (short) 18;
                              num2 = (int) (IntPtr) num1;
                              continue;
                            }
                            goto case 15;
                          case 15:
                            flag = true;
                            num1 = (short) 3;
                            num2 = (int) (IntPtr) num1;
                            continue;
                          case 16:
                            num1 = (short) 19;
                            num2 = (int) (IntPtr) num1;
                            continue;
                          case 17:
                            num1 = (short) 9;
                            num2 = (int) (IntPtr) num1;
                            continue;
                          case 18:
                            num1 = (short) 6;
                            num2 = (int) (IntPtr) num1;
                            continue;
                          case 19:
                            if (str.Contains("eClinicalWorks"))
                            {
                              num1 = (short) 11;
                              num2 = (int) (IntPtr) num1;
                              continue;
                            }
                            break;
                          case 20:
                            global::g.b("Dictionary key='CN' not found in the certificate");
                            num1 = (short) 16;
                            num2 = (int) (IntPtr) num1;
                            continue;
                          default:
                            goto label_39;
                        }
                        flag = false;
                        num1 = (short) 1;
                        num2 = (int) (IntPtr) num1;
                      }
                  }
                }
                catch (Exception ex)
                {
                  flag = false;
                  global::g.b(ex.Message);
                  break;
                }
              case 12:
                if (A_1.Subject.ToLower().Contains("imperva"))
                {
                  num1 = (short) 14;
                  num2 = (int) (IntPtr) num1;
                  continue;
                }
                culture = new CultureInfo("en-US");
                regex = new Regex(",(?=(?:[^"]*"[^"]*")*(?![^"]*"))");
                global::g.b("Certificate issuer: " + A_1.Issuer);
                num1 = (short) 7;
                num2 = (int) (IntPtr) num1;
                continue;
              case 13:
                if (flag)
                {
                  num1 = (short) 1;
                  num2 = (int) (IntPtr) num1;
                  continue;
                }
                break;
              case 14:
                global::g.b("This is incapsula issued certificate, Checking SAN information");
                flag = global::n.a(A_1);
                num1 = (short) 6;
                num2 = (int) (IntPtr) num1;
                continue;
              case 15:
                goto label_76;
              case 16:
                if (flag)
                {
                  num1 = (short) 3;
                  num2 = (int) (IntPtr) num1;
                  continue;
                }
                goto case 4;
              case 17:
                switch (0)
                {
                  case 0:
                    goto label_6;
                  default:
                    continue;
                }
              default:
label_6:
                if (A_3 == SslPolicyErrors.None)
                {
                  num1 = (short) 9;
                  num2 = (int) (IntPtr) num1;
                  continue;
                }
                global::g.a("Certificate ERROR, SslPolicyErrors: " + A_3.ToString());
                flag = false;
                num1 = (short) 4;
                num2 = (int) (IntPtr) num1;
                continue;
            }
label_69:
            num2 = 16;
          }
        }
        catch (Exception ex)
        {
          flag = false;
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
        }
label_76:
        return flag;
    }
  }

  private static bool a(X509Certificate A_0)
  {
    int A_1 = 13;
    int num1 = 0;
    switch (num1)
    {
      default:
        bool flag = false;
        try
        {
          List<string> source;
          X509Certificate2 x509Certificate2;
          X509Extension extension;
          short num2;
          switch (0)
          {
            case 0:
label_4:
              global::g.b("CheckForSubjectAlternativeName: 1");
              source = new List<string>((IEnumerable<string>) new string[5]
              {
                ".ecwlab.com",
                ".eclinicalweb.com",
                ".ecwcloud.com",
                ".eclinicalworks.com",
                ".ecwcloud.in"
              });
              global::g.b("CheckForSubjectAlternativeName: 2");
              x509Certificate2 = new X509Certificate2(A_0);
              global::g.b("CheckForSubjectAlternativeName: 3");
              extension = x509Certificate2.Extensions["2.5.29.17"];
              global::g.b("CheckForSubjectAlternativeName: 4");
              num2 = (short) 4;
              num1 = (int) (IntPtr) num2;
              goto default;
            default:
              while (true)
              {
                string[] strArray1;
                int index;
                // ISSUE: variable of a compiler-generated type
                global::n.d d;
                string[] strArray2;
                string str1;
                string str2;
                switch (num1)
                {
                  case 0:
                    num2 = (short) -28171;
                    int num3 = (int) num2;
                    num2 = (short) -28171;
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
                        global::g.b("SAN value: " + d.a);
                        // ISSUE: reference to a compiler-generated method
                        str2 = source.FirstOrDefault<string>(new Func<string, bool>(d.b));
                        num2 = (short) 2;
                        num1 = (int) (IntPtr) num2;
                        continue;
                    }
                    break;
                  case 1:
                    goto label_24;
                  case 2:
                    if (!string.IsNullOrEmpty(str2))
                    {
                      num2 = (short) 11;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto label_9;
                  case 3:
                  case 12:
                    num2 = (short) 9;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 4:
                    if (extension == null)
                      goto case 5;
                    else
                      break;
                  case 5:
                  case 8:
                    global::g.b("CheckForSubjectAlternativeName count: " + x509Certificate2.Extensions.Count.ToString());
                    num2 = (short) 1;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 6:
                    global::g.b("CheckForSubjectAlternativeName: 5");
                    strArray1 = extension.Format(true).Split(new string[1]
                    {
                      Environment.NewLine
                    }, StringSplitOptions.RemoveEmptyEntries);
                    index = 0;
                    num2 = (short) 12;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 7:
                    // ISSUE: reference to a compiler-generated field
                    if (d.a != null)
                    {
                      num2 = (short) 0;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto label_9;
                  case 9:
                    if (index < strArray1.Length)
                    {
                      string str3 = strArray1[index];
                      // ISSUE: object of a compiler-generated type is created
                      d = new global::n.d();
                      global::g.b("SAN found.");
                      strArray2 = str3.Split('=');
                      str1 = strArray2[0];
                      num2 = (short) 10;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    num2 = (short) 8;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 10:
                    // ISSUE: reference to a compiler-generated field
                    d.a = strArray2.Length != 0 ? strArray2[1] : (string) null;
                    global::g.b("SAN name: " + str1);
                    num2 = (short) 7;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 11:
                    global::g.b("SAN found.");
                    flag = true;
                    num2 = (short) 5;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  default:
                    goto label_4;
                }
                num2 = (short) 6;
                num1 = (int) (IntPtr) num2;
                continue;
label_9:
                ++index;
                num2 = (short) 3;
                num1 = (int) (IntPtr) num2;
              }
          }
        }
        catch (Exception ex)
        {
          flag = false;
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
        }
label_24:
        if (false)
          ;
        return flag;
    }
  }

  public static CookieContainer a(CookieContainer A_0)
  {
label_0:
    MemoryStream serializationStream = new MemoryStream();
    CookieContainer cookieContainer;
    try
    {
      BinaryFormatter binaryFormatter = new BinaryFormatter();
      binaryFormatter.Serialize((Stream) serializationStream, (object) A_0);
      serializationStream.Seek(0L, SeekOrigin.Begin);
      cookieContainer = (CookieContainer) binaryFormatter.Deserialize((Stream) serializationStream);
    }
    finally
    {
      short num1 = 0;
      int num2 = (int) (IntPtr) num1;
      while (true)
      {
        switch (num2)
        {
          case 0:
            switch (0)
            {
              case 0:
                break;
              default:
                continue;
            }
            break;
          case 1:
            goto label_8;
          case 2:
            serializationStream.Dispose();
            num1 = (short) 1;
            num2 = (int) (IntPtr) num1;
            continue;
        }
        if (serializationStream != null)
        {
          num1 = (short) 2;
          num2 = (int) (IntPtr) num1;
        }
        else
          break;
      }
label_8:;
    }
    short num3 = 30944;
    int num4 = (int) num3;
    num3 = (short) 30944;
    int num5 = (int) num3;
    switch (num4 == num5 ? 1 : 0)
    {
      case 0:
      case 2:
        goto label_0;
      default:
        num3 = (short) 1;
        if (num3 == (short) 0)
          ;
        num3 = (short) 0;
        if (num3 == (short) 0)
          ;
        return cookieContainer;
    }
  }

  public static string g()
  {
    int A_1 = 8;
    string path = string.Empty;
    try
    {
      int num1;
      short num2;
      switch (0)
      {
        case 0:
label_3:
          path = global::n.f();
          num2 = (short) 2;
          num1 = (int) (IntPtr) num2;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
                if (!System.IO.File.Exists(path))
                {
                  num2 = (short) -12080;
                  int num3 = (int) num2;
                  num2 = (short) -12080;
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
                      num2 = (short) 4;
                      num1 = (int) (IntPtr) num2;
                      continue;
                  }
                }
                else
                  goto case 3;
                break;
              case 1:
                goto label_18;
              case 2:
                if (string.IsNullOrEmpty(path))
                {
                  num2 = (short) 5;
                  num1 = (int) (IntPtr) num2;
                  continue;
                }
                goto case 3;
              case 3:
                num2 = (short) 1;
                num1 = (int) (IntPtr) num2;
                continue;
              case 4:
                global::g.a(new global::e("Chrome.exe is not found in default location, Please check chrome path."));
                path = string.Empty;
                break;
              case 5:
                path = "C:\Program Files\Google\Chrome\Application\chrome.exe";
                num2 = (short) 7;
                num1 = (int) (IntPtr) num2;
                continue;
              case 6:
                path = global::n.aa() + "\Google\Chrome\Application\chrome.exe";
                num2 = (short) 0;
                num1 = (int) (IntPtr) num2;
                continue;
              case 7:
                if (!System.IO.File.Exists(path))
                {
                  num2 = (short) 6;
                  num1 = (int) (IntPtr) num2;
                  continue;
                }
                goto case 3;
              default:
                goto label_3;
            }
            num2 = (short) 3;
            num1 = (int) (IntPtr) num2;
          }
      }
    }
    catch (Exception ex)
    {
      path = string.Empty;
      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
    }
label_18:
    if (false)
      ;
    return path;
  }

  public static string f()
  {
    int A_1_1 = 2;
label_1:
    short num1 = 0;
    int num2 = (int) num1;
    switch (num2)
    {
      default:
        num1 = (short) 22261;
        int num3 = (int) num1;
        num1 = (short) 22261;
        int num4 = (int) num1;
        switch (num3 == num4 ? 1 : 0)
        {
          case 0:
          case 2:
            goto label_1;
          default:
            num1 = (short) 0;
            if (num1 == (short) 0)
              ;
            string str1 = string.Empty;
            try
            {
              XmlDocument xmlDocument;
              switch (0)
              {
                case 0:
label_7:
                  xmlDocument = new XmlDocument();
                  List<string> stringList = new List<string>();
                  num1 = (short) 3;
                  num2 = (int) (IntPtr) num1;
                  goto default;
                default:
                  while (true)
                  {
                    XDocument xdocument;
                    IEnumerable<XElement> source;
                    string str2;
                    IEnumerable<XElement> xelements;
                    switch (num2)
                    {
                      case 0:
                        if (source != null)
                        {
                          num1 = (short) 1;
                          num2 = (int) (IntPtr) num1;
                          continue;
                        }
                        num1 = (short) 6;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      case 1:
                        str2 = source.FirstOrDefault<XElement>((Func<XElement, bool>) (A_0 =>
                        {
                          int A_1_2 = 5;
                          short num5 = -1359;
                          int num6 = (int) num5;
                          num5 = (short) -1359;
                          int num7 = (int) num5;
                          switch (num6 == num7)
                          {
                            case true:
                              if (false)
                                ;
                              if (true)
                                ;
                              return A_0.Element((XName) "DisplayName").Value == "ChromePath";
                            default:
                              goto case 1;
                          }
                        })).Element((XName) "Message").Value;
                        break;
                      case 2:
                        num1 = (short) 1;
                        if (num1 == (short) 0)
                          ;
                        num1 = (short) 5;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      case 3:
                        if (System.IO.File.Exists(global::n.a + "\PluginSettings.xml"))
                        {
                          num1 = (short) 8;
                          num2 = (int) (IntPtr) num1;
                          continue;
                        }
                        goto case 11;
                      case 4:
                        xelements = xdocument.Elements((XName) "Products").Descendants<XElement>((XName) "Product");
                        goto label_23;
                      case 5:
                        xelements = (IEnumerable<XElement>) null;
                        goto label_23;
                      case 6:
                        num1 = (short) 10;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      case 7:
                        goto label_28;
                      case 8:
                        xmlDocument.Load(global::n.a + "\PluginSettings.xml");
                        XDocument.Parse(xmlDocument.InnerXml);
                        xdocument = XDocument.Parse(xmlDocument.InnerXml);
                        num1 = (short) 9;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      case 9:
                        if (xdocument == null)
                        {
                          num1 = (short) 2;
                          num2 = (int) (IntPtr) num1;
                          continue;
                        }
                        num1 = (short) 4;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      case 10:
                        str2 = (string) null;
                        break;
                      case 11:
                        num1 = (short) 7;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      default:
                        goto label_7;
                    }
                    str1 = str2;
                    num1 = (short) 11;
                    num2 = (int) (IntPtr) num1;
                    continue;
label_23:
                    source = xelements;
                    num1 = (short) 0;
                    num2 = (int) (IntPtr) num1;
                  }
              }
            }
            catch (Exception ex)
            {
              global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
            }
label_28:
            return str1;
        }
    }
  }

  public static string e()
  {
    int A_1 = 5;
    short num1 = 3537;
    int num2 = (int) num1;
    num1 = (short) 3537;
    int num3 = (int) num1;
    string str;
    switch (num2 == num3 ? 1 : 0)
    {
      case 0:
      case 2:
        return str;
      default:
        if (true)
          ;
        if (false)
          ;
        global::g.a("Started");
        str = string.Empty;
        try
        {
          RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey("Ecw\shell\open\command");
          registryKey.GetValue("Default");
          str = registryKey.GetValue("").ToString().Replace("%1", " ").Trim();
          global::g.a("Return value " + str + " ");
          global::g.a("Completed GetPluginPath...");
          goto case 0;
        }
        catch (Exception ex)
        {
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
          goto case 0;
        }
        finally
        {
          global::g.a("Completed");
        }
    }
  }

  public static bool b(string A_0)
  {
    int A_1 = 9;
    int num1 = 0;
    switch (num1)
    {
      default:
        bool flag;
        switch (true ? 1 : 0)
        {
          case 0:
          case 2:
label_15:
            return flag;
          default:
            if (true)
              ;
            global::g.a("Started");
            try
            {
              string str;
              short num2;
              switch (0)
              {
                case 0:
label_7:
                  str = Path.Combine(global::n.a, "PluginSettings.xml");
                  num2 = (short) 2;
                  num1 = (int) (IntPtr) num2;
                  goto default;
                default:
                  while (true)
                  {
                    switch (num1)
                    {
                      case 0:
                        XmlDocument xmlDocument = new XmlDocument();
                        xmlDocument.Load(str);
                        flag = xmlDocument.InnerXml.Contains(A_0);
                        num2 = (short) 3;
                        num1 = (int) (IntPtr) num2;
                        continue;
                      case 1:
                        goto label_4;
                      case 2:
                        if (System.IO.File.Exists(str))
                        {
                          num2 = (short) 0;
                          num1 = (int) (IntPtr) num2;
                          continue;
                        }
                        num2 = (short) 1;
                        num1 = (int) (IntPtr) num2;
                        continue;
                      case 3:
                        goto label_15;
                      default:
                        goto label_7;
                    }
                  }
              }
            }
            catch (Exception ex)
            {
              global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
            }
            finally
            {
              if (false)
                ;
              global::g.a("Completed");
            }
label_4:
            return false;
        }
    }
  }

  public static bool d()
  {
    int A_1 = 3;
    short num1 = 1;
    if (num1 == (short) 0)
      ;
    num1 = (short) 0;
    int num2 = (int) num1;
    switch (num2)
    {
      default:
        global::g.a("Started");
        bool flag = false;
        try
        {
          string str;
          switch (0)
          {
            case 0:
label_5:
              str = Path.Combine(global::n.a, "PluginSettings.xml");
              num1 = (short) 4;
              num2 = (int) (IntPtr) num1;
              goto default;
            default:
              XmlDocument xmlDocument;
              IEnumerator enumerator;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                  case 2:
label_37:
                    num1 = (short) 1;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 1:
                    goto label_40;
                  case 3:
                    if (xmlDocument.InnerXml.Contains("EdgeBrowserMode"))
                    {
                      num1 = (short) 7;
                      num2 = (int) (IntPtr) num1;
                      continue;
                    }
                    flag = true;
                    num1 = (short) -22618;
                    int num3 = (int) num1;
                    num1 = (short) -22618;
                    int num4 = (int) num1;
                    switch (num3 == num4 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        goto label_10;
                      default:
                        num1 = (short) 0;
                        if (num1 == (short) 0)
                          ;
                        num1 = (short) 0;
                        num2 = (int) (IntPtr) num1;
                        continue;
                    }
                  case 4:
                    if (System.IO.File.Exists(str))
                    {
                      num1 = (short) 6;
                      num2 = (int) (IntPtr) num1;
                      continue;
                    }
                    flag = true;
                    num1 = (short) 2;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 5:
                    try
                    {
                      num1 = (short) 4;
                      num2 = (int) (IntPtr) num1;
                      while (true)
                      {
                        XmlNode current;
                        switch (num2)
                        {
                          case 0:
                            goto label_37;
                          case 1:
                          case 3:
                            num1 = (short) 0;
                            num2 = (int) (IntPtr) num1;
                            continue;
                          case 2:
                            if (enumerator.MoveNext())
                            {
                              current = (XmlNode) enumerator.Current;
                              num1 = (short) 7;
                              num2 = (int) (IntPtr) num1;
                              continue;
                            }
                            num1 = (short) 1;
                            num2 = (int) (IntPtr) num1;
                            continue;
                          case 4:
                            switch (0)
                            {
                              case 0:
                                break;
                              default:
                                continue;
                            }
                            break;
                          case 5:
                            flag = true;
                            num1 = (short) 3;
                            num2 = (int) (IntPtr) num1;
                            continue;
                          case 6:
                            num1 = (short) 8;
                            num2 = (int) (IntPtr) num1;
                            continue;
                          case 7:
                            if (current.SelectSingleNode("DisplayName").InnerText.Equals("EdgeBrowserMode", StringComparison.OrdinalIgnoreCase))
                            {
                              num1 = (short) 6;
                              num2 = (int) (IntPtr) num1;
                              continue;
                            }
                            break;
                          case 8:
                            if (!string.IsNullOrWhiteSpace(current.SelectSingleNode("Message").InnerText))
                            {
                              num1 = (short) 5;
                              num2 = (int) (IntPtr) num1;
                              continue;
                            }
                            break;
                        }
                        num1 = (short) 2;
                        num2 = (int) (IntPtr) num1;
                      }
                    }
                    finally
                    {
                      IDisposable disposable;
                      short num5;
                      switch (0)
                      {
                        case 0:
label_32:
                          disposable = enumerator as IDisposable;
                          num5 = (short) 1;
                          num2 = (int) (IntPtr) num5;
                          goto default;
                        default:
                          while (true)
                          {
                            switch (num2)
                            {
                              case 0:
                                disposable.Dispose();
                                num5 = (short) 2;
                                num2 = (int) (IntPtr) num5;
                                continue;
                              case 1:
                                if (disposable != null)
                                {
                                  num5 = (short) 0;
                                  num2 = (int) (IntPtr) num5;
                                  continue;
                                }
                                goto label_36;
                              case 2:
                                goto label_36;
                              default:
                                goto label_32;
                            }
                          }
label_36:;
                      }
                    }
                  case 6:
label_10:
                    xmlDocument = new XmlDocument();
                    xmlDocument.Load(str);
                    num1 = (short) 3;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 7:
                    XmlNodeList xmlNodeList = xmlDocument.SelectNodes("//Products/Product");
                    XDocument.Parse(xmlDocument.InnerXml);
                    enumerator = xmlNodeList.GetEnumerator();
                    num1 = (short) 5;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  default:
                    goto label_5;
                }
              }
          }
        }
        catch (Exception ex)
        {
          global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
        }
        finally
        {
          global::g.a(string.Format("Return:{0}", (object) flag));
          global::g.a("Completed");
        }
label_40:
        return flag;
    }
  }

  public static bool c()
  {
    int A_1 = 12;
    global::g.a("Started");
    string str = ConfigurationManager.AppSettings.Get("FixedWebViewDownloadUrl");
    if (!string.IsNullOrWhiteSpace(str))
    {
      switch (true ? 1 : 0)
      {
        case 0:
        case 2:
          break;
        default:
          if (false)
            ;
          if (true)
            ;
          return global::c.b(new Uri(str.Trim()), global::n.b);
      }
    }
    return false;
  }

  public static bool b()
  {
    int A_1 = 12;
label_1:
    short num1 = 0;
    int num2 = (int) num1;
    switch (num2)
    {
      default:
        num1 = (short) -26310;
        int num3 = (int) num1;
        num1 = (short) -26310;
        int num4 = (int) num1;
        switch (num3 == num4 ? 1 : 0)
        {
          case 0:
          case 2:
            goto label_1;
          default:
            num1 = (short) 1;
            if (num1 == (short) 0)
              ;
            num1 = (short) 0;
            if (num1 == (short) 0)
              ;
            global::g.a("Started");
            bool flag = false;
            try
            {
              string path;
              switch (0)
              {
                case 0:
label_8:
                  path = Path.Combine(global::n.b, "WebViewRunTime");
                  num1 = (short) 2;
                  num2 = (int) (IntPtr) num1;
                  goto default;
                default:
                  while (true)
                  {
                    switch (num2)
                    {
                      case 0:
                        Directory.CreateDirectory(path);
                        num1 = (short) 3;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      case 1:
                        goto label_15;
                      case 2:
                        if (!Directory.Exists(path))
                        {
                          num1 = (short) 0;
                          num2 = (int) (IntPtr) num1;
                          continue;
                        }
                        goto case 3;
                      case 3:
                        ((ArchiveInfo) new CabInfo(Path.Combine(global::n.b, "WebViewRunTime.cab"))).Unpack(path);
                        flag = true;
                        num1 = (short) 1;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      default:
                        goto label_8;
                    }
                  }
              }
            }
            catch (Exception ex)
            {
              global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
            }
            finally
            {
              global::g.a("Completed");
            }
label_15:
            return flag;
        }
    }
  }

  public static bool a(string A_0)
  {
label_0:
    switch (0)
    {
      default:
        switch (true ? 1 : 0)
        {
          case 0:
          case 2:
            goto label_0;
          default:
            if (false)
              ;
            if (true)
              ;
            bool flag = false;
            DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Path.GetTempPath(), A_0));
            try
            {
              int num1 = 3;
              while (true)
              {
                int num2;
                switch (num1)
                {
                  case 0:
                    num2 = 0;
                    break;
                  case 1:
                    goto label_14;
                  case 2:
                    num1 = 0;
                    continue;
                  case 3:
                    switch (0)
                    {
                      case 0:
                        goto label_8;
                      default:
                        continue;
                    }
                  case 4:
                    num2 = 1;
                    break;
                  default:
label_8:
                    num1 = directoryInfo.CreationTime < DateTime.Now.AddHours(-8.0) ? 4 : 2;
                    continue;
                }
                flag = num2 != 0;
                num1 = 1;
              }
            }
            catch (IOException ex)
            {
              global::g.a(ex.Message);
            }
label_14:
            return flag;
        }
    }
  }

  public static bool a()
  {
    int A_1 = 11;
    int num1 = 0;
    switch (num1)
    {
      default:
        if (false)
          ;
        bool flag = false;
        try
        {
          Process[] processesByName;
          int index;
          short num2;
          switch (0)
          {
            case 0:
label_5:
              processesByName = Process.GetProcessesByName("WinProjectE");
              index = 0;
              num2 = (short) 4;
              num1 = (int) (IntPtr) num2;
              goto default;
            default:
              while (true)
              {
                Process process;
                switch (num1)
                {
                  case 0:
                    try
                    {
                      num2 = (short) 2;
                      int num3 = (int) (IntPtr) num2;
                      while (true)
                      {
                        switch (num3)
                        {
                          case 0:
                            num2 = (short) 3;
                            num3 = (int) (IntPtr) num2;
                            continue;
                          case 1:
                            goto label_22;
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
                            goto label_20;
                        }
                        if (process.MainWindowHandle == IntPtr.Zero)
                        {
                          num2 = (short) 0;
                          num3 = (int) (IntPtr) num2;
                        }
                        else
                        {
                          flag = true;
                          num2 = (short) 1;
                          num3 = (int) (IntPtr) num2;
                        }
                      }
                    }
                    catch (Exception ex)
                    {
                      global::g.a(new global::e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
                    }
label_20:
                    ++index;
                    break;
                  case 1:
label_22:
                    num2 = (short) 2;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 2:
                    goto label_24;
                  case 3:
                    if (index >= processesByName.Length)
                    {
                      num2 = (short) 1;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    num2 = (short) -20604;
                    int num4 = (int) num2;
                    num2 = (short) -20604;
                    int num5 = (int) num2;
                    switch (num4 == num5 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        break;
                      default:
                        num2 = (short) 0;
                        if (num2 == (short) 0)
                          ;
                        process = processesByName[index];
                        num2 = (short) 0;
                        num1 = (int) (IntPtr) num2;
                        continue;
                    }
                    break;
                  case 4:
                  case 5:
                    num2 = (short) 3;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  default:
                    goto label_5;
                }
                num2 = (short) 5;
                num1 = (int) (IntPtr) num2;
              }
          }
        }
        catch (IOException ex)
        {
          global::g.a(ex.Message);
        }
label_24:
        return flag;
    }
  }

  static n()
  {
    int A_1 = 17;
    short num1 = 29699;
    int num2 = (int) num1;
    num1 = (short) 29699;
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
        global::n.a = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\eClinicalWorks\plugin\";
        global::n.b = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "eClinicalWorks\plugin\") ?? "";
        global::n.c = true;
        break;
      default:
        goto case 1;
    }
  }

  public enum a
  {
    a,
    b,
  }
}

