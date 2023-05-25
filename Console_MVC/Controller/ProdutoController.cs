
using Console_MVC.Model;
using Console_MVC.View;

namespace Console_MVC.Controller
{
    public class ProdutoController
    {
        //instancia das classes
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        //metodo controlador para acessar 
        public void ListarProdutos()
        {
            List<Produto> produtos = produto.Ler();

            produtoView.Listar(produtos);
        }

        public void CadastrarProduto()
        {
            Produto novoProduto = produtoView.Cadastrar();
            produto.Inserir(novoProduto);
        }
    }
}

