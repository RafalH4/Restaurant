import { Component, OnInit, Input } from '@angular/core';
import { Dish } from 'src/app/models/dish.model';

@Component({
  selector: 'app-main-page',
  templateUrl: './main-page.component.html',
  styleUrls: ['./main-page.component.scss']
})
export class MainPageComponent implements OnInit {

  constructor() { }

  dish;
  dishes = new Map()

  menu: Dish[] = [
    new Dish("Ruskie pierogi", "8 pierogów z ziemniakami", 10, "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Ruskie.jpg/330px-Ruskie.jpg"),
    new Dish("Schabowy", "Zestaw obiadowy: ziemniaki, schabowy, surówka", 20, "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6c/0003_kotlet_schabowy_2013%2C_photo_by_Silar.JPG/800px-0003_kotlet_schabowy_2013%2C_photo_by_Silar.JPG"),
    new Dish("Ruskie pierogi", "8 pierogów z ziemniakami", 10, "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Ruskie.jpg/330px-Ruskie.jpg"),
    new Dish("Schabowy", "Zestaw obiadowy: ziemniaki, schabowy, surówka", 20, "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6c/0003_kotlet_schabowy_2013%2C_photo_by_Silar.JPG/800px-0003_kotlet_schabowy_2013%2C_photo_by_Silar.JPG"),
    new Dish("Ruskie pierogi", "8 pierogów z ziemniakami", 10, "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Ruskie.jpg/330px-Ruskie.jpg"),
    new Dish("Schabowy", "Zestaw obiadowy: ziemniaki, schabowy, surówka", 20, "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6c/0003_kotlet_schabowy_2013%2C_photo_by_Silar.JPG/800px-0003_kotlet_schabowy_2013%2C_photo_by_Silar.JPG")
  ]
  ngOnInit(): void {
  }

  getDish(event) {
    if(!this.dishes.has(event))
      this.dishes.set(event, 1);
    else
      this.dishes.set(event, this.dishes.get(event)+1);
  }

}
