import React from 'react';

function Index() {
    const [veiculos, SetVeiculos] = useState([]);
    useEffect(() => {
        //todo criar funçao para buscar veiculos
        async function getVeiculos() {
            try {
                const response = await fetch('https://localhost:7113/api/Veiculo/Veiculos-Disponiveis')
                const data = await response.json();
                console.log(data);
                SetVeiculos(data);

            }
            catch (error) {
                console.erro("Erro ao obter veiculo", error);
            }

        }
        getVeiculos();
    }, []);
    return (
        <div className="veiculo-container">
            {
                veiculos.map(veiculo =>(
                    <div key={veiculo.id} className="card"> 
                        <img src={veiculo.imagem} alt={'veiculo ${veiculo.tipoVeiculo}'} />
                        <br/>
                        <div className="card-content">
                            <p>Tipo de veiculo:{veiculo.tiposdeveiculos }</p>
                            <p>Estado:{veiculo.estado }</p>
                            <p>Ano:{veiculo.anoFabricacao }</p>
                            <p>placa:{veiculo.placa }</p>
                    </div>
                 
                    </div>
            ))
           }
        </div>
            
  );
}



export default Index;