import { Component, OnInit, EventEmitter, Output, Input } from '@angular/core';
import { Dish } from 'src/app/models/dish.model';

@Component({
  selector: 'app-dish-list',
  templateUrl: './dish-list.component.html',
  styleUrls: ['./dish-list.component.scss']
})
export class DishListComponent implements OnInit {


  @Input() menu: Dish[];
  @Output() selectedDish = new EventEmitter()
  constructor() { }

  ngOnInit(): void {
  }
  orderDish(dish){
    this.selectedDish.emit(dish)
  }


}
