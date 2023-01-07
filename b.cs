// Decompiled with JetBrains decompiler
// Type: b
// Assembly: eCWUrlLaunch, Version=4.0.1745.0, Culture=neutral, PublicKeyToken=null
// MVID: CB040BB1-DE0F-4FAE-AA16-19ACB0F0655F
// Assembly location: C:\ProgramData\eClinicalWorks\plugin\eCWUrlLaunch.exe

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;

public class b
{
  private static byte[] a;
  private static int b;
  private static string c;
  private static byte[] d;

  public byte[] e(byte[] A_0)
  {
    MemoryStream memoryStream = new MemoryStream();
label_1:
    short num1;
    byte[] array;
    try
    {
      GZipStream gzipStream = new GZipStream((Stream) memoryStream, CompressionMode.Compress);
      try
      {
        gzipStream.Write(A_0, 0, A_0.Length);
      }
      finally
      {
        short num2 = 2;
        int num3 = (int) (IntPtr) num2;
        while (true)
        {
          switch (num3)
          {
            case 0:
              gzipStream.Dispose();
              num2 = (short) 1;
              num3 = (int) (IntPtr) num2;
              continue;
            case 1:
              goto label_9;
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
          if (gzipStream != null)
          {
            num2 = (short) 0;
            num3 = (int) (IntPtr) num2;
          }
          else
            break;
        }
label_9:;
      }
      switch (true ? 1 : 0)
      {
        case 0:
        case 2:
          goto label_1;
        default:
          num1 = (short) 0;
          if (num1 == (short) 0)
            ;
          array = memoryStream.ToArray();
          break;
      }
    }
    finally
    {
      int num4 = 2;
      while (true)
      {
        switch (num4)
        {
          case 0:
            memoryStream.Dispose();
            num4 = 1;
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
        if (memoryStream != null)
          num4 = 0;
        else
          break;
      }
label_19:;
    }
    num1 = (short) 1;
    if (num1 == (short) 0)
      ;
    return array;
  }

  public byte[] d(byte[] A_0)
  {
label_0:
    short num1 = 0;
    int num2 = (int) num1;
    switch (num2)
    {
      default:
        GZipStream gzipStream = new GZipStream((Stream) new MemoryStream(A_0), CompressionMode.Decompress);
        byte[] array;
        try
        {
          byte[] buffer = new byte[4096];
          MemoryStream memoryStream = new MemoryStream();
          try
          {
            int count;
            switch (0)
            {
              case 0:
label_5:
                count = 0;
                num1 = (short) 5;
                num2 = (int) (IntPtr) num1;
                goto default;
              default:
                while (true)
                {
                  switch (num2)
                  {
                    case 0:
                      memoryStream.Write(buffer, 0, count);
                      num1 = (short) 2;
                      num2 = (int) (IntPtr) num1;
                      continue;
                    case 1:
                      if (count > 0)
                      {
                        num1 = (short) 0;
                        num2 = (int) (IntPtr) num1;
                        continue;
                      }
                      goto case 2;
                    case 2:
                      num1 = (short) 6;
                      num2 = (int) (IntPtr) num1;
                      continue;
                    case 3:
                      array = memoryStream.ToArray();
                      num1 = (short) 4;
                      num2 = (int) (IntPtr) num1;
                      continue;
                    case 4:
                      goto label_28;
                    case 5:
                      count = gzipStream.Read(buffer, 0, 4096);
                      num1 = (short) 1;
                      num2 = (int) (IntPtr) num1;
                      continue;
                    case 6:
                      if (count <= 0)
                      {
                        num1 = (short) 3;
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
          finally
          {
            int num3 = 1;
            while (true)
            {
              switch (num3)
              {
                case 0:
                  goto label_20;
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
                  memoryStream.Dispose();
                  num3 = 0;
                  continue;
              }
              if (memoryStream != null)
                num3 = 2;
              else
                break;
            }
label_20:;
          }
        }
        finally
        {
          short num4 = 1;
          int num5 = (int) (IntPtr) num4;
          while (true)
          {
            switch (num5)
            {
              case 0:
                goto label_27;
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
                gzipStream.Dispose();
                num4 = (short) 0;
                num5 = (int) (IntPtr) num4;
                continue;
            }
            if (gzipStream != null)
            {
              num4 = (short) 2;
              num5 = (int) (IntPtr) num4;
            }
            else
              break;
          }
label_27:;
        }
label_28:
        num1 = (short) 17717;
        int num6 = (int) num1;
        num1 = (short) 17717;
        int num7 = (int) num1;
        switch (num6 == num7 ? 1 : 0)
        {
          case 0:
          case 2:
            goto label_0;
          default:
            num1 = (short) 1;
            if (num1 == (short) 0)
              ;
            num1 = (short) 0;
            if (num1 == (short) 0)
              ;
            return array;
        }
    }
  }

  public string c(string A_0, string A_1)
  {
    short num1 = 31304;
    int num2 = (int) num1;
    num1 = (short) 31304;
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
        return this.c("", A_0, A_1, global::b.a, global::b.d, global::b.b);
      default:
        goto case 1;
    }
  }

  public string c(string A_0, string A_1, string A_2)
  {
    short num1 = 18148;
    int num2 = (int) num1;
    num1 = (short) 18148;
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
        return this.c(A_0, A_1, A_2, global::b.a, global::b.d, global::b.b);
      default:
        goto case 1;
    }
  }

  public string c(string A_0, string A_1, string A_2, byte[] A_3, byte[] A_4, int A_5)
  {
    short num1 = -5703;
    int num2 = (int) num1;
    num1 = (short) -5703;
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
        return this.a(A_0, Encoding.UTF8.GetBytes(A_1), A_2, A_3, A_4, A_5);
      default:
        goto case 1;
    }
  }

  public string c(byte[] A_0)
  {
    short num1 = -10847;
    int num2 = (int) num1;
    num1 = (short) -10847;
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
        return this.a("", A_0, global::b.c, global::b.a, global::b.d, global::b.b);
      default:
        goto case 1;
    }
  }

  public string a(string A_0, byte[] A_1)
  {
    short num1 = 11984;
    int num2 = (int) num1;
    num1 = (short) 11984;
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
        return this.a(A_0, A_1, global::b.c, global::b.a, global::b.d, global::b.b);
      default:
        goto case 1;
    }
  }

  public string a(string A_0, byte[] A_1, string A_2, byte[] A_3, byte[] A_4, int A_5)
  {
    int A_1_1 = 12;
    int num1;
    short num2;
    byte[] numArray;
    string str;
    switch (0)
    {
      case 0:
label_2:
        num2 = (short) 1;
        if (num2 == (short) 0)
          ;
        numArray = this.a(A_1, A_2);
        str = "";
        num2 = (short) 8;
        num1 = (int) (IntPtr) num2;
        goto default;
      default:
        while (true)
        {
          switch (num1)
          {
            case 0:
              str = A_0 + Convert.ToBase64String(numArray);
              num2 = (short) 32010;
              int num3 = (int) num2;
              num2 = (short) 32010;
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
                  num2 = (short) 1;
                  num1 = (int) (IntPtr) num2;
                  continue;
              }
            case 1:
              goto label_19;
            case 2:
label_6:
              numArray = this.e(numArray);
              num2 = (short) 0;
              num1 = (int) (IntPtr) num2;
              continue;
            case 3:
              num2 = (short) 9;
              num1 = (int) (IntPtr) num2;
              continue;
            case 4:
              if (A_0.EndsWith("C"))
              {
                num2 = (short) 2;
                num1 = (int) (IntPtr) num2;
                continue;
              }
              goto case 0;
            case 5:
              if (A_0.Length != 0)
              {
                num2 = (short) 6;
                num1 = (int) (IntPtr) num2;
                continue;
              }
              goto case 0;
            case 6:
              num2 = (short) 4;
              num1 = (int) (IntPtr) num2;
              continue;
            case 7:
              num2 = (short) 5;
              num1 = (int) (IntPtr) num2;
              continue;
            case 8:
              if (numArray != null)
              {
                num2 = (short) 3;
                num1 = (int) (IntPtr) num2;
                continue;
              }
              goto label_19;
            case 9:
              if (A_0 != null)
              {
                num2 = (short) 7;
                num1 = (int) (IntPtr) num2;
                continue;
              }
              goto case 0;
            default:
              goto label_2;
          }
        }
label_19:
        return str;
    }
  }

  public byte[] a(byte[] A_0, string A_1)
  {
    short num1 = -15763;
    int num2 = (int) num1;
    num1 = (short) -15763;
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
        return this.b(A_0, A_1, global::b.a, global::b.d, global::b.b);
      default:
        goto case 1;
    }
  }

  public byte[] b(byte[] A_0, string A_1, byte[] A_2, byte[] A_3, int A_4)
  {
    short num1 = 14364;
    int num2 = (int) num1;
    num1 = (short) 14364;
    int num3 = (int) num1;
    byte[] numArray;
    switch (num2 == num3 ? 1 : 0)
    {
      case 0:
      case 2:
        return numArray;
      default:
        short num4 = 1;
        if (num4 == (short) 0)
          ;
        num4 = (short) 0;
        if (num4 == (short) 0)
          ;
        numArray = (byte[]) null;
        try
        {
          numArray = this.a(new Rfc2898DeriveBytes(A_1, A_2, A_4).GetBytes(16)).CreateEncryptor().TransformFinalBlock(A_0, 0, A_0.Length);
          goto case 0;
        }
        catch (Exception ex)
        {
          goto case 0;
        }
    }
  }

  public string b(string A_0, string A_1)
  {
    short num1 = -3604;
    int num2 = (int) num1;
    num1 = (short) -3604;
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
        return this.b("", A_0, A_1, global::b.a, global::b.d, global::b.b);
      default:
        goto case 1;
    }
  }

  public string b(string A_0, string A_1, string A_2)
  {
    short num1 = 175;
    int num2 = (int) num1;
    num1 = (short) 175;
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
        return this.b(A_0, A_1, A_2, global::b.a, global::b.d, global::b.b);
      default:
        goto case 1;
    }
  }

  public string b(string A_0, string A_1, string A_2, byte[] A_3, byte[] A_4, int A_5)
  {
    short num1 = 1;
    if (num1 == (short) 0)
      ;
    byte[] bytes = this.a(A_0, A_1, A_2, A_3, A_4, A_5);
    if (bytes == null)
      goto label_3;
label_2:
    return Encoding.UTF8.GetString(bytes);
label_3:
    num1 = (short) -3280;
    int num2 = (int) num1;
    num1 = (short) -3280;
    int num3 = (int) num1;
    switch (num2 == num3 ? 1 : 0)
    {
      case 0:
      case 2:
        goto label_2;
      default:
        num1 = (short) 0;
        if (num1 == (short) 0)
          ;
        return (string) null;
    }
  }

  [ExcludeFromCodeCoverage]
  public byte[] a(string A_0)
  {
    short num1 = -6618;
    int num2 = (int) num1;
    num1 = (short) -6618;
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
        return this.b(Convert.FromBase64String(A_0));
      default:
        goto case 1;
    }
  }

  public byte[] a(string A_0, string A_1, string A_2, byte[] A_3, byte[] A_4, int A_5)
  {
    int A_1_1 = 7;
    int num1 = 0;
    switch (num1)
    {
      default:
        string s;
        short num2;
        switch (0)
        {
          case 0:
label_3:
            s = A_1;
            num2 = (short) 12;
            num1 = (int) (IntPtr) num2;
            goto default;
          default:
            byte[] A_0_1;
            while (true)
            {
              int num3;
              switch (num1)
              {
                case 0:
                  if (num3 < A_1.Length)
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
                  A_1 = A_1.Substring(A_0.Length);
                  num2 = (short) 1;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 3:
                  if (!A_1.StartsWith(A_0))
                    goto label_27;
                  else
                    goto label_13;
                case 4:
                  num2 = (short) 13;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 5:
                  num2 = (short) 0;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 6:
                  A_0_1 = this.d(A_0_1);
                  num2 = (short) -30570;
                  int num4 = (int) num2;
                  num2 = (short) -30570;
                  int num5 = (int) num2;
                  switch (num4 == num5 ? 1 : 0)
                  {
                    case 0:
                    case 2:
                      goto label_13;
                    default:
                      num2 = (short) 0;
                      if (num2 == (short) 0)
                        ;
                      num2 = (short) 11;
                      num1 = (int) (IntPtr) num2;
                      continue;
                  }
                case 7:
                  if (A_0.EndsWith("C"))
                  {
                    num2 = (short) 6;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto label_14;
                case 8:
                  num3 = A_1.IndexOf(A_0);
                  num2 = (short) 9;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 9:
                  if (num3 >= 0)
                  {
                    num2 = (short) 5;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  break;
                case 10:
                  num2 = (short) 3;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 11:
                  goto label_14;
                case 12:
                  if (A_0 != null)
                  {
                    num2 = (short) 4;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto label_27;
                case 13:
                  if (A_0.Length >= 0)
                  {
                    num2 = (short) 10;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto label_27;
                default:
                  goto label_3;
              }
              A_0_1 = Convert.FromBase64String(A_1);
              num2 = (short) 7;
              num1 = (int) (IntPtr) num2;
              continue;
label_13:
              num2 = (short) 8;
              num1 = (int) (IntPtr) num2;
            }
label_14:
            return this.a(A_0_1, A_2, A_3, A_4, A_5);
label_27:
            return Encoding.UTF8.GetBytes(s);
        }
    }
  }

  [ExcludeFromCodeCoverage]
  public byte[] a(string A_0, string A_1, string A_2)
  {
    int A_1_1 = 11;
    int num1 = 0;
    switch (num1)
    {
      default:
        string s;
        short num2;
        switch (0)
        {
          case 0:
label_3:
            s = A_1;
            num2 = (short) 12;
            num1 = (int) (IntPtr) num2;
            goto default;
          default:
            byte[] A_0_1;
            while (true)
            {
              int num3;
              switch (num1)
              {
                case 0:
                  if (num3 < A_1.Length)
                  {
                    num2 = (short) 2;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto case 1;
                case 1:
                  A_0_1 = Convert.FromBase64String(A_1);
                  num2 = (short) 7;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 2:
                  A_1 = A_1.Substring(A_0.Length);
                  num2 = (short) 1;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 3:
                  if (!A_1.StartsWith(A_0))
                    goto label_26;
                  else
                    break;
                case 4:
                  num2 = (short) 13;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 5:
                  num2 = (short) 0;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 6:
                  A_0_1 = this.d(A_0_1);
                  num2 = (short) 16786;
                  int num4 = (int) num2;
                  num2 = (short) 16786;
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
                      num2 = (short) 11;
                      num1 = (int) (IntPtr) num2;
                      continue;
                  }
                  break;
                case 7:
                  if (A_0.EndsWith("C"))
                  {
                    num2 = (short) 6;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto label_13;
                case 8:
                  num3 = A_1.IndexOf(A_0);
                  num2 = (short) 9;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 9:
                  if (num3 >= 0)
                  {
                    num2 = (short) 5;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto case 1;
                case 10:
                  num2 = (short) 3;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 11:
                  goto label_13;
                case 12:
                  if (A_0 != null)
                  {
                    num2 = (short) 4;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto label_26;
                case 13:
                  if (A_0.Length != 0)
                  {
                    num2 = (short) 10;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto label_26;
                default:
                  goto label_3;
              }
              num2 = (short) 8;
              num1 = (int) (IntPtr) num2;
            }
label_13:
            return this.a(A_0_1, A_2, global::b.a, global::b.d, global::b.b);
label_26:
            num2 = (short) 1;
            if (num2 == (short) 0)
              ;
            return Encoding.UTF8.GetBytes(s);
        }
    }
  }

  public byte[] b(byte[] A_0)
  {
    short num1 = 85;
    int num2 = (int) num1;
    num1 = (short) 85;
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
        return this.a(A_0, global::b.c, global::b.a, global::b.d, global::b.b);
      default:
        goto case 1;
    }
  }

  public byte[] a(byte[] A_0, string A_1, byte[] A_2, byte[] A_3, int A_4)
  {
    short num1 = 6987;
    int num2 = (int) num1;
    num1 = (short) 6987;
    int num3 = (int) num1;
    byte[] numArray;
    switch (num2 == num3 ? 1 : 0)
    {
      case 0:
      case 2:
        return numArray;
      default:
        short num4 = 0;
        if (num4 == (short) 0)
          ;
        num4 = (short) 1;
        if (num4 == (short) 0)
          ;
        numArray = (byte[]) null;
        try
        {
          numArray = this.a(new Rfc2898DeriveBytes(A_1, A_2, A_4).GetBytes(16)).CreateDecryptor().TransformFinalBlock(A_0, 0, A_0.Length);
          goto case 0;
        }
        catch (Exception ex)
        {
          goto case 0;
        }
    }
  }

  [ExcludeFromCodeCoverage]
  public string a(string A_0, string A_1)
  {
    int A_1_1 = 10;
    byte[] numArray;
    string str1;
    try
    {
      FileStream fileStream = new FileStream(A_0, FileMode.Open, FileAccess.Read);
      numArray = new byte[fileStream.Length];
      long num = (long) fileStream.Read(numArray, 0, (int) fileStream.Length);
      fileStream.Close();
      goto label_6;
    }
    catch (Exception ex)
    {
      Console.WriteLine("{0}", (object) ex.Message);
      str1 = "";
      goto label_7;
    }
label_5:
    Console.WriteLine("Encrypted file " + A_0 + " to " + A_1);
    string str2;
    return str2;
label_6:
    str2 = this.c(numArray);
    try
    {
      StreamWriter streamWriter = new StreamWriter(A_1, false, Encoding.ASCII);
      streamWriter.Write(str2);
      streamWriter.Close();
      goto label_5;
    }
    catch (Exception ex)
    {
      Console.WriteLine("{0}", (object) ex.Message);
      goto label_5;
    }
label_7:
    switch (true ? 1 : 0)
    {
      case 0:
      case 2:
        goto label_5;
      default:
        if (false)
          ;
        if (true)
          ;
        return str1;
    }
  }

  [ExcludeFromCodeCoverage]
  public void a()
  {
    int A_1_1 = 17;
    int num1 = 0;
    switch (num1)
    {
      default:
        short num2 = 1;
        if (num2 == (short) 0)
          ;
        string A_1_2;
        string strB;
        switch (0)
        {
          case 0:
label_4:
            A_1_2 = "This is some protected data in a C# app.";
            string A_1_3 = this.c("aInFxC", A_1_2, global::b.c);
            Console.WriteLine("plainData:");
            Console.WriteLine(A_1_2);
            Console.WriteLine("
encData:");
            Console.WriteLine(A_1_3);
            strB = this.b("aInFxC", A_1_3, global::b.c);
            Console.WriteLine("
Decrypting result back to rePlainData");
            Console.WriteLine(strB);
            break;
          default:
label_3:
            while (true)
            {
              switch (num1)
              {
                case 0:
                  goto label_13;
                case 1:
                  num2 = (short) 0;
                  num1 = (int) (IntPtr) num2;
                  continue;
                case 2:
                  if (A_1_2.CompareTo(strB) != 0)
                  {
                    num2 = (short) 1;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  num2 = (short) -11357;
                  int num3 = (int) num2;
                  num2 = (short) -11357;
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
                      num2 = (short) 3;
                      num1 = (int) (IntPtr) num2;
                      continue;
                  }
                case 3:
                  goto label_11;
                default:
                  goto label_4;
              }
            }
label_11:
            string str1 = "was SUCCESSFUL";
            goto label_14;
label_13:
            str1 = "FAILED";
label_14:
            string str2 = str1;
            Console.WriteLine("encrypt/decrypt test " + str2);
            return;
        }
label_5:
        num2 = (short) 2;
        num1 = (int) (IntPtr) num2;
        goto label_3;
    }
  }

  [ExcludeFromCodeCoverage]
  public void a(string[] A_0)
  {
    short num1 = -10181;
    int num2 = (int) num1;
    num1 = (short) -10181;
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
        this.a();
        break;
      default:
        goto case 1;
    }
  }

  private AesCryptoServiceProvider a(byte[] A_0)
  {
    short num1 = 20375;
    int num2 = (int) num1;
    num1 = (short) 20375;
    int num3 = (int) num1;
    short num4;
    AesCryptoServiceProvider cryptoServiceProvider;
    switch (num2 == num3 ? 1 : 0)
    {
      case 0:
      case 2:
        num4 = (short) 1;
        if (num4 == (short) 0)
          ;
        return cryptoServiceProvider;
      default:
        num4 = (short) 0;
        if (num4 == (short) 0)
          ;
        cryptoServiceProvider = new AesCryptoServiceProvider();
        try
        {
          cryptoServiceProvider.KeySize = 128;
          cryptoServiceProvider.BlockSize = 128;
          cryptoServiceProvider.Mode = CipherMode.CBC;
          cryptoServiceProvider.Padding = PaddingMode.PKCS7;
          cryptoServiceProvider.Key = A_0;
          cryptoServiceProvider.IV = global::b.d;
          goto case 0;
        }
        catch (global::e ex)
        {
          g.a(ex);
          throw new Exception(ex.Message);
        }
    }
  }

  static b()
  {
    int A_1 = 17;
    short num1 = 29425;
    int num2 = (int) num1;
    num1 = (short) 29425;
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
        global::b.a = new byte[17]
        {
          (byte) 172,
          (byte) 137,
          (byte) 25,
          (byte) 56,
          (byte) 156,
          (byte) 100,
          (byte) 136,
          (byte) 211,
          (byte) 84,
          (byte) 67,
          (byte) 96,
          (byte) 10,
          (byte) 24,
          (byte) 111,
          (byte) 112,
          (byte) 137,
          (byte) 3
        };
        global::b.b = 1024;
        global::b.c = "sOme*ShaREd*SecreT*Which#caN%Bee&diff$each*!@Mod";
        global::b.d = new byte[16]
        {
          (byte) 125,
          (byte) 106,
          (byte) 126,
          (byte) 113,
          (byte) 98,
          (byte) 108,
          (byte) 122,
          (byte) 124,
          (byte) 111,
          (byte) 105,
          (byte) 46,
          (byte) 36,
          (byte) 42,
          (byte) 47,
          (byte) 35,
          (byte) 48
        };
        break;
      default:
        goto case 1;
    }
  }

  public class a
  {
    public const string a = "";
    public const string b = "aInMmm";
    public const string c = "aInMmC";
    public const string d = "aInFxx";
    public const string e = "aInFxC";
    public const string f = "aInInn";
    public const string g = "aInInC";
  }
}

