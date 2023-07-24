import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    loadChildren: () => import('./components/views/auth/auth.module')
      .then(m => m.AuthModule)
  },
  {
    path: 'home',
    loadChildren: () => import('./components/views/home/home.module')
      .then(m => m.HomeModule)
    },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
