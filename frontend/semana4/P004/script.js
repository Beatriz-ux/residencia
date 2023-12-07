// const cards = [
//   {
//     id: 1,
//     imagem: "./assets/imgs/salvador.jpg",
//     title: "Salvador",
//     beneficios: ["Aéreo ida e volta", "03 diárias", "Café da manhã"],
//     preco: 670,
//     taxaInclusa: true,
//     parcelas: 10,
//   },
//   {
//     id: 2,
//     imagem: "./assets/imgs/fortaleza.jpg",
//     title: "Fortaleza",
//     beneficios: ["Aéreo ida e volta", "03 diárias", "Café da manhã"],
//     preco: 590,
//     taxaInclusa: true,
//     parcelas: 10,
//   },
//   {
//     id: 3,
//     imagem: "./assets/imgs/campinas.jpg",
//     title: "Campinas",
//     beneficios: ["Aéreo ida e volta", "03 diárias", "Café da manhã"],
//     preco: 1090,
//     taxaInclusa: true,
//     parcelas: 10,
//   },
//   {
//     id: 4,
//     imagem: "./assets/imgs/fortaleza.jpg",
//     title: "Natal",
//     beneficios: ["Aéreo ida e volta", "03 diárias"],
//     preco: 790,
//     taxaInclusa: true,
//     parcelas: 10,
//   },
// ];

const cardsContainer = document.querySelector(".container-destinos");
const cards = carregarTarefasDoStorage();

function criaCard(card) {
  const div = document.createElement("div");
  div.classList.add("roteiros-viagens");
  div.innerHTML = `
        <div class="imagem">
            <img src="${card.url}" alt="">
            <div class="roteiro-destino">${card.titulo}</div>
        </div>
        <div class="roteiros-conteudo">
            <ul class="roteiro-incluso">
              ${
                printBeneficios(card.beneficios)
              }
              <li><iconify-icon icon="mdi-light:check"></iconify-icon>${card.diarias} diárias</li>
            </ul>
            <div class="roteiro-preco">
              <small>R$</small>
              ${Number(card.preco).toLocaleString("pt-br",{
                minimumFractionDigits: 2,
                maximumFractionDigits: 2,
              })}</div>
            <div class="roteiro-obs">
              ${card.taxaInclusa=="sim" ? "Taxa de embarque inclusa" : ""}
              <br />
              ${card.parcelas == "0" ? "Sem parcelamento" : "Em até " +card.parcelas+"x sem Juros"}
            </div>
            <button class="roteiro-comprar" onclick="Comprar(${card.id})">Comprar</button>
          </div>
    `;
    cardsContainer.appendChild(div);
    
}
function Comprar(id){
  const card = cards.find((card) => card.id === id);
  console.log(card);
}

function carregarTarefasDoStorage() {
  // Obtém as tarefas existentes do localStorage
  let cards = JSON.parse(localStorage.getItem("Cards")) || [];
  cards=cards.map(element => {
    return{
      ...element,
      id:cards.indexOf(element)
    }
  }
    );
  // Adiciona cada tarefa ao DOM
  if (cards.length == 0){
    const texto = document.createElement("p");
    texto.innerText = "Nenhum roteiro cadastrado, vá ao botão azul do cabeçalho e cadastre um roteiro";
    texto.classList.add("texto");
    cardsContainer.appendChild(texto);
  }
  cards.forEach(criaCard);
  return cards;
}

function printBeneficios(beneficios){
  let beneficio = "";

  if(beneficios.cafe){
    beneficio += "<li><iconify-icon icon='mdi-light:check'></iconify-icon>Café da manhã</li>";
  }
  if(beneficios.ida_e_volta){
    beneficio += "<li><iconify-icon icon='mdi-light:check'></iconify-icon>Aéreo ida e volta</li>";
  }
  if(beneficios.almoco){
    beneficio += "<li><iconify-icon icon='mdi-light:check'></iconify-icon>Almoço</li>";
  }
  if(beneficios.academia){
    beneficio += "<li><iconify-icon icon='mdi-light:check'></iconify-icon>Academia</li>";
  }
  if(beneficios.piscina){
    beneficio += "<li><iconify-icon icon='mdi-light:check'></iconify-icon>Piscina</li>";
  }
  if(beneficios.wifi){
    beneficio += "<li><iconify-icon icon='mdi-light:check'></iconify-icon>Wifi</li>";
  }
  return beneficio;

  
  
}