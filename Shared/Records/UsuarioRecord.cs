namespace JoyaBlazor.Shared.Records;

public class UsuarioRecord
{
    private UsuarioRolRecord usuarioRolRecord;
    private UsuarioRolRecord usuarioRolRecord1;

    public UsuarioRecord(int id, UsuarioRolRecord usuarioRolRecord1, string name, string nickName, string password)
    {
        Id = id;
        this.usuarioRolRecord1 = usuarioRolRecord1;
        Name = name;
        NickName = nickName;
        Password = password;
    }

    public int Id {get; set;}
    public int UsuarioRolId  {get; set;}
    public virtual UsuarioRolRecord UsuarioRol  {get; set;} = null!;
    public string Name {get; set;} = null!;
    public string NickName {get; set;} = null!;
    public string Password {get; set;} = null!;
    public UsuarioRolRecord UsuarioRolRecord { get; }
}