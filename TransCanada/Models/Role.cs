﻿// Decompiled with JetBrains decompiler
// Type: TransCanada.Models.Role
// Assembly: TransCanada, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 78AEA9CA-12BE-44D1-9407-D806EB0929A5
// Assembly location: C:\Users\Admin\Documents\TransCanada.dll

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TransCanada.Models
{
  public class Role
  {
    [Required]
    [Display(Name = "Role Name ")]
    public string RoleName { get; set; }

    public string Screesnsid { get; set; }

    public int No { get; set; }

    public List<CheckBox> Screesns { get; set; }
  }
}
