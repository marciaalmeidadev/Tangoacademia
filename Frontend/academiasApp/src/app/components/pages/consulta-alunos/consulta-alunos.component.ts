import { Component } from '@angular/core';
import { Aluno } from 'src/app/shared/model/aluno-models';

@Component({
  selector: 'app-consulta-alunos',
  templateUrl: './consulta-alunos.component.html',
  styleUrls: ['./consulta-alunos.component.css']
})
export class ConsultaAlunosComponent {
 /*
Atributos
*/
alunos: Aluno[] = [];
quantidadeDeAlunos: number = 0;

constructor() {}

ngOnInit(): void {
  this.alunos = [
    {
      nome: 'Marcia Correa',
      idade: 56,
      observacoes: 'bom aluno',
    },
    { nome: 'Marta Corria',
    idade: 46,
     observacoes: 'bom aluno' },
     {
      nome: 'Marta Silva',
      idade: 26,
      observacoes: ' aluno gordo',
    },
    {
      nome: 'Paulo Junoir Correa',
      idade: 16,
      observacoes: ' aluno diciplinado',
    },
    {
      nome: 'Rose Pacheco',
      idade: 61,
      observacoes: 'mau pagadora',
    },
  ];
  this.quantidadeDeAlunos = this.alunos.length;
}

}
