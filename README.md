[doc]: https://start.spring.io/#!type=maven-project&language=java&platformVersion=3.3.1&packaging=jar&jvmVersion=17&groupId=com.contravi&artifactId=contravi&name=contravi&description=Gerenciar%20viagens%2C%20roteiros%20e%20passageiros.&packageName=com.contravi.contravi&dependencies=security,data-mongodb


## Dependências:
EntityFramewokr
- instalar global na maquina via cli: dotnet tool install --global dotnet-ef
- instalar em infrastructure: EntityFrameworkCore.SqlServer e EntityFrameworkCore.Tools


[Configuração inicial spring][doc].
## Diagrama de classe

```mermaid
classDiagram
    Pessoa <|-- Motorista
    Pessoa <|-- Passageiro
    
    class Pessoa {
        -nome: string
        -telefone: string
        -id: string
        -endereco: Endereco
    }

    class Endereco {
        -cep: string
        -uf: string
        -cidade: string
        -bairro: string
        -logradouro: string
        -numero: string
        -complemento: string
    }

    class Motorista {
        -CNH: string
    }

    class Passageiro {
        -CNS: string
    }

    class Veiculo {
        -Id: string
        -modelo: string
        -placa: string
        -vagas: int
    }

    class Viagem {
        -motorista: Motorista
        -horario: DateTime
        -veiculo: Veiculo
        -data: DateTime
        -roteiro: Roteiro
        -destinoDosPassageiros: DestinoDoPassageiro
    }

    class DestinoDoPassageiro {
        -passageiro: Passageiro
        -procedimento: string
        -destino: string
        -horarioDeAtendimento: DateTime
    }

    class Roteiro {
        -saida: string
        -destino: string
        -chegada: string
    } 

    Pessoa *-- Endereco
    Viagem *-- Veiculo
    Viagem *-- Motorista
    Viagem *-- Roteiro
    Viagem o-- DestinoDoPassageiro
```

## Diagrama Entidade Relacionamento

```mermaid
erDiagram
    PESSOA {
        string id
        string nome
        string telefone
        string cep
        string uf
        string cidade
        string bairro
        string logradouro
        string numero
        string complemento
    }

    MOTORISTA {
        string id
        string CNH
    }

    PASSAGEIRO {
        string id
        string CNS
    }

    VEICULO {
        string id
        string modelo
        string placa
        int vagas
    }

    VIAGEM {
        string id
        string motorista_id
        DateTime horario
        string veiculo_id
        DateTime data
        string roteiro_id
    }

    DESTINODOPASSAGEIRO {
        string id
        string viagem_id
        string passageiro_id
        string procedimento
        string destino
        DateTime horarioDeAtendimento
    }

    ROTEIRO {
        string id
        string saida
        string destino
        string chegada
    }

    PESSOA ||--o{ MOTORISTA : "é"
    PESSOA ||--o{ PASSAGEIRO : "é"
    VIAGEM ||--o{ VEICULO : "contém"
    VIAGEM ||--o{ MOTORISTA : "contém"
    VIAGEM ||--o{ ROTEIRO : "contém"
    VIAGEM ||--o{ DESTINODOPASSAGEIRO : "contém"
    DESTINODOPASSAGEIRO ||--o{ PASSAGEIRO : "é"

```
