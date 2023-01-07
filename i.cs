// Decompiled with JetBrains decompiler
// Type: i
// Assembly: eCWUrlLaunch, Version=4.0.1745.0, Culture=neutral, PublicKeyToken=null
// MVID: CB040BB1-DE0F-4FAE-AA16-19ACB0F0655F
// Assembly location: C:\ProgramData\eClinicalWorks\plugin\eCWUrlLaunch.exe

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

[ExcludeFromCodeCoverage]
public class i
{
  public const string a = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
  public const string b = "cfhistuCFHISTU";
  private const int c = 16;
  private const double d = 3.5;
  private const double e = 12.0;
  private string f;
  private string g;
  private string h;
  private string i;
  private int j;
  private Regex k;
  private Regex l;
  private static Regex m;
  private static Regex n;

  public i()
  {
    int A_1 = 11;
    // ISSUE: explicit constructor call
    this.\u002Ector(string.Empty, A_2: "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890", A_3: "cfhistuCFHISTU");
  }

  public i(string A_0 = "", int A_1 = 0, string A_2 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890", string A_3 = "cfhistuCFHISTU")
  {
    int A_1_1 = 15;
    // ISSUE: explicit constructor call
    base.\u002Ector();
    if (string.IsNullOrWhiteSpace(A_2))
      throw new ArgumentNullException("alphabet");
    this.g = A_0;
    this.f = string.Join<char>(string.Empty, A_2.Distinct<char>());
    this.h = A_3;
    this.j = A_1;
    if (this.f.Length < 16)
      throw new ArgumentException("alphabet must contain atleast 4 unique characters.", "alphabet");
    this.b();
    this.a();
  }

  private void b()
  {
    int A_1 = 15;
    int num1;
    short num2;
    switch (0)
    {
      case 0:
label_2:
        this.h = new string(this.h.Intersect<char>((IEnumerable<char>) this.f.ToArray<char>()).ToArray<char>());
        this.f = new string(this.f.Except<char>((IEnumerable<char>) this.h.ToArray<char>()).ToArray<char>());
        this.h = this.a(this.h, this.g);
        num2 = (short) 7;
        num1 = (int) (IntPtr) num2;
        goto default;
      default:
        int length;
        while (true)
        {
          switch (num1)
          {
            case 0:
              length = 2;
              num2 = (short) 1;
              num1 = (int) (IntPtr) num2;
              continue;
            case 1:
              num2 = (short) 3;
              num1 = (int) (IntPtr) num2;
              continue;
            case 2:
              if ((double) (this.f.Length / this.h.Length) > 3.5)
              {
                num2 = (short) 5;
                num1 = (int) (IntPtr) num2;
                continue;
              }
              goto label_20;
            case 3:
              if (length <= this.h.Length)
              {
                this.h = this.h.Substring(0, length);
                num2 = (short) 4;
                num1 = (int) (IntPtr) num2;
                continue;
              }
              num2 = (short) 10;
              num1 = (int) (IntPtr) num2;
              continue;
            case 4:
            case 9:
              goto label_20;
            case 5:
label_13:
              length = (int) Math.Ceiling((double) this.f.Length / 3.5);
              num2 = (short) 6;
              num1 = (int) (IntPtr) num2;
              continue;
            case 6:
              num2 = (short) 1;
              if (num2 == (short) 0)
                ;
              if (length == 1)
              {
                num2 = (short) 0;
                num1 = (int) (IntPtr) num2;
                continue;
              }
              goto case 1;
            case 7:
              if (this.h.Length != 0)
              {
                num2 = (short) 8;
                num1 = (int) (IntPtr) num2;
                continue;
              }
              goto case 5;
            case 8:
              num2 = (short) -22663;
              int num3 = (int) num2;
              num2 = (short) -22663;
              int num4 = (int) num2;
              switch (num3 == num4 ? 1 : 0)
              {
                case 0:
                case 2:
                  goto label_13;
                default:
                  num2 = (short) 0;
                  if (num2 == (short) 0)
                    ;
                  num2 = (short) 2;
                  num1 = (int) (IntPtr) num2;
                  continue;
              }
            case 10:
              int num5 = length - this.h.Length;
              this.h += this.f.Substring(0, num5);
              this.f = this.f.Substring(num5);
              num2 = (short) 9;
              num1 = (int) (IntPtr) num2;
              continue;
            default:
              goto label_2;
          }
        }
label_20:
        this.l = new Regex("[" + this.h + "]", RegexOptions.Compiled);
        this.f = this.a(this.f, this.g);
        break;
    }
  }

  private void a()
  {
    int A_1 = 4;
    int num1;
    short num2;
    int num3;
    switch (0)
    {
      case 0:
label_2:
        num2 = (short) 22023;
        int num4 = (int) num2;
        num2 = (short) 22023;
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
            num3 = (int) Math.Ceiling((double) this.f.Length / 12.0);
            num2 = (short) 2;
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
              this.i = this.h.Substring(0, num3);
              this.h = this.h.Substring(num3);
              num2 = (short) 3;
              num1 = (int) (IntPtr) num2;
              continue;
            case 1:
            case 3:
              goto label_10;
            case 2:
              num2 = (short) 1;
              if (num2 == (short) 0)
                ;
              if (this.f.Length >= 3)
              {
                this.i = this.f.Substring(0, num3);
                this.f = this.f.Substring(num3);
                num2 = (short) 1;
                num1 = (int) (IntPtr) num2;
                continue;
              }
              goto label_7;
            default:
              goto label_2;
          }
        }
label_10:
        this.k = new Regex("[" + this.i + "]", RegexOptions.Compiled);
        return;
    }
label_7:
    num2 = (short) 0;
    num1 = (int) (IntPtr) num2;
    goto label_1;
  }

  [Obsolete("Use 'Encode' instead. The methor was renamed to better explain what it actually does.")]
  public virtual string a(params int[] A_0)
  {
    short num1 = -23063;
    int num2 = (int) num1;
    num1 = (short) -23063;
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
        return this.b(A_0);
      default:
        goto case 1;
    }
  }

  [Obsolete("Use 'EncodeHex' instead. The method was renamed to better explain what it actually does.")]
  public virtual string a(string A_0)
  {
    short num1 = 1;
    if (num1 == (short) 0)
      ;
    num1 = (short) 29108;
    int num2 = (int) num1;
    num1 = (short) 29108;
    int num3 = (int) num1;
    switch (num2 == num3)
    {
      case true:
        num1 = (short) 0;
        if (num1 == (short) 0)
          ;
        return this.b(A_0);
      default:
        goto case 1;
    }
  }

  public virtual string b(string A_0)
  {
    int A_1 = 9;
    switch (0)
    {
      default:
        short num1 = 1;
        int num2 = (int) (IntPtr) num1;
        IEnumerator enumerator;
        List<int> intList;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_25;
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
          if (!global::i.m.IsMatch(A_0))
          {
            num1 = (short) 1;
            if (num1 == (short) 0)
              ;
            num1 = (short) 0;
            num2 = (int) (IntPtr) num1;
          }
          else
          {
            intList = new List<int>();
            enumerator = global::i.n.Matches(A_0).GetEnumerator();
            num1 = (short) 2;
            num2 = (int) (IntPtr) num1;
          }
        }
label_23:
        num1 = (short) 31547;
        int num3 = (int) num1;
        num1 = (short) 31547;
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
              num1 = (short) 3;
              num2 = (int) (IntPtr) num1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    if (enumerator.MoveNext())
                    {
                      Match current = (Match) enumerator.Current;
                      int int32 = Convert.ToInt32("1" + current.Value, 16);
                      intList.Add(int32);
                      num1 = (short) 0;
                      num2 = (int) (IntPtr) num1;
                      continue;
                    }
                    num1 = (short) 2;
                    num2 = (int) (IntPtr) num1;
                    continue;
                  case 2:
                    num1 = (short) 4;
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
                  case 4:
                    goto label_26;
                }
                num1 = (short) 1;
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
label_17:
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
                        goto label_21;
                      case 2:
                        goto label_21;
                      default:
                        goto label_17;
                    }
                  }
label_21:;
              }
            }
label_26:
            return this.b(intList.ToArray());
        }
label_25:
        return string.Empty;
    }
  }

  [Obsolete("Use 'Decode' instead. Method was renamed to better explain what it actually does.")]
  public virtual int[] c(string A_0)
  {
    short num1 = -13404;
    int num2 = (int) num1;
    num1 = (short) -13404;
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
        return this.f(A_0);
      default:
        goto case 1;
    }
  }

  [Obsolete("Use 'DecodeHex' instead. The method was renamed to better explain what it actually does.")]
  public virtual string d(string A_0)
  {
    short num1 = 2662;
    int num2 = (int) num1;
    num1 = (short) 2662;
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
        return this.e(A_0);
      default:
        goto case 1;
    }
  }

  public virtual string e(string A_0)
  {
    int A_1 = 19;
    int num1 = 0;
    switch (num1)
    {
      default:
        short num2;
        StringBuilder stringBuilder;
        int[] numArray;
        int index;
        switch (0)
        {
          case 0:
label_6:
            stringBuilder = new StringBuilder();
            numArray = this.f(A_0);
            index = 0;
            num2 = (short) 2;
            num1 = (int) (IntPtr) num2;
            goto default;
          default:
            while (true)
            {
              num2 = (short) 1;
              if (num2 == (short) 0)
                ;
              num2 = (short) -1583;
              int num3 = (int) num2;
              num2 = (short) -1583;
              int num4 = (int) num2;
              switch (num3 == num4 ? 1 : 0)
              {
                case 0:
                case 2:
label_7:
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
                      if (index >= numArray.Length)
                      {
                        num2 = (short) 1;
                        num1 = (int) (IntPtr) num2;
                        continue;
                      }
                      int num5 = numArray[index];
                      stringBuilder.Append(string.Format("{0:X}", (object) num5).Substring(1));
                      ++index;
                      num2 = (short) 3;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    case 1:
                      goto label_11;
                    case 2:
                    case 3:
                      goto label_7;
                    default:
                      goto label_6;
                  }
              }
            }
label_11:
            return stringBuilder.ToString();
        }
    }
  }

  public virtual string b(params int[] A_0)
  {
    switch (0)
    {
      default:
        short num1 = 22;
        int num2 = (int) (IntPtr) num1;
        string str1;
        while (true)
        {
          int num3;
          int index1;
          int index2;
          string str2;
          int num4;
          int num5;
          int A_0_1;
          string str3;
          char ch1;
          switch (num2)
          {
            case 0:
              num1 = (short) 1;
              if (num1 == (short) 0)
                ;
              num1 = (short) 25;
              num2 = (int) (IntPtr) num1;
              continue;
            case 1:
              if (index2 < A_0.Length)
              {
                num3 += A_0[index2] % (index2 + 100);
                ++index2;
                num1 = (short) 24;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              num1 = (short) 4;
              num2 = (int) (IntPtr) num1;
              continue;
            case 2:
            case 6:
              num1 = (short) 13;
              num2 = (int) (IntPtr) num1;
              continue;
            case 3:
              str1 = str1.Substring(num5 / 2, this.j);
              num1 = (short) 2;
              num2 = (int) (IntPtr) num1;
              continue;
            case 4:
              ch1 = str2[num3 % str2.Length];
              str1 = ch1.ToString();
              index1 = 0;
              num1 = (short) 7;
              num2 = (int) (IntPtr) num1;
              continue;
            case 5:
              goto label_42;
            case 7:
            case 8:
              num1 = (short) 9;
              num2 = (int) (IntPtr) num1;
              continue;
            case 9:
              if (index1 >= A_0.Length)
              {
                num1 = (short) 0;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              A_0_1 = A_0[index1];
              string str4 = ch1.ToString() + this.g + str2;
              str2 = this.a(str2, str4.Substring(0, str2.Length));
              str3 = this.a(A_0_1, str2);
              str1 += str3;
              num1 = (short) 19;
              num2 = (int) (IntPtr) num1;
              continue;
            case 10:
              if (A_0.Length == 0)
              {
                num1 = (short) 20;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              str2 = this.f;
              num3 = 0;
              index2 = 0;
              num1 = (short) 17;
              num2 = (int) (IntPtr) num1;
              continue;
            case 11:
              num1 = (short) 10;
              num2 = (int) (IntPtr) num1;
              continue;
            case 12:
              num1 = (short) -19510;
              int num6 = (int) num1;
              num1 = (short) -19510;
              int num7 = (int) num1;
              switch (num6 == num7 ? 1 : 0)
              {
                case 0:
                case 2:
                  goto label_20;
                default:
                  num1 = (short) 0;
                  if (num1 == (short) 0)
                    ;
                  num4 = str2.Length / 2;
                  num1 = (short) 6;
                  num2 = (int) (IntPtr) num1;
                  continue;
              }
            case 13:
              if (str1.Length < this.j)
              {
                str2 = this.a(str2, str2);
                str1 = str2.Substring(num4) + str1 + str2.Substring(0, num4);
                num5 = str1.Length - this.j;
                num1 = (short) 14;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              num1 = (short) 5;
              num2 = (int) (IntPtr) num1;
              continue;
            case 14:
              if (num5 > 0)
              {
                num1 = (short) 3;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              goto case 2;
            case 15:
              str1 = this.i[(num3 + (int) str1[0]) % this.i.Length].ToString() + str1;
              num1 = (short) 23;
              num2 = (int) (IntPtr) num1;
              continue;
            case 16:
              char ch2 = this.i[(num3 + (int) str1[2]) % this.i.Length];
              str1 += ch2.ToString();
              num1 = (short) 12;
              num2 = (int) (IntPtr) num1;
              continue;
            case 17:
            case 24:
              num1 = (short) 1;
              num2 = (int) (IntPtr) num1;
              continue;
            case 18:
              ++index1;
              num1 = (short) 8;
              num2 = (int) (IntPtr) num1;
              continue;
            case 19:
              if (index1 + 1 < A_0.Length)
              {
                num1 = (short) 21;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              goto case 18;
            case 20:
              goto label_17;
            case 21:
label_20:
              A_0_1 %= (int) str3[0] + index1;
              int index3 = A_0_1 % this.h.Length;
              str1 += this.h[index3].ToString();
              num1 = (short) 18;
              num2 = (int) (IntPtr) num1;
              continue;
            case 22:
              switch (0)
              {
                case 0:
                  break;
                default:
                  continue;
              }
              break;
            case 23:
              if (str1.Length < this.j)
              {
                num1 = (short) 16;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              goto case 12;
            case 25:
              if (str1.Length < this.j)
              {
                num1 = (short) 15;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              goto case 12;
          }
          if (A_0 != null)
          {
            num1 = (short) 11;
            num2 = (int) (IntPtr) num1;
          }
          else
            break;
        }
label_17:
        return string.Empty;
label_42:
        return str1.ToString();
    }
  }

  private string a(int A_0, string A_1)
  {
    short num1;
    int num2;
    string str;
    switch (0)
    {
      case 0:
label_3:
        str = string.Empty;
        break;
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
              if (A_0 <= 0)
              {
                num1 = (short) 18303;
                int num3 = (int) num1;
                num1 = (short) 18303;
                int num4 = (int) num1;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_4;
                  default:
                    num1 = (short) 0;
                    if (num1 == (short) 0)
                      ;
                    num1 = (short) 2;
                    num2 = (int) (IntPtr) num1;
                    continue;
                }
              }
              else
                goto case 1;
            case 1:
              str = A_1[A_0 % A_1.Length].ToString() + str;
              A_0 /= A_1.Length;
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
        return str;
    }
label_4:
    num1 = (short) 1;
    num2 = (int) (IntPtr) num1;
    goto label_1;
  }

  private int b(string A_0, string A_1)
  {
    int num1;
    int num2;
    int index;
    short num3;
    switch (0)
    {
      case 0:
label_2:
        num2 = 0;
        index = 0;
        num3 = (short) 1;
        num1 = (int) (IntPtr) num3;
        goto default;
      default:
        while (true)
        {
          switch (num1)
          {
            case 0:
            case 1:
              num3 = (short) 3;
              num1 = (int) (IntPtr) num3;
              continue;
            case 2:
              num3 = (short) 1;
              if (num3 == (short) 0)
                ;
              num3 = (short) 19724;
              int num4 = (int) num3;
              num3 = (short) 19724;
              int num5 = (int) num3;
              switch (num4 == num5 ? 1 : 0)
              {
                case 0:
                case 2:
                  goto label_4;
                default:
                  goto label_8;
              }
            case 3:
label_4:
              if (index >= A_0.Length)
              {
                num3 = (short) 2;
                num1 = (int) (IntPtr) num3;
                continue;
              }
              int num6 = A_1.IndexOf(A_0[index]);
              num2 += (int) ((double) num6 * Math.Pow((double) A_1.Length, (double) (A_0.Length - index - 1)));
              ++index;
              num3 = (short) 0;
              num1 = (int) (IntPtr) num3;
              continue;
            default:
              goto label_2;
          }
        }
label_8:
        num3 = (short) 0;
        if (num3 == (short) 0)
          ;
        return num2;
    }
  }

  public virtual int[] f(string A_0)
  {
    int A_1 = 11;
    switch (0)
    {
      default:
        short num1 = 7;
        int num2 = (int) (IntPtr) num1;
        List<int> intList;
        while (true)
        {
          int index1;
          string[] strArray;
          string str1;
          char ch;
          string str2;
          int index2;
          switch (num2)
          {
            case 0:
              str1 = strArray[index2];
              num1 = (short) 14;
              num2 = (int) (IntPtr) num1;
              continue;
            case 1:
            case 13:
              num1 = (short) 9;
              num2 = (int) (IntPtr) num1;
              continue;
            case 2:
              num1 = (short) 8;
              num2 = (int) (IntPtr) num1;
              continue;
            case 3:
              intList.Clear();
              num1 = (short) 5440;
              int num3 = (int) num1;
              num1 = (short) 5440;
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
                  num1 = (short) 10;
                  num2 = (int) (IntPtr) num1;
                  continue;
              }
              break;
            case 4:
              index2 = 1;
              num1 = (short) 0;
              num2 = (int) (IntPtr) num1;
              continue;
            case 5:
              goto label_17;
            case 6:
              if (this.b(intList.ToArray()) != A_0)
              {
                num1 = (short) 3;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              goto label_29;
            case 7:
              switch (0)
              {
                case 0:
                  goto label_4;
                default:
                  continue;
              }
            case 8:
              if (strArray.Length == 2)
              {
                num1 = (short) 4;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              goto case 0;
            case 9:
              if (index1 >= strArray.Length)
              {
                num1 = (short) 11;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              string A_0_1 = strArray[index1];
              string str3 = ch.ToString() + this.g + str2;
              str2 = this.a(str2, str3.Substring(0, str2.Length));
              intList.Add(this.b(A_0_1, str2));
              ++index1;
              num1 = (short) 1;
              num2 = (int) (IntPtr) num1;
              continue;
            case 10:
              goto label_29;
            case 11:
              num1 = (short) 6;
              num2 = (int) (IntPtr) num1;
              continue;
            case 12:
              ch = str1[0];
              str1 = this.l.Replace(str1.Substring(1), " ");
              strArray = str1.Split(new char[1]{ ' ' }, StringSplitOptions.RemoveEmptyEntries);
              index1 = 0;
              num1 = (short) 13;
              num2 = (int) (IntPtr) num1;
              continue;
            case 14:
              if (str1[0] == char.MinValue)
                goto label_29;
              else
                break;
            case 15:
              if (strArray.Length != 3)
              {
                num1 = (short) 2;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              goto case 4;
            default:
label_4:
              num1 = (short) 1;
              if (num1 == (short) 0)
                ;
              if (string.IsNullOrWhiteSpace(A_0))
              {
                num1 = (short) 5;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              str2 = string.Copy(this.f);
              intList = new List<int>();
              index2 = 0;
              str1 = this.k.Replace(A_0, " ");
              strArray = str1.Split(new char[1]{ ' ' }, StringSplitOptions.RemoveEmptyEntries);
              num1 = (short) 15;
              num2 = (int) (IntPtr) num1;
              continue;
          }
          num1 = (short) 12;
          num2 = (int) (IntPtr) num1;
        }
label_17:
        return new int[0];
label_29:
        return intList.ToArray();
    }
  }

  private string a(string A_0, string A_1)
  {
    switch (0)
    {
      default:
        short num1 = 1;
        int num2 = (int) (IntPtr) num1;
        while (true)
        {
          int num3;
          int num4;
          int num5;
          switch (num2)
          {
            case 0:
            case 2:
              num1 = (short) 4;
              num2 = (int) (IntPtr) num1;
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
            case 3:
              goto label_14;
            case 4:
              if (num5 > 0)
              {
                int index = num3 % A_1.Length;
                int num6;
                num4 += num6 = (int) A_1[index];
                int num7 = (num6 + index + num4) % num5;
                char ch = A_0[num7];
                A_0 = A_0.Substring(0, num7) + A_0[num5].ToString() + A_0.Substring(num7 + 1);
                A_0 = A_0.Substring(0, num5) + ch.ToString() + A_0.Substring(num5 + 1);
                --num5;
                num3 = index + 1;
                num1 = (short) 0;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              num1 = (short) 3;
              num2 = (int) (IntPtr) num1;
              continue;
            case 5:
              goto label_10;
          }
          num1 = (short) 25612;
          int num8 = (int) num1;
          num1 = (short) 25612;
          int num9 = (int) num1;
          switch (num8 == num9 ? 1 : 0)
          {
            case 0:
            case 2:
              goto label_10;
            default:
              num1 = (short) 0;
              if (num1 == (short) 0)
                ;
              if (string.IsNullOrWhiteSpace(A_1))
              {
                num1 = (short) 5;
                num2 = (int) (IntPtr) num1;
                continue;
              }
              int num10;
              int num11 = num10 = 0;
              num4 = num10;
              num3 = num10;
              num5 = A_0.Length - 1;
              num1 = (short) 2;
              num2 = (int) (IntPtr) num1;
              continue;
          }
        }
label_10:
        return A_0;
label_14:
        num1 = (short) 1;
        if (num1 == (short) 0)
          ;
        return A_0;
    }
  }

  static i()
  {
    int A_1 = 6;
    short num1 = -3652;
    int num2 = (int) num1;
    num1 = (short) -3652;
    int num3 = (int) num1;
    switch (num2 == num3)
    {
      case true:
        if (false)
          ;
        if (true)
          ;
        global::i.m = new Regex("^[0-9a-fA-F]+$", RegexOptions.Compiled);
        global::i.n = new Regex("[\w\W]{1,12}", RegexOptions.Compiled);
        break;
      default:
        goto case 1;
    }
  }
}

