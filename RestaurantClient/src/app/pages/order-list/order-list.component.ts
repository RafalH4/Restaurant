import { Component, OnInit, Input, OnChanges, DoCheck } from '@angular/core';
import { Dish } from 'src/app/models/dish.model';

@Component({
  selector: 'app-order-list',
  templateUrl: './order-list.component.html',
  styleUrls: ['./order-list.component.scss']
})
export class OrderListComponent implements DoCheck {

  constructor() { }

  dishes:Dish[] = []
  @Input() dish:Dish;

  ngDoCheck(): void {
    if(this.dish)
    this.dishes.push(this.dish)
  }

}
