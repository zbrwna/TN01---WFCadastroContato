﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN01___WFCadastroContato
{
    public enum ETipoTelefone
    {
        Pessoal = 1,
        Comercial,
        Recado
    }
    public class Contato
    {
        public Contato(int codigo, string? nome, string? sobrenome, string? dDD, string? telefone, ETipoTelefone tipoTelefone, string? email)
        {
            Codigo = codigo;
            Nome = nome;
            Sobrenome = sobrenome;
            DDD = dDD;
            Telefone = telefone;
            TipoTelefone = tipoTelefone;
            Email = email;
        }
        public Contato() { }

        public static List<Contato> ListaContatos = new List<Contato>();

        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
        public string? DDD { get; set; }
        public string? Telefone { get; set; }
        public ETipoTelefone TipoTelefone { get; set; }
        public string? Email { get; set; }

    }
}
