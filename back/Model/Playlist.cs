using System;
using System.Collections.Generic;

namespace back.Model;

public partial class Playlist
{
    public int IdPlaylist { get; set; }

    public int? MusicasQnt { get; set; }

    public string? Nome { get; set; }

    public string? Musicas { get; set; }
}
