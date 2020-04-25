import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { DishListComponent } from './dish-list/dish-list.component';
import { HeaderComponent } from './header/header.component';
import { MainPageComponent } from './main-page/main-page.component';
import { OrderListComponent } from './order-list/order-list.component';
import { PagesRoutingModule } from './pages-routing.module';

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
