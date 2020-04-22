import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DishListComponent } from './dish-list/dish-list.component';
import { OrderListComponent } from './order-list/order-list.component';
import { HeaderComponent } from './header/header.component';
import { MainPageComponent } from './main-page/main-page.component';
import { PagesRoutingModule } from './pages-routing.module';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [
    HeaderComponent,
    OrderListComponent,
    DishListComponent,
    MainPageComponent,
  ],
  imports: [
    CommonModule,
    PagesRoutingModule,
    RouterModule
  ]
})
export class PagesModule { }
