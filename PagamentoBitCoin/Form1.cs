using QRCoder;
using System;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Globalization;


namespace PagamentoBitCoin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal amount = 0.00m; // Valor em BTC

        static async Task CheckPayment(string bitcoinAddress)
        {
            string apiUrl = $"https://api.blockcypher.com/v1/btc/main/addrs/{bitcoinAddress}/balance";

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync(apiUrl);
                Console.WriteLine(response); // Aqui você verifica se o saldo mudou
                
            }
        }

        private async void btnCotar_Click(object sender, EventArgs e)
        {
            decimal valorDecimal = decimal.Parse(txtCotarBtc.Text, CultureInfo.InvariantCulture);
            this.amount = await ConverterReaisParaBitcoin(valorDecimal);
            lblCotacaoBTC.Text = @"BTC: " + this.amount.ToString();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string bitcoinAddress = "bc1qde6dwq2p2tgm4m4mmts05sltmxe87pk3gjc5lj"; // Minha Carteira
            

            string paymentUri = $"bitcoin:{bitcoinAddress}?amount={amount}";

            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(paymentUri, QRCodeGenerator.ECCLevel.Q);
                using (QRCode qrCode = new QRCode(qrCodeData))
                {
                    Bitmap qrCodeImage = qrCode.GetGraphic(20);

                    // Exibe o QR Code em um formulário
                    Form qrForm = new Form
                    {
                        Text = "Pagamento Bitcoin",
                        ClientSize = new Size(300, 300)
                    };

                    PictureBox pictureBox = new PictureBox
                    {
                        Image = qrCodeImage,
                        Dock = DockStyle.Fill,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };

                    qrForm.Controls.Add(pictureBox);
                    qrForm.ShowDialog(); // Corrige o erro
                }
            }
            // Verifica o pagamento após exibir o QR Code
            string message = await CheckPaymentAsync(bitcoinAddress, amount);
            MessageBox.Show(message, "Status do Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        private async Task<string> CheckPaymentAsync(string bitcoinAddress, decimal expectedAmount)
        {
            string apiUrl = $"https://api.blockcypher.com/v1/btc/main/addrs/{bitcoinAddress}/balance";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetStringAsync(apiUrl);

                    // Deserializa o JSON retornado
                    var balanceInfo = JsonConvert.DeserializeObject<BlockcypherBalance>(response);

                    // Converte satoshis para BTC
                    decimal confirmedBalance = balanceInfo.final_balance / 100000000m;

                    if (confirmedBalance >= expectedAmount)
                    {
                        return "Pagamento recebido com sucesso!";
                    }
                    else
                    {
                        return "Nenhum pagamento detectado. Por favor, tente novamente.";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Erro ao verificar o pagamento: {ex.Message}";
            }
        }



        private async Task<decimal> ConverterReaisParaBitcoin(decimal valorReais)
        {
            string apiUrl = "https://api.coingecko.com/api/v3/simple/price?ids=bitcoin&vs_currencies=brl";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetStringAsync(apiUrl);

                    // Deserializa o JSON retornado pela API
                    var cotacao = JsonConvert.DeserializeObject<CotacaoBitcoin>(response);

                    // Preço do BTC em BRL
                    decimal precoBitcoinEmReais = cotacao.Bitcoin.Brl;

                    // Converte o valor de reais para Bitcoin
                    decimal valorBitcoin = valorReais / precoBitcoinEmReais;

                    return valorBitcoin;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter a cotação: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

     
    }
}
