import { Component, OnInit } from '@angular/core';
import { Dish } from 'src/app/models/dish.model';

@Component({
  selector: 'app-dish-list',
  templateUrl: './dish-list.component.html',
  styleUrls: ['./dish-list.component.scss']
})
export class DishListComponent implements OnInit {

  dishes: Dish[] = [
    new Dish("Ruskie pierogi", "8 pierogów z ziemniakami", 10, "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Ruskie.jpg/330px-Ruskie.jpg"),
    new Dish("Schabowy", "Zestaw obiadowy: ziemniaki, schabowy, surówka", 20, "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6c/0003_kotlet_schabowy_2013%2C_photo_by_Silar.JPG/800px-0003_kotlet_schabowy_2013%2C_photo_by_Silar.JPG"),
    new Dish("Ruskie pierogi", "8 pierogów z ziemniakami", 10, "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Ruskie.jpg/330px-Ruskie.jpg"),
    new Dish("Schabowy", "Zestaw obiadowy: ziemniaki, schabowy, surówka", 20, "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6c/0003_kotlet_schabowy_2013%2C_photo_by_Silar.JPG/800px-0003_kotlet_schabowy_2013%2C_photo_by_Silar.JPG"),
    new Dish("Ruskie pierogi", "8 pierogów z ziemniakami", 10, "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Ruskie.jpg/330px-Ruskie.jpg"),
    new Dish("Schabowy", "Zestaw obiadowy: ziemniaki, schabowy, surówka", 20, "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6c/0003_kotlet_schabowy_2013%2C_photo_by_Silar.JPG/800px-0003_kotlet_schabowy_2013%2C_photo_by_Silar.JPG")
  
  ]
  constructor() { }

  ngOnInit(): void {
  }

}
