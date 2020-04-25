import { Component, Input } from '@angular/core';
import { Dish } from 'src/app/models/dish.model';

interface OrderItem {
  dishId: number;
  quantity: number;
}

@Component({
  selector: 'app-order-list',
  templateUrl: './order-list.component.html',
  styleUrls: ['./order-list.component.scss']
})
export class OrderListComponent {
  constructor() { }

  @Input() dishes = new Map<Dish, number>();

  plusDish(dish) {
    this.dishes.set(dish, this.dishes.get(dish)+1)
  }
  
  minusDish(dish) {
    if(this.dishes.get(dish)==1)
      this.dishes.delete(dish);
    else
      this.dishes.set(dish, this.dishes.get(dish)-1)
  }

  submit(): void {
    const orderItems: OrderItem[] = [];
    // this.dishes => OrderItem[]
    console.log(orderItems);
    // this.service.order(orderItems)
  }
}
