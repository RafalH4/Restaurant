import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DashboardRoutingModule } from './dashboard-routing.module';
import { MainPageComponent } from './main-page/main-page.component';
import { HeaderComponent } from './header/header.component';
import { NavigationComponent } from './navigation/navigation.component';
import { DishesComponent } from './dishes/dishes.component';
import { OrdersComponent } from './orders/orders.component';
import { UsersComponent } from './users/users.component';



@NgModule({
  declarations: [
    MainPageComponent, 
    HeaderComponent, 
    NavigationComponent, 
    DishesComponent, 
    OrdersComponent, 
    UsersComponent],
  imports: [
    CommonModule,
    DashboardRoutingModule
  ]
})
export class DashboardModule { }
