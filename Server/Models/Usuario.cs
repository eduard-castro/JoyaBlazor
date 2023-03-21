
using System.ComponentModel.DataAnnotations;
using JoyaBlazor.Shared.Records;
using JoyaBlazor.Shared.Request;

namespace JoyaBlazor.Server.Models;
public class Usuario 
{
    public Usuario()
    {
        
    }

    public Usuario(int usuarioRolId, string name, string nickName, string password)
    {
        UsuarioRolId = usuarioRolId;
        Name = name;
        NickName = nickName;
        Password = password;
    }

    public Usuario(int id, int usuarioRolId, string name, string nickName, string password)
    {
        Id = id;
        UsuarioRolId = usuarioRolId;
        Name = name;
        NickName = nickName;
        Password = password;
    }

[Key]
    public int Id {get; set;}
    public int UsuarioRolId  {get; set;}
    public string Name {get; set;} = null!;
    public string NickName {get; set;} = null!;
    public string Password {get; set;} = null!;
     public virtual UsuarioRol UsuarioRol  {get; set;} = null!;
public static Usuario Crear (UsuarioCreateRequest request)
    {
      return new Usuario(request.UsuarioRolId, request.Name, request.NickName, request.Password); 
    }
public void Modificar (UsuarioRolUpdateRequest request){
if (Name!= request.Name) Name = request.Name;
if (UsuarioRolId!= request.UsuarioRolId) UsuarioRolId = request.UsuarioRolId;
if (NickName!= request.Nickname) NickName = request.Nickname;
if (Password!= request.Password) Password = request.Password;
}

public UsuarioRecord ToRecord( )
{
  return new UsuarioRecord(Id,UsuarioRol.ToRecord(),Name,NickName,Password);
}
}