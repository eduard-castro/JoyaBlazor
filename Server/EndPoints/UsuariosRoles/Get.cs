using Ardalis.ApiEndpoints;
using JoyaBlazor.Server.Context;
using JoyaBlazor.Shared.Records;
using JoyaBlazor.Shared.Routes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static JoyaBlazor.Shared.Wrapper.Result<T>;
using static Microsoft.AspNetCore.Mvc;

namespace JoyaBlazor.Server.EndPoints.UsuariosRoles;
using Respuesta = ResultList<UsuarioRolRecord>;

public class Get : EndpointBaseAsync.WithoutRequest.WithActionResult<int>
{
    private readonly IMyDbContext dbContex;

    public Get(IMyDbContext dbContex)
    {
        this.dbContex = dbContex;
    }
    [Microsoft.AspNetCore.Mvc.HttpGet(UsuarioRolRouteManager.BASE)]
    public override async Task<ActionResult<int>> HandleAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            var roles = await dbContex.UsuariosRoles 
        .Select(rol=>rol.ToRecord())
        .ToListAsync(cancellationToken);
        
        return Respuesta.Succees(roles);
        }
        catch(Exception ex){
            return Respuesta.Fail(ex.Message);
        }
    }
}