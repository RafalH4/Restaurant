import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Dish } from 'src/app/models/dish.model';

import { DishesDataAccessService } from '../services/dish-services.service';

@Component({
  selector: 'app-main-page',
  templateUrl: './main-page.component.html',
  styleUrls: ['./main-page.component.scss']
})
export class MainPageComponent implements OnInit {
  orderedDishes = new Map()
  menu$: Observable<Dish[]>

  // pola

  constructor(private dishesDataAccessService: DishesDataAccessService) {}

  // priv

  ngOnInit(): void {
    this.menu$ = this.dishesDataAccessService.getDishes();
  }
  
  onSelectedDish(dish: Dish): void {
    if(!this.orderedDishes.has(dish))
      this.orderedDishes.set(dish, 1);
    else
      this.orderedDishes.set(dish, this.orderedDishes.get(dish)+1);
  }

}
