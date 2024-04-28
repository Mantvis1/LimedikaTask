﻿using System.ComponentModel.DataAnnotations;

namespace LimedikosTask.Server.Models;

public class Client
{
    [Key]
    public string Name { get; set; }
    public string Address { get; set; }
    public string PostCode { get; set; }
}
