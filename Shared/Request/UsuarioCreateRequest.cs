using System.ComponentModel.DataAnnotations;

namespace JoyaBlazor.Shared.Request;

public class UsuarioCreateRequest
{
    [Range (1,int.MaxValue, ErrorMessage ="El Rol seleccionado no es valido")]
    public int UsuarioRolId  {get; set;}
    
     [ Required(ErrorMessage ="Se debe proporcionar el nombre del Usuario"),
      MinLength(5, ErrorMessage = "El nombre debe superar los 5 Caracteres. "), 
      MaxLength(100, ErrorMessage = "El nombre no debe superar los 100 Caracteres. "), 
     ]
    public string Name {get; set;} = null!;

     [ Required(ErrorMessage ="Se debe proporcionar el NickName del Usuario"),
       MinLength(3, ErrorMessage = "El NickName debe superar los 3 Caracteres. "), 
        MaxLength(100, ErrorMessage = "El NickName no debe superar los 100 Caracteres. "), 
     ]
    public string NickName {get; set;} = null!;
      [ Required(ErrorMessage ="Se debe proporcionar La Contraseña del Usuario"),
       MinLength(3, ErrorMessage = "La Contraseña debe superar los 3 Caracteres. "), 
        MaxLength(100, ErrorMessage = "La Contraseña no debe superar los 100 Caracteres. "), 
       ]
    public string Password {get; set;} = null!;

}
public class UsuarioUpdateRequest : UsuarioCreateRequest
{
[Required(ErrorMessage ="Se debe proporcionar el Id del Usuario a modificar")]
     public int Id {get; set;}

}

