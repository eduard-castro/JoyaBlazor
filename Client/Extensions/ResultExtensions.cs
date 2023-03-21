namespace JoyaBlazor.Client.Extensions;

using JoyaBlazor.Shared.Wrapper;
using Newtonsoft.Json;

internal class ResultExtension
{
 internal static async Async Task<T> (this HttpResponseMessage response){
    var respuesta_a_texto = await response.Content.ReadAsByteArrayAsync();
 var objeto = JsonConvert.DeserializeObject<Result<T>>(respuesta_a_texto);
 return objeto!;
 } 
 internal static async Async TaskList<T> (this HttpResponseMessage response){
    var respuesta_a_texto = await response.Content.ReadAsByteArrayAsync();
 var objeto = JsonConvert.DeserializeObject<Result<T>>(respuesta_a_texto);
 return objeto!;
 }
}