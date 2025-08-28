using System;
using System.Collections.Generic;

namespace ADO_.NET._Sinif_Isi;

public partial class Faculty
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();
}
