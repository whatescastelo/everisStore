using System;
using EverisStore.Domain;

namespace EverisStore.Aplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testando cenário de usuário perfil
            Perfil perfil = new Perfil
            {
                Id = 1,
                Descricao = "Contador",
                Regra = "Pode acessar tudo",
                DataCadastro = DateTime.Now,
                Ativo = true
            };

            Usuario usuario = new Usuario(1, "Whates", "fulano@hotmail.com", "55555", 1);
            usuario.Perfil = perfil;

            string descricaoPerfil = usuario.Perfil.Descricao;

            var verificaAtivo = usuario.RetornarAtivo();

            usuario.Desativar();
            usuario.Desativar(0);
            var verificaAtivo2 = usuario.RetornarAtivo();

            usuario.Ativar();
            var verificaAtivo3 = usuario.RetornarAtivo();


            // Testando cenário produto
            Produto produto = new Produto(1, "Mesa", "Mesa quatro cadeiras", 500, 10);

            produto.ReporEstoque(15);

            var possuiEstoque = produto.PossuiEstoque(10);
            if(possuiEstoque)
                produto.DebitarEstoque(10);

            var possuiEstoque2 = produto.PossuiEstoque(15);
            if(possuiEstoque)
                produto.DebitarEstoque(10);


            
        }
    }
}
