using System;
using System.Collections.Generic;

namespace ADO_.NET._Sinif_Isi;

public partial class Department
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
}
