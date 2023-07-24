import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-renderizar-cnpj',
  templateUrl: './renderizar-cnpj.component.html',
  styleUrls: ['./renderizar-cnpj.component.scss']
})
export class RenderizarCnpjComponent {
  @Input() data!: any[];
}
