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

