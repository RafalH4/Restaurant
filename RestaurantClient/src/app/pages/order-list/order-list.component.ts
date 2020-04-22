import { Component, OnInit, Input, OnChanges, DoCheck } from '@angular/core';
import { Dish } from 'src/app/models/dish.model';

@Component({
  selector: 'app-order-list',
  templateUrl: './order-list.component.html',
  styleUrls: ['./order-list.component.scss']
})
export class OrderListComponent implements DoCheck, OnChanges {

  constructor() { }
  ngDoCheck(): void {
    console.log()
  }

  dishes:Dish[]= []
  @Input() dish:Dish;

  ngOnChanges(): void {
    if(this.dish)
    {
      if(this.dishes.includes(this.dish))
      {
        let element = this.dishes.indexOf(this.dish);
        this.dishes[element].amount++;
      }
      else
      {
        this.dishes.push(this.dish)
      }
    }

   
  }
  plusDish(index)
  {
    this.dishes[index].amount++;
  }
  minusDish(index)
  {
    if(this.dishes[index].amount==1)
    {
      this.dishes.splice(index, 1)
    }
    else
    {
      this.dishes[index].amount--
    }
  }

}
