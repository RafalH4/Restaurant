import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Dish } from 'src/app/models/dish.model';

@Injectable({
  providedIn: 'root'
})
export class DishesDataAccessService {

  /*
    api/dishes -> DishesDataAccessService
    api/orders -> OrdersDataAccessService
  */
  
  dishes: Dish[] = [
    {name: "Ruskie pierogi", description: "8 pierogów z ziemniakami", price: 10, imgUrl: "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Ruskie.jpg/330px-Ruskie.jpg"},
    {name: "Schabowy", description: "Zestaw obiadowy: ziemniaki, schabowy, surówka", price: 20, imgUrl: "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6c/0003_kotlet_schabowy_2013%2C_photo_by_Silar.JPG/800px-0003_kotlet_schabowy_2013%2C_photo_by_Silar.JPG"},
    {name: "Ruskie pierogi", description: "8 pierogów z ziemniakami", price: 10, imgUrl: "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Ruskie.jpg/330px-Ruskie.jpg"},
    {name: "Schabowy", description: "Zestaw obiadowy: ziemniaki, schabowy, surówka", price: 20, imgUrl: "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6c/0003_kotlet_schabowy_2013%2C_photo_by_Silar.JPG/800px-0003_kotlet_schabowy_2013%2C_photo_by_Silar.JPG"},
    {name: "Ruskie pierogi", description: "8 pierogów z ziemniakami", price: 10, imgUrl: "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Ruskie.jpg/330px-Ruskie.jpg"},
    {name: "Schabowy", description: "Zestaw obiadowy: ziemniaki, schabowy, surówka", price: 20, imgUrl: "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6c/0003_kotlet_schabowy_2013%2C_photo_by_Silar.JPG/800px-0003_kotlet_schabowy_2013%2C_photo_by_Silar.JPG"}
  ]
  
  constructor() { }

  getDishes(): Observable<Dish[]> {
    return of(this.dishes)
  }

  // postDish
}
