using System;
using System.Net.Http;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_em_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnBuscar_Click(Object sender, EventArgs e)
        {
            string cnpj = txtCnpj.Text.Trim();
            if (!string.IsNullOrEmpty(cnpj))
            {
                progressBar.Style = ProgressBarStyle.Marquee;
                progressBar.Visible = true;

                string resultado = await BuscarCnpjAsync(cnpj);

                progressBar.Style = ProgressBarStyle.Blocks;
                progressBar.Visible = false;
                
                lblResultado.Text = resultado;
            }
            else
            {
                MessageBox.Show("Por Favor, Insira um CNPJ Válido");
            }
        }

        private async Task<string> BuscarCnpjAsync(string cnpj)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // URL da API
                    string url = $"https://receitaws.com.br/v1/cnpj/{cnpj}";
                    var response = await client.GetStringAsync(url); // Faz a requisição GET
                    var json = JsonObject.Parse(response);

                    // Extraindo as informações desejadas
                    var nomeEmpresa = json["nome"]?.ToString();
                    var endereco = json["logradouro"]?.ToString();
                    var numero = json["numero"]?.ToString();
                    var cep = json["cep"]?.ToString();

                    // Formatar a resposta
                    return $"Nome da Empresa: {nomeEmpresa}\nEndereço: {endereco}\nNumero {numero}\nCep: {cep}";
                }
                catch (HttpRequestException ex)
                {
                    return $"Erro ao buscar CNPJ: {ex.Message}"; // Tratamento de erro
                }
                catch (Exception ex)
                {
                    return $"Erro inesperado: {ex.Message}"; // Tratamento de erro genérico
                }
            }
        }
    }
}