
using System.ComponentModel.DataAnnotations;

namespace JoyaBlazor.Shared.Request;

public class UsuarioRolCreateRequest
{
[Required(ErrorMessage ="Se debe proporcionar el nombre del Rol"),
    MinLength(3, ErrorMessage = "El nombre debe superar los 3 Caracteres. "), 
    MaxLength(100, ErrorMessage = "El nombre no debe superar los 100 Caracteres. "), 
]
    public string Name {get; set;} = null!;
    public bool PermisoParaCrear {get; set;}
    public bool PermisoParaEditar {get; set;}
    public bool PermisoParaEliminar {get; set;}
}
