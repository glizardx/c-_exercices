using System;
using System.Collections.Generic;
using System.Linq;

namespace ClientesApp
{
    public class _hospedes
    {
        internal class _hospede
        {
            private string _nome;
            private string _sobrenome;
            private string _email;
            private string _telefone;

            public string Nome
            {
                get => _nome;
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        Console.WriteLine("Nome não pode ser vazio");
                        _nome = "Nome Inválido";
                    }
                    else
                    {
                        _nome = value;
                    }
                }
            }

            public string Sobrenome
            {
                get => _sobrenome;
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        Console.WriteLine("Sobrenome não pode ser vazio");
                        _sobrenome = "Sobrenome Inválido";
                    }
                    if (!value.All(char.IsLetter))
                    {
                        Console.WriteLine("Sobrenome não pode conter números");
                        _sobrenome = "Sobrenome Inválido";
                    }
                    else
                    {
                        _sobrenome = value;
                    }
                }
            }

            public string Email
            {
                get => _email;
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        Console.WriteLine("Email não pode ser vazio");
                        _email = "Email Inválido";
                    }
                    else if (value.Length < 5)
                    {
                        Console.WriteLine("Email deve conter mais de 5 caracteres");
                        _email = "Email Inválido";
                    }
                    else
                    {
                        _email = value;
                    }
                }

            }

            public string Telefone
            {
                get => _telefone;
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        Console.WriteLine("Telefone não pode ser vazio");
                        _telefone = "Telefone Inválido";
                    }
                    else if (value.Length < 8)
                    {
                        Console.WriteLine("Telefone deve conter mais de 8 caracteres");
                        _telefone = "Telefone Inválido";
                    }
                    else
                    {
                        _telefone = value;
                    }
                }
            }

            public _hospede(string nome, string sobrenome, string email, string telefone)
            {
                _nome = nome;
                _sobrenome = sobrenome;
                _email = email;
                _telefone = telefone;

                Console.WriteLine($"Um novo hóspede chamado {_nome} {_sobrenome} foi hospedado.");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<_hospedes._hospede> hospedes = new List<_hospedes._hospede>();

            while (true)
            {
                Console.WriteLine("Bem vindo ao sistema de hospedagem, qual o seu nome?");
                string nome = Console.ReadLine();

                Console.WriteLine("Qual o seu sobrenome?");
                string sobrenome = Console.ReadLine();

                Console.WriteLine("Qual o seu email?");
                string email = Console.ReadLine();

                Console.WriteLine("Por último, qual o telefone?");
                string telefone = Console.ReadLine();

                _hospedes._hospede myHospede = new _hospedes._hospede(nome, sobrenome, email, telefone);
                hospedes.Add(myHospede);

                Console.WriteLine($"O hóspede {myHospede.Nome} {myHospede.Sobrenome} foi hospedado com sucesso.");
                Console.WriteLine($"Email: {myHospede.Email}");
                Console.WriteLine($"Telefone: {myHospede.Telefone}");

                Console.WriteLine("Deseja hospedar mais alguém? (s/n)");
                string answer = Console.ReadLine();
                
                if (answer == "n")
                {
                    break;
                }
            }
            
            Console.WriteLine("Hóspedes hospedados:");
            foreach (var hospede in hospedes)
            {
                Console.WriteLine($"Nome: {hospede.Nome}, Sobrenome: {hospede.Sobrenome}, Email: {hospede.Email}, Telefone: {hospede.Telefone}");
            }

            Console.ReadKey();
        }
    }
}
