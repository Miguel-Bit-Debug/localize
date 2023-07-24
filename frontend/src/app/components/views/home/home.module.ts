import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HomeRoutingModule } from './home-routing.module';
import { HomeComponent } from './home.component';
import { MatToolbarModule } from '@angular/material/toolbar';
import { FormsModule } from '@angular/forms';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { NavbarComponent } from '../../shared/navbar/navbar.component';
import { MatSidenavModule } from '@angular/material/sidenav'
import { MatInputModule } from '@angular/material/input'
import { MatListModule } from '@angular/material/list';
import { EditarPerfilComponent } from '../editar-perfil/editar-perfil.component';
import { ExcluirPerfilComponent } from '../excluir-perfil/excluir-perfil.component';
import { RenderizarCnpjComponent } from '../renderizar-cnpj/renderizar-cnpj.component';

@NgModule({
  declarations: [
    HomeComponent,
    NavbarComponent,
    EditarPerfilComponent,
    ExcluirPerfilComponent,
    RenderizarCnpjComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    HomeRoutingModule,
    MatToolbarModule,
    MatIconModule,
    MatButtonModule,
    MatSidenavModule,
    MatInputModule,
    MatListModule
  ]
})
export class HomeModule { }
