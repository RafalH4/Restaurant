import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TestComponentComponent } from './test-component/test-component.component';
import { AuthGuardGuard } from './auth/services/auth-guard.guard';


const routes: Routes = [
  {
    path: '',
    loadChildren: () => import ('./pages/pages.module').then(m => m.PagesModule)

  },
  {
    path: 'test',
    component: TestComponentComponent,
    canActivate: [AuthGuardGuard]
  },
  {
    path: 'login',
    loadChildren: () => import('./auth/auth.module').then(m => m.AuthModule)
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
