# Projeto de Exemplo com Kafka e .NET Core

Este é um projeto de exemplo que demonstra como usar o Apache Kafka como sistema de mensageria em uma aplicação .NET Core. Ele ilustra os conceitos básicos de produção e consumo de mensagens usando o Kafka e fornece um ponto de partida para integrar o Kafka em seus próprios projetos.

## Pré-requisitos

Antes de começar, certifique-se de ter as seguintes ferramentas instaladas em sua máquina:

- [.NET Core](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/get-started)
- [Docker Compose](https://docs.docker.com/compose/install/)
- [Apache Kafka](https://kafka.apache.org/downloads) (ou você pode usá-lo via Docker)

## Configuração do Kafka

Certifique-se de que o Apache Kafka esteja em execução. Você pode usar o Docker Compose para executar um cluster Kafka localmente com as configurações padrão:

```bash
docker-compose up -d
