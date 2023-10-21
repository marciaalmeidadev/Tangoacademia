import { Component, OnInit } from '@angular/core';
import { Funcionario } from 'src/app/shared/model/Funcionario-model';

@Component({
  selector: 'app-consulta-funcionarios',
  templateUrl: './consulta-funcionarios.component.html',
  styleUrls: ['./consulta-funcionarios.component.css'],
})
export class ConsultaFuncionariosComponent implements OnInit {
  /*
Atributos
*/
  funcionarios: Funcionario[] = [];
  quantidadeDeFuncionarios: number = 0;

  constructor() {}

  ngOnInit(): void {
    this.funcionarios = [
      {
        nome: 'Marcia Correa',
        idade: 56,
        cargo: 'professora',
      },
      { nome: 'Marta Corria', idade: 46, cargo: 'faxineira' },
    ];
    this.quantidadeDeFuncionarios = this.funcionarios.length;
  }
}
