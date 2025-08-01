using DesafioPOO.Models;
// TODO: Realizar os testes com as classes Nokia e Iphone
//implementado
Smartphone meuCelular = new Nokia("99999-9999", "Nokia 3310", "123456789", 64);
meuCelular.Ligar();
meuCelular.InstalarAplicativo("Twitter");

Smartphone outroCelular = new Nokia("99999-9999", "Nokia 3310", "123456789", 64);
outroCelular.Ligar();
outroCelular.InstalarAplicativo("Instagram");
