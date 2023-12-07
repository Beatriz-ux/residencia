function Comprar(id){
  const card = cards.find((card) => card.id === id);
  console.log(card);
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