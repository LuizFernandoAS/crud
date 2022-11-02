using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud
{
    public class Cliente
    {
        //Método Construtor
        public Cliente(int id=0, string nome=null, string sobrenome=null, string telefone=null, string email=null)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
            Email = email;
        }

        //Propriedade
        public int Id { get; set; }
        public string Nome{get;set;}
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        

        public void Inserir()
        {
            var cmd= Banco.Abrir();
            cmd.CommandText = "INSERT Cliente VALUES (0, @Nome, @Sobrenome, @Telefone, @Email)";
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Sobrenome", Sobrenome);
            cmd.Parameters.AddWithValue("@Telefone", Telefone);
            cmd.Parameters.AddWithValue("@Email", Email);

            cmd.ExecuteNonQuery();
        }

        public void Alterar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "UPDATE Cliente SET nomeCliente='@Nome'; sobrenomeCliente='@Sobrenome', telefoneCliente='@Telefone', emailCliente='@Email' WHERE idcliente='@Id')";
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Sobrenome", Sobrenome);
            cmd.Parameters.AddWithValue("@Telefone", Telefone);
            cmd.Parameters.AddWithValue("@Email", Email);

            cmd.ExecuteNonQuery();
        }
        
        public void Deletar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "INSERT Cliente VALUES (0, @Nome, @Sobrenome, @Telefone, @Email)";
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@Sobrenome", Sobrenome);
            cmd.Parameters.AddWithValue("@Telefone", Telefone);
            cmd.Parameters.AddWithValue("@Email", Email);

            cmd.ExecuteNonQuery();

        }

    }
}
