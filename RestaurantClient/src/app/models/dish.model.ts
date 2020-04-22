export class Dish{
    constructor(
        public name: string,
        public description: string,
        public price: number,
        public imgUrl: string,
        public amount: number=1
        ){}

    }