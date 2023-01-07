// Decompiled with JetBrains decompiler
// Type: eCWUrlLaunch.Properties.Settings
// Assembly: eCWUrlLaunch, Version=4.0.1745.0, Culture=neutral, PublicKeyToken=null
// MVID: CB040BB1-DE0F-4FAE-AA16-19ACB0F0655F
// Assembly location: C:\ProgramData\eClinicalWorks\plugin\eCWUrlLaunch.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace eCWUrlLaunch.Properties
{
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
  [ExcludeFromCodeCoverage]
  [CompilerGenerated]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings a;

    public static Settings Default
    {
      get
      {
        short num1 = -3348;
        int num2 = (int) num1;
        num1 = (short) -3348;
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
            return Settings.a;
          default:
            goto case 1;
        }
      }
    }

    static Settings()
    {
      short num1 = 1;
      if (num1 == (short) 0)
        ;
      num1 = (short) 31775;
      int num2 = (int) num1;
      num1 = (short) 31775;
      int num3 = (int) num1;
      switch (num2 == num3)
      {
        case true:
          num1 = (short) 0;
          if (num1 == (short) 0)
            ;
          // ISSUE: reference to a compiler-generated field
          // ISSUE: object of a compiler-generated type is created
          Settings.a = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());
          break;
        default:
          goto case 1;
      }
    }
  }
}

