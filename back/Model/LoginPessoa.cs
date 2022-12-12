using System;
using System.Collections.Generic;

namespace back.Model;

public partial class LoginPessoa
{
    public int PessoaId { get; set; }

    public string EmailPessoa { get; set; } = null!;

    public string SenhaPessoa { get; set; } = null!;
}
