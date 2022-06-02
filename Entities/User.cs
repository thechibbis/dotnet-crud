using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_test.entities{
  
  public class User{
    public int id {get;set;}
    public string nome {get;set;}
    public string sobrenome {get;set;}
    public string email {get;set;}
    public string senha {get;set;}
    public string status {get;set;}
  }
}