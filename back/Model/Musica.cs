using System;
using System.Collections.Generic;

namespace back.Model;

public partial class Musica
{
    public int IdMusica { get; set; }

    public string? Nome { get; set; }

    public TimeSpan? Duracao { get; set; }
}
