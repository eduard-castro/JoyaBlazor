using JoyaBlazor.Shared.Records;

namespace JoyaBlazor.Shared.Wrapper;
public partial class Result<T>
{
    public class ResultList<T>:Result
{
    public IEnumerable<T> Items { get; set; }= default!;

    public new static ResultList<T> Fail()
{
    return new ResultList<T>(){Succeeded=false, Message= new List<string> (){"❌"}};
}
   public  new static  ResultList<T> Fail(string message)
{
    return new ResultList<T>(){Succeeded=false, Message= new List<string> (){message}};
}
    public new static ResultList<T> Fail(List<string> messages)
{
    return new ResultList<T>(){Succeeded=false, Message= messages};
}

        public static Microsoft.AspNetCore.Mvc.ActionResult<int> Succees(List<UsuarioRecord> roles)
        {
            throw new NotImplementedException();
        }
    }

}