using JoyaBlazor.Shared.Wrapper;
using JoyaBlazor.Shared.Records;
using static JoyaBlazor.Shared.Wrapper.Result<T>;
using JoyaBlazor.Shared.Routes;

public class UsuarioRolManager
{
    private readonly HttpClient httpClient;

    public UsuarioRolManager(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
public async Task <ResultList<UsuarioRolRecord>> GetAsync()
{
    try 
    {
      var response = httpClient.GetAsync(UsuarioRolRouteManager.BASE);
    var resultado = await response.ToResultList<UsuarioRolRecord>();
    return resultado;
    
    }
    catch(Exception e)
    {
        return ResultList<UsuarioRolRecord>.Fail(e.Message);
    }
}

}