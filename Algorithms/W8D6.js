class ListNode {
    constructor(value) {
        this.value = value;
        this.next = null;
    }
}

class SinglyLinkedList {
    constructor() {
        this.head = null;
        this.tail = null;
    }

    addToBack(value) {
        var new_node = new ListNode(value);
        if (this.head == null) {
            this.head = new_node;
            this.tail = new_node;
        } else {
            this.tail.next = new_node;
            this.tail = new_node;
        }
    }

    display() {
        if (this.head == null) {
            return null;
        }
        var values = this.head.value;
        var runner = this.head.next;

        while (runner != null) {
            values += " - " + runner.value;
            runner = runner.next;
        }
        return values;
    }

    reverse() {
        let current = this.head;
        let next = null;
        let previous = null;
        while (current != null) {

            next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }
        this.head = previous;
    }
}


var new_sll = new SinglyLinkedList();
new_sll.addToBack("Disneyland");
new_sll.addToBack("Las Vegas");
new_sll.addToBack("Grand Canyon");
new_sll.addToBack("Times Square");
new_sll.addToBack("Mount Rushmore");
console.log(new_sll.display());

new_sll.reverse();
console.log(new_sll.display());

// Singly Linked List Reverse
// Write a method in your singly linked list class that reverses the order of a singly linked list
// Ex: if your current list has 2 -> 4 -> 8 -> 1 -> 5 then after it should be 5 -> 1 -> 8 -> 4 -> 2





// function reverseList() {
//     var currentNode = this.head;
//     var nextNode = this.head.next;
//     var prevNode = null;
//     if (!this.head || this.head.next == null) {
//         return this.head;
//     }


//     while (currentNode) {
//         nextNode = currentNode.next;
//         currentNode.next = prevNode;
//         prevNode = currentNode;
//         currentNode = nextNode;
//     }
//     this.head = prevNode;
// }

// SLList.reverseList(2, 4, 8, 1, 5);