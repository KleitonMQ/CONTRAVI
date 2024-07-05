[doc]: https://start.spring.io/#!type=maven-project&language=java&platformVersion=3.3.1&packaging=jar&jvmVersion=17&groupId=com.contravi&artifactId=contravi&name=contravi&description=Gerenciar%20viagens%2C%20roteiros%20e%20passageiros.&packageName=com.contravi.contravi&dependencies=data-jpa,security,data-mongodb

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
        -horarioDeAtendimento: string
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
    MOTORISTA {
        string id
        string nome
        string telefone
        string CNH
        string cep
        string uf
        string cidade
        string bairro
        string logradouro
        string numero
        string complemento
    }

    PASSAGEIRO {
        string id
        string nome
        string telefone
        string CNS
        string cep
        string uf
        string cidade
        string bairro
        string logradouro
        string numero
        string complemento
    }

    VEICULO {
        string Id
        string modelo
        string placa
        int vagas
    }

    VIAGEM {
        string motorista
        DateTime horario
        string veiculo
        DateTime data
        string roteiro
        string passageiros
        string procedimento
        string destino
        string horarioDeAtendimento
    }

    VIAGEM ||--o{ VEICULO : "contém"
    VIAGEM ||--o{ MOTORISTA : "contém"
    VIAGEM ||--o{ PASSAGEIRO : "contém"
```
