using Rampfy.BlazorDash.Shared.Enums;


namespace Rampfy.BlazorDash.Shared.Models
{
     public abstract class AxysBase
    {
         public string? Label {get; set;}
        public object[]? XValue {get; set;}
        public object[]? YValue {get; set;}

    }
    public class AxysTyped<TX,TY> : AxysBase
    {
       
        public TX[]? XValue {get; set;}
        public TY[]? YValue {get; set;}
    }
}