using System;
using System.Collections.Generic;

namespace back.Model;

public partial class UsuarioToken
{
    public int UsuarioTokenId { get; set; }

    public int? UsuarioId { get; set; }

    public string TipoToken { get; set; } = null!;

    public string Token { get; set; } = null!;

    public string AccessToken { get; set; } = null!;

    public string TokenType { get; set; } = null!;

    public string Scope { get; set; } = null!;

    public string ExpiresIn { get; set; } = null!;

    public string RefreshToken { get; set; } = null!;

    public virtual LoginPessoa? Usuario { get; set; }
}
