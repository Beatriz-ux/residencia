const form = document.querySelector("form");
// carregarCardsDoStorage();
form.addEventListener("submit", adicionaCard);

function adicionaCard(event) {
  event.preventDefault();
  const dados = {
    url: form.url.value,
    titulo: form.titulo.value,
    beneficios: {
        cafe: form.cafe.checked,
        ida_e_volta: form.ida_e_volta.checked,
        almoco: form.almoco.checked,
        academia: form.academia.checked,
        piscina: form.piscina.checked,
        wifi: form.wifi.checked,
    },
    diarias: form.diarias.value,
    preco: form.preco.value,
    parcelas: form.parcelas.value,
    taxaInclusa: form.taxaInclusa.value,
  };
  let cardVar = new Card(dados.url, dados.titulo, dados.beneficios,dados.diarias,dados.preco,dados.parcelas,dados.taxaInclusa);
  adicionaCardNoStorage(cardVar);
  window.location.reload();
}

class Card {
  constructor(url, titulo, beneficios,diarias,preco,parcelas,taxaInclusa) {
    this.url = url;
    this.titulo = titulo;
    this.beneficios = beneficios;
    this.diarias = diarias;
    this.preco = preco;
    this.parcelas = parcelas;
    this.taxaInclusa = taxaInclusa;
  }
}

function adicionaCardNoStorage(Card) {
  // Obtém as Cards existentes do localStorage
  let Cards = JSON.parse(localStorage.getItem("Cards")) || [];
  // Adiciona a nova Card ao array
  Cards.push(Card);
  // Armazena o array atualizado no localStorage
  localStorage.setItem("Cards", JSON.stringify(Cards));
}

