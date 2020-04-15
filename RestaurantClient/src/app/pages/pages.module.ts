import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DishItemComponent } from './dish-list/dish-item/dish-item.component';
import { DishListComponent } from './dish-list/dish-list.component';
import { OrderItemComponent } from './order-list/order-item/order-item.component';
import { OrderListComponent } from './order-list/order-list.component';
import { HeaderComponent } from './header/header.component';
import { MainPageComponent } from './main-page/main-page.component';
import { PagesRoutingModule } from './pages-routing.module';



@NgModule({
  declarations: [
    HeaderComponent,
    OrderListComponent,
    OrderItemComponent,
    DishListComponent,
    DishItemComponent,
    MainPageComponent,
  ],
  imports: [
    CommonModule,
    PagesRoutingModule
  ]
})
export class PagesModule { }
