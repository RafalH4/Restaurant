import { Dish } from './dish.model';

export interface Order{
        dishList: Dish[],
        amount: number,
        firstName: string,
        secondName: string,
        adress: string

}