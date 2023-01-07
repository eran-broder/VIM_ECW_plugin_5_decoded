// Decompiled with JetBrains decompiler
// Type: a
// Assembly: eCWUrlLaunch, Version=4.0.1745.0, Culture=neutral, PublicKeyToken=null
// MVID: CB040BB1-DE0F-4FAE-AA16-19ACB0F0655F
// Assembly location: C:\ProgramData\eClinicalWorks\plugin\eCWUrlLaunch.exe

using System;
using System.Reflection;

public class a
{
  protected a()
  {
  }

  public static string b(string A_0, string A_1)
  {
    int A_1_1 = 4;
    global::b b = new global::b();
    string str = "";
    try
    {
      int num1 = 3;
      while (true)
      {
        short num2;
        switch (num1)
        {
          case 0:
            num2 = (short) 2;
            num1 = (int) (IntPtr) num2;
            continue;
          case 1:
            num2 = (short) 1;
            if (num2 == (short) 0)
              ;
            str = b.c("aInMmm", A_0, A_1);
            num2 = (short) -13642;
            int num3 = (int) num2;
            num2 = (short) -13642;
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
            break;
          case 2:
            goto label_13;
          case 3:
            switch (0)
            {
              case 0:
                goto label_4;
              default:
                continue;
            }
          default:
label_4:
            if (string.IsNullOrWhiteSpace(A_0))
              goto label_10;
            else
              break;
        }
        num2 = (short) 1;
        num1 = (int) (IntPtr) num2;
      }
label_10:
      throw new e("String to be decrypted is empty.");
    }
    catch (Exception ex)
    {
      g.a(new e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
    }
label_13:
    return str;
  }

  public static string a(string A_0, string A_1)
  {
    int A_1_1 = 7;
    global::b b = new global::b();
    string str = "";
    try
    {
      short num1 = 3;
      int num2 = (int) (IntPtr) num1;
      while (true)
      {
        switch (num2)
        {
          case 0:
            goto label_12;
          case 1:
            num1 = (short) 0;
            num2 = (int) (IntPtr) num1;
            continue;
          case 2:
            str = b.b("aInMmm", A_0, A_1);
            num1 = (short) 31743;
            int num3 = (int) num1;
            num1 = (short) 31743;
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
                num1 = (short) 1;
                num2 = (int) (IntPtr) num1;
                continue;
            }
            break;
          case 3:
            switch (0)
            {
              case 0:
                goto label_4;
              default:
                continue;
            }
          default:
label_4:
            if (string.IsNullOrWhiteSpace(A_0))
              goto label_9;
            else
              break;
        }
        num1 = (short) 2;
        num2 = (int) (IntPtr) num1;
      }
label_9:
      throw new e("String to be decrypted is empty.");
    }
    catch (Exception ex)
    {
      g.a(new e(ex.Message, ex.GetType().FullName, ex.StackTrace, MethodBase.GetCurrentMethod().Name));
    }
label_12:
    if (false)
      ;
    return str;
  }

  internal static string c(string A_0, int A_1)
  {
    char[] charArray = A_0.ToCharArray();
    int num1 = (int) (1056552126 + A_1 + new IntPtr(54) + new IntPtr(95) + new IntPtr(97) + new IntPtr(22) + new IntPtr(44));
    int num2 = 0;
    if (num2 < 1)
      goto label_2;
label_1:
    int index1 = num2;
    char[] chArray = charArray;
    int index2 = index1;
    int num3 = (int) (short) charArray[index1];
    int num4 = num3 & (int) byte.MaxValue;
    int num5 = num1;
    int num6 = num5 + 1;
    byte num7 = (byte) (num4 ^ num5);
    int num8 = num3 >> 8;
    int num9 = num6;
    num1 = num9 + 1;
    int num10 = (int) (byte) (num8 ^ num9);
    int num11 = (int) (ushort) ((uint) num7 << 8 | (uint) (byte) num10);
    chArray[index2] = (char) num11;
    ++num2;
label_2:
    if (num2 >= charArray.Length)
      return string.Intern(new string(charArray));
    goto label_1;
  }
}

