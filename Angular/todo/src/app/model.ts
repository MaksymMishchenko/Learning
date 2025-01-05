export class Model {
    user!: string
    items!: any
    constructor() {
        this.user = 'Adam',
            this.items = [new ToDoItems('Buy Flowers', true),
            new ToDoItems('Get Shoes', false),
            new ToDoItems('Collect Tickets', false),
            new ToDoItems('Call Joe', true)]
    }
}

export class ToDoItems {
    action!: string
    done!: string

    constructor(action: string, done: any) {
        this.action = action,
            this.done = done
    }
}