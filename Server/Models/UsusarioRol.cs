
using System.ComponentModel.DataAnnotations;
using JoyaBlazor.Shared.Records;
using JoyaBlazor.Shared.Request;

namespace JoyaBlazor.Server.Models;

public class UsuarioRol
{
    [Key]
    public int Id {get; set;}
    public string Nombre {get; set;} = null!;
    public bool PermisoParaCrear {get; set;}
    public bool PermisoParaEditar {get; set;}
    public bool PermisoParaEliminar {get; set;}

    public static UsuarioRol Crear (UsuarioRolCreateRequest request)
    {
        return new UsuarioRol (){ 
            Nombre = request.Name,
            PermisoParaCrear = request.PermisoParaCrear,
            PermisoParaEditar = request.PermisoParaEditar,
            PermisoParaEliminar = request.PermisoParaEliminar,}; 
    }
    public void Modificar (UsuarioRolUpdateRequest request)
    {
        if (Nombre != request.Name)
        Nombre = request.Name;

        if (PermisoParaCrear != request.PermisoParaCrear)
        PermisoParaCrear = request.PermisoParaCrear;

        if (PermisoParaEditar !=request.PermisoParaEditar)
        PermisoParaEditar = request.PermisoParaEditar;

        if (PermisoParaEliminar != request.PermisoParaEliminar)
        PermisoParaEliminar = request.PermisoParaEliminar;
    }

public UsuarioRolRecord ToRecord()
{
   return new UsuarioRolRecord(Id,Nombre,PermisoParaCrear,PermisoParaEditar,PermisoParaEliminar); 
}
}



