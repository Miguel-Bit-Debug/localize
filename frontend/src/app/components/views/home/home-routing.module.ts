import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home.component';
import { EditarPerfilComponent } from '../editar-perfil/editar-perfil.component';
import { ExcluirPerfilComponent } from '../excluir-perfil/excluir-perfil.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'editar-perfil', component: EditarPerfilComponent },
  { path: 'excluir-perfil', component: ExcluirPerfilComponent }

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HomeRoutingModule { }
