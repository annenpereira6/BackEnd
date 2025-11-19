// See https://aka.ms/new-console-template for more information

//criar um objeto da classe carro

using Exemplos;

// Carro nissan = new Carro("Vermelho", "Nissan", "Kicks", 2026);

// nissan.ExibirInfo();

// Moto Honda = new Moto("Azul", "Honda", "CG 160", 2025 );
// Honda.ExibirInfo();

//criar um interface Icontrole com as seguintes regras/metodos:
//Ligar, Desligar, AumentarVolume, DiminuirVolume

//Criar uma classe ControleRemoto que implemente a interface IControle
//Tambem deve ter as propriedades NivelVolume e VolumeMaximo

ControleRemoto controleTv = new ControleRemoto();
// controleTv.AumentarVolume();
controleTv.DiminuirVolume();