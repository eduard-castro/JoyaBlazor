
using System.ComponentModel.DataAnnotations;

namespace JoyaBlazor.Shared.Request;

public class UsuarioRolUpdateRequest : UsuarioRolCreateRequest
{
[Required(ErrorMessage ="Se debe proporcionar el Id del Rol a modificar")]
   public int Id {get; set;}
    public int UsuarioRolId { get; set; }
    public string? Nickname { get; set; }
    public string? Password { get; set; }
}