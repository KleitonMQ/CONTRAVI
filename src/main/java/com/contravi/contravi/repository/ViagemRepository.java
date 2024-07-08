package com.contravi.contravi.repository;

import java.time.LocalDateTime;
import java.util.List;

import org.springframework.data.mongodb.repository.MongoRepository;
import org.springframework.data.mongodb.repository.Query;

import com.contravi.contravi.model.Motorista;
import com.contravi.contravi.model.Roteiro;
import com.contravi.contravi.model.Veiculo;
import com.contravi.contravi.model.Viagem;

public interface ViagemRepository extends MongoRepository<Viagem, String>{
    // Busca viagens por data da viagem
    List<Viagem> findByDataDaViagem(LocalDateTime dataDaViagem);
    
    // Busca viagens por roteiro viagem
    List<Viagem> findByRoteiro(Roteiro roteiro);

    // Busca viagens por motorista
    List<Viagem> findByMotorista(Motorista motorista);
    
    // Busca viagens por veículo
    List<Viagem> findByVeiculo(Veiculo veiculo);

    // Busca viagens por motorista e data da viagem
    @Query("{ 'motorista.id': ?0, 'dataDaViagem': ?1 }")
    List<Viagem> findByMotoristaIdAndDataDaViagem(String motoristaId, LocalDateTime dataDaViagem);
}
