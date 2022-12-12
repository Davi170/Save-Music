using System;
using System.Collections.Generic;

namespace back.Model;

public partial class UsuarioToken
{
    public int? UsuarioTokenId { get; set; }

    public int? UsuarioId { get; set; }

    public string? TipoToken { get; set; }

    public string? Token { get; set; }

    public string AccessToken { get; set; } = null!;

    public string? TokenType { get; set; }

    public string? Scope { get; set; }

    public string? ExpiresIn { get; set; }

    public string? RefreshToken { get; set; }
}
