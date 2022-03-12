using System.Collections.Generic;

namespace OneInch.Api
{    
     public class Swap
    {
             public Token FromToken {get;set;}
             public Token ToToken {get;set;}            
             public List<List<List<SelectedProtocol>>> Protocols {get;set;}             
             public string FromTokenAmount {get;set;}
             public string ToTokenAmount {get;set;}
             public Transaction Tx {get;set;}
    }
}