using System;
using System.Collections.Generic;
using System.Text;

namespace pessoaanimal
{
    class Pessoa
    {


        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        //public  string pessoa { get; set; }
        //public  string animal { get; set; }

        //public Cadastro[] Cadastros { get; set; } = new Cadastro[3]; 



    }
}namespace pessoaanimal
{
    class Animal
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public int Idade { get; set; }
        public string Tipo { get; set; }


        //public  string animal { get; set; }

        //private int qtdanimal = 0;

        //public void RegistroAnimal(Cadastro c)
        //{
        //    if (qtdanimal < 4)
        //        cadastro[qtdanimal++] = c;
        //}
        //public int RetornoAnimal()
        //{
        //    return qtdanimal;
        //}



    }
}
