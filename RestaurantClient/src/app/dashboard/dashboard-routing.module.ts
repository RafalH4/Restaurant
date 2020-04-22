import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { MainPageComponent } from './main-page/main-page.component';
import { DishesComponent } from './dishes/dishes.component';
import { UsersComponent } from './users/users.component';
import { OrdersComponent } from './orders/orders.component';


const routes: Routes = [
  {
    path: '',
    component: MainPageComponent,
    children: [  
      {
        path: 'dishes',
        component: DishesComponent
      },
      {
        path: 'orders',
        component: OrdersComponent
      },
      {
        path: 'users',
        component: UsersComponent
      },
    ]
  },
  {
    path: '**',
    component: UsersComponent
  },
  
]
@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ],
  exports: [
    RouterModule
  ]
})
export class DashboardRoutingModule { }
