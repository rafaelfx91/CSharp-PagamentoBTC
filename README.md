💰 Pagamento Bitcoin - Gerador de QR Code e Validação de Pagamento
🚀 Visão Geral

Este projeto é uma aplicação desenvolvida em C# .NET Framework que facilita a geração de QR Codes para pagamentos em Bitcoin e valida a transação automaticamente através da API BlockCypher.
🔧 Funcionalidades

✅ Geração de QR Code – Cria um QR Code com os dados do pagamento Bitcoin.
✅ Conversão de Moeda – Converte valores de Reais (BRL) para Bitcoin (BTC) usando a API CoinGecko.
✅ Validação de Pagamento – Consulta a blockchain para verificar se a transação foi confirmada.
✅ Interface Simples e Intuitiva – Desenvolvido com Windows Forms para fácil interação.
🛠️ Tecnologias Utilizadas

    Linguagem: C#
    Framework: .NET Framework
    Bibliotecas:
        QRCoder – Para geração de QR Codes
        Newtonsoft.Json – Para manipulação de JSON
        HttpClient – Para consumo de APIs externas

🎯 Como Funciona?

1️⃣ O usuário informa o valor em Reais (BRL) que deseja converter para Bitcoin (BTC).
2️⃣ O sistema consulta a API CoinGecko para obter a cotação atual.
3️⃣ Um QR Code é gerado para facilitar o pagamento na carteira do usuário.
4️⃣ O sistema verifica periodicamente a blockchain para confirmar o recebimento do pagamento.
📌 Como Usar?

1️⃣ Clone este repositório:

git clone https://github.com/seu-usuario/pagamento-bitcoin.git

2️⃣ Abra o projeto no Visual Studio e compile a solução.
3️⃣ Execute o aplicativo e informe o valor em BRL para gerar o QR Code.
4️⃣ Faça o pagamento utilizando qualquer carteira Bitcoin compatível.
5️⃣ O sistema verificará a blockchain para confirmar a transação.
🛡️ Segurança

    O sistema usa apenas APIs públicas e não armazena chaves privadas ou informações sensíveis.
    Toda a comunicação com APIs externas é feita via requisições HTTPS seguras.

📜 Licença

Este projeto está licenciado sob a MIT License, permitindo seu uso e modificação livremente.
