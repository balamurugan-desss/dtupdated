﻿// Decompiled with JetBrains decompiler
// Type: TransCanada.Models.Services
// Assembly: TransCanada, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 78AEA9CA-12BE-44D1-9407-D806EB0929A5
// Assembly location: C:\Users\Admin\Documents\TransCanada.dll

using System.ComponentModel.DataAnnotations;

namespace TransCanada.Models
{
  public class Services
  {
    public int Service_id { get; set; }

    [Required]
    [Display(Name = "Service Group")]
    public string Service_Name { get; set; }

    public string Labid { get; set; }
  }
}
