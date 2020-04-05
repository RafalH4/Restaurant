import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { OrderListComponent } from './components/order-list/order-list.component';
import { OrderItemComponent } from './components/order-list/order-item/order-item.component';
import { DishListComponent } from './components/dish-list/dish-list.component';
import { DishItemComponent } from './components/dish-list/dish-item/dish-item.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    OrderListComponent,
    OrderItemComponent,
    DishListComponent,
    DishItemComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
