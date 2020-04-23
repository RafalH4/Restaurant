import { Component, OnInit, Input, OnChanges, DoCheck } from '@angular/core';
import { Dish } from 'src/app/models/dish.model';

@Component({
  selector: 'app-order-list',
  templateUrl: './order-list.component.html',
  styleUrls: ['./order-list.component.scss']
})
export class OrderListComponent {

  constructor() { }


  @Input() dishes = new Map()

  plusDish(dish)
  {
    this.dishes.set(dish, this.dishes.get(dish)+1)
  }
  minusDish(dish)
  {
    if(this.dishes.get(dish)==1)
      this.dishes.delete(dish);
    else
      this.dishes.set(dish, this.dishes.get(dish)-1)
   }

}
