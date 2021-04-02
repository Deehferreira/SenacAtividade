using System;

namespace EstudoBC.Models
{
    public class Usuario
    {
        public string Nome {get;set;}
        public string Login{get;set;}
        public string Senha{get;set;}
        public int Id { get; set;}
        public DateTime DataNascimento {get;set;}
    }
}