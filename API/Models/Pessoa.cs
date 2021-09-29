using System;

namespace API.Models
{
    public class Pessoa
    {
        public Pessoa() => CriadoEm = DateTime.Now;

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public string Idade { get; set; }
        public string Telefone { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString() =>
            $"Nome: {Nome} | Sobrenome: {Sobrenome} | Cpf: {Cpf} | Idade: {Idade} | Telefone: {Telefone} | Criado em: {CriadoEm}";

    }
}